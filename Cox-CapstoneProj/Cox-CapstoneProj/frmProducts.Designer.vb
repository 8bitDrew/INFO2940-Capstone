<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.txtPCode = New System.Windows.Forms.TextBox()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtLPrice = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(784, 256)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 426)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(185, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(205, 426)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(185, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(396, 426)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(185, 23)
        Me.btnRetrieve.TabIndex = 3
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(587, 426)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(185, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Category ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(365, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(365, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "List Price"
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(115, 289)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(234, 20)
        Me.txtPID.TabIndex = 11
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(115, 327)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(234, 20)
        Me.txtCID.TabIndex = 12
        '
        'txtPCode
        '
        Me.txtPCode.Location = New System.Drawing.Point(115, 371)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(234, 20)
        Me.txtPCode.TabIndex = 13
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(446, 289)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(274, 20)
        Me.txtPName.TabIndex = 14
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(446, 327)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(274, 20)
        Me.txtDesc.TabIndex = 15
        '
        'txtLPrice
        '
        Me.txtLPrice.Location = New System.Drawing.Point(446, 371)
        Me.txtLPrice.Name = "txtLPrice"
        Me.txtLPrice.Size = New System.Drawing.Size(274, 20)
        Me.txtLPrice.TabIndex = 16
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.txtLPrice)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtPName)
        Me.Controls.Add(Me.txtPCode)
        Me.Controls.Add(Me.txtCID)
        Me.Controls.Add(Me.txtPID)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProducts"
        Me.Text = "Product Listing"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRetrieve As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPID As TextBox
    Friend WithEvents txtCID As TextBox
    Friend WithEvents txtPCode As TextBox
    Friend WithEvents txtPName As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtLPrice As TextBox
End Class
