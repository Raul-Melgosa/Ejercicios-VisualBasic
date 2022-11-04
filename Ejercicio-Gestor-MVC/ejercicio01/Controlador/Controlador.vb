Public Class Controlador
    Sub InsertarEmpleado(nombre As String, apellido1 As String, apellido2 As String)
        'Errores es una lista donde se guardan todos los errores que haya podido cometer el usuario
        Dim errores As String = ""
        If nombre.Trim.Length = 0 Then
            errores &= "Falta el nombre" & vbCrLf
        End If
        If apellido1.Trim.Length = 0 Then
            errores &= "Falta el primer apellido" & vbCrLf
        End If
        If apellido2.Trim.Length = 0 Then
            errores &= "Falta el segundo apellido" & vbCrLf
        End If

        'si ha habido errores lanzamos una excepción
        If errores <> "" Then
            Throw New Exception(errores)
        End If

        Dim empleado As New Empleado(nombre, apellido1, apellido2)

        'recorremos los departamentos para mirar si el empleado que queremos insertar
        'ya existe como jefe o esta en la lista de empleados
        'si es así, lanzamos una excepción
        For Each departamento In Datos.Empresa
            If departamento.Empleados.Contains(empleado) Or departamento.Jefe.Equals(empleado) Then
                Throw New Exception("La persona que intenta insertar ya esta en un departamento")
            End If
        Next

        'Si el empleado esta en la lista de empleados disponibles lanza una excepción
        If Datos.EmpDisponibles.Contains(empleado) Then
            Throw New Exception("La persona que intenta insertar ya esta en la lista de empleados disponibles.")
        End If

        'si no se ha dado ninguna excepción el empleado es insertado en la lista de empleados disponibles
        Datos.EmpDisponibles.Add(empleado)
    End Sub

    Sub InsertarDepartamento(nombre As String, jefe As Empleado, empleados As List(Of Empleado))
        If nombre.Length = 0 OrElse
        jefe.ToString().Length = 0 OrElse
        empleados.Count() = 0 Then
            Throw New Exception("Falta algún dato para poder insertar el departamento")
        End If
        Dim depart As New Departamento(nombre, jefe)

        'si ya existe un departamento con ese nombre no se inserta el departamento
        If Datos.Empresa.Contains(depart) Then
            Throw New Exception("Ese departamento ya existe")
        End If

        'si no ha habido ninguna excepción
        'insertamos el departamento
        Datos.Empresa.Add(depart)

        'insertamos en el Jefe el departamento al que pertenece
        jefe.Departamento = depart
        Datos.EmpDisponibles.Remove(jefe)

        'por cada empleado que tenemos en la lista de empleados:
        'al empleado le insertamos el departamento al que pertecene
        'insertamos el empleado en la lista del empleados del departamento
        'borramos el empleado de la lista de empleados disponibles
        For Each empleado In empleados
            empleado.Departamento = depart
            depart.InsertarEmpleado(empleado)
            Datos.EmpDisponibles.Remove(empleado)
        Next
    End Sub

    Function CargarDatosDepartamentos() As List(Of Empleado)
        Dim empDisponibles As New List(Of Empleado)
        For Each persona In Datos.EmpDisponibles
            empDisponibles.Add(persona)
        Next
        Return empDisponibles
    End Function

    Function CargarDatosEmpresa() As List(Of Departamento)
        Dim dept As New List(Of Departamento)
        For Each departamento In Datos.Empresa
            dept.Add(departamento)
        Next
        Return dept
    End Function

    Sub CargarDatosIniciales()
        Datos.CargarDatosIniciales()
    End Sub
End Class
