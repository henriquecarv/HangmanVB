<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.btnA = New System.Windows.Forms.Button()
        Me.txtWrongGuesses = New System.Windows.Forms.TextBox()
        Me.lblWrongGuesses = New System.Windows.Forms.Label()
        Me.lblLetters = New System.Windows.Forms.Label()
        Me.lblDifficult = New System.Windows.Forms.Label()
        Me.cmbDifficult = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLetter1 = New System.Windows.Forms.Label()
        Me.lblLetter3 = New System.Windows.Forms.Label()
        Me.lblLetter2 = New System.Windows.Forms.Label()
        Me.lblLetter4 = New System.Windows.Forms.Label()
        Me.lblLetter5 = New System.Windows.Forms.Label()
        Me.lblLetter6 = New System.Windows.Forms.Label()
        Me.btnPosition1 = New System.Windows.Forms.Button()
        Me.btnPosition2 = New System.Windows.Forms.Button()
        Me.btnPosition3 = New System.Windows.Forms.Button()
        Me.btnPosition4 = New System.Windows.Forms.Button()
        Me.btnPosition5 = New System.Windows.Forms.Button()
        Me.btnPosition6 = New System.Windows.Forms.Button()
        Me.picHangman = New System.Windows.Forms.PictureBox()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblCountRem = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnPosition12 = New System.Windows.Forms.Button()
        Me.btnPosition11 = New System.Windows.Forms.Button()
        Me.btnPosition10 = New System.Windows.Forms.Button()
        Me.btnPosition9 = New System.Windows.Forms.Button()
        Me.btnPosition8 = New System.Windows.Forms.Button()
        Me.btnPosition7 = New System.Windows.Forms.Button()
        Me.lblLetter12 = New System.Windows.Forms.Label()
        Me.lblLetter11 = New System.Windows.Forms.Label()
        Me.lblLetter10 = New System.Windows.Forms.Label()
        Me.lblLetter8 = New System.Windows.Forms.Label()
        Me.lblLetter9 = New System.Windows.Forms.Label()
        Me.lblLetter7 = New System.Windows.Forms.Label()
        Me.btnPosition20 = New System.Windows.Forms.Button()
        Me.btnPosition19 = New System.Windows.Forms.Button()
        Me.btnPosition18 = New System.Windows.Forms.Button()
        Me.btnPosition17 = New System.Windows.Forms.Button()
        Me.btnPosition16 = New System.Windows.Forms.Button()
        Me.btnPosition15 = New System.Windows.Forms.Button()
        Me.lblLetter20 = New System.Windows.Forms.Label()
        Me.lblLetter19 = New System.Windows.Forms.Label()
        Me.lblLetter18 = New System.Windows.Forms.Label()
        Me.lblLetter16 = New System.Windows.Forms.Label()
        Me.lblLetter17 = New System.Windows.Forms.Label()
        Me.lblLetter15 = New System.Windows.Forms.Label()
        Me.btnPosition14 = New System.Windows.Forms.Button()
        Me.btnPosition13 = New System.Windows.Forms.Button()
        Me.lblLetter14 = New System.Windows.Forms.Label()
        Me.lblLetter13 = New System.Windows.Forms.Label()
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnA
        '
        Me.btnA.AccessibleName = ""
        Me.btnA.Location = New System.Drawing.Point(233, 403)
        Me.btnA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(51, 42)
        Me.btnA.TabIndex = 0
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'txtWrongGuesses
        '
        Me.txtWrongGuesses.AccessibleName = "txtBoxWrong"
        Me.txtWrongGuesses.Location = New System.Drawing.Point(1123, 285)
        Me.txtWrongGuesses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWrongGuesses.Multiline = True
        Me.txtWrongGuesses.Name = "txtWrongGuesses"
        Me.txtWrongGuesses.Size = New System.Drawing.Size(199, 203)
        Me.txtWrongGuesses.TabIndex = 34
        '
        'lblWrongGuesses
        '
        Me.lblWrongGuesses.AccessibleName = "lblWordsGuessed"
        Me.lblWrongGuesses.AutoSize = True
        Me.lblWrongGuesses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrongGuesses.Location = New System.Drawing.Point(1118, 238)
        Me.lblWrongGuesses.Name = "lblWrongGuesses"
        Me.lblWrongGuesses.Size = New System.Drawing.Size(154, 25)
        Me.lblWrongGuesses.TabIndex = 35
        Me.lblWrongGuesses.Text = "Wrong Guesses"
        '
        'lblLetters
        '
        Me.lblLetters.AccessibleName = "lblLetters"
        Me.lblLetters.AutoSize = True
        Me.lblLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetters.Location = New System.Drawing.Point(32, 391)
        Me.lblLetters.Name = "lblLetters"
        Me.lblLetters.Size = New System.Drawing.Size(65, 24)
        Me.lblLetters.TabIndex = 36
        Me.lblLetters.Text = "Letters"
        '
        'lblDifficult
        '
        Me.lblDifficult.AccessibleName = "lblDifficult"
        Me.lblDifficult.AutoSize = True
        Me.lblDifficult.Location = New System.Drawing.Point(1120, 34)
        Me.lblDifficult.Name = "lblDifficult"
        Me.lblDifficult.Size = New System.Drawing.Size(69, 17)
        Me.lblDifficult.TabIndex = 37
        Me.lblDifficult.Text = "Difficulty: "
        '
        'cmbDifficult
        '
        Me.cmbDifficult.AccessibleName = "comboBoxDifficult"
        Me.cmbDifficult.FormattingEnabled = True
        Me.cmbDifficult.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cmbDifficult.Location = New System.Drawing.Point(1189, 34)
        Me.cmbDifficult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDifficult.Name = "cmbDifficult"
        Me.cmbDifficult.Size = New System.Drawing.Size(121, 24)
        Me.cmbDifficult.TabIndex = 38
        '
        'cmbCategory
        '
        Me.cmbCategory.AccessibleName = "comboBoxCategory"
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(1189, 91)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmbCategory.TabIndex = 39
        '
        'lblCategory
        '
        Me.lblCategory.AccessibleName = "lblCategory"
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(1120, 94)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(69, 17)
        Me.lblCategory.TabIndex = 40
        Me.lblCategory.Text = "Category:"
        '
        'btnRestart
        '
        Me.btnRestart.AccessibleName = "btnRestart"
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(1227, 548)
        Me.btnRestart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(95, 36)
        Me.btnRestart.TabIndex = 41
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1123, 548)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 34)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLetter1
        '
        Me.lblLetter1.AccessibleName = ""
        Me.lblLetter1.AutoSize = True
        Me.lblLetter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter1.Location = New System.Drawing.Point(51, 300)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter1.TabIndex = 43
        '
        'lblLetter3
        '
        Me.lblLetter3.AccessibleName = ""
        Me.lblLetter3.AutoSize = True
        Me.lblLetter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter3.Location = New System.Drawing.Point(155, 300)
        Me.lblLetter3.Name = "lblLetter3"
        Me.lblLetter3.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter3.TabIndex = 44
        '
        'lblLetter2
        '
        Me.lblLetter2.AccessibleName = ""
        Me.lblLetter2.AutoSize = True
        Me.lblLetter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter2.Location = New System.Drawing.Point(104, 300)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter2.TabIndex = 45
        '
        'lblLetter4
        '
        Me.lblLetter4.AccessibleName = ""
        Me.lblLetter4.AutoSize = True
        Me.lblLetter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter4.Location = New System.Drawing.Point(208, 300)
        Me.lblLetter4.Name = "lblLetter4"
        Me.lblLetter4.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter4.TabIndex = 46
        Me.lblLetter4.Visible = False
        '
        'lblLetter5
        '
        Me.lblLetter5.AccessibleName = ""
        Me.lblLetter5.AutoSize = True
        Me.lblLetter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter5.Location = New System.Drawing.Point(259, 300)
        Me.lblLetter5.Name = "lblLetter5"
        Me.lblLetter5.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter5.TabIndex = 47
        Me.lblLetter5.Visible = False
        '
        'lblLetter6
        '
        Me.lblLetter6.AccessibleName = ""
        Me.lblLetter6.AutoSize = True
        Me.lblLetter6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter6.Location = New System.Drawing.Point(312, 300)
        Me.lblLetter6.Name = "lblLetter6"
        Me.lblLetter6.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter6.TabIndex = 48
        Me.lblLetter6.Visible = False
        '
        'btnPosition1
        '
        Me.btnPosition1.AccessibleName = ""
        Me.btnPosition1.Enabled = False
        Me.btnPosition1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition1.Location = New System.Drawing.Point(40, 338)
        Me.btnPosition1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition1.Name = "btnPosition1"
        Me.btnPosition1.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition1.TabIndex = 49
        Me.btnPosition1.Text = "Button29"
        Me.btnPosition1.UseVisualStyleBackColor = True
        '
        'btnPosition2
        '
        Me.btnPosition2.AccessibleName = ""
        Me.btnPosition2.Enabled = False
        Me.btnPosition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition2.Location = New System.Drawing.Point(91, 338)
        Me.btnPosition2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition2.Name = "btnPosition2"
        Me.btnPosition2.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition2.TabIndex = 50
        Me.btnPosition2.Text = "Button30"
        Me.btnPosition2.UseVisualStyleBackColor = True
        '
        'btnPosition3
        '
        Me.btnPosition3.AccessibleName = ""
        Me.btnPosition3.Enabled = False
        Me.btnPosition3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition3.Location = New System.Drawing.Point(144, 338)
        Me.btnPosition3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition3.Name = "btnPosition3"
        Me.btnPosition3.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition3.TabIndex = 51
        Me.btnPosition3.Text = "Button31"
        Me.btnPosition3.UseVisualStyleBackColor = True
        '
        'btnPosition4
        '
        Me.btnPosition4.AccessibleName = ""
        Me.btnPosition4.Enabled = False
        Me.btnPosition4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition4.Location = New System.Drawing.Point(195, 338)
        Me.btnPosition4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition4.Name = "btnPosition4"
        Me.btnPosition4.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition4.TabIndex = 52
        Me.btnPosition4.Text = "Button32"
        Me.btnPosition4.UseVisualStyleBackColor = True
        Me.btnPosition4.Visible = False
        '
        'btnPosition5
        '
        Me.btnPosition5.AccessibleName = ""
        Me.btnPosition5.Enabled = False
        Me.btnPosition5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition5.Location = New System.Drawing.Point(248, 338)
        Me.btnPosition5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition5.Name = "btnPosition5"
        Me.btnPosition5.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition5.TabIndex = 53
        Me.btnPosition5.Text = "Button33"
        Me.btnPosition5.UseVisualStyleBackColor = True
        Me.btnPosition5.Visible = False
        '
        'btnPosition6
        '
        Me.btnPosition6.AccessibleName = ""
        Me.btnPosition6.Enabled = False
        Me.btnPosition6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition6.Location = New System.Drawing.Point(301, 338)
        Me.btnPosition6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition6.Name = "btnPosition6"
        Me.btnPosition6.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition6.TabIndex = 54
        Me.btnPosition6.Text = "Button34"
        Me.btnPosition6.UseVisualStyleBackColor = True
        Me.btnPosition6.Visible = False
        '
        'picHangman
        '
        Me.picHangman.AccessibleName = ""
        Me.picHangman.Image = Global.WindowsApplication1.My.Resources.Resources.hangman0
        Me.picHangman.Location = New System.Drawing.Point(36, 25)
        Me.picHangman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picHangman.Name = "picHangman"
        Me.picHangman.Size = New System.Drawing.Size(964, 238)
        Me.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHangman.TabIndex = 55
        Me.picHangman.TabStop = False
        '
        'btnM
        '
        Me.btnM.AccessibleName = ""
        Me.btnM.Location = New System.Drawing.Point(905, 403)
        Me.btnM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(51, 42)
        Me.btnM.TabIndex = 56
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.AccessibleName = ""
        Me.btnL.Location = New System.Drawing.Point(849, 403)
        Me.btnL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(51, 42)
        Me.btnL.TabIndex = 57
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.AccessibleName = ""
        Me.btnK.Location = New System.Drawing.Point(793, 403)
        Me.btnK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(51, 42)
        Me.btnK.TabIndex = 58
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.AccessibleName = ""
        Me.btnJ.Location = New System.Drawing.Point(737, 403)
        Me.btnJ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(51, 42)
        Me.btnJ.TabIndex = 59
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.AccessibleName = ""
        Me.btnI.Location = New System.Drawing.Point(681, 403)
        Me.btnI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(51, 42)
        Me.btnI.TabIndex = 60
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.AccessibleName = ""
        Me.btnH.Location = New System.Drawing.Point(625, 403)
        Me.btnH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(51, 42)
        Me.btnH.TabIndex = 61
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.AccessibleName = ""
        Me.btnG.Location = New System.Drawing.Point(569, 403)
        Me.btnG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(51, 42)
        Me.btnG.TabIndex = 62
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.AccessibleName = ""
        Me.btnF.Location = New System.Drawing.Point(513, 403)
        Me.btnF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(51, 42)
        Me.btnF.TabIndex = 63
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.AccessibleName = ""
        Me.btnE.Location = New System.Drawing.Point(457, 403)
        Me.btnE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(51, 42)
        Me.btnE.TabIndex = 64
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.AccessibleName = ""
        Me.btnD.Location = New System.Drawing.Point(401, 403)
        Me.btnD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(51, 42)
        Me.btnD.TabIndex = 65
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.AccessibleName = ""
        Me.btnC.Location = New System.Drawing.Point(345, 403)
        Me.btnC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(51, 42)
        Me.btnC.TabIndex = 66
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.AccessibleName = "btnB"
        Me.btnB.Location = New System.Drawing.Point(289, 403)
        Me.btnB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(51, 42)
        Me.btnB.TabIndex = 67
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.AccessibleName = ""
        Me.btnO.Location = New System.Drawing.Point(289, 497)
        Me.btnO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(51, 42)
        Me.btnO.TabIndex = 80
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.AccessibleName = ""
        Me.btnP.Location = New System.Drawing.Point(345, 497)
        Me.btnP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(51, 42)
        Me.btnP.TabIndex = 79
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.AccessibleName = ""
        Me.btnQ.Location = New System.Drawing.Point(401, 497)
        Me.btnQ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(51, 42)
        Me.btnQ.TabIndex = 78
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.AccessibleName = ""
        Me.btnR.Location = New System.Drawing.Point(457, 497)
        Me.btnR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(51, 42)
        Me.btnR.TabIndex = 77
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.AccessibleName = ""
        Me.btnS.Location = New System.Drawing.Point(513, 497)
        Me.btnS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(51, 42)
        Me.btnS.TabIndex = 76
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.AccessibleName = ""
        Me.btnT.Location = New System.Drawing.Point(569, 497)
        Me.btnT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(51, 42)
        Me.btnT.TabIndex = 75
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.AccessibleName = ""
        Me.btnU.Location = New System.Drawing.Point(625, 497)
        Me.btnU.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(51, 42)
        Me.btnU.TabIndex = 74
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.AccessibleName = ""
        Me.btnV.Location = New System.Drawing.Point(681, 497)
        Me.btnV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(51, 42)
        Me.btnV.TabIndex = 73
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.AccessibleName = ""
        Me.btnW.Location = New System.Drawing.Point(737, 497)
        Me.btnW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(51, 42)
        Me.btnW.TabIndex = 72
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.AccessibleName = ""
        Me.btnX.Location = New System.Drawing.Point(793, 497)
        Me.btnX.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(51, 42)
        Me.btnX.TabIndex = 71
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.AccessibleName = ""
        Me.btnY.Location = New System.Drawing.Point(849, 497)
        Me.btnY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(51, 42)
        Me.btnY.TabIndex = 70
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.AccessibleName = ""
        Me.btnZ.Location = New System.Drawing.Point(905, 497)
        Me.btnZ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(51, 42)
        Me.btnZ.TabIndex = 69
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.AccessibleName = ""
        Me.btnN.Location = New System.Drawing.Point(233, 496)
        Me.btnN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(51, 42)
        Me.btnN.TabIndex = 68
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(1119, 172)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(165, 20)
        Me.lblRemaining.TabIndex = 81
        Me.lblRemaining.Text = "Remaining Guesses:"
        '
        'lblCountRem
        '
        Me.lblCountRem.AutoSize = True
        Me.lblCountRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountRem.ForeColor = System.Drawing.Color.Red
        Me.lblCountRem.Location = New System.Drawing.Point(1301, 168)
        Me.lblCountRem.Name = "lblCountRem"
        Me.lblCountRem.Size = New System.Drawing.Size(23, 25)
        Me.lblCountRem.TabIndex = 82
        Me.lblCountRem.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1018, 132)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 83
        '
        'btnPosition12
        '
        Me.btnPosition12.AccessibleName = ""
        Me.btnPosition12.Enabled = False
        Me.btnPosition12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition12.Location = New System.Drawing.Point(617, 338)
        Me.btnPosition12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition12.Name = "btnPosition12"
        Me.btnPosition12.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition12.TabIndex = 95
        Me.btnPosition12.Text = "Button34"
        Me.btnPosition12.UseVisualStyleBackColor = True
        Me.btnPosition12.Visible = False
        '
        'btnPosition11
        '
        Me.btnPosition11.AccessibleName = ""
        Me.btnPosition11.Enabled = False
        Me.btnPosition11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition11.Location = New System.Drawing.Point(564, 338)
        Me.btnPosition11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition11.Name = "btnPosition11"
        Me.btnPosition11.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition11.TabIndex = 94
        Me.btnPosition11.Text = "Button33"
        Me.btnPosition11.UseVisualStyleBackColor = True
        Me.btnPosition11.Visible = False
        '
        'btnPosition10
        '
        Me.btnPosition10.AccessibleName = ""
        Me.btnPosition10.Enabled = False
        Me.btnPosition10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition10.Location = New System.Drawing.Point(511, 338)
        Me.btnPosition10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition10.Name = "btnPosition10"
        Me.btnPosition10.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition10.TabIndex = 93
        Me.btnPosition10.Text = "Button32"
        Me.btnPosition10.UseVisualStyleBackColor = True
        Me.btnPosition10.Visible = False
        '
        'btnPosition9
        '
        Me.btnPosition9.AccessibleName = ""
        Me.btnPosition9.Enabled = False
        Me.btnPosition9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition9.Location = New System.Drawing.Point(460, 338)
        Me.btnPosition9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition9.Name = "btnPosition9"
        Me.btnPosition9.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition9.TabIndex = 92
        Me.btnPosition9.Text = "Button31"
        Me.btnPosition9.UseVisualStyleBackColor = True
        Me.btnPosition9.Visible = False
        '
        'btnPosition8
        '
        Me.btnPosition8.AccessibleName = ""
        Me.btnPosition8.Enabled = False
        Me.btnPosition8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition8.Location = New System.Drawing.Point(407, 338)
        Me.btnPosition8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition8.Name = "btnPosition8"
        Me.btnPosition8.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition8.TabIndex = 91
        Me.btnPosition8.Text = "Button30"
        Me.btnPosition8.UseVisualStyleBackColor = True
        Me.btnPosition8.Visible = False
        '
        'btnPosition7
        '
        Me.btnPosition7.AccessibleName = ""
        Me.btnPosition7.Enabled = False
        Me.btnPosition7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition7.Location = New System.Drawing.Point(356, 338)
        Me.btnPosition7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition7.Name = "btnPosition7"
        Me.btnPosition7.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition7.TabIndex = 90
        Me.btnPosition7.Text = "Button29"
        Me.btnPosition7.UseVisualStyleBackColor = True
        Me.btnPosition7.Visible = False
        '
        'lblLetter12
        '
        Me.lblLetter12.AccessibleName = ""
        Me.lblLetter12.AutoSize = True
        Me.lblLetter12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter12.Location = New System.Drawing.Point(628, 300)
        Me.lblLetter12.Name = "lblLetter12"
        Me.lblLetter12.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter12.TabIndex = 89
        Me.lblLetter12.Visible = False
        '
        'lblLetter11
        '
        Me.lblLetter11.AccessibleName = ""
        Me.lblLetter11.AutoSize = True
        Me.lblLetter11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter11.Location = New System.Drawing.Point(575, 300)
        Me.lblLetter11.Name = "lblLetter11"
        Me.lblLetter11.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter11.TabIndex = 88
        Me.lblLetter11.Visible = False
        '
        'lblLetter10
        '
        Me.lblLetter10.AccessibleName = ""
        Me.lblLetter10.AutoSize = True
        Me.lblLetter10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter10.Location = New System.Drawing.Point(524, 300)
        Me.lblLetter10.Name = "lblLetter10"
        Me.lblLetter10.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter10.TabIndex = 87
        Me.lblLetter10.Visible = False
        '
        'lblLetter8
        '
        Me.lblLetter8.AccessibleName = ""
        Me.lblLetter8.AutoSize = True
        Me.lblLetter8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter8.Location = New System.Drawing.Point(420, 300)
        Me.lblLetter8.Name = "lblLetter8"
        Me.lblLetter8.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter8.TabIndex = 86
        Me.lblLetter8.Visible = False
        '
        'lblLetter9
        '
        Me.lblLetter9.AccessibleName = ""
        Me.lblLetter9.AutoSize = True
        Me.lblLetter9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter9.Location = New System.Drawing.Point(471, 300)
        Me.lblLetter9.Name = "lblLetter9"
        Me.lblLetter9.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter9.TabIndex = 85
        Me.lblLetter9.Visible = False
        '
        'lblLetter7
        '
        Me.lblLetter7.AccessibleName = ""
        Me.lblLetter7.AutoSize = True
        Me.lblLetter7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter7.Location = New System.Drawing.Point(367, 300)
        Me.lblLetter7.Name = "lblLetter7"
        Me.lblLetter7.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter7.TabIndex = 84
        Me.lblLetter7.Visible = False
        '
        'btnPosition20
        '
        Me.btnPosition20.AccessibleName = ""
        Me.btnPosition20.Enabled = False
        Me.btnPosition20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition20.Location = New System.Drawing.Point(1042, 338)
        Me.btnPosition20.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition20.Name = "btnPosition20"
        Me.btnPosition20.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition20.TabIndex = 111
        Me.btnPosition20.Text = "Button34"
        Me.btnPosition20.UseVisualStyleBackColor = True
        Me.btnPosition20.Visible = False
        '
        'btnPosition19
        '
        Me.btnPosition19.AccessibleName = ""
        Me.btnPosition19.Enabled = False
        Me.btnPosition19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition19.Location = New System.Drawing.Point(989, 338)
        Me.btnPosition19.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition19.Name = "btnPosition19"
        Me.btnPosition19.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition19.TabIndex = 110
        Me.btnPosition19.Text = "Button33"
        Me.btnPosition19.UseVisualStyleBackColor = True
        Me.btnPosition19.Visible = False
        '
        'btnPosition18
        '
        Me.btnPosition18.AccessibleName = ""
        Me.btnPosition18.Enabled = False
        Me.btnPosition18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition18.Location = New System.Drawing.Point(936, 338)
        Me.btnPosition18.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition18.Name = "btnPosition18"
        Me.btnPosition18.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition18.TabIndex = 109
        Me.btnPosition18.Text = "Button32"
        Me.btnPosition18.UseVisualStyleBackColor = True
        Me.btnPosition18.Visible = False
        '
        'btnPosition17
        '
        Me.btnPosition17.AccessibleName = ""
        Me.btnPosition17.Enabled = False
        Me.btnPosition17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition17.Location = New System.Drawing.Point(885, 338)
        Me.btnPosition17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition17.Name = "btnPosition17"
        Me.btnPosition17.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition17.TabIndex = 108
        Me.btnPosition17.Text = "Button31"
        Me.btnPosition17.UseVisualStyleBackColor = True
        Me.btnPosition17.Visible = False
        '
        'btnPosition16
        '
        Me.btnPosition16.AccessibleName = ""
        Me.btnPosition16.Enabled = False
        Me.btnPosition16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition16.Location = New System.Drawing.Point(832, 338)
        Me.btnPosition16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition16.Name = "btnPosition16"
        Me.btnPosition16.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition16.TabIndex = 107
        Me.btnPosition16.Text = "Button30"
        Me.btnPosition16.UseVisualStyleBackColor = True
        Me.btnPosition16.Visible = False
        '
        'btnPosition15
        '
        Me.btnPosition15.AccessibleName = ""
        Me.btnPosition15.Enabled = False
        Me.btnPosition15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition15.Location = New System.Drawing.Point(781, 338)
        Me.btnPosition15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition15.Name = "btnPosition15"
        Me.btnPosition15.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition15.TabIndex = 106
        Me.btnPosition15.Text = "Button29"
        Me.btnPosition15.UseVisualStyleBackColor = True
        Me.btnPosition15.Visible = False
        '
        'lblLetter20
        '
        Me.lblLetter20.AccessibleName = ""
        Me.lblLetter20.AutoSize = True
        Me.lblLetter20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter20.Location = New System.Drawing.Point(1053, 300)
        Me.lblLetter20.Name = "lblLetter20"
        Me.lblLetter20.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter20.TabIndex = 105
        Me.lblLetter20.Visible = False
        '
        'lblLetter19
        '
        Me.lblLetter19.AccessibleName = ""
        Me.lblLetter19.AutoSize = True
        Me.lblLetter19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter19.Location = New System.Drawing.Point(1000, 300)
        Me.lblLetter19.Name = "lblLetter19"
        Me.lblLetter19.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter19.TabIndex = 104
        Me.lblLetter19.Visible = False
        '
        'lblLetter18
        '
        Me.lblLetter18.AccessibleName = ""
        Me.lblLetter18.AutoSize = True
        Me.lblLetter18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter18.Location = New System.Drawing.Point(949, 300)
        Me.lblLetter18.Name = "lblLetter18"
        Me.lblLetter18.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter18.TabIndex = 103
        Me.lblLetter18.Visible = False
        '
        'lblLetter16
        '
        Me.lblLetter16.AccessibleName = ""
        Me.lblLetter16.AutoSize = True
        Me.lblLetter16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter16.Location = New System.Drawing.Point(845, 300)
        Me.lblLetter16.Name = "lblLetter16"
        Me.lblLetter16.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter16.TabIndex = 102
        Me.lblLetter16.Visible = False
        '
        'lblLetter17
        '
        Me.lblLetter17.AccessibleName = ""
        Me.lblLetter17.AutoSize = True
        Me.lblLetter17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter17.Location = New System.Drawing.Point(896, 300)
        Me.lblLetter17.Name = "lblLetter17"
        Me.lblLetter17.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter17.TabIndex = 101
        Me.lblLetter17.Visible = False
        '
        'lblLetter15
        '
        Me.lblLetter15.AccessibleName = ""
        Me.lblLetter15.AutoSize = True
        Me.lblLetter15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter15.Location = New System.Drawing.Point(792, 300)
        Me.lblLetter15.Name = "lblLetter15"
        Me.lblLetter15.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter15.TabIndex = 100
        Me.lblLetter15.Visible = False
        '
        'btnPosition14
        '
        Me.btnPosition14.AccessibleName = ""
        Me.btnPosition14.Enabled = False
        Me.btnPosition14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition14.Location = New System.Drawing.Point(726, 338)
        Me.btnPosition14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition14.Name = "btnPosition14"
        Me.btnPosition14.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition14.TabIndex = 99
        Me.btnPosition14.Text = "Button34"
        Me.btnPosition14.UseVisualStyleBackColor = True
        Me.btnPosition14.Visible = False
        '
        'btnPosition13
        '
        Me.btnPosition13.AccessibleName = ""
        Me.btnPosition13.Enabled = False
        Me.btnPosition13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition13.Location = New System.Drawing.Point(673, 338)
        Me.btnPosition13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPosition13.Name = "btnPosition13"
        Me.btnPosition13.Size = New System.Drawing.Size(48, 2)
        Me.btnPosition13.TabIndex = 98
        Me.btnPosition13.Text = "Button33"
        Me.btnPosition13.UseVisualStyleBackColor = True
        Me.btnPosition13.Visible = False
        '
        'lblLetter14
        '
        Me.lblLetter14.AccessibleName = ""
        Me.lblLetter14.AutoSize = True
        Me.lblLetter14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter14.Location = New System.Drawing.Point(737, 300)
        Me.lblLetter14.Name = "lblLetter14"
        Me.lblLetter14.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter14.TabIndex = 97
        Me.lblLetter14.Visible = False
        '
        'lblLetter13
        '
        Me.lblLetter13.AccessibleName = ""
        Me.lblLetter13.AutoSize = True
        Me.lblLetter13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter13.Location = New System.Drawing.Point(684, 300)
        Me.lblLetter13.Name = "lblLetter13"
        Me.lblLetter13.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter13.TabIndex = 96
        Me.lblLetter13.Visible = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 613)
        Me.Controls.Add(Me.btnPosition20)
        Me.Controls.Add(Me.btnPosition19)
        Me.Controls.Add(Me.btnPosition18)
        Me.Controls.Add(Me.btnPosition17)
        Me.Controls.Add(Me.btnPosition16)
        Me.Controls.Add(Me.btnPosition15)
        Me.Controls.Add(Me.lblLetter20)
        Me.Controls.Add(Me.lblLetter19)
        Me.Controls.Add(Me.lblLetter18)
        Me.Controls.Add(Me.lblLetter16)
        Me.Controls.Add(Me.lblLetter17)
        Me.Controls.Add(Me.lblLetter15)
        Me.Controls.Add(Me.btnPosition14)
        Me.Controls.Add(Me.btnPosition13)
        Me.Controls.Add(Me.lblLetter14)
        Me.Controls.Add(Me.lblLetter13)
        Me.Controls.Add(Me.btnPosition12)
        Me.Controls.Add(Me.btnPosition11)
        Me.Controls.Add(Me.btnPosition10)
        Me.Controls.Add(Me.btnPosition9)
        Me.Controls.Add(Me.btnPosition8)
        Me.Controls.Add(Me.btnPosition7)
        Me.Controls.Add(Me.lblLetter12)
        Me.Controls.Add(Me.lblLetter11)
        Me.Controls.Add(Me.lblLetter10)
        Me.Controls.Add(Me.lblLetter8)
        Me.Controls.Add(Me.lblLetter9)
        Me.Controls.Add(Me.lblLetter7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCountRem)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.btnO)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnQ)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnW)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnY)
        Me.Controls.Add(Me.btnZ)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnH)
        Me.Controls.Add(Me.btnI)
        Me.Controls.Add(Me.btnJ)
        Me.Controls.Add(Me.btnK)
        Me.Controls.Add(Me.btnL)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.picHangman)
        Me.Controls.Add(Me.btnPosition6)
        Me.Controls.Add(Me.btnPosition5)
        Me.Controls.Add(Me.btnPosition4)
        Me.Controls.Add(Me.btnPosition3)
        Me.Controls.Add(Me.btnPosition2)
        Me.Controls.Add(Me.btnPosition1)
        Me.Controls.Add(Me.lblLetter6)
        Me.Controls.Add(Me.lblLetter5)
        Me.Controls.Add(Me.lblLetter4)
        Me.Controls.Add(Me.lblLetter2)
        Me.Controls.Add(Me.lblLetter3)
        Me.Controls.Add(Me.lblLetter1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.cmbDifficult)
        Me.Controls.Add(Me.lblDifficult)
        Me.Controls.Add(Me.lblLetters)
        Me.Controls.Add(Me.lblWrongGuesses)
        Me.Controls.Add(Me.txtWrongGuesses)
        Me.Controls.Add(Me.btnA)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.picHangman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents txtWrongGuesses As System.Windows.Forms.TextBox
    Friend WithEvents lblWrongGuesses As System.Windows.Forms.Label
    Friend WithEvents lblLetters As System.Windows.Forms.Label
    Friend WithEvents lblDifficult As System.Windows.Forms.Label
    Friend WithEvents cmbDifficult As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblLetter1 As System.Windows.Forms.Label
    Friend WithEvents lblLetter3 As System.Windows.Forms.Label
    Friend WithEvents lblLetter2 As System.Windows.Forms.Label
    Friend WithEvents lblLetter4 As System.Windows.Forms.Label
    Friend WithEvents lblLetter5 As System.Windows.Forms.Label
    Friend WithEvents lblLetter6 As System.Windows.Forms.Label
    Friend WithEvents btnPosition1 As System.Windows.Forms.Button
    Friend WithEvents btnPosition2 As System.Windows.Forms.Button
    Friend WithEvents btnPosition3 As System.Windows.Forms.Button
    Friend WithEvents btnPosition4 As System.Windows.Forms.Button
    Friend WithEvents btnPosition5 As System.Windows.Forms.Button
    Friend WithEvents btnPosition6 As System.Windows.Forms.Button
    Friend WithEvents picHangman As System.Windows.Forms.PictureBox
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents btnL As System.Windows.Forms.Button
    Friend WithEvents btnK As System.Windows.Forms.Button
    Friend WithEvents btnJ As System.Windows.Forms.Button
    Friend WithEvents btnI As System.Windows.Forms.Button
    Friend WithEvents btnH As System.Windows.Forms.Button
    Friend WithEvents btnG As System.Windows.Forms.Button
    Friend WithEvents btnF As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnO As System.Windows.Forms.Button
    Friend WithEvents btnP As System.Windows.Forms.Button
    Friend WithEvents btnQ As System.Windows.Forms.Button
    Friend WithEvents btnR As System.Windows.Forms.Button
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnU As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents btnW As System.Windows.Forms.Button
    Friend WithEvents btnX As System.Windows.Forms.Button
    Friend WithEvents btnY As System.Windows.Forms.Button
    Friend WithEvents btnZ As System.Windows.Forms.Button
    Friend WithEvents btnN As System.Windows.Forms.Button
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents lblCountRem As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnPosition12 As System.Windows.Forms.Button
    Friend WithEvents btnPosition11 As System.Windows.Forms.Button
    Friend WithEvents btnPosition10 As System.Windows.Forms.Button
    Friend WithEvents btnPosition9 As System.Windows.Forms.Button
    Friend WithEvents btnPosition8 As System.Windows.Forms.Button
    Friend WithEvents btnPosition7 As System.Windows.Forms.Button
    Friend WithEvents lblLetter12 As System.Windows.Forms.Label
    Friend WithEvents lblLetter11 As System.Windows.Forms.Label
    Friend WithEvents lblLetter10 As System.Windows.Forms.Label
    Friend WithEvents lblLetter8 As System.Windows.Forms.Label
    Friend WithEvents lblLetter9 As System.Windows.Forms.Label
    Friend WithEvents lblLetter7 As System.Windows.Forms.Label
    Friend WithEvents btnPosition20 As System.Windows.Forms.Button
    Friend WithEvents btnPosition19 As System.Windows.Forms.Button
    Friend WithEvents btnPosition18 As System.Windows.Forms.Button
    Friend WithEvents btnPosition17 As System.Windows.Forms.Button
    Friend WithEvents btnPosition16 As System.Windows.Forms.Button
    Friend WithEvents btnPosition15 As System.Windows.Forms.Button
    Friend WithEvents lblLetter20 As System.Windows.Forms.Label
    Friend WithEvents lblLetter19 As System.Windows.Forms.Label
    Friend WithEvents lblLetter18 As System.Windows.Forms.Label
    Friend WithEvents lblLetter16 As System.Windows.Forms.Label
    Friend WithEvents lblLetter17 As System.Windows.Forms.Label
    Friend WithEvents lblLetter15 As System.Windows.Forms.Label
    Friend WithEvents btnPosition14 As System.Windows.Forms.Button
    Friend WithEvents btnPosition13 As System.Windows.Forms.Button
    Friend WithEvents lblLetter14 As System.Windows.Forms.Label
    Friend WithEvents lblLetter13 As System.Windows.Forms.Label
End Class
