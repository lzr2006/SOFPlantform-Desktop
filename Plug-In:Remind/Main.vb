Public Class Main
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (
                                              ByVal hwnd As IntPtr,
                                              ByVal wMsg As Integer,
                                              ByVal wParam As Integer,
                                              ByVal lParam As Integer) _
                                              As Boolean
    Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean
    Const WM_SYSCOMMAND = &H112
    Const SC_MOVE = &HF010&
    Const HTCAPTION = 2
    Dim K As Int64 = 1644049999
    Private Sub Panel_Top_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Top.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nt As String = DateTime.Now
        Label_Time.Text = nt.Split(" ")(3)
    End Sub

    Private Sub PictureBox_Exit_Click(sender As Object, e As EventArgs) Handles PictureBox_Exit.Click
        Environment.Exit(0)
    End Sub

    Private Sub Timer_timeGetHandler_Tick(sender As Object, e As EventArgs) Handles Timer_timeGetHandler.Tick
        Dim nt As String = DateTime.Now
        Label_Time.Text = "现在是：" + nt
        Dim Unix As String = TimeToUnix(nt)
        Label2.Text = "任务剩余时间：" + (K - (Convert.ToInt64(Unix)-28801)).ToString()
    End Sub

    Public Function TimeToUnix(ByVal dteDate As Date) As String
        If dteDate.IsDaylightSavingTime = True Then
            dteDate = DateAdd(DateInterval.Hour, -1, dteDate)
        End If
        TimeToUnix = DateDiff(DateInterval.Second, #1/1/1970#, dteDate)
    End Function

    Private Sub Label_SayHello_Click(sender As Object, e As EventArgs) Handles Label_SayHello.Click

    End Sub

    Private Sub Panel_Top_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Top.Paint

    End Sub
End Class
