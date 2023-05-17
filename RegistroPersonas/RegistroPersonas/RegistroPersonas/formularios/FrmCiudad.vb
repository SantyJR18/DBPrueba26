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

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim codigo As Integer = txtID.Text
        Dim dCiudad As New DCiudades()
        Dim ciudad As New Tbl_Ciudad
        ciudad = dCiudad.BuscarRegistro(codigo)
        If (ciudad.IdCiudad = 0) Then
            MsgBox("El registro no existe",
                   MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If

        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro " & ciudad.IdCiudad, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "ADVERTENCIA"))
        If (resp = vbNo) Then
            MsgBox("Operacion cancelada",
                       MsgBoxStyle.Information, "Ciudades")
            Exit Sub
        End If

        Dim eliminado = dCiudad.EliminarRegistro(ciudad.IdCiudad)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                       MsgBoxStyle.Information, "Ciudades")
        Else
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        LlenarRegistros()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim ds As New DataSet
        Dim dao As New DCiudades
        ds = dao.BuscarXNombre(TxtValor.Text.Trim)
        DgvRegistrosC.DataSource = ds.Tables(0)
        DgvRegistrosC.Refresh()
        GbRegistros.Text = "Registros almacenados" & DgvRegistrosC.Rows.Count
    End Sub
End Class