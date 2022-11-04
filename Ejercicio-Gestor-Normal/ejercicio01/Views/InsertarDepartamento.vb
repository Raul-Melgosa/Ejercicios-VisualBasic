Public Class InsertarDepartamento
    Dim tamFuente As Double

    Private Shared formu As InsertarDepartamento
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo InsertarDepartamento
    'Si no hay una instancia se crea.
    'Devuelve formu, que sera la instancia del formulario
    Public Shared Function GetInstance() As InsertarDepartamento
        If formu Is Nothing Then
            formu = New InsertarDepartamento()
        End If
        Return formu
    End Function

    Private Sub bGuardarDep_Click(sender As Object, e As EventArgs) Handles bGuardarDep.Click
        'empleados es una lista que guarda los indices de los empleados
        'que estan seleccionados en el datagrid
        Dim empleados As New List(Of Integer)

        Dim depart As Departamento
        'Usamos el for para rellenar la lista de indices
        'Para ello recorremos las filas del datagrid y si el checkbox esta a true lo insertamos
        'insertamos de la última fila a la primera para que al eliminar empleados de la lista
        'de empleados disponibles no cambien las posiciones de los empleados de arriba
        For i As Integer = dgEmpleados.Rows.Count - 1 To 0 Step -1
            If dgEmpleados.Item(1, i).Value Then empleados.Add(i)
        Next

        If tbNombre.Text.Length = 0 OrElse
        tbNombre.Text.Length = 0 OrElse
        empleados.Count() = 0 Then
            MsgBox("Falta algún dato para poder insertar el departamento", MsgBoxStyle.OkOnly OrElse MsgBoxStyle.DefaultButton1, "Faltan datos")
            tbNombre.Focus()
        Else
            depart = New Departamento(tbNombre.Text, cbJefe.SelectedItem)

            'si ya existe un departamento con ese nombre no se inserta el departamento
            If Gestor.Empresa.Contains(depart) Then
                MsgBox("Ese departamento ya existe", MsgBoxStyle.OkOnly OrElse MsgBoxStyle.DefaultButton1, "Ya existe")
            Else
                'insertamos el departamento
                Gestor.Empresa.Add(depart)

                'insertamos en el Jefe el departamento al que pertenece
                cbJefe.SelectedItem.departamento = depart

                'por cada indice que tenemos en la lista de empleados:
                'al empleado le insertamos el departamento al que pertecene
                'insertamos el empleado que tiene ese indice en la lista del empleados del departamento
                'borramos el empleado de la lista de empleados disponibles
                For Each posPersona In empleados
                    Gestor.EmpDisponibles(posPersona).Departamento = depart
                    depart.InsertarEmpleado(Gestor.EmpDisponibles(posPersona))
                    Gestor.EmpDisponibles.RemoveAt(posPersona)
                Next

                'Eliminamos al jefe de la lista de empleados disponibles
                'Lo hacemos en este momento, porque si no la lista de empleados disponibles cambia
                'antes de insertar los empleados en la lista
                Gestor.EmpDisponibles.Remove(cbJefe.SelectedItem)

                'Vaciamos los datos para poder volver a insertar un departamento
                tbNombre.Text = ""
                cbJefe.Text = ""
                For i As Integer = 0 To dgEmpleados.Rows.Count - 1
                    dgEmpleados.Item(1, i).Value = False
                Next
                CargarDatos()
            End If

        End If
    End Sub
    Sub CargarDatos()
        'Borramos los datos que teniamos tanto en el combobox como en el datagrid
        cbJefe.Items.Clear()
        dgEmpleados.Rows.Clear()

        'Rellenamos el combobox y el datagrid con los datos de los empleados disponibles
        For Each persona In Gestor.EmpDisponibles
            cbJefe.Items.Add(persona)
            dgEmpleados.Rows.Add(persona.ToString())
        Next
    End Sub

    Private Sub InsertarDepartamento_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Cambia el tamaño de fuente en proporción al cambio de ancho y alto
        '8.25 es el tamaño de fuente que va a tener este formulario al inicio
        tamFuente = Me.Width * 8.25 / 646 '646 es el ancho que tiene el formulario al inicio
        tamFuente = Me.Height * 8.25 / 404 '404 es la altura que tiene el formulario al inicio

        'Limita a 12 el tamaño de fuente
        tamFuente = IIf(tamFuente > 12, 12, tamFuente)

        'Asigna el nuevo tamaño de fuente a todos los controles del tableLayoutPanel
        For Each departamento In tlpDepartamento.Controls
            departamento.Font = New System.Drawing.Font("Segoe UI", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next
    End Sub

    Private Sub cbJefe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJefe.SelectedIndexChanged
        Dim posicion As Integer = cbJefe.SelectedIndex

        'Cuando seleccionamos un jefe, le cambiamos el estilo en el datagrid
        'para que no pueda ser seleccionado
        For i As Integer = 0 To dgEmpleados.Rows.Count - 1

            'Estilo de la row del datagrid donde aparece el jefe
            If i = posicion Then
                dgEmpleados.Rows(i).ReadOnly = True
                dgEmpleados.Rows(i).DefaultCellStyle.ForeColor = SystemColors.GrayText
                dgEmpleados.Rows(i).DefaultCellStyle.BackColor = SystemColors.GrayText
                dgEmpleados.Item(1, i).Value = False
                'Estilo del resto de rows
            Else
                dgEmpleados.Rows(i).ReadOnly = False
                dgEmpleados.Rows(i).DefaultCellStyle.ForeColor = SystemColors.ControlText
                dgEmpleados.Rows(i).DefaultCellStyle.BackColor = Color.White
            End If
        Next

    End Sub
End Class