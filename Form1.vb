Imports System.Threading
Imports MaterialSkin

Public Class Form1

    Private TargetProcessHandle As Integer
    Private pfnStartAddr As Integer
    Private pszLibFileRemote As String
    Private TargetBufferSize As Integer

    Public Const PROCESS_VM_READ = &H10
    Public Const TH32CS_SNAPPROCESS = &H2
    Public Const MEM_COMMIT = 4096
    Public Const PAGE_READWRITE = 4

    Public Const PROCESS_CREATE_THREAD = (&H2)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_VM_WRITE = (&H20)
    Dim DLLFileName As String
    Public Declare Function ReadProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (
    ByVal lpLibFileName As String) As Integer

    Public Declare Function VirtualAllocEx Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpAddress As Integer,
    ByVal dwSize As Integer,
    ByVal flAllocationType As Integer,
    ByVal flProtect As Integer) As Integer

    Public Declare Function WriteProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function GetProcAddress Lib "kernel32" (
    ByVal hModule As Integer, ByVal lpProcName As String) As Integer

    Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (
    ByVal lpModuleName As String) As Integer

    Public Declare Function CreateRemoteThread Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpThreadAttributes As Integer,
    ByVal dwStackSize As Integer,
    ByVal lpStartAddress As Integer,
    ByVal lpParameter As Integer,
    ByVal dwCreationFlags As Integer,
    ByRef lpThreadId As Integer) As Integer

    Public Declare Function OpenProcess Lib "kernel32" (
    ByVal dwDesiredAccess As Integer,
    ByVal bInheritHandle As Integer,
    ByVal dwProcessId As Integer) As Integer

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As Integer

    Private Declare Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (
    ByVal hObject As Integer) As Integer

    Dim ExeName As String = IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)

    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32

    Friend Sub ReleaseMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
            End If
        Catch ex As Exception
            ' Do nothing
        End Try
    End Sub

    Public Sub TopMostCheck()
        If (MaterialCheckBox2.Checked = True) Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub

    Public Sub SecureModeCheck()
        If (MaterialCheckBox4.Checked = True) Then
            Dim pJunkcode As Single = 53219789111453L
            pJunkcode = 134111111189242L
            pJunkcode = 17321111111425L
            pJunkcode = 11117897348911L
            pJunkcode = 2304238921893748943L
            pJunkcode = 43904327510453L
            pJunkcode = 17324114348925L
            pJunkcode = 43578195346534L
            pJunkcode = 2304813748943L
            pJunkcode = 4390751823390453L
            pJunkcode = 183452543425L
            pJunkcode = 173242334876198465L
            pJunkcode = 435789513416534L
            pJunkcode = 23048371148943346L
            pJunkcode = 43904373453910453L
            pJunkcode = 13411117657189242L
            pJunkcode = 17321111434111425L
            pJunkcode = 111178454578911L
            pJunkcode = 23048921879748943L
            pJunkcode = 43943345390453L
            pJunkcode = 1732412236648925L
            pJunkcode = 435347815346534L
            pJunkcode = 230489243213748943L
            pJunkcode = 439075536790453L
            pJunkcode = 1834421347243543425L
            pJunkcode = 173254198465765L
            pJunkcode = 435789542343416534L
            pJunkcode = 2332423471148943346L
            pJunkcode = 4390435324243910453L
            pJunkcode = 1341111118924432L
            pJunkcode = 17321111434111425L
            pJunkcode = 11117894446578911L
            pJunkcode = 23048921893748943L
            pJunkcode = 43943390453L
            pJunkcode = 173241226541825L
            pJunkcode = 4357819545346534L
            pJunkcode = 230489243213748943L
            pJunkcode = 4390751395553L
            pJunkcode = 183442342432543425L
            pJunkcode = 173242319554465L
            pJunkcode = 435423413416534L
            pJunkcode = 233242347118943346L
            pJunkcode = 4390435324243910453L
        Else
            ' do nothing
        End If
    End Sub

    Public Sub SecureModeCheck2()
        If (MaterialCheckBox4.Checked = True) Then
            Dim pJunkcode As Single = 53219789111453L
            pJunkcode = 134111111189242L
            pJunkcode = 17321111111425L
            pJunkcode = 11117897448911L
            pJunkcode = 23048921893748943L
            pJunkcode = 439075134590453L
            pJunkcode = 1732414518925L
            pJunkcode = 4357819534546534L
            pJunkcode = 230489213748943L
            pJunkcode = 43907515390453L
            pJunkcode = 183451342543425L
            pJunkcode = 1732423619546458465L
            pJunkcode = 435789513416534L
            pJunkcode = 2303223748943346L
            pJunkcode = 4390437539610453L
            pJunkcode = 1341111111689242L
            pJunkcode = 17321111434111425L
            pJunkcode = 1111789324654478911L
            pJunkcode = 2304892193748943L
            pJunkcode = 439433451390453L
            pJunkcode = 1732412245518925L
            pJunkcode = 435347813955346534L
            pJunkcode = 230489243213748943L
            pJunkcode = 439075554334290453L
            pJunkcode = 183442134432543425L
            pJunkcode = 1732423541965654465L
            pJunkcode = 4357895423413416534L
            pJunkcode = 2332423471148943346L
            pJunkcode = 439043532243910453L
            pJunkcode = 134111189243232L
            pJunkcode = 173211114434111425L
            pJunkcode = 111178944546578911L
            pJunkcode = 2304892183748943L
            pJunkcode = 439433407390453L
            pJunkcode = 173241233265418925L
            pJunkcode = 43578195346346534L
            pJunkcode = 230489243213748943L
            pJunkcode = 439075139362550453L
            pJunkcode = 183442134232543425L
            pJunkcode = 17324231955458465L
            pJunkcode = 4357895427563416534L
            pJunkcode = 2332423471154443346L
            pJunkcode = 439043532424 = 3910453L
        Else
            ' do nothing
        End If
    End Sub

    Public Sub CheckForUpdates()
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/Philip-j-fry/Whitelist-Bot/master/version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                MessageBox.Show("Cryptic Injector is up to date, running v" + currentversion, "Cryptic Injector V3.1 Update!")
                response.Dispose()
            Else
                MessageBox.Show("New update found" & Environment.NewLine & "Latest: " + newestversion & Environment.NewLine & "Please go to iCryptics latest youtube video to download.", "Cryptic Injector V3.1 Update!")
                response.Dispose()
            End If
        Catch
            MessageBox.Show("Failed to fetch New updates", "Cryptic Injector V3.1 Error!")
        End Try
    End Sub

    Private Sub Inject()
        On Error GoTo 1
        Timer1.Stop()
        Dim TargetProcess As Process() = Process.GetProcessesByName(MaterialSingleLineTextField1.Text)
        SecureModeCheck()
        TargetProcessHandle = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE, False, TargetProcess(0).Id)
        pszLibFileRemote = OpenFileDialog1.FileName
        pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
        TargetBufferSize = 1 + Len(pszLibFileRemote)
        Dim Rtn As Integer
        Dim LoadLibParamAdr As Integer
        LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, MEM_COMMIT, PAGE_READWRITE)
        Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0)
        CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, 0)
        CloseHandle(TargetProcessHandle)
        SecureModeCheck2()
        ReleaseMemory()
