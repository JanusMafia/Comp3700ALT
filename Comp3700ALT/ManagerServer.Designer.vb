<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerServer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeetingRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.welcomePanel = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.leaveRequestBox = New System.Windows.Forms.CheckedListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.welcomePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenToolStripMenuItem, Me.DataTabelsToolStripMenuItem, Me.RequestsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenToolStripMenuItem
        '
        Me.MenToolStripMenuItem.Name = "MenToolStripMenuItem"
        Me.MenToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenToolStripMenuItem.Text = "Menu"
        '
        'DataTabelsToolStripMenuItem
        '
        Me.DataTabelsToolStripMenuItem.Name = "DataTabelsToolStripMenuItem"
        Me.DataTabelsToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.DataTabelsToolStripMenuItem.Text = "Data Tabels"
        '
        'RequestsToolStripMenuItem
        '
        Me.RequestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountRequestsToolStripMenuItem, Me.LeaveRequestsToolStripMenuItem, Me.MeetingRequestsToolStripMenuItem})
        Me.RequestsToolStripMenuItem.Name = "RequestsToolStripMenuItem"
        Me.RequestsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RequestsToolStripMenuItem.Text = "Requests"
        '
        'AccountRequestsToolStripMenuItem
        '
        Me.AccountRequestsToolStripMenuItem.Name = "AccountRequestsToolStripMenuItem"
        Me.AccountRequestsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AccountRequestsToolStripMenuItem.Text = "Account Requests"
        '
        'LeaveRequestsToolStripMenuItem
        '
        Me.LeaveRequestsToolStripMenuItem.Name = "LeaveRequestsToolStripMenuItem"
        Me.LeaveRequestsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.LeaveRequestsToolStripMenuItem.Text = "Leave Requests"
        '
        'MeetingRequestsToolStripMenuItem
        '
        Me.MeetingRequestsToolStripMenuItem.Name = "MeetingRequestsToolStripMenuItem"
        Me.MeetingRequestsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.MeetingRequestsToolStripMenuItem.Text = "Meeting Requests"
        '
        'welcomePanel
        '
        Me.welcomePanel.Controls.Add(Me.lblWelcome)
        Me.welcomePanel.Location = New System.Drawing.Point(388, 338)
        Me.welcomePanel.Name = "welcomePanel"
        Me.welcomePanel.Size = New System.Drawing.Size(200, 100)
        Me.welcomePanel.TabIndex = 1
        Me.welcomePanel.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(40, 29)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(126, 31)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.leaveRequestBox)
        Me.Panel1.Location = New System.Drawing.Point(55, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 377)
        Me.Panel1.TabIndex = 2
        '
        'leaveRequestBox
        '
        Me.leaveRequestBox.FormattingEnabled = True
        Me.leaveRequestBox.HorizontalScrollbar = True
        Me.leaveRequestBox.Location = New System.Drawing.Point(62, 45)
        Me.leaveRequestBox.MultiColumn = True
        Me.leaveRequestBox.Name = "leaveRequestBox"
        Me.leaveRequestBox.Size = New System.Drawing.Size(316, 94)
        Me.leaveRequestBox.TabIndex = 0
        '
        'ManagerServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.welcomePanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManagerServer"
        Me.Text = "ManagerServer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.welcomePanel.ResumeLayout(False)
        Me.welcomePanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTabelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountRequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveRequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeetingRequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents welcomePanel As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents leaveRequestBox As CheckedListBox
End Class
