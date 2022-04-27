Public Class Credits
    Dim lbgraphicmaker, lbcodewritter, lbteacher, lbpublisher, lbsoftwarebrand As Label
    Dim graphicmaker, codewritter, teacher, publisher, softwarebrand As PictureBox

    Dim spinningFry(5) As PictureBox
    Dim credcounter As Integer
    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        'graphic designer code
        graphicmaker = New PictureBox
        graphicmaker.Image = My.Resources.French_Fry
        graphicmaker.SizeMode = PictureBoxSizeMode.StretchImage
        graphicmaker.BackColor = Color.Transparent
        graphicmaker.Left = Me.Width / 2
        graphicmaker.Top = Me.Height / 2
        graphicmaker.Width = Me.Width / 4
        graphicmaker.Height = Me.Width / 8
        graphicmaker.Visible = False
        Controls.Add(graphicmaker)

        'have the label placed on top of picture box
        lbgraphicmaker = New Label
        lbgraphicmaker.AutoSize = False
        lbgraphicmaker.Text = "Greg Blickley"
        lbgraphicmaker.Font = New Font("MV Boli", 30, FontStyle.Bold)
        lbgraphicmaker.ForeColor = Color.Black
        lbgraphicmaker.BackColor = Color.Transparent
        Controls.Add(lbgraphicmaker)

        'Coder code
        codewritter = New PictureBox
        codewritter.Image = My.Resources.French_Fry
        codewritter.AutoSize = False
        codewritter.Text = "Greg Blickley"
        codewritter.Font = New Font("MV Boli", 48, FontStyle.Bold)
        codewritter.ForeColor = Color.Black
        codewritter.Left = Me.Width / 2
        codewritter.Top = Me.Height / 2
        codewritter.Width = Me.Width / 4
        codewritter.Height = Me.Width / 8
        codewritter.Visible = False
        Controls.Add(codewritter)

        'Teacher Code
        teacher = New PictureBox
        teacher.Image = My.Resources.French_Fry
        teacher.AutoSize = False
        teacher.Text = "Greg Blickley"
        teacher.Font = New Font("MV Boli", 48, FontStyle.Bold)
        teacher.ForeColor = Color.Black
        teacher.Left = Me.Width / 2
        teacher.Top = Me.Height / 2
        teacher.Width = Me.Width / 4
        teacher.Height = Me.Width / 8
        teacher.Visible = False
        Controls.Add(teacher)

        'Publisher Code
        publisher = New PictureBox
        publisher.Image = My.Resources.French_Fry
        publisher.AutoSize = False
        publisher.Text = "Greg Blickley"
        publisher.Font = New Font("MV Boli", 48, FontStyle.Bold)
        publisher.ForeColor = Color.Black
        publisher.Left = Me.Width / 2
        publisher.Top = Me.Height / 2
        publisher.Width = Me.Width / 4
        publisher.Height = Me.Width / 8
        publisher.Visible = False
        Controls.Add(publisher)

        'Software brand credits 
        softwarebrand = New PictureBox
        softwarebrand.Image = My.Resources.French_Fry
        softwarebrand.AutoSize = False
        softwarebrand.Text = "Greg Blickley"
        softwarebrand.Font = New Font("MV Boli", 48, FontStyle.Bold)
        softwarebrand.ForeColor = Color.Black
        softwarebrand.Left = Me.Width / 2
        softwarebrand.Top = Me.Height / 2
        softwarebrand.Width = Me.Width / 4
        softwarebrand.Height = Me.Width / 8
        softwarebrand.Visible = False
        Controls.Add(softwarebrand)

        'Spinning Fry 
        For x = 0 To 5
            spinningFry(x) = New PictureBox
            spinningFry(x).Image = My.Resources.Fry_animation
            spinningFry(x).SizeMode = PictureBoxSizeMode.StretchImage
            spinningFry(x).Left = (Me.Width - spinningFry(x).Width) / 2
            spinningFry(x).Top = 0
            spinningFry(x).Width = Me.Width / 8
            spinningFry(x).Height = Me.Width / 8
            spinningFry(x).BackColor = Color.Transparent
            spinningFry(x).Visible = False
            Controls.Add(spinningFry(x))
        Next
        ShowCredits = False

    End Sub

    Private Sub lbgoback_MouseEnter(sender As Object, e As EventArgs) Handles lbgoback.MouseEnter
        lbgoback.Text = "< Go Back"
    End Sub

    Private Sub lbgoback_MouseLeave(sender As Object, e As EventArgs) Handles lbgoback.MouseLeave
        lbgoback.Text = "Go Back"
    End Sub

    Private Sub lbgoback_Click(sender As Object, e As EventArgs) Handles lbgoback.Click
        Me.Hide()
        Timer1.Enabled = False
        Form1.Show()
        Form1.Timer1.Enabled = True
        ShowCredits = True
        Controls.Remove(graphicmaker)
        Controls.Remove(codewritter)
        Controls.Remove(teacher)
        Controls.Remove(publisher)
        Controls.Remove(softwarebrand)
        For x = 0 To 5
            Controls.Remove(spinningFry(x))
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lbgoback.Text = credcounter
        'allows me to restart the credits each time they enter the form



        'having the spinning fries fall to center of screen
        credcounter += 1

        'turning certain fries visable at times to control what will be visable and when 
        'timer interval 100= 1 sec
        If credcounter = 50 Then
            spinningFry(0).Visible = True
        ElseIf credcounter = 150 Then
            spinningFry(1).Visible = True
        ElseIf credcounter = 250 Then
            spinningFry(2).Visible = True
        ElseIf credcounter = 350 Then
            spinningFry(3).Visible = True
        ElseIf credcounter = 450 Then
            spinningFry(4).Visible = True
        ElseIf credcounter = 550 Then
            spinningFry(5).Visible = True
        End If

        'graphic design graphics
        If spinningFry(0).Visible = True Then


            'fry falls to center screent then enlarges 
            If spinningFry(0).Top <> (Me.Height) / 2 Then
                spinningFry(0).Top += 3

            ElseIf spinningFry(0).Top = (Me.Height) / 2 Then
                spinningFry(0).Top = spinningFry(0).Top
                If spinningFry(0).Width <> graphicmaker.Width Then
                    spinningFry(0).Width += 1
                    spinningFry(0).Height += 1
                ElseIf spinningFry(0).Width = graphicmaker.Width Then
                    spinningFry(0).Width += 0
                    spinningFry(0).Height += 0

                    'remove animated fry replace with stationary
                    spinningFry(0).Visible = False
                    graphicmaker.Visible = True
                    graphicmaker.Left = spinningFry(0).Left
                    graphicmaker.Top = spinningFry(0).Top
                    graphicmaker.Width = spinningFry(0).Width

                End If

            End If

        End If
    End Sub
End Class