<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditCashiering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditCashiering))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDept = New System.Windows.Forms.TextBox
        Me.KryptonHeader25 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cmdViewFees = New DevExpress.XtraEditors.SimpleButton
        Me.txtAddCharges = New System.Windows.Forms.TextBox
        Me.txtSex = New System.Windows.Forms.TextBox
        Me.KryptonHeader11 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
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
        Me.txtHRMFund = New System.Windows.Forms.TextBox
        Me.txtCooking = New System.Windows.Forms.TextBox
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.KryptonHeader6 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtAmountPaid = New System.Windows.Forms.TextBox
        Me.txtTendered = New System.Windows.Forms.TextBox
        Me.KryptonHeader7 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader8 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboFor = New System.Windows.Forms.ComboBox
        Me.txtChange = New System.Windows.Forms.TextBox
        Me.KryptonHeader9 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtOR = New System.Windows.Forms.TextBox
        Me.KryptonHeader10 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader12 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.PaymentGrid = New System.Windows.Forms.DataGridView
        Me.paymentID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.paymentname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amountpaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaidAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalAfter = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.KryptonHeader13 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PaymentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 709)
        Me.StatusStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1178, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(257, 17)
        Me.ToolStripStatusLabel1.Text = " School Management System - Cashiering"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDept)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader25)
        Me.GroupBox1.Controls.Add(Me.cmdViewFees)
        Me.GroupBox1.Controls.Add(Me.txtAddCharges)
        Me.GroupBox1.Controls.Add(Me.txtSex)
        Me.GroupBox1.Controls.Add(Me.KryptonHeader11)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1076, 103)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Student/Type Name"
        '
        'txtDept
        '
        Me.txtDept.AutoCompleteCustomSource.AddRange(New String() {"MALE", "FEMALE"})
        Me.txtDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDept.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDept.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.Location = New System.Drawing.Point(122, 171)
        Me.txtDept.MaxLength = 6
        Me.txtDept.Name = "txtDept"
        Me.txtDept.ReadOnly = True
        Me.txtDept.Size = New System.Drawing.Size(89, 27)
        Me.txtDept.TabIndex = 13
        Me.txtDept.TabStop = False
        Me.txtDept.Visible = False
        '
        'KryptonHeader25
        '
        Me.KryptonHeader25.AutoSize = False
        Me.KryptonHeader25.Location = New System.Drawing.Point(14, 171)
        Me.KryptonHeader25.Name = "KryptonHeader25"
        Me.KryptonHeader25.Size = New System.Drawing.Size(116, 27)
        Me.KryptonHeader25.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader25.StateNormal.Border.Rounding = 0
        Me.KryptonHeader25.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader25.TabIndex = 12
        Me.KryptonHeader25.Text = "Dept:"
        Me.KryptonHeader25.Values.Description = ""
        Me.KryptonHeader25.Values.Heading = "Dept:"
        Me.KryptonHeader25.Values.Image = Nothing
        Me.KryptonHeader25.Visible = False
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
        Me.cmdViewFees.TabIndex = 0
        Me.cmdViewFees.TabStop = False
        Me.cmdViewFees.Text = "View Rate of Fees"
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
        'txtSex
        '
        Me.txtSex.AutoCompleteCustomSource.AddRange(New String() {"MALE", "FEMALE"})
        Me.txtSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSex.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtSex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSex.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(280, 138)
        Me.txtSex.MaxLength = 6
        Me.txtSex.Name = "txtSex"
        Me.txtSex.ReadOnly = True
        Me.txtSex.Size = New System.Drawing.Size(140, 27)
        Me.txtSex.TabIndex = 11
        Me.txtSex.TabStop = False
        Me.txtSex.Visible = False
        '
        'KryptonHeader11
        '
        Me.KryptonHeader11.AutoSize = False
        Me.KryptonHeader11.Location = New System.Drawing.Point(217, 138)
        Me.KryptonHeader11.Name = "KryptonHeader11"
        Me.KryptonHeader11.Size = New System.Drawing.Size(91, 27)
        Me.KryptonHeader11.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader11.StateNormal.Border.Rounding = 0
        Me.KryptonHeader11.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader11.TabIndex = 10
        Me.KryptonHeader11.Text = "Sex:"
        Me.KryptonHeader11.Values.Description = ""
        Me.KryptonHeader11.Values.Heading = "Sex:"
        Me.KryptonHeader11.Values.Image = Nothing
        Me.KryptonHeader11.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.AutoCompleteCustomSource.AddRange(New String() {"New", "Old", "Returnee"})
        Me.txtStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(122, 138)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(89, 27)
        Me.txtStatus.TabIndex = 7
        Me.txtStatus.TabStop = False
        Me.txtStatus.Visible = False
        '
        'KryptonHeader5
        '
        Me.KryptonHeader5.AutoSize = False
        Me.KryptonHeader5.Location = New System.Drawing.Point(14, 138)
        Me.KryptonHeader5.Name = "KryptonHeader5"
        Me.KryptonHeader5.Size = New System.Drawing.Size(116, 27)
        Me.KryptonHeader5.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader5.StateNormal.Border.Rounding = 5
        Me.KryptonHeader5.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader5.TabIndex = 6
        Me.KryptonHeader5.Text = "Status:"
        Me.KryptonHeader5.Values.Description = ""
        Me.KryptonHeader5.Values.Heading = "Status:"
        Me.KryptonHeader5.Values.Image = Nothing
        Me.KryptonHeader5.Visible = False
        '
        'txtCourse
        '
        Me.txtCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCourse.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourse.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(122, 108)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(298, 27)
        Me.txtCourse.TabIndex = 9
        Me.txtCourse.TabStop = False
        Me.txtCourse.Visible = False
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.AutoSize = False
        Me.KryptonHeader4.Location = New System.Drawing.Point(13, 108)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(140, 27)
        Me.KryptonHeader4.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader4.StateNormal.Border.Rounding = 5
        Me.KryptonHeader4.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader4.TabIndex = 8
        Me.KryptonHeader4.Text = "Course:"
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "Course:"
        Me.KryptonHeader4.Values.Image = Nothing
        Me.KryptonHeader4.Visible = False
        '
        'txtYear
        '
        Me.txtYear.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5"})
        Me.txtYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtYear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(280, 171)
        Me.txtYear.MaxLength = 1
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(140, 27)
        Me.txtYear.TabIndex = 5
        Me.txtYear.TabStop = False
        Me.txtYear.Visible = False
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.Location = New System.Drawing.Point(217, 171)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(88, 27)
        Me.KryptonHeader3.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader3.StateNormal.Border.Rounding = 5
        Me.KryptonHeader3.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader3.TabIndex = 4
        Me.KryptonHeader3.Text = "Year:"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Year:"
        Me.KryptonHeader3.Values.Image = Nothing
        Me.KryptonHeader3.Visible = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(122, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(389, 27)
        Me.txtName.TabIndex = 3
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
        Me.KryptonHeader1.TabIndex = 2
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
        Me.txtEDP.Size = New System.Drawing.Size(389, 27)
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
        'txtHRMFund
        '
        Me.txtHRMFund.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtHRMFund.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHRMFund.Location = New System.Drawing.Point(1036, 141)
        Me.txtHRMFund.Name = "txtHRMFund"
        Me.txtHRMFund.ReadOnly = True
        Me.txtHRMFund.Size = New System.Drawing.Size(10, 22)
        Me.txtHRMFund.TabIndex = 37
        Me.txtHRMFund.TabStop = False
        Me.txtHRMFund.Text = "0.00"
        Me.txtHRMFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHRMFund.Visible = False
        '
        'txtCooking
        '
        Me.txtCooking.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCooking.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCooking.Location = New System.Drawing.Point(1020, 139)
        Me.txtCooking.Name = "txtCooking"
        Me.txtCooking.ReadOnly = True
        Me.txtCooking.Size = New System.Drawing.Size(10, 22)
        Me.txtCooking.TabIndex = 39
        Me.txtCooking.TabStop = False
        Me.txtCooking.Text = "0.00"
        Me.txtCooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCooking.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(937, 651)
        Me.cmdSave.LookAndFeel.SkinName = "iMaginary"
        Me.cmdSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 32)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.TabStop = False
        Me.cmdSave.Text = "Save [F2]"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(1054, 651)
        Me.cmdCancel.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 32)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.TabStop = False
        Me.cmdCancel.Text = "Cancel [Esc]"
        '
        'KryptonHeader6
        '
        Me.KryptonHeader6.AutoSize = False
        Me.KryptonHeader6.Location = New System.Drawing.Point(836, 171)
        Me.KryptonHeader6.Name = "KryptonHeader6"
        Me.KryptonHeader6.Size = New System.Drawing.Size(164, 33)
        Me.KryptonHeader6.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader6.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader6.StateNormal.Border.Rounding = 5
        Me.KryptonHeader6.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader6.TabIndex = 5
        Me.KryptonHeader6.Text = "Amount Paid:"
        Me.KryptonHeader6.Values.Description = ""
        Me.KryptonHeader6.Values.Heading = "Amount Paid:"
        Me.KryptonHeader6.Values.Image = Nothing
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.AutoCompleteCustomSource.AddRange(New String() {"New", "Old", "Returnee"})
        Me.txtAmountPaid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAmountPaid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAmountPaid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmountPaid.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(965, 171)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.ReadOnly = True
        Me.txtAmountPaid.Size = New System.Drawing.Size(201, 33)
        Me.txtAmountPaid.TabIndex = 6
        Me.txtAmountPaid.TabStop = False
        Me.txtAmountPaid.Text = "0.00"
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTendered
        '
        Me.txtTendered.AutoCompleteCustomSource.AddRange(New String() {"New", "Old", "Returnee"})
        Me.txtTendered.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTendered.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTendered.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTendered.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTendered.Location = New System.Drawing.Point(965, 210)
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Size = New System.Drawing.Size(201, 33)
        Me.txtTendered.TabIndex = 8
        Me.txtTendered.Text = "0.00"
        Me.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader7
        '
        Me.KryptonHeader7.AutoSize = False
        Me.KryptonHeader7.Location = New System.Drawing.Point(836, 210)
        Me.KryptonHeader7.Name = "KryptonHeader7"
        Me.KryptonHeader7.Size = New System.Drawing.Size(164, 33)
        Me.KryptonHeader7.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader7.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader7.StateNormal.Border.Rounding = 5
        Me.KryptonHeader7.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader7.TabIndex = 7
        Me.KryptonHeader7.Text = "Tendered:"
        Me.KryptonHeader7.Values.Description = ""
        Me.KryptonHeader7.Values.Heading = "Tendered:"
        Me.KryptonHeader7.Values.Image = Nothing
        '
        'KryptonHeader8
        '
        Me.KryptonHeader8.AutoSize = False
        Me.KryptonHeader8.Location = New System.Drawing.Point(12, 577)
        Me.KryptonHeader8.Name = "KryptonHeader8"
        Me.KryptonHeader8.Size = New System.Drawing.Size(197, 50)
        Me.KryptonHeader8.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader8.StateNormal.Border.Rounding = 5
        Me.KryptonHeader8.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader8.TabIndex = 0
        Me.KryptonHeader8.Text = "Payment For:"
        Me.KryptonHeader8.Values.Description = ""
        Me.KryptonHeader8.Values.Heading = "Payment For:"
        Me.KryptonHeader8.Values.Image = Nothing
        Me.KryptonHeader8.Visible = False
        '
        'cboFor
        '
        Me.cboFor.AutoCompleteCustomSource.AddRange(New String() {"TUITION", "OTHERS"})
        Me.cboFor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFor.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFor.FormattingEnabled = True
        Me.cboFor.Items.AddRange(New Object() {"Tuition", "Others"})
        Me.cboFor.Location = New System.Drawing.Point(114, 577)
        Me.cboFor.Name = "cboFor"
        Me.cboFor.Size = New System.Drawing.Size(364, 50)
        Me.cboFor.TabIndex = 1
        Me.cboFor.Visible = False
        '
        'txtChange
        '
        Me.txtChange.AutoCompleteCustomSource.AddRange(New String() {"New", "Old", "Returnee"})
        Me.txtChange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtChange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtChange.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChange.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(965, 252)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(201, 33)
        Me.txtChange.TabIndex = 10
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader9
        '
        Me.KryptonHeader9.AutoSize = False
        Me.KryptonHeader9.Location = New System.Drawing.Point(836, 252)
        Me.KryptonHeader9.Name = "KryptonHeader9"
        Me.KryptonHeader9.Size = New System.Drawing.Size(164, 33)
        Me.KryptonHeader9.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader9.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader9.StateNormal.Border.Rounding = 5
        Me.KryptonHeader9.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader9.TabIndex = 9
        Me.KryptonHeader9.Text = "Change:"
        Me.KryptonHeader9.Values.Description = ""
        Me.KryptonHeader9.Values.Heading = "Change:"
        Me.KryptonHeader9.Values.Image = Nothing
        '
        'txtOR
        '
        Me.txtOR.AutoCompleteCustomSource.AddRange(New String() {"New", "Old", "Returnee"})
        Me.txtOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOR.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOR.Location = New System.Drawing.Point(965, 130)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(201, 33)
        Me.txtOR.TabIndex = 4
        '
        'KryptonHeader10
        '
        Me.KryptonHeader10.AutoSize = False
        Me.KryptonHeader10.Location = New System.Drawing.Point(836, 130)
        Me.KryptonHeader10.Name = "KryptonHeader10"
        Me.KryptonHeader10.Size = New System.Drawing.Size(164, 33)
        Me.KryptonHeader10.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader10.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader10.StateNormal.Border.Rounding = 5
        Me.KryptonHeader10.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader10.TabIndex = 3
        Me.KryptonHeader10.Text = "OR Number:"
        Me.KryptonHeader10.Values.Description = ""
        Me.KryptonHeader10.Values.Heading = "OR Number:"
        Me.KryptonHeader10.Values.Image = Nothing
        '
        'KryptonHeader12
        '
        Me.KryptonHeader12.AutoSize = False
        Me.KryptonHeader12.Location = New System.Drawing.Point(26, 510)
        Me.KryptonHeader12.Name = "KryptonHeader12"
        Me.KryptonHeader12.Size = New System.Drawing.Size(466, 50)
        Me.KryptonHeader12.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader12.StateNormal.Border.Rounding = 5
        Me.KryptonHeader12.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader12.TabIndex = 11
        Me.KryptonHeader12.Text = "Select For Other Payments:"
        Me.KryptonHeader12.Values.Description = ""
        Me.KryptonHeader12.Values.Heading = "Select For Other Payments:"
        Me.KryptonHeader12.Values.Image = Nothing
        Me.KryptonHeader12.Visible = False
        '
        'PaymentGrid
        '
        Me.PaymentGrid.AllowUserToAddRows = False
        Me.PaymentGrid.AllowUserToDeleteRows = False
        Me.PaymentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.paymentID, Me.paymentname, Me.balance, Me.amountpaid, Me.remarks, Me.PaidAmount, Me.BalAfter})
        Me.PaymentGrid.Location = New System.Drawing.Point(12, 131)
        Me.PaymentGrid.Name = "PaymentGrid"
        Me.PaymentGrid.RowHeadersWidth = 22
        Me.PaymentGrid.Size = New System.Drawing.Size(808, 510)
        Me.PaymentGrid.TabIndex = 14
        '
        'paymentID
        '
        Me.paymentID.HeaderText = "paymentID"
        Me.paymentID.Name = "paymentID"
        Me.paymentID.ReadOnly = True
        Me.paymentID.Visible = False
        '
        'paymentname
        '
        Me.paymentname.HeaderText = "Payment Name"
        Me.paymentname.Name = "paymentname"
        Me.paymentname.ReadOnly = True
        Me.paymentname.Width = 150
        '
        'balance
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.balance.DefaultCellStyle = DataGridViewCellStyle1
        Me.balance.HeaderText = "Amount"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 125
        '
        'amountpaid
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.amountpaid.DefaultCellStyle = DataGridViewCellStyle2
        Me.amountpaid.HeaderText = "Total Paid"
        Me.amountpaid.Name = "amountpaid"
        Me.amountpaid.ReadOnly = True
        Me.amountpaid.Width = 125
        '
        'remarks
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.remarks.DefaultCellStyle = DataGridViewCellStyle3
        Me.remarks.HeaderText = "Current Balance"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        Me.remarks.Width = 125
        '
        'PaidAmount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.PaidAmount.DefaultCellStyle = DataGridViewCellStyle4
        Me.PaidAmount.HeaderText = "Paid Amount"
        Me.PaidAmount.Name = "PaidAmount"
        Me.PaidAmount.Width = 125
        '
        'BalAfter
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.BalAfter.DefaultCellStyle = DataGridViewCellStyle5
        Me.BalAfter.HeaderText = "Balance After Payment"
        Me.BalAfter.Name = "BalAfter"
        Me.BalAfter.ReadOnly = True
        Me.BalAfter.Width = 125
        '
        'txtbalance
        '
        Me.txtbalance.AutoCompleteCustomSource.AddRange(New String() {"New", "Old", "Returnee"})
        Me.txtbalance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtbalance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtbalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbalance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(425, 651)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.ReadOnly = True
        Me.txtbalance.Size = New System.Drawing.Size(395, 33)
        Me.txtbalance.TabIndex = 15
        Me.txtbalance.Text = "0.00"
        Me.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonHeader13
        '
        Me.KryptonHeader13.AutoSize = False
        Me.KryptonHeader13.Location = New System.Drawing.Point(235, 651)
        Me.KryptonHeader13.Name = "KryptonHeader13"
        Me.KryptonHeader13.Size = New System.Drawing.Size(197, 33)
        Me.KryptonHeader13.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader13.StateNormal.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader13.StateNormal.Border.Rounding = 5
        Me.KryptonHeader13.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader13.TabIndex = 16
        Me.KryptonHeader13.Text = "Remaining Balance:"
        Me.KryptonHeader13.Values.Description = ""
        Me.KryptonHeader13.Values.Heading = "Remaining Balance:"
        Me.KryptonHeader13.Values.Image = Nothing
        '
        'frmAddEditCashiering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1178, 731)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.KryptonHeader13)
        Me.Controls.Add(Me.PaymentGrid)
        Me.Controls.Add(Me.KryptonHeader12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtOR)
        Me.Controls.Add(Me.KryptonHeader10)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.KryptonHeader9)
        Me.Controls.Add(Me.cboFor)
        Me.Controls.Add(Me.KryptonHeader8)
        Me.Controls.Add(Me.txtTendered)
        Me.Controls.Add(Me.KryptonHeader7)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.KryptonHeader6)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtCooking)
        Me.Controls.Add(Me.txtHRMFund)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditCashiering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashiering"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PaymentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader25 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtHRMFund As System.Windows.Forms.TextBox
    Friend WithEvents txtCooking As System.Windows.Forms.TextBox
    Friend WithEvents cmdViewFees As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAddCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader11 As ComponentFactory.Krypton.Toolkit.KryptonHeader
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
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KryptonHeader6 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents txtTendered As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader7 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader8 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboFor As System.Windows.Forms.ComboBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader9 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtOR As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader10 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader12 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents PaymentGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader13 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents paymentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paymentname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amountpaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalAfter As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
