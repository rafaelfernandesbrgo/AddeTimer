<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Configuração
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Configuração))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_Tempo = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_Editar = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_Título = New System.Windows.Forms.TextBox()
        Me.Borda = New System.Windows.Forms.Label()
        Me.op_C = New MetroFramework.Controls.MetroRadioButton()
        Me.op_S = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tx_Final = New System.Windows.Forms.TextBox()
        Me.tx_Acompanhamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.bt_Selecionar = New MetroFramework.Controls.MetroButton()
        Me.tx_Modo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Título"
        '
        'tx_Tempo
        '
        Me.tx_Tempo.Enabled = False
        Me.tx_Tempo.Location = New System.Drawing.Point(335, 308)
        Me.tx_Tempo.Name = "tx_Tempo"
        Me.tx_Tempo.Size = New System.Drawing.Size(100, 20)
        Me.tx_Tempo.TabIndex = 2
        Me.tx_Tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_Tempo.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tempo"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 109)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(462, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'bt_Editar
        '
        Me.bt_Editar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_Editar.Location = New System.Drawing.Point(335, 80)
        Me.bt_Editar.Name = "bt_Editar"
        Me.bt_Editar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Editar.TabIndex = 5
        Me.bt_Editar.Text = "Editar"
        Me.bt_Editar.UseCustomBackColor = True
        Me.bt_Editar.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton4.Location = New System.Drawing.Point(99, 466)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton4.TabIndex = 8
        Me.MetroButton4.Text = "Abrir (A)"
        Me.MetroButton4.UseCustomBackColor = True
        Me.MetroButton4.UseSelectable = True
        '
        'MetroButton5
        '
        Me.MetroButton5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton5.Location = New System.Drawing.Point(180, 466)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(92, 23)
        Me.MetroButton5.TabIndex = 9
        Me.MetroButton5.Text = "Play (Espaço)"
        Me.MetroButton5.UseCustomBackColor = True
        Me.MetroButton5.UseSelectable = True
        '
        'MetroButton6
        '
        Me.MetroButton6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton6.Location = New System.Drawing.Point(278, 466)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton6.TabIndex = 10
        Me.MetroButton6.Text = "Pause (P)"
        Me.MetroButton6.UseCustomBackColor = True
        Me.MetroButton6.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Dados:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Selecionado:"
        '
        'tx_Título
        '
        Me.tx_Título.Enabled = False
        Me.tx_Título.Location = New System.Drawing.Point(99, 310)
        Me.tx_Título.Name = "tx_Título"
        Me.tx_Título.Size = New System.Drawing.Size(184, 20)
        Me.tx_Título.TabIndex = 13
        '
        'Borda
        '
        Me.Borda.AutoSize = True
        Me.Borda.Location = New System.Drawing.Point(12, 387)
        Me.Borda.Name = "Borda"
        Me.Borda.Size = New System.Drawing.Size(38, 13)
        Me.Borda.TabIndex = 16
        Me.Borda.Text = "Borda:"
        '
        'op_C
        '
        Me.op_C.AutoSize = True
        Me.op_C.Checked = True
        Me.op_C.Location = New System.Drawing.Point(61, 408)
        Me.op_C.Name = "op_C"
        Me.op_C.Size = New System.Drawing.Size(49, 15)
        Me.op_C.TabIndex = 17
        Me.op_C.TabStop = True
        Me.op_C.Text = "Com"
        Me.op_C.UseSelectable = True
        '
        'op_S
        '
        Me.op_S.AutoSize = True
        Me.op_S.Location = New System.Drawing.Point(116, 408)
        Me.op_S.Name = "op_S"
        Me.op_S.Size = New System.Drawing.Size(46, 15)
        Me.op_S.TabIndex = 19
        Me.op_S.Text = "Sem"
        Me.op_S.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton2.Location = New System.Drawing.Point(99, 495)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(133, 23)
        Me.MetroButton2.TabIndex = 20
        Me.MetroButton2.Text = "Atualizar Borda(F4)"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Frase Final"
        '
        'tx_Final
        '
        Me.tx_Final.Location = New System.Drawing.Point(99, 336)
        Me.tx_Final.Name = "tx_Final"
        Me.tx_Final.Size = New System.Drawing.Size(336, 20)
        Me.tx_Final.TabIndex = 24
        '
        'tx_Acompanhamento
        '
        Me.tx_Acompanhamento.Enabled = False
        Me.tx_Acompanhamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Acompanhamento.Location = New System.Drawing.Point(304, 408)
        Me.tx_Acompanhamento.Name = "tx_Acompanhamento"
        Me.tx_Acompanhamento.Size = New System.Drawing.Size(156, 31)
        Me.tx_Acompanhamento.TabIndex = 25
        Me.tx_Acompanhamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_Acompanhamento.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Acompanhamento"
        '
        'MetroButton3
        '
        Me.MetroButton3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton3.Location = New System.Drawing.Point(238, 495)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(115, 23)
        Me.MetroButton3.TabIndex = 27
        Me.MetroButton3.Text = "Reduzir 1min (F5)"
        Me.MetroButton3.UseCustomBackColor = True
        Me.MetroButton3.UseSelectable = True
        '
        'bt_Selecionar
        '
        Me.bt_Selecionar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_Selecionar.Location = New System.Drawing.Point(416, 80)
        Me.bt_Selecionar.Name = "bt_Selecionar"
        Me.bt_Selecionar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Selecionar.TabIndex = 28
        Me.bt_Selecionar.Text = "Selecionar"
        Me.bt_Selecionar.UseCustomBackColor = True
        Me.bt_Selecionar.UseSelectable = True
        '
        'tx_Modo
        '
        Me.tx_Modo.Enabled = False
        Me.tx_Modo.Location = New System.Drawing.Point(392, 54)
        Me.tx_Modo.Name = "tx_Modo"
        Me.tx_Modo.Size = New System.Drawing.Size(99, 20)
        Me.tx_Modo.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Modo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.IndianRed
        Me.Label8.Location = New System.Drawing.Point(163, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(337, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "obs.: as 7 primeiras linhas  possuem atalhos, sendo a tecla da posição"
        '
        'Frm_Configuração
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 533)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tx_Modo)
        Me.Controls.Add(Me.bt_Selecionar)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tx_Acompanhamento)
        Me.Controls.Add(Me.tx_Final)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.op_S)
        Me.Controls.Add(Me.op_C)
        Me.Controls.Add(Me.Borda)
        Me.Controls.Add(Me.tx_Título)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MetroButton6)
        Me.Controls.Add(Me.MetroButton5)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.bt_Editar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tx_Tempo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Configuração"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Configuração"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_Tempo As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bt_Editar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TítuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton

    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn

    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tx_Título As TextBox
    Friend WithEvents Borda As Label
    Friend WithEvents op_C As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents op_S As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents tx_Final As TextBox
    Friend WithEvents tx_Acompanhamento As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents bt_Selecionar As MetroFramework.Controls.MetroButton
    Friend WithEvents tx_Modo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
