<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(12, 58)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(160, 47)
        Me.btnProducts.TabIndex = 0
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(160, 40)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Click a button below to make a selection."
        '
        'btnClients
        '
        Me.btnClients.Location = New System.Drawing.Point(12, 111)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(160, 47)
        Me.btnClients.TabIndex = 2
        Me.btnClients.Text = "Clients"
        Me.btnClients.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(12, 164)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(160, 47)
        Me.btnOrders.TabIndex = 3
        Me.btnOrders.Text = "Orders"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 402)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 47)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOrders)
        Me.Controls.Add(Me.btnClients)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnProducts)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "ICI Ordering"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProducts As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnClients As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnExit As Button
End Class
