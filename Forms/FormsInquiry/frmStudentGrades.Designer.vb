<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentGrades
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentGrades))
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
        Me.cboStudents = New System.Windows.Forms.ComboBox
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtEDP = New System.Windows.Forms.TextBox
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader4 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboSubjects = New System.Windows.Forms.ComboBox
        Me.cboSY = New System.Windows.Forms.ComboBox
        Me.ErrProve = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdLoad = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.KryptonHeader6 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtName = New System.Windows.Forms.TextBox
        Me.KryptonHeader5 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.KryptonHeader7 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtGPA = New System.Windows.Forms.TextBox
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dvgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(1, 456)
        Me.StatusStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1048, 22)
        Me.StatusStrip1.TabIndex = 9
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1048, 25)
        Me.ToolStrip1.TabIndex = 0
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
        Me.ToolStrip2.Size = New System.Drawing.Size(1048, 25)
        Me.ToolStrip2.TabIndex = 1
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
        Me.dvgList.Location = New System.Drawing.Point(2, 200)
        Me.dvgList.Margin = New System.Windows.Forms.Padding(1)
        Me.dvgList.Name = "dvgList"
        Me.dvgList.ReadOnly = True
        Me.dvgList.Size = New System.Drawing.Size(1046, 254)
        Me.dvgList.TabIndex = 8
        '
        'cboStudents
        '
        Me.cboStudents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStudents.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudents.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(130, 172)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(894, 24)
        Me.cboStudents.TabIndex = 11
        Me.cboStudents.Visible = False
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.AutoSize = False
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(1, 172)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader2.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader2.TabIndex = 10
        Me.KryptonHeader2.Text = "Select Student:"
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "Select Student:"
        Me.KryptonHeader2.Values.Image = Nothing
        Me.KryptonHeader2.Visible = False
        '
        'txtEDP
        '
        Me.txtEDP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEDP.Location = New System.Drawing.Point(131, 65)
        Me.txtEDP.MaxLength = 11
        Me.txtEDP.Name = "txtEDP"
        Me.txtEDP.Size = New System.Drawing.Size(254, 27)
        Me.txtEDP.TabIndex = 3
        Me.txtEDP.Text = "MAIN-"
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AutoSize = False
        Me.KryptonHeader1.Location = New System.Drawing.Point(4, 65)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader1.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader1.StateNormal.Border.Rounding = 5
        Me.KryptonHeader1.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader1.TabIndex = 2
        Me.KryptonHeader1.Text = "EDP Number:"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "EDP Number:"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.Location = New System.Drawing.Point(4, 98)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader3.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader3.StateNormal.Border.Rounding = 5
        Me.KryptonHeader3.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader3.TabIndex = 4
        Me.KryptonHeader3.Text = "Term:"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Term:"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.AutoSize = False
        Me.KryptonHeader4.Location = New System.Drawing.Point(4, 131)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader4.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader4.StateNormal.Border.Rounding = 5
        Me.KryptonHeader4.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader4.TabIndex = 6
        Me.KryptonHeader4.Text = "School Year:"
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "School Year:"
        Me.KryptonHeader4.Values.Image = Nothing
        '
        'cboSubjects
        '
        Me.cboSubjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubjects.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubjects.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubjects.FormattingEnabled = True
        Me.cboSubjects.Items.AddRange(New Object() {"First Semester", "Second Semester", "Summer"})
        Me.cboSubjects.Location = New System.Drawing.Point(130, 98)
        Me.cboSubjects.Name = "cboSubjects"
        Me.cboSubjects.Size = New System.Drawing.Size(255, 27)
        Me.cboSubjects.TabIndex = 5
        '
        'cboSY
        '
        Me.cboSY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSY.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.Items.AddRange(New Object() {"2011-2012", "2012-2013", "2013-2014", "2014-2015", "2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020"})
        Me.cboSY.Location = New System.Drawing.Point(130, 131)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(255, 27)
        Me.cboSY.TabIndex = 7
        '
        'ErrProve
        '
        Me.ErrProve.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProve.ContainerControl = Me
        '
        'cmdLoad
        '
        Me.cmdLoad.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.Appearance.Options.UseFont = True
        Me.cmdLoad.Image = CType(resources.GetObject("cmdLoad.Image"), System.Drawing.Image)
        Me.cmdLoad.Location = New System.Drawing.Point(274, 164)
        Me.cmdLoad.LookAndFeel.SkinName = "iMaginary"
        Me.cmdLoad.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(111, 32)
        Me.cmdLoad.TabIndex = 22
        Me.cmdLoad.TabStop = False
        Me.cmdLoad.Text = "Load"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtGPA)
        Me.Panel1.Controls.Add(Me.txtYear)
        Me.Panel1.Controls.Add(Me.KryptonHeader7)
        Me.Panel1.Controls.Add(Me.txtCourse)
        Me.Panel1.Controls.Add(Me.KryptonHeader6)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.KryptonHeader5)
        Me.Panel1.Location = New System.Drawing.Point(391, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 101)
        Me.Panel1.TabIndex = 23
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(72, 45)
        Me.txtCourse.MaxLength = 11
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(434, 27)
        Me.txtCourse.TabIndex = 7
        '
        'KryptonHeader6
        '
        Me.KryptonHeader6.AutoSize = False
        Me.KryptonHeader6.Location = New System.Drawing.Point(13, 45)
        Me.KryptonHeader6.Name = "KryptonHeader6"
        Me.KryptonHeader6.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader6.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader6.StateNormal.Border.Rounding = 5
        Me.KryptonHeader6.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader6.TabIndex = 6
        Me.KryptonHeader6.Text = "Course:"
        Me.KryptonHeader6.Values.Description = ""
        Me.KryptonHeader6.Values.Heading = "Course:"
        Me.KryptonHeader6.Values.Image = Nothing
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(72, 12)
        Me.txtName.MaxLength = 11
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(546, 27)
        Me.txtName.TabIndex = 5
        '
        'KryptonHeader5
        '
        Me.KryptonHeader5.AutoSize = False
        Me.KryptonHeader5.Location = New System.Drawing.Point(13, 12)
        Me.KryptonHeader5.Name = "KryptonHeader5"
        Me.KryptonHeader5.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader5.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader5.StateNormal.Border.Rounding = 5
        Me.KryptonHeader5.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader5.TabIndex = 4
        Me.KryptonHeader5.Text = "Name:"
        Me.KryptonHeader5.Values.Description = ""
        Me.KryptonHeader5.Values.Heading = "Name:"
        Me.KryptonHeader5.Values.Image = Nothing
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(558, 45)
        Me.txtYear.MaxLength = 11
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(60, 27)
        Me.txtYear.TabIndex = 9
        '
        'KryptonHeader7
        '
        Me.KryptonHeader7.AutoSize = False
        Me.KryptonHeader7.Location = New System.Drawing.Point(512, 45)
        Me.KryptonHeader7.Name = "KryptonHeader7"
        Me.KryptonHeader7.Size = New System.Drawing.Size(97, 27)
        Me.KryptonHeader7.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader7.StateNormal.Border.Rounding = 5
        Me.KryptonHeader7.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader7.TabIndex = 8
        Me.KryptonHeader7.Text = "Year:"
        Me.KryptonHeader7.Values.Description = ""
        Me.KryptonHeader7.Values.Heading = "Year:"
        Me.KryptonHeader7.Values.Image = Nothing
        '
        'txtGPA
        '
        Me.txtGPA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPA.Location = New System.Drawing.Point(558, 71)
        Me.txtGPA.MaxLength = 11
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.ReadOnly = True
        Me.txtGPA.Size = New System.Drawing.Size(60, 27)
        Me.txtGPA.TabIndex = 10
        Me.txtGPA.Visible = False
        '
        'frmStudentGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1050, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.dvgList)
        Me.Controls.Add(Me.cboSY)
        Me.Controls.Add(Me.cboSubjects)
        Me.Controls.Add(Me.KryptonHeader4)
        Me.Controls.Add(Me.KryptonHeader3)
        Me.Controls.Add(Me.txtEDP)
        Me.Controls.Add(Me.KryptonHeader1)
        Me.Controls.Add(Me.cboStudents)
        Me.Controls.Add(Me.KryptonHeader2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStudentGrades"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Grades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dvgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents cboStudents As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtEDP As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader4 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboSubjects As System.Windows.Forms.ComboBox
    Friend WithEvents cboSY As System.Windows.Forms.ComboBox
    Friend WithEvents ErrProve As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader5 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader6 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader7 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtGPA As System.Windows.Forms.TextBox
End Class
