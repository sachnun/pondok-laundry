Public Class SplashScreen
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.Snow
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Form2.Show()
        Me.Hide()

        Timer1.Stop()
    End Sub
End Class
