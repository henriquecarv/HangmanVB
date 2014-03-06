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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.btnA = New System.Windows.Forms.Button
        Me.txtWrongGuesses = New System.Windows.Forms.TextBox
        Me.lblWrongGuesses = New System.Windows.Forms.Label
        Me.lblLetters = New System.Windows.Forms.Label
        Me.lblDifficult = New System.Windows.Forms.Label
        Me.cmbDifficult = New System.Windows.Forms.ComboBox
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.lblCategory = New System.Windows.Forms.Label
        Me.btnRestart = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblLetter1 = New System.Windows.Forms.Label
        Me.lblLetter3 = New System.Windows.Forms.Label
        Me.lblLetter2 = New System.Windows.Forms.Label
        Me.lblLetter4 = New System.Windows.Forms.Label
        Me.lblLetter5 = New System.Windows.Forms.Label
        Me.lblLetter6 = New System.Windows.Forms.Label
        Me.btnPosition1 = New System.Windows.Forms.Button
        Me.btnPosition2 = New System.Windows.Forms.Button
        Me.btnPosition3 = New System.Windows.Forms.Button
        Me.btnPosition4 = New System.Windows.Forms.Button
        Me.btnPosition5 = New System.Windows.Forms.Button
        Me.btnPosition6 = New System.Windows.Forms.Button
        Me.picImage = New System.Windows.Forms.PictureBox
        Me.btnM = New System.Windows.Forms.Button
        Me.btnL = New System.Windows.Forms.Button
        Me.btnK = New System.Windows.Forms.Button
        Me.btnJ = New System.Windows.Forms.Button
        Me.btnI = New System.Windows.Forms.Button
        Me.btnH = New System.Windows.Forms.Button
        Me.btnG = New System.Windows.Forms.Button
        Me.btnF = New System.Windows.Forms.Button
        Me.btnE = New System.Windows.Forms.Button
        Me.btnD = New System.Windows.Forms.Button
        Me.btnC = New System.Windows.Forms.Button
        Me.btnB = New System.Windows.Forms.Button
        Me.btnO = New System.Windows.Forms.Button
        Me.btnP = New System.Windows.Forms.Button
        Me.btnQ = New System.Windows.Forms.Button
        Me.btnR = New System.Windows.Forms.Button
        Me.btnS = New System.Windows.Forms.Button
        Me.btnT = New System.Windows.Forms.Button
        Me.btnU = New System.Windows.Forms.Button
        Me.btnV = New System.Windows.Forms.Button
        Me.btnW = New System.Windows.Forms.Button
        Me.btnX = New System.Windows.Forms.Button
        Me.btnY = New System.Windows.Forms.Button
        Me.btnZ = New System.Windows.Forms.Button
        Me.btnN = New System.Windows.Forms.Button
        Me.lblRemaining = New System.Windows.Forms.Label
        Me.lblCountRem = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnA
        '
        Me.btnA.AccessibleName = ""
        Me.btnA.Location = New System.Drawing.Point(27, 362)
        Me.btnA.Margin = New System.Windows.Forms.Padding(2)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(38, 34)
        Me.btnA.TabIndex = 0
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'txtWrongGuesses
        '
        Me.txtWrongGuesses.AccessibleName = "txtBoxWrong"
        Me.txtWrongGuesses.Location = New System.Drawing.Point(691, 226)
        Me.txtWrongGuesses.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWrongGuesses.Multiline = True
        Me.txtWrongGuesses.Name = "txtWrongGuesses"
        Me.txtWrongGuesses.Size = New System.Drawing.Size(150, 166)
        Me.txtWrongGuesses.TabIndex = 34
        '
        'lblWrongGuesses
        '
        Me.lblWrongGuesses.AccessibleName = "lblWordsGuessed"
        Me.lblWrongGuesses.AutoSize = True
        Me.lblWrongGuesses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrongGuesses.Location = New System.Drawing.Point(707, 204)
        Me.lblWrongGuesses.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWrongGuesses.Name = "lblWrongGuesses"
        Me.lblWrongGuesses.Size = New System.Drawing.Size(124, 20)
        Me.lblWrongGuesses.TabIndex = 35
        Me.lblWrongGuesses.Text = "Wrong Guesses"
        '
        'lblLetters
        '
        Me.lblLetters.AccessibleName = "lblLetters"
        Me.lblLetters.AutoSize = True
        Me.lblLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetters.Location = New System.Drawing.Point(24, 318)
        Me.lblLetters.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetters.Name = "lblLetters"
        Me.lblLetters.Size = New System.Drawing.Size(53, 18)
        Me.lblLetters.TabIndex = 36
        Me.lblLetters.Text = "Letters"
        '
        'lblDifficult
        '
        Me.lblDifficult.AccessibleName = "lblDifficult"
        Me.lblDifficult.AutoSize = True
        Me.lblDifficult.Location = New System.Drawing.Point(690, 28)
        Me.lblDifficult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDifficult.Name = "lblDifficult"
        Me.lblDifficult.Size = New System.Drawing.Size(53, 13)
        Me.lblDifficult.TabIndex = 37
        Me.lblDifficult.Text = "Difficulty: "
        '
        'cmbDifficult
        '
        Me.cmbDifficult.AccessibleName = "comboBoxDifficult"
        Me.cmbDifficult.FormattingEnabled = True
        Me.cmbDifficult.Items.AddRange(New Object() {"Easy", "Medium", "Hard"})
        Me.cmbDifficult.Location = New System.Drawing.Point(742, 28)
        Me.cmbDifficult.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDifficult.Name = "cmbDifficult"
        Me.cmbDifficult.Size = New System.Drawing.Size(92, 21)
        Me.cmbDifficult.TabIndex = 38
        '
        'cmbCategory
        '
        Me.cmbCategory.AccessibleName = "comboBoxCategory"
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(742, 74)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(92, 21)
        Me.cmbCategory.TabIndex = 39
        '
        'lblCategory
        '
        Me.lblCategory.AccessibleName = "lblCategory"
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(690, 76)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(52, 13)
        Me.lblCategory.TabIndex = 40
        Me.lblCategory.Text = "Category:"
        '
        'btnRestart
        '
        Me.btnRestart.AccessibleName = "btnRestart"
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(770, 440)
        Me.btnRestart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(71, 29)
        Me.btnRestart.TabIndex = 41
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(692, 440)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(59, 28)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLetter1
        '
        Me.lblLetter1.AccessibleName = "lblLetter1"
        Me.lblLetter1.AutoSize = True
        Me.lblLetter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter1.Location = New System.Drawing.Point(38, 244)
        Me.lblLetter1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(0, 29)
        Me.lblLetter1.TabIndex = 43
        '
        'lblLetter3
        '
        Me.lblLetter3.AccessibleName = "lblLetter3"
        Me.lblLetter3.AutoSize = True
        Me.lblLetter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter3.Location = New System.Drawing.Point(116, 244)
        Me.lblLetter3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetter3.Name = "lblLetter3"
        Me.lblLetter3.Size = New System.Drawing.Size(0, 29)
        Me.lblLetter3.TabIndex = 44
        '
        'lblLetter2
        '
        Me.lblLetter2.AccessibleName = "lblLetter2"
        Me.lblLetter2.AutoSize = True
        Me.lblLetter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter2.Location = New System.Drawing.Point(78, 244)
        Me.lblLetter2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(0, 29)
        Me.lblLetter2.TabIndex = 45
        '
        'lblLetter4
        '
        Me.lblLetter4.AccessibleName = "lblLetter4"
        Me.lblLetter4.AutoSize = True
        Me.lblLetter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter4.Location = New System.Drawing.Point(156, 244)
        Me.lblLetter4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetter4.Name = "lblLetter4"
        Me.lblLetter4.Size = New System.Drawing.Size(0, 29)
        Me.lblLetter4.TabIndex = 46
        '
        'lblLetter5
        '
        Me.lblLetter5.AccessibleName = "lblLetter5"
        Me.lblLetter5.AutoSize = True
        Me.lblLetter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter5.Location = New System.Drawing.Point(194, 244)
        Me.lblLetter5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetter5.Name = "lblLetter5"
        Me.lblLetter5.Size = New System.Drawing.Size(0, 29)
        Me.lblLetter5.TabIndex = 47
        '
        'lblLetter6
        '
        Me.lblLetter6.AccessibleName = "lblLetter6"
        Me.lblLetter6.AutoSize = True
        Me.lblLetter6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter6.Location = New System.Drawing.Point(234, 244)
        Me.lblLetter6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetter6.Name = "lblLetter6"
        Me.lblLetter6.Size = New System.Drawing.Size(0, 29)
        Me.lblLetter6.TabIndex = 48
        '
        'btnPosition1
        '
        Me.btnPosition1.AccessibleName = "btnPosition1"
        Me.btnPosition1.Enabled = False
        Me.btnPosition1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition1.Location = New System.Drawing.Point(30, 275)
        Me.btnPosition1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPosition1.Name = "btnPosition1"
        Me.btnPosition1.Size = New System.Drawing.Size(36, 2)
        Me.btnPosition1.TabIndex = 49
        Me.btnPosition1.Text = "Button29"
        Me.btnPosition1.UseVisualStyleBackColor = True
        '
        'btnPosition2
        '
        Me.btnPosition2.AccessibleName = "btnPosition2"
        Me.btnPosition2.Enabled = False
        Me.btnPosition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition2.Location = New System.Drawing.Point(68, 275)
        Me.btnPosition2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPosition2.Name = "btnPosition2"
        Me.btnPosition2.Size = New System.Drawing.Size(36, 2)
        Me.btnPosition2.TabIndex = 50
        Me.btnPosition2.Text = "Button30"
        Me.btnPosition2.UseVisualStyleBackColor = True
        '
        'btnPosition3
        '
        Me.btnPosition3.AccessibleName = "btnPosition3"
        Me.btnPosition3.Enabled = False
        Me.btnPosition3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition3.Location = New System.Drawing.Point(108, 275)
        Me.btnPosition3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPosition3.Name = "btnPosition3"
        Me.btnPosition3.Size = New System.Drawing.Size(36, 2)
        Me.btnPosition3.TabIndex = 51
        Me.btnPosition3.Text = "Button31"
        Me.btnPosition3.UseVisualStyleBackColor = True
        '
        'btnPosition4
        '
        Me.btnPosition4.AccessibleName = "btnPosition4"
        Me.btnPosition4.Enabled = False
        Me.btnPosition4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition4.Location = New System.Drawing.Point(146, 275)
        Me.btnPosition4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPosition4.Name = "btnPosition4"
        Me.btnPosition4.Size = New System.Drawing.Size(36, 2)
        Me.btnPosition4.TabIndex = 52
        Me.btnPosition4.Text = "Button32"
        Me.btnPosition4.UseVisualStyleBackColor = True
        '
        'btnPosition5
        '
        Me.btnPosition5.AccessibleName = "btnPosition5"
        Me.btnPosition5.Enabled = False
        Me.btnPosition5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition5.Location = New System.Drawing.Point(186, 275)
        Me.btnPosition5.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPosition5.Name = "btnPosition5"
        Me.btnPosition5.Size = New System.Drawing.Size(36, 2)
        Me.btnPosition5.TabIndex = 53
        Me.btnPosition5.Text = "Button33"
        Me.btnPosition5.UseVisualStyleBackColor = True
        '
        'btnPosition6
        '
        Me.btnPosition6.AccessibleName = "btnPosition6"
        Me.btnPosition6.Enabled = False
        Me.btnPosition6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPosition6.Location = New System.Drawing.Point(226, 275)
        Me.btnPosition6.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPosition6.Name = "btnPosition6"
        Me.btnPosition6.Size = New System.Drawing.Size(36, 2)
        Me.btnPosition6.TabIndex = 54
        Me.btnPosition6.Text = "Button34"
        Me.btnPosition6.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.AccessibleName = "picture1"
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(27, 20)
        Me.picImage.Margin = New System.Windows.Forms.Padding(2)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(562, 193)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 55
        Me.picImage.TabStop = False
        '
        'btnM
        '
        Me.btnM.AccessibleName = ""
        Me.btnM.Location = New System.Drawing.Point(531, 362)
        Me.btnM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(38, 34)
        Me.btnM.TabIndex = 56
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.AccessibleName = ""
        Me.btnL.Location = New System.Drawing.Point(489, 362)
        Me.btnL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(38, 34)
        Me.btnL.TabIndex = 57
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.AccessibleName = ""
        Me.btnK.Location = New System.Drawing.Point(447, 362)
        Me.btnK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(38, 34)
        Me.btnK.TabIndex = 58
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.AccessibleName = ""
        Me.btnJ.Location = New System.Drawing.Point(405, 362)
        Me.btnJ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(38, 34)
        Me.btnJ.TabIndex = 59
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.AccessibleName = ""
        Me.btnI.Location = New System.Drawing.Point(363, 362)
        Me.btnI.Margin = New System.Windows.Forms.Padding(2)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(38, 34)
        Me.btnI.TabIndex = 60
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.AccessibleName = ""
        Me.btnH.Location = New System.Drawing.Point(321, 362)
        Me.btnH.Margin = New System.Windows.Forms.Padding(2)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(38, 34)
        Me.btnH.TabIndex = 61
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.AccessibleName = ""
        Me.btnG.Location = New System.Drawing.Point(279, 362)
        Me.btnG.Margin = New System.Windows.Forms.Padding(2)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(38, 34)
        Me.btnG.TabIndex = 62
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.AccessibleName = ""
        Me.btnF.Location = New System.Drawing.Point(237, 362)
        Me.btnF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(38, 34)
        Me.btnF.TabIndex = 63
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.AccessibleName = ""
        Me.btnE.Location = New System.Drawing.Point(195, 362)
        Me.btnE.Margin = New System.Windows.Forms.Padding(2)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(38, 34)
        Me.btnE.TabIndex = 64
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.AccessibleName = ""
        Me.btnD.Location = New System.Drawing.Point(153, 362)
        Me.btnD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(38, 34)
        Me.btnD.TabIndex = 65
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.AccessibleName = ""
        Me.btnC.Location = New System.Drawing.Point(111, 362)
        Me.btnC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(38, 34)
        Me.btnC.TabIndex = 66
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.AccessibleName = "btnB"
        Me.btnB.Location = New System.Drawing.Point(69, 362)
        Me.btnB.Margin = New System.Windows.Forms.Padding(2)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(38, 34)
        Me.btnB.TabIndex = 67
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.AccessibleName = ""
        Me.btnO.Location = New System.Drawing.Point(69, 439)
        Me.btnO.Margin = New System.Windows.Forms.Padding(2)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(38, 34)
        Me.btnO.TabIndex = 80
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.AccessibleName = ""
        Me.btnP.Location = New System.Drawing.Point(111, 439)
        Me.btnP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(38, 34)
        Me.btnP.TabIndex = 79
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.AccessibleName = ""
        Me.btnQ.Location = New System.Drawing.Point(153, 439)
        Me.btnQ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(38, 34)
        Me.btnQ.TabIndex = 78
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.AccessibleName = ""
        Me.btnR.Location = New System.Drawing.Point(195, 439)
        Me.btnR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(38, 34)
        Me.btnR.TabIndex = 77
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.AccessibleName = ""
        Me.btnS.Location = New System.Drawing.Point(237, 439)
        Me.btnS.Margin = New System.Windows.Forms.Padding(2)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(38, 34)
        Me.btnS.TabIndex = 76
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.AccessibleName = ""
        Me.btnT.Location = New System.Drawing.Point(279, 439)
        Me.btnT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(38, 34)
        Me.btnT.TabIndex = 75
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.AccessibleName = ""
        Me.btnU.Location = New System.Drawing.Point(321, 439)
        Me.btnU.Margin = New System.Windows.Forms.Padding(2)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(38, 34)
        Me.btnU.TabIndex = 74
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.AccessibleName = ""
        Me.btnV.Location = New System.Drawing.Point(363, 439)
        Me.btnV.Margin = New System.Windows.Forms.Padding(2)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(38, 34)
        Me.btnV.TabIndex = 73
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.AccessibleName = ""
        Me.btnW.Location = New System.Drawing.Point(405, 439)
        Me.btnW.Margin = New System.Windows.Forms.Padding(2)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(38, 34)
        Me.btnW.TabIndex = 72
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.AccessibleName = ""
        Me.btnX.Location = New System.Drawing.Point(447, 439)
        Me.btnX.Margin = New System.Windows.Forms.Padding(2)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(38, 34)
        Me.btnX.TabIndex = 71
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.AccessibleName = ""
        Me.btnY.Location = New System.Drawing.Point(489, 439)
        Me.btnY.Margin = New System.Windows.Forms.Padding(2)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(38, 34)
        Me.btnY.TabIndex = 70
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.AccessibleName = ""
        Me.btnZ.Location = New System.Drawing.Point(531, 439)
        Me.btnZ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(38, 34)
        Me.btnZ.TabIndex = 69
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.AccessibleName = ""
        Me.btnN.Location = New System.Drawing.Point(27, 438)
        Me.btnN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(38, 34)
        Me.btnN.TabIndex = 68
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(688, 141)
        Me.lblRemaining.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(139, 17)
        Me.lblRemaining.TabIndex = 81
        Me.lblRemaining.Text = "Remaining Guesses:"
        '
        'lblCountRem
        '
        Me.lblCountRem.AutoSize = True
        Me.lblCountRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountRem.ForeColor = System.Drawing.Color.Red
        Me.lblCountRem.Location = New System.Drawing.Point(824, 138)
        Me.lblCountRem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCountRem.Name = "lblCountRem"
        Me.lblCountRem.Size = New System.Drawing.Size(18, 20)
        Me.lblCountRem.TabIndex = 82
        Me.lblCountRem.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(623, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 83
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 498)
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
        Me.Controls.Add(Me.picImage)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
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
End Class
