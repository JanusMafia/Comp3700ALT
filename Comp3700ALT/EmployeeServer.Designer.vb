<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeServer
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
        Me.welcomeMSG = New System.Windows.Forms.Label()
        Me.cmdRequestLeave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthCalendarTmp = New System.Windows.Forms.MonthCalendar()
        Me.LeaveTypeBox = New System.Windows.Forms.ComboBox()
        Me.RequestTypeLabel = New System.Windows.Forms.Label()
        Me.RequestDatesLabel = New System.Windows.Forms.Label()
        Me.LeaveRequestPanel = New System.Windows.Forms.Panel()
        Me.lblRequestSent = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.LeaveRequestPanel.SuspendLayout()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenueToolStripMenuItem, Me.LeaveToolStripMenuItem, Me.RequestsToolStripMenuItem, Me.LeaveToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenueToolStripMenuItem
        '
        Me.MenueToolStripMenuItem.Name = "MenueToolStripMenuItem"
        Me.MenueToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.MenueToolStripMenuItem.Text = "Menue"
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
        Me.LeaveToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestToolStripMenuItem, Me.StatusToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.LeaveToolStripMenuItem1.Name = "LeaveToolStripMenuItem1"
        Me.LeaveToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.LeaveToolStripMenuItem1.Text = "Leave"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RequestToolStripMenuItem.Text = "Request"
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
        'MonthCalendarTmp
        '
        Me.MonthCalendarTmp.Location = New System.Drawing.Point(187, 110)
        Me.MonthCalendarTmp.Name = "MonthCalendarTmp"
        Me.MonthCalendarTmp.TabIndex = 5
        '
        'LeaveTypeBox
        '
        Me.LeaveTypeBox.FormattingEnabled = True
        Me.LeaveTypeBox.Items.AddRange(New Object() {"Vaccation", "Sick", "Paternity/Maternity"})
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
        'LeaveRequestPanel
        '
        Me.LeaveRequestPanel.Controls.Add(Me.MonthCalendarTmp)
        Me.LeaveRequestPanel.Controls.Add(Me.welcomeMSG)
        Me.LeaveRequestPanel.Controls.Add(Me.RequestDatesLabel)
        Me.LeaveRequestPanel.Controls.Add(Me.cmdRequestLeave)
        Me.LeaveRequestPanel.Controls.Add(Me.RequestTypeLabel)
        Me.LeaveRequestPanel.Controls.Add(Me.cmdCancel)
        Me.LeaveRequestPanel.Controls.Add(Me.LeaveTypeBox)
        Me.LeaveRequestPanel.Location = New System.Drawing.Point(0, 27)
        Me.LeaveRequestPanel.Name = "LeaveRequestPanel"
        Me.LeaveRequestPanel.Size = New System.Drawing.Size(600, 426)
        Me.LeaveRequestPanel.TabIndex = 10
        Me.LeaveRequestPanel.Visible = False
        '
        'lblRequestSent
        '
        Me.lblRequestSent.AutoSize = True
        Me.lblRequestSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblRequestSent.Location = New System.Drawing.Point(170, 202)
        Me.lblRequestSent.Name = "lblRequestSent"
        Me.lblRequestSent.Size = New System.Drawing.Size(261, 46)
        Me.lblRequestSent.TabIndex = 11
        Me.lblRequestSent.Text = "Request Sent"
        Me.lblRequestSent.Visible = False
        '
        'EmployeeServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.lblRequestSent)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LeaveRequestPanel)
        Me.Name = "EmployeeServer"
        Me.Text = "EmployeeServer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.LeaveRequestPanel.ResumeLayout(False)
        Me.LeaveRequestPanel.PerformLayout()
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
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthCalendarTmp As MonthCalendar
    Friend WithEvents LeaveTypeBox As ComboBox
    Friend WithEvents RequestTypeLabel As Label
    Friend WithEvents RequestDatesLabel As Label
    Friend WithEvents LeaveRequestPanel As Panel
    Friend WithEvents lblRequestSent As Label
End Class
