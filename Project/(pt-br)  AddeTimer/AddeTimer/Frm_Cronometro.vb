Public Class Frm_Cronometro


    Dim St As String
    Property Segundo As Integer
    Dim parte As String
    Property Min As Integer

    Dim Tempo As String

    Public Sub Carrega()

        Try
            St = Frm_Configuração.tx_Tempo.Text
            St = St.Replace(":", "")
            Segundo = CInt(St(St.Length - 2) & St(St.Length - 1))
            parte = St.Remove(St.Length - 1) ''tira a ultima
            Min = CInt(parte.Remove(parte.Length - 1)) ''tira a penultima



            ''arruma minuto
            If Min = 0 Then
                Tempo = "00:"
            Else
                If Min < 10 Then
                    Tempo = "0" & Min & ":"
                Else
                    Tempo = Min & ":"
                End If
            End If

            ''aruma segundo
            If Segundo = 0 Then
                Tempo = Tempo & "00"
            Else
                If Segundo < 10 Then
                    Tempo = Tempo & "0" & Segundo
                Else
                    Tempo = Tempo & Segundo
                End If
            End If

            ''forma relogio
            tx_Relogio.Text = Tempo
            tx_Relogio.Left = (Me.Width - tx_Relogio.Width) / 2
            tx_Relogio.Top = (Me.Height - tx_Relogio.Height) / 2


            ''liga apos configurar
            tx_Relogio.Visible = True

            Timer2.Stop()

            tx_Relogio.ForeColor = Color.Yellow


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub New()

        InitializeComponent()

        Carrega()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try



            ''arruma minuto
            If Min = 0 Then
                Tempo = "00:"
            Else
                If Min < 10 Then
                    Tempo = "0" & Min & ":"
                Else
                    Tempo = Min & ":"
                End If
            End If

            ''aruma segundo
            If Segundo = 0 Then
                Tempo = Tempo & "00"
            Else
                If Segundo < 10 Then
                    Tempo = Tempo & "0" & Segundo
                Else
                    Tempo = Tempo & Segundo
                End If
            End If

            ''forma relogio
            tx_Relogio.Text = Tempo
            tx_Relogio.Left = (Me.Width - tx_Relogio.Width) / 2
            tx_Relogio.Top = (Me.Height - tx_Relogio.Height) / 2





            ''fim
            If Min = 0 And Segundo = 0 Then
                ''fica invisivel, vai diminuindo e centralizando até ficar certo, depois fica visivel
                tx_Relogio.Visible = False
                tx_Relogio.Text = Frm_Configuração.tx_Final.Text
                Dim tamanho As Integer = tx_Relogio.Font.Size
                While tx_Relogio.Width > Me.Width
                    tamanho = tamanho - 1
                    tx_Relogio.Font = New Font(tx_Relogio.Font.Name, tamanho)
                    tx_Relogio.Left = (Me.Width - tx_Relogio.Width) / 2
                    tx_Relogio.Top = (Me.Height - tx_Relogio.Height) / 2
                End While
                tx_Relogio.Font = New Font(tx_Relogio.Font.Name, tamanho)
                tx_Relogio.Left = (Me.Width - tx_Relogio.Width) / 2
                tx_Relogio.Top = (Me.Height - tx_Relogio.Height) / 2
                tx_Relogio.Visible = True

                ''para relógio
                Timer1.Stop()

                ''inicia piscador
                Timer2.Start()

            Else
                If Segundo = 0 Then
                    Min = Min - 1
                    Segundo = 59
                Else
                    Segundo = Segundo - 1
                End If
            End If

            If Min = 0 And Segundo < 10 Then
                tx_Relogio.ForeColor = Color.Red
            Else
                tx_Relogio.ForeColor = Color.Yellow
            End If




            Frm_Configuração.tx_Acompanhamento.Text = tx_Relogio.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Stop()
        End Try



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If tx_Relogio.Visible = False Then
            tx_Relogio.Visible = True
        Else
            tx_Relogio.Visible = False
        End If

    End Sub

    Private Sub Frm_Cronometro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try

            If Frm_Configuração.tx_Modo.Text = "Selecionar" Then


                If e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then
                    Frm_Configuração.DataGridView1.CurrentCell = Frm_Configuração.DataGridView1.Rows(0).Cells(0)
                    Frm_Configuração.tx_Título.Text = Frm_Configuração.DataGridView1.Rows(0).Cells(0).Value
                    Frm_Configuração.tx_Tempo.Text = Frm_Configuração.DataGridView1.Rows(0).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
                    Frm_Configuração.DataGridView1.CurrentCell = Frm_Configuração.DataGridView1.Rows(1).Cells(0)
                    Frm_Configuração.tx_Título.Text = Frm_Configuração.DataGridView1.Rows(1).Cells(0).Value
                    Frm_Configuração.tx_Tempo.Text = Frm_Configuração.DataGridView1.Rows(1).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then
                    Frm_Configuração.DataGridView1.CurrentCell = Frm_Configuração.DataGridView1.Rows(2).Cells(0)
                    Frm_Configuração.tx_Título.Text = Frm_Configuração.DataGridView1.Rows(2).Cells(0).Value
                    Frm_Configuração.tx_Tempo.Text = Frm_Configuração.DataGridView1.Rows(2).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4 Then
                    Frm_Configuração.DataGridView1.CurrentCell = Frm_Configuração.DataGridView1.Rows(3).Cells(0)
                    Frm_Configuração.tx_Título.Text = Frm_Configuração.DataGridView1.Rows(3).Cells(0).Value
                    Frm_Configuração.tx_Tempo.Text = Frm_Configuração.DataGridView1.Rows(3).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5 Then
                    Frm_Configuração.DataGridView1.CurrentCell = Frm_Configuração.DataGridView1.Rows(4).Cells(0)
                    Frm_Configuração.tx_Título.Text = Frm_Configuração.DataGridView1.Rows(4).Cells(0).Value
                    Frm_Configuração.tx_Tempo.Text = Frm_Configuração.DataGridView1.Rows(4).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Then
                    Frm_Configuração.DataGridView1.CurrentCell = Frm_Configuração.DataGridView1.Rows(5).Cells(0)
                    Frm_Configuração.tx_Título.Text = Frm_Configuração.DataGridView1.Rows(5).Cells(0).Value
                    Frm_Configuração.tx_Tempo.Text = Frm_Configuração.DataGridView1.Rows(5).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Then
                    Frm_Configuração.DataGridView1.CurrentCell = Frm_Configuração.DataGridView1.Rows(6).Cells(0)
                    Frm_Configuração.tx_Título.Text = Frm_Configuração.DataGridView1.Rows(6).Cells(0).Value
                    Frm_Configuração.tx_Tempo.Text = Frm_Configuração.DataGridView1.Rows(6).Cells(1).Value
                End If



                If e.KeyCode = Keys.A Then
                    Frm_Configuração.Abrir()
                End If
                If e.KeyCode = Keys.Space Then
                    Frm_Configuração.Play()
                End If
                If e.KeyCode = Keys.P Then
                    Frm_Configuração.Pause()
                End If
                If e.KeyCode = Keys.F4 Then
                    Frm_Configuração.MudarBorda()
                End If
                If e.KeyCode = Keys.F5 Then
                    Frm_Configuração.Reduzir()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class