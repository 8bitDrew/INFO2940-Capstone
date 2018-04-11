Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim sqlConn As MySqlConnection
    Dim sqlCmd As MySqlCommand

    Private Sub btnTestConn_Click(sender As Object, e As EventArgs) Handles btnTestConn.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=computer_shop"

        Try
            sqlConn.Open()
            MessageBox.Show("Connection Successful")
            sqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()

        End Try
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        sqlConn = New MySqlConnection
        sqlConn.ConnectionString =
            "server=localhost;userid=root;password=;database=computer_shop"
        Dim sqlReader As MySqlDataReader

        Try
            sqlConn.Open()
            Dim sqlQuery As String
            sqlQuery = "select * from computer_shop.administrators where username='" & txtUserName.Text & "' and password='" & txtPassword.Text & "' "
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlReader = sqlCmd.ExecuteReader
            Dim Count As Integer
            Count = 0

            While sqlReader.Read
                Count = Count + 1
            End While

            If Count = 1 Then
                MessageBox.Show("Login is correct")
                frmMain.Show()
                Me.Hide()

            Else
                MessageBox.Show("Login is not correct")
            End If

            sqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()

        End Try
    End Sub


End Class

