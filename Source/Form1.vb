Imports System.Net
Imports System.Text
Imports Microsoft.Win32

Public Class Form1

    Private Const AppVersion As String = "V1.0"

    Private wc As WebClient
    Private ExitApp As Boolean

    Private FirstStart As Boolean = True
    Private TrayHelpShown As Boolean = False

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Me.Text = "PushBullet Control " & AppVersion
        Me.NotifyIcon1.Text = "PushBullet Control " & AppVersion
        Me.NotifyIcon1.BalloonTipTitle = "PushBullet Control " & AppVersion

        ExitApp = False

        If Not LoadConfig() Then Log("Failed to load config.xml!")

        AddHandler SystemEvents.SessionSwitch, AddressOf WSlockedCheck

    End Sub

    Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        If Not FirstStart Then
            Me.Visible = False
            TrayMsg("PushBullet Control running.")
            If Me.ChWSlockCtrl.Checked Then
                TrayMsg("Workstation Lock Commands ENABLED.")
            Else
                TrayMsg("Workstation Lock Commands DISABLED!")
            End If
        End If

        If Me.ChWSlockCtrl.Checked Then PushNotification(tPushType.WSunlock)

    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.WindowsShutDown Then
            If Me.ChWSlockCtrl.Checked Then PushNotification(tPushType.WSlock)
            ExitApp = True
        End If

        SaveConfig()

        If Not ExitApp Then
            'Minimizing...
            e.Cancel = True
            Me.Visible = False

            If FirstStart And Not TrayHelpShown Then
                TrayMsg("PushBullet Control is still running. Right-click tray icon to close the application.")
                TrayHelpShown = True
            End If

        Else
            'Closing...

        End If

    End Sub

    Private Sub TestPush()
        If Me.TextBox1.Text.Trim = "" Then
            MsgBox("No text entered!")
        Else
            PushNotification(tPushType.Test, Me.TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TestPush()
    End Sub

    Private Sub PushNotification(ByVal PushType As tPushType, Optional ByVal Cmd As String = "")
        Dim parameters As String
        Dim result As String
        Dim LogTxt As String

        Select Case PushType
            Case tPushType.Test
                LogTxt = "Test"

            Case tPushType.WSlock
                LogTxt = "WS locked"
                Cmd = Me.TbLock.Text

            Case Else 'tPushType.WSunlock
                LogTxt = "WS unlocked"
                Cmd = Me.TbUnlock.Text

        End Select

        If Cmd.Trim = "" Then Exit Sub

        Try

            'New  System.Net.WebClient
            wc = New WebClient

            'Header with Access Token (Me.TbToken.Text)
            wc.Headers.Add(HttpRequestHeader.UserAgent, "PushbulletControl" & AppVersion)
            wc.Headers.Add(HttpRequestHeader.Authorization, String.Format("Basic {0}", Convert.ToBase64String(Encoding.UTF8.GetBytes(Me.TbToken.Text & ":"))))
            wc.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded")
            wc.Headers.Add(HttpRequestHeader.Accept, "application/json")

            'Set target device ID (Me.TbDevice.Text)
            parameters = "device_iden=" & Me.TbDevice.Text

            'Set Type
            parameters &= "&type=note"

            'Set message (Cmd)
            parameters &= "&title=PushbulletControl&body=" & Cmd

            'Push
            result = wc.UploadString("https://api.pushbullet.com/v2/pushes", parameters)

            Log("[" & LogTxt & "] Push '" & Cmd & "' successful.")

        Catch ex As Exception

            Log("[" & LogTxt & "] Push '" & Cmd & "' failed!")

        End Try



    End Sub

    Private Sub WSlockedCheck(ByVal sender As Object, ByVal e As SessionSwitchEventArgs)

        If Not Me.ChWSlockCtrl.Checked Then Exit Sub

        If e.Reason = SessionSwitchReason.SessionLock Then
            PushNotification(tPushType.WSlock)
        Else
            PushNotification(tPushType.WSunlock)
        End If
    End Sub

    Private Sub Log(ByVal Msg As String)

        If Me.ChLog.Checked Then Me.RichTextBox1.AppendText(Now.ToString & ": " & Msg & vbCrLf)

        If Me.ChNotif.Checked Then TrayMsg(Msg)

    End Sub

    Private Sub TrayMsg(ByVal Msg As String)
        Me.NotifyIcon1.BalloonTipText = Msg
        Me.NotifyIcon1.ShowBalloonTip(500)
    End Sub

    Private Enum tPushType
        Test
        WSlock
        WSunlock
    End Enum


    Private Sub BtLogClear_Click(sender As System.Object, e As System.EventArgs) Handles BtLogClear.Click
        Me.RichTextBox1.Clear()
    End Sub

    
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitApp = True
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then Me.Visible = True
    End Sub

    Private Function LoadConfig() As Boolean

        Dim xml As XDocument

        If IO.File.Exists(My.Application.Info.DirectoryPath & "\config.xml") Then
            FirstStart = False
        Else
            Return True
        End If

        Try
            xml = XDocument.Load(My.Application.Info.DirectoryPath & "\config.xml")

            Me.TbToken.Text = xml.<PushBulletControl>.<PushBulletAccess>.<AccessToken>.Value
            Me.TbDevice.Text = xml.<PushBulletControl>.<PushBulletAccess>.<device_iden>.Value

            Me.ChWSlockCtrl.Checked = xml.<PushBulletControl>.<Config>.<WSlockControl>.Value
            Me.ChNotif.Checked = xml.<PushBulletControl>.<Config>.<TrayNotification>.Value
            Me.ChLog.Checked = xml.<PushBulletControl>.<Config>.<LogEnabled>.Value

            Me.TbLock.Text = xml.<PushBulletControl>.<Commands>.<WSlock>.Value
            Me.TbUnlock.Text = xml.<PushBulletControl>.<Commands>.<WSunlock>.Value


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Function SaveConfig() As Boolean
        Dim xml As New XDocument
        Dim xe0 As XElement
        Dim xe As XElement

        xe0 = New XElement("PushBulletControl")

        xe = New XElement("PushBulletAccess")
        xe.Add(New XElement("AccessToken", Me.TbToken.Text))
        xe.Add(New XElement("device_iden", Me.TbDevice.Text))
        xe0.Add(xe)

        xe = New XElement("Config")
        xe.Add(New XElement("WSlockControl", Me.ChWSlockCtrl.Checked))
        xe.Add(New XElement("TrayNotification", Me.ChNotif.Checked))
        xe.Add(New XElement("LogEnabled", Me.ChLog.Checked))
        xe0.Add(xe)

        xe = New XElement("Commands")
        xe.Add(New XElement("WSlock", Me.TbLock.Text))
        xe.Add(New XElement("WSunlock", Me.TbUnlock.Text))

        xe0.Add(xe)

        xml.Add(xe0)

        xml.Save(My.Application.Info.DirectoryPath & "\config.xml")

        Return True

    End Function

    Private Sub ChWSlockCtrl_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChWSlockCtrl.CheckedChanged
        Me.Panel1.Enabled = Me.ChWSlockCtrl.Checked
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then TestPush()
    End Sub

End Class
