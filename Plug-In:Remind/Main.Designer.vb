<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Label_WarnCap = New System.Windows.Forms.Label()
        Me.PictureBox_Exit = New System.Windows.Forms.PictureBox()
        Me.Label_SayHello = New System.Windows.Forms.Label()
        Me.Label_Time = New System.Windows.Forms.Label()
        Me.Timer_timeGetHandler = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox_Pb = New System.Windows.Forms.PictureBox()
        Me.Panel_Top.SuspendLayout()
        CType(Me.PictureBox_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel_Top.Controls.Add(Me.Label_WarnCap)
        Me.Panel_Top.Controls.Add(Me.PictureBox_Exit)
        resources.ApplyResources(Me.Panel_Top, "Panel_Top")
        Me.Panel_Top.Name = "Panel_Top"
        '
        'Label_WarnCap
        '
        resources.ApplyResources(Me.Label_WarnCap, "Label_WarnCap")
        Me.Label_WarnCap.Name = "Label_WarnCap"
        '
        'PictureBox_Exit
        '
        resources.ApplyResources(Me.PictureBox_Exit, "PictureBox_Exit")
        Me.PictureBox_Exit.Name = "PictureBox_Exit"
        Me.PictureBox_Exit.TabStop = False
        '
        'Label_SayHello
        '
        resources.ApplyResources(Me.Label_SayHello, "Label_SayHello")
        Me.Label_SayHello.Name = "Label_SayHello"
        '
        'Label_Time
        '
        resources.ApplyResources(Me.Label_Time, "Label_Time")
        Me.Label_Time.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label_Time.Name = "Label_Time"
        '
        'Timer_timeGetHandler
        '
        Me.Timer_timeGetHandler.Enabled = True
        Me.Timer_timeGetHandler.Interval = 1000
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'PictureBox_Pb
        '
        Me.PictureBox_Pb.BackColor = System.Drawing.Color.Azure
        resources.ApplyResources(Me.PictureBox_Pb, "PictureBox_Pb")
        Me.PictureBox_Pb.Name = "PictureBox_Pb"
        Me.PictureBox_Pb.TabStop = False
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.Controls.Add(Me.PictureBox_Pb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Time)
        Me.Controls.Add(Me.Label_SayHello)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Opacity = 0.833R
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        CType(Me.PictureBox_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Top As Panel
    Friend WithEvents PictureBox_Exit As PictureBox
    Friend WithEvents Label_SayHello As Label
    Friend WithEvents Label_Time As Label
    Friend WithEvents Timer_timeGetHandler As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_WarnCap As Label
    Friend WithEvents PictureBox_Pb As PictureBox
End Class
