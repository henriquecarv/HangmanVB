<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryandDifficult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryandDifficult))
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbDifficult = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblDifficult = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(182, 88)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(137, 24)
        Me.cmbCategory.TabIndex = 0
        '
        'cmbDifficult
        '
        Me.cmbDifficult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDifficult.FormattingEnabled = True
        Me.cmbDifficult.Location = New System.Drawing.Point(182, 201)
        Me.cmbDifficult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDifficult.Name = "cmbDifficult"
        Me.cmbDifficult.Size = New System.Drawing.Size(137, 24)
        Me.cmbDifficult.TabIndex = 1
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(207, 61)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(92, 25)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "Category"
        '
        'lblDifficult
        '
        Me.lblDifficult.AutoSize = True
        Me.lblDifficult.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficult.Location = New System.Drawing.Point(207, 174)
        Me.lblDifficult.Name = "lblDifficult"
        Me.lblDifficult.Size = New System.Drawing.Size(84, 25)
        Me.lblDifficult.TabIndex = 3
        Me.lblDifficult.Text = "Difficulty"
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(204, 284)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(87, 39)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'CategoryandDifficult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 380)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblDifficult)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbDifficult)
        Me.Controls.Add(Me.cmbCategory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CategoryandDifficult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category & Difficult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDifficult As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblDifficult As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
End Class
