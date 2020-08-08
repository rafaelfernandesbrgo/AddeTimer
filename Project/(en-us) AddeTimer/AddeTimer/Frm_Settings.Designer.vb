<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_Time = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bt_Edit = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_Title = New System.Windows.Forms.TextBox()
        Me.Border = New System.Windows.Forms.Label()
        Me.op_Y = New MetroFramework.Controls.MetroRadioButton()
        Me.op_N = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tx_FinalText = New System.Windows.Forms.TextBox()
        Me.tx_Acompanhamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.bt_Select = New MetroFramework.Controls.MetroButton()
        Me.tx_Mode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 382)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title"
        '
        'tx_Time
        '
        Me.tx_Time.Enabled = False
        Me.tx_Time.Location = New System.Drawing.Point(447, 379)
        Me.tx_Time.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Time.Name = "tx_Time"
        Me.tx_Time.Size = New System.Drawing.Size(132, 22)
        Me.tx_Time.TabIndex = 2
        Me.tx_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_Time.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 382)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Time"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(51, 134)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(616, 185)
        Me.DataGridView1.TabIndex = 4
        '
        'bt_Edit
        '
        Me.bt_Edit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_Edit.Location = New System.Drawing.Point(447, 98)
        Me.bt_Edit.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Edit.Name = "bt_Edit"
        Me.bt_Edit.Size = New System.Drawing.Size(100, 28)
        Me.bt_Edit.TabIndex = 5
        Me.bt_Edit.Text = "Edit"
        Me.bt_Edit.UseCustomBackColor = True
        Me.bt_Edit.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton4.Location = New System.Drawing.Point(132, 574)
        Me.MetroButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton4.TabIndex = 8
        Me.MetroButton4.Text = "Open (A)"
        Me.MetroButton4.UseCustomBackColor = True
        Me.MetroButton4.UseSelectable = True
        '
        'MetroButton5
        '
        Me.MetroButton5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton5.Location = New System.Drawing.Point(240, 574)
        Me.MetroButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(123, 28)
        Me.MetroButton5.TabIndex = 9
        Me.MetroButton5.Text = "Play (Espaço)"
        Me.MetroButton5.UseCustomBackColor = True
        Me.MetroButton5.UseSelectable = True
        '
        'MetroButton6
        '
        Me.MetroButton6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton6.Location = New System.Drawing.Point(371, 574)
        Me.MetroButton6.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton6.TabIndex = 10
        Me.MetroButton6.Text = "Pause (P)"
        Me.MetroButton6.UseCustomBackColor = True
        Me.MetroButton6.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 343)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Selected"
        '
        'tx_Title
        '
        Me.tx_Title.Enabled = False
        Me.tx_Title.Location = New System.Drawing.Point(132, 382)
        Me.tx_Title.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Title.Name = "tx_Title"
        Me.tx_Title.Size = New System.Drawing.Size(244, 22)
        Me.tx_Title.TabIndex = 13
        '
        'Border
        '
        Me.Border.AutoSize = True
        Me.Border.Location = New System.Drawing.Point(16, 476)
        Me.Border.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Border.Name = "Border"
        Me.Border.Size = New System.Drawing.Size(64, 21)
        Me.Border.TabIndex = 16
        Me.Border.Text = "Border"
        '
        'op_Y
        '
        Me.op_Y.AutoSize = True
        Me.op_Y.Checked = True
        Me.op_Y.Location = New System.Drawing.Point(81, 502)
        Me.op_Y.Margin = New System.Windows.Forms.Padding(4)
        Me.op_Y.Name = "op_Y"
        Me.op_Y.Size = New System.Drawing.Size(43, 17)
        Me.op_Y.TabIndex = 17
        Me.op_Y.TabStop = True
        Me.op_Y.Text = "Yes"
        Me.op_Y.UseSelectable = True
        '
        'op_N
        '
        Me.op_N.AutoSize = True
        Me.op_N.Location = New System.Drawing.Point(155, 502)
        Me.op_N.Margin = New System.Windows.Forms.Padding(4)
        Me.op_N.Name = "op_N"
        Me.op_N.Size = New System.Drawing.Size(42, 17)
        Me.op_N.TabIndex = 19
        Me.op_N.Text = "No"
        Me.op_N.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton2.Location = New System.Drawing.Point(132, 609)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(177, 28)
        Me.MetroButton2.TabIndex = 20
        Me.MetroButton2.Text = "Update Border (F4)"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 417)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Final Text"
        '
        'tx_FinalText
        '
        Me.tx_FinalText.Location = New System.Drawing.Point(132, 414)
        Me.tx_FinalText.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_FinalText.Name = "tx_FinalText"
        Me.tx_FinalText.Size = New System.Drawing.Size(447, 22)
        Me.tx_FinalText.TabIndex = 24
        '
        'tx_Acompanhamento
        '
        Me.tx_Acompanhamento.Enabled = False
        Me.tx_Acompanhamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Acompanhamento.Location = New System.Drawing.Point(388, 502)
        Me.tx_Acompanhamento.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Acompanhamento.Name = "tx_Acompanhamento"
        Me.tx_Acompanhamento.Size = New System.Drawing.Size(191, 37)
        Me.tx_Acompanhamento.TabIndex = 25
        Me.tx_Acompanhamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tx_Acompanhamento.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(385, 476)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Running Time"
        '
        'MetroButton3
        '
        Me.MetroButton3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MetroButton3.Location = New System.Drawing.Point(317, 609)
        Me.MetroButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(153, 28)
        Me.MetroButton3.TabIndex = 27
        Me.MetroButton3.Text = "Reduce 1min (F5)"
        Me.MetroButton3.UseCustomBackColor = True
        Me.MetroButton3.UseSelectable = True
        '
        'bt_Select
        '
        Me.bt_Select.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bt_Select.Location = New System.Drawing.Point(555, 98)
        Me.bt_Select.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_Select.Name = "bt_Select"
        Me.bt_Select.Size = New System.Drawing.Size(100, 28)
        Me.bt_Select.TabIndex = 28
        Me.bt_Select.Text = "Select"
        Me.bt_Select.UseCustomBackColor = True
        Me.bt_Select.UseSelectable = True
        '
        'tx_Mode
        '
        Me.tx_Mode.Enabled = False
        Me.tx_Mode.Location = New System.Drawing.Point(523, 66)
        Me.tx_Mode.Margin = New System.Windows.Forms.Padding(4)
        Me.tx_Mode.Name = "tx_Mode"
        Me.tx_Mode.Size = New System.Drawing.Size(131, 22)
        Me.tx_Mode.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(469, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Mode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.IndianRed
        Me.Label8.Location = New System.Drawing.Point(321, 323)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(346, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "note: the first 7 lines have shortcuts (the position key)"
        '
        'Frm_Settings
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 656)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tx_Mode)
        Me.Controls.Add(Me.bt_Select)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tx_Acompanhamento)
        Me.Controls.Add(Me.tx_FinalText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.op_N)
        Me.Controls.Add(Me.op_Y)
        Me.Controls.Add(Me.Border)
        Me.Controls.Add(Me.tx_Title)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MetroButton6)
        Me.Controls.Add(Me.MetroButton5)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.bt_Edit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tx_Time)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Settings"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Settings"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_Time As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bt_Edit As MetroFramework.Controls.MetroButton
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
    Friend WithEvents tx_Title As TextBox
    Friend WithEvents Border As Label
    Friend WithEvents op_Y As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents op_N As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents tx_FinalText As TextBox
    Friend WithEvents tx_Acompanhamento As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents bt_Select As MetroFramework.Controls.MetroButton
    Friend WithEvents tx_Mode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
