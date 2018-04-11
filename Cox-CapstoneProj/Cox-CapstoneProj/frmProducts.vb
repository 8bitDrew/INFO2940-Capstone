Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmProducts
    Private conn As String = "server=localhost;database=computer_shop;uid=root;pwd=;"
    Private sqlConn As New MySqlConnection(conn)
    Private sqlCmd As New MySqlCommand
    Private sqlAdapt As New MySqlDataAdapter
    Private dTable As New DataTable()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONSTRUCT DATA GRID VIEW
        DataGridView1.ColumnCount = 6

        DataGridView1.Columns(0).Name = "Product ID"
        DataGridView1.Columns(1).Name = "Category ID"
        DataGridView1.Columns(2).Name = "Product Code"
        DataGridView1.Columns(3).Name = "Product Name"
        DataGridView1.Columns(4).Name = "Description"
        DataGridView1.Columns(5).Name = "List Price"

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'LOADS DATA ONCE FORM IS LOADED
        retrieve()
    End Sub

    'CLEAR TXTBOX
    Private Sub cleartxt()
        txtPID.Text = ""
        txtCID.Text = ""
        txtPCode.Text = ""
        txtPName.Text = ""
        txtDesc.Text = ""
        txtLPrice.Text = ""
    End Sub

    'INSERT DATA INTO DB
    Private Sub Add()
        Dim sqlStr As String = "INSERT INTO products(product_id, category_id, product_code, product_name, description, list_price) VALUES (@PID,@CID,@PCODE,@PNAME,@DESC,@LPRICE)"
        sqlCmd = New MySqlCommand(sqlStr, sqlConn)

        'PARAMETERS
        sqlCmd.Parameters.AddWithValue("@PID", txtPID.Text)
        sqlCmd.Parameters.AddWithValue("@CID", txtCID.Text)
        sqlCmd.Parameters.AddWithValue("@PCODE", txtPCode.Text)
        sqlCmd.Parameters.AddWithValue("@PNAME", txtPName.Text)
        sqlCmd.Parameters.AddWithValue("@DESC", txtDesc.Text)
        sqlCmd.Parameters.AddWithValue("@LPRICE", txtLPrice.Text)

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
    Private Sub Populate(product_id As Integer, category_id As Integer, product_code As String, product_name As String, description As String, list_price As String)
        Dim row As String() = New String() {product_id, category_id, product_code, product_name, description, list_price}
        DataGridView1.Rows.Add(row)
    End Sub

    'RETRIEVE DATA FROM DB
    Private Sub retrieve()
        DataGridView1.Rows.Clear()
        'SQL STATEMENT
        Dim sqlQry As String = "SELECT * FROM PRODUCTS"
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
        Dim sql As String = "UPDATE products SET product_id='" + txtPID.Text + "', category_id='" + txtCID.Text + "', product_code='" + txtPCode.Text + "', product_name='" + txtPName.Text + "', description='" + txtDesc.Text + "', list_price='" + txtLPrice.Text + "' WHERE product_id='" + id + "'"
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
        Dim sql As String = "DELETE FROM products WHERE product_id='" + id + "'"
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
    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim PID As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Dim CID As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim PCode As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim PName As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim Desc As String = DataGridView1.SelectedRows(0).Cells(4).Value
        Dim LPrice As String = DataGridView1.SelectedRows(0).Cells(5).Value

        txtPID.Text = PID
        txtCID.Text = CID
        txtPCode.Text = PCode
        txtPName.Text = PName
        txtDesc.Text = Desc
        txtLPrice.Text = LPrice
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
        Dim id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        UpdateDG(id)
    End Sub

    'EVENT CLICK DELETE BUTTON
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        delete(id)
    End Sub

End Class