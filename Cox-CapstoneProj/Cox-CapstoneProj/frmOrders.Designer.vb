<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrders
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
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
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
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.txtOrderDate = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(784, 269)
        Me.DataGridView3.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(584, 426)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(185, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(393, 426)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(185, 23)
        Me.btnRetrieve.TabIndex = 11
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(202, 426)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(185, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(9, 426)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(185, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Order ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Order Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Product ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Item Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Quantity"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(126, 306)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(174, 20)
        Me.txtOrderID.TabIndex = 19
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(126, 340)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(174, 20)
        Me.txtCustID.TabIndex = 20
        '
        'txtOrderDate
        '
        Me.txtOrderDate.Location = New System.Drawing.Point(126, 375)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.ReadOnly = True
        Me.txtOrderDate.Size = New System.Drawing.Size(174, 20)
        Me.txtOrderDate.TabIndex = 21
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(500, 340)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(205, 20)
        Me.txtQuantity.TabIndex = 23
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Location = New System.Drawing.Point(500, 375)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(205, 20)
        Me.txtItemPrice.TabIndex = 24
        '
        'txtProdID
        '
        Me.txtProdID.Location = New System.Drawing.Point(500, 306)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(205, 20)
        Me.txtProdID.TabIndex = 22
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.txtOrderDate)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.txtOrderID)
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
        Me.Controls.Add(Me.DataGridView3)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOrders"
        Me.Text = "Order Listing"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView3 As DataGridView
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
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents txtOrderDate As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents txtProdID As TextBox
End Class
