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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim ciudad As New Tbl_Ciudad()
            ciudad.NombreCiudad = txtNombre.Text.Trim
            Dim dCiudad As New DCiudades
            If (dCiudad.GuardarRegistros(ciudad)) Then
                MsgBox("Registro guardado correctamente...", MsgBoxStyle.Information, "Ciudad")
            Else
                MsgBox("No se pudo guardar el registro...", MsgBoxStyle.Information, "Ciudad")
            End If
            LlenarRegistros()
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim ciudad As New Tbl_Ciudad(
                CInt(txtID.Text), txtNombre.Text, True)
            Dim dao As New DCiudades
            If (dao.EditarRegistros(ciudad)) Then
                MsgBox("Registro editado")
            Else
                MsgBox("error")
            End If
            LlenarRegistros()
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub

    Private Sub DgvRegistrosC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRegistrosC.CellDoubleClick
        Dim fila As Integer = DgvRegistrosC.CurrentRow.Index
        txtID.Text = DgvRegistrosC.Rows(fila).Cells(0).Value
        txtNombre.Text = DgvRegistrosC.Rows(fila).Cells(1).Value
    End Sub
End Class