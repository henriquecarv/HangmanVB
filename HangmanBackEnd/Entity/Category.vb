Public Class Category

#Region "Fields"
    Private variableIdCategory As Integer
    Private variableCategory As String
#End Region

#Region "Properties"
    Property IdCategory() As Integer
        Get
            Return variableIdCategory
        End Get
        Set(ByVal value As Integer)
            variableIdCategory = value
        End Set
    End Property

    Property Category() As String
        Get
            Return variableCategory
        End Get
        Set(ByVal value As String)
            variableCategory = value
        End Set
    End Property

#End Region
End Class
