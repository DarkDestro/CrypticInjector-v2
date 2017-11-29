Imports MaterialSkin

Public Class Themes
    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label9.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label8.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label6.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label10.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label15.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox6.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox3.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox5.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox7.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox11.BackColor = Color.FromArgb(199, 45, 45)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label9.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label8.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label6.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label10.BackColor = Color.FromArgb(199, 45, 45)
            Form1.Label15.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox6.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox3.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox5.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox7.BackColor = Color.FromArgb(199, 45, 45)
            Form1.PictureBox11.BackColor = Color.FromArgb(199, 45, 45)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(54, 51, 51)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton16_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton16.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label9.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label8.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label6.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label10.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label15.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox6.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox3.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox5.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox7.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox11.BackColor = Color.FromArgb(21, 102, 189)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label9.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label8.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label6.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label10.BackColor = Color.FromArgb(21, 102, 189)
            Form1.Label15.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox6.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox3.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox5.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox7.BackColor = Color.FromArgb(21, 102, 189)
            Form1.PictureBox11.BackColor = Color.FromArgb(21, 102, 189)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(54, 51, 51)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton15_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton15.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label9.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label8.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label6.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label10.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label15.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox6.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox3.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox5.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox7.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox11.BackColor = Color.FromArgb(103, 29, 153)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label9.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label8.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label6.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label10.BackColor = Color.FromArgb(103, 29, 153)
            Form1.Label15.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox6.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox3.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox5.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox7.BackColor = Color.FromArgb(103, 29, 153)
            Form1.PictureBox11.BackColor = Color.FromArgb(103, 29, 153)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton8_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton8.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label9.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label8.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label6.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label10.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label15.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox6.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox3.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox5.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox7.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox11.BackColor = Color.FromArgb(46, 125, 49)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label9.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label8.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label6.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label10.BackColor = Color.FromArgb(46, 125, 49)
            Form1.Label15.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox6.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox3.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox5.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox7.BackColor = Color.FromArgb(46, 125, 49)
            Form1.PictureBox11.BackColor = Color.FromArgb(46, 125, 49)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)

        End If
    End Sub

    Private Sub MaterialFlatButton12_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton12.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label9.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label8.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label6.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label10.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label15.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox6.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox3.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox5.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox7.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox11.BackColor = Color.FromArgb(0, 131, 140)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label9.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label8.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label6.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label10.BackColor = Color.FromArgb(0, 131, 140)
            Form1.Label15.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox6.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox3.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox5.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox7.BackColor = Color.FromArgb(0, 131, 140)
            Form1.PictureBox11.BackColor = Color.FromArgb(0, 131, 140)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton11_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton11.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label9.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label8.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label6.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label10.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label15.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox6.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox3.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox5.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox7.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox11.BackColor = Color.FromArgb(237, 107, 0)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label9.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label8.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label6.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label10.BackColor = Color.FromArgb(237, 107, 0)
            Form1.Label15.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox6.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox3.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox5.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox7.BackColor = Color.FromArgb(237, 107, 0)
            Form1.PictureBox11.BackColor = Color.FromArgb(237, 107, 0)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton14_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton14.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label9.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label8.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label6.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label10.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label15.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox6.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox3.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox5.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox7.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox11.BackColor = Color.FromArgb(247, 167, 37)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label9.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label8.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label6.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label10.BackColor = Color.FromArgb(247, 167, 37)
            Form1.Label15.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox6.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox3.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox5.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox7.BackColor = Color.FromArgb(247, 167, 37)
            Form1.PictureBox11.BackColor = Color.FromArgb(247, 167, 37)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton10_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton10.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label9.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label8.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label6.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label10.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label15.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox6.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox3.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox5.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox7.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox11.BackColor = Color.FromArgb(171, 22, 87)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else

            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label9.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label8.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label6.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label10.BackColor = Color.FromArgb(171, 22, 87)
            Form1.Label15.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox6.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox3.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox5.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox7.BackColor = Color.FromArgb(171, 22, 87)
            Form1.PictureBox11.BackColor = Color.FromArgb(171, 22, 87)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton9_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton9.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Lime800, Primary.Lime900, Primary.Lime500, Accent.Lime200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label9.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label8.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label6.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label10.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label15.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox6.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox3.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox5.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox7.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox11.BackColor = Color.FromArgb(156, 156, 36)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else

            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Lime800, Primary.Lime900, Primary.Lime500, Accent.Lime200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label9.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label8.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label6.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label10.BackColor = Color.FromArgb(156, 156, 36)
            Form1.Label15.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox6.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox3.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox5.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox7.BackColor = Color.FromArgb(156, 156, 36)
            Form1.PictureBox11.BackColor = Color.FromArgb(156, 156, 36)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton13_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton13.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label9.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label8.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label6.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label10.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label15.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox6.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox3.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox5.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox7.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox11.BackColor = Color.FromArgb(41, 55, 145)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label9.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label8.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label6.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label10.BackColor = Color.FromArgb(41, 55, 145)
            Form1.Label15.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox6.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox3.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox5.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox7.BackColor = Color.FromArgb(41, 55, 145)
            Form1.PictureBox11.BackColor = Color.FromArgb(41, 55, 145)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub Themes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label9.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label8.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label6.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label10.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label15.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox6.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox3.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox5.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox7.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox11.BackColor = Color.FromArgb(0, 105, 89)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label9.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label8.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label6.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label10.BackColor = Color.FromArgb(0, 105, 89)
            Form1.Label15.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox6.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox3.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox5.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox7.BackColor = Color.FromArgb(0, 105, 89)
            Form1.PictureBox11.BackColor = Color.FromArgb(0, 105, 89)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.Amber200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label9.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label8.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label6.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label10.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label15.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox6.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox3.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox5.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox7.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox11.BackColor = Color.FromArgb(255, 140, 0)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.Amber200, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label9.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label8.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label6.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label10.BackColor = Color.FromArgb(255, 140, 0)
            Form1.Label15.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox6.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox3.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox5.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox7.BackColor = Color.FromArgb(255, 140, 0)
            Form1.PictureBox11.BackColor = Color.FromArgb(255, 140, 0)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        If (Form1.MaterialCheckBox8.Checked = True) Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Cyan100, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label9.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label8.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label6.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label10.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label15.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox6.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox3.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox5.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox7.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox11.BackColor = Color.FromArgb(53, 70, 77)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(235, 231, 231)
            Form1.Label2.ForeColor = Color.Black
            Form1.Label4.ForeColor = Color.Black
            Form1.Label5.ForeColor = Color.Black
            Form1.TabPage4.BackColor = Color.White
            Form1.TabPage5.BackColor = Color.White
            Form1.TabPage6.BackColor = Color.White
            Form1.TabPage7.BackColor = Color.White
            Form1.TrackBar1.BackColor = Color.White
        Else
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Cyan100, TextShade.WHITE)
            ' Sets the left sidebar
            Form1.TextBox4.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label9.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label8.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label6.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label10.BackColor = Color.FromArgb(53, 70, 77)
            Form1.Label15.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox6.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox3.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox5.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox7.BackColor = Color.FromArgb(53, 70, 77)
            Form1.PictureBox11.BackColor = Color.FromArgb(53, 70, 77)
            ' End
            Form1.ListBox1.BackColor = Color.FromArgb(67, 65, 65)
            Form1.Label2.ForeColor = Color.White
            Form1.Label4.ForeColor = Color.White
            Form1.Label5.ForeColor = Color.White
            Form1.TabPage4.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage5.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage6.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TabPage7.BackColor = Color.FromArgb(54, 51, 51)
            Form1.TrackBar1.BackColor = Color.FromArgb(54, 51, 51)
        End If
    End Sub
End Class