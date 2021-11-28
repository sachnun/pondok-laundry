Public Class Splash
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Login.Show()
        Me.Hide()

        Timer1.Stop()
    End Sub

    Private Sub Splash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Color.Snow
    End Sub
End Class
