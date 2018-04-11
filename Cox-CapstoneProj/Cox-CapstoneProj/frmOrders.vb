Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmOrders
    Private conn As String = "server=localhost;database=computer_shop;uid=root;pwd=;"
    Private sqlConn As New MySqlConnection(conn)
    Private sqlCmd As New MySqlCommand
    Private sqlAdapt As New MySqlDataAdapter
    Private dTable As New DataTable()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONSTRUCT DATA GRID VIEW
        DataGridView3.ColumnCount = 6

        DataGridView3.Columns(0).Name = "Order ID"
        DataGridView3.Columns(1).Name = "Customer ID"
        DataGridView3.Columns(2).Name = "Order Date"
        DataGridView3.Columns(3).Name = "Product ID"
        DataGridView3.Columns(4).Name = "Quantity"
        DataGridView3.Columns(5).Name = "Price"

        DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'LOADS DATA ONCE FORM IS LOADED
        retrieve()

    End Sub

    'CLEAR TXTBOX
    Private Sub cleartxt()
        txtOrderID.Text = ""
        txtCustID.Text = ""
        txtOrderDate.Text = ""
        txtProdID.Text = ""
        txtItemPrice.Text = ""
        txtQuantity.Text = ""
    End Sub

    'INSERT DATA INTO DB
    Private Sub Add()
        Dim sqlStr As String = "INSERT INTO orders(order_id, customer_id, order_date, product_id, quantity, price) VALUES (@ORDERID,@CUSTID,@ORDERDATE,@PRODID,@QUANTITY,@PRICE)"
        sqlCmd = New MySqlCommand(sqlStr, sqlConn)

        'PARAMETERS
        sqlCmd.Parameters.AddWithValue("@ORDERID", txtOrderID.Text)
        sqlCmd.Parameters.AddWithValue("@CUSTID", txtCustID.Text)
        sqlCmd.Parameters.AddWithValue("@ORDERDATE", Now())
        sqlCmd.Parameters.AddWithValue("@PRODID", txtProdID.Text)
        sqlCmd.Parameters.AddWithValue("@QUANTITY", txtQuantity.Text)
        sqlCmd.Parameters.AddWithValue("@PRICE", txtItemPrice.Text)


        'OPEN CONNECTION AND INSERT
        Try
            sqlConn.Open()

            If sqlCmd.ExecuteNonQuery() > 0 Then
                MsgBox("Successfully Inserted")
                cleartxt()
            End If


            sqlConn.Close()
            retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlConn.Close()

        End Try

    End Sub

    'POPULATE ROWS
    Private Sub Populate(order_id As Integer, customer_id As Integer, order_date As String, product_id As Integer, quantity As Integer, price As String)
        Dim row As String() = New String() {order_id, customer_id, order_date, product_id, quantity, price}

        DataGridView3.Rows.Add(row)
    End Sub

    'RETRIEVE DATA FROM DB
    Private Sub retrieve()
        DataGridView3.Rows.Clear()

        'SQL STATEMENT
        Dim sqlQry As String = "SELECT order_id, customer_id, order_date, product_id, quantity, price FROM orders"
        sqlCmd = New MySqlCommand(sqlQry, sqlConn)

        Try
            sqlConn.Open()

            sqlAdapt = New MySqlDataAdapter(sqlCmd)
            sqlAdapt.Fill(dTable)

            For Each row In dTable.Rows
                Populate(row(0), row(1), row(2), row(3), row(4), row(5))
            Next

            sqlConn.Close()

            dTable.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlConn.Close()

        End Try

    End Sub

    'UPDATE DATA
    Private Sub UpdateDG(id As String)
        Dim sql As String = "UPDATE orders SET order_id='" + txtOrderID.Text + "', customer_id='" + txtCustID.Text + "', order_date='" + txtOrderDate.Text + "', product_id='" + txtProdID.Text + "', quantity='" + txtQuantity.Text + "', price='" + txtItemPrice.Text + "' WHERE order_id='" + id + "'"

        Try
            sqlConn.Open()

            sqlAdapt.UpdateCommand = sqlConn.CreateCommand()

            sqlAdapt.UpdateCommand.CommandText = sql

            If sqlAdapt.UpdateCommand.ExecuteNonQuery() > 0 Then
                MsgBox("Successfully Updated")
                cleartxt()
            End If

            sqlConn.Close()

            retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            cleartxt()
        End Try
    End Sub

    'DELETE DATA
    Private Sub delete(id As String)
        Dim sql As String = "DELETE FROM orders WHERE order_id='" + id + "'"

        sqlCmd = New MySqlCommand(sql, sqlConn)

        Try
            sqlConn.Open()

            sqlAdapt.DeleteCommand = sqlConn.CreateCommand
            sqlAdapt.DeleteCommand.CommandText = sql

            If MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                If sqlCmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Successfully Deleted")
                    cleartxt()
                End If
            End If
            sqlConn.Close()
            retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlConn.Close()
        End Try
    End Sub

    'EVENT FOR CLICKING WITHIN THE GRID
    Private Sub DataGridView3_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView3.MouseClick
        Dim orderID As String = DataGridView3.SelectedRows(0).Cells(0).Value
        Dim custID As String = DataGridView3.SelectedRows(0).Cells(1).Value
        Dim orderDate As String = DataGridView3.SelectedRows(0).Cells(2).Value
        Dim prodID As String = DataGridView3.SelectedRows(0).Cells(3).Value
        Dim quantity As String = DataGridView3.SelectedRows(0).Cells(4).Value
        Dim itemPrice As String = DataGridView3.SelectedRows(0).Cells(5).Value

        txtOrderID.Text = orderID
        txtCustID.Text = custID
        txtOrderDate.Text = orderDate
        txtProdID.Text = prodID
        txtItemPrice.Text = itemPrice
        txtQuantity.Text = quantity

    End Sub

    'EVENT CLICK ADD BUTTON
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    'EVENT CLICK RETRIEVE BUTTON
    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        retrieve()
    End Sub

    'EVENT CLICK UPDATE BUTTON
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As String = DataGridView3.SelectedRows(0).Cells(0).Value
        UpdateDG(id)
    End Sub

    'EVENT CLICK DELETE BUTTON
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As String = DataGridView3.SelectedRows(0).Cells(0).Value
        delete(id)
    End Sub

End Class