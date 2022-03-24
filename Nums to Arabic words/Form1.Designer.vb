<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.اللغةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.العربيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.نسخالنصToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ايقافالألوانToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RGBTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(0, 515)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(991, 23)
        Me.TextBox1.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripSplitButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(991, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اللغةToolStripMenuItem, Me.نسخالنصToolStripMenuItem, Me.ايقافالألوانToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'اللغةToolStripMenuItem
        '
        Me.اللغةToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.العربيةToolStripMenuItem, Me.EnglishToolStripMenuItem})
        Me.اللغةToolStripMenuItem.Name = "اللغةToolStripMenuItem"
        Me.اللغةToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.اللغةToolStripMenuItem.Text = "اللغة"
        '
        'العربيةToolStripMenuItem
        '
        Me.العربيةToolStripMenuItem.Name = "العربيةToolStripMenuItem"
        Me.العربيةToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.العربيةToolStripMenuItem.Text = "العربية"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'نسخالنصToolStripMenuItem
        '
        Me.نسخالنصToolStripMenuItem.Name = "نسخالنصToolStripMenuItem"
        Me.نسخالنصToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.نسخالنصToolStripMenuItem.Text = "نسخ النص"
        '
        'ايقافالألوانToolStripMenuItem
        '
        Me.ايقافالألوانToolStripMenuItem.Name = "ايقافالألوانToolStripMenuItem"
        Me.ايقافالألوانToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ايقافالألوانToolStripMenuItem.Text = "ايقاف الألوان"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(0, 85)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(991, 276)
        Me.TextBox2.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.Location = New System.Drawing.Point(12, 367)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(120, 19)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "اضافة ""فقط لا غير"""
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "نسخ/Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Made With Love By:Hassan Abdulbaqi"
        '
        'RGBTimer
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Instagram:1g_di"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(478, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Facebook: Hassan Abdulbaqi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 538)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تفقيط الأرقام"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents اللغةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents العربيةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents نسخالنصToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RGBTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ايقافالألوانToolStripMenuItem As ToolStripMenuItem
End Class
