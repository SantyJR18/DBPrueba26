Imports System.Data.SqlClient

Public Class DCiudades

    Dim strConexion As String = My.Settings.StrConnection.ToString()
    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim tSql As String = "Select id as N'CODIGO', nombre as N'CIUDAD' from Ciudad"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener registro. " & ex.Message, MsgBoxStyle.Critical,
            "Error")
        End Try
        Return ds
    End Function

    Public Function GuardarRegistros(ByVal ciudad As Tbl_Ciudad) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConexion)
            Dim cmd As New SqlCommand()
            Dim tsql = "insert into Ciudad(nombre) values(@nombre)"
            cmd.Parameters.AddWithValue("@nombre", ciudad.NombreCiudad)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error al guardar registro. " & ex.Message, MsgBoxStyle.Critical,
            "Error")
        End Try
        Return resultado
    End Function

    Public Function EditarRegistros(ByVal ciudad As Tbl_Ciudad)
        Dim flag = False
        Try
            Dim tsql = "UPDATE Ciudad SET nombre = @nombre, estado = @estado WHERE id = @id"
            Dim conn As New SqlConnection(My.Settings.StrConnection)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", ciudad.NombreCiudad)
            cmd.Parameters.AddWithValue("@estado", ciudad.Estado)
            cmd.Parameters.AddWithValue("@id", ciudad.IdCiudad)
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                flag = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error al guardar registro. " & ex.Message, MsgBoxStyle.Critical,
            "Error")
        End Try
        Return flag
    End Function

    Public Function EliminarRegistro(ByVal id As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "delete from Ciudad where id = @id"
            Dim conn As New SqlConnection(strConexion)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id", id)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarRegistro(ByVal id As Integer) As Tbl_Ciudad
        Dim ciudad As New Tbl_Ciudad
        Try
            Dim tsql As String = "select * from Ciudad where id = @id"
            Dim conn As New SqlConnection(strConexion)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id", id)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                ciudad.IdCiudad = tbl.Rows(0).Item("id")
                ciudad.NombreCiudad = tbl.Rows(0).Item("nombre")
                ciudad.Estado = tbl.Rows(0).Item("estado")
            End If
        Catch ex As Exception

        End Try
        Return ciudad
    End Function

    Public Function BuscarXNombre(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        Try
            nombre = nombre + "%"
            Dim tsql As String = "Select * from Ciudad where nombre like @nombre"
            Dim conn As New SqlConnection(strConexion)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function
End Class