<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FeedsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageFeedsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewestArticleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OldestArticleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlderArticleButton = New System.Windows.Forms.Button()
        Me.NewerArticleButton = New System.Windows.Forms.Button()
        Me.PublishDateLabel = New System.Windows.Forms.Label()
        Me.FeedSelectorBox = New System.Windows.Forms.ComboBox()
        Me.ArticleViewerWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FeedTitleLabel = New System.Windows.Forms.LinkLabel()
        Me.FeedDescriptionLabel = New System.Windows.Forms.Label()
        Me.ArticleTitleLabel = New System.Windows.Forms.LinkLabel()
        Me.ManageFeedsButton = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeedsToolStripMenuItem, Me.ArticlesToolStripMenuItem, Me.ReaderToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FeedsToolStripMenuItem
        '
        Me.FeedsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ManageFeedsToolStripMenuItem})
        Me.FeedsToolStripMenuItem.Name = "FeedsToolStripMenuItem"
        Me.FeedsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.FeedsToolStripMenuItem.Text = "Feeds"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ManageFeedsToolStripMenuItem
        '
        Me.ManageFeedsToolStripMenuItem.Name = "ManageFeedsToolStripMenuItem"
        Me.ManageFeedsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ManageFeedsToolStripMenuItem.Text = "Manage Feeds..."
        '
        'ArticlesToolStripMenuItem
        '
        Me.ArticlesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewestArticleToolStripMenuItem, Me.OldestArticleToolStripMenuItem})
        Me.ArticlesToolStripMenuItem.Name = "ArticlesToolStripMenuItem"
        Me.ArticlesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ArticlesToolStripMenuItem.Text = "Articles"
        '
        'NewestArticleToolStripMenuItem
        '
        Me.NewestArticleToolStripMenuItem.Name = "NewestArticleToolStripMenuItem"
        Me.NewestArticleToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NewestArticleToolStripMenuItem.Text = "Newest Article"
        '
        'OldestArticleToolStripMenuItem
        '
        Me.OldestArticleToolStripMenuItem.Name = "OldestArticleToolStripMenuItem"
        Me.OldestArticleToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OldestArticleToolStripMenuItem.Text = "Oldest Article"
        '
        'ReaderToolStripMenuItem
        '
        Me.ReaderToolStripMenuItem.Name = "ReaderToolStripMenuItem"
        Me.ReaderToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ReaderToolStripMenuItem.Text = "Reader"
        '
        'OlderArticleButton
        '
        Me.OlderArticleButton.Location = New System.Drawing.Point(297, 497)
        Me.OlderArticleButton.Name = "OlderArticleButton"
        Me.OlderArticleButton.Size = New System.Drawing.Size(69, 22)
        Me.OlderArticleButton.TabIndex = 1
        Me.OlderArticleButton.Text = "Older"
        Me.OlderArticleButton.UseVisualStyleBackColor = True
        '
        'NewerArticleButton
        '
        Me.NewerArticleButton.Location = New System.Drawing.Point(18, 497)
        Me.NewerArticleButton.Name = "NewerArticleButton"
        Me.NewerArticleButton.Size = New System.Drawing.Size(69, 22)
        Me.NewerArticleButton.TabIndex = 2
        Me.NewerArticleButton.Text = "Newer"
        Me.NewerArticleButton.UseVisualStyleBackColor = True
        '
        'PublishDateLabel
        '
        Me.PublishDateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublishDateLabel.Location = New System.Drawing.Point(93, 494)
        Me.PublishDateLabel.Name = "PublishDateLabel"
        Me.PublishDateLabel.Size = New System.Drawing.Size(198, 28)
        Me.PublishDateLabel.TabIndex = 3
        Me.PublishDateLabel.Text = "Published DD/MM/YY HH:MM"
        Me.PublishDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FeedSelectorBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FeedSelectorBox, 2)
        Me.FeedSelectorBox.FormattingEnabled = True
        Me.FeedSelectorBox.Location = New System.Drawing.Point(18, 18)
        Me.FeedSelectorBox.Name = "FeedSelectorBox"
        Me.FeedSelectorBox.Size = New System.Drawing.Size(273, 21)
        Me.FeedSelectorBox.TabIndex = 4
        Me.FeedSelectorBox.Text = "Select an RSS feed..."
        '
        'ArticleViewerWebBrowser
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ArticleViewerWebBrowser, 3)
        Me.ArticleViewerWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArticleViewerWebBrowser.Location = New System.Drawing.Point(18, 140)
        Me.ArticleViewerWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ArticleViewerWebBrowser.Name = "ArticleViewerWebBrowser"
        Me.ArticleViewerWebBrowser.ScriptErrorsSuppressed = True
        Me.ArticleViewerWebBrowser.Size = New System.Drawing.Size(348, 336)
        Me.ArticleViewerWebBrowser.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FeedSelectorBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NewerArticleButton, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.OlderArticleButton, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.ArticleViewerWebBrowser, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.PublishDateLabel, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.FeedTitleLabel, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FeedDescriptionLabel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ArticleTitleLabel, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ManageFeedsButton, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 537)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'FeedTitleLabel
        '
        Me.FeedTitleLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.FeedTitleLabel, 3)
        Me.FeedTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeedTitleLabel.Location = New System.Drawing.Point(18, 58)
        Me.FeedTitleLabel.Name = "FeedTitleLabel"
        Me.FeedTitleLabel.Size = New System.Drawing.Size(79, 20)
        Me.FeedTitleLabel.TabIndex = 6
        Me.FeedTitleLabel.TabStop = True
        Me.FeedTitleLabel.Tag = ""
        Me.FeedTitleLabel.Text = "Feed Title"
        '
        'FeedDescriptionLabel
        '
        Me.FeedDescriptionLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.FeedDescriptionLabel, 3)
        Me.FeedDescriptionLabel.Location = New System.Drawing.Point(18, 78)
        Me.FeedDescriptionLabel.Name = "FeedDescriptionLabel"
        Me.FeedDescriptionLabel.Size = New System.Drawing.Size(87, 13)
        Me.FeedDescriptionLabel.TabIndex = 7
        Me.FeedDescriptionLabel.Text = "Feed Description"
        '
        'ArticleTitleLabel
        '
        Me.ArticleTitleLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.ArticleTitleLabel, 3)
        Me.ArticleTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticleTitleLabel.Location = New System.Drawing.Point(18, 106)
        Me.ArticleTitleLabel.Name = "ArticleTitleLabel"
        Me.ArticleTitleLabel.Size = New System.Drawing.Size(74, 16)
        Me.ArticleTitleLabel.TabIndex = 8
        Me.ArticleTitleLabel.TabStop = True
        Me.ArticleTitleLabel.Text = "Article Title"
        '
        'ManageFeedsButton
        '
        Me.ManageFeedsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManageFeedsButton.Location = New System.Drawing.Point(297, 18)
        Me.ManageFeedsButton.Name = "ManageFeedsButton"
        Me.ManageFeedsButton.Size = New System.Drawing.Size(69, 22)
        Me.ManageFeedsButton.TabIndex = 9
        Me.ManageFeedsButton.Text = "Feeds"
        Me.ManageFeedsButton.UseVisualStyleBackColor = True
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(400, 600)
        Me.Name = "Main_Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "RSS Reader"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OlderArticleButton As Button
    Friend WithEvents NewerArticleButton As Button
    Friend WithEvents PublishDateLabel As Label
    Friend WithEvents FeedSelectorBox As ComboBox
    Friend WithEvents ArticleViewerWebBrowser As WebBrowser
    Friend WithEvents FeedsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ArticleTitleLabel As LinkLabel
    Friend WithEvents FeedTitleLabel As LinkLabel
    Friend WithEvents FeedDescriptionLabel As Label
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageFeedsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewestArticleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OldestArticleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageFeedsButton As Button
End Class