1:      Show()
    End Sub

    Public Sub RobloxModeCheck()
        If (MaterialCheckBox7.Checked = True) Then
            MaterialSingleLineTextField1.Text = ("RobloxPlayerBeta")
        Else
            MaterialSingleLineTextField1.Text = ("")
        End If
    End Sub

    Public Sub checkifhotkeysenabled()
        If (MaterialCheckBox9.Checked = True) Then
            ReleaseMemory()
            Timer3.Start()
            Timer4.Start()
            Timer5.Start()
            Timer6.Start()
            Timer7.Start()
            Timer8.Start()
        Else
            ReleaseMemory()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
        End If
    End Sub

    Public Sub InjectCheck()
        If Process.GetProcessesByName(MaterialSingleLineTextField1.Text).Length < 1 Then
            MsgBox("Selected process you're trying to inject to isn't running", MsgBoxStyle.Critical, "Cryptic Injector V3.1 Error!")
        Else
            Dim delay = Task.Run(Async Function()
                                     Await Task.Delay(MaterialSingleLineTextField2.Text)
                                     Timer1.Stop()
                                     Call Inject()
                                     Return MessageBox.Show("Dll injected into: " + MaterialSingleLineTextField1.Text, "Cryptic Injector V3.1 Success!")
                                 End Function)
            If MaterialCheckBox5.Checked = True Then
                GoTo 1
            Else
            End If
            Dim webAddress As String = "https://www.youtube.com/icryptic?sub_confirmation=1"
            Process.Start(webAddress)
            If MaterialCheckBox1.Checked = True Then
                End
            Else
            End If
        End If
