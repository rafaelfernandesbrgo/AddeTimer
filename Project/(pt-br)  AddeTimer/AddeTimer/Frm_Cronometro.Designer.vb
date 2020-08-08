<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Cronometro
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cronometro))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tx_Relogio = New System.Windows.Forms.Label()
        Me.tx_Titulo = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'tx_Relogio
        '
        Me.tx_Relogio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tx_Relogio.AutoSize = True
        Me.tx_Relogio.Font = New System.Drawing.Font("Microsoft Sans Serif", 300.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Relogio.ForeColor = System.Drawing.Color.Yellow
        Me.tx_Relogio.Location = New System.Drawing.Point(82, 127)
        Me.tx_Relogio.Name = "tx_Relogio"
        Me.tx_Relogio.Size = New System.Drawing.Size(1189, 453)
        Me.tx_Relogio.TabIndex = 12
        Me.tx_Relogio.Text = "00:00"
        '
        'tx_Titulo
        '
        Me.tx_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tx_Titulo.AutoSize = True
        Me.tx_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.tx_Titulo.Location = New System.Drawing.Point(536, 95)
        Me.tx_Titulo.Name = "tx_Titulo"
        Me.tx_Titulo.Size = New System.Drawing.Size(279, 108)
        Me.tx_Titulo.TabIndex = 13
        Me.tx_Titulo.Text = "Título"
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Frm_Cronometro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1353, 754)
        Me.Controls.Add(Me.tx_Titulo)
        Me.Controls.Add(Me.tx_Relogio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Frm_Cronometro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cronômetro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tx_Relogio As Label
    Friend WithEvents tx_Titulo As Label
    Friend WithEvents Timer2 As Timer
End Class
