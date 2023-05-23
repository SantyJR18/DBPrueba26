<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsDBPrueba = New RegistroPersonas.DsDBPrueba()
        Me.ListadoPersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DsDBPrueba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoPersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ListadoPersonaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RegistroPersonas.RptPersonas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(977, 524)
        Me.ReportViewer1.TabIndex = 0
        '
        'DsDBPrueba
        '
        Me.DsDBPrueba.DataSetName = "DsDBPrueba"
        Me.DsDBPrueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoPersonaBindingSource
        '
        Me.ListadoPersonaBindingSource.DataMember = "ListadoPersona"
        Me.ListadoPersonaBindingSource.DataSource = Me.DsDBPrueba
        '
        'FrmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 524)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmVistaPrevia"
        Me.Text = "FrmVistaPrevia"
        CType(Me.DsDBPrueba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoPersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListadoPersonaBindingSource As BindingSource
    Friend WithEvents DsDBPrueba As DsDBPrueba
End Class
