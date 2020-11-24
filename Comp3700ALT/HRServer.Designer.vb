<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HRServer
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
        Me.MStripHR = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MStripHR.SuspendLayout()
        Me.PanelWelcome.SuspendLayout()
        Me.PanelLeaveRequest.SuspendLayout()
        Me.SuspendLayout()
        '
        'MStripHR
        '
        Me.MStripHR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.DataTablesToolStripMenuItem, Me.RequestsToolStripMenuItem, Me.LeaveToolStripMenuItem})
        Me.MStripHR.Location = New System.Drawing.Point(0, 0)
        Me.MStripHR.Name = "MStripHR"
        Me.MStripHR.Size = New System.Drawing.Size(600, 24)
        Me.MStripHR.TabIndex = 0
        Me.MStripHR.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'DataTablesToolStripMenuItem
        '
        Me.DataTablesToolStripMenuItem.Name = "DataTablesToolStripMenuItem"
        Me.DataTablesToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.DataTablesToolStripMenuItem.Text = "Data Tables"
        '
        'RequestsToolStripMenuItem
        '
        Me.RequestsToolStripMenuItem.Name = "RequestsToolStripMenuItem"
        Me.RequestsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RequestsToolStripMenuItem.Text = "Requests"
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestToolStripMenuItem1, Me.StatusToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        '
        'RequestToolStripMenuItem1
        '
        Me.RequestToolStripMenuItem1.Name = "RequestToolStripMenuItem1"
        Me.RequestToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.RequestToolStripMenuItem1.Text = "Request"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'PanelWelcome
        '
        Me.PanelWelcome.Controls.Add(Me.lblWelcome)
        Me.PanelWelcome.Location = New System.Drawing.Point(0, 27)
        Me.PanelWelcome.Name = "PanelWelcome"
        Me.PanelWelcome.Size = New System.Drawing.Size(600, 426)
        Me.PanelWelcome.TabIndex = 10
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(204, 188)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(188, 46)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome"
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
        Me.LeaveTypeBox.DataSource = New Comp3700ALT.LeaveRequest.TypeOfLeaveEnum() {Comp3700ALT.LeaveRequest.TypeOfLeaveEnum.Vacation, Comp3700ALT.LeaveRequest.TypeOfLeaveEnum.Sick, Comp3700ALT.LeaveRequest.TypeOfLeaveEnum.Paternal}
        Me.LeaveTypeBox.FormattingEnabled = True
        Me.LeaveTypeBox.Items.AddRange(New Object() {Comp3700ALT.LeaveRequest.TypeOfLeaveEnum.Vacation, Comp3700ALT.LeaveRequest.TypeOfLeaveEnum.Sick, Comp3700ALT.LeaveRequest.TypeOfLeaveEnum.Paternal})
        Me.LeaveTypeBox.Location = New System.Drawing.Point(187, 292)
        Me.LeaveTypeBox.Name = "LeaveTypeBox"
        Me.LeaveTypeBox.Size = New System.Drawing.Size(227, 21)
        Me.LeaveTypeBox.TabIndex = 6
        '
        'HRServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.MStripHR)
        Me.Controls.Add(Me.PanelLeaveRequest)
        Me.Controls.Add(Me.PanelWelcome)
        Me.MainMenuStrip = Me.MStripHR
        Me.Name = "HRServer"
        Me.Text = "HRServer"
        Me.MStripHR.ResumeLayout(False)
        Me.MStripHR.PerformLayout()
        Me.PanelWelcome.ResumeLayout(False)
        Me.PanelWelcome.PerformLayout()
        Me.PanelLeaveRequest.ResumeLayout(False)
        Me.PanelLeaveRequest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MStripHR As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
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
End Class
