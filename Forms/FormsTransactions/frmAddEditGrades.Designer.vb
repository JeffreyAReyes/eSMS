<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditGrades
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditGrades))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.cboInsturctor = New System.Windows.Forms.ComboBox
        Me.KryptonHeader4 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dvgLoads = New System.Windows.Forms.DataGridView
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dvgStudents = New System.Windows.Forms.DataGridView
        Me.SOID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudentName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CourseCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EnrolYear = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FinalGrade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PointGrade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradingRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cboTerm = New System.Windows.Forms.ComboBox
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboSY = New System.Windows.Forms.ComboBox
        Me.KryptonHeader5 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCheckGrades = New DevExpress.XtraEditors.SimpleButton
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dvgLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 653)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1154, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = " ToolStripStatusLabel1"
        '
        'cboInsturctor
        '
        Me.cboInsturctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInsturctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboInsturctor.FormattingEnabled = True
        Me.cboInsturctor.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboInsturctor.Location = New System.Drawing.Point(723, 25)
        Me.cboInsturctor.Name = "cboInsturctor"
        Me.cboInsturctor.Size = New System.Drawing.Size(328, 24)
        Me.cboInsturctor.TabIndex = 12
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.AutoSize = False
        Me.KryptonHeader4.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader4.Location = New System.Drawing.Point(635, 25)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(186, 24)
        Me.KryptonHeader4.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader4.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader4.TabIndex = 11
        Me.KryptonHeader4.Text = "Instructor:"
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "Instructor:"
        Me.KryptonHeader4.Values.Image = Nothing
        '
        'dvgLoads
        '
        Me.dvgLoads.AllowUserToAddRows = False
        Me.dvgLoads.AllowUserToDeleteRows = False
        Me.dvgLoads.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dvgLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgLoads.Location = New System.Drawing.Point(12, 95)
        Me.dvgLoads.Name = "dvgLoads"
        Me.dvgLoads.ReadOnly = True
        Me.dvgLoads.Size = New System.Drawing.Size(416, 480)
        Me.dvgLoads.TabIndex = 13
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AutoSize = False
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(12, 65)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(416, 24)
        Me.KryptonHeader1.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader1.TabIndex = 14
        Me.KryptonHeader1.Text = "Loads:"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Loads:"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.AutoSize = False
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(434, 65)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(708, 24)
        Me.KryptonHeader2.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader2.TabIndex = 16
        Me.KryptonHeader2.Text = "Students:"
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "Students:"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'dvgStudents
        '
        Me.dvgStudents.AllowUserToAddRows = False
        Me.dvgStudents.AllowUserToDeleteRows = False
        Me.dvgStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dvgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SOID, Me.ESSID, Me.StudentID, Me.StudentName, Me.CourseCode, Me.EnrolYear, Me.FinalGrade, Me.PointGrade, Me.GradingRemarks})
        Me.dvgStudents.Location = New System.Drawing.Point(434, 95)
        Me.dvgStudents.Name = "dvgStudents"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgStudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dvgStudents.Size = New System.Drawing.Size(708, 480)
        Me.dvgStudents.TabIndex = 15
        '
        'SOID
        '
        Me.SOID.HeaderText = "SOID"
        Me.SOID.Name = "SOID"
        Me.SOID.ReadOnly = True
        Me.SOID.Visible = False
        '
        'ESSID
        '
        Me.ESSID.HeaderText = "ESSID"
        Me.ESSID.Name = "ESSID"
        Me.ESSID.ReadOnly = True
        Me.ESSID.Visible = False
        '
        'StudentID
        '
        Me.StudentID.HeaderText = "StudentID"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        Me.StudentID.Visible = False
        '
        'StudentName
        '
        Me.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StudentName.HeaderText = "Student Name"
        Me.StudentName.Name = "StudentName"
        Me.StudentName.ReadOnly = True
        '
        'CourseCode
        '
        Me.CourseCode.HeaderText = "Course"
        Me.CourseCode.Name = "CourseCode"
        Me.CourseCode.ReadOnly = True
        Me.CourseCode.Width = 65
        '
        'EnrolYear
        '
        Me.EnrolYear.HeaderText = "Year"
        Me.EnrolYear.Name = "EnrolYear"
        Me.EnrolYear.ReadOnly = True
        Me.EnrolYear.Width = 55
        '
        'FinalGrade
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.FinalGrade.DefaultCellStyle = DataGridViewCellStyle6
        Me.FinalGrade.HeaderText = "Final Grade"
        Me.FinalGrade.Name = "FinalGrade"
        Me.FinalGrade.Width = 75
        '
        'PointGrade
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.PointGrade.DefaultCellStyle = DataGridViewCellStyle7
        Me.PointGrade.HeaderText = "Point Grade"
        Me.PointGrade.Name = "PointGrade"
        Me.PointGrade.ReadOnly = True
        Me.PointGrade.Width = 65
        '
        'GradingRemarks
        '
        Me.GradingRemarks.HeaderText = "Remarks"
        Me.GradingRemarks.Name = "GradingRemarks"
        Me.GradingRemarks.ReadOnly = True
        '
        'cboTerm
        '
        Me.cboTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Items.AddRange(New Object() {"Second Semester"})
        Me.cboTerm.Location = New System.Drawing.Point(68, 25)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(205, 24)
        Me.cboTerm.TabIndex = 18
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader3.Location = New System.Drawing.Point(12, 25)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(186, 24)
        Me.KryptonHeader3.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader3.TabIndex = 17
        Me.KryptonHeader3.Text = "Term:"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Term:"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'cboSY
        '
        Me.cboSY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.Items.AddRange(New Object() {"2011-2012"})
        Me.cboSY.Location = New System.Drawing.Point(367, 25)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(205, 24)
        Me.cboSY.TabIndex = 20
        '
        'KryptonHeader5
        '
        Me.KryptonHeader5.AutoSize = False
        Me.KryptonHeader5.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader5.Location = New System.Drawing.Point(279, 25)
        Me.KryptonHeader5.Name = "KryptonHeader5"
        Me.KryptonHeader5.Size = New System.Drawing.Size(186, 24)
        Me.KryptonHeader5.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader5.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader5.TabIndex = 19
        Me.KryptonHeader5.Text = "School Year:"
        Me.KryptonHeader5.Values.Description = ""
        Me.KryptonHeader5.Values.Heading = "School Year:"
        Me.KryptonHeader5.Values.Image = Nothing
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(914, 597)
        Me.cmdSave.LookAndFeel.SkinName = "iMaginary"
        Me.cmdSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 32)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.TabStop = False
        Me.cmdSave.Text = "Save [F2]"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(1031, 597)
        Me.cmdCancel.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 32)
        Me.cmdCancel.TabIndex = 23
        Me.cmdCancel.TabStop = False
        Me.cmdCancel.Text = "Cancel [Esc]"
        '
        'cmdCheckGrades
        '
        Me.cmdCheckGrades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCheckGrades.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckGrades.Appearance.Options.UseFont = True
        Me.cmdCheckGrades.Image = CType(resources.GetObject("cmdCheckGrades.Image"), System.Drawing.Image)
        Me.cmdCheckGrades.Location = New System.Drawing.Point(797, 597)
        Me.cmdCheckGrades.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCheckGrades.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCheckGrades.Name = "cmdCheckGrades"
        Me.cmdCheckGrades.Size = New System.Drawing.Size(111, 32)
        Me.cmdCheckGrades.TabIndex = 24
        Me.cmdCheckGrades.TabStop = False
        Me.cmdCheckGrades.Text = "Check Grades"
        '
        'frmAddEditGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1154, 675)
        Me.Controls.Add(Me.cmdCheckGrades)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cboSY)
        Me.Controls.Add(Me.KryptonHeader5)
        Me.Controls.Add(Me.cboTerm)
        Me.Controls.Add(Me.KryptonHeader3)
        Me.Controls.Add(Me.KryptonHeader2)
        Me.Controls.Add(Me.dvgStudents)
        Me.Controls.Add(Me.KryptonHeader1)
        Me.Controls.Add(Me.dvgLoads)
        Me.Controls.Add(Me.cboInsturctor)
        Me.Controls.Add(Me.KryptonHeader4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAddEditGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Add Edit Grades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dvgLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cboInsturctor As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader4 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents dvgLoads As System.Windows.Forms.DataGridView
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents dvgStudents As System.Windows.Forms.DataGridView
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboSY As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader5 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents SOID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnrolYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinalGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PointGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradingRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCheckGrades As DevExpress.XtraEditors.SimpleButton
End Class
