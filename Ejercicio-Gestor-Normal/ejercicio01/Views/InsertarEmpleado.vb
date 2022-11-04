Public Class InsertarEmpleado
    Dim tamFuente As Double
    Private Shared formu As InsertarEmpleado
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo InsertarDepartamento
    'Si no hay una instancia se crea.
    'Devuelve formu, que sera la instancia del formulario
    Public Shared Function GetInstance() As InsertarEmpleado
        If formu Is Nothing Then
            formu = New InsertarEmpleado()
        End If
        Return formu
    End Function
    Private Sub bGuardarEmp_Click(sender As Object, e As EventArgs) Handles bGuardarEmp.Click
        Dim empleado As Empleado
        'Errores es una lista donde se guardan todos los errores que haya podido cometer el usuario
        Dim errores As String = ""
        If tbApellido2.Text.Trim.Length = 0 Then
            errores &= "Falta el segundo apellido" & vbCrLf
            tbApellido2.BackColor = Color.Red
            tbApellido2.Focus()
        End If
        If tbApellido1.Text.Trim.Length = 0 Then
            errores &= "Falta el primer apellido" & vbCrLf
            tbApellido2.BackColor = Color.Red
            tbApellido1.Focus()
        End If
        If tbNombre.Text.Trim.Length = 0 Then
            errores &= "Falta el nombre" & vbCrLf
            tbApellido2.BackColor = Color.Red
            tbNombre.Focus()
        End If

        'Si no hay errores se inserta el empleado
        If errores <> "" Then
            MsgBox(errores, MsgBoxStyle.OkOnly OrElse MsgBoxStyle.DefaultButton1, "Faltan datos")
        Else
            empleado = New Empleado(tbNombre.Text, tbApellido1.Text, tbApellido2.Text)
            'recorremos los departamentos para mirar si el empleado que queremos insertar
            'ya existe como jefe o esta en la lista de empleados
            Dim existe As Boolean = False
            For Each departamento In Gestor.Empresa
                If departamento.Empleados.Contains(empleado) Or departamento.Jefe.Equals(empleado) Then
                    existe = True
                    MsgBox("La persona que intenta insertar ya esta en un departamento", MsgBoxStyle.OkOnly OrElse MsgBoxStyle.DefaultButton1, "Persona existente")
                End If
            Next
            'Si el empleado no esta en ningún departamento ni en la lista de empleados disponibles
            'lo insertamos en la lista de empleados disponibles
            If Not Gestor.EmpDisponibles.Contains(empleado) AndAlso Not existe Then
                Gestor.EmpDisponibles.Add(empleado)
                tbApellido1.Text = ""
                tbApellido2.Text = ""
                tbNombre.Text = ""
                tbNombre.Focus()
                Gestor.tssEstado.Text = "Empleado insertado"
            Else
                MsgBox("La persona que intenta insertar ya esta en la lista de empleados disponibles.", MsgBoxStyle.OkOnly OrElse MsgBoxStyle.DefaultButton1, "Persona existente")
            End If
        End If
    End Sub
    Private Sub InsertarDepartamento_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Cambia el tamaño de fuente en proporción al cambio de ancho y alto
        '8.25 es el tamaño de fuente que va a tener este formulario al inicio
        tamFuente = Me.Width * 8.25 / 646 '646 es el ancho que tiene el formulario al inicio
        tamFuente = Me.Height * 8.25 / 404 '404 es la altura que tiene el formulario al inicio

        'Limita a 12 el tamaño de fuente
        tamFuente = IIf(tamFuente > 12, 12, tamFuente)

        'Asigna el nuevo tamaño de fuente a todos los controles del tableLayoutPanel
        For Each departamento In tlpEmpleado.Controls
            departamento.Font = New System.Drawing.Font("Segoe UI", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next
    End Sub
End Class