Imports System.Net
Imports System.Threading
Imports System.Xml
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.WebBrowser

Public Class TTSD
    ' Form Loader
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()

    End Sub
    ' Time & Date
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("dd MMMM yyyy, h:mm:ss tt")
        Label1.Location = New Point(618, 350)
    End Sub
    ' Min & Close
    Private Sub NsLabel13_Click(sender As Object, e As EventArgs) Handles NsLabel13.Click
        Me.Close()
    End Sub

    Private Sub NsLabel2_Click(sender As Object, e As EventArgs) Handles NsLabel2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    ' On/Off Box's
    Private Sub NsOnOffBox1_CheckedChanged(sender As Object) Handles NsOnOffBox1.CheckedChanged
        If NsOnOffBox1.Checked = True Then
            Me.TopMost = True
        End If
        If NsOnOffBox1.Checked = False Then
            Me.TopMost = False
        End If
    End Sub
End Class
