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
        'empleados es una lista que guarda los empleados que estan seleccionados en el datagrid
        Dim empleados As New List(Of Empleado)

        'Usamos el for para rellenar la lista de indices
        'Para ello recorremos las filas del datagrid y si el checkbox esta a true lo insertamos
        For i As Integer = 0 To dgEmpleados.Rows.Count - 1 'To 0 Step -1
            If dgEmpleados.Item(1, i).Value Then empleados.Add(dgEmpleados.Item(0, i).Value)
        Next
        Try
            Gestor.miControlador.InsertarDepartamento(tbNombre.Text, cbJefe.SelectedItem, empleados)
            Gestor.tssEstado.Text = "Departamento insertado"
            tbNombre.Text = ""
            cbJefe.Text = ""
            For i As Integer = 0 To dgEmpleados.Rows.Count - 1
                dgEmpleados.Item(1, i).Value = False
            Next
            CargarDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CargarDatos()
        'Borramos los datos que teniamos tanto en el combobox como en el datagrid
        cbJefe.Items.Clear()
        dgEmpleados.Rows.Clear()
        Dim empDisponibles As List(Of Empleado) = Gestor.miControlador.CargarDatosDepartamentos()
        'Rellenamos el combobox y el datagrid con los datos de los empleados disponibles
        For Each persona In empDisponibles
            cbJefe.Items.Add(persona)
            dgEmpleados.Rows.Add(persona)
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