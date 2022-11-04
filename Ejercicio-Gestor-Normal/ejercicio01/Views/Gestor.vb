Public Class Gestor
    Dim insertarDep As InsertarDepartamento
    Dim insertarEmp As InsertarEmpleado
    Dim verEmp As VerEmpresa
    Property Empresa As New List(Of Departamento)
    Property EmpDisponibles As New List(Of Empleado)

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Como GetInstance es de tipo Shared no necesitamos una instancia de objeto para poder usarla
        'Simplemente la usamos con el nombre de la clase a la que pertenece
        insertarDep = InsertarDepartamento.GetInstance()

        'CargarFormulario carga el formulario en el panel1
        CargarFormulario(insertarDep)

        'CargarDatos carga los datos de los empleados disponibles en el combobox y datagrid
        'del formulario insertarDep
        insertarDep.CargarDatos()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'Como GetInstance es de tipo Shared no necesitamos una instancia de objeto para poder usarla
        'Simplemente la usamos con el nombre de la clase a la que pertenece
        insertarEmp = InsertarEmpleado.GetInstance()

        'CargarFormulario carga el formulario en el panel1
        CargarFormulario(insertarEmp)
    End Sub
    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        'Como GetInstance es de tipo Shared no necesitamos una instancia de objeto para poder usarla
        'Simplemente la usamos con el nombre de la clase a la que pertenece
        verEmp = VerEmpresa.GetInstance()

        'CargarFormulario carga el formulario en el panel1
        CargarFormulario(verEmp)

        'CargarDatos carga los datos de los diferentes departamentos
        'En el flowPanelLayout del formulario verEmp
        verEmp.CargarDatos()
    End Sub
    Private Sub CargarFormulario(formulario As Form)
        'Borra los controles que pudiera haber en el Panel1
        Panel1.Controls.Clear()

        'El formulario que queremos cargar no sera de nivel superior
        formulario.TopLevel = False

        'Añadimos el formulario a los controles del Panel1
        Panel1.Controls.Add(formulario)

        formulario.Dock = System.Windows.Forms.DockStyle.Fill
        'Muestra el formulario
        formulario.Show()
    End Sub
    Private Sub Gestor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

End Class
