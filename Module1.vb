Module Module1
    Public score As Integer
    Public h As String
    Public m As String
    Public s As String
    Public timemem As Integer
    Public timesec As Integer
    Public highscoremem As Integer
    Public hour As Integer
    Public second As Integer
    Public min As Integer
    Public yes As Boolean
    Public newhighscore As Boolean
    Public ShowCredits As Boolean
    Public FILEscore As New IO.FileStream("highscores.txt", IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)
    Public FILEplayers As New IO.FileStream("playernames.txt", IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.None)
    Public WRITEscore As New IO.StreamWriter(FILEscore)
    Public WRITEplayers As New IO.StreamWriter(FILEplayers)
    Public READscore As New IO.StreamReader(FILEscore)
    Public READplayers As New IO.StreamReader(FILEplayers)
End Module
