Public Class Controller
    Dim calc As Calculadora

    Public Function operar(n1 As Double, n2 As Double, op As Form1.Operaciones)
        calc = New Calculadora(n1, n2)
        Dim r
        Select Case op
            Case Form1.Operaciones.Suma
                r = calc.Sumar()
            Case Form1.Operaciones.Resta
                r = calc.Restar()
            Case Form1.Operaciones.Multiplicacion
                r = calc.Multiplicar()
            Case Form1.Operaciones.Division
                If n2 = 0 Then
                    r = "ERROR"
                    MsgBox("No se puede dividir entre 0")
                    Exit Select
                End If
                r = calc.Dividir()
            Case Form1.Operaciones.Potencia
                r = calc.potencia()
        End Select

        Return r
    End Function
End Class
