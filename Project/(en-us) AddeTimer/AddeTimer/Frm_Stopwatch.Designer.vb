<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Stopwatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Stopwatch))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tx_Watch = New System.Windows.Forms.Label()
        Me.tx_Title = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'tx_Watch
        '
        Me.tx_Watch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tx_Watch.AutoSize = True
        Me.tx_Watch.Font = New System.Drawing.Font("Microsoft Sans Serif", 300.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Watch.ForeColor = System.Drawing.Color.Yellow
        Me.tx_Watch.Location = New System.Drawing.Point(109, 156)
        Me.tx_Watch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tx_Watch.Name = "tx_Watch"
        Me.tx_Watch.Size = New System.Drawing.Size(1488, 566)
        Me.tx_Watch.TabIndex = 12
        Me.tx_Watch.Text = "00:00"
        '
        'tx_Title
        '
        Me.tx_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tx_Title.AutoSize = True
        Me.tx_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_Title.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.tx_Title.Location = New System.Drawing.Point(715, 117)
        Me.tx_Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tx_Title.Name = "tx_Title"
        Me.tx_Title.Size = New System.Drawing.Size(284, 135)
        Me.tx_Title.TabIndex = 13
        Me.tx_Title.Text = "Title"
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Frm_Stopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1804, 928)
        Me.Controls.Add(Me.tx_Title)
        Me.Controls.Add(Me.tx_Watch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Stopwatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tx_Watch As Label
    Friend WithEvents tx_Title As Label
    Friend WithEvents Timer2 As Timer
End Class
