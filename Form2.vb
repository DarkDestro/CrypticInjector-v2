Public Class Form2
    Public Sub Refreshlist() 'Refresh processlist
        ListBox1.Items.Clear() 'Clear listbox1 items
        For Each Proc As Process In Process.GetProcesses 'Get list of processes
            ListBox1.Items.Add(Proc.ProcessName) 'Add process name to listbox1 item
        Next
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refreshlist() 'Refresh processlist sub
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Refreshlist()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Try 'Get rid of errors
            Form1.MaterialSingleLineTextField1.Clear()
            For Each Item As Object In ListBox1.SelectedItems
                Form1.MaterialSingleLineTextField1.Text = Item.ToString
                Me.Close()
            Next
        Catch ex As Exception 'Get rid of errors
        End Try 'Get rid of errors
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Refreshlist()
    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        If (MaterialSingleLineTextField1.Text.Length < 1) Then
            MessageBox.Show("Did not provide a query to search for", "Cryptic Injector V2 Error!")
        Else
        End If
        Dim count As Integer = (ListBox1.Items.Count - 1)
        Dim search As String
        For a = 0 To count
            search = ListBox1.Items.Item(a)
            If InStr(search.ToLower, MaterialSingleLineTextField1.Text.ToLower) Then
                ListBox1.SelectedItem = search
            End If
        Next
    End Sub
End Class