Imports System.Net
Imports System.Threading

Public Class Login
    ' Form Loader
    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TopMost = True
    End Sub
    ' Min & Close
    Private Sub NsLabel13_Click(sender As Object, e As EventArgs) Handles NsLabel13.Click
        Me.Close()
    End Sub

    Private Sub NsLabel2_Click(sender As Object, e As EventArgs) Handles NsLabel2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ' Login Button
    Private Sub NsButton4_Click(sender As Object, e As EventArgs) Handles NsButton4.Click
        Timer1.Start()
        Try
            If NsTextBox6.Text = "" Then
                MsgBox("Please Enter Your Username", MsgBoxStyle.Critical)
            End If
            If TextBox1.Text = "" Then
                MsgBox("Please Enter Your Password", MsgBoxStyle.Critical)
            Else
                Dim login As Thread = New Thread(AddressOf auth)
                login.Start()
                CheckForIllegalCrossThreadCalls = 0
            End If
        Catch ex As Exception
            MsgBox("There was a unknown error :( Try again!", MsgBoxStyle.Critical)
        End Try
    End Sub
    ' Thread for Login
    Private Sub auth(ByVal bka)
        Dim c As New WebClient
        c.Proxy = Nothing
        Dim API As String = ("http://api.gfysc.org/user.php?")
        Dim getinfo As String = c.DownloadString(API + "user=" + NsTextBox6.Text)
        Dim getinfo2 As String = c.DownloadString(API + "user=" + TextBox1.Text)
        NsTextBox1.Text = getinfo
        NsTextBox2.Text = getinfo2
    End Sub
    ' Timer For Login Thread
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If NsTextBox1.Text = "This Key is incorrect" Then
                Timer1.Stop()
                MsgBox("The Username Is Incorrect", MsgBoxStyle.Critical)
            End If
            If NsTextBox2.Text = "This Key is incorrect" Then
                Timer1.Stop()
                MsgBox("The Password Is Incorrect", MsgBoxStyle.Critical)
            End If
            If NsTextBox1.Text = "Go Girl!" And NsTextBox2.Text = "Go Girl!" Then
                TTSD.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("There was a unknown error :( Try again!", MsgBoxStyle.Critical)
        End Try
    End Sub
    ' EnterKey For Login
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            NsButton4_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class