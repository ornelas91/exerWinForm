Public Class Pessoa
    Private nome As String
    Private cpf As String

    Public Sub New()
    End Sub

    Public Sub New(nome As String, cpf As String)
        Me.nome = nome
        Me.cpf = cpf
    End Sub

    Public Property pNome As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Property pCpf As String
        Get
            Return cpf
        End Get
        Set(value As String)
            cpf = value
        End Set
    End Property
End Class
