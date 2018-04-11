<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.txtEAdd = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(784, 233)
        Me.DataGridView2.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(587, 426)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(185, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(396, 426)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(185, 23)
        Me.btnRetrieve.TabIndex = 7
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(205, 426)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(185, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 426)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(185, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address Line 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address Line 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "City"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(522, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Zip Code"
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(117, 264)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(179, 20)
        Me.txtCID.TabIndex = 18
        '
        'txtEAdd
        '
        Me.txtEAdd.Location = New System.Drawing.Point(117, 299)
        Me.txtEAdd.Name = "txtEAdd"
        Me.txtEAdd.Size = New System.Drawing.Size(179, 20)
        Me.txtEAdd.TabIndex = 19
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(117, 335)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(179, 20)
        Me.txtFName.TabIndex = 20
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(117, 375)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(179, 20)
        Me.txtLName.TabIndex = 21
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(423, 264)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(211, 20)
        Me.txtAdd1.TabIndex = 22
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(423, 299)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(211, 20)
        Me.txtAdd2.TabIndex = 23
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(423, 335)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(211, 20)
        Me.txtCity.TabIndex = 24
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(423, 375)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(73, 20)
        Me.txtState.TabIndex = 25
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(589, 375)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 26
        '
        'frmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAdd2)
        Me.Controls.Add(Me.txtAdd1)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtEAdd)
        Me.Controls.Add(Me.txtCID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView2)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmClients"
        Me.Text = "Client Listing"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRetrieve As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCID As TextBox
    Friend WithEvents txtEAdd As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
End Class
