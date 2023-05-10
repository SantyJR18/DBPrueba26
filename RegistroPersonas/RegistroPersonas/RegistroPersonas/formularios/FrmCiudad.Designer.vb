<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCiudad
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.DgvRegistrosC = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbActivo = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GbRegistros.SuspendLayout()
        CType(Me.DgvRegistrosC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnGuardar, Me.BtnNuevo, Me.BtnEditar, Me.BtnBorrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(402, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Image = Global.RegistroPersonas.My.Resources.Resources.guardar
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(24, 24)
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNuevo.Image = Global.RegistroPersonas.My.Resources.Resources.agregar_archivo
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(24, 24)
        Me.BtnNuevo.Text = "Agregar/Nuevo"
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.RegistroPersonas.My.Resources.Resources.editar
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(24, 24)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnBorrar.Image = Global.RegistroPersonas.My.Resources.Resources.borrar
        Me.BtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(24, 24)
        Me.BtnBorrar.Text = "Borrar"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.DgvRegistrosC)
        Me.GbRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbRegistros.Location = New System.Drawing.Point(11, 191)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(2)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(2)
        Me.GbRegistros.Size = New System.Drawing.Size(377, 143)
        Me.GbRegistros.TabIndex = 1
        Me.GbRegistros.TabStop = False
        Me.GbRegistros.Text = "Registros almacenados: "
        '
        'DgvRegistrosC
        '
        Me.DgvRegistrosC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistrosC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRegistrosC.Location = New System.Drawing.Point(2, 14)
        Me.DgvRegistrosC.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvRegistrosC.Name = "DgvRegistrosC"
        Me.DgvRegistrosC.RowHeadersWidth = 51
        Me.DgvRegistrosC.RowTemplate.Height = 24
        Me.DgvRegistrosC.Size = New System.Drawing.Size(373, 127)
        Me.DgvRegistrosC.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbActivo)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 41)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(375, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ciudad"
        '
        'CbActivo
        '
        Me.CbActivo.AutoSize = True
        Me.CbActivo.Location = New System.Drawing.Point(205, 34)
        Me.CbActivo.Margin = New System.Windows.Forms.Padding(2)
        Me.CbActivo.Name = "CbActivo"
        Me.CbActivo.Size = New System.Drawing.Size(62, 17)
        Me.CbActivo.TabIndex = 4
        Me.CbActivo.Text = "Activo"
        Me.CbActivo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(61, 72)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 19)
        Me.txtNombre.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(61, 35)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 19)
        Me.txtID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 349)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbRegistros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCiudad"
        Me.Text = "Gestión de Ciudades"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.DgvRegistrosC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnBorrar As ToolStripButton
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents DgvRegistrosC As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbActivo As CheckBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
