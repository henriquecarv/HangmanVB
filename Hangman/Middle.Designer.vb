<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Middle
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblDifficult = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cbDifficult = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(120, 260)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(87, 40)
        Me.btnPlay.TabIndex = 9
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblDifficult
        '
        Me.lblDifficult.AutoSize = True
        Me.lblDifficult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficult.Location = New System.Drawing.Point(133, 145)
        Me.lblDifficult.Name = "lblDifficult"
        Me.lblDifficult.Size = New System.Drawing.Size(74, 25)
        Me.lblDifficult.TabIndex = 8
        Me.lblDifficult.Text = "Difficult"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(124, 33)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(92, 25)
        Me.lblCategory.TabIndex = 7
        Me.lblCategory.Text = "Category"
        '
        'cbDifficult
        '
        Me.cbDifficult.FormattingEnabled = True
        Me.cbDifficult.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cbDifficult.Location = New System.Drawing.Point(109, 173)
        Me.cbDifficult.Name = "cbDifficult"
        Me.cbDifficult.Size = New System.Drawing.Size(121, 24)
        Me.cbDifficult.TabIndex = 6
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Technology", "Movie", "Food", "Beverage", "Entertainment", "Science"})
        Me.cbCategory.Location = New System.Drawing.Point(109, 61)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(121, 24)
        Me.cbCategory.TabIndex = 5
        '
        'Middle_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 335)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblDifficult)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cbDifficult)
        Me.Controls.Add(Me.cbCategory)
        Me.Name = "Middle_New"
        Me.Text = "Middle_New"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblDifficult As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cbDifficult As System.Windows.Forms.ComboBox
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
End Class
