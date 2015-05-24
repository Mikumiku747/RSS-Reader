Public Class FeedManager
    Private Sub FeedManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each feed In My.Settings.Feeds
            FeedsTextBox.Text &= feed & vbNewLine
        Next
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim feeds As String() = FeedsTextBox.Text.Split(vbNewLine)
        My.Settings.Feeds = New System.Collections.Specialized.StringCollection
        For Each feed In feeds
            My.Settings.Feeds.Add(feed)
        Next
        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub
End Class