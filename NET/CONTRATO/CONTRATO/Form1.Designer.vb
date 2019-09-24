<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrato
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContrato))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbrOpcao = New System.Windows.Forms.ToolStrip()
        Me.cmdSair = New System.Windows.Forms.ToolStripButton()
        Me.cmdLimpar = New System.Windows.Forms.ToolStripButton()
        Me.cmdGravar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.txtContrato = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCnpjCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtPessoa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDtCad = New System.Windows.Forms.MaskedTextBox()
        Me.txtFim = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdGrid = New System.Windows.Forms.DataGridView()
        Me.tbrOpcao.SuspendLayout()
        CType(Me.grdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contrato:"
        '
        'tbrOpcao
        '
        Me.tbrOpcao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSair, Me.cmdLimpar, Me.cmdGravar, Me.cmdConsultar})
        Me.tbrOpcao.Location = New System.Drawing.Point(0, 0)
        Me.tbrOpcao.Name = "tbrOpcao"
        Me.tbrOpcao.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.tbrOpcao.Size = New System.Drawing.Size(508, 25)
        Me.tbrOpcao.TabIndex = 1
        Me.tbrOpcao.Text = "ToolStrip1"
        '
        'cmdSair
        '
        Me.cmdSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSair.Image = CType(resources.GetObject("cmdSair.Image"), System.Drawing.Image)
        Me.cmdSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(23, 22)
        Me.cmdSair.Text = "Sair"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLimpar.Image = CType(resources.GetObject("cmdLimpar.Image"), System.Drawing.Image)
        Me.cmdLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(23, 22)
        Me.cmdLimpar.Text = "Limpar"
        '
        'cmdGravar
        '
        Me.cmdGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(23, 22)
        Me.cmdGravar.Text = "Gravar"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(23, 22)
        Me.cmdConsultar.Text = "Consultar"
        '
        'txtContrato
        '
        Me.txtContrato.Location = New System.Drawing.Point(74, 49)
        Me.txtContrato.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.Size = New System.Drawing.Size(60, 23)
        Me.txtContrato.TabIndex = 2
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(140, 49)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(351, 23)
        Me.txtDescricao.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCnpjCpf
        '
        Me.txtCnpjCpf.Location = New System.Drawing.Point(74, 92)
        Me.txtCnpjCpf.Mask = "##############"
        Me.txtCnpjCpf.Name = "txtCnpjCpf"
        Me.txtCnpjCpf.Size = New System.Drawing.Size(112, 23)
        Me.txtCnpjCpf.TabIndex = 5
        Me.txtCnpjCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'txtPessoa
        '
        Me.txtPessoa.Location = New System.Drawing.Point(192, 92)
        Me.txtPessoa.Name = "txtPessoa"
        Me.txtPessoa.Size = New System.Drawing.Size(299, 23)
        Me.txtPessoa.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dt.Cadastro:"
        '
        'txtDtCad
        '
        Me.txtDtCad.Location = New System.Drawing.Point(103, 133)
        Me.txtDtCad.Mask = "##/##/####"
        Me.txtDtCad.Name = "txtDtCad"
        Me.txtDtCad.Size = New System.Drawing.Size(76, 23)
        Me.txtDtCad.TabIndex = 8
        Me.txtDtCad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'txtFim
        '
        Me.txtFim.Location = New System.Drawing.Point(415, 133)
        Me.txtFim.Mask = "##/##/####"
        Me.txtFim.Name = "txtFim"
        Me.txtFim.Size = New System.Drawing.Size(76, 23)
        Me.txtFim.TabIndex = 10
        Me.txtFim.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dt.Fim:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 13)
        Me.Panel1.TabIndex = 11
        '
        'grdGrid
        '
        Me.grdGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrid.Location = New System.Drawing.Point(12, 177)
        Me.grdGrid.Name = "grdGrid"
        Me.grdGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdGrid.Size = New System.Drawing.Size(484, 176)
        Me.grdGrid.TabIndex = 12
        '
        'frmContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 423)
        Me.Controls.Add(Me.grdGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtFim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDtCad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPessoa)
        Me.Controls.Add(Me.txtCnpjCpf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtContrato)
        Me.Controls.Add(Me.tbrOpcao)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmContrato"
        Me.Text = "Cadastro de Contrato"
        Me.tbrOpcao.ResumeLayout(False)
        Me.tbrOpcao.PerformLayout()
        CType(Me.grdGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbrOpcao As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdLimpar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtContrato As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCnpjCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPessoa As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDtCad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFim As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton

End Class
