Public Class VerEmpresa
    Dim tamFuente As Double
    Private Shared formu As VerEmpresa
    'Usamos la función Shared para poder acceder a ella sin necesidad
    'de instanciar un objeto de tipo VerEmpresa
    'Si no hay una instancia se crea.
    'Devuelve formu, que sera la instancia del formulario
    Public Shared Function GetInstance() As VerEmpresa
        If formu Is Nothing Then
            formu = New VerEmpresa()
        End If
        Return formu
    End Function
    Sub CargarDatos()
        flDepartamentos.Controls.Clear()
        For Each departamento In Gestor.Empresa
            Dim lDepartamento As New Label
            flDepartamentos.Controls.Add(lDepartamento)
            lDepartamento.AutoSize = True
            lDepartamento.MinimumSize = New System.Drawing.Size(Me.Width - 25, 50)
            lDepartamento.Margin = New System.Windows.Forms.Padding(10)
            lDepartamento.Padding = New System.Windows.Forms.Padding(5)
            lDepartamento.BorderStyle = BorderStyle.FixedSingle
            lDepartamento.Text = departamento.ToString
            CambiarTamaño()
            lDepartamento.Font = New System.Drawing.Font("Segoe UI", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next
    End Sub

    Private Sub flDepartamentos_Resize(sender As Object, e As EventArgs) Handles flDepartamentos.Resize
        CambiarTamaño()
        flDepartamentos.Width = Me.Width
        For Each departamento In flDepartamentos.Controls
            departamento.MinimumSize = New System.Drawing.Size(Me.Width - 35, 50)
            departamento.Font = New System.Drawing.Font("Segoe UI", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next
    End Sub

    Private Sub CambiarTamaño()
        tamFuente = Me.Width * 10 / 646
        tamFuente = Me.Height * 10 / 404
        tamFuente = IIf(tamFuente > 16, 16, tamFuente)
    End Sub

End Class