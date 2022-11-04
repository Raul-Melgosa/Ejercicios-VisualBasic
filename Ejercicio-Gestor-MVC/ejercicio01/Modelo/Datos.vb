Module Datos
    Property Empresa As New List(Of Departamento)
    Property EmpDisponibles As New List(Of Empleado)

    Sub CargarDatosIniciales()
        'Inicializo la aplicación con datos
        EmpDisponibles.Add(New Empleado("maider", "díaz", "salinas"))
        EmpDisponibles.Add(New Empleado("david", "pérez", "goikoetxea"))
        EmpDisponibles.Add(New Empleado("paco", "lapatza", "soria"))
        EmpDisponibles.Add(New Empleado("luis", "gonzalez", "uzquiano"))
        EmpDisponibles.Add(New Empleado("maria", "de la presa", "rubia"))
        EmpDisponibles.Add(New Empleado("marta", "ortiz", "bengoetxea"))
        EmpDisponibles.Add(New Empleado("asunción", "saenz", "areta"))
        EmpDisponibles.Add(New Empleado("alberto", "moraza", "velasco"))
        Empresa.Add(New Departamento("producción", New Empleado("leire", "moraza", "blanco")))
        Empresa.Last.InsertarEmpleado(New Empleado("juan", "perez", "gracianteparaluceta"))
        Empresa.Last.InsertarEmpleado(New Empleado("luisa", "gil", "garcía"))
        Empresa.Add(New Departamento("almacen", New Empleado("maika", "sanz", "ruíz")))
        Empresa.Last.InsertarEmpleado(New Empleado("itziar", "medina", "escudero"))
        Empresa.Last.InsertarEmpleado(New Empleado("itxaso", "castro", "ortiz"))
        Empresa.Add(New Departamento("administración", New Empleado("iker", "areta", "uzquiano")))
        Empresa.Last.InsertarEmpleado(New Empleado("ibon", "martínez", "mondoño"))
    End Sub
End Module
