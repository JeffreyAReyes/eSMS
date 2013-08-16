<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOFEnrolmentSummaryvb
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOFEnrolmentSummaryvb))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdAddNew = New System.Windows.Forms.ToolStripButton
        Me.cmdModify = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox
        Me.cmdSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRefresh = New System.Windows.Forms.ToolStripButton
        Me.dvgList = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dvgDept = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.dvgEnrolled = New System.Windows.Forms.DataGridView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.dvgGender = New System.Windows.Forms.DataGridView
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.dvgCourseYearLevel = New System.Windows.Forms.DataGridView
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.dvgDepartmentYearLevel = New System.Windows.Forms.DataGridView
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dvgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dvgDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dvgEnrolled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dvgGender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dvgCourseYearLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dvgDepartmentYearLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(1, 448)
        Me.StatusStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1058, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = " ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddNew, Me.cmdModify, Me.cmdDelete, Me.ToolStripSeparator1, Me.cmdPrint, Me.ToolStripSeparator2, Me.cmdClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1058, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.Image = CType(resources.GetObject("cmdAddNew.Image"), System.Drawing.Image)
        Me.cmdAddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(79, 22)
        Me.cmdAddNew.Text = "Add [F2]"
        Me.cmdAddNew.ToolTipText = "Add new department."
        Me.cmdAddNew.Visible = False
        '
        'cmdModify
        '
        Me.cmdModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModify.Image = CType(resources.GetObject("cmdModify.Image"), System.Drawing.Image)
        Me.cmdModify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(94, 22)
        Me.cmdModify.Text = "Modify [F3]"
        Me.cmdModify.ToolTipText = "Modify department."
        Me.cmdModify.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(94, 22)
        Me.cmdDelete.Text = "Delete [F5]"
        Me.cmdDelete.ToolTipText = "Delete record."
        Me.cmdDelete.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(80, 22)
        Me.cmdPrint.Text = "Print [F6]"
        Me.cmdPrint.ToolTipText = "Print list."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(101, 22)
        Me.cmdClose.Text = "Close [ESC]"
        Me.cmdClose.ToolTipText = "Close window"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtSearch, Me.cmdSearch, Me.ToolStripSeparator3, Me.cmdRefresh})
        Me.ToolStrip2.Location = New System.Drawing.Point(1, 26)
        Me.ToolStrip2.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(1)
        Me.ToolStrip2.Size = New System.Drawing.Size(1058, 25)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripLabel1.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 23)
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(71, 20)
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.ToolTipText = "Search list."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(101, 20)
        Me.cmdRefresh.Text = "Refresh [F8]"
        Me.cmdRefresh.ToolTipText = "Reload list."
        '
        'dvgList
        '
        Me.dvgList.AllowUserToAddRows = False
        Me.dvgList.AllowUserToDeleteRows = False
        Me.dvgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgList.Location = New System.Drawing.Point(3, 3)
        Me.dvgList.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgList.Name = "dvgList"
        Me.dvgList.ReadOnly = True
        Me.dvgList.Size = New System.Drawing.Size(1038, 354)
        Me.dvgList.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(4, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1052, 389)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dvgList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1044, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary by course"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dvgDept)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1044, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Summary by department"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dvgDept
        '
        Me.dvgDept.AllowUserToAddRows = False
        Me.dvgDept.AllowUserToDeleteRows = False
        Me.dvgDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgDept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgDept.Location = New System.Drawing.Point(3, 3)
        Me.dvgDept.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgDept.Name = "dvgDept"
        Me.dvgDept.ReadOnly = True
        Me.dvgDept.Size = New System.Drawing.Size(1038, 354)
        Me.dvgDept.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dvgEnrolled)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1044, 360)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Summary by date enrolled"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dvgEnrolled
        '
        Me.dvgEnrolled.AllowUserToAddRows = False
        Me.dvgEnrolled.AllowUserToDeleteRows = False
        Me.dvgEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgEnrolled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgEnrolled.Location = New System.Drawing.Point(3, 3)
        Me.dvgEnrolled.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgEnrolled.Name = "dvgEnrolled"
        Me.dvgEnrolled.ReadOnly = True
        Me.dvgEnrolled.Size = New System.Drawing.Size(1038, 354)
        Me.dvgEnrolled.TabIndex = 7
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dvgGender)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1044, 360)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Summary by course/gender"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dvgGender
        '
        Me.dvgGender.AllowUserToAddRows = False
        Me.dvgGender.AllowUserToDeleteRows = False
        Me.dvgGender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgGender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgGender.Location = New System.Drawing.Point(3, 3)
        Me.dvgGender.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgGender.Name = "dvgGender"
        Me.dvgGender.ReadOnly = True
        Me.dvgGender.Size = New System.Drawing.Size(1038, 354)
        Me.dvgGender.TabIndex = 7
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dvgCourseYearLevel)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1044, 360)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Summary by course/year level"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dvgCourseYearLevel
        '
        Me.dvgCourseYearLevel.AllowUserToAddRows = False
        Me.dvgCourseYearLevel.AllowUserToDeleteRows = False
        Me.dvgCourseYearLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCourseYearLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgCourseYearLevel.Location = New System.Drawing.Point(3, 3)
        Me.dvgCourseYearLevel.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgCourseYearLevel.Name = "dvgCourseYearLevel"
        Me.dvgCourseYearLevel.ReadOnly = True
        Me.dvgCourseYearLevel.Size = New System.Drawing.Size(1038, 354)
        Me.dvgCourseYearLevel.TabIndex = 7
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dvgDepartmentYearLevel)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1044, 360)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Summary by department/year level"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dvgDepartmentYearLevel
        '
        Me.dvgDepartmentYearLevel.AllowUserToAddRows = False
        Me.dvgDepartmentYearLevel.AllowUserToDeleteRows = False
        Me.dvgDepartmentYearLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgDepartmentYearLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgDepartmentYearLevel.Location = New System.Drawing.Point(3, 3)
        Me.dvgDepartmentYearLevel.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgDepartmentYearLevel.Name = "dvgDepartmentYearLevel"
        Me.dvgDepartmentYearLevel.ReadOnly = True
        Me.dvgDepartmentYearLevel.Size = New System.Drawing.Size(1038, 354)
        Me.dvgDepartmentYearLevel.TabIndex = 7
        '
        'frmListOFEnrolmentSummaryvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1060, 471)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmListOFEnrolmentSummaryvb"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enrolment Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dvgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dvgDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dvgEnrolled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dvgGender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dvgCourseYearLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dvgDepartmentYearLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAddNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdModify As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents dvgList As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dvgDept As System.Windows.Forms.DataGridView
    Friend WithEvents dvgEnrolled As System.Windows.Forms.DataGridView
    Friend WithEvents dvgGender As System.Windows.Forms.DataGridView
    Friend WithEvents dvgCourseYearLevel As System.Windows.Forms.DataGridView
    Friend WithEvents dvgDepartmentYearLevel As System.Windows.Forms.DataGridView
End Class
