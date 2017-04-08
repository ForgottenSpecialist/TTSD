<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NSTheme = New TT_SD.NSTheme()
        Me.NsGroupBox3 = New TT_SD.NSGroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NsTextBox2 = New TT_SD.NSTextBox()
        Me.NsTextBox1 = New TT_SD.NSTextBox()
        Me.NsTextBox7 = New TT_SD.NSTextBox()
        Me.NsButton4 = New TT_SD.NSButton()
        Me.NsTextBox6 = New TT_SD.NSTextBox()
        Me.NsLabel9 = New TT_SD.NSLabel()
        Me.NsLabel10 = New TT_SD.NSLabel()
        Me.NsLabel33 = New TT_SD.NSLabel()
        Me.NsLabel2 = New TT_SD.NSLabel()
        Me.NsLabel13 = New TT_SD.NSLabel()
        Me.NSTheme.SuspendLayout()
        Me.NsGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'NSTheme
        '
        Me.NSTheme.AccentOffset = 42
        Me.NSTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NSTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NSTheme.Colors = New TT_SD.Bloom(-1) {}
        Me.NSTheme.Controls.Add(Me.NsGroupBox3)
        Me.NSTheme.Controls.Add(Me.NsLabel33)
        Me.NSTheme.Controls.Add(Me.NsLabel2)
        Me.NSTheme.Controls.Add(Me.NsLabel13)
        Me.NSTheme.Customization = ""
        Me.NSTheme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NSTheme.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NSTheme.Image = Nothing
        Me.NSTheme.Location = New System.Drawing.Point(0, 0)
        Me.NSTheme.Movable = True
        Me.NSTheme.Name = "NSTheme"
        Me.NSTheme.NoRounding = False
        Me.NSTheme.Sizable = True
        Me.NSTheme.Size = New System.Drawing.Size(217, 240)
        Me.NSTheme.SmartBounds = True
        Me.NSTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NSTheme.TabIndex = 0
        Me.NSTheme.TransparencyKey = System.Drawing.Color.Empty
        Me.NSTheme.Transparent = False
        '
        'NsGroupBox3
        '
        Me.NsGroupBox3.Controls.Add(Me.TextBox1)
        Me.NsGroupBox3.Controls.Add(Me.NsTextBox2)
        Me.NsGroupBox3.Controls.Add(Me.NsTextBox1)
        Me.NsGroupBox3.Controls.Add(Me.NsTextBox7)
        Me.NsGroupBox3.Controls.Add(Me.NsButton4)
        Me.NsGroupBox3.Controls.Add(Me.NsTextBox6)
        Me.NsGroupBox3.Controls.Add(Me.NsLabel9)
        Me.NsGroupBox3.Controls.Add(Me.NsLabel10)
        Me.NsGroupBox3.DrawSeperator = False
        Me.NsGroupBox3.Location = New System.Drawing.Point(12, 41)
        Me.NsGroupBox3.Name = "NsGroupBox3"
        Me.NsGroupBox3.Size = New System.Drawing.Size(192, 186)
        Me.NsGroupBox3.SubTitle = ""
        Me.NsGroupBox3.TabIndex = 18
        Me.NsGroupBox3.Text = "NsGroupBox3"
        Me.NsGroupBox3.Title = "Login Credentials"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.7!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(11, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 23)
        Me.TextBox1.TabIndex = 14
        '
        'NsTextBox2
        '
        Me.NsTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox2.Location = New System.Drawing.Point(156, 0)
        Me.NsTextBox2.MaxLength = 32767
        Me.NsTextBox2.Multiline = False
        Me.NsTextBox2.Name = "NsTextBox2"
        Me.NsTextBox2.ReadOnly = False
        Me.NsTextBox2.Size = New System.Drawing.Size(37, 19)
        Me.NsTextBox2.TabIndex = 13
        Me.NsTextBox2.Text = "NsTextBox2"
        Me.NsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox2.UseSystemPasswordChar = False
        Me.NsTextBox2.Visible = False
        '
        'NsTextBox1
        '
        Me.NsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox1.Location = New System.Drawing.Point(118, 0)
        Me.NsTextBox1.MaxLength = 32767
        Me.NsTextBox1.Multiline = False
        Me.NsTextBox1.Name = "NsTextBox1"
        Me.NsTextBox1.ReadOnly = False
        Me.NsTextBox1.Size = New System.Drawing.Size(37, 19)
        Me.NsTextBox1.TabIndex = 12
        Me.NsTextBox1.Text = "NsTextBox1"
        Me.NsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox1.UseSystemPasswordChar = False
        Me.NsTextBox1.Visible = False
        '
        'NsTextBox7
        '
        Me.NsTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox7.Enabled = False
        Me.NsTextBox7.Font = New System.Drawing.Font("Segoe UI", 12.7!)
        Me.NsTextBox7.Location = New System.Drawing.Point(6, 87)
        Me.NsTextBox7.MaxLength = 32767
        Me.NsTextBox7.Multiline = False
        Me.NsTextBox7.Name = "NsTextBox7"
        Me.NsTextBox7.ReadOnly = False
        Me.NsTextBox7.Size = New System.Drawing.Size(180, 34)
        Me.NsTextBox7.TabIndex = 11
        Me.NsTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox7.UseSystemPasswordChar = True
        '
        'NsButton4
        '
        Me.NsButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NsButton4.Location = New System.Drawing.Point(6, 134)
        Me.NsButton4.Name = "NsButton4"
        Me.NsButton4.Size = New System.Drawing.Size(180, 46)
        Me.NsButton4.TabIndex = 10
        Me.NsButton4.Text = "                  Login"
        '
        'NsTextBox6
        '
        Me.NsTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBox6.Font = New System.Drawing.Font("Segoe UI", 12.7!)
        Me.NsTextBox6.Location = New System.Drawing.Point(6, 39)
        Me.NsTextBox6.MaxLength = 32767
        Me.NsTextBox6.Multiline = False
        Me.NsTextBox6.Name = "NsTextBox6"
        Me.NsTextBox6.ReadOnly = False
        Me.NsTextBox6.Size = New System.Drawing.Size(180, 34)
        Me.NsTextBox6.TabIndex = 10
        Me.NsTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox6.UseSystemPasswordChar = False
        '
        'NsLabel9
        '
        Me.NsLabel9.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsLabel9.Location = New System.Drawing.Point(8, 68)
        Me.NsLabel9.Name = "NsLabel9"
        Me.NsLabel9.Size = New System.Drawing.Size(75, 23)
        Me.NsLabel9.TabIndex = 10
        Me.NsLabel9.Text = "NsLabel9"
        Me.NsLabel9.Value1 = "Password:"
        Me.NsLabel9.Value2 = ""
        '
        'NsLabel10
        '
        Me.NsLabel10.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsLabel10.Location = New System.Drawing.Point(8, 22)
        Me.NsLabel10.Name = "NsLabel10"
        Me.NsLabel10.Size = New System.Drawing.Size(105, 19)
        Me.NsLabel10.TabIndex = 10
        Me.NsLabel10.Text = "NsLabel10"
        Me.NsLabel10.Value1 = "User Name:"
        Me.NsLabel10.Value2 = ""
        '
        'NsLabel33
        '
        Me.NsLabel33.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NsLabel33.Location = New System.Drawing.Point(3, 3)
        Me.NsLabel33.Name = "NsLabel33"
        Me.NsLabel33.Size = New System.Drawing.Size(49, 21)
        Me.NsLabel33.TabIndex = 17
        Me.NsLabel33.Text = "NsLabel33"
        Me.NsLabel33.Value1 = "Login"
        Me.NsLabel33.Value2 = ""
        '
        'NsLabel2
        '
        Me.NsLabel2.Font = New System.Drawing.Font("Verdana", 2.0!)
        Me.NsLabel2.Location = New System.Drawing.Point(187, 7)
        Me.NsLabel2.Name = "NsLabel2"
        Me.NsLabel2.Size = New System.Drawing.Size(14, 15)
        Me.NsLabel2.TabIndex = 15
        Me.NsLabel2.Text = "NsLabel2"
        Me.NsLabel2.Value1 = "____"
        Me.NsLabel2.Value2 = ""
        '
        'NsLabel13
        '
        Me.NsLabel13.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsLabel13.Location = New System.Drawing.Point(201, 2)
        Me.NsLabel13.Name = "NsLabel13"
        Me.NsLabel13.Size = New System.Drawing.Size(13, 23)
        Me.NsLabel13.TabIndex = 14
        Me.NsLabel13.Text = "NsLabel13"
        Me.NsLabel13.Value1 = "X"
        Me.NsLabel13.Value2 = ""
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 240)
        Me.Controls.Add(Me.NSTheme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.NSTheme.ResumeLayout(False)
        Me.NsGroupBox3.ResumeLayout(False)
        Me.NsGroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NSTheme As NSTheme
    Friend WithEvents NsLabel13 As NSLabel
    Friend WithEvents NsLabel2 As NSLabel
    Friend WithEvents NsLabel33 As NSLabel
    Friend WithEvents NsGroupBox3 As NSGroupBox
    Friend WithEvents NsTextBox7 As NSTextBox
    Friend WithEvents NsButton4 As NSButton
    Friend WithEvents NsTextBox6 As NSTextBox
    Friend WithEvents NsLabel9 As NSLabel
    Friend WithEvents NsLabel10 As NSLabel
    Friend WithEvents NsTextBox1 As NSTextBox
    Friend WithEvents NsTextBox2 As NSTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
