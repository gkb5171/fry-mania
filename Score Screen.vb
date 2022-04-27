Imports System.IO
Public Class submitbtn
    Dim i, tot As Integer
    Dim scores(5) As String 'array for score
    Dim names(5) As String 'array for names
    Dim falls(0 To 25) As PictureBox
    Dim rendered As Boolean

    Dim playername As String

    Private Sub lbgohome_Click(sender As Object, e As EventArgs) Handles lbgohome.Click
        Form1.Show()
        Me.Hide()
        Cursor.Show()
        Timer1.Enabled = False
        Form1.Timer1.Enabled = True
        FILEscore.Close()
        FILEplayers.Close()
    End Sub

    Private Sub lbplayagain_Click(sender As Object, e As EventArgs) Handles lbplayagain.Click
        GameLoad.Show()
        Me.Hide()
        Cursor.Hide()
        Timer1.Enabled = False
        hour = 0
        min = 0
        second = 0
        score = 0
        FILEscore.Close()
        FILEplayers.Close()
    End Sub

    Private Sub lbgohome_MouseEnter(sender As Object, e As EventArgs) Handles lbgohome.MouseEnter
        lbgohome.Text = "< Go Home"
    End Sub

    Private Sub lbgohome_MouseLeave(sender As Object, e As EventArgs) Handles lbgohome.MouseLeave
        lbgohome.Text = "Go Home"
    End Sub

    Private Sub lbplayagain_MouseEnter(sender As Object, e As EventArgs) Handles lbplayagain.MouseEnter
        lbplayagain.Text = ">Play Again?"

    End Sub

    Private Sub lbplayagain_MouseLeave(sender As Object, e As EventArgs) Handles lbplayagain.MouseLeave
        lbplayagain.Text = "Play Again?"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If newhighscore = True Then
            txname.Visible = True
            Button1.Visible = True
        Else
            txname.Visible = False
            Button1.Visible = False
        End If
        timesec = timemem / 100
        lbtime.Text = hour & ":" & min & ":" & second
        'lbhsvalue.Text = highscoremem
        lbscore.Text = score
        If newhighscore = True Then
            Dim highnumr As Integer
            Dim randg As Integer
            Dim highnumb As Integer
            highnumr = Int(Rnd() * 255)
            highnumb = Int(Rnd() * 255)
            randg = Int(Rnd() * 255)
            lbhighscore1.ForeColor = Color.FromArgb(0, highnumr, randg, highnumb)
            lbhsvalue.ForeColor = Color.FromArgb(0, highnumr, randg, highnumb)
        End If
    End Sub

    Private Sub txname_TextChanged(sender As Object, e As EventArgs) Handles txname.TextChanged
        If txname.Visible = True Then
            playername = txname.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Visible = True Then
            WRITEplayers.WriteLine(vbNewLine, txname.Text)
            WRITEscore.WriteLine(vbNewLine, Str(score))
            lbhsname.Text = READplayers.ReadLine()
            lbhsvalue.Text = READscore.ReadLine()
        End If
    End Sub

    Private Sub Score_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yes = True



    End Sub
End Class