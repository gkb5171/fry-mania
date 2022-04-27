<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.htp = New System.Windows.Forms.Label()
        Me.lbexit = New System.Windows.Forms.Label()
        Me.lbcredits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(929, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(467, 171)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Play!"
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(581, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(991, 171)
        Me.title.TabIndex = 1
        Me.title.Text = "FRY MANIA!!!"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'htp
        '
        Me.htp.BackColor = System.Drawing.Color.Transparent
        Me.htp.Font = New System.Drawing.Font("MV Boli", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htp.Location = New System.Drawing.Point(848, 336)
        Me.htp.Name = "htp"
        Me.htp.Size = New System.Drawing.Size(794, 171)
        Me.htp.TabIndex = 2
        Me.htp.Text = "How to Play"
        '
        'lbexit
        '
        Me.lbexit.BackColor = System.Drawing.Color.Transparent
        Me.lbexit.Font = New System.Drawing.Font("MV Boli", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbexit.Location = New System.Drawing.Point(730, 559)
        Me.lbexit.Name = "lbexit"
        Me.lbexit.Size = New System.Drawing.Size(378, 106)
        Me.lbexit.TabIndex = 3
        Me.lbexit.Text = "EXIT!"
        '
        'lbcredits
        '
        Me.lbcredits.BackColor = System.Drawing.Color.Transparent
        Me.lbcredits.Font = New System.Drawing.Font("MV Boli", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcredits.Location = New System.Drawing.Point(523, 665)
        Me.lbcredits.Name = "lbcredits"
        Me.lbcredits.Size = New System.Drawing.Size(436, 103)
        Me.lbcredits.TabIndex = 4
        Me.lbcredits.Text = "Credits"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.lbcredits)
        Me.Controls.Add(Me.lbexit)
        Me.Controls.Add(Me.htp)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Label
    Friend WithEvents title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents htp As Label
    Friend WithEvents lbexit As Label
    Friend WithEvents lbcredits As Label
End Class
