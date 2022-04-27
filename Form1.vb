Public Class Form1
    Dim colortext As Integer
    Dim r As Integer
    Dim g As Integer
    Dim b As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Left = (Me.Width - Button1.Width) / 2
        Button1.Top = Me.Height / 4
        title.Left = (Me.Width - title.Width) / 2 - 50
        title.Top = Button1.Top + Button1.Top / -1.2
        htp.Left = (Me.Width - htp.Width) / 2
        htp.Top = Button1.Top + Button1.Top / 2
        lbexit.Left = Button1.Left - 20
        lbexit.Top = lbcredits.Top - 20
        lbexit.ForeColor = Color.Red
        lbcredits.Left = Button1.Left - 20
        lbcredits.Top = Button1.Top * 2
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r = Int(Rnd() * 255)
        g = Int(Rnd() * 255)
        b = Int(Rnd() * 255)
        title.ForeColor = Color.FromArgb(0, r, g, b)
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Text = ">Play!"
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Text = "Play!"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GameLoad.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub
    Private Sub htp_MouseEnter(sender As Object, e As EventArgs) Handles htp.MouseEnter
        htp.Text = ">How to Play"
    End Sub
    Private Sub htp_MouseLeave(sender As Object, e As EventArgs) Handles htp.MouseLeave
        htp.Text = "How to Play"
    End Sub

    Private Sub lbexit_MouseEnter(sender As Object, e As EventArgs) Handles lbexit.MouseEnter
        lbexit.Text = ">EXIT!"
    End Sub

    Private Sub lbexit_MouseLeave(sender As Object, e As EventArgs) Handles lbexit.MouseLeave
        lbexit.Text = "EXIT!"
    End Sub

    Private Sub lbexit_Click(sender As Object, e As EventArgs) Handles lbexit.Click
        End
    End Sub

    Private Sub htp_Click(sender As Object, e As EventArgs) Handles htp.Click
        HowToPlay.Show()
        Me.Hide()
    End Sub

    Private Sub lbcredits_MouseEnter(sender As Object, e As EventArgs) Handles lbcredits.MouseEnter
        lbcredits.Text = ">Credits"
    End Sub

    Private Sub lbcredits_MouseLeave(sender As Object, e As EventArgs) Handles lbcredits.MouseLeave
        lbcredits.Text = "Credits"
    End Sub

    Private Sub lbcredits_Click(sender As Object, e As EventArgs) Handles lbcredits.Click
        Me.Hide()
        Timer1.Enabled = False
        Credits.Show()
        Credits.Timer1.Enabled = True

    End Sub
End Class
