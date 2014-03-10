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
        Me.picImage = New System.Windows.Forms.PictureBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblLetter1.AccessibleName = "lblLetter1"
        Me.lblLetter1.AutoSize = True
        Me.lblLetter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter1.Location = New System.Drawing.Point(51, 300)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter1.TabIndex = 43
        '
        'lblLetter3
        '
        Me.lblLetter3.AccessibleName = "lblLetter3"
        Me.lblLetter3.AutoSize = True
        Me.lblLetter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter3.Location = New System.Drawing.Point(155, 300)
        Me.lblLetter3.Name = "lblLetter3"
        Me.lblLetter3.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter3.TabIndex = 44
        '
        'lblLetter2
        '
        Me.lblLetter2.AccessibleName = "lblLetter2"
        Me.lblLetter2.AutoSize = True
        Me.lblLetter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter2.Location = New System.Drawing.Point(104, 300)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter2.TabIndex = 45
        '
        'lblLetter4
        '
        Me.lblLetter4.AccessibleName = "lblLetter4"
        Me.lblLetter4.AutoSize = True
        Me.lblLetter4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter4.Location = New System.Drawing.Point(208, 300)
        Me.lblLetter4.Name = "lblLetter4"
        Me.lblLetter4.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter4.TabIndex = 46
        '
        'lblLetter5
        '
        Me.lblLetter5.AccessibleName = "lblLetter5"
        Me.lblLetter5.AutoSize = True
        Me.lblLetter5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter5.Location = New System.Drawing.Point(259, 300)
        Me.lblLetter5.Name = "lblLetter5"
        Me.lblLetter5.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter5.TabIndex = 47
        '
        'lblLetter6
        '
        Me.lblLetter6.AccessibleName = "lblLetter6"
        Me.lblLetter6.AutoSize = True
        Me.lblLetter6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter6.Location = New System.Drawing.Point(312, 300)
        Me.lblLetter6.Name = "lblLetter6"
        Me.lblLetter6.Size = New System.Drawing.Size(0, 36)
        Me.lblLetter6.TabIndex = 48
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
        '
        'picImage
        '
        Me.picImage.AccessibleName = "picture1"
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(36, 25)
        Me.picImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(964, 238)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 55
        Me.picImage.TabStop = False
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
        '
        'Label1
        '
        Me.Label1.AccessibleName = "lblLetter6"
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(628, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 36)
        Me.Label1.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AccessibleName = "lblLetter5"
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(575, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 36)
        Me.Label2.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AccessibleName = "lblLetter4"
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(524, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 36)
        Me.Label3.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AccessibleName = "lblLetter2"
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(420, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 36)
        Me.Label4.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AccessibleName = "lblLetter3"
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(471, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 36)
        Me.Label5.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AccessibleName = "lblLetter1"
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(367, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 36)
        Me.Label6.TabIndex = 84
        '
        'Button1
        '
        Me.Button1.AccessibleName = ""
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1042, 338)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 2)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "Button34"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AccessibleName = ""
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(989, 338)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 2)
        Me.Button2.TabIndex = 110
        Me.Button2.Text = "Button33"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AccessibleName = ""
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(936, 338)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 2)
        Me.Button3.TabIndex = 109
        Me.Button3.Text = "Button32"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AccessibleName = ""
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(885, 338)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 2)
        Me.Button4.TabIndex = 108
        Me.Button4.Text = "Button31"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.AccessibleName = ""
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(832, 338)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 2)
        Me.Button5.TabIndex = 107
        Me.Button5.Text = "Button30"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.AccessibleName = ""
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(781, 338)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(48, 2)
        Me.Button6.TabIndex = 106
        Me.Button6.Text = "Button29"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AccessibleName = "lblLetter6"
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1053, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 36)
        Me.Label7.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AccessibleName = "lblLetter5"
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1000, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 36)
        Me.Label8.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.AccessibleName = "lblLetter4"
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(949, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 36)
        Me.Label9.TabIndex = 103
        '
        'Label10
        '
        Me.Label10.AccessibleName = "lblLetter2"
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(845, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 36)
        Me.Label10.TabIndex = 102
        '
        'Label11
        '
        Me.Label11.AccessibleName = "lblLetter3"
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(896, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 36)
        Me.Label11.TabIndex = 101
        '
        'Label12
        '
        Me.Label12.AccessibleName = "lblLetter1"
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(792, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 36)
        Me.Label12.TabIndex = 100
        '
        'Button7
        '
        Me.Button7.AccessibleName = ""
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(726, 338)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(48, 2)
        Me.Button7.TabIndex = 99
        Me.Button7.Text = "Button34"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.AccessibleName = ""
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(673, 338)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(48, 2)
        Me.Button8.TabIndex = 98
        Me.Button8.Text = "Button33"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AccessibleName = "lblLetter6"
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(737, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 36)
        Me.Label13.TabIndex = 97
        '
        'Label14
        '
        Me.Label14.AccessibleName = "lblLetter5"
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(684, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 36)
        Me.Label14.TabIndex = 96
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 613)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnPosition12)
        Me.Controls.Add(Me.btnPosition11)
        Me.Controls.Add(Me.btnPosition10)
        Me.Controls.Add(Me.btnPosition9)
        Me.Controls.Add(Me.btnPosition8)
        Me.Controls.Add(Me.btnPosition7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents btnPosition12 As System.Windows.Forms.Button
    Friend WithEvents btnPosition11 As System.Windows.Forms.Button
    Friend WithEvents btnPosition10 As System.Windows.Forms.Button
    Friend WithEvents btnPosition9 As System.Windows.Forms.Button
    Friend WithEvents btnPosition8 As System.Windows.Forms.Button
    Friend WithEvents btnPosition7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
