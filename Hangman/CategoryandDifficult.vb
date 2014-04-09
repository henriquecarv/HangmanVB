Imports System.Data.OleDb

Public Class CategoryandDifficult
    Dim difficulties = New String() {"Easy", "Medium", "Hard"}
    Public difficult As String

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Me.Hide()
        Game.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        difficult = cmbCategory.Text
    End Sub

    Private Sub CategoryandDifficult_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub CategoryandDifficult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hangman.accdb;Persist Security Info=False;")
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
    End Sub

End Class