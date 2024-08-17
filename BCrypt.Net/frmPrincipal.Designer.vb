<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.txtSenhaLimpa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenhaHash = New System.Windows.Forms.TextBox()
        Me.btnGerar = New System.Windows.Forms.Button()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.pictBoxLogoPainel = New System.Windows.Forms.PictureBox()
        Me.lblPainel = New System.Windows.Forms.Label()
        Me.pictBoxPainel = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaltos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        CType(Me.pictBoxLogoPainel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictBoxPainel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSenhaLimpa
        '
        Me.txtSenhaLimpa.Location = New System.Drawing.Point(120, 148)
        Me.txtSenhaLimpa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenhaLimpa.Name = "txtSenhaLimpa"
        Me.txtSenhaLimpa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtSenhaLimpa.Size = New System.Drawing.Size(287, 22)
        Me.txtSenhaLimpa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 151)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hash Senha:"
        '
        'txtSenhaHash
        '
        Me.txtSenhaHash.Location = New System.Drawing.Point(120, 185)
        Me.txtSenhaHash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenhaHash.Multiline = True
        Me.txtSenhaHash.Name = "txtSenhaHash"
        Me.txtSenhaHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSenhaHash.Size = New System.Drawing.Size(436, 109)
        Me.txtSenhaHash.TabIndex = 3
        '
        'btnGerar
        '
        Me.btnGerar.Location = New System.Drawing.Point(120, 310)
        Me.btnGerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(206, 28)
        Me.btnGerar.TabIndex = 4
        Me.btnGerar.Text = "Gerar Hash"
        Me.btnGerar.UseVisualStyleBackColor = True
        '
        'btnComparar
        '
        Me.btnComparar.Location = New System.Drawing.Point(348, 310)
        Me.btnComparar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(208, 28)
        Me.btnComparar.TabIndex = 5
        Me.btnComparar.Text = "Comparar"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'pictBoxLogoPainel
        '
        Me.pictBoxLogoPainel.Image = CType(resources.GetObject("pictBoxLogoPainel.Image"), System.Drawing.Image)
        Me.pictBoxLogoPainel.Location = New System.Drawing.Point(17, 13)
        Me.pictBoxLogoPainel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictBoxLogoPainel.Name = "pictBoxLogoPainel"
        Me.pictBoxLogoPainel.Size = New System.Drawing.Size(48, 48)
        Me.pictBoxLogoPainel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictBoxLogoPainel.TabIndex = 55
        Me.pictBoxLogoPainel.TabStop = False
        '
        'lblPainel
        '
        Me.lblPainel.AutoSize = True
        Me.lblPainel.BackColor = System.Drawing.Color.Transparent
        Me.lblPainel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPainel.ForeColor = System.Drawing.Color.White
        Me.lblPainel.Location = New System.Drawing.Point(93, 32)
        Me.lblPainel.Name = "lblPainel"
        Me.lblPainel.Size = New System.Drawing.Size(186, 29)
        Me.lblPainel.TabIndex = 54
        Me.lblPainel.Text = "BCrypt.Net-Next"
        '
        'pictBoxPainel
        '
        Me.pictBoxPainel.BackColor = System.Drawing.Color.SteelBlue
        Me.pictBoxPainel.Location = New System.Drawing.Point(0, 0)
        Me.pictBoxPainel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictBoxPainel.Name = "pictBoxPainel"
        Me.pictBoxPainel.Size = New System.Drawing.Size(637, 86)
        Me.pictBoxPainel.TabIndex = 53
        Me.pictBoxPainel.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Image = CType(resources.GetObject("CheckBox1.Image"), System.Drawing.Image)
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CheckBox1.Location = New System.Drawing.Point(427, 142)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 32)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.Text = "         Visualizar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Saltos:"
        '
        'txtSaltos
        '
        Me.txtSaltos.Location = New System.Drawing.Point(120, 113)
        Me.txtSaltos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaltos.Name = "txtSaltos"
        Me.txtSaltos.Size = New System.Drawing.Size(49, 22)
        Me.txtSaltos.TabIndex = 57
        Me.txtSaltos.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 17)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Quanto maior, maior será o tempo de processamento."
        '
        'btnSelecionar
        '
        Me.btnSelecionar.FlatAppearance.BorderSize = 0
        Me.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelecionar.Image = CType(resources.GetObject("btnSelecionar.Image"), System.Drawing.Image)
        Me.btnSelecionar.Location = New System.Drawing.Point(564, 264)
        Me.btnSelecionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(35, 30)
        Me.btnSelecionar.TabIndex = 61
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 360)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSaltos)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.pictBoxLogoPainel)
        Me.Controls.Add(Me.lblPainel)
        Me.Controls.Add(Me.pictBoxPainel)
        Me.Controls.Add(Me.btnComparar)
        Me.Controls.Add(Me.btnGerar)
        Me.Controls.Add(Me.txtSenhaHash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSenhaLimpa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BCrypt.Net - rijndael"
        CType(Me.pictBoxLogoPainel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictBoxPainel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSenhaLimpa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSenhaHash As TextBox
    Friend WithEvents btnGerar As Button
    Friend WithEvents btnComparar As Button
    Friend WithEvents pictBoxLogoPainel As PictureBox
    Friend WithEvents lblPainel As Label
    Friend WithEvents pictBoxPainel As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaltos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSelecionar As Button
End Class
