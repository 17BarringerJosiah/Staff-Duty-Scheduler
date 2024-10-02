<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGenerateSchedule = New System.Windows.Forms.Button()
        Me.btnAddException = New System.Windows.Forms.Button()
        Me.cmbStaffMembers = New System.Windows.Forms.ComboBox()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.lblDutyMonth = New System.Windows.Forms.Label()
        Me.lblInputExceptions = New System.Windows.Forms.Label()
        Me.dtpExceptionDay = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerateSchedule
        '
        Me.btnGenerateSchedule.Location = New System.Drawing.Point(330, 219)
        Me.btnGenerateSchedule.Name = "btnGenerateSchedule"
        Me.btnGenerateSchedule.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerateSchedule.TabIndex = 1
        Me.btnGenerateSchedule.Text = "&Generate"
        Me.btnGenerateSchedule.UseVisualStyleBackColor = True
        '
        'btnAddException
        '
        Me.btnAddException.Location = New System.Drawing.Point(310, 163)
        Me.btnAddException.Name = "btnAddException"
        Me.btnAddException.Size = New System.Drawing.Size(110, 23)
        Me.btnAddException.TabIndex = 2
        Me.btnAddException.Text = "&Add Exception"
        Me.btnAddException.UseVisualStyleBackColor = True
        '
        'cmbStaffMembers
        '
        Me.cmbStaffMembers.FormattingEnabled = True
        Me.cmbStaffMembers.Location = New System.Drawing.Point(310, 110)
        Me.cmbStaffMembers.Name = "cmbStaffMembers"
        Me.cmbStaffMembers.Size = New System.Drawing.Size(121, 21)
        Me.cmbStaffMembers.TabIndex = 3
        '
        'dtpMonth
        '
        Me.dtpMonth.Location = New System.Drawing.Point(264, 25)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 5
        '
        'dgvSchedule
        '
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Location = New System.Drawing.Point(264, 248)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.Size = New System.Drawing.Size(218, 190)
        Me.dgvSchedule.TabIndex = 6
        '
        'lblDutyMonth
        '
        Me.lblDutyMonth.AutoSize = True
        Me.lblDutyMonth.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblDutyMonth.Location = New System.Drawing.Point(310, 9)
        Me.lblDutyMonth.Name = "lblDutyMonth"
        Me.lblDutyMonth.Size = New System.Drawing.Size(95, 13)
        Me.lblDutyMonth.TabIndex = 8
        Me.lblDutyMonth.Text = "Select Duty Month"
        '
        'lblInputExceptions
        '
        Me.lblInputExceptions.AutoSize = True
        Me.lblInputExceptions.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblInputExceptions.Location = New System.Drawing.Point(319, 94)
        Me.lblInputExceptions.Name = "lblInputExceptions"
        Me.lblInputExceptions.Size = New System.Drawing.Size(86, 13)
        Me.lblInputExceptions.TabIndex = 9
        Me.lblInputExceptions.Text = "Input Exceptions"
        '
        'dtpExceptionDay
        '
        Me.dtpExceptionDay.Location = New System.Drawing.Point(264, 137)
        Me.dtpExceptionDay.Name = "dtpExceptionDay"
        Me.dtpExceptionDay.Size = New System.Drawing.Size(200, 20)
        Me.dtpExceptionDay.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.StaffDutyScheduler.My.Resources.Resources.Golden_Griffen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpExceptionDay)
        Me.Controls.Add(Me.lblInputExceptions)
        Me.Controls.Add(Me.lblDutyMonth)
        Me.Controls.Add(Me.dgvSchedule)
        Me.Controls.Add(Me.dtpMonth)
        Me.Controls.Add(Me.cmbStaffMembers)
        Me.Controls.Add(Me.btnAddException)
        Me.Controls.Add(Me.btnGenerateSchedule)
        Me.Name = "Form1"
        Me.Text = "Staff Duty Scheduler"
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerateSchedule As Button
    Friend WithEvents btnAddException As Button
    Friend WithEvents cmbStaffMembers As ComboBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents lblDutyMonth As Label
    Friend WithEvents lblInputExceptions As Label
    Friend WithEvents dtpExceptionDay As DateTimePicker
End Class
