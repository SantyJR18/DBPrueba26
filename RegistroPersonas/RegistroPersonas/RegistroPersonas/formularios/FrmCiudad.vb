Public Class FrmCiudad
    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub

    Sub LlenarRegistros()
        Dim dCiudad As New DCiudades
        DgvRegistrosC.DataSource = dCiudad.MostrarRegistros.Tables(0)
        DgvRegistrosC.Refresh()
        GbRegistros.Text = "Registros almacenados " &
            DgvRegistrosC.Rows.Count
    End Sub
End Class