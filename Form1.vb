Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNome.Click

    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub btnPessoa_Click(sender As Object, e As EventArgs) Handles btnPessoa.Click
        Dim pessoa As New Pessoa()
        pessoa.pNome = nome.Text
        pessoa.pCpf = cpf.Text

        lstDados.Items.Add("Nome: " + pessoa.pNome + " - Cpf: " + pessoa.pCpf)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblT.Click

    End Sub

    Private Sub btnGravarProfessor_Click(sender As Object, e As EventArgs) Handles btnGravarProfessor.Click
        Dim prof As New Professor(professor.Text, cpfProfessor.Text, titulo.Text)
        lstDados.Items.Add("Titulo: " + prof.pTitulo + " - Nome: " + prof.pNome + " - Cpf: " + prof.pCpf)
    End Sub
End Class
