Public Class Departamento
    Property Nombre As String
    Property Jefe As Empleado
    Property Empleados As List(Of Empleado)

    Sub New(nombre As String, jefe As Empleado)
        _Nombre = nombre
        _Jefe = jefe
    End Sub

    Sub InsertarEmpleado(miEmpleado As Empleado)
        If _Empleados Is Nothing Then
            _Empleados = New List(Of Empleado)
        End If
        _Empleados.Add(miEmpleado)
    End Sub

    Public Overrides Function ToString() As String
        Dim miDepartamento As String
        Dim i As Integer = 1
        miDepartamento = String.Format("Nombre del departamento: {0}
Nombre del jef@: {1}
", _Nombre, _Jefe.ToString())
        For Each empleado In _Empleados
            miDepartamento &= String.Format("{0,5}.{1}
", i, empleado.ToString())
            i += 1
        Next
        Return miDepartamento
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim departamento = TryCast(obj, Departamento)
        Return departamento IsNot Nothing AndAlso
               Nombre = departamento.Nombre
    End Function
End Class
