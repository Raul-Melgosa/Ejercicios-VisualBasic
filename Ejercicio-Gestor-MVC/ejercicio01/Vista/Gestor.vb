Public Class Gestor
    Dim insertarDep As InsertarDepartamento
    Dim insertarEmp As InsertarEmpleado
    Dim verEmp As VerEmpresa
    Property miControlador As New Controlador
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
        miControlador.CargarDatosIniciales()
    End Sub

End Class
