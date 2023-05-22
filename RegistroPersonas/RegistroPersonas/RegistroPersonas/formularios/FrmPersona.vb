Public Class FrmPersona

    Dim ciudad As New DCiudades

    Sub LlenarCiudades()
        Dim ds As New DataSet
        ds = ciudad.MostrarRegistros()
        CmbCiudad.DataSource = ds.Tables(0)
        CmbCiudad.Refresh()
        CmbCiudad.DisplayMember = "Ciudad" 'nombre del alias'
        CmbCiudad.ValueMember = "Codigo" 'nombre del alias'

    End Sub

    Private Sub FrmPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCiudades()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        DireccionTextBox.Text = CmbCiudad.SelectedValue.ToString()
    End Sub
End Class