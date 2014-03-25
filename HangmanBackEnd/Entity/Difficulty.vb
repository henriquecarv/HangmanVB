Public Class Difficulty

#Region "Fields"
    Private variableName As String
    Private variableGuess As Integer
#End Region

#Region "Properties"
    Property Name() As String
        Get
            Return variableName
        End Get
        Set(ByVal value As String)
            variableName = value
        End Set
    End Property

    Property Guess() As Integer
        Get
            Return variableGuess
        End Get
        Set(ByVal value As Integer)
            variableGuess = value
        End Set
    End Property
#End Region

End Class
