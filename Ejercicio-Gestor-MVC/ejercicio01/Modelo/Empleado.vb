Public Class Empleado
    Property Nombre As String
    Property Apellido1 As String
    Property Apellido2 As String
    Property Departamento As Departamento

    Public Sub New(nombre As String, apellido1 As String, apellido2 As String, departamento As Departamento)
        _Nombre = nombre
        _Apellido1 = apellido1
        _Apellido2 = apellido2
        _Departamento = departamento
    End Sub

    Public Sub New(nombre As String, apellido1 As String, apellido2 As String)
        _Nombre = nombre
        _Apellido1 = apellido1
        _Apellido2 = apellido2
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1} {2}", Nombre, Apellido1, Apellido2)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim empleado = TryCast(obj, Empleado)
        Return empleado IsNot Nothing AndAlso
               _Nombre = empleado._Nombre AndAlso
               _Apellido1 = empleado._Apellido1 AndAlso
               _Apellido2 = empleado._Apellido2
    End Function
End Class
