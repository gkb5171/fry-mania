Public Class GameLoad
    Dim fries(0 To 20) As PictureBox
    Dim leftpos As Integer
    Dim frycheck(0 To 20) As Boolean
    Dim fryfall(0 To 20) As Boolean
    Dim counter As Integer
    Dim speedcounter As Integer
    Dim dx As Integer
    Dim health As Integer
    Dim timecounter As Integer
    Dim heart(0 To 9) As PictureBox
    Dim steam As Boolean
    Dim steamflip As Integer
    Dim rndpowerup As Integer
    Dim heartdrop As PictureBox
    Dim heartfall As Boolean
    Dim oilflip As Integer
    Dim protectglove As PictureBox
    Dim protectfall As Boolean
    Dim protection As Boolean
    Dim protectioncounter As Integer
    Dim frycounter As Integer


    Private Sub Game_Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        health = 100
        counter = 0
        dx = 5
        score = 0
        Timer1.Enabled = False
        hour = 0
        min = 0
        second = 0
        steamflip = False
        highscoremem = 0
        Label8.Visible = False
        Label6.Visible = False
        heart(9) = heart2
        heart(8) = heart1
        heart(7) = heart3
        heart(6) = heart4
        heart(5) = heart5
        heart(4) = heart6
        heart(3) = heart7
        heart(2) = heart8
        heart(1) = heart9
        heart(0) = heart10
        For x = 0 To 20
            leftpos = Int(Rnd() * Me.Width - 250) + 200
            fries(x) = New PictureBox
            fries(x).Top = 0
            fries(x).Left = leftpos
            fries(x).Image = My.Resources.Fry_animation
            fries(x).SizeMode = PictureBoxSizeMode.AutoSize
            frycheck(x) = False
            fries(x).Visible = True
            Controls.Add(fries(x))
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timemem += 1
        'Power up code

        If heartfall = True Then
            heartdrop.Top += dx
            If heartdrop.Bounds.IntersectsWith(pbsteam1.Bounds) Then
                heartfall = False
                heartdrop.Visible = False
                heartdrop.Top = 0
            ElseIf heartdrop.Bounds.IntersectsWith(basket.Bounds) And health < 100 Then
                health += 10
                heartfall = False
                heartdrop.Visible = False
                heartdrop.Top = 0
            ElseIf heartdrop.Bounds.IntersectsWith(basket.Bounds) And health = 100 Then
                heartfall = False
                heartdrop.Visible = False
                heartdrop.Top = 0
            End If
        ElseIf protectfall = True Then
            protectioncounter += 1
            protectglove.Top += dx
            If protectglove.Bounds.IntersectsWith(pbsteam1.Bounds) Then
                protectfall = False
                protectglove.Visible = False
                protectglove.Top = 0
            ElseIf protectglove.Bounds.IntersectsWith(basket.Bounds) Then
                protection = True
                protectfall = False
                protectglove.Visible = False
                protectglove.Top = 0
            End If
        End If
        rndpowerup = Int(Rnd() * 10000) + 1
        If protection = True Then
            protectioncounter += 1
            If protectioncounter = 500 Then
                protection = False
                protectfall = False
                protectglove.Visible = False
                protectglove.Top = 0
                protectioncounter = 0
            End If
        End If
        If rndpowerup = 34 And heartfall = False Then
            heartdrop = New PictureBox
            heartdrop.Image = My.Resources.Hearts
            heartdrop.SizeMode = PictureBoxSizeMode.StretchImage
            heartdrop.Width = 25
            heartdrop.Height = 25
            heartdrop.Visible = True
            heartdrop.Top = 0
            heartdrop.Left = Int(Rnd() * Me.Width - 250) + 200
            heartfall = True
            Controls.Add(heartdrop)
        ElseIf rndpowerup = 64 And protectfall = False Then
            protectglove = New PictureBox
            protectglove.Image = My.Resources.Black_Hexagon_Wallpaper
            protectglove.Size = New Size(30, 30)
            protectglove.Left = Int(Rnd() * Me.Width - 250) + 200
            protectglove.Top = 0
            protectglove.Visible = True
            protectglove.SizeMode = PictureBoxSizeMode.StretchImage
            protectfall = True
            Controls.Add(protectglove)
        End If
        'steam animation
        steamflip += 1
        If steamflip < 20 Then
            pbsteam1.Image = My.Resources.steam1
        ElseIf steamflip >= 20 And steamflip < 45 Then
            pbsteam1.Image = My.Resources.steam2
        ElseIf steamflip = 45 Then
            steamflip = 0
        End If
        'oil animation
        oilflip += 1
        If oilflip < 15 Then
            oil.Image = My.Resources.oil1
        ElseIf oilflip >= 15 And oilflip < 30 Then
            oil.Image = My.Resources.oil2
        ElseIf oilflip >= 30 And oilflip < 45 Then
            oil.Image = My.Resources.oil3
        ElseIf oilflip = 46 Then
            oilflip = 0
        End If


        'if basket hits wall
        If MousePosition.X >= 2020 Then
            basket.Left = 2020

        ElseIf MousePosition.X = 0 Then
            basket.Left = 2015
        Else
            basket.Left = MousePosition.X
        End If



        If health > 0 Then
            timecounter += 1
        Else
            timecounter += 0
        End If
        basket.Left = MousePosition.X
        'health code
        If health = 100 Then
            For x = 0 To 9
                heart(x).Visible = True
            Next
        ElseIf health = 90 Then
            For x = 0 To 8
                heart(x).Visible = True
            Next
            heart(9).Visible = False
        ElseIf health = 80 Then
            For x = 0 To 7
                heart(x).Visible = True
            Next
            For x = 8 To 9
                heart(x).Visible = False
            Next
        ElseIf health = 70 Then
            For x = 0 To 6
                heart(x).Visible = True
            Next
            For x = 7 To 9
                heart(x).Visible = False
            Next
        ElseIf health = 60 Then
            For x = 0 To 5
                heart(x).Visible = True
            Next
            For x = 6 To 9
                heart(x).Visible = False
            Next
        ElseIf health = 50 Then
            For x = 0 To 4
                heart(x).Visible = True
            Next
            For x = 5 To 9
                heart(x).Visible = False
            Next
        ElseIf health = 40 Then
            For x = 0 To 3
                heart(x).Visible = True
            Next
            For x = 4 To 9
                heart(x).Visible = False
            Next
        ElseIf health = 30 Then
            For x = 0 To 2
                heart(x).Visible = True
            Next
            For x = 3 To 9
                heart(x).Visible = False
            Next
        ElseIf health = 20 Then
            For x = 0 To 1
                heart(x).Visible = True
            Next
            For x = 2 To 9
                heart(x).Visible = False
            Next
        ElseIf health = 10 Then
            heart(0).Visible = True
            For x = 1 To 9
                heart(x).Visible = False
            Next
        End If


        Scoreval.Text = counter
        Scoreval.Text = score
        If score > highscoremem Then
            highscoremem = score
            newhighscore = True
        Else
            score = score
        End If
        counter += 1
        'drop speed
        secsdis.Text = second
        mindis.Text = min
        hourdis.Text = hour

        If timecounter = 100 And second < 60 Then
            second += 1
            timecounter = 0
        ElseIf timecounter = 100 And second = 60 And min < 60 Then
            min += 1
            second = 0
            timecounter = 0
        ElseIf timecounter = 100 And min = 60 And second = 60 Then
            hour += 1
            min = 0
            second = 0
            timecounter = 0
        End If
        If score < 1000 Then
            dx = 5
        ElseIf score > 1000 And score <= 2000 Then
            dx = 7
        ElseIf score > 2000 And score <= 3000 Then
            dx = 9
        ElseIf score > 3000 And score <= 4000 Then
            dx = 11
        ElseIf score > 4000 Then
            dx = 13
        End If
        If counter = 1001 Then counter = 0

        'determining when and where fry will/if drop and if it hits basket
        leftpos = Int(Rnd() * Me.Width - 250) + 200
        For x = 0 To 20
            If fryfall(x) = True Then
                fries(x).Top += dx
            End If
            If fries(x).Bounds.IntersectsWith(pbsteam1.Bounds) And protection = False Then
                fries(x).Top = 0
                fries(x).Left = leftpos
                frycheck(x) = False
                fryfall(x) = False
                health += -10
                counter = 0
            End If
            If fries(x).Bounds.IntersectsWith(basket.Bounds) Then
                score += 100
                fries(x).Top = 0
                fries(x).Left = leftpos
                frycheck(x) = False
                fryfall(x) = False
                counter = 0
            End If
        Next
        'Choosing which fry will drop
        If counter = 10 And frycheck(0) = False Then
            fryfall(0) = True
            fries(0).Visible = True
        ElseIf counter = 50 And frycheck(1) = False Then
            fryfall(1) = True
            fries(1).Visible = True
        ElseIf counter = 100 And frycheck(2) = False Then
            fryfall(2) = True
            fries(2).Visible = True
        ElseIf counter = 150 And frycheck(3) = False Then
            fryfall(3) = True
            fries(3).Visible = True
        ElseIf counter = 200 And frycheck(4) = False Then
            fryfall(4) = True
            fries(4).Visible = True
        ElseIf counter = 250 And frycheck(5) = False Then
            fryfall(5) = True
            fries(5).Visible = True
        ElseIf counter = 300 And frycheck(6) = False Then
            fryfall(6) = True
            fries(6).Visible = True
        ElseIf counter = 350 And frycheck(7) = False Then
            fryfall(7) = True
            fries(7).Visible = True
        ElseIf counter = 400 And frycheck(8) = False Then
            fryfall(8) = True
            fries(8).Visible = True
        ElseIf counter = 450 And frycheck(9) = False Then
            fryfall(9) = True
            fries(9).Visible = True
        ElseIf counter = 500 And frycheck(10) = False Then
            fryfall(10) = True
            fries(10).Visible = True
        ElseIf counter = 550 And frycheck(11) = False Then
            fryfall(11) = True
            fries(11).Visible = True
        ElseIf counter = 55 And frycheck(12) = False Then
            fryfall(12) = True
            fries(12).Visible = True
        ElseIf counter = 155 And frycheck(13) = False Then
            fryfall(13) = True
            fries(13).Visible = True
        ElseIf counter = 205 And frycheck(14) = False Then
            fryfall(14) = True
            fries(14).Visible = True
        ElseIf counter = 255 And frycheck(15) = False Then
            fryfall(15) = True
            fries(15).Visible = True
        ElseIf counter = 305 And frycheck(16) = False Then
            fryfall(16) = True
            fries(16).Visible = True
        ElseIf counter = 355 And frycheck(17) = False Then
            fryfall(17) = True
            fries(17).Visible = True
        ElseIf counter = 405 And frycheck(18) = False Then
            fryfall(18) = True
            fries(18).Visible = True
        ElseIf counter = 950 And frycheck(19) = False Then
            fryfall(19) = True
            fries(19).Visible = True
        ElseIf counter = 1000 And frycheck(20) = False Then
            fryfall(20) = True
            fries(20).Visible = True
        End If
















        'lose condition
        If health = 0 Then
            yes = True
            Timer1.Enabled = False
            submitbtn.Show()
            Me.Hide()
            For x = 0 To 20
                leftpos = Int(Rnd() * Me.Width - 250) + 200
                fries(x).Top = 0
                fries(x).Left = leftpos
                fryfall(x) = False
                frycheck(x) = False
            Next
            submitbtn.Timer1.Enabled = True
            Cursor.Show()
            health = 100
            counter = 0
            speedcounter = 0
            timecounter = 0
            'submitbtn.lbhsname.Text = READplayers.ReadLine()
            'submitbtn.lbhsvalue.Text = READscore.ReadLine()

        End If
    End Sub

    Private Sub GameLoad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Keys.Space Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            ElseIf Timer1.Enabled = False Then
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Scoreval_Click(sender As Object, e As EventArgs) Handles Scoreval.Click

    End Sub
End Class