Public Class frmMain
    Public chat = "<body bgcolor=black></body><font color=white>"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wbChat.Navigate("about:blank")
        wbChat.Document.OpenNew(False)
        wbChat.Document.Write(chat)
        wbChat.Refresh()
        Me.BackgroundImage = My.Resources.Channel___SC1_Layout
        wbChat.IsWebBrowserContextMenuEnabled = False
        wbFriendsChannel.IsWebBrowserContextMenuEnabled = False
    End Sub

    Private Sub sendChat(sender As Object, e As KeyEventArgs) Handles tbChat.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            wbChat.Document.OpenNew(False)
            wbChat.Document.Write(chat & tbChat.Text & "<br />")
            chat = chat & tbChat.Text & "<br />"
            wbChat.Refresh()
            tbChat.Clear()
            tmrChatFocus.Enabled = True
        End If
    End Sub

    Private Sub tmrChatFocus_Tick(sender As Object, e As EventArgs) Handles tmrChatFocus.Tick
        tbChat.Focus()
        tmrChatFocus.Enabled = False
    End Sub

    Private Sub lblFriendCount_Click(sender As Object, e As EventArgs) Handles lblFriendCount.Click
        btnFriends_Click(sender, e)
    End Sub

    Private Sub lblChannelCount_Click(sender As Object, e As EventArgs) Handles lblChannelCount.Click
        btnChannel_Click(sender, e)
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        Me.BackgroundImage = My.Resources.Friends___SC_Layout
    End Sub

    Private Sub btnChannel_Click(sender As Object, e As EventArgs) Handles btnChannel.Click
        Me.BackgroundImage = My.Resources.Channel___SC1_Layout
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        wbChat.Document.OpenNew(False)
        wbChat.Document.Write(chat & "Add Function Here")
        wbChat.Refresh()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmSettings.Show()
    End Sub
End Class
