Imports System.Data.OleDb

Public Class Game
    Dim letter As String
    Dim randy As New Random
    Dim words As String
    Dim difficulties = New String() {"Easy", "Medium", "Hard"}
    Dim count_difficulty = New Integer() {8, 6, 4}
    Dim wordss As New List(Of String)
    Dim category As Integer

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub Game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data Source=Hangman.accdb;Persist Security Info=False;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Category", con)
        con.Open()
        Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim myDataSet As DataSet = New DataSet()
        myDA.Fill(myDataSet, "Category")

        cmbCategory.DataSource = myDataSet.Tables("Category").DefaultView
        cmbCategory.ValueMember = "category_id"
        cmbCategory.DisplayMember = "category_name"

        con.Close()
        con = Nothing

        cmbDifficult.DataSource = difficulties

        cmbCategory.SelectedIndex = CategoryandDifficult.cmbCategory.SelectedIndex
        cmbDifficult.SelectedIndex = CategoryandDifficult.cmbDifficult.SelectedIndex

        If cmbDifficult.SelectedIndex = 1 Then
            lblCountRem.Text = count_difficulty(cmbDifficult.SelectedIndex).ToString
        ElseIf cmbDifficult.SelectedIndex = 2 Then
            lblCountRem.Text = count_difficulty(cmbDifficult.SelectedIndex).ToString
        Else
            lblCountRem.Text = count_difficulty(cmbDifficult.SelectedIndex).ToString
        End If

        category = CategoryandDifficult.cmbCategory.SelectedIndex + 1
        Dim number As Integer
        number = Word_Random(category)
        Dim rand_number As Integer = randy.Next(1, number)
        words = wordss.Item(rand_number + 1).ToLower
        TextBox1.Text = words

        'words = apple

        '        cmbCategory.Text = CategoryandDifficult.cmbCategory.Text
        '       cmbDifficult.Text = CategoryandDifficult.cmbDifficult.Text
    End Sub

    Function funResult(ByVal pLetter As String)

        Dim result As Boolean = True
        Dim intLength As Integer = words.Length
        Dim intPosition As Integer = 0
        Dim i As Integer = InStr(words, pLetter.ToLower)
        If InStr(words, pLetter.ToLower) > 0 Then
            intPosition = InStr(words, pLetter.ToLower)

            If intPosition = 1 Then
                lblLetter1.Text = pLetter
            ElseIf intPosition = 2 Then
                lblLetter2.Text = pLetter
            ElseIf intPosition = 3 Then
                lblLetter3.Text = pLetter
            ElseIf intPosition = 4 Then
                lblLetter4.Text = pLetter
            ElseIf intPosition = 5 Then
                lblLetter5.Text = pLetter
            ElseIf intPosition = 6 Then
                lblLetter6.Text = pLetter
            End If
        Else
            txtWrongGuesses.Text = txtWrongGuesses.Text + " " + pLetter
        End If

        Return result
    End Function

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        letter = "A"
        funResult(letter)
        btnA.Enabled = False
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        letter = "B"
        funResult(letter)
        btnB.Enabled = False
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        letter = "C"
        funResult(letter)
        btnC.Enabled = False
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        letter = "D"
        funResult(letter)
        btnD.Enabled = False
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        letter = "E"
        funResult(letter)
        btnE.Enabled = False
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        letter = "F"
        funResult(letter)
        btnF.Enabled = False
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        letter = "G"
        funResult(letter)
        btnG.Enabled = False
    End Sub

    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click
        letter = "H"
        funResult(letter)
        btnH.Enabled = False
    End Sub

    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click
        letter = "T"
        funResult(letter)
        btnI.Enabled = False
    End Sub

    Private Sub btnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJ.Click
        letter = "J"
        funResult(letter)
        btnJ.Enabled = False
    End Sub

    Private Sub btnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnK.Click
        letter = "K"
        funResult(letter)
        btnK.Enabled = False
    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        letter = "L"
        funResult(letter)
        btnL.Enabled = False
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        letter = "M"
        funResult(letter)
        btnM.Enabled = False
    End Sub

    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN.Click
        letter = "N"
        funResult(letter)
        btnN.Enabled = False
    End Sub

    Private Sub btnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnO.Click
        letter = "O"
        funResult(letter)
        btnO.Enabled = False
    End Sub

    Private Sub btnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP.Click
        letter = "P"
        funResult(letter)
        btnP.Enabled = False
    End Sub

    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click
        letter = "Q"
        funResult(letter)
        btnQ.Enabled = False
    End Sub

    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click
        letter = "R"
        funResult(letter)
        btnR.Enabled = False
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        letter = "S"
        funResult(letter)
        btnS.Enabled = False
    End Sub

    Private Sub btnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT.Click
        letter = "T"
        funResult(letter)
        btnT.Enabled = False
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        letter = "U"
        funResult(letter)
        btnU.Enabled = False
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        letter = "V"
        funResult(letter)
        btnV.Enabled = False
    End Sub

    Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnW.Click
        letter = "W"
        funResult(letter)
        btnW.Enabled = False
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        letter = "X"
        funResult(letter)
        btnX.Enabled = False
    End Sub

    Private Sub btnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY.Click
        letter = "Y"
        funResult(letter)
        btnY.Enabled = False
    End Sub

    Private Sub btnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZ.Click
        letter = "Z"
        funResult(letter)
        btnZ.Enabled = False
    End Sub

    Private Function Word_Random(ByVal cat_id As Integer) As Integer
        wordss.Clear()
        Dim count_random As Integer
        count_random = 0
        Using comm As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data Source=Hangman.accdb")
            comm.Open()
            Using cmd As New OleDbCommand("SELECT word_name From Word Where word_category = @Category", comm)
                cmd.Parameters.AddWithValue("@Category", cat_id.ToString)
                Using reader As OleDbDataReader = cmd.ExecuteReader
                    While reader.Read
                        wordss.Add(reader("word_name").ToString)
                        count_random += 1
                    End While
                End Using
            End Using
        End Using
        Return count_random
    End Function

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged

        category = cmbCategory.SelectedIndex + 1
        Dim number As Integer
        number = Word_Random(category)
        Dim rand_number As Integer = randy.Next(1, number)
        words = wordss.Item(rand_number + 1).ToLower
        TextBox1.Text = words

        'category = Me.cmbCategory.SelectedIndex
        'Dim number As Integer
        'number = Word_Random(category)
        'Dim rand_number As Integer = randy.Next(number).ToString + 1
        'words = wordss.Item(rand_number + 1)
        'Dim number As Integer = randy.Next(50).ToString + 1
        'Dim i As Integer = Me.cmbCategory.SelectedIndex
        'Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Users\Bhavna\Downloads\Hangman.accdb")
        'Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Word where word_category = " & Me.cmbCategory.SelectedIndex + 1, con)
        'con.Open()
        'Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        'Dim myDataSet As DataSet = New DataSet()
        'myDA.Fill(myDataSet, "Word")

        'cmbDifficult.DataSource = myDataSet.Tables("Word").DefaultView
        ''cmbDifficult.ValueMember = "word_id"
        'cmbDifficult.DisplayMember = "word_name"

        'con.Close()
        'con = Nothing
    End Sub

End Class