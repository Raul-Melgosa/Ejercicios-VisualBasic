<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarEmpleado
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
        Me.tlpEmpleado = New System.Windows.Forms.TableLayoutPanel()
        Me.tbApellido2 = New System.Windows.Forms.TextBox()
        Me.tbApellido1 = New System.Windows.Forms.TextBox()
        Me.lNombreEmp = New System.Windows.Forms.Label()
        Me.lApe1Emp = New System.Windows.Forms.Label()
        Me.lApe2Emp = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.bGuardarEmp = New System.Windows.Forms.Button()
        Me.tlpEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpEmpleado
        '
        Me.tlpEmpleado.ColumnCount = 4
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpEmpleado.Controls.Add(Me.tbApellido2, 2, 3)
        Me.tlpEmpleado.Controls.Add(Me.tbApellido1, 2, 2)
        Me.tlpEmpleado.Controls.Add(Me.lNombreEmp, 1, 1)
        Me.tlpEmpleado.Controls.Add(Me.lApe1Emp, 1, 2)
        Me.tlpEmpleado.Controls.Add(Me.lApe2Emp, 1, 3)
        Me.tlpEmpleado.Controls.Add(Me.tbNombre, 2, 1)
        Me.tlpEmpleado.Controls.Add(Me.bGuardarEmp, 1, 4)
        Me.tlpEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.tlpEmpleado.Margin = New System.Windows.Forms.Padding(50)
        Me.tlpEmpleado.Name = "tlpEmpleado"
        Me.tlpEmpleado.RowCount = 6
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmpleado.Size = New System.Drawing.Size(640, 400)
        Me.tlpEmpleado.TabIndex = 0
        '
        'tbApellido2
        '
        Me.tbApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbApellido2.Location = New System.Drawing.Point(174, 208)
        Me.tbApellido2.Margin = New System.Windows.Forms.Padding(10)
        Me.tbApellido2.Name = "tbApellido2"
        Me.tbApellido2.Size = New System.Drawing.Size(402, 20)
        Me.tbApellido2.TabIndex = 6
        '
        'tbApellido1
        '
        Me.tbApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbApellido1.Location = New System.Drawing.Point(174, 168)
        Me.tbApellido1.Margin = New System.Windows.Forms.Padding(10)
        Me.tbApellido1.Name = "tbApellido1"
        Me.tbApellido1.Size = New System.Drawing.Size(402, 20)
        Me.tbApellido1.TabIndex = 5
        '
        'lNombreEmp
        '
        Me.lNombreEmp.AutoSize = True
        Me.lNombreEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNombreEmp.Location = New System.Drawing.Point(62, 128)
        Me.lNombreEmp.Margin = New System.Windows.Forms.Padding(10)
        Me.lNombreEmp.Name = "lNombreEmp"
        Me.lNombreEmp.Size = New System.Drawing.Size(92, 20)
        Me.lNombreEmp.TabIndex = 0
        Me.lNombreEmp.Text = "Nombre:"
        Me.lNombreEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lApe1Emp
        '
        Me.lApe1Emp.AutoSize = True
        Me.lApe1Emp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lApe1Emp.Location = New System.Drawing.Point(62, 168)
        Me.lApe1Emp.Margin = New System.Windows.Forms.Padding(10)
        Me.lApe1Emp.Name = "lApe1Emp"
        Me.lApe1Emp.Size = New System.Drawing.Size(92, 20)
        Me.lApe1Emp.TabIndex = 1
        Me.lApe1Emp.Text = "Primer apellido:"
        Me.lApe1Emp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lApe2Emp
        '
        Me.lApe2Emp.AutoSize = True
        Me.lApe2Emp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lApe2Emp.Location = New System.Drawing.Point(62, 208)
        Me.lApe2Emp.Margin = New System.Windows.Forms.Padding(10)
        Me.lApe2Emp.Name = "lApe2Emp"
        Me.lApe2Emp.Size = New System.Drawing.Size(92, 20)
        Me.lApe2Emp.TabIndex = 2
        Me.lApe2Emp.Text = "Segundo apellido:"
        Me.lApe2Emp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbNombre
        '
        Me.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNombre.Location = New System.Drawing.Point(174, 128)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(10)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(402, 20)
        Me.tbNombre.TabIndex = 4
        '
        'bGuardarEmp
        '
        Me.bGuardarEmp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tlpEmpleado.SetColumnSpan(Me.bGuardarEmp, 2)
        Me.bGuardarEmp.Location = New System.Drawing.Point(281, 248)
        Me.bGuardarEmp.Margin = New System.Windows.Forms.Padding(10)
        Me.bGuardarEmp.Name = "bGuardarEmp"
        Me.bGuardarEmp.Size = New System.Drawing.Size(75, 23)
        Me.bGuardarEmp.TabIndex = 8
        Me.bGuardarEmp.Text = "Guardar"
        Me.bGuardarEmp.UseVisualStyleBackColor = True
        '
        'InsertarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.tlpEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InsertarEmpleado"
        Me.Text = "InsertarEmpleado"
        Me.tlpEmpleado.ResumeLayout(False)
        Me.tlpEmpleado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEmpleado As TableLayoutPanel
    Friend WithEvents tbApellido2 As TextBox
    Friend WithEvents tbApellido1 As TextBox
    Friend WithEvents lNombreEmp As Label
    Friend WithEvents lApe1Emp As Label
    Friend WithEvents lApe2Emp As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents bGuardarEmp As Button
End Class
