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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthCalendarTmp = New System.Windows.Forms.MonthCalendar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'welcomeMSG
        '
        Me.welcomeMSG.AutoSize = True
        Me.welcomeMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.welcomeMSG.Location = New System.Drawing.Point(338, 40)
        Me.welcomeMSG.Name = "welcomeMSG"
        Me.welcomeMSG.Size = New System.Drawing.Size(129, 24)
        Me.welcomeMSG.TabIndex = 0
        Me.welcomeMSG.Text = "welcomeMSG"
        '
        'cmdRequestLeave
        '
        Me.cmdRequestLeave.Location = New System.Drawing.Point(143, 319)
        Me.cmdRequestLeave.Name = "cmdRequestLeave"
        Me.cmdRequestLeave.Size = New System.Drawing.Size(100, 58)
        Me.cmdRequestLeave.TabIndex = 1
        Me.cmdRequestLeave.Text = "Request"
        Me.cmdRequestLeave.UseVisualStyleBackColor = True
        Me.cmdRequestLeave.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(352, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 58)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(574, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 58)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenueToolStripMenuItem, Me.LeaveToolStripMenuItem, Me.RequestsToolStripMenuItem, Me.LeaveToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
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
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RequestToolStripMenuItem.Text = "Request"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'MonthCalendarTmp
        '
        Me.MonthCalendarTmp.Location = New System.Drawing.Point(290, 96)
        Me.MonthCalendarTmp.Name = "MonthCalendarTmp"
        Me.MonthCalendarTmp.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Vaccation", "Sick", "Paternity/Maternity"})
        Me.ComboBox1.Location = New System.Drawing.Point(99, 134)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'EmployeeServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MonthCalendarTmp)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdRequestLeave)
        Me.Controls.Add(Me.welcomeMSG)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "EmployeeServer"
        Me.Text = "EmployeeServer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welcomeMSG As Label
    Friend WithEvents cmdRequestLeave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthCalendarTmp As MonthCalendar
    Friend WithEvents ComboBox1 As ComboBox
End Class
