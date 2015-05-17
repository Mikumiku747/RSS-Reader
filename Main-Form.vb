Imports System.Xml

Public Class Main_Form

    Public feedurl As String = "http://xkcd.com/rss.xml"
    Public articleno As Integer = 0

    Dim noOfArticles As Integer = 1
    Dim feedlink As String = ""
    Dim articlelink As String = ""

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadarticle(feedurl, articleno)
    End Sub

    Private Sub FeedSelectorBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FeedSelectorBox.SelectedIndexChanged

    End Sub

    Private Sub loadarticle(feedurl, articleno)
        Dim feed As New XmlDocument
        Try
            feed.Load(feedurl)
        Catch ex As System.Net.WebException
            MsgBox("Could not connect to feed.")
            Return
        End Try
        Dim title As String = "Failed to load feed title"
        Dim link As String = ""
        Dim desc As String = "Failed to load feed description"
        Try
            title = feed.SelectSingleNode("rss/channel/title").InnerText
        Catch ex As NullReferenceException
            MsgBox("Could not load feed title.", MsgBoxStyle.Critical)
        End Try
        Try
            link = feed.SelectSingleNode("rss/channel/link").InnerText
        Catch ex As NullReferenceException
            MsgBox("Could not load feed link.", MsgBoxStyle.Critical)
        End Try
        Try
            desc = feed.SelectSingleNode("rss/channel/description").InnerText
        Catch ex As NullReferenceException
            MsgBox("Could not load feed description.", MsgBoxStyle.Critical)
        End Try

        Dim articles As XmlNodeList = feed.SelectNodes("/rss/channel/item")
        noOfArticles = articles.Count
        Dim article As XmlNode = articles.ItemOf(articleno)
        Dim a_title As String = article.SelectSingleNode("title").InnerText
        Dim a_link As String = article.SelectSingleNode("link").InnerText
        Dim a_desc As String = article.SelectSingleNode("description").InnerText
        Dim a_pubdate As String = article.SelectSingleNode("pubDate").InnerText

        FeedTitleLabel.Text = title
        feedlink = link
        FeedDescriptionLabel.Text = desc
        ArticleTitleLabel.Text = a_title
        articlelink = a_link
        ArticleViewerWebBrowser.DocumentText = a_desc
        PublishDateLabel.Text = a_pubdate
        Debug.Print(ArticleViewerWebBrowser.DocumentText)
    End Sub

    Private Sub OlderArticleButton_Click(sender As Object, e As EventArgs) Handles OlderArticleButton.Click
        If articleno < noOfArticles - 1 Then
            articleno = articleno + 1
            loadarticle(feedurl, articleno)
        Else
            MsgBox("No older articles to view.")
        End If
    End Sub

    Private Sub NewerArticleButton_Click(sender As Object, e As EventArgs) Handles NewerArticleButton.Click
        If articleno > 0 Then
            articleno = articleno - 1
            loadarticle(feedurl, articleno)
        Else
            MsgBox("No newer articles To view.")
        End If
    End Sub

    Private Sub FeedTitleLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles FeedTitleLabel.LinkClicked
        If feedlink <> "" Then
            Process.Start(feedlink)
        End If
    End Sub

    Private Sub ArticleTitleLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ArticleTitleLabel.LinkClicked
        If articlelink <> "" Then
            Process.Start(articlelink)
        End If
    End Sub
End Class