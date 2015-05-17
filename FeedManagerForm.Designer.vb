<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedManagerForm
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
        Me.FeedListListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'FeedListListBox
        '
        Me.FeedListListBox.FormattingEnabled = True
        Me.FeedListListBox.Items.AddRange(New Object() {"http://xkcd.com/rss.xml"})
        Me.FeedListListBox.Location = New System.Drawing.Point(12, 12)
        Me.FeedListListBox.Name = "FeedListListBox"
        Me.FeedListListBox.Size = New System.Drawing.Size(212, 238)
        Me.FeedListListBox.TabIndex = 0
        '
        'FeedManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 276)
        Me.Controls.Add(Me.FeedListListBox)
        Me.Name = "FeedManagerForm"
        Me.Text = "FeedManagerForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FeedListListBox As ListBox
End Class
