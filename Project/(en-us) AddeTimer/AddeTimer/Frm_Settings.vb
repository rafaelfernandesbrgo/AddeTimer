Imports System.IO
Imports System.Xml


Public Class Frm_Settings

    Private dt As DataTable
    Private ds As DataSet

    Dim Id As Integer

    Public Sub Clear()
        tx_Time.Text = ""
        tx_Title.Text = ""
    End Sub



    Private Sub Frm_Configuração_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            DataGridView1.ReadOnly = False
            DataGridView1.AllowUserToAddRows = True
            DataGridView1.AllowUserToDeleteRows = True
            tx_Mode.Text = "Edit"

            ''if you don't have the file, set up the structure, put it in the datagridview
            ds = New DataSet()
            Try
                ds.ReadXml(Application.StartupPath & "/Time.xml")
                dt = ds.Tables("Client")
            Catch ex As FileNotFoundException
                dt = New DataTable("Client")
                dt.Columns.Add("Title")
                dt.Columns.Add("Time")
                ds.Tables.Add(dt)
            End Try
            DataGridView1.DataSource = dt

            '' clean fields
            Clear()


            ''format
            Dim column As DataGridViewColumn = DataGridView1.Columns(0)
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            Me.Select()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''open
    Public Sub Open()

        If tx_Time.Text = "" Or tx_Title.Text = "" Then
            MessageBox.Show("Select something!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If


        If tx_Time.Text.Length < 4 Then
            MessageBox.Show("Fill in the data correctly!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            If Application.OpenForms.OfType(Of Frm_Stopwatch)().Count() > 0 Then
                If op_Y.Checked = True Then
                    Frm_Stopwatch.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
                Else
                    Frm_Stopwatch.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                End If
                Frm_Stopwatch.Timer1.Stop()
                Frm_Stopwatch.ToLoad()
                Frm_Stopwatch.tx_Title.Text = tx_Title.Text
                tx_Acompanhamento.Text = tx_Time.Text
                Frm_Stopwatch.tx_Watch.Font = New Font(Frm_Stopwatch.tx_Watch.Font.Name, 300)
                Frm_Stopwatch.tx_Title.Left = (Frm_Stopwatch.Width - Frm_Stopwatch.tx_Title.Width) / 2
                Frm_Stopwatch.tx_Watch.Left = (Frm_Stopwatch.Width - Frm_Stopwatch.tx_Watch.Width) / 2
                Frm_Stopwatch.tx_Watch.Top = (Frm_Stopwatch.Height - Frm_Stopwatch.tx_Watch.Height) / 2
            Else
                If op_Y.Checked = True Then
                    Frm_Stopwatch.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
                Else
                    Frm_Stopwatch.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                End If
                Frm_Stopwatch.Show()
                Frm_Stopwatch.tx_Title.Text = tx_Title.Text
                tx_Acompanhamento.Text = tx_Time.Text
                Frm_Stopwatch.tx_Watch.Font = New Font(Frm_Stopwatch.tx_Watch.Font.Name, 300)
                Frm_Stopwatch.tx_Title.Left = (Frm_Stopwatch.Width - Frm_Stopwatch.tx_Title.Width) / 2
                Frm_Stopwatch.tx_Watch.Left = (Frm_Stopwatch.Width - Frm_Stopwatch.tx_Watch.Width) / 2
                Frm_Stopwatch.tx_Watch.Top = (Frm_Stopwatch.Height - Frm_Stopwatch.tx_Watch.Height) / 2
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            If tx_Mode.Text = "Select" Then
                Open()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''play
    Public Sub Play()
        Try
            If Application.OpenForms.OfType(Of Frm_Stopwatch)().Count() > 0 Then
                Frm_Stopwatch.Timer1.Start()
            Else
                MessageBox.Show("First open the timer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub MetroButton5_Click_1(sender As Object, e As EventArgs) Handles MetroButton5.Click

        Try
            If tx_Mode.Text = "Select" Then
                Play()
            End If
        Catch ex As Exception
        End Try


    End Sub

    ''pause
    Public Sub Pause()
        Try
            If Application.OpenForms.OfType(Of Frm_Stopwatch)().Count() > 0 Then
                Frm_Stopwatch.Timer1.Stop()
            Else
                MessageBox.Show("First open the timer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Try
            If tx_Mode.Text = "Select" Then
                Pause()
            End If
        Catch ex As Exception
        End Try
    End Sub


    ''reduzir 1 min
    Public Sub Reduce()

        Try
            If Frm_Stopwatch.Minute = 0 Then
                MessageBox.Show("Not possible, final minute!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Frm_Stopwatch.Minute = Frm_Stopwatch.Minute - 1

                Dim Time As String

                ''set minute
                If Frm_Stopwatch.Minute = 0 Then
                    Time = "00:"
                Else
                    If Frm_Stopwatch.Minute < 10 Then
                        Time = "0" & Frm_Stopwatch.Minute & ":"
                    Else
                        Time = Frm_Stopwatch.Minute & ":"
                    End If
                End If

                ''set second
                If Frm_Stopwatch.Second = 0 Then
                    Time = Time & "00"
                Else
                    If Frm_Stopwatch.Second < 10 Then
                        Time = Time & "0" & Frm_Stopwatch.Second
                    Else
                        Time = Time & Frm_Stopwatch.Second
                    End If
                End If

                ''build the watch
                Frm_Stopwatch.tx_Watch.Text = Time
                Frm_Stopwatch.tx_Watch.Left = (Frm_Stopwatch.Width - Frm_Stopwatch.tx_Watch.Width) / 2
                Frm_Stopwatch.tx_Watch.Top = (Frm_Stopwatch.Height - Frm_Stopwatch.tx_Watch.Height) / 2

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If tx_Mode.Text = "Select" Then
                Reduce()
            End If
        Catch ex As Exception
        End Try
    End Sub


    '' borda
    Public Sub ChangeBorder()
        If op_Y.Checked = True Then
            Frm_Stopwatch.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Else
            Frm_Stopwatch.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If tx_Mode.Text = "Select" Then
                ChangeBorder()
            End If
        Catch ex As Exception
        End Try
    End Sub



    ''editar, selecionar
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles bt_Edit.Click

        Try
            DataGridView1.ReadOnly = False
            DataGridView1.AllowUserToAddRows = True
            DataGridView1.AllowUserToDeleteRows = True
            tx_Mode.Text = "Edit"
            tx_Time.Text = ""
            tx_Title.Text = ""
            tx_FinalText.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles bt_Select.Click

        Try

            DataGridView1.ReadOnly = True
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            tx_Mode.Text = "Select"


            '' if the dt is empty, you cannot create it without a structure, then delete xml if it exists, avoiding error when read
            '' if the dt has something, take dt and create xml
            If dt.Rows.Count <> 0 Then
                dt = DataGridView1.DataSource
                ds.WriteXml(Application.StartupPath & "/Time.xml")
            Else
                If System.IO.File.Exists(Application.StartupPath & "/Time.xml") Then
                    My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/Time.xml")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    ''gridview
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit


        '' if editing time, then take a point, put two points in the last 2
        Try
            If DataGridView1.Columns(e.ColumnIndex).Name = "Time" Then
                Dim St As String = DataGridView1.CurrentCell.FormattedValue
                St = St.Replace(":", "")
                St = St.Insert(St.Length - 2, ":")
                DataGridView1.CurrentCell.Value = St
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            If tx_Mode.Text = "Select" Then
                tx_Title.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                tx_Time.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
        End Try

    End Sub

    ''atalhos
    Private Sub Frm_Configuração_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try

            If tx_Mode.Text = "Select" Then


                '' shortcut lines
                If e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
                    tx_Title.Text = DataGridView1.Rows(0).Cells(0).Value
                    tx_Time.Text = DataGridView1.Rows(0).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(1).Cells(0)
                    tx_Title.Text = DataGridView1.Rows(1).Cells(0).Value
                    tx_Time.Text = DataGridView1.Rows(1).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(2).Cells(0)
                    tx_Title.Text = DataGridView1.Rows(2).Cells(0).Value
                    tx_Time.Text = DataGridView1.Rows(2).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(3).Cells(0)
                    tx_Title.Text = DataGridView1.Rows(3).Cells(0).Value
                    tx_Time.Text = DataGridView1.Rows(3).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(4).Cells(0)
                    tx_Title.Text = DataGridView1.Rows(4).Cells(0).Value
                    tx_Time.Text = DataGridView1.Rows(4).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(5).Cells(0)
                    tx_Title.Text = DataGridView1.Rows(5).Cells(0).Value
                    tx_Time.Text = DataGridView1.Rows(5).Cells(1).Value
                End If
                If e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(6).Cells(0)
                    tx_Title.Text = DataGridView1.Rows(6).Cells(0).Value
                    tx_Time.Text = DataGridView1.Rows(6).Cells(1).Value
                End If


                ''buttons
                If e.KeyCode = Keys.A Then
                    Open()
                End If
                If e.KeyCode = Keys.Space Then
                    Play()
                End If
                If e.KeyCode = Keys.P Then
                    Pause()
                End If
                If e.KeyCode = Keys.F4 Then
                    ChangeBorder()
                End If
                If e.KeyCode = Keys.F5 Then
                    Reduce()
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub


End Class
