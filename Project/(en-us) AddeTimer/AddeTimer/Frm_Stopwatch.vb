Public Class Frm_Stopwatch


    Dim St As String
    Dim part As String
    Dim Time As String

    Property Minute As Integer
    Property Second As Integer


    Public Sub ToLoad()

        Try
            St = Frm_Settings.tx_Time.Text
            St = St.Replace(":", "")
            Second = CInt(St(St.Length - 2) & St(St.Length - 1))
            part = St.Remove(St.Length - 1) ''remove the last
            Minute = CInt(part.Remove(part.Length - 1)) ''remove the penultimate



            ''set minute
            If Minute = 0 Then
                Time = "00:"
            Else
                If Minute < 10 Then
                    Time = "0" & Minute & ":"
                Else
                    Time = Minute & ":"
                End If
            End If

            ''set second
            If Second = 0 Then
                Time = Time & "00"
            Else
                If Second < 10 Then
                    Time = Time & "0" & Second
                Else
                    Time = Time & Second
                End If
            End If

            ''build the watch
            tx_Watch.Text = Time
            tx_Watch.Left = (Me.Width - tx_Watch.Width) / 2
            tx_Watch.Top = (Me.Height - tx_Watch.Height) / 2


            ''turn on  after setting
            tx_Watch.Visible = True

            Timer2.Stop()

            tx_Watch.ForeColor = Color.Yellow


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub New()

        InitializeComponent()

        ToLoad()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try



            ''set minute
            If Minute = 0 Then
                Time = "00:"
            Else
                If Minute < 10 Then
                    Time = "0" & Minute & ":"
                Else
                    Time = Minute & ":"
                End If
            End If

            ''set second
            If Second = 0 Then
                Time = Time & "00"
            Else
                If Second < 10 Then
                    Time = Time & "0" & Second
                Else
                    Time = Time & Second
                End If
            End If

            ''build the watch
            tx_Watch.Text = Time
            tx_Watch.Left = (Me.Width - tx_Watch.Width) / 2
            tx_Watch.Top = (Me.Height - tx_Watch.Height) / 2





            ''end
            If Minute = 0 And Second = 0 Then
                ''makes it invisible, decreasing And centering until it Is right, then it becomes visible
                tx_Watch.Visible = False
                tx_Watch.Text = Frm_Settings.tx_FinalText.Text
                Dim size As Integer = tx_Watch.Font.Size
                While tx_Watch.Width > Me.Width
                    size = size - 1
                    tx_Watch.Font = New Font(tx_Watch.Font.Name, size)
                    tx_Watch.Left = (Me.Width - tx_Watch.Width) / 2
                    tx_Watch.Top = (Me.Height - tx_Watch.Height) / 2
                End While
                tx_Watch.Font = New Font(tx_Watch.Font.Name, size)
                tx_Watch.Left = (Me.Width - tx_Watch.Width) / 2
                tx_Watch.Top = (Me.Height - tx_Watch.Height) / 2
                tx_Watch.Visible = True

                ''stop watch
                Timer1.Stop()

                ''start the blinker
                Timer2.Start()

            Else
                If Second = 0 Then
                    Minute = Minute - 1
                    Second = 59
                Else
                    Second = Second - 1
                End If
            End If

            If Minute = 0 And Second < 10 Then
                tx_Watch.ForeColor = Color.Red
            Else
                tx_Watch.ForeColor = Color.Yellow
            End If




            Frm_Settings.tx_Acompanhamento.Text = tx_Watch.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Stop()
        End Try



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If tx_Watch.Visible = False Then
            tx_Watch.Visible = True
        Else
            tx_Watch.Visible = False
        End If

    End Sub

    Private Sub Frm_Cronometro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try

            If Frm_Settings.tx_Mode.Text = "Select" Then


                If e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then
                    Frm_Settings.DataGridView1.CurrentCell = Frm_Settings.DataGridView1.Rows(0).Cells(0)
                    Frm_Settings.tx_Title.Text = Frm_Settings.DataGridView1.Rows(0).Cells(0).Value
                    Frm_Settings.tx_Time.Text = Frm_Settings.DataGridView1.Rows(0).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
                    Frm_Settings.DataGridView1.CurrentCell = Frm_Settings.DataGridView1.Rows(1).Cells(0)
                    Frm_Settings.tx_Title.Text = Frm_Settings.DataGridView1.Rows(1).Cells(0).Value
                    Frm_Settings.tx_Time.Text = Frm_Settings.DataGridView1.Rows(1).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then
                    Frm_Settings.DataGridView1.CurrentCell = Frm_Settings.DataGridView1.Rows(2).Cells(0)
                    Frm_Settings.tx_Title.Text = Frm_Settings.DataGridView1.Rows(2).Cells(0).Value
                    Frm_Settings.tx_Time.Text = Frm_Settings.DataGridView1.Rows(2).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4 Then
                    Frm_Settings.DataGridView1.CurrentCell = Frm_Settings.DataGridView1.Rows(3).Cells(0)
                    Frm_Settings.tx_Title.Text = Frm_Settings.DataGridView1.Rows(3).Cells(0).Value
                    Frm_Settings.tx_Time.Text = Frm_Settings.DataGridView1.Rows(3).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5 Then
                    Frm_Settings.DataGridView1.CurrentCell = Frm_Settings.DataGridView1.Rows(4).Cells(0)
                    Frm_Settings.tx_Title.Text = Frm_Settings.DataGridView1.Rows(4).Cells(0).Value
                    Frm_Settings.tx_Time.Text = Frm_Settings.DataGridView1.Rows(4).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Then
                    Frm_Settings.DataGridView1.CurrentCell = Frm_Settings.DataGridView1.Rows(5).Cells(0)
                    Frm_Settings.tx_Title.Text = Frm_Settings.DataGridView1.Rows(5).Cells(0).Value
                    Frm_Settings.tx_Time.Text = Frm_Settings.DataGridView1.Rows(5).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Then
                    Frm_Settings.DataGridView1.CurrentCell = Frm_Settings.DataGridView1.Rows(6).Cells(0)
                    Frm_Settings.tx_Title.Text = Frm_Settings.DataGridView1.Rows(6).Cells(0).Value
                    Frm_Settings.tx_Time.Text = Frm_Settings.DataGridView1.Rows(6).Cells(1).Value
                End If



                If e.KeyCode = Keys.A Then
                    Frm_Settings.Open()
                End If
                If e.KeyCode = Keys.Space Then
                    Frm_Settings.Play()
                End If
                If e.KeyCode = Keys.P Then
                    Frm_Settings.Pause()
                End If
                If e.KeyCode = Keys.F4 Then
                    Frm_Settings.ChangeBorder()
                End If
                If e.KeyCode = Keys.F5 Then
                    Frm_Settings.Reduce()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class