1: ' Do nothing
    End Sub

    Public Sub CheckForNewExploits()
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://icryptic.xyz/iCrypticExploitLinks.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            RichTextBox1.Text = sr.ReadToEnd()
            response.Dispose()
        Catch
            MessageBox.Show("Error fetching the newest exploits.", "Cryptic Injector V3.1 Error!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Filter = "DLL (*.dll) |*.dll"
        OpenFileDialog1.ShowDialog()
        Dim FileName As String
        FileName = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\"))
        Dim DllFileName As String = FileName.Replace("\", "")
        Me.ListBox1.Items.Add(DllFileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForUpdates()
        MaterialFlatButton1.Text = "Add Dll"
        Timer1.Interval = 50
        Timer1.Start()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IO.File.Exists(OpenFileDialog1.FileName) Then
            Dim TargetProcess As Process() = Process.GetProcessesByName(MaterialSingleLineTextField1.Text)
            If TargetProcess.Length = 0 Then
                ' Do nothing
            Else
                If MaterialCheckBox3.Checked = True Then
                    MaterialFlatButton1.Visible = True
                    MaterialCheckBox6.Checked = False
                End If
                If MaterialCheckBox6.Checked = True Then
                    'MaterialFlatButton1.Visible = False
                    Try
                        InjectCheck()
                    Catch
                        MessageBox.Show("Null injection error injecting into: " + MaterialSingleLineTextField1.Text, "Cryptic Injector V3.1 Error!")
                    End Try
                End If
            End If
        Else
        End If
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Clear()
    End Sub

    Public Sub BrowseDll()
        Try
            OpenFileDialog1.Filter = "DLL (*.dll) |*.dll"
            OpenFileDialog1.ShowDialog(Me)
            Dim FileName As String
            FileName = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\"))
            Dim DllFileName As String = FileName.Replace("\", "")
            Me.ListBox1.Items.Add(DllFileName)
        Catch
            MessageBox.Show("No Dll selected!", "Cryptic Injector V3.1 Error!")
        End Try
    End Sub

    Public Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        BrowseDll()
    End Sub

    Private Sub MaterialFlatButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        MaterialSingleLineTextField1.Clear()
    End Sub

    Private Sub MaterialCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox2.CheckedChanged
        TopMostCheck()
    End Sub

    Public Sub ManualInjectionCheck()
        If MaterialCheckBox3.Checked = True Then
            MaterialFlatButton4.Show()
        Else
            If MaterialCheckBox3.Checked = False Then
                MaterialFlatButton4.Hide()
            End If
        End If
    End Sub

    Private Sub MaterialCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox3.CheckedChanged
        ManualInjectionCheck()
    End Sub

    Private Sub MaterialFlatButton4_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        Try
            If (ListBox1.Items.Count() < 1 Or MaterialSingleLineTextField1.Text.Length < 1) Then
                MessageBox.Show("No dll(s) or process selected to inject", "Cryptic Injector V3.1 Error!")
            Else
                InjectCheck()
            End If
        Catch
            MessageBox.Show("Null injection error injecting into: " + MaterialSingleLineTextField1.Text, "Cryptic Injector V3.1 Error!")
        End Try
    End Sub

    Private Sub MaterialCheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox6.CheckedChanged
        Timer1.Enabled = True
    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        Form2.Show()
    End Sub

    Private Sub MaterialCheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox7.CheckedChanged
        RobloxModeCheck()
    End Sub

    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton16_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton15_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton8_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton12_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton11_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton14_Click(sender As Object, e As EventArgs)
        Try
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE)
        Catch
            MessageBox.Show("Error applying the theme selected!", "Cryptic Injector V3.1 Error!")
        End Try
    End Sub

    Private Sub MaterialFlatButton10_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE)
    End Sub

    Private Sub MaterialFlatButton9_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton9.Click
        Themes.Show()
    End Sub

    Private Sub MaterialFlatButton13_Click(sender As Object, e As EventArgs)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE)
    End Sub

    Private Sub MaterialCheckBox4_CheckedChanged(sender As Object, e As EventArgs)
        Me.Opacity = 0.95
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Me.Opacity = TrackBar1.Value / TrackBar1.Maximum
    End Sub

    Private Sub MaterialFlatButton5_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        Me.ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub MaterialFlatButton18_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton18.Click
        If (MaterialSingleLineTextField1.Text.Length < 1) Then
            MessageBox.Show("No proccess was selected to be able to kill it", "Cryptic Injector V3.1 Error!")
        Else
            Try
                Process.GetProcessesByName(MaterialSingleLineTextField1.Text)(0).Kill()
                MessageBox.Show(MaterialSingleLineTextField1.Text + " has been killed", "Cryptic Injector V3.1 Success!")
            Catch
                MessageBox.Show("Selected Process isnt running", "Cryptic Injector V3.1 Error!")
            End Try
        End If
    End Sub

    Private Sub MaterialFlatButton8_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton8.Click
        Try
            Process.Start("explorer.exe", "/select," + "C:\Users\" + Environment.UserName + "\AppData\Local\Roblox\Versions\")
        Catch
            MessageBox.Show("Roblox was not found on the system", "Cryptic Injector V3.1 Error!")
        End Try
    End Sub

    Private Sub MaterialFlatButton7_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click
        Dim cDialog As New ColorDialog()

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Label2.ForeColor = cDialog.Color
            Label4.ForeColor = cDialog.Color
            Label5.ForeColor = cDialog.Color
            Label9.ForeColor = cDialog.Color
            Label8.ForeColor = cDialog.Color
            Label6.ForeColor = cDialog.Color
            Label10.ForeColor = cDialog.Color
            Label15.ForeColor = cDialog.Color
            ListBox1.ForeColor = cDialog.Color
            Label7.ForeColor = cDialog.Color
            About.Label1.ForeColor = cDialog.Color
            About.Label2.ForeColor = cDialog.Color
            About.Label4.ForeColor = cDialog.Color
            About.LinkLabel1.LinkColor = cDialog.Color
        End If
    End Sub

    Private Sub MaterialFlatButton10_Click_2(sender As Object, e As EventArgs) Handles MaterialFlatButton10.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Me.NotifyIcon1.Visible = True
    End Sub

    Private Sub MaterialFlatButton13_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton13.Click
        System.Diagnostics.Process.Start("https://discord.gg/HqqAX2h")
    End Sub

    Private Sub MaterialFlatButton12_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton12.Click
        CheckForNewExploits()
    End Sub

    Private Sub RichTextBox1_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click
        TabPage4.Hide()
        TabPage5.Show()
        TabPage6.Hide()
        TabPage7.Hide()
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Show()
        TabPage7.Hide()
    End Sub

    Private Sub Label10_Click_3(sender As Object, e As EventArgs) Handles Label10.Click
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Show()
    End Sub

    Private Sub Label9_Click_2(sender As Object, e As EventArgs) Handles Label9.Click
        TabPage4.Show()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage7.Hide()
    End Sub

    Private Sub Label15_Click_1(sender As Object, e As EventArgs) Handles Label15.Click
        About.Show()
    End Sub

    Private Sub MaterialCheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox9.CheckedChanged
        MessageBox.Show("Hot keys that can be used" & Environment.NewLine & "Automatic injection = F1" & Environment.NewLine & "Manual injection = F2" & Environment.NewLine & "Browse = F3" & Environment.NewLine & "Inject = F4" & Environment.NewLine & "Disable on-inject pop-ups = F5" & Environment.NewLine & "Close = F6", "Cryptic Injector V3.1 Error!")
        checkifhotkeysenabled()
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim hotkey As Boolean
        hotkey = GetAsyncKeyState(Keys.F1)
        If hotkey = True Then
            MaterialCheckBox3.Checked = False
            MaterialCheckBox6.Checked = True
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim hotkey2 As Boolean
        hotkey2 = GetAsyncKeyState(Keys.F2)
        If hotkey2 = True Then
            MaterialCheckBox6.Checked = False
            MaterialCheckBox3.Checked = True
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim hotkey3 As Boolean
        hotkey3 = GetAsyncKeyState(Keys.F3)
        If hotkey3 = True Then
            BrowseDll()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Dim hotkey4 As Boolean
        hotkey4 = GetAsyncKeyState(Keys.F4)
        If hotkey4 = True Then
            InjectCheck()
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Dim hotkey5 As Boolean
        hotkey5 = GetAsyncKeyState(Keys.F5)
        If hotkey5 = True Then
            MaterialCheckBox5.Checked = True
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Dim hotkey6 As Boolean
        hotkey6 = GetAsyncKeyState(Keys.F6)
        If hotkey6 = True Then
            End
        End If
    End Sub

    Private Sub MaterialFlatButton11_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton11.Click
        Dim webAddress As String = "https://www.microsoft.com/en-us/download/details.aspx?id=48145"
        Process.Start(webAddress)
    End Sub
End Class
