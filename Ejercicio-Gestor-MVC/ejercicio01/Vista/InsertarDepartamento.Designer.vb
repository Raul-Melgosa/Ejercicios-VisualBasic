<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarDepartamento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlpDepartamento = New System.Windows.Forms.TableLayoutPanel()
        Me.lNombreDep = New System.Windows.Forms.Label()
        Me.lNombreJefe = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.cbJefe = New System.Windows.Forms.ComboBox()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.bGuardarDep = New System.Windows.Forms.Button()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tlpDepartamento.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpDepartamento
        '
        Me.tlpDepartamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpDepartamento.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDepartamento.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDepartamento.Controls.Add(Me.lNombreDep, 0, 0)
        Me.tlpDepartamento.Controls.Add(Me.lNombreJefe, 0, 1)
        Me.tlpDepartamento.Controls.Add(Me.tbNombre, 1, 0)
        Me.tlpDepartamento.Controls.Add(Me.cbJefe, 1, 1)
        Me.tlpDepartamento.Controls.Add(Me.dgEmpleados, 0, 2)
        Me.tlpDepartamento.Controls.Add(Me.bGuardarDep, 0, 3)
        Me.tlpDepartamento.Location = New System.Drawing.Point(0, 0)
        Me.tlpDepartamento.Name = "tlpDepartamento"
        Me.tlpDepartamento.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDepartamento.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDepartamento.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDepartamento.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDepartamento.Size = New System.Drawing.Size(640, 400)
        Me.tlpDepartamento.TabIndex = 0
        '
        'lNombreDep
        '
        Me.lNombreDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNombreDep.Location = New System.Drawing.Point(10, 10)
        Me.lNombreDep.Margin = New System.Windows.Forms.Padding(10)
        Me.lNombreDep.Name = "lNombreDep"
        Me.lNombreDep.Size = New System.Drawing.Size(300, 20)
        Me.lNombreDep.TabIndex = 0
        Me.lNombreDep.Text = "Nombre del departamento:"
        Me.lNombreDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lNombreJefe
        '
        Me.lNombreJefe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNombreJefe.Location = New System.Drawing.Point(10, 50)
        Me.lNombreJefe.Margin = New System.Windows.Forms.Padding(10)
        Me.lNombreJefe.Name = "lNombreJefe"
        Me.lNombreJefe.Size = New System.Drawing.Size(300, 21)
        Me.lNombreJefe.TabIndex = 1
        Me.lNombreJefe.Text = "Nombre del Jef@ del departamento:"
        Me.lNombreJefe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbNombre
        '
        Me.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNombre.Location = New System.Drawing.Point(330, 10)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(10)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(300, 20)
        Me.tbNombre.TabIndex = 2
        '
        'cbJefe
        '
        Me.cbJefe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbJefe.FormattingEnabled = True
        Me.cbJefe.Location = New System.Drawing.Point(330, 50)
        Me.cbJefe.Margin = New System.Windows.Forms.Padding(10)
        Me.cbJefe.Name = "cbJefe"
        Me.cbJefe.Size = New System.Drawing.Size(300, 21)
        Me.cbJefe.TabIndex = 3
        '
        'dgEmpleados
        '
        Me.dgEmpleados.AllowUserToAddRows = False
        Me.dgEmpleados.AllowUserToDeleteRows = False
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empleado, Me.seleccionado})
        Me.tlpDepartamento.SetColumnSpan(Me.dgEmpleados, 2)
        Me.dgEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEmpleados.Location = New System.Drawing.Point(10, 91)
        Me.dgEmpleados.Margin = New System.Windows.Forms.Padding(10)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(620, 270)
        Me.dgEmpleados.TabIndex = 4
        '
        'bGuardarDep
        '
        Me.bGuardarDep.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.tlpDepartamento.SetColumnSpan(Me.bGuardarDep, 2)
        Me.bGuardarDep.Location = New System.Drawing.Point(282, 374)
        Me.bGuardarDep.Name = "bGuardarDep"
        Me.bGuardarDep.Size = New System.Drawing.Size(75, 23)
        Me.bGuardarDep.TabIndex = 5
        Me.bGuardarDep.Text = "Guardar"
        Me.bGuardarDep.UseVisualStyleBackColor = True
        '
        'empleado
        '
        Me.empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.empleado.HeaderText = "Emplead@"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'seleccionado
        '
        Me.seleccionado.HeaderText = ""
        Me.seleccionado.Name = "seleccionado"
        Me.seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.seleccionado.Width = 50
        '
        'InsertarDepartamento
        '
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpDepartamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InsertarDepartamento"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.tlpDepartamento.ResumeLayout(False)
        Me.tlpDepartamento.PerformLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpDepartamento As TableLayoutPanel
    Friend WithEvents lNombreDep As Label
    Friend WithEvents lNombreJefe As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents cbJefe As ComboBox
    Friend WithEvents dgEmpleados As DataGridView
    Friend WithEvents bGuardarDep As Button
    Friend WithEvents empleado As DataGridViewTextBoxColumn
    Friend WithEvents seleccionado As DataGridViewCheckBoxColumn
End Class
