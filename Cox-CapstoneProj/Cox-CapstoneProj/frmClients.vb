Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmClients
    Private conn As String = "server=localhost;database=computer_shop;uid=root;pwd=;"
    Private sqlConn As New MySqlConnection(conn)
    Private sqlCmd As New MySqlCommand
    Private sqlAdapt As New MySqlDataAdapter
    Private dTable As New DataTable()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONSTRUCT DATA GRID VIEW
        DataGridView2.ColumnCount = 9

        DataGridView2.Columns(0).Name = "Customer ID"
        DataGridView2.Columns(1).Name = "Email Address"
        DataGridView2.Columns(2).Name = "First Name"
        DataGridView2.Columns(3).Name = "Last Name"
        DataGridView2.Columns(4).Name = "Address Line 1"
        DataGridView2.Columns(5).Name = "Address Line 2"
        DataGridView2.Columns(6).Name = "City"
        DataGridView2.Columns(7).Name = "State"
        DataGridView2.Columns(8).Name = "Zip Code"


        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        'LOADS DATA ONCE FORM IS LOADED
        retrieve()

    End Sub

    'CLEAR TXTBOX
    Private Sub cleartxt()
        txtCID.Text = ""
        txtEAdd.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        txtAdd1.Text = ""
        txtAdd2.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
    End Sub

    'INSERT DATA INTO DB
    Private Sub Add()
        Dim sqlStr As String = "INSERT INTO customers(customer_id, email_address, first_name, last_name, line1, line2, city, state, zip_code) 
                                VALUES (@CID,@EADD,@FNAME,@LNAME,@ADD1,@ADD2,@CITY,@STATE,@ZIP)"

        sqlCmd = New MySqlCommand(sqlStr, sqlConn)

        'PARAMETERS
        sqlCmd.Parameters.AddWithValue("@CID", txtCID.Text)
        sqlCmd.Parameters.AddWithValue("@EADD", txtEAdd.Text)
        sqlCmd.Parameters.AddWithValue("@FNAME", txtFName.Text)
        sqlCmd.Parameters.AddWithValue("@LNAME", txtLName.Text)
        sqlCmd.Parameters.AddWithValue("@ADD1", txtAdd1.Text)
        sqlCmd.Parameters.AddWithValue("@ADD2", txtAdd2.Text)
        sqlCmd.Parameters.AddWithValue("@CITY", txtCity.Text)
        sqlCmd.Parameters.AddWithValue("@STATE", txtState.Text)
        sqlCmd.Parameters.AddWithValue("@ZIP", txtZip.Text)

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
    Private Sub Populate(customer_id As Integer, email_address As String, first_name As String, last_name As String, line1 As String, line2 As String, city As String, state As String, zip_code As String)
        Dim row As String() = New String() {customer_id, email_address, first_name, last_name, line1, line2, city, state, zip_code}

        DataGridView2.Rows.Add(row)
    End Sub

    'RETRIEVE DATA FROM DB
    Private Sub retrieve()
        DataGridView2.Rows.Clear()

        'SQL STATEMENT
        Dim sqlQry As String = "SELECT * FROM CUSTOMERS"
        sqlCmd = New MySqlCommand(sqlQry, sqlConn)

        Try
            sqlConn.Open()

            sqlAdapt = New MySqlDataAdapter(sqlCmd)
            sqlAdapt.Fill(dTable)

            For Each row In dTable.Rows
                Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8))
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
        Dim sql As String = "UPDATE customers SET customer_id='" + txtCID.Text + "', email_address='" + txtEAdd.Text + "', first_name='" + txtFName.Text + "', last_name='" + txtLName.Text + "', line1='" + txtAdd1.Text + "', line2='" + txtAdd2.Text + "', city='" + txtCity.Text + "', state='" + txtState.Text + "', zip_code='" + txtZip.Text + "' WHERE customer_id='" + id + "'"

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
        Dim sql As String = "DELETE FROM customers WHERE customer_id='" + id + "'"
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
    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        Dim CID As String = DataGridView2.SelectedRows(0).Cells(0).Value
        Dim eMail As String = DataGridView2.SelectedRows(0).Cells(1).Value
        Dim FName As String = DataGridView2.SelectedRows(0).Cells(2).Value
        Dim LName As String = DataGridView2.SelectedRows(0).Cells(3).Value
        Dim Add1 As String = DataGridView2.SelectedRows(0).Cells(4).Value
        Dim Add2 As String = DataGridView2.SelectedRows(0).Cells(5).Value
        Dim City As String = DataGridView2.SelectedRows(0).Cells(6).Value
        Dim State As String = DataGridView2.SelectedRows(0).Cells(7).Value
        Dim Zip As String = DataGridView2.SelectedRows(0).Cells(8).Value

        txtCID.Text = CID
        txtEAdd.Text = eMail
        txtFName.Text = FName
        txtLName.Text = LName
        txtAdd1.Text = Add1
        txtAdd2.Text = Add2
        txtCity.Text = City
        txtState.Text = State
        txtZip.Text = Zip

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
        Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        UpdateDG(id)
    End Sub

    'EVENT CLICK DELETE BUTTON
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As String = DataGridView2.SelectedRows(0).Cells(0).Value
        delete(id)
    End Sub

End Class