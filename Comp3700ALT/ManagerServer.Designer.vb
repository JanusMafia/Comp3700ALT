<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagerServer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeetingRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelWelcome = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PanelLeaveRequest = New System.Windows.Forms.Panel()
        Me.MonthCalendarTmp = New System.Windows.Forms.MonthCalendar()
        Me.welcomeMSG = New System.Windows.Forms.Label()
        Me.RequestDatesLabel = New System.Windows.Forms.Label()
        Me.cmdRequestLeave = New System.Windows.Forms.Button()
        Me.RequestTypeLabel = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.LeaveTypeBox = New System.Windows.Forms.ComboBox()
        Me.PanelNotification = New System.Windows.Forms.Panel()
        Me.DGVNotification = New System.Windows.Forms.DataGridView()
        Me.RequesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfLeave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursRequested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApprovalStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLeaveRequestUpdate = New System.Windows.Forms.Label()
        Me.lblLeaveNotificationHeader = New System.Windows.Forms.Label()
        Me.bttnNotificationCancel = New System.Windows.Forms.Button()
        Me.LblNotifications = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelWelcome.SuspendLayout()
        Me.PanelLeaveRequest.SuspendLayout()
        Me.PanelNotification.SuspendLayout()
        CType(Me.DGVNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenToolStripMenuItem, Me.DataTabelsToolStripMenuItem, Me.RequestsToolStripMenuItem, Me.LeaveToolStripMenuItem, Me.NotificationsToolStripMenuItem, Me.ReportToolStripMenuItem})
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
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestToolStripMenuItem})
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RequestToolStripMenuItem.Text = "Request"
        '
        'NotificationsToolStripMenuItem
        '
        Me.NotificationsToolStripMenuItem.Name = "NotificationsToolStripMenuItem"
        Me.NotificationsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.NotificationsToolStripMenuItem.Text = "Notifications"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'PanelWelcome
        '
        Me.PanelWelcome.Controls.Add(Me.lblWelcome)
        Me.PanelWelcome.Location = New System.Drawing.Point(3, 24)
        Me.PanelWelcome.Name = "PanelWelcome"
        Me.PanelWelcome.Size = New System.Drawing.Size(600, 426)
        Me.PanelWelcome.TabIndex = 10
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(75, 179)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(351, 46)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to work, "
        '
        'PanelLeaveRequest
        '
        Me.PanelLeaveRequest.Controls.Add(Me.MonthCalendarTmp)
        Me.PanelLeaveRequest.Controls.Add(Me.welcomeMSG)
        Me.PanelLeaveRequest.Controls.Add(Me.RequestDatesLabel)
        Me.PanelLeaveRequest.Controls.Add(Me.cmdRequestLeave)
        Me.PanelLeaveRequest.Controls.Add(Me.RequestTypeLabel)
        Me.PanelLeaveRequest.Controls.Add(Me.cmdCancel)
        Me.PanelLeaveRequest.Controls.Add(Me.LeaveTypeBox)
        Me.PanelLeaveRequest.Location = New System.Drawing.Point(0, 24)
        Me.PanelLeaveRequest.Name = "PanelLeaveRequest"
        Me.PanelLeaveRequest.Size = New System.Drawing.Size(600, 426)
        Me.PanelLeaveRequest.TabIndex = 11
        Me.PanelLeaveRequest.Visible = False
        '
        'MonthCalendarTmp
        '
        Me.MonthCalendarTmp.Location = New System.Drawing.Point(187, 110)
        Me.MonthCalendarTmp.Name = "MonthCalendarTmp"
        Me.MonthCalendarTmp.TabIndex = 5
        '
        'welcomeMSG
        '
        Me.welcomeMSG.AutoSize = True
        Me.welcomeMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.welcomeMSG.Location = New System.Drawing.Point(236, 49)
        Me.welcomeMSG.Name = "welcomeMSG"
        Me.welcomeMSG.Size = New System.Drawing.Size(129, 24)
        Me.welcomeMSG.TabIndex = 0
        Me.welcomeMSG.Text = "welcomeMSG"
        '
        'RequestDatesLabel
        '
        Me.RequestDatesLabel.AutoSize = True
        Me.RequestDatesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RequestDatesLabel.Location = New System.Drawing.Point(83, 110)
        Me.RequestDatesLabel.Name = "RequestDatesLabel"
        Me.RequestDatesLabel.Size = New System.Drawing.Size(92, 17)
        Me.RequestDatesLabel.TabIndex = 8
        Me.RequestDatesLabel.Text = "Select Dates:"
        '
        'cmdRequestLeave
        '
        Me.cmdRequestLeave.Location = New System.Drawing.Point(187, 331)
        Me.cmdRequestLeave.Name = "cmdRequestLeave"
        Me.cmdRequestLeave.Size = New System.Drawing.Size(94, 42)
        Me.cmdRequestLeave.TabIndex = 1
        Me.cmdRequestLeave.Text = "Request"
        Me.cmdRequestLeave.UseVisualStyleBackColor = True
        '
        'RequestTypeLabel
        '
        Me.RequestTypeLabel.AutoSize = True
        Me.RequestTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RequestTypeLabel.Location = New System.Drawing.Point(45, 292)
        Me.RequestTypeLabel.Name = "RequestTypeLabel"
        Me.RequestTypeLabel.Size = New System.Drawing.Size(130, 17)
        Me.RequestTypeLabel.TabIndex = 7
        Me.RequestTypeLabel.Text = "Select Leave Type:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(320, 331)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(94, 42)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'LeaveTypeBox
        '
        Me.LeaveTypeBox.FormattingEnabled = True
        Me.LeaveTypeBox.Location = New System.Drawing.Point(187, 292)
        Me.LeaveTypeBox.Name = "LeaveTypeBox"
        Me.LeaveTypeBox.Size = New System.Drawing.Size(227, 21)
        Me.LeaveTypeBox.TabIndex = 6
        '
        'PanelNotification
        '
        Me.PanelNotification.Controls.Add(Me.DGVNotification)
        Me.PanelNotification.Controls.Add(Me.lblLeaveRequestUpdate)
        Me.PanelNotification.Controls.Add(Me.lblLeaveNotificationHeader)
        Me.PanelNotification.Controls.Add(Me.bttnNotificationCancel)
        Me.PanelNotification.Controls.Add(Me.LblNotifications)
        Me.PanelNotification.Location = New System.Drawing.Point(0, 24)
        Me.PanelNotification.Name = "PanelNotification"
        Me.PanelNotification.Size = New System.Drawing.Size(600, 426)
        Me.PanelNotification.TabIndex = 2
        Me.PanelNotification.Visible = False
        '
        'DGVNotification
        '
        Me.DGVNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNotification.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RequesID, Me.TypeOfLeave, Me.HoursRequested, Me.ApprovalStatus})
        Me.DGVNotification.Location = New System.Drawing.Point(14, 113)
        Me.DGVNotification.Name = "DGVNotification"
        Me.DGVNotification.Size = New System.Drawing.Size(556, 227)
        Me.DGVNotification.TabIndex = 4
        Me.DGVNotification.Visible = False
        '
        'RequesID
        '
        Me.RequesID.HeaderText = "RequestID"
        Me.RequesID.Name = "RequesID"
        Me.RequesID.ReadOnly = True
        '
        'TypeOfLeave
        '
        Me.TypeOfLeave.HeaderText = "Type Of Leave"
        Me.TypeOfLeave.Name = "TypeOfLeave"
        Me.TypeOfLeave.ReadOnly = True
        '
        'HoursRequested
        '
        Me.HoursRequested.HeaderText = "HrRequested"
        Me.HoursRequested.Name = "HoursRequested"
        Me.HoursRequested.ReadOnly = True
        '
        'ApprovalStatus
        '
        Me.ApprovalStatus.HeaderText = "Approval Status"
        Me.ApprovalStatus.Name = "ApprovalStatus"
        Me.ApprovalStatus.ReadOnly = True
        '
        'lblLeaveRequestUpdate
        '
        Me.lblLeaveRequestUpdate.AutoSize = True
        Me.lblLeaveRequestUpdate.Location = New System.Drawing.Point(60, 113)
        Me.lblLeaveRequestUpdate.Name = "lblLeaveRequestUpdate"
        Me.lblLeaveRequestUpdate.Size = New System.Drawing.Size(102, 13)
        Me.lblLeaveRequestUpdate.TabIndex = 3
        Me.lblLeaveRequestUpdate.Text = "No Active Requests"
        '
        'lblLeaveNotificationHeader
        '
        Me.lblLeaveNotificationHeader.AutoSize = True
        Me.lblLeaveNotificationHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblLeaveNotificationHeader.Location = New System.Drawing.Point(41, 73)
        Me.lblLeaveNotificationHeader.Name = "lblLeaveNotificationHeader"
        Me.lblLeaveNotificationHeader.Size = New System.Drawing.Size(121, 20)
        Me.lblLeaveNotificationHeader.TabIndex = 2
        Me.lblLeaveNotificationHeader.Text = "Leave Request:"
        '
        'bttnNotificationCancel
        '
        Me.bttnNotificationCancel.Location = New System.Drawing.Point(479, 358)
        Me.bttnNotificationCancel.Name = "bttnNotificationCancel"
        Me.bttnNotificationCancel.Size = New System.Drawing.Size(106, 55)
        Me.bttnNotificationCancel.TabIndex = 1
        Me.bttnNotificationCancel.Text = "Cancel"
        Me.bttnNotificationCancel.UseVisualStyleBackColor = True
        '
        'LblNotifications
        '
        Me.LblNotifications.AutoSize = True
        Me.LblNotifications.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LblNotifications.Location = New System.Drawing.Point(9, 34)
        Me.LblNotifications.Name = "LblNotifications"
        Me.LblNotifications.Size = New System.Drawing.Size(193, 25)
        Me.LblNotifications.TabIndex = 0
        Me.LblNotifications.Text = "Current Notifications:"
        '
        'ManagerServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelLeaveRequest)
        Me.Controls.Add(Me.PanelNotification)
        Me.Controls.Add(Me.PanelWelcome)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManagerServer"
        Me.Text = "ManagerServer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelWelcome.ResumeLayout(False)
        Me.PanelWelcome.PerformLayout()
        Me.PanelLeaveRequest.ResumeLayout(False)
        Me.PanelLeaveRequest.PerformLayout()
        Me.PanelNotification.ResumeLayout(False)
        Me.PanelNotification.PerformLayout()
        CType(Me.DGVNotification, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelWelcome As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PanelLeaveRequest As Panel
    Friend WithEvents MonthCalendarTmp As MonthCalendar
    Friend WithEvents welcomeMSG As Label
    Friend WithEvents RequestDatesLabel As Label
    Friend WithEvents cmdRequestLeave As Button
    Friend WithEvents RequestTypeLabel As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents LeaveTypeBox As ComboBox
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelNotification As Panel
    Friend WithEvents DGVNotification As DataGridView
    Friend WithEvents RequesID As DataGridViewTextBoxColumn
    Friend WithEvents TypeOfLeave As DataGridViewTextBoxColumn
    Friend WithEvents HoursRequested As DataGridViewTextBoxColumn
    Friend WithEvents ApprovalStatus As DataGridViewTextBoxColumn
    Friend WithEvents lblLeaveRequestUpdate As Label
    Friend WithEvents lblLeaveNotificationHeader As Label
    Friend WithEvents bttnNotificationCancel As Button
    Friend WithEvents LblNotifications As Label
    Friend WithEvents NotificationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
