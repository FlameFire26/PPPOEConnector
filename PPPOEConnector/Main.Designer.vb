<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_Byhand = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Connect = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Disconnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Setting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_AutoReconnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Menu_Startup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.MenuStrip
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "宽带连接器"
        Me.NotifyIcon.Visible = True
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Byhand, Me.Menu_Setting, Me.Menu_AutoReconnect, Me.Menu_Startup, Me.Menu_Exit})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.ShowCheckMargin = True
        Me.MenuStrip.ShowImageMargin = False
        Me.MenuStrip.ShowItemToolTips = False
        Me.MenuStrip.Size = New System.Drawing.Size(153, 154)
        '
        'Menu_Byhand
        '
        Me.Menu_Byhand.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Connect, Me.Menu_Disconnect})
        Me.Menu_Byhand.Name = "Menu_Byhand"
        Me.Menu_Byhand.Size = New System.Drawing.Size(240, 30)
        Me.Menu_Byhand.Text = "手动操作"
        '
        'Menu_Connect
        '
        Me.Menu_Connect.Name = "Menu_Connect"
        Me.Menu_Connect.Size = New System.Drawing.Size(272, 34)
        Me.Menu_Connect.Text = "连接"
        '
        'Menu_Disconnect
        '
        Me.Menu_Disconnect.Name = "Menu_Disconnect"
        Me.Menu_Disconnect.Size = New System.Drawing.Size(272, 34)
        Me.Menu_Disconnect.Text = "断开并取消自动重连"
        '
        'Menu_Setting
        '
        Me.Menu_Setting.Name = "Menu_Setting"
        Me.Menu_Setting.Size = New System.Drawing.Size(240, 30)
        Me.Menu_Setting.Text = "更多设置"
        '
        'Menu_AutoReconnect
        '
        Me.Menu_AutoReconnect.Name = "Menu_AutoReconnect"
        Me.Menu_AutoReconnect.Size = New System.Drawing.Size(240, 30)
        Me.Menu_AutoReconnect.Text = "自动重连"
        '
        'Menu_Exit
        '
        Me.Menu_Exit.Name = "Menu_Exit"
        Me.Menu_Exit.Size = New System.Drawing.Size(240, 30)
        Me.Menu_Exit.Text = "退出"
        '
        'Timer
        '
        Me.Timer.Interval = 10000
        '
        'Menu_Startup
        '
        Me.Menu_Startup.Name = "Menu_Startup"
        Me.Menu_Startup.Size = New System.Drawing.Size(240, 30)
        Me.Menu_Startup.Text = "开机启动"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 244)
        Me.ControlBox = False
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "宽带连接器"
        Me.MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents MenuStrip As ContextMenuStrip
    Friend WithEvents Menu_Setting As ToolStripMenuItem
    Friend WithEvents Menu_AutoReconnect As ToolStripMenuItem
    Friend WithEvents Menu_Exit As ToolStripMenuItem
    Friend WithEvents Menu_Byhand As ToolStripMenuItem
    Friend WithEvents Menu_Connect As ToolStripMenuItem
    Friend WithEvents Menu_Disconnect As ToolStripMenuItem
    Friend WithEvents Timer As Timer
    Friend WithEvents Menu_Startup As ToolStripMenuItem
End Class
