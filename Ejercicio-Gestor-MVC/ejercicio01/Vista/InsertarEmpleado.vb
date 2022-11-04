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
        'Si falta algún dato ponemos el fondo en rojo y el cursor en su textbox
        If tbApellido2.Text.Trim.Length = 0 Then
            tbApellido2.BackColor = Color.Red
            tbApellido2.Focus()
        End If
        If tbApellido1.Text.Trim.Length = 0 Then
            tbApellido1.BackColor = Color.Red
            tbApellido1.Focus()
        End If
        If tbNombre.Text.Trim.Length = 0 Then
            tbNombre.BackColor = Color.Red
            tbNombre.Focus()
        End If

        'Intentamos insertar el empleado.
        Try
            Gestor.miControlador.InsertarEmpleado(tbNombre.Text, tbApellido1.Text, tbApellido2.Text)
            tbApellido1.Text = ""
            tbApellido1.BackColor = Color.White
            tbApellido2.Text = ""
            tbApellido2.BackColor = Color.White
            tbNombre.Text = ""
            tbNombre.BackColor = Color.White
            tbNombre.Focus()
            MsgBox("Empleado insertado", Title:="Insercción empleado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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