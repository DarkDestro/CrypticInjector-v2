Public Class About
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://github.com/Philip-j-fry/CrypticInjector-v2/issues"
        Process.Start(webAddress)
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class