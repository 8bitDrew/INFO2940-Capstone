<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnTestConn = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(484, 124)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btnTestConn
        '
        Me.btnTestConn.Location = New System.Drawing.Point(12, 142)
        Me.btnTestConn.Name = "btnTestConn"
        Me.btnTestConn.Size = New System.Drawing.Size(131, 59)
        Me.btnTestConn.TabIndex = 1
        Me.btnTestConn.Text = "Test Connection"
        Me.btnTestConn.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(365, 142)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(131, 59)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(253, 142)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 22)
        Me.txtUserName.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(253, 174)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtPassword.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 212)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnTestConn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Info Consulting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnTestConn As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
