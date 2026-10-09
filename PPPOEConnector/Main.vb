Imports System.IO
Imports System.Management
Imports System.Net.NetworkInformation
Imports IWshRuntimeLibrary
Public Class Main

    Public Watcher As New ManagementEventWatcher
    Public m = Reflection.Assembly.GetExecutingAssembly().GetModules()(0)
    Public AppName = Path.GetFileNameWithoutExtension(m.FullyQualifiedName)
    Public StartupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
    Public FileStartup As New FileInfo($"{StartupPath}\{AppName}.lnk")

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.Manual
        Location = New Point(-3000, -3000)
        ShowInTaskbar = False
        Timer.Enabled = My.Settings.AutoReconnect
        Menu_AutoReconnect.Checked = My.Settings.AutoReconnect
        Menu_Startup.Checked = My.Settings.Startup
        If Menu_Startup.Checked Then CreateStartup()
        If My.Settings.PPPOEName = "" Or My.Settings.PPPOEName = Nothing Then Setting.Show()

        Watcher.Query.QueryString = "SELECT * FROM __InstanceCreationEvent WITHIN 1 WHERE TargetInstance ISA 'Win32_NTLogEvent' AND TargetInstance.Logfile = 'Application' AND TargetInstance.SourceName = 'RasClient' AND TargetInstance.EventCode = 20226"
        AddHandler Watcher.EventArrived, AddressOf Disconnected
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Hide()
    End Sub

    Private Sub Menu_Setting_Click(sender As Object, e As EventArgs) Handles Menu_Setting.Click
        Setting.Show()
    End Sub

    Private Sub Menu_AutoReconnect_Click(sender As Object, e As EventArgs) Handles Menu_AutoReconnect.Click
        Menu_AutoReconnect.Checked = Not Menu_AutoReconnect.Checked
        Timer.Enabled = Menu_AutoReconnect.Checked
        My.Settings.AutoReconnect = Menu_AutoReconnect.Checked
        My.Settings.Save()
        If My.Settings.AutoReconnect Then
            Dim t As New Threading.Thread(AddressOf Connect)
            t.Start()
        End If
    End Sub

    Private Sub Menu_Startup_Click(sender As Object, e As EventArgs) Handles Menu_Startup.Click
        Menu_Startup.Checked = Not Menu_Startup.Checked
        My.Settings.Startup = Menu_Startup.Checked
        If Menu_Startup.Checked Then
            CreateStartup()
        Else
            If FileStartup.Exists Then My.Computer.FileSystem.DeleteFile(FileStartup.ToString)
        End If
    End Sub

    Private Sub Menu_Exit_Click(sender As Object, e As EventArgs) Handles Menu_Exit.Click
        End
    End Sub

    Private Sub Menu_Connect_Click(sender As Object, e As EventArgs) Handles Menu_Connect.Click
        Dim t As New Threading.Thread(AddressOf Connect)
        t.Start()
    End Sub

    Private Sub Menu_Disconnect_Click(sender As Object, e As EventArgs) Handles Menu_Disconnect.Click
        Menu_AutoReconnect.Checked = False
        My.Settings.AutoReconnect = False
        My.Settings.Save()
        CMD("rasdial /disconnect")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If (Not Connected()) And My.Settings.AutoReconnect Then
            My.Computer.Audio.Play("C:\Windows\Media\Windows Notify Messaging.wav")
            Dim t As New Threading.Thread(AddressOf Connect)
            t.Start()
        End If
    End Sub

    Public Sub Connect()
        CMD($"rasdial {My.Settings.PPPOEName} {My.Settings.UserName} {My.Settings.Password}")
    End Sub

    Public Sub Disconnected()
        My.Computer.Audio.Play("C:\Windows\Media\Windows Notify Messaging.wav")
        If My.Settings.AutoReconnect Then
            Dim t As New Threading.Thread(AddressOf Connect)
            t.Start()
        End If
    End Sub

    Public Sub CMD(strCMD As String)
        Dim p As New Process
        With p.StartInfo
            .FileName = "cmd.exe"
            .Arguments = "/c " + strCMD
            .UseShellExecute = False
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        p.Start()
        Console.WriteLine(p.StandardOutput.ReadToEnd())
        p.Close()
    End Sub

    Public Function Connected() As Boolean
        Dim i As Short = 0
        For Each interfac As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
            If interfac.NetworkInterfaceType = NetworkInterfaceType.Ppp Then i += 1
        Next
        Return Not i = 0
    End Function

    Public Sub CreateStartup()
        If Not FileStartup.Exists Then
            Dim Shell = New WshShell()
            Dim Shortcut = CType(Shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" & AppName & ".lnk"), IWshShortcut)
            Shortcut.WorkingDirectory = Environment.CurrentDirectory
            Shortcut.WindowStyle = 1
            Shortcut.Description = AppName
            Shortcut.IconLocation = Application.ExecutablePath
            Shortcut.TargetPath = $"{Application.StartupPath}\{AppName}.exe"
            Shortcut.Save()
        End If
    End Sub

End Class
