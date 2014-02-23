<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.txtboxInstrutions = New System.Windows.Forms.TextBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblHangman = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtboxInstrutions
        '
        Me.txtboxInstrutions.AccessibleName = "txtboxInstructions"
        Me.txtboxInstrutions.Location = New System.Drawing.Point(45, 237)
        Me.txtboxInstrutions.Multiline = True
        Me.txtboxInstrutions.Name = "txtboxInstrutions"
        Me.txtboxInstrutions.Size = New System.Drawing.Size(373, 124)
        Me.txtboxInstrutions.TabIndex = 11
        Me.txtboxInstrutions.Text = resources.GetString("txtboxInstrutions.Text")
        '
        'lblWelcome
        '
        Me.lblWelcome.AccessibleName = "lblWelcome"
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(170, 188)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(126, 31)
        Me.lblWelcome.TabIndex = 10
        Me.lblWelcome.Text = "Welcome"
        '
        'btnStart
        '
        Me.btnStart.AccessibleName = ""
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(491, 318)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 43)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblHangman
        '
        Me.lblHangman.AccessibleName = "lblTitle"
        Me.lblHangman.AutoSize = True
        Me.lblHangman.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHangman.Location = New System.Drawing.Point(238, 48)
        Me.lblHangman.Name = "lblHangman"
        Me.lblHangman.Size = New System.Drawing.Size(180, 42)
        Me.lblHangman.TabIndex = 8
        Me.lblHangman.Text = "Hangman"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 414)
        Me.Controls.Add(Me.txtboxInstrutions)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblHangman)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxInstrutions As System.Windows.Forms.TextBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblHangman As System.Windows.Forms.Label

End Class
