Imports System.IO
Imports System.Xml


Public Class Frm_Configuração

    Private dt As DataTable
    Private ds As DataSet

    Dim Id As Integer

    Public Sub Limpa()
        tx_Tempo.Text = ""
        tx_Título.Text = ""
    End Sub



    ''iniciar
    Private Sub Frm_Configuração_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            DataGridView1.ReadOnly = False
            DataGridView1.AllowUserToAddRows = True
            DataGridView1.AllowUserToDeleteRows = True
            tx_Modo.Text = "Editar"

            ''se nao tiver o arquivo, monta estrutura, coloca no datagridview
            ds = New DataSet()
            Try
                ds.ReadXml(Application.StartupPath & "/Tempos.xml")
                dt = ds.Tables("Clientes")
            Catch ex As FileNotFoundException
                dt = New DataTable("Clientes")
                dt.Columns.Add("Título")
                dt.Columns.Add("Tempo")
                ds.Tables.Add(dt)
            End Try
            DataGridView1.DataSource = dt

            ''limpa campos
            Limpa()


            ''formata
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            Me.Select()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''abrir
    Public Sub Abrir()

        If tx_Tempo.Text = "" Or tx_Título.Text = "" Then
            MessageBox.Show("Selecione algo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If


        If tx_Tempo.Text.Length < 4 Then
            MessageBox.Show("Preencha os dados corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            If Application.OpenForms.OfType(Of Frm_Cronometro)().Count() > 0 Then
                If op_C.Checked = True Then
                    Frm_Cronometro.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
                Else
                    Frm_Cronometro.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                End If
                Frm_Cronometro.Timer1.Stop()
                Frm_Cronometro.Carrega()
                Frm_Cronometro.tx_Titulo.Text = tx_Título.Text
                tx_Acompanhamento.Text = tx_Tempo.Text
                Frm_Cronometro.tx_Relogio.Font = New Font(Frm_Cronometro.tx_Relogio.Font.Name, 300)
                Frm_Cronometro.tx_Titulo.Left = (Frm_Cronometro.Width - Frm_Cronometro.tx_Titulo.Width) / 2
                Frm_Cronometro.tx_Relogio.Left = (Frm_Cronometro.Width - Frm_Cronometro.tx_Relogio.Width) / 2
                Frm_Cronometro.tx_Relogio.Top = (Frm_Cronometro.Height - Frm_Cronometro.tx_Relogio.Height) / 2
            Else
                If op_C.Checked = True Then
                    Frm_Cronometro.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
                Else
                    Frm_Cronometro.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                End If
                Frm_Cronometro.Show()
                Frm_Cronometro.tx_Titulo.Text = tx_Título.Text
                tx_Acompanhamento.Text = tx_Tempo.Text
                Frm_Cronometro.tx_Relogio.Font = New Font(Frm_Cronometro.tx_Relogio.Font.Name, 300)
                Frm_Cronometro.tx_Titulo.Left = (Frm_Cronometro.Width - Frm_Cronometro.tx_Titulo.Width) / 2
                Frm_Cronometro.tx_Relogio.Left = (Frm_Cronometro.Width - Frm_Cronometro.tx_Relogio.Width) / 2
                Frm_Cronometro.tx_Relogio.Top = (Frm_Cronometro.Height - Frm_Cronometro.tx_Relogio.Height) / 2
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            If tx_Modo.Text = "Selecionar" Then
                Abrir()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''play
    Public Sub Play()
        Try
            If Application.OpenForms.OfType(Of Frm_Cronometro)().Count() > 0 Then
                Frm_Cronometro.Timer1.Start()
            Else
                MessageBox.Show("Primeiro abra o cronômetro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub MetroButton5_Click_1(sender As Object, e As EventArgs) Handles MetroButton5.Click

        Try
            If tx_Modo.Text = "Selecionar" Then
                Play()
            End If
        Catch ex As Exception
        End Try


    End Sub

    ''pause
    Public Sub Pause()
        Try
            If Application.OpenForms.OfType(Of Frm_Cronometro)().Count() > 0 Then
                Frm_Cronometro.Timer1.Stop()
            Else
                MessageBox.Show("Primeiro abra o cronômetro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Try
            If tx_Modo.Text = "Selecionar" Then
                Pause()
            End If
        Catch ex As Exception
        End Try
    End Sub


    ''reduzir 1 min
    Public Sub Reduzir()

        Try
            If Frm_Cronometro.Min = 0 Then
                MessageBox.Show("Não é possível, minuto final!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Frm_Cronometro.Min = Frm_Cronometro.Min - 1

                Dim Tempo As String

                ''arruma minuto
                If Frm_Cronometro.Min = 0 Then
                    Tempo = "00:"
                Else
                    If Frm_Cronometro.Min < 10 Then
                        Tempo = "0" & Frm_Cronometro.Min & ":"
                    Else
                        Tempo = Frm_Cronometro.Min & ":"
                    End If
                End If

                ''aruma segundo
                If Frm_Cronometro.Segundo = 0 Then
                    Tempo = Tempo & "00"
                Else
                    If Frm_Cronometro.Segundo < 10 Then
                        Tempo = Tempo & "0" & Frm_Cronometro.Segundo
                    Else
                        Tempo = Tempo & Frm_Cronometro.Segundo
                    End If
                End If

                ''forma relogio
                Frm_Cronometro.tx_Relogio.Text = Tempo
                Frm_Cronometro.tx_Relogio.Left = (Frm_Cronometro.Width - Frm_Cronometro.tx_Relogio.Width) / 2
                Frm_Cronometro.tx_Relogio.Top = (Frm_Cronometro.Height - Frm_Cronometro.tx_Relogio.Height) / 2

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If tx_Modo.Text = "Selecionar" Then
                Reduzir()
            End If
        Catch ex As Exception
        End Try
    End Sub


    '' borda
    Public Sub MudarBorda()
        If op_C.Checked = True Then
            Frm_Cronometro.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Else
            Frm_Cronometro.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If tx_Modo.Text = "Selecionar" Then
                MudarBorda()
            End If
        Catch ex As Exception
        End Try
    End Sub



    ''editar, selecionar
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles bt_Editar.Click

        Try
            DataGridView1.ReadOnly = False
            DataGridView1.AllowUserToAddRows = True
            DataGridView1.AllowUserToDeleteRows = True
            tx_Modo.Text = "Editar"
            tx_Tempo.Text = ""
            tx_Título.Text = ""
            tx_Final.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles bt_Selecionar.Click

        Try

            DataGridView1.ReadOnly = True
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            tx_Modo.Text = "Selecionar"


            ''se o dt estiver vazio, não pode criar pois sem estrutura, entao apaga xml se existir, evitando erro quando lido
            ''se o dt estiver tiver algo, pega dt e cria xml
            If dt.Rows.Count <> 0 Then
                dt = DataGridView1.DataSource
                ds.WriteXml(Application.StartupPath & "/Tempos.xml")
            Else
                If System.IO.File.Exists(Application.StartupPath & "/Tempos.xml") Then
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/Tempos.xml")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    ''gridview
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

        ''se editando tempo, entao tira ponto, coloca dois ponto nas 2 ultimas
        Try
            If DataGridView1.Columns(e.ColumnIndex).Name = "Tempo" Then
                Dim St As String = DataGridView1.CurrentCell.FormattedValue
                St = St.Replace(":", "")
                St = St.Insert(St.Length - 2, ":")
                DataGridView1.CurrentCell.Value = St
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            If tx_Modo.Text = "Selecionar" Then
                tx_Título.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                tx_Tempo.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
        End Try

    End Sub

    ''atalhos
    Private Sub Frm_Configuração_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try

            If tx_Modo.Text = "Selecionar" Then


                ''atalho das linhas
                If e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
                    tx_Título.Text = DataGridView1.Rows(0).Cells(0).Value
                    tx_Tempo.Text = DataGridView1.Rows(0).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(1).Cells(0)
                    tx_Título.Text = DataGridView1.Rows(1).Cells(0).Value
                    tx_Tempo.Text = DataGridView1.Rows(1).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(2).Cells(0)
                    tx_Título.Text = DataGridView1.Rows(2).Cells(0).Value
                    tx_Tempo.Text = DataGridView1.Rows(2).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(3).Cells(0)
                    tx_Título.Text = DataGridView1.Rows(3).Cells(0).Value
                    tx_Tempo.Text = DataGridView1.Rows(3).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(4).Cells(0)
                    tx_Título.Text = DataGridView1.Rows(4).Cells(0).Value
                    tx_Tempo.Text = DataGridView1.Rows(4).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(5).Cells(0)
                    tx_Título.Text = DataGridView1.Rows(5).Cells(0).Value
                    tx_Tempo.Text = DataGridView1.Rows(5).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(6).Cells(0)
                    tx_Título.Text = DataGridView1.Rows(6).Cells(0).Value
                    tx_Tempo.Text = DataGridView1.Rows(6).Cells(1).Value
                End If


                ''butoes
                If e.KeyCode = Keys.A Then
                    Abrir()
                End If
                If e.KeyCode = Keys.Space Then
                    Play()
                End If
                If e.KeyCode = Keys.P Then
                    Pause()
                End If
                If e.KeyCode = Keys.F4 Then
                    MudarBorda()
                End If
                If e.KeyCode = Keys.F5 Then
                    Reduzir()
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub


End Class
