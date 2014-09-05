<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TbToken = New System.Windows.Forms.TextBox()
        Me.TbDevice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChWSlockCtrl = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChLog = New System.Windows.Forms.CheckBox()
        Me.BtLogClear = New System.Windows.Forms.Button()
        Me.ChNotif = New System.Windows.Forms.CheckBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbUnlock = New System.Windows.Forms.TextBox()
        Me.TbLock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrTest = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrTest.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbToken
        '
        Me.TbToken.Location = New System.Drawing.Point(99, 23)
        Me.TbToken.Name = "TbToken"
        Me.TbToken.Size = New System.Drawing.Size(298, 20)
        Me.TbToken.TabIndex = 0
        '
        'TbDevice
        '
        Me.TbDevice.Location = New System.Drawing.Point(99, 49)
        Me.TbDevice.Name = "TbDevice"
        Me.TbDevice.Size = New System.Drawing.Size(298, 20)
        Me.TbDevice.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Push"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Access Token"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "device_iden"
        '
        'ChWSlockCtrl
        '
        Me.ChWSlockCtrl.AutoSize = True
        Me.ChWSlockCtrl.Checked = True
        Me.ChWSlockCtrl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChWSlockCtrl.Location = New System.Drawing.Point(14, 19)
        Me.ChWSlockCtrl.Name = "ChWSlockCtrl"
        Me.ChWSlockCtrl.Size = New System.Drawing.Size(65, 17)
        Me.ChWSlockCtrl.TabIndex = 7
        Me.ChWSlockCtrl.Text = "Enabled"
        Me.ChWSlockCtrl.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 48)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(391, 126)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChLog)
        Me.GroupBox1.Controls.Add(Me.BtLogClear)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 180)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log"
        '
        'ChLog
        '
        Me.ChLog.AutoSize = True
        Me.ChLog.Checked = True
        Me.ChLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChLog.Location = New System.Drawing.Point(9, 23)
        Me.ChLog.Name = "ChLog"
        Me.ChLog.Size = New System.Drawing.Size(65, 17)
        Me.ChLog.TabIndex = 0
        Me.ChLog.Text = "Enabled"
        Me.ChLog.UseVisualStyleBackColor = True
        '
        'BtLogClear
        '
        Me.BtLogClear.Location = New System.Drawing.Point(340, 19)
        Me.BtLogClear.Name = "BtLogClear"
        Me.BtLogClear.Size = New System.Drawing.Size(57, 23)
        Me.BtLogClear.TabIndex = 1
        Me.BtLogClear.Text = "Clear"
        Me.BtLogClear.UseVisualStyleBackColor = True
        '
        'ChNotif
        '
        Me.ChNotif.AutoSize = True
        Me.ChNotif.Checked = True
        Me.ChNotif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChNotif.Location = New System.Drawing.Point(18, 454)
        Me.ChNotif.Name = "ChNotif"
        Me.ChNotif.Size = New System.Drawing.Size(106, 17)
        Me.ChNotif.TabIndex = 4
        Me.ChNotif.Text = "Tray notifications"
        Me.ChNotif.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.ChWSlockCtrl)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 86)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Workstation Lock Commands"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TbUnlock)
        Me.Panel1.Controls.Add(Me.TbLock)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 40)
        Me.Panel1.TabIndex = 9
        '
        'TbUnlock
        '
        Me.TbUnlock.Location = New System.Drawing.Point(301, 10)
        Me.TbUnlock.Name = "TbUnlock"
        Me.TbUnlock.Size = New System.Drawing.Size(90, 20)
        Me.TbUnlock.TabIndex = 1
        '
        'TbLock
        '
        Me.TbLock.Location = New System.Drawing.Point(87, 10)
        Me.TbLock.Name = "TbLock"
        Me.TbLock.Size = New System.Drawing.Size(90, 20)
        Me.TbLock.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Unlock Command"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lock Command"
        '
        'GrTest
        '
        Me.GrTest.Controls.Add(Me.TextBox1)
        Me.GrTest.Controls.Add(Me.Button1)
        Me.GrTest.Controls.Add(Me.Label1)
        Me.GrTest.Location = New System.Drawing.Point(12, 193)
        Me.GrTest.Name = "GrTest"
        Me.GrTest.Size = New System.Drawing.Size(403, 58)
        Me.GrTest.TabIndex = 2
        Me.GrTest.TabStop = False
        Me.GrTest.Text = "Test"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Note"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TbToken)
        Me.GroupBox4.Controls.Add(Me.TbDevice)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(403, 83)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PushBullet Access"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 486)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GrTest)
        Me.Controls.Add(Me.ChNotif)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GrTest.ResumeLayout(False)
        Me.GrTest.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbToken As System.Windows.Forms.TextBox
    Friend WithEvents TbDevice As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChWSlockCtrl As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtLogClear As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChNotif As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TbUnlock As System.Windows.Forms.TextBox
    Friend WithEvents TbLock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrTest As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChLog As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
