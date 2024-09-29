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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MyStatusLine = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnRandomWords = New System.Windows.Forms.Button()
        Me.BtnGames = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(775, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 36)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MyStatusLine
        '
        Me.MyStatusLine.AutoSize = True
        Me.MyStatusLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyStatusLine.Location = New System.Drawing.Point(12, 410)
        Me.MyStatusLine.Name = "MyStatusLine"
        Me.MyStatusLine.Size = New System.Drawing.Size(79, 25)
        Me.MyStatusLine.TabIndex = 1
        Me.MyStatusLine.Text = "Status"
        Me.MyStatusLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(911, 382)
        Me.ListBox1.TabIndex = 2
        '
        'BtnRandomWords
        '
        Me.BtnRandomWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRandomWords.Location = New System.Drawing.Point(621, 399)
        Me.BtnRandomWords.Name = "BtnRandomWords"
        Me.BtnRandomWords.Size = New System.Drawing.Size(148, 36)
        Me.BtnRandomWords.TabIndex = 3
        Me.BtnRandomWords.Text = "&Random Words"
        Me.BtnRandomWords.UseVisualStyleBackColor = True
        '
        'BtnGames
        '
        Me.BtnGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGames.Location = New System.Drawing.Point(467, 399)
        Me.BtnGames.Name = "BtnGames"
        Me.BtnGames.Size = New System.Drawing.Size(148, 36)
        Me.BtnGames.TabIndex = 4
        Me.BtnGames.Text = "&Games"
        Me.BtnGames.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 450)
        Me.Controls.Add(Me.BtnGames)
        Me.Controls.Add(Me.BtnRandomWords)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MyStatusLine)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "WordyPuzzles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents MyStatusLine As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnRandomWords As Button
    Friend WithEvents BtnGames As Button
End Class
