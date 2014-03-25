Public Class Word

#Region "Fields"
    Private variableIdWord As Integer
    Private variableWord As String
    Private variableIdCategory As Integer
#End Region

#Region "Properties"
    Property IdWord() As Integer
        Get
            Return variableIdWord
        End Get
        Set(ByVal value As Integer)
            variableIdWord = value
        End Set
    End Property

    Property Word() As String
        Get
            Return variableWord
        End Get
        Set(ByVal value As String)
            variableWord = value
        End Set
    End Property

    Property IdCategory() As Integer
        Get
            Return variableIdCategory
        End Get
        Set(ByVal value As Integer)
            variableIdCategory = value
        End Set
    End Property

#End Region

End Class
