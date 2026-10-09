Imports System.Text.Encoding
Public Class Setting
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (hwnd As IntPtr, wMsg As Integer, wParam As IntPtr, lParam As Byte()) As Integer
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chk_AutoReconnect.Checked = My.Settings.AutoReconnect
        Main.Menu_AutoReconnect.Checked = My.Settings.AutoReconnect
        Tb_PPPOEName.Text = My.Settings.PPPOEName
        Tb_UserName.Text = My.Settings.UserName
        Tb_Password.Text = My.Settings.Password
        Tb_PPPOEName_TextChanged(sender, e)
        SendMessage(Tb_PPPOEName.Handle, &H1501, IntPtr.Zero, Unicode.GetBytes("必填"))
        SendMessage(Tb_UserName.Handle, &H1501, IntPtr.Zero, Unicode.GetBytes("留空使用保存的设置"))
        SendMessage(Tb_Password.Handle, &H1501, IntPtr.Zero, Unicode.GetBytes("留空使用保存的设置"))
        Chk_AutoReconnect.Select()
    End Sub

    Private Sub Btn_Done_Click(sender As Object, e As EventArgs) Handles Btn_Done.Click
        Save()
        If My.Settings.AutoReconnect Then Main.CMD($"rasdial {My.Settings.PPPOEName} {My.Settings.UserName} {My.Settings.Password}")
        Close()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Close()
    End Sub

    Private Sub Tb_PPPOEName_TextChanged(sender As Object, e As EventArgs) Handles Tb_PPPOEName.TextChanged
        Btn_Done.Enabled = Not Tb_PPPOEName.Text = ""
        Main.Menu_AutoReconnect.Enabled = Not Tb_PPPOEName.Text = ""
        Main.Menu_Connect.Enabled = Not Tb_PPPOEName.Text = ""
    End Sub

    Public Sub Save()
        Main.Menu_AutoReconnect.Checked = Chk_AutoReconnect.Checked
        Main.Timer.Enabled = Chk_AutoReconnect.Checked
        My.Settings.AutoReconnect = Chk_AutoReconnect.Checked
        My.Settings.PPPOEName = Tb_PPPOEName.Text
        My.Settings.UserName = Tb_UserName.Text
        My.Settings.Password = Tb_Password.Text
        My.Settings.Save()
    End Sub
End Class