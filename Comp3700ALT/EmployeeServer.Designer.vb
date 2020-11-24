<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeServer
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
        Me.welcomeMSG = New System.Windows.Forms.Label()
        Me.cmdRequestLeave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthCalendarTmp = New System.Windows.Forms.MonthCalendar()
        Me.LeaveTypeBox = New System.Windows.Forms.ComboBox()
        Me.RequestTypeLabel = New System.Windows.Forms.Label()
        Me.RequestDatesLabel = New System.Windows.Forms.Label()
        Me.PanelLeaveRequest = New System.Windows.Forms.Panel()
        Me.PanelWelcome = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelLeaveRequest.SuspendLayout()
        Me.PanelWelcome.SuspendLayout()
        Me.PanelNotification.SuspendLayout()
        CType(Me.DGVNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'cmdRequestLeave
        '
        Me.cmdRequestLeave.Location = New System.Drawing.Point(187, 331)
        Me.cmdRequestLeave.Name = "cmdRequestLeave"
        Me.cmdRequestLeave.Size = New System.Drawing.Size(94, 42)
        Me.cmdRequestLeave.TabIndex = 1
        Me.cmdRequestLeave.Text = "Request"
        Me.cmdRequestLeave.UseVisualStyleBackColor = True
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenueToolStripMenuItem, Me.LeaveToolStripMenuItem, Me.RequestsToolStripMenuItem, Me.LeaveToolStripMenuItem1, Me.NotificationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenueToolStripMenuItem
        '
        Me.MenueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.MenueToolStripMenuItem.Name = "MenueToolStripMenuItem"
        Me.MenueToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenueToolStripMenuItem.Text = "Menu"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogoutToolStripMenuItem.Text = "Log out"
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.LeaveToolStripMenuItem.Text = "Data Tabels"
        '
        'RequestsToolStripMenuItem
        '
        Me.RequestsToolStripMenuItem.Name = "RequestsToolStripMenuItem"
        Me.RequestsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RequestsToolStripMenuItem.Text = "Requests"
        '
        'LeaveToolStripMenuItem1
        '
        Me.LeaveToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.LeaveToolStripMenuItem1.Name = "LeaveToolStripMenuItem1"
        Me.LeaveToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.LeaveToolStripMenuItem1.Text = "Leave"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RequestToolStripMenuItem.Text = "Request"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'NotificationsToolStripMenuItem
        '
        Me.NotificationsToolStripMenuItem.Name = "NotificationsToolStripMenuItem"
        Me.NotificationsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.NotificationsToolStripMenuItem.Text = "Notifications"
        '
        'MonthCalendarTmp
        '
        Me.MonthCalendarTmp.Location = New System.Drawing.Point(187, 110)
        Me.MonthCalendarTmp.Name = "MonthCalendarTmp"
        Me.MonthCalendarTmp.TabIndex = 5
        '
        'LeaveTypeBox
        '
        Me.LeaveTypeBox.FormattingEnabled = True
        Me.LeaveTypeBox.Location = New System.Drawing.Point(187, 292)
        Me.LeaveTypeBox.Name = "LeaveTypeBox"
        Me.LeaveTypeBox.Size = New System.Drawing.Size(227, 21)
        Me.LeaveTypeBox.TabIndex = 6
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
        'PanelLeaveRequest
        '
        Me.PanelLeaveRequest.Controls.Add(Me.MonthCalendarTmp)
        Me.PanelLeaveRequest.Controls.Add(Me.welcomeMSG)
        Me.PanelLeaveRequest.Controls.Add(Me.RequestDatesLabel)
        Me.PanelLeaveRequest.Controls.Add(Me.cmdRequestLeave)
        Me.PanelLeaveRequest.Controls.Add(Me.RequestTypeLabel)
        Me.PanelLeaveRequest.Controls.Add(Me.cmdCancel)
        Me.PanelLeaveRequest.Controls.Add(Me.LeaveTypeBox)
        Me.PanelLeaveRequest.Location = New System.Drawing.Point(0, 28)
        Me.PanelLeaveRequest.Name = "PanelLeaveRequest"
        Me.PanelLeaveRequest.Size = New System.Drawing.Size(600, 426)
        Me.PanelLeaveRequest.TabIndex = 10
        Me.PanelLeaveRequest.Visible = False
        '
        'PanelWelcome
        '
        Me.PanelWelcome.Controls.Add(Me.lblWelcome)
        Me.PanelWelcome.Controls.Add(Me.PictureBox1)
        Me.PanelWelcome.Location = New System.Drawing.Point(3, 25)
        Me.PanelWelcome.Name = "PanelWelcome"
        Me.PanelWelcome.Size = New System.Drawing.Size(600, 426)
        Me.PanelWelcome.TabIndex = 9
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
        'PanelNotification
        '
        Me.PanelNotification.Controls.Add(Me.DGVNotification)
        Me.PanelNotification.Controls.Add(Me.lblLeaveRequestUpdate)
        Me.PanelNotification.Controls.Add(Me.lblLeaveNotificationHeader)
        Me.PanelNotification.Controls.Add(Me.bttnNotificationCancel)
        Me.PanelNotification.Controls.Add(Me.LblNotifications)
        Me.PanelNotification.Location = New System.Drawing.Point(3, 25)
        Me.PanelNotification.Name = "PanelNotification"
        Me.PanelNotification.Size = New System.Drawing.Size(600, 426)
        Me.PanelNotification.TabIndex = 1
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Comp3700ALT.My.Resources.Resources.defaultbgimgg
        Me.PictureBox1.InitialImage = Global.Comp3700ALT.My.Resources.Resources.defaultbgimgg
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(585, 417)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'EmployeeServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelWelcome)
        Me.Controls.Add(Me.PanelNotification)
        Me.Controls.Add(Me.PanelLeaveRequest)
        Me.Name = "EmployeeServer"
        Me.Text = "EmployeeServer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelLeaveRequest.ResumeLayout(False)
        Me.PanelLeaveRequest.PerformLayout()
        Me.PanelWelcome.ResumeLayout(False)
        Me.PanelWelcome.PerformLayout()
        Me.PanelNotification.ResumeLayout(False)
        Me.PanelNotification.PerformLayout()
        CType(Me.DGVNotification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welcomeMSG As Label
    Friend WithEvents cmdRequestLeave As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthCalendarTmp As MonthCalendar
    Friend WithEvents LeaveTypeBox As ComboBox
    Friend WithEvents RequestTypeLabel As Label
    Friend WithEvents RequestDatesLabel As Label
    Friend WithEvents PanelLeaveRequest As Panel
    Friend WithEvents PanelWelcome As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelNotification As Panel
    Friend WithEvents LblNotifications As Label
    Friend WithEvents NotificationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bttnNotificationCancel As Button
    Friend WithEvents lblLeaveRequestUpdate As Label
    Friend WithEvents lblLeaveNotificationHeader As Label
    Friend WithEvents DGVNotification As DataGridView
    Friend WithEvents RequesID As DataGridViewTextBoxColumn
    Friend WithEvents TypeOfLeave As DataGridViewTextBoxColumn
    Friend WithEvents HoursRequested As DataGridViewTextBoxColumn
    Friend WithEvents ApprovalStatus As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
