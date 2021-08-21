Public Class Professor
    Inherits Pessoa
    Private titulo As String

    Public Sub New()
    End Sub

    Public Sub New(nome As String, cpf As String, titulo As String)
        MyBase.New(nome, cpf)
        Me.titulo = titulo
    End Sub

    Public Property pTitulo As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property
End Class
