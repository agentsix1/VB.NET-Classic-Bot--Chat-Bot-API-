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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.wbChat = New System.Windows.Forms.WebBrowser()
        Me.wbFriendsChannel = New System.Windows.Forms.WebBrowser()
        Me.btnCreate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFriends = New System.Windows.Forms.Label()
        Me.btnChannel = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Label()
        Me.btnChannels = New System.Windows.Forms.Label()
        Me.btnAddFriend = New System.Windows.Forms.Label()
        Me.tbChat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tmrChatFocus = New System.Windows.Forms.Timer(Me.components)
        Me.lblFriendCount = New System.Windows.Forms.Label()
        Me.lblChannelCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'wbChat
        '
        Me.wbChat.AllowNavigation = False
        Me.wbChat.Location = New System.Drawing.Point(55, 174)
        Me.wbChat.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbChat.Name = "wbChat"
        Me.wbChat.ScriptErrorsSuppressed = True
        Me.wbChat.Size = New System.Drawing.Size(656, 694)
        Me.wbChat.TabIndex = 1
        '
        'wbFriendsChannel
        '
        Me.wbFriendsChannel.Location = New System.Drawing.Point(780, 174)
        Me.wbFriendsChannel.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbFriendsChannel.Name = "wbFriendsChannel"
        Me.wbFriendsChannel.Size = New System.Drawing.Size(396, 598)
        Me.wbFriendsChannel.TabIndex = 2
        '
        'btnCreate
        '
        Me.btnCreate.AutoEllipsis = True
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.Location = New System.Drawing.Point(64, 42)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(242, 54)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(320, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.UseCompatibleTextRendering = True
        '
        'btnFriends
        '
        Me.btnFriends.AutoEllipsis = True
        Me.btnFriends.BackColor = System.Drawing.Color.Transparent
        Me.btnFriends.Location = New System.Drawing.Point(774, 118)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Size = New System.Drawing.Size(200, 45)
        Me.btnFriends.TabIndex = 5
        Me.btnFriends.UseCompatibleTextRendering = True
        '
        'btnChannel
        '
        Me.btnChannel.AutoEllipsis = True
        Me.btnChannel.BackColor = System.Drawing.Color.Transparent
        Me.btnChannel.Location = New System.Drawing.Point(980, 118)
        Me.btnChannel.Name = "btnChannel"
        Me.btnChannel.Size = New System.Drawing.Size(196, 45)
        Me.btnChannel.TabIndex = 6
        Me.btnChannel.UseCompatibleTextRendering = True
        '
        'btnQuit
        '
        Me.btnQuit.AutoEllipsis = True
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.Location = New System.Drawing.Point(924, 890)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(279, 61)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.UseCompatibleTextRendering = True
        '
        'btnChannels
        '
        Me.btnChannels.AutoEllipsis = True
        Me.btnChannels.BackColor = System.Drawing.Color.Transparent
        Me.btnChannels.Location = New System.Drawing.Point(773, 807)
        Me.btnChannels.Name = "btnChannels"
        Me.btnChannels.Size = New System.Drawing.Size(213, 61)
        Me.btnChannels.TabIndex = 8
        Me.btnChannels.Text = "agentsix1"
        Me.btnChannels.UseCompatibleTextRendering = True
        '
        'btnAddFriend
        '
        Me.btnAddFriend.AutoEllipsis = True
        Me.btnAddFriend.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFriend.Location = New System.Drawing.Point(980, 807)
        Me.btnAddFriend.Name = "btnAddFriend"
        Me.btnAddFriend.Size = New System.Drawing.Size(232, 61)
        Me.btnAddFriend.TabIndex = 9
        Me.btnAddFriend.UseCompatibleTextRendering = True
        '
        'tbChat
        '
        Me.tbChat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbChat.BackColor = System.Drawing.Color.Black
        Me.tbChat.ForeColor = System.Drawing.Color.White
        Me.tbChat.Location = New System.Drawing.Point(62, 892)
        Me.tbChat.Name = "tbChat"
        Me.tbChat.Size = New System.Drawing.Size(637, 20)
        Me.tbChat.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(846, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 45)
        Me.Label2.TabIndex = 11
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(846, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 45)
        Me.Label3.TabIndex = 12
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.UseCompatibleTextRendering = True
        '
        'tmrChatFocus
        '
        Me.tmrChatFocus.Interval = 1
        '
        'lblFriendCount
        '
        Me.lblFriendCount.AutoEllipsis = True
        Me.lblFriendCount.BackColor = System.Drawing.Color.Black
        Me.lblFriendCount.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriendCount.ForeColor = System.Drawing.Color.White
        Me.lblFriendCount.Location = New System.Drawing.Point(896, 125)
        Me.lblFriendCount.Name = "lblFriendCount"
        Me.lblFriendCount.Size = New System.Drawing.Size(78, 35)
        Me.lblFriendCount.TabIndex = 13
        Me.lblFriendCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFriendCount.UseCompatibleTextRendering = True
        '
        'lblChannelCount
        '
        Me.lblChannelCount.AutoEllipsis = True
        Me.lblChannelCount.BackColor = System.Drawing.Color.Black
        Me.lblChannelCount.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannelCount.ForeColor = System.Drawing.Color.White
        Me.lblChannelCount.Location = New System.Drawing.Point(1098, 125)
        Me.lblChannelCount.Name = "lblChannelCount"
        Me.lblChannelCount.Size = New System.Drawing.Size(78, 35)
        Me.lblChannelCount.TabIndex = 14
        Me.lblChannelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblChannelCount.UseCompatibleTextRendering = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1247, 960)
        Me.Controls.Add(Me.lblChannelCount)
        Me.Controls.Add(Me.lblFriendCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbChat)
        Me.Controls.Add(Me.btnAddFriend)
        Me.Controls.Add(Me.btnChannels)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnChannel)
        Me.Controls.Add(Me.btnFriends)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.wbFriendsChannel)
        Me.Controls.Add(Me.wbChat)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "VB.NET Classic Bot (Chat Bot)"
        Me.TransparencyKey = System.Drawing.Color.Coral
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wbChat As WebBrowser
    Friend WithEvents wbFriendsChannel As WebBrowser
    Friend WithEvents btnCreate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFriends As Label
    Friend WithEvents btnChannel As Label
    Friend WithEvents btnQuit As Label
    Friend WithEvents btnChannels As Label
    Friend WithEvents btnAddFriend As Label
    Friend WithEvents tbChat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tmrChatFocus As Timer
    Friend WithEvents lblFriendCount As Label
    Friend WithEvents lblChannelCount As Label
End Class
