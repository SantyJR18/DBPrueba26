﻿Public Class FrmMenu
    Private Sub CiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadToolStripMenuItem.Click
        Dim frm As New FrmCiudad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        FrmPersona.Show()
    End Sub
End Class
