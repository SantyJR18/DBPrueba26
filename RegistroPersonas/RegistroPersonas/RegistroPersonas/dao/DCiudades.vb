Imports System.Data.SqlClient

Public Class DCiudades
    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tSql As String = "Select id as N'CODIGO', nombre as N'CIUDAD' from Ciudad"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener registro. s" & ex.Message, MsgBoxStyle.Critical,
            "Error")
        End Try
        Return ds
    End Function
End Class
