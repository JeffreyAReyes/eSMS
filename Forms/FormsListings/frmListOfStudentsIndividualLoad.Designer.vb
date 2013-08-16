<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListOfStudentsIndividualLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListOfStudentsIndividualLoad))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.cboSchoolYear = New System.Windows.Forms.ComboBox
        Me.KryptonHeader27 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboTerm = New System.Windows.Forms.ComboBox
        Me.KryptonHeader26 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ESID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EDPNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Student = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CourseCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EYear = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dept = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Degree = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptiveTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumOfUnits = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dvgList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
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
        Me.ToolStrip2.Size = New System.Drawing.Size(800, 25)
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
        Me.dvgList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ESID, Me.StudentID, Me.EDPNumber, Me.Student, Me.CourseCode, Me.EYear, Me.Status, Me.Gender, Me.Dept, Me.Degree, Me.SubjectCode, Me.DescriptiveTitle, Me.NumOfUnits})
        Me.dvgList.Location = New System.Drawing.Point(2, 86)
        Me.dvgList.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgList.Name = "dvgList"
        Me.dvgList.ReadOnly = True
        Me.dvgList.RowHeadersWidth = 24
        Me.dvgList.Size = New System.Drawing.Size(798, 360)
        Me.dvgList.TabIndex = 6
        '
        'cboSchoolYear
        '
        Me.cboSchoolYear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSchoolYear.FormattingEnabled = True
        Me.cboSchoolYear.Items.AddRange(New Object() {"2011-2012", "2012-2013", "2013-2014", "2014-2015", "2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020"})
        Me.cboSchoolYear.Location = New System.Drawing.Point(396, 55)
        Me.cboSchoolYear.Name = "cboSchoolYear"
        Me.cboSchoolYear.Size = New System.Drawing.Size(166, 27)
        Me.cboSchoolYear.TabIndex = 58
        '
        'KryptonHeader27
        '
        Me.KryptonHeader27.AutoSize = False
        Me.KryptonHeader27.Location = New System.Drawing.Point(286, 55)
        Me.KryptonHeader27.Name = "KryptonHeader27"
        Me.KryptonHeader27.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader27.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader27.StateNormal.Border.Rounding = 5
        Me.KryptonHeader27.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader27.TabIndex = 57
        Me.KryptonHeader27.Text = "School Year:"
        Me.KryptonHeader27.Values.Description = ""
        Me.KryptonHeader27.Values.Heading = "School Year:"
        Me.KryptonHeader27.Values.Image = Nothing
        '
        'cboTerm
        '
        Me.cboTerm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Items.AddRange(New Object() {"First Semester", "Second Semester", "Summer"})
        Me.cboTerm.Location = New System.Drawing.Point(114, 55)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(166, 27)
        Me.cboTerm.TabIndex = 56
        '
        'KryptonHeader26
        '
        Me.KryptonHeader26.AutoSize = False
        Me.KryptonHeader26.Location = New System.Drawing.Point(4, 55)
        Me.KryptonHeader26.Name = "KryptonHeader26"
        Me.KryptonHeader26.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader26.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader26.StateNormal.Border.Rounding = 5
        Me.KryptonHeader26.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader26.TabIndex = 55
        Me.KryptonHeader26.Text = "Semester:"
        Me.KryptonHeader26.Values.Description = ""
        Me.KryptonHeader26.Values.Heading = "Semester:"
        Me.KryptonHeader26.Values.Image = Nothing
        '
        'ESID
        '
        Me.ESID.HeaderText = "ESID"
        Me.ESID.Name = "ESID"
        Me.ESID.ReadOnly = True
        Me.ESID.Visible = False
        '
        'StudentID
        '
        Me.StudentID.HeaderText = "StudentID"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        Me.StudentID.Visible = False
        '
        'EDPNumber
        '
        Me.EDPNumber.HeaderText = "EDP Number"
        Me.EDPNumber.Name = "EDPNumber"
        Me.EDPNumber.ReadOnly = True
        Me.EDPNumber.Width = 110
        '
        'Student
        '
        Me.Student.HeaderText = "Student"
        Me.Student.Name = "Student"
        Me.Student.ReadOnly = True
        Me.Student.Width = 200
        '
        'CourseCode
        '
        Me.CourseCode.HeaderText = "Course"
        Me.CourseCode.Name = "CourseCode"
        Me.CourseCode.ReadOnly = True
        '
        'EYear
        '
        Me.EYear.HeaderText = "Year"
        Me.EYear.Name = "EYear"
        Me.EYear.ReadOnly = True
        Me.EYear.Width = 65
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 65
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        Me.Gender.Visible = False
        '
        'Dept
        '
        Me.Dept.HeaderText = "Dept"
        Me.Dept.Name = "Dept"
        Me.Dept.ReadOnly = True
        Me.Dept.Visible = False
        '
        'Degree
        '
        Me.Degree.HeaderText = "Degree"
        Me.Degree.Name = "Degree"
        Me.Degree.ReadOnly = True
        Me.Degree.Visible = False
        '
        'SubjectCode
        '
        Me.SubjectCode.HeaderText = "Subject Code"
        Me.SubjectCode.Name = "SubjectCode"
        Me.SubjectCode.ReadOnly = True
        '
        'DescriptiveTitle
        '
        Me.DescriptiveTitle.HeaderText = "Descriptive Title"
        Me.DescriptiveTitle.Name = "DescriptiveTitle"
        Me.DescriptiveTitle.ReadOnly = True
        Me.DescriptiveTitle.Width = 300
        '
        'NumOfUnits
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "1"
        Me.NumOfUnits.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumOfUnits.HeaderText = "Units"
        Me.NumOfUnits.Name = "NumOfUnits"
        Me.NumOfUnits.ReadOnly = True
        Me.NumOfUnits.Width = 75
        '
        'frmListOfStudentsIndividualLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(802, 471)
        Me.Controls.Add(Me.cboSchoolYear)
        Me.Controls.Add(Me.KryptonHeader27)
        Me.Controls.Add(Me.cboTerm)
        Me.Controls.Add(Me.KryptonHeader26)
        Me.Controls.Add(Me.dvgList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmListOfStudentsIndividualLoad"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student's Individual Load"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dvgList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboSchoolYear As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader27 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader26 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ESID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EDPNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Student As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Degree As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptiveTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumOfUnits As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
