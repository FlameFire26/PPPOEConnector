<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
        Me.Btn_Done = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Chk_AutoReconnect = New System.Windows.Forms.CheckBox()
        Me.Tb_UserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_PPPOEName = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Done
        '
        Me.Btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Done.Location = New System.Drawing.Point(10, 10)
        Me.Btn_Done.Margin = New System.Windows.Forms.Padding(10, 10, 20, 10)
        Me.Btn_Done.Name = "Btn_Done"
        Me.Btn_Done.Size = New System.Drawing.Size(168, 38)
        Me.Btn_Done.TabIndex = 0
        Me.Btn_Done.Text = "保存"
        Me.Btn_Done.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 20, 15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "宽带名："
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Tb_Password, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Chk_AutoReconnect, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Tb_UserName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Tb_PPPOEName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(535, 247)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Tb_Password
        '
        Me.Tb_Password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tb_Password.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Tb_Password.Location = New System.Drawing.Point(143, 132)
        Me.Tb_Password.Margin = New System.Windows.Forms.Padding(10, 10, 20, 10)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Tb_Password.Size = New System.Drawing.Size(372, 39)
        Me.Tb_Password.TabIndex = 7
        Me.Tb_Password.WordWrap = False
        '
        'Chk_AutoReconnect
        '
        Me.Chk_AutoReconnect.AutoSize = True
        Me.Chk_AutoReconnect.Checked = True
        Me.Chk_AutoReconnect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_AutoReconnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Chk_AutoReconnect.Location = New System.Drawing.Point(15, 198)
        Me.Chk_AutoReconnect.Margin = New System.Windows.Forms.Padding(15)
        Me.Chk_AutoReconnect.Name = "Chk_AutoReconnect"
        Me.Chk_AutoReconnect.Size = New System.Drawing.Size(103, 29)
        Me.Chk_AutoReconnect.TabIndex = 1
        Me.Chk_AutoReconnect.Text = "自动重连"
        Me.Chk_AutoReconnect.UseVisualStyleBackColor = True
        '
        'Tb_UserName
        '
        Me.Tb_UserName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tb_UserName.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Tb_UserName.Location = New System.Drawing.Point(143, 71)
        Me.Tb_UserName.Margin = New System.Windows.Forms.Padding(10, 10, 20, 10)
        Me.Tb_UserName.Name = "Tb_UserName"
        Me.Tb_UserName.Size = New System.Drawing.Size(372, 39)
        Me.Tb_UserName.TabIndex = 6
        Me.Tb_UserName.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(20, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(20, 20, 15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "用户名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(20, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(20, 20, 15, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "密码："
        '
        'Tb_PPPOEName
        '
        Me.Tb_PPPOEName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tb_PPPOEName.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Tb_PPPOEName.Location = New System.Drawing.Point(143, 10)
        Me.Tb_PPPOEName.Margin = New System.Windows.Forms.Padding(10, 10, 20, 10)
        Me.Tb_PPPOEName.Name = "Tb_PPPOEName"
        Me.Tb_PPPOEName.Size = New System.Drawing.Size(372, 39)
        Me.Tb_PPPOEName.TabIndex = 5
        Me.Tb_PPPOEName.WordWrap = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_Cancel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_Done, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(136, 186)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(396, 58)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Cancel.Location = New System.Drawing.Point(208, 10)
        Me.Btn_Cancel.Margin = New System.Windows.Forms.Padding(10, 10, 20, 10)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(163, 38)
        Me.Btn_Cancel.TabIndex = 1
        Me.Btn_Cancel.Text = "取消"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "宽带连接器"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Done As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Password As TextBox
    Friend WithEvents Tb_UserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_PPPOEName As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Chk_AutoReconnect As CheckBox
    Friend WithEvents Btn_Cancel As Button
End Class
