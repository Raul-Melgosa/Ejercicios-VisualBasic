Public Class Calculadora
    Property num1 As Double
    Property num2 As Double

    Public Sub New(num1 As Double, num2 As Double)
        Me.num1 = num1
        Me.num2 = num2
    End Sub

    Public Function Sumar()
        Return Me.num1 + Me.num2
    End Function

    Public Function Restar()
        Return Me.num1 - Me.num2
    End Function

    Public Function Multiplicar()
        Return Me.num1 * Me.num2
    End Function

    Public Function Dividir()
        Try
            Dim r = Me.num1 / Me.num2
            Return r
        Catch ex As Exception
            Dim r = "ERROR"
            Return r
        End Try
    End Function

    Public Function potencia()
        Return Me.num1 ^ Me.num2
    End Function
End Class
