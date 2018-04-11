Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmMain

    Private Sub frmMain_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        frmProducts.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
        frmClients.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
        frmOrders.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub


    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmClients.Close()
        frmOrders.Close()
        frmProducts.Show()
        frmProducts.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        frmProducts.Close()
        frmOrders.Close()
        frmClients.Show()
        frmClients.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        frmProducts.Close()
        frmClients.Close()
        frmOrders.Show()
        frmOrders.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class