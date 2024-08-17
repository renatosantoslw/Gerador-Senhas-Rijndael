Imports BCrypt
Imports BCrypt.Net.BCrypt

Public Class frmPrincipal

    Const WorkFactor As Integer = 10
    Dim SenhaLimpa
    Dim SenhaHash

    Private Sub btnGerar_Click(sender As Object, e As EventArgs) Handles btnGerar.Click
        Dim datahoraAtual As DateTime = Now
        Dim datahoraInicioProcesso As DateTime = Now

        SenhaLimpa = txtSenhaLimpa.Text
        SenhaHash = HashPassword(SenhaLimpa, Convert.ToInt32(txtSaltos.Text))
        txtSenhaHash.Text = SenhaHash

        Dim datahoraFimProcesso As DateTime = Now
        Dim tempoProcessamento As TimeSpan = datahoraFimProcesso.Subtract(datahoraInicioProcesso)

        MessageBox.Show("Tempo de Processamento: " + tempoProcessamento.ToString, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
        Dim datahoraAtual As DateTime = Now
        Dim datahoraInicioProcesso As DateTime = Now

        Dim passwordsMatch = Verify(txtSenhaLimpa.Text, txtSenhaHash.Text)

        Dim datahoraFimProcesso As DateTime = Now
        Dim tempoProcessamento As TimeSpan = datahoraFimProcesso.Subtract(datahoraInicioProcesso)

        Dim Mensagem As String = String.Empty

        If passwordsMatch = True Then
            Mensagem = "-Sucesso - Senha confere com Hash Senha"
            MessageBox.Show(Mensagem + vbCrLf + "-Tempo de Processamento: " + tempoProcessamento.ToString, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Mensagem = "-Falha - Senha não confere com Hash Senha"
            MessageBox.Show(Mensagem + vbCrLf + "-Tempo de Processamento: " + tempoProcessamento.ToString, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "BCrypt.Net-Next"
        lblPainel.Text = "BCrypt.Net"

        Dim img As New Bitmap(pictBoxPainel.Width, pictBoxPainel.Height)
        Dim brush As New Drawing.Drawing2D.LinearGradientBrush(New PointF(0, 0), New PointF(img.Width, img.Height), Color.SteelBlue, SystemColors.Control)
        Dim gr As Graphics = Graphics.FromImage(img)
        gr.FillRectangle(brush, New RectangleF(0, 0, img.Width, img.Height))
        pictBoxPainel.BackgroundImage = img

        lblPainel.Parent = pictBoxPainel
        lblPainel.BackColor = Color.Transparent
        lblPainel.BringToFront()

        pictBoxLogoPainel.Parent = pictBoxPainel
        pictBoxLogoPainel.BackColor = Color.Transparent
        pictBoxLogoPainel.BringToFront()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtSenhaLimpa.PasswordChar = ""
        Else
            txtSenhaLimpa.PasswordChar = "•"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click
        Clipboard.SetDataObject(txtSenhaHash.Text)
        MessageBox.Show("Hash Copiado")
    End Sub
End Class
