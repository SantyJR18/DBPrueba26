<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim PrimerNombreLabel As System.Windows.Forms.Label
        Dim SegundoNombreLabel As System.Windows.Forms.Label
        Dim PrimerApellidoLabel As System.Windows.Forms.Label
        Dim SegundoApellidoLabel As System.Windows.Forms.Label
        Dim FechaNacLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim IdCiudadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnBorrar = New System.Windows.Forms.ToolStripButton()
        Me.DsDBPrueba = New RegistroPersonas.DsDBPrueba()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaTableAdapter = New RegistroPersonas.DsDBPruebaTableAdapters.PersonaTableAdapter()
        Me.TableAdapterManager = New RegistroPersonas.DsDBPruebaTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerNombreTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoNombreTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.CmbCiudad = New System.Windows.Forms.ComboBox()
        IdLabel = New System.Windows.Forms.Label()
        PrimerNombreLabel = New System.Windows.Forms.Label()
        SegundoNombreLabel = New System.Windows.Forms.Label()
        PrimerApellidoLabel = New System.Windows.Forms.Label()
        SegundoApellidoLabel = New System.Windows.Forms.Label()
        FechaNacLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IdCiudadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DsDBPrueba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(64, 62)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 4
        IdLabel.Text = "id:"
        '
        'PrimerNombreLabel
        '
        PrimerNombreLabel.AutoSize = True
        PrimerNombreLabel.Location = New System.Drawing.Point(211, 62)
        PrimerNombreLabel.Name = "PrimerNombreLabel"
        PrimerNombreLabel.Size = New System.Drawing.Size(78, 13)
        PrimerNombreLabel.TabIndex = 5
        PrimerNombreLabel.Text = "primer Nombre:"
        '
        'SegundoNombreLabel
        '
        SegundoNombreLabel.AutoSize = True
        SegundoNombreLabel.Location = New System.Drawing.Point(429, 62)
        SegundoNombreLabel.Name = "SegundoNombreLabel"
        SegundoNombreLabel.Size = New System.Drawing.Size(91, 13)
        SegundoNombreLabel.TabIndex = 6
        SegundoNombreLabel.Text = "segundo Nombre:"
        '
        'PrimerApellidoLabel
        '
        PrimerApellidoLabel.AutoSize = True
        PrimerApellidoLabel.Location = New System.Drawing.Point(5, 112)
        PrimerApellidoLabel.Name = "PrimerApellidoLabel"
        PrimerApellidoLabel.Size = New System.Drawing.Size(78, 13)
        PrimerApellidoLabel.TabIndex = 8
        PrimerApellidoLabel.Text = "primer Apellido:"
        '
        'SegundoApellidoLabel
        '
        SegundoApellidoLabel.AutoSize = True
        SegundoApellidoLabel.Location = New System.Drawing.Point(198, 112)
        SegundoApellidoLabel.Name = "SegundoApellidoLabel"
        SegundoApellidoLabel.Size = New System.Drawing.Size(91, 13)
        SegundoApellidoLabel.TabIndex = 10
        SegundoApellidoLabel.Text = "segundo Apellido:"
        '
        'FechaNacLabel
        '
        FechaNacLabel.AutoSize = True
        FechaNacLabel.Location = New System.Drawing.Point(460, 116)
        FechaNacLabel.Name = "FechaNacLabel"
        FechaNacLabel.Size = New System.Drawing.Size(60, 13)
        FechaNacLabel.TabIndex = 12
        FechaNacLabel.Text = "fecha Nac:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(46, 161)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(32, 13)
        SexoLabel.TabIndex = 14
        SexoLabel.Text = "sexo:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(241, 161)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 16
        TelefonoLabel.Text = "telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(486, 164)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "email:"
        '
        'IdCiudadLabel
        '
        IdCiudadLabel.AutoSize = True
        IdCiudadLabel.Location = New System.Drawing.Point(29, 227)
        IdCiudadLabel.Name = "IdCiudadLabel"
        IdCiudadLabel.Size = New System.Drawing.Size(54, 13)
        IdCiudadLabel.TabIndex = 20
        IdCiudadLabel.Text = "id Ciudad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(218, 227)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 22
        DireccionLabel.Text = "direccion:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(487, 229)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(0, 13)
        EstadoLabel.TabIndex = 24
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnGuardar, Me.BtnNuevo, Me.BtnEditar, Me.BtnBorrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(791, 27)
        Me.ToolStrip1.TabIndex = 3
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
        'DsDBPrueba
        '
        Me.DsDBPrueba.DataSetName = "DsDBPrueba"
        Me.DsDBPrueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.DsDBPrueba
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CiudadTableAdapter = Nothing
        Me.TableAdapterManager.PersonaTableAdapter = Me.PersonaTableAdapter
        Me.TableAdapterManager.UpdateOrder = RegistroPersonas.DsDBPruebaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(88, 59)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 5
        '
        'PrimerNombreTextBox
        '
        Me.PrimerNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerNombre", True))
        Me.PrimerNombreTextBox.Location = New System.Drawing.Point(295, 59)
        Me.PrimerNombreTextBox.Name = "PrimerNombreTextBox"
        Me.PrimerNombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrimerNombreTextBox.TabIndex = 6
        '
        'SegundoNombreTextBox
        '
        Me.SegundoNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoNombre", True))
        Me.SegundoNombreTextBox.Location = New System.Drawing.Point(526, 59)
        Me.SegundoNombreTextBox.Name = "SegundoNombreTextBox"
        Me.SegundoNombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SegundoNombreTextBox.TabIndex = 7
        '
        'PrimerApellidoTextBox
        '
        Me.PrimerApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerApellido", True))
        Me.PrimerApellidoTextBox.Location = New System.Drawing.Point(89, 109)
        Me.PrimerApellidoTextBox.Name = "PrimerApellidoTextBox"
        Me.PrimerApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrimerApellidoTextBox.TabIndex = 9
        '
        'SegundoApellidoTextBox
        '
        Me.SegundoApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoApellido", True))
        Me.SegundoApellidoTextBox.Location = New System.Drawing.Point(295, 109)
        Me.SegundoApellidoTextBox.Name = "SegundoApellidoTextBox"
        Me.SegundoApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SegundoApellidoTextBox.TabIndex = 11
        '
        'FechaNacDateTimePicker
        '
        Me.FechaNacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonaBindingSource, "fechaNac", True))
        Me.FechaNacDateTimePicker.Location = New System.Drawing.Point(526, 112)
        Me.FechaNacDateTimePicker.Name = "FechaNacDateTimePicker"
        Me.FechaNacDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaNacDateTimePicker.TabIndex = 13
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(295, 158)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 17
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(526, 161)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 19
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(277, 222)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DireccionTextBox.Size = New System.Drawing.Size(290, 106)
        Me.DireccionTextBox.TabIndex = 23
        '
        'EstadoCheckBox
        '
        Me.EstadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PersonaBindingSource, "estado", True))
        Me.EstadoCheckBox.Location = New System.Drawing.Point(622, 222)
        Me.EstadoCheckBox.Name = "EstadoCheckBox"
        Me.EstadoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EstadoCheckBox.TabIndex = 25
        Me.EstadoCheckBox.Text = "Activo"
        Me.EstadoCheckBox.UseVisualStyleBackColor = True
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.CmbSexo.Location = New System.Drawing.Point(88, 161)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(101, 21)
        Me.CmbSexo.TabIndex = 26
        '
        'CmbCiudad
        '
        Me.CmbCiudad.FormattingEnabled = True
        Me.CmbCiudad.Location = New System.Drawing.Point(87, 223)
        Me.CmbCiudad.Name = "CmbCiudad"
        Me.CmbCiudad.Size = New System.Drawing.Size(101, 21)
        Me.CmbCiudad.TabIndex = 27
        '
        'FrmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 343)
        Me.Controls.Add(Me.CmbCiudad)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoCheckBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(IdCiudadLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(FechaNacLabel)
        Me.Controls.Add(Me.FechaNacDateTimePicker)
        Me.Controls.Add(SegundoApellidoLabel)
        Me.Controls.Add(Me.SegundoApellidoTextBox)
        Me.Controls.Add(PrimerApellidoLabel)
        Me.Controls.Add(Me.PrimerApellidoTextBox)
        Me.Controls.Add(SegundoNombreLabel)
        Me.Controls.Add(Me.SegundoNombreTextBox)
        Me.Controls.Add(PrimerNombreLabel)
        Me.Controls.Add(Me.PrimerNombreTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPersona"
        Me.Text = "Gestión de Personas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DsDBPrueba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnBorrar As ToolStripButton
    Friend WithEvents DsDBPrueba As DsDBPrueba
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As DsDBPruebaTableAdapters.PersonaTableAdapter
    Friend WithEvents TableAdapterManager As DsDBPruebaTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents PrimerNombreTextBox As TextBox
    Friend WithEvents SegundoNombreTextBox As TextBox
    Friend WithEvents PrimerApellidoTextBox As TextBox
    Friend WithEvents SegundoApellidoTextBox As TextBox
    Friend WithEvents FechaNacDateTimePicker As DateTimePicker
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents EstadoCheckBox As CheckBox
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents CmbCiudad As ComboBox
End Class
