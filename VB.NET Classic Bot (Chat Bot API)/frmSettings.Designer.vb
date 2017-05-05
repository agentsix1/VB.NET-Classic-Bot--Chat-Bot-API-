<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbApi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comServer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbChannel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTrigger = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbIdle = New System.Windows.Forms.TextBox()
        Me.chkIdle = New System.Windows.Forms.CheckBox()
        Me.chkGreet = New System.Windows.Forms.CheckBox()
        Me.tbGreet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkSmartGreet = New System.Windows.Forms.CheckBox()
        Me.tbSmartGreet = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPing = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tbIdleTime = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.comServer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbApi)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 54)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sever Settings"
        '
        'tbApi
        '
        Me.tbApi.Location = New System.Drawing.Point(57, 21)
        Me.tbApi.Name = "tbApi"
        Me.tbApi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbApi.Size = New System.Drawing.Size(352, 20)
        Me.tbApi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "API Key"
        '
        'comServer
        '
        Me.comServer.FormattingEnabled = True
        Me.comServer.Items.AddRange(New Object() {"USWest", "USEast", "Asia", "Europe"})
        Me.comServer.Location = New System.Drawing.Point(459, 21)
        Me.comServer.Name = "comServer"
        Me.comServer.Size = New System.Drawing.Size(81, 21)
        Me.comServer.TabIndex = 3
        Me.comServer.Text = "USEast"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Server"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbIdleTime)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbPing)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.chkSmartGreet)
        Me.GroupBox2.Controls.Add(Me.tbSmartGreet)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chkGreet)
        Me.GroupBox2.Controls.Add(Me.tbGreet)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chkIdle)
        Me.GroupBox2.Controls.Add(Me.tbIdle)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbTrigger)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbChannel)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(546, 194)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bot Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Home Channel"
        '
        'tbChannel
        '
        Me.tbChannel.Location = New System.Drawing.Point(9, 34)
        Me.tbChannel.Name = "tbChannel"
        Me.tbChannel.Size = New System.Drawing.Size(152, 20)
        Me.tbChannel.TabIndex = 5
        Me.tbChannel.Text = "Brood War USA-1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Trigger"
        '
        'tbTrigger
        '
        Me.tbTrigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTrigger.Location = New System.Drawing.Point(167, 34)
        Me.tbTrigger.MaxLength = 2
        Me.tbTrigger.Name = "tbTrigger"
        Me.tbTrigger.Size = New System.Drawing.Size(37, 22)
        Me.tbTrigger.TabIndex = 7
        Me.tbTrigger.Text = "."
        Me.tbTrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Idle Message"
        '
        'tbIdle
        '
        Me.tbIdle.Location = New System.Drawing.Point(9, 73)
        Me.tbIdle.Name = "tbIdle"
        Me.tbIdle.Size = New System.Drawing.Size(510, 20)
        Me.tbIdle.TabIndex = 9
        Me.tbIdle.Text = "Idle Message Here"
        '
        'chkIdle
        '
        Me.chkIdle.AutoSize = True
        Me.chkIdle.Location = New System.Drawing.Point(525, 76)
        Me.chkIdle.Name = "chkIdle"
        Me.chkIdle.Size = New System.Drawing.Size(15, 14)
        Me.chkIdle.TabIndex = 10
        Me.chkIdle.UseVisualStyleBackColor = True
        '
        'chkGreet
        '
        Me.chkGreet.AutoSize = True
        Me.chkGreet.Location = New System.Drawing.Point(525, 115)
        Me.chkGreet.Name = "chkGreet"
        Me.chkGreet.Size = New System.Drawing.Size(15, 14)
        Me.chkGreet.TabIndex = 13
        Me.chkGreet.UseVisualStyleBackColor = True
        '
        'tbGreet
        '
        Me.tbGreet.Location = New System.Drawing.Point(9, 112)
        Me.tbGreet.Name = "tbGreet"
        Me.tbGreet.Size = New System.Drawing.Size(510, 20)
        Me.tbGreet.TabIndex = 12
        Me.tbGreet.Text = "Greet Message Here"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Greet Message"
        '
        'chkSmartGreet
        '
        Me.chkSmartGreet.AutoSize = True
        Me.chkSmartGreet.Location = New System.Drawing.Point(525, 155)
        Me.chkSmartGreet.Name = "chkSmartGreet"
        Me.chkSmartGreet.Size = New System.Drawing.Size(15, 14)
        Me.chkSmartGreet.TabIndex = 16
        Me.chkSmartGreet.UseVisualStyleBackColor = True
        '
        'tbSmartGreet
        '
        Me.tbSmartGreet.Location = New System.Drawing.Point(9, 152)
        Me.tbSmartGreet.Name = "tbSmartGreet"
        Me.tbSmartGreet.Size = New System.Drawing.Size(510, 20)
        Me.tbSmartGreet.TabIndex = 15
        Me.tbSmartGreet.Text = "Greet Message Here"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Smart Greet Message"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Ping"
        '
        'tbPing
        '
        Me.tbPing.Enabled = False
        Me.tbPing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPing.Location = New System.Drawing.Point(213, 34)
        Me.tbPing.MaxLength = 2
        Me.tbPing.Name = "tbPing"
        Me.tbPing.Size = New System.Drawing.Size(52, 20)
        Me.tbPing.TabIndex = 17
        Me.tbPing.Text = "0"
        Me.tbPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(483, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.Location = New System.Drawing.Point(402, 272)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(321, 272)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tbIdleTime
        '
        Me.tbIdleTime.Enabled = False
        Me.tbIdleTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdleTime.Location = New System.Drawing.Point(467, 34)
        Me.tbIdleTime.MaxLength = 2
        Me.tbIdleTime.Name = "tbIdleTime"
        Me.tbIdleTime.Size = New System.Drawing.Size(52, 20)
        Me.tbIdleTime.TabIndex = 19
        Me.tbIdleTime.Text = "0"
        Me.tbIdleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(464, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Idle Mins"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(570, 302)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings - VB.NET Classic Bot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comServer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbApi As TextBox
    Friend WithEvents tbIdleTime As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPing As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkSmartGreet As CheckBox
    Friend WithEvents tbSmartGreet As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkGreet As CheckBox
    Friend WithEvents tbGreet As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkIdle As CheckBox
    Friend WithEvents tbIdle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTrigger As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbChannel As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
End Class
