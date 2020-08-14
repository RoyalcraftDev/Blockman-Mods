Public Class Update
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ProgressBar1.Value = 0 Then
            Timer1.Start()
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 5 Then
            Me.Text = "Loading.."
        ElseIf ProgressBar1.Value = 10 Then
            Me.Text = "Loading..."
        ElseIf ProgressBar1.Value = 15 Then
            Me.Text = "Loading."
        ElseIf ProgressBar1.Value = 20 Then
            Me.Text = "Loading.."
        ElseIf ProgressBar1.Value = 25 Then
            Me.Text = "Loading..."
            Label1.Text = "Checking user data 2/2"
        ElseIf ProgressBar1.Value = 30 Then
            Me.Text = "Loading."
        ElseIf ProgressBar1.Value = 35 Then
            Me.Text = "Loading.."
        ElseIf ProgressBar1.Value = 40 Then
            Me.Text = "Loading..."
        ElseIf ProgressBar1.Value = 45 Then
            Me.Text = "Loading."
        ElseIf ProgressBar1.Value = 50 Then
            Me.Text = "Loading.."
            Label1.Text = "      Inialization"
        ElseIf ProgressBar1.Value = 55 Then
            Me.Text = "Loading..."
        ElseIf ProgressBar1.Value = 60 Then
            Me.Text = "Loading."
        ElseIf ProgressBar1.Value = 65 Then
            Me.Text = "Loading.."
        ElseIf ProgressBar1.Value = 70 Then
            Me.Text = "Loading..."
        ElseIf ProgressBar1.Value = 85 Then
            Me.Text = "Loading."
        ElseIf ProgressBar1.Value = 90 Then
            Me.Text = "Loading.."
        ElseIf ProgressBar1.Value = 95 Then
            Me.Text = "Loading..."
        ElseIf ProgressBar1.Value = 100 Then
            Me.Text = "Finish"
            Label1.Text = "Launching software"
        End If
        If ProgressBar1.Value = 100 Then
            Main.Timer1.Enabled = True
            Main.Timer1.Interval = 5
            Main.Opacity = 0
            Main.Show()
            Me.Hide()
            Timer1.Stop()

        End If
    End Sub
End Class
