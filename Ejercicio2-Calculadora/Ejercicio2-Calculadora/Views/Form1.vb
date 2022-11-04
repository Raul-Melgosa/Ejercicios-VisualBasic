Imports Ejercicio2_Calculadora.Controller

Public Class Form1
    Dim controller = New Controller()

    Enum Operaciones
        Suma
        Resta
        Multiplicacion
        Division
        Potencia
    End Enum
    Private Sub changeResult(newResult As Double)
        tbResultado.Text = newResult
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        changeResult(controller.operar(nudNum1.Value, nudNum2.Value, Operaciones.Suma))
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        changeResult(controller.operar(nudNum1.Value, nudNum2.Value, Operaciones.Resta))
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        changeResult(controller.operar(nudNum1.Value, nudNum2.Value, Operaciones.Multiplicacion))
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        tbResultado.Text = controller.operar(nudNum1.Value, nudNum2.Value, Operaciones.Division)
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        changeResult(controller.operar(nudNum1.Value, nudNum2.Value, Operaciones.Potencia))
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbResultado.Text = ""
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim pixels As Integer = 42.5 * (Me.Size.Width / 100)
        resizeWidth(pixels)

        Dim nudFontSize As Double = Me.Width * 15.75 / 400
        Dim labelFontSize As Double = Me.Width * 10 / 400
        Dim textBoxFontSize As Double = Me.Width * 14 / 400
        Dim buttonFontSize As Double = Me.Width * 18 / 400

        If nudFontSize > 40 Then
            nudFontSize = 40
        End If

        If labelFontSize > 40 Then
            labelFontSize = 40
        End If

        If textBoxFontSize > 40 Then
            textBoxFontSize = 40
        End If

        If buttonFontSize > 40 Then
            buttonFontSize = 40
        End If

        Dim labels As Font = New System.Drawing.Font("Microsoft Sans Serif", labelFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim buttons As Font = New System.Drawing.Font("Microsoft Sans Serif", buttonFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim nuds As Font = New System.Drawing.Font("Microsoft Sans Serif", nudFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        lbPrimerOperador.Font = labels
        lbSegundoOperador.Font = labels
        lbResultado.Font = labels
        btnClear.Font = buttons
        btnDividir.Font = buttons
        btnMultiplicar.Font = buttons
        btnPower.Font = buttons
        btnRestar.Font = buttons
        btnSumar.Font = buttons
        tbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", textBoxFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        nudNum1.Font = nuds
        nudNum2.Font = nuds
    End Sub

    Private Sub resizeWidth(pixels As Integer)
        tbResultado.Width = pixels
        nudNum1.Width = pixels
        nudNum2.Width = pixels
    End Sub
End Class
