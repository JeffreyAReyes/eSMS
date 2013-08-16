<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterStudent))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblHeader = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdViewRecords = New DevExpress.XtraEditors.SimpleButton
        Me.cmdChangeCourse = New DevExpress.XtraEditors.SimpleButton
        Me.dvgFees = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtDept = New System.Windows.Forms.TextBox
        Me.KryptonHeader25 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtHRMFund = New System.Windows.Forms.TextBox
        Me.KryptonHeader24 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtUnits = New System.Windows.Forms.TextBox
        Me.txtIsEnrolled = New System.Windows.Forms.TextBox
        Me.txtCooking = New System.Windows.Forms.TextBox
        Me.KryptonHeader23 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cmdViewFees = New DevExpress.XtraEditors.SimpleButton
        Me.txtDegree = New System.Windows.Forms.TextBox
        Me.txtAddCharges = New System.Windows.Forms.TextBox
        Me.KryptonHeader22 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtBackAccount = New System.Windows.Forms.TextBox
        Me.KryptonHeader21 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.KryptonHeader20 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtLess = New System.Windows.Forms.TextBox
        Me.KryptonHeader13 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtPremium = New System.Windows.Forms.TextBox
        Me.KryptonHeader18 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader17 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtCharges = New System.Windows.Forms.TextBox
        Me.KryptonHeader19 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtOtherFees = New System.Windows.Forms.TextBox
        Me.KryptonHeader16 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtMatFee = New System.Windows.Forms.TextBox
        Me.KryptonHeader15 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtLabFee = New System.Windows.Forms.TextBox
        Me.KryptonHeader14 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtTuition = New System.Windows.Forms.TextBox
        Me.KryptonHeader12 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtSex = New System.Windows.Forms.TextBox
        Me.KryptonHeader11 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dtpAssessed = New System.Windows.Forms.DateTimePicker
        Me.dtpEnrolled = New System.Windows.Forms.DateTimePicker
        Me.KryptonHeader10 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader9 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtPayments = New System.Windows.Forms.TextBox
        Me.lblPayments = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.KryptonHeader5 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.KryptonHeader4 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtName = New System.Windows.Forms.TextBox
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtEDP = New System.Windows.Forms.TextBox
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTotUnitsDisplay = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dvgSubjectsList = New System.Windows.Forms.DataGridView
        Me.ESSID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Time1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Room1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Time2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Day2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Room2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumOfUnits = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton
        Me.chkCOR = New System.Windows.Forms.CheckBox
        Me.chkAllowConflict = New System.Windows.Forms.CheckBox
        Me.cmdClearList = New DevExpress.XtraEditors.SimpleButton
        Me.txtSectionCode = New System.Windows.Forms.TextBox
        Me.txtDummy = New System.Windows.Forms.TextBox
        Me.lblError = New System.Windows.Forms.Label
        Me.cmdTestPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdViewCourseOfferings = New DevExpress.XtraEditors.SimpleButton
        Me.KryptonHeader8 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cmdBlock = New DevExpress.XtraEditors.SimpleButton
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.KryptonHeader7 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cboSubjects = New System.Windows.Forms.ComboBox
        Me.KryptonHeader6 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.lblTotUnits = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ErrProve = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdHelp = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblNSTP = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dvgSemestralFees = New System.Windows.Forms.DataGridView
        Me.SFID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FNID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FeeCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FeeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FeeAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvgFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dvgSubjectsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgSemestralFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1140, 22)
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
        'lblHeader
        '
        Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.AutoSize = False
        Me.lblHeader.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1140, 25)
        Me.lblHeader.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.lblHeader.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Heading"
        Me.lblHeader.Values.Description = ""
        Me.lblHeader.Values.Heading = "Heading"
        Me.lblHeader.Values.Image = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdViewRecords)
        Me.GroupBox1.Controls.Add(Me.cmdChangeCourse)
        Me.GroupBox1.Controls.Add(Me.dvgFees)
        Me.GroupBox1.Controls.Add(Me.txtDept)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader25)
        Me.GroupBox1.Controls.Add(Me.txtHRMFund)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader24)
        Me.GroupBox1.Controls.Add(Me.txtUnits)
        Me.GroupBox1.Controls.Add(Me.txtIsEnrolled)
        Me.GroupBox1.Controls.Add(Me.txtCooking)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader23)
        Me.GroupBox1.Controls.Add(Me.cmdViewFees)
        Me.GroupBox1.Controls.Add(Me.txtDegree)
        Me.GroupBox1.Controls.Add(Me.txtAddCharges)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader22)
        Me.GroupBox1.Controls.Add(Me.txtBackAccount)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader21)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader20)
        Me.GroupBox1.Controls.Add(Me.txtLess)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader13)
        Me.GroupBox1.Controls.Add(Me.txtPremium)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader18)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader17)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtCharges)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader19)
        Me.GroupBox1.Controls.Add(Me.txtOtherFees)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader16)
        Me.GroupBox1.Controls.Add(Me.txtMatFee)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader15)
        Me.GroupBox1.Controls.Add(Me.txtLabFee)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader14)
        Me.GroupBox1.Controls.Add(Me.txtTuition)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader12)
        Me.GroupBox1.Controls.Add(Me.txtSex)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader11)
        Me.GroupBox1.Controls.Add(Me.dtpAssessed)
        Me.GroupBox1.Controls.Add(Me.dtpEnrolled)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader10)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader9)
        Me.GroupBox1.Controls.Add(Me.txtPayments)
        Me.GroupBox1.Controls.Add(Me.lblPayments)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader5)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader4)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader3)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader1)
        Me.GroupBox1.Controls.Add(Me.txtEDP)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1140, 228)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Student"
        '
        'cmdViewRecords
        '
        Me.cmdViewRecords.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewRecords.Appearance.Options.UseFont = True
        Me.cmdViewRecords.Image = CType(resources.GetObject("cmdViewRecords.Image"), System.Drawing.Image)
        Me.cmdViewRecords.Location = New System.Drawing.Point(138, 193)
        Me.cmdViewRecords.LookAndFeel.SkinName = "iMaginary"
        Me.cmdViewRecords.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdViewRecords.Name = "cmdViewRecords"
        Me.cmdViewRecords.Size = New System.Drawing.Size(125, 29)
        Me.cmdViewRecords.TabIndex = 18
        Me.cmdViewRecords.TabStop = False
        Me.cmdViewRecords.Text = "View Record"
        Me.cmdViewRecords.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdViewRecords.ToolTipTitle = "Search student"
        '
        'cmdChangeCourse
        '
        Me.cmdChangeCourse.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChangeCourse.Appearance.Options.UseFont = True
        Me.cmdChangeCourse.Image = CType(resources.GetObject("cmdChangeCourse.Image"), System.Drawing.Image)
        Me.cmdChangeCourse.Location = New System.Drawing.Point(13, 193)
        Me.cmdChangeCourse.LookAndFeel.SkinName = "iMaginary"
        Me.cmdChangeCourse.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdChangeCourse.Name = "cmdChangeCourse"
        Me.cmdChangeCourse.Size = New System.Drawing.Size(119, 29)
        Me.cmdChangeCourse.TabIndex = 51
        Me.cmdChangeCourse.TabStop = False
        Me.cmdChangeCourse.Text = "Change Course"
        Me.ToolTip1.SetToolTip(Me.cmdChangeCourse, "Click to change student course.")
        Me.cmdChangeCourse.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdChangeCourse.ToolTipTitle = "Click to change student course."
        '
        'dvgFees
        '
        Me.dvgFees.AllowUserToAddRows = False
        Me.dvgFees.AllowUserToDeleteRows = False
        Me.dvgFees.AllowUserToResizeColumns = False
        Me.dvgFees.AllowUserToResizeRows = False
        Me.dvgFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Fee, Me.Amount})
        Me.dvgFees.Location = New System.Drawing.Point(664, 12)
        Me.dvgFees.Name = "dvgFees"
        Me.dvgFees.ReadOnly = True
        Me.dvgFees.RowHeadersWidth = 25
        Me.dvgFees.Size = New System.Drawing.Size(311, 210)
        Me.dvgFees.TabIndex = 50
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Fee
        '
        Me.Fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fee.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fee.HeaderText = "Fee"
        Me.Fee.Name = "Fee"
        Me.Fee.ReadOnly = True
        Me.Fee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Amount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txtDept
        '
        Me.txtDept.AutoCompleteCustomSource.AddRange(New String() {"MALE", "FEMALE"})
        Me.txtDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDept.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.Location = New System.Drawing.Point(492, 90)
        Me.txtDept.MaxLength = 6
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(134, 27)
        Me.txtDept.TabIndex = 49
        '
        'KryptonHeader25
        '
        Me.KryptonHeader25.AutoSize = False
        Me.KryptonHeader25.Location = New System.Drawing.Point(429, 90)
        Me.KryptonHeader25.Name = "KryptonHeader25"
        Me.KryptonHeader25.Size = New System.Drawing.Size(88, 27)
        Me.KryptonHeader25.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader25.StateNormal.Border.Rounding = 0
        Me.KryptonHeader25.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader25.TabIndex = 48
        Me.KryptonHeader25.Text = "Dept:"
        Me.KryptonHeader25.Values.Description = ""
        Me.KryptonHeader25.Values.Heading = "Dept:"
        Me.KryptonHeader25.Values.Image = Nothing
        '
        'txtHRMFund
        '
        Me.txtHRMFund.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtHRMFund.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHRMFund.Location = New System.Drawing.Point(1056, 66)
        Me.txtHRMFund.Name = "txtHRMFund"
        Me.txtHRMFund.ReadOnly = True
        Me.txtHRMFund.Size = New System.Drawing.Size(74, 22)
        Me.txtHRMFund.TabIndex = 37
        Me.txtHRMFund.TabStop = False
        Me.txtHRMFund.Text = "0.00"
        Me.txtHRMFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHRMFund.Visible = False
        '
        'KryptonHeader24
        '
        Me.KryptonHeader24.AutoSize = False
        Me.KryptonHeader24.Location = New System.Drawing.Point(981, 66)
        Me.KryptonHeader24.Name = "KryptonHeader24"
        Me.KryptonHeader24.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader24.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader24.StateNormal.Border.Rounding = 0
        Me.KryptonHeader24.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader24.TabIndex = 36
        Me.KryptonHeader24.Text = "HRM Fund:"
        Me.KryptonHeader24.Values.Description = ""
        Me.KryptonHeader24.Values.Heading = "HRM Fund:"
        Me.KryptonHeader24.Values.Image = Nothing
        Me.KryptonHeader24.Visible = False
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtUnits.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Location = New System.Drawing.Point(533, 160)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.ReadOnly = True
        Me.txtUnits.Size = New System.Drawing.Size(93, 27)
        Me.txtUnits.TabIndex = 20
        Me.txtUnits.TabStop = False
        Me.txtUnits.Text = "0.00"
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUnits.Visible = False
        '
        'txtIsEnrolled
        '
        Me.txtIsEnrolled.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtIsEnrolled.Enabled = False
        Me.txtIsEnrolled.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIsEnrolled.Location = New System.Drawing.Point(434, 160)
        Me.txtIsEnrolled.Name = "txtIsEnrolled"
        Me.txtIsEnrolled.ReadOnly = True
        Me.txtIsEnrolled.Size = New System.Drawing.Size(93, 27)
        Me.txtIsEnrolled.TabIndex = 19
        Me.txtIsEnrolled.TabStop = False
        Me.txtIsEnrolled.Text = "0"
        Me.txtIsEnrolled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIsEnrolled.Visible = False
        '
        'txtCooking
        '
        Me.txtCooking.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCooking.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCooking.Location = New System.Drawing.Point(1056, 94)
        Me.txtCooking.Name = "txtCooking"
        Me.txtCooking.ReadOnly = True
        Me.txtCooking.Size = New System.Drawing.Size(74, 22)
        Me.txtCooking.TabIndex = 39
        Me.txtCooking.TabStop = False
        Me.txtCooking.Text = "0.00"
        Me.txtCooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCooking.Visible = False
        '
        'KryptonHeader23
        '
        Me.KryptonHeader23.AutoSize = False
        Me.KryptonHeader23.Location = New System.Drawing.Point(981, 94)
        Me.KryptonHeader23.Name = "KryptonHeader23"
        Me.KryptonHeader23.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader23.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader23.StateNormal.Border.Rounding = 0
        Me.KryptonHeader23.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader23.TabIndex = 38
        Me.KryptonHeader23.Text = "Cooking:"
        Me.KryptonHeader23.Values.Description = ""
        Me.KryptonHeader23.Values.Heading = "Cooking:"
        Me.KryptonHeader23.Values.Image = Nothing
        Me.KryptonHeader23.Visible = False
        '
        'cmdViewFees
        '
        Me.cmdViewFees.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewFees.Appearance.Options.UseFont = True
        Me.cmdViewFees.Image = CType(resources.GetObject("cmdViewFees.Image"), System.Drawing.Image)
        Me.cmdViewFees.Location = New System.Drawing.Point(986, 193)
        Me.cmdViewFees.LookAndFeel.SkinName = "iMaginary"
        Me.cmdViewFees.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdViewFees.Name = "cmdViewFees"
        Me.cmdViewFees.Size = New System.Drawing.Size(149, 29)
        Me.cmdViewFees.TabIndex = 35
        Me.cmdViewFees.TabStop = False
        Me.cmdViewFees.Text = "View Rate of Fees"
        Me.cmdViewFees.ToolTip = "Click this button to view this semester's rates of fees."
        '
        'txtDegree
        '
        Me.txtDegree.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtDegree.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDegree.Location = New System.Drawing.Point(122, 160)
        Me.txtDegree.Name = "txtDegree"
        Me.txtDegree.ReadOnly = True
        Me.txtDegree.Size = New System.Drawing.Size(166, 27)
        Me.txtDegree.TabIndex = 17
        Me.txtDegree.TabStop = False
        '
        'txtAddCharges
        '
        Me.txtAddCharges.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAddCharges.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddCharges.Location = New System.Drawing.Point(1056, 119)
        Me.txtAddCharges.Name = "txtAddCharges"
        Me.txtAddCharges.ReadOnly = True
        Me.txtAddCharges.Size = New System.Drawing.Size(75, 22)
        Me.txtAddCharges.TabIndex = 41
        Me.txtAddCharges.TabStop = False
        Me.txtAddCharges.Text = "0.00"
        Me.txtAddCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAddCharges.Visible = False
        '
        'KryptonHeader22
        '
        Me.KryptonHeader22.AutoSize = False
        Me.KryptonHeader22.Location = New System.Drawing.Point(981, 119)
        Me.KryptonHeader22.Name = "KryptonHeader22"
        Me.KryptonHeader22.Size = New System.Drawing.Size(94, 22)
        Me.KryptonHeader22.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader22.StateNormal.Border.Rounding = 0
        Me.KryptonHeader22.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader22.TabIndex = 40
        Me.KryptonHeader22.Text = "Add Charges:"
        Me.KryptonHeader22.Values.Description = "Description"
        Me.KryptonHeader22.Values.Heading = "Add Charges:"
        Me.KryptonHeader22.Values.Image = Nothing
        Me.KryptonHeader22.Visible = False
        '
        'txtBackAccount
        '
        Me.txtBackAccount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBackAccount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackAccount.Location = New System.Drawing.Point(900, 83)
        Me.txtBackAccount.Name = "txtBackAccount"
        Me.txtBackAccount.ReadOnly = True
        Me.txtBackAccount.Size = New System.Drawing.Size(75, 22)
        Me.txtBackAccount.TabIndex = 43
        Me.txtBackAccount.TabStop = False
        Me.txtBackAccount.Text = "0.00"
        Me.txtBackAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader21
        '
        Me.KryptonHeader21.AutoSize = False
        Me.KryptonHeader21.Location = New System.Drawing.Point(826, 83)
        Me.KryptonHeader21.Name = "KryptonHeader21"
        Me.KryptonHeader21.Size = New System.Drawing.Size(94, 22)
        Me.KryptonHeader21.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader21.StateNormal.Border.Rounding = 0
        Me.KryptonHeader21.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader21.TabIndex = 42
        Me.KryptonHeader21.Text = "B. Account:"
        Me.KryptonHeader21.Values.Description = "Description"
        Me.KryptonHeader21.Values.Heading = "B. Account:"
        Me.KryptonHeader21.Values.Image = Nothing
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBalance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtBalance.Location = New System.Drawing.Point(900, 139)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(75, 22)
        Me.txtBalance.TabIndex = 47
        Me.txtBalance.TabStop = False
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader20
        '
        Me.KryptonHeader20.AutoSize = False
        Me.KryptonHeader20.Location = New System.Drawing.Point(826, 139)
        Me.KryptonHeader20.Name = "KryptonHeader20"
        Me.KryptonHeader20.Size = New System.Drawing.Size(94, 22)
        Me.KryptonHeader20.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader20.StateNormal.Border.Rounding = 0
        Me.KryptonHeader20.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader20.TabIndex = 46
        Me.KryptonHeader20.Text = "Balance:"
        Me.KryptonHeader20.Values.Description = "Description"
        Me.KryptonHeader20.Values.Heading = "Balance:"
        Me.KryptonHeader20.Values.Image = Nothing
        '
        'txtLess
        '
        Me.txtLess.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtLess.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLess.Location = New System.Drawing.Point(900, 111)
        Me.txtLess.Name = "txtLess"
        Me.txtLess.ReadOnly = True
        Me.txtLess.Size = New System.Drawing.Size(75, 22)
        Me.txtLess.TabIndex = 45
        Me.txtLess.TabStop = False
        Me.txtLess.Text = "0.00"
        Me.txtLess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader13
        '
        Me.KryptonHeader13.AutoSize = False
        Me.KryptonHeader13.Location = New System.Drawing.Point(664, 165)
        Me.KryptonHeader13.Name = "KryptonHeader13"
        Me.KryptonHeader13.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader13.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader13.StateNormal.Border.Rounding = 0
        Me.KryptonHeader13.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader13.TabIndex = 23
        Me.KryptonHeader13.Text = "Student Devt:"
        Me.KryptonHeader13.Values.Description = "Description"
        Me.KryptonHeader13.Values.Heading = "Student Devt:"
        Me.KryptonHeader13.Values.Image = Nothing
        Me.KryptonHeader13.Visible = False
        '
        'txtPremium
        '
        Me.txtPremium.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPremium.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPremium.Location = New System.Drawing.Point(739, 165)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.ReadOnly = True
        Me.txtPremium.Size = New System.Drawing.Size(74, 22)
        Me.txtPremium.TabIndex = 24
        Me.txtPremium.TabStop = False
        Me.txtPremium.Text = "0.00"
        Me.txtPremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPremium.Visible = False
        '
        'KryptonHeader18
        '
        Me.KryptonHeader18.AutoSize = False
        Me.KryptonHeader18.Location = New System.Drawing.Point(826, 111)
        Me.KryptonHeader18.Name = "KryptonHeader18"
        Me.KryptonHeader18.Size = New System.Drawing.Size(94, 22)
        Me.KryptonHeader18.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader18.StateNormal.Border.Rounding = 0
        Me.KryptonHeader18.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader18.TabIndex = 44
        Me.KryptonHeader18.Text = "Less:"
        Me.KryptonHeader18.Values.Description = "Description"
        Me.KryptonHeader18.Values.Heading = "Less:"
        Me.KryptonHeader18.Values.Image = Nothing
        '
        'KryptonHeader17
        '
        Me.KryptonHeader17.AutoSize = False
        Me.KryptonHeader17.Location = New System.Drawing.Point(819, 165)
        Me.KryptonHeader17.Name = "KryptonHeader17"
        Me.KryptonHeader17.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader17.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader17.StateNormal.Border.Rounding = 0
        Me.KryptonHeader17.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader17.TabIndex = 31
        Me.KryptonHeader17.Text = "Charges:"
        Me.KryptonHeader17.Values.Description = "Description"
        Me.KryptonHeader17.Values.Heading = "Charges:"
        Me.KryptonHeader17.Values.Image = Nothing
        Me.KryptonHeader17.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotal.Location = New System.Drawing.Point(739, 139)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(75, 22)
        Me.txtTotal.TabIndex = 34
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCharges
        '
        Me.txtCharges.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCharges.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharges.Location = New System.Drawing.Point(894, 165)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.ReadOnly = True
        Me.txtCharges.Size = New System.Drawing.Size(74, 22)
        Me.txtCharges.TabIndex = 32
        Me.txtCharges.TabStop = False
        Me.txtCharges.Text = "0.00"
        Me.txtCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCharges.Visible = False
        '
        'KryptonHeader19
        '
        Me.KryptonHeader19.AutoSize = False
        Me.KryptonHeader19.Location = New System.Drawing.Point(664, 139)
        Me.KryptonHeader19.Name = "KryptonHeader19"
        Me.KryptonHeader19.Size = New System.Drawing.Size(94, 22)
        Me.KryptonHeader19.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader19.StateNormal.Border.Rounding = 0
        Me.KryptonHeader19.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader19.TabIndex = 33
        Me.KryptonHeader19.Text = "Total:"
        Me.KryptonHeader19.Values.Description = "Description"
        Me.KryptonHeader19.Values.Heading = "Total:"
        Me.KryptonHeader19.Values.Image = Nothing
        '
        'txtOtherFees
        '
        Me.txtOtherFees.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOtherFees.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherFees.Location = New System.Drawing.Point(739, 112)
        Me.txtOtherFees.Name = "txtOtherFees"
        Me.txtOtherFees.ReadOnly = True
        Me.txtOtherFees.Size = New System.Drawing.Size(74, 22)
        Me.txtOtherFees.TabIndex = 30
        Me.txtOtherFees.TabStop = False
        Me.txtOtherFees.Text = "0.00"
        Me.txtOtherFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader16
        '
        Me.KryptonHeader16.AutoSize = False
        Me.KryptonHeader16.Location = New System.Drawing.Point(664, 112)
        Me.KryptonHeader16.Name = "KryptonHeader16"
        Me.KryptonHeader16.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader16.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader16.StateNormal.Border.Rounding = 0
        Me.KryptonHeader16.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader16.TabIndex = 29
        Me.KryptonHeader16.Text = "Other Fees:"
        Me.KryptonHeader16.Values.Description = "Description"
        Me.KryptonHeader16.Values.Heading = "Other Fees:"
        Me.KryptonHeader16.Values.Image = Nothing
        '
        'txtMatFee
        '
        Me.txtMatFee.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtMatFee.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatFee.Location = New System.Drawing.Point(739, 55)
        Me.txtMatFee.Name = "txtMatFee"
        Me.txtMatFee.ReadOnly = True
        Me.txtMatFee.Size = New System.Drawing.Size(74, 22)
        Me.txtMatFee.TabIndex = 28
        Me.txtMatFee.TabStop = False
        Me.txtMatFee.Text = "0.00"
        Me.txtMatFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader15
        '
        Me.KryptonHeader15.AutoSize = False
        Me.KryptonHeader15.Location = New System.Drawing.Point(664, 55)
        Me.KryptonHeader15.Name = "KryptonHeader15"
        Me.KryptonHeader15.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader15.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader15.StateNormal.Border.Rounding = 0
        Me.KryptonHeader15.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader15.TabIndex = 27
        Me.KryptonHeader15.Text = "Misc. Fees:"
        Me.KryptonHeader15.Values.Description = "Description"
        Me.KryptonHeader15.Values.Heading = "Misc. Fees:"
        Me.KryptonHeader15.Values.Image = Nothing
        '
        'txtLabFee
        '
        Me.txtLabFee.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtLabFee.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabFee.Location = New System.Drawing.Point(739, 83)
        Me.txtLabFee.Name = "txtLabFee"
        Me.txtLabFee.ReadOnly = True
        Me.txtLabFee.Size = New System.Drawing.Size(74, 22)
        Me.txtLabFee.TabIndex = 26
        Me.txtLabFee.TabStop = False
        Me.txtLabFee.Text = "0.00"
        Me.txtLabFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader14
        '
        Me.KryptonHeader14.AutoSize = False
        Me.KryptonHeader14.Location = New System.Drawing.Point(664, 83)
        Me.KryptonHeader14.Name = "KryptonHeader14"
        Me.KryptonHeader14.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader14.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader14.StateNormal.Border.Rounding = 0
        Me.KryptonHeader14.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader14.TabIndex = 25
        Me.KryptonHeader14.Text = "Lab. Fees"
        Me.KryptonHeader14.Values.Description = "Description"
        Me.KryptonHeader14.Values.Heading = "Lab. Fees"
        Me.KryptonHeader14.Values.Image = Nothing
        '
        'txtTuition
        '
        Me.txtTuition.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTuition.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuition.Location = New System.Drawing.Point(739, 27)
        Me.txtTuition.Name = "txtTuition"
        Me.txtTuition.ReadOnly = True
        Me.txtTuition.Size = New System.Drawing.Size(74, 22)
        Me.txtTuition.TabIndex = 22
        Me.txtTuition.TabStop = False
        Me.txtTuition.Text = "0.00"
        Me.txtTuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader12
        '
        Me.KryptonHeader12.AutoSize = False
        Me.KryptonHeader12.Location = New System.Drawing.Point(664, 27)
        Me.KryptonHeader12.Name = "KryptonHeader12"
        Me.KryptonHeader12.Size = New System.Drawing.Size(93, 22)
        Me.KryptonHeader12.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader12.StateNormal.Border.Rounding = 0
        Me.KryptonHeader12.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader12.TabIndex = 21
        Me.KryptonHeader12.Text = "Tuition:"
        Me.KryptonHeader12.Values.Description = "Description"
        Me.KryptonHeader12.Values.Heading = "Tuition:"
        Me.KryptonHeader12.Values.Image = Nothing
        '
        'txtSex
        '
        Me.txtSex.AutoCompleteCustomSource.AddRange(New String() {"MALE", "FEMALE"})
        Me.txtSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSex.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtSex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSex.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(492, 57)
        Me.txtSex.MaxLength = 6
        Me.txtSex.Name = "txtSex"
        Me.txtSex.ReadOnly = True
        Me.txtSex.Size = New System.Drawing.Size(134, 27)
        Me.txtSex.TabIndex = 9
        '
        'KryptonHeader11
        '
        Me.KryptonHeader11.AutoSize = False
        Me.KryptonHeader11.Location = New System.Drawing.Point(429, 57)
        Me.KryptonHeader11.Name = "KryptonHeader11"
        Me.KryptonHeader11.Size = New System.Drawing.Size(91, 27)
        Me.KryptonHeader11.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader11.StateNormal.Border.Rounding = 0
        Me.KryptonHeader11.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader11.TabIndex = 8
        Me.KryptonHeader11.Text = "Sex:"
        Me.KryptonHeader11.Values.Description = ""
        Me.KryptonHeader11.Values.Heading = "Sex:"
        Me.KryptonHeader11.Values.Image = Nothing
        '
        'dtpAssessed
        '
        Me.dtpAssessed.CustomFormat = "MMM/dd/yyyy"
        Me.dtpAssessed.Enabled = False
        Me.dtpAssessed.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAssessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAssessed.Location = New System.Drawing.Point(418, 126)
        Me.dtpAssessed.Name = "dtpAssessed"
        Me.dtpAssessed.Size = New System.Drawing.Size(208, 26)
        Me.dtpAssessed.TabIndex = 15
        Me.dtpAssessed.TabStop = False
        '
        'dtpEnrolled
        '
        Me.dtpEnrolled.CustomFormat = "MMM/dd/yyyy"
        Me.dtpEnrolled.Enabled = False
        Me.dtpEnrolled.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnrolled.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnrolled.Location = New System.Drawing.Point(122, 126)
        Me.dtpEnrolled.Name = "dtpEnrolled"
        Me.dtpEnrolled.Size = New System.Drawing.Size(166, 26)
        Me.dtpEnrolled.TabIndex = 13
        Me.dtpEnrolled.TabStop = False
        '
        'KryptonHeader10
        '
        Me.KryptonHeader10.AutoSize = False
        Me.KryptonHeader10.Location = New System.Drawing.Point(292, 126)
        Me.KryptonHeader10.Name = "KryptonHeader10"
        Me.KryptonHeader10.Size = New System.Drawing.Size(138, 26)
        Me.KryptonHeader10.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader10.StateNormal.Border.Rounding = 5
        Me.KryptonHeader10.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader10.TabIndex = 14
        Me.KryptonHeader10.Text = "Date Re-assessed:"
        Me.KryptonHeader10.Values.Description = ""
        Me.KryptonHeader10.Values.Heading = "Date Re-assessed:"
        Me.KryptonHeader10.Values.Image = Nothing
        '
        'KryptonHeader9
        '
        Me.KryptonHeader9.AutoSize = False
        Me.KryptonHeader9.Location = New System.Drawing.Point(13, 127)
        Me.KryptonHeader9.Name = "KryptonHeader9"
        Me.KryptonHeader9.Size = New System.Drawing.Size(143, 25)
        Me.KryptonHeader9.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader9.StateNormal.Border.Rounding = 5
        Me.KryptonHeader9.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader9.TabIndex = 12
        Me.KryptonHeader9.Text = "Date Enrolled:"
        Me.KryptonHeader9.Values.Description = ""
        Me.KryptonHeader9.Values.Heading = "Date Enrolled:"
        Me.KryptonHeader9.Values.Image = Nothing
        '
        'txtPayments
        '
        Me.txtPayments.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtPayments.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayments.Location = New System.Drawing.Point(294, 160)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.ReadOnly = True
        Me.txtPayments.Size = New System.Drawing.Size(126, 27)
        Me.txtPayments.TabIndex = 18
        Me.txtPayments.TabStop = False
        Me.txtPayments.Text = "0.00"
        Me.txtPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPayments
        '
        Me.lblPayments.AutoSize = False
        Me.lblPayments.Location = New System.Drawing.Point(14, 160)
        Me.lblPayments.Name = "lblPayments"
        Me.lblPayments.Size = New System.Drawing.Size(139, 27)
        Me.lblPayments.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.lblPayments.StateNormal.Border.Rounding = 0
        Me.lblPayments.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayments.TabIndex = 16
        Me.lblPayments.Text = "Degree:"
        Me.lblPayments.Values.Description = ""
        Me.lblPayments.Values.Heading = "Degree:"
        Me.lblPayments.Values.Image = Nothing
        '
        'txtStatus
        '
        Me.txtStatus.AutoCompleteCustomSource.AddRange(New String() {"New", "Old", "Returnee"})
        Me.txtStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(492, 22)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(134, 27)
        Me.txtStatus.TabIndex = 5
        '
        'KryptonHeader5
        '
        Me.KryptonHeader5.AutoSize = False
        Me.KryptonHeader5.Location = New System.Drawing.Point(429, 22)
        Me.KryptonHeader5.Name = "KryptonHeader5"
        Me.KryptonHeader5.Size = New System.Drawing.Size(68, 27)
        Me.KryptonHeader5.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader5.StateNormal.Border.Rounding = 5
        Me.KryptonHeader5.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader5.TabIndex = 4
        Me.KryptonHeader5.Text = "Status:"
        Me.KryptonHeader5.Values.Description = ""
        Me.KryptonHeader5.Values.Heading = "Status:"
        Me.KryptonHeader5.Values.Image = Nothing
        '
        'txtCourse
        '
        Me.txtCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCourse.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourse.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(122, 90)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(298, 27)
        Me.txtCourse.TabIndex = 11
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.AutoSize = False
        Me.KryptonHeader4.Location = New System.Drawing.Point(13, 90)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(140, 27)
        Me.KryptonHeader4.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader4.StateNormal.Border.Rounding = 5
        Me.KryptonHeader4.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader4.TabIndex = 10
        Me.KryptonHeader4.Text = "Course:"
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "Course:"
        Me.KryptonHeader4.Values.Image = Nothing
        '
        'txtYear
        '
        Me.txtYear.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5"})
        Me.txtYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(356, 22)
        Me.txtYear.MaxLength = 1
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(64, 27)
        Me.txtYear.TabIndex = 3
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.Location = New System.Drawing.Point(293, 22)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(88, 27)
        Me.KryptonHeader3.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader3.StateNormal.Border.Rounding = 5
        Me.KryptonHeader3.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader3.TabIndex = 2
        Me.KryptonHeader3.Text = "Year:"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Year:"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(122, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(298, 27)
        Me.txtName.TabIndex = 7
        Me.txtName.TabStop = False
        Me.txtName.Tag = " "
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AutoSize = False
        Me.KryptonHeader1.Location = New System.Drawing.Point(13, 57)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(143, 27)
        Me.KryptonHeader1.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader1.StateNormal.Border.Rounding = 5
        Me.KryptonHeader1.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader1.TabIndex = 6
        Me.KryptonHeader1.Text = "Name:"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Name:"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'txtEDP
        '
        Me.txtEDP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEDP.Location = New System.Drawing.Point(122, 22)
        Me.txtEDP.MaxLength = 11
        Me.txtEDP.Name = "txtEDP"
        Me.txtEDP.Size = New System.Drawing.Size(165, 27)
        Me.txtEDP.TabIndex = 1
        Me.txtEDP.Text = "MAIN-"
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.AutoSize = False
        Me.KryptonHeader2.Location = New System.Drawing.Point(14, 22)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(142, 27)
        Me.KryptonHeader2.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader2.StateNormal.Border.Rounding = 5
        Me.KryptonHeader2.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader2.TabIndex = 0
        Me.KryptonHeader2.Text = "EDP Number:"
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "EDP Number:"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblTotUnitsDisplay)
        Me.GroupBox2.Controls.Add(Me.dvgSubjectsList)
        Me.GroupBox2.Controls.Add(Me.cmdRemove)
        Me.GroupBox2.Controls.Add(Me.chkCOR)
        Me.GroupBox2.Controls.Add(Me.chkAllowConflict)
        Me.GroupBox2.Controls.Add(Me.cmdClearList)
        Me.GroupBox2.Controls.Add(Me.txtSectionCode)
        Me.GroupBox2.Controls.Add(Me.txtDummy)
        Me.GroupBox2.Controls.Add(Me.lblError)
        Me.GroupBox2.Controls.Add(Me.cmdTestPrint)
        Me.GroupBox2.Controls.Add(Me.cmdViewCourseOfferings)
        Me.GroupBox2.Controls.Add(Me.KryptonHeader8)
        Me.GroupBox2.Controls.Add(Me.cmdBlock)
        Me.GroupBox2.Controls.Add(Me.KryptonHeader7)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cboSubjects)
        Me.GroupBox2.Controls.Add(Me.KryptonHeader6)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1140, 379)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subjects List"
        '
        'lblTotUnitsDisplay
        '
        Me.lblTotUnitsDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotUnitsDisplay.AutoSize = False
        Me.lblTotUnitsDisplay.Location = New System.Drawing.Point(935, 338)
        Me.lblTotUnitsDisplay.Name = "lblTotUnitsDisplay"
        Me.lblTotUnitsDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotUnitsDisplay.Size = New System.Drawing.Size(195, 35)
        Me.lblTotUnitsDisplay.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.lblTotUnitsDisplay.StateNormal.Border.Rounding = 0
        Me.lblTotUnitsDisplay.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotUnitsDisplay.TabIndex = 17
        Me.lblTotUnitsDisplay.Text = "0.0"
        Me.lblTotUnitsDisplay.Values.Description = ""
        Me.lblTotUnitsDisplay.Values.Heading = "0.0"
        Me.lblTotUnitsDisplay.Values.Image = Nothing
        '
        'dvgSubjectsList
        '
        Me.dvgSubjectsList.AllowUserToAddRows = False
        Me.dvgSubjectsList.AllowUserToResizeRows = False
        Me.dvgSubjectsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgSubjectsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dvgSubjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgSubjectsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ESSID, Me.SubjNumber, Me.SubCode, Me.DescTitle, Me.Time1, Me.Day1, Me.Room1, Me.Time2, Me.Day2, Me.Room2, Me.NumOfUnits, Me.LabCode, Me.SubID, Me.SOID})
        Me.dvgSubjectsList.Location = New System.Drawing.Point(14, 87)
        Me.dvgSubjectsList.Name = "dvgSubjectsList"
        Me.dvgSubjectsList.ReadOnly = True
        Me.dvgSubjectsList.RowHeadersWidth = 25
        Me.dvgSubjectsList.Size = New System.Drawing.Size(1116, 245)
        Me.dvgSubjectsList.TabIndex = 17
        '
        'ESSID
        '
        Me.ESSID.HeaderText = "ESSID"
        Me.ESSID.Name = "ESSID"
        Me.ESSID.ReadOnly = True
        Me.ESSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ESSID.Visible = False
        '
        'SubjNumber
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SubjNumber.DefaultCellStyle = DataGridViewCellStyle4
        Me.SubjNumber.HeaderText = "Section Code"
        Me.SubjNumber.Name = "SubjNumber"
        Me.SubjNumber.ReadOnly = True
        Me.SubjNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SubjNumber.Width = 75
        '
        'SubCode
        '
        Me.SubCode.HeaderText = "Subject Code"
        Me.SubCode.Name = "SubCode"
        Me.SubCode.ReadOnly = True
        Me.SubCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DescTitle
        '
        Me.DescTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescTitle.HeaderText = "Descriptive Title"
        Me.DescTitle.Name = "DescTitle"
        Me.DescTitle.ReadOnly = True
        Me.DescTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Time1
        '
        Me.Time1.HeaderText = "Time1"
        Me.Time1.Name = "Time1"
        Me.Time1.ReadOnly = True
        Me.Time1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Time1.Width = 135
        '
        'Day1
        '
        Me.Day1.HeaderText = "Day1"
        Me.Day1.Name = "Day1"
        Me.Day1.ReadOnly = True
        Me.Day1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Day1.Width = 55
        '
        'Room1
        '
        Me.Room1.HeaderText = "Room1"
        Me.Room1.Name = "Room1"
        Me.Room1.ReadOnly = True
        Me.Room1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Room1.Width = 75
        '
        'Time2
        '
        Me.Time2.HeaderText = "Time2"
        Me.Time2.Name = "Time2"
        Me.Time2.ReadOnly = True
        Me.Time2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Time2.Width = 135
        '
        'Day2
        '
        Me.Day2.HeaderText = "Day2"
        Me.Day2.Name = "Day2"
        Me.Day2.ReadOnly = True
        Me.Day2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Day2.Width = 55
        '
        'Room2
        '
        Me.Room2.HeaderText = "Room2"
        Me.Room2.Name = "Room2"
        Me.Room2.ReadOnly = True
        Me.Room2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Room2.Width = 75
        '
        'NumOfUnits
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N1"
        DataGridViewCellStyle5.NullValue = "0.0"
        Me.NumOfUnits.DefaultCellStyle = DataGridViewCellStyle5
        Me.NumOfUnits.HeaderText = "Units"
        Me.NumOfUnits.Name = "NumOfUnits"
        Me.NumOfUnits.ReadOnly = True
        Me.NumOfUnits.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NumOfUnits.Width = 65
        '
        'LabCode
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LabCode.DefaultCellStyle = DataGridViewCellStyle6
        Me.LabCode.HeaderText = "Lab. Code"
        Me.LabCode.Name = "LabCode"
        Me.LabCode.ReadOnly = True
        Me.LabCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.LabCode.Width = 65
        '
        'SubID
        '
        Me.SubID.HeaderText = "Subject ID"
        Me.SubID.Name = "SubID"
        Me.SubID.ReadOnly = True
        Me.SubID.Visible = False
        Me.SubID.Width = 65
        '
        'SOID
        '
        Me.SOID.HeaderText = "SOID"
        Me.SOID.Name = "SOID"
        Me.SOID.ReadOnly = True
        Me.SOID.Visible = False
        Me.SOID.Width = 65
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Appearance.Options.UseFont = True
        Me.cmdRemove.Image = CType(resources.GetObject("cmdRemove.Image"), System.Drawing.Image)
        Me.cmdRemove.Location = New System.Drawing.Point(14, 338)
        Me.cmdRemove.LookAndFeel.SkinName = "iMaginary"
        Me.cmdRemove.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(158, 31)
        Me.cmdRemove.TabIndex = 12
        Me.cmdRemove.TabStop = False
        Me.cmdRemove.Text = "Remove Selected[F6]"
        Me.cmdRemove.ToolTip = "Click to remove selected subject."
        '
        'chkCOR
        '
        Me.chkCOR.AutoSize = True
        Me.chkCOR.Checked = True
        Me.chkCOR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCOR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCOR.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkCOR.Location = New System.Drawing.Point(513, 61)
        Me.chkCOR.Name = "chkCOR"
        Me.chkCOR.Size = New System.Drawing.Size(88, 20)
        Me.chkCOR.TabIndex = 9
        Me.chkCOR.TabStop = False
        Me.chkCOR.Text = "Print COR"
        Me.ToolTipController1.SetTitle(Me.chkCOR, "Print COR")
        Me.ToolTipController1.SetToolTip(Me.chkCOR, "Check this box if you want to print COR.")
        Me.ToolTip1.SetToolTip(Me.chkCOR, "Check this box if you want to print COR.")
        Me.ToolTipController1.SetToolTipIconType(Me.chkCOR, DevExpress.Utils.ToolTipIconType.Information)
        Me.chkCOR.UseVisualStyleBackColor = True
        '
        'chkAllowConflict
        '
        Me.chkAllowConflict.AutoSize = True
        Me.chkAllowConflict.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllowConflict.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkAllowConflict.Location = New System.Drawing.Point(393, 61)
        Me.chkAllowConflict.Name = "chkAllowConflict"
        Me.chkAllowConflict.Size = New System.Drawing.Size(114, 20)
        Me.chkAllowConflict.TabIndex = 8
        Me.chkAllowConflict.TabStop = False
        Me.chkAllowConflict.Text = "Allow Conflict"
        Me.ToolTipController1.SetTitle(Me.chkAllowConflict, "Allow conflict.")
        Me.ToolTipController1.SetToolTip(Me.chkAllowConflict, "Check this box to allow conflict of schedules.")
        Me.ToolTipController1.SetToolTipIconType(Me.chkAllowConflict, DevExpress.Utils.ToolTipIconType.Information)
        Me.chkAllowConflict.UseVisualStyleBackColor = True
        '
        'cmdClearList
        '
        Me.cmdClearList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdClearList.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearList.Appearance.Options.UseFont = True
        Me.cmdClearList.Image = CType(resources.GetObject("cmdClearList.Image"), System.Drawing.Image)
        Me.cmdClearList.Location = New System.Drawing.Point(178, 338)
        Me.cmdClearList.LookAndFeel.SkinName = "iMaginary"
        Me.cmdClearList.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClearList.Name = "cmdClearList"
        Me.cmdClearList.Size = New System.Drawing.Size(139, 31)
        Me.cmdClearList.TabIndex = 13
        Me.cmdClearList.TabStop = False
        Me.cmdClearList.Text = "Clear List [F7]"
        Me.cmdClearList.ToolTip = "Click to clear list of subjects."
        '
        'txtSectionCode
        '
        Me.txtSectionCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSectionCode.Location = New System.Drawing.Point(122, 21)
        Me.txtSectionCode.Name = "txtSectionCode"
        Me.txtSectionCode.Size = New System.Drawing.Size(259, 27)
        Me.txtSectionCode.TabIndex = 1
        '
        'txtDummy
        '
        Me.txtDummy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDummy.Location = New System.Drawing.Point(307, 26)
        Me.txtDummy.Name = "txtDummy"
        Me.txtDummy.Size = New System.Drawing.Size(27, 21)
        Me.txtDummy.TabIndex = 2
        Me.txtDummy.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Maroon
        Me.lblError.Location = New System.Drawing.Point(390, 27)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(50, 16)
        Me.lblError.TabIndex = 3
        Me.lblError.Text = "Label1"
        Me.lblError.Visible = False
        '
        'cmdTestPrint
        '
        Me.cmdTestPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdTestPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestPrint.Appearance.Options.UseFont = True
        Me.cmdTestPrint.Image = CType(resources.GetObject("cmdTestPrint.Image"), System.Drawing.Image)
        Me.cmdTestPrint.Location = New System.Drawing.Point(278, 342)
        Me.cmdTestPrint.LookAndFeel.SkinName = "iMaginary"
        Me.cmdTestPrint.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdTestPrint.Name = "cmdTestPrint"
        Me.cmdTestPrint.Size = New System.Drawing.Size(10, 11)
        Me.cmdTestPrint.TabIndex = 14
        Me.cmdTestPrint.TabStop = False
        Me.cmdTestPrint.Text = "Print [F10]"
        '
        'cmdViewCourseOfferings
        '
        Me.cmdViewCourseOfferings.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewCourseOfferings.Appearance.Options.UseFont = True
        Me.cmdViewCourseOfferings.Image = CType(resources.GetObject("cmdViewCourseOfferings.Image"), System.Drawing.Image)
        Me.cmdViewCourseOfferings.Location = New System.Drawing.Point(210, 54)
        Me.cmdViewCourseOfferings.LookAndFeel.SkinName = "iMaginary"
        Me.cmdViewCourseOfferings.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdViewCourseOfferings.Name = "cmdViewCourseOfferings"
        Me.cmdViewCourseOfferings.Size = New System.Drawing.Size(171, 27)
        Me.cmdViewCourseOfferings.TabIndex = 7
        Me.cmdViewCourseOfferings.TabStop = False
        Me.cmdViewCourseOfferings.Text = "View Course Offerings"
        Me.ToolTip1.SetToolTip(Me.cmdViewCourseOfferings, "Click to view course offerings.")
        Me.cmdViewCourseOfferings.ToolTip = "Click to view course offerings."
        Me.cmdViewCourseOfferings.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdViewCourseOfferings.ToolTipTitle = "View Course Offerings."
        '
        'KryptonHeader8
        '
        Me.KryptonHeader8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeader8.AutoSize = False
        Me.KryptonHeader8.Location = New System.Drawing.Point(837, 338)
        Me.KryptonHeader8.Name = "KryptonHeader8"
        Me.KryptonHeader8.Size = New System.Drawing.Size(99, 35)
        Me.KryptonHeader8.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader8.StateNormal.Border.Rounding = 0
        Me.KryptonHeader8.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader8.TabIndex = 15
        Me.KryptonHeader8.Text = "Total Units:"
        Me.KryptonHeader8.Values.Description = ""
        Me.KryptonHeader8.Values.Heading = "Total Units:"
        Me.KryptonHeader8.Values.Image = Nothing
        '
        'cmdBlock
        '
        Me.cmdBlock.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBlock.Appearance.Options.UseFont = True
        Me.cmdBlock.Image = CType(resources.GetObject("cmdBlock.Image"), System.Drawing.Image)
        Me.cmdBlock.Location = New System.Drawing.Point(112, 54)
        Me.cmdBlock.LookAndFeel.SkinName = "iMaginary"
        Me.cmdBlock.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdBlock.Name = "cmdBlock"
        Me.cmdBlock.Size = New System.Drawing.Size(92, 27)
        Me.cmdBlock.TabIndex = 6
        Me.cmdBlock.TabStop = False
        Me.cmdBlock.Text = "Block[F3]"
        Me.cmdBlock.ToolTip = "Click to select block sections."
        Me.cmdBlock.ToolTipController = Me.ToolTipController1
        Me.cmdBlock.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdBlock.ToolTipTitle = "Block Sections"
        '
        'ToolTipController1
        '
        Me.ToolTipController1.Rounded = True
        '
        'KryptonHeader7
        '
        Me.KryptonHeader7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.KryptonHeader7.AutoSize = False
        Me.KryptonHeader7.Location = New System.Drawing.Point(974, 47)
        Me.KryptonHeader7.Name = "KryptonHeader7"
        Me.KryptonHeader7.Size = New System.Drawing.Size(156, 27)
        Me.KryptonHeader7.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader7.StateNormal.Border.Rounding = 0
        Me.KryptonHeader7.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader7.TabIndex = 10
        Me.KryptonHeader7.TabStop = False
        Me.KryptonHeader7.Text = "Subjects List:"
        Me.KryptonHeader7.Values.Description = ""
        Me.KryptonHeader7.Values.Heading = "Subjects List:"
        Me.KryptonHeader7.Values.Image = Nothing
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(13, 54)
        Me.cmdAdd.LookAndFeel.SkinName = "iMaginary"
        Me.cmdAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(92, 27)
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.TabStop = False
        Me.cmdAdd.Text = "Add [F2]"
        '
        'cboSubjects
        '
        Me.cboSubjects.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubjects.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubjects.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubjects.FormattingEnabled = True
        Me.cboSubjects.Location = New System.Drawing.Point(1060, 16)
        Me.cboSubjects.Name = "cboSubjects"
        Me.cboSubjects.Size = New System.Drawing.Size(70, 27)
        Me.cboSubjects.TabIndex = 4
        Me.cboSubjects.Visible = False
        '
        'KryptonHeader6
        '
        Me.KryptonHeader6.AutoSize = False
        Me.KryptonHeader6.Location = New System.Drawing.Point(12, 21)
        Me.KryptonHeader6.Name = "KryptonHeader6"
        Me.KryptonHeader6.Size = New System.Drawing.Size(120, 27)
        Me.KryptonHeader6.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader6.StateNormal.Border.Rounding = 5
        Me.KryptonHeader6.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader6.TabIndex = 0
        Me.KryptonHeader6.Text = "Section Code:"
        Me.KryptonHeader6.Values.Description = ""
        Me.KryptonHeader6.Values.Heading = "Section Code:"
        Me.KryptonHeader6.Values.Image = Nothing
        '
        'lblTotUnits
        '
        Me.lblTotUnits.AutoSize = False
        Me.lblTotUnits.Location = New System.Drawing.Point(554, 711)
        Me.lblTotUnits.Name = "lblTotUnits"
        Me.lblTotUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotUnits.Size = New System.Drawing.Size(140, 10)
        Me.lblTotUnits.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.lblTotUnits.StateNormal.Border.Rounding = 0
        Me.lblTotUnits.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotUnits.TabIndex = 16
        Me.lblTotUnits.Text = "0.0"
        Me.lblTotUnits.Values.Description = "Description"
        Me.lblTotUnits.Values.Heading = "0.0"
        Me.lblTotUnits.Values.Image = Nothing
        '
        'ErrProve
        '
        Me.ErrProve.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProve.ContainerControl = Me
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Appearance.Options.UseFont = True
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(1024, 686)
        Me.cmdExit.LookAndFeel.SkinName = "iMaginary"
        Me.cmdExit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(111, 35)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.TabStop = False
        Me.cmdExit.Text = "Close [Esc]"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(907, 686)
        Me.cmdSave.LookAndFeel.SkinName = "iMaginary"
        Me.cmdSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 35)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.TabStop = False
        Me.cmdSave.Text = "Save [F5]"
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHelp.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Appearance.Options.UseFont = True
        Me.cmdHelp.Image = CType(resources.GetObject("cmdHelp.Image"), System.Drawing.Image)
        Me.cmdHelp.Location = New System.Drawing.Point(811, 686)
        Me.cmdHelp.LookAndFeel.SkinName = "iMaginary"
        Me.cmdHelp.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(90, 35)
        Me.cmdHelp.TabIndex = 8
        Me.cmdHelp.TabStop = False
        Me.cmdHelp.Text = "Help [F1]"
        Me.cmdHelp.ToolTip = "Click me to view help in using the window."
        Me.cmdHelp.ToolTipTitle = "Help for this window."
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(700, 686)
        Me.cmdSearch.LookAndFeel.SkinName = "iMaginary"
        Me.cmdSearch.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(105, 35)
        Me.cmdSearch.TabIndex = 9
        Me.cmdSearch.TabStop = False
        Me.cmdSearch.Text = "Search [F4]"
        Me.cmdSearch.ToolTip = "Click to search for student."
        Me.cmdSearch.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdSearch.ToolTipTitle = "Search student"
        '
        'lblNSTP
        '
        Me.lblNSTP.AutoSize = False
        Me.lblNSTP.Location = New System.Drawing.Point(408, 711)
        Me.lblNSTP.Name = "lblNSTP"
        Me.lblNSTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNSTP.Size = New System.Drawing.Size(140, 10)
        Me.lblNSTP.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.lblNSTP.StateNormal.Border.Rounding = 0
        Me.lblNSTP.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNSTP.TabIndex = 17
        Me.lblNSTP.Text = "0.0"
        Me.lblNSTP.Values.Description = "Description"
        Me.lblNSTP.Values.Heading = "0.0"
        Me.lblNSTP.Values.Image = Nothing
        '
        'dvgSemestralFees
        '
        Me.dvgSemestralFees.AllowUserToAddRows = False
        Me.dvgSemestralFees.AllowUserToDeleteRows = False
        Me.dvgSemestralFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgSemestralFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SFID, Me.FNID, Me.FeeCategory, Me.FeeName, Me.FeeAmount})
        Me.dvgSemestralFees.Location = New System.Drawing.Point(13, 640)
        Me.dvgSemestralFees.Name = "dvgSemestralFees"
        Me.dvgSemestralFees.ReadOnly = True
        Me.dvgSemestralFees.Size = New System.Drawing.Size(619, 71)
        Me.dvgSemestralFees.TabIndex = 19
        '
        'SFID
        '
        Me.SFID.HeaderText = "SFID"
        Me.SFID.Name = "SFID"
        Me.SFID.ReadOnly = True
        '
        'FNID
        '
        Me.FNID.HeaderText = "FNID"
        Me.FNID.Name = "FNID"
        Me.FNID.ReadOnly = True
        '
        'FeeCategory
        '
        Me.FeeCategory.HeaderText = "Fee Cat"
        Me.FeeCategory.Name = "FeeCategory"
        Me.FeeCategory.ReadOnly = True
        '
        'FeeName
        '
        Me.FeeName.HeaderText = "Fee Name"
        Me.FeeName.Name = "FeeName"
        Me.FeeName.ReadOnly = True
        '
        'FeeAmount
        '
        Me.FeeAmount.HeaderText = "Amount"
        Me.FeeAmount.Name = "FeeAmount"
        Me.FeeAmount.ReadOnly = True
        '
        'frmRegisterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1140, 746)
        Me.Controls.Add(Me.dvgSemestralFees)
        Me.Controls.Add(Me.lblNSTP)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblTotUnits)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRegisterStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enrollment Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dvgFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dvgSubjectsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgSemestralFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblHeader As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHRMFund As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader24 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtIsEnrolled As System.Windows.Forms.TextBox
    Friend WithEvents txtCooking As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader23 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cmdViewFees As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDegree As System.Windows.Forms.TextBox
    Friend WithEvents txtAddCharges As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader22 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtBackAccount As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader21 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader20 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtLess As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader18 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader19 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader17 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtOtherFees As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader16 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtMatFee As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader15 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtLabFee As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader14 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtPremium As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader13 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtTuition As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader12 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader11 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents dtpAssessed As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnrolled As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonHeader10 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader9 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtPayments As System.Windows.Forms.TextBox
    Friend WithEvents lblPayments As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader5 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader4 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtEDP As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkCOR As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowConflict As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClearList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSectionCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDummy As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents cmdTestPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdViewCourseOfferings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KryptonHeader8 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents lblTotUnits As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cmdBlock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KryptonHeader7 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSubjects As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader6 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ErrProve As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader25 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdHelp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvgSubjectsList As System.Windows.Forms.DataGridView
    Friend WithEvents dvgFees As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ESSID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Time1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Time2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumOfUnits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdChangeCourse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTotUnitsDisplay As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents lblNSTP As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cmdViewRecords As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dvgSemestralFees As System.Windows.Forms.DataGridView
    Friend WithEvents SFID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeAmount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
