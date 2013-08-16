<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditAdmission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditAdmission))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtEDPNumber = New System.Windows.Forms.TextBox
        Me.KryptonHeader11 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.lblHeader = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ErrProve = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtMiddle = New System.Windows.Forms.TextBox
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker
        Me.KryptonHeader6 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboCivilStatus = New System.Windows.Forms.ComboBox
        Me.KryptonHeader5 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboGender = New System.Windows.Forms.ComboBox
        Me.KryptonHeader4 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtPAddress = New System.Windows.Forms.TextBox
        Me.KryptonHeader10 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtHAdress = New System.Windows.Forms.TextBox
        Me.KryptonHeader7 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCapture = New DevExpress.XtraEditors.SimpleButton
        Me.cmdLoadFromFile = New DevExpress.XtraEditors.SimpleButton
        Me.PicImage = New System.Windows.Forms.PictureBox
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.KryptonHeader8 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtContactPersonNumber = New System.Windows.Forms.TextBox
        Me.KryptonHeader9 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtContactPersonName = New System.Windows.Forms.TextBox
        Me.KryptonHeader12 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.KryptonHeader13 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 513)
        Me.StatusStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(756, 22)
        Me.StatusStrip1.TabIndex = 31
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = " ToolStripStatusLabel1"
        '
        'txtEDPNumber
        '
        Me.txtEDPNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEDPNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEDPNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEDPNumber.Location = New System.Drawing.Point(141, 62)
        Me.txtEDPNumber.Name = "txtEDPNumber"
        Me.txtEDPNumber.ReadOnly = True
        Me.txtEDPNumber.Size = New System.Drawing.Size(289, 23)
        Me.txtEDPNumber.TabIndex = 2
        Me.txtEDPNumber.TabStop = False
        '
        'KryptonHeader11
        '
        Me.KryptonHeader11.AutoSize = False
        Me.KryptonHeader11.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader11.Location = New System.Drawing.Point(12, 62)
        Me.KryptonHeader11.Name = "KryptonHeader11"
        Me.KryptonHeader11.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader11.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader11.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader11.TabIndex = 1
        Me.KryptonHeader11.Text = "EDP Number:"
        Me.KryptonHeader11.Values.Description = ""
        Me.KryptonHeader11.Values.Heading = "EDP Number:"
        Me.KryptonHeader11.Values.Image = Nothing
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(141, 91)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(289, 23)
        Me.txtLastName.TabIndex = 4
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AutoSize = False
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(12, 91)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader1.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader1.TabIndex = 3
        Me.KryptonHeader1.Text = "Last Name:"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Last Name:"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(202, 458)
        Me.cmdSave.LookAndFeel.SkinName = "iMaginary"
        Me.cmdSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 32)
        Me.cmdSave.TabIndex = 26
        Me.cmdSave.TabStop = False
        Me.cmdSave.Text = "Save [F2]"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(319, 458)
        Me.cmdCancel.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 32)
        Me.cmdCancel.TabIndex = 27
        Me.cmdCancel.TabStop = False
        Me.cmdCancel.Text = "Cancel [Esc]"
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.AutoSize = False
        Me.lblHeader.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.lblHeader.Location = New System.Drawing.Point(12, 22)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(710, 23)
        Me.lblHeader.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.lblHeader.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Sign In"
        Me.lblHeader.Values.Description = ""
        Me.lblHeader.Values.Heading = "Sign In"
        Me.lblHeader.Values.Image = Nothing
        '
        'ErrProve
        '
        Me.ErrProve.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrProve.ContainerControl = Me
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(141, 120)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(289, 23)
        Me.txtFirstName.TabIndex = 6
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.AutoSize = False
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(12, 120)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader2.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader2.TabIndex = 5
        Me.KryptonHeader2.Text = "First Name:"
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "First Name:"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'txtMiddle
        '
        Me.txtMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMiddle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddle.Location = New System.Drawing.Point(141, 149)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.Size = New System.Drawing.Size(289, 23)
        Me.txtMiddle.TabIndex = 8
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader3.Location = New System.Drawing.Point(12, 149)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader3.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader3.TabIndex = 7
        Me.KryptonHeader3.Text = "Middle Name:"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Middle Name:"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'dtpBirth
        '
        Me.dtpBirth.CustomFormat = "MMM/dd/yyyy"
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirth.Location = New System.Drawing.Point(141, 238)
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.Size = New System.Drawing.Size(289, 23)
        Me.dtpBirth.TabIndex = 14
        '
        'KryptonHeader6
        '
        Me.KryptonHeader6.AutoSize = False
        Me.KryptonHeader6.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader6.Location = New System.Drawing.Point(12, 238)
        Me.KryptonHeader6.Name = "KryptonHeader6"
        Me.KryptonHeader6.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader6.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader6.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader6.TabIndex = 13
        Me.KryptonHeader6.Text = "Date of Birth:"
        Me.KryptonHeader6.Values.Description = ""
        Me.KryptonHeader6.Values.Heading = "Date of Birth:"
        Me.KryptonHeader6.Values.Image = Nothing
        '
        'cboCivilStatus
        '
        Me.cboCivilStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCivilStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCivilStatus.FormattingEnabled = True
        Me.cboCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widow"})
        Me.cboCivilStatus.Location = New System.Drawing.Point(141, 208)
        Me.cboCivilStatus.Name = "cboCivilStatus"
        Me.cboCivilStatus.Size = New System.Drawing.Size(289, 24)
        Me.cboCivilStatus.TabIndex = 12
        '
        'KryptonHeader5
        '
        Me.KryptonHeader5.AutoSize = False
        Me.KryptonHeader5.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader5.Location = New System.Drawing.Point(12, 208)
        Me.KryptonHeader5.Name = "KryptonHeader5"
        Me.KryptonHeader5.Size = New System.Drawing.Size(186, 24)
        Me.KryptonHeader5.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader5.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader5.TabIndex = 11
        Me.KryptonHeader5.Text = "Civil Status:"
        Me.KryptonHeader5.Values.Description = ""
        Me.KryptonHeader5.Values.Heading = "Civil Status:"
        Me.KryptonHeader5.Values.Image = Nothing
        '
        'cboGender
        '
        Me.cboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(141, 178)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(289, 24)
        Me.cboGender.TabIndex = 10
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.AutoSize = False
        Me.KryptonHeader4.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader4.Location = New System.Drawing.Point(12, 178)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(186, 24)
        Me.KryptonHeader4.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader4.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader4.TabIndex = 9
        Me.KryptonHeader4.Text = "Gender:"
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "Gender:"
        Me.KryptonHeader4.Values.Image = Nothing
        '
        'txtPAddress
        '
        Me.txtPAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAddress.Location = New System.Drawing.Point(141, 267)
        Me.txtPAddress.Name = "txtPAddress"
        Me.txtPAddress.Size = New System.Drawing.Size(289, 23)
        Me.txtPAddress.TabIndex = 16
        '
        'KryptonHeader10
        '
        Me.KryptonHeader10.AutoSize = False
        Me.KryptonHeader10.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader10.Location = New System.Drawing.Point(12, 267)
        Me.KryptonHeader10.Name = "KryptonHeader10"
        Me.KryptonHeader10.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader10.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader10.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader10.TabIndex = 15
        Me.KryptonHeader10.Text = "Present Address:"
        Me.KryptonHeader10.Values.Description = ""
        Me.KryptonHeader10.Values.Heading = "Present Address:"
        Me.KryptonHeader10.Values.Image = Nothing
        '
        'txtHAdress
        '
        Me.txtHAdress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHAdress.Location = New System.Drawing.Point(141, 296)
        Me.txtHAdress.Name = "txtHAdress"
        Me.txtHAdress.Size = New System.Drawing.Size(289, 23)
        Me.txtHAdress.TabIndex = 18
        '
        'KryptonHeader7
        '
        Me.KryptonHeader7.AutoSize = False
        Me.KryptonHeader7.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader7.Location = New System.Drawing.Point(12, 296)
        Me.KryptonHeader7.Name = "KryptonHeader7"
        Me.KryptonHeader7.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader7.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader7.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader7.TabIndex = 17
        Me.KryptonHeader7.Text = "Home Address:"
        Me.KryptonHeader7.Values.Description = ""
        Me.KryptonHeader7.Values.Heading = "Home Address:"
        Me.KryptonHeader7.Values.Image = Nothing
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(492, 390)
        Me.SimpleButton3.LookAndFeel.SkinName = "iMaginary"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(216, 32)
        Me.SimpleButton3.TabIndex = 30
        Me.SimpleButton3.TabStop = False
        Me.SimpleButton3.Text = "Remove Picture"
        '
        'cmdCapture
        '
        Me.cmdCapture.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCapture.Appearance.Options.UseFont = True
        Me.cmdCapture.Image = CType(resources.GetObject("cmdCapture.Image"), System.Drawing.Image)
        Me.cmdCapture.Location = New System.Drawing.Point(492, 361)
        Me.cmdCapture.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCapture.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCapture.Name = "cmdCapture"
        Me.cmdCapture.Size = New System.Drawing.Size(216, 32)
        Me.cmdCapture.TabIndex = 29
        Me.cmdCapture.TabStop = False
        Me.cmdCapture.Text = "Capture From Camera"
        '
        'cmdLoadFromFile
        '
        Me.cmdLoadFromFile.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadFromFile.Appearance.Options.UseFont = True
        Me.cmdLoadFromFile.Image = CType(resources.GetObject("cmdLoadFromFile.Image"), System.Drawing.Image)
        Me.cmdLoadFromFile.Location = New System.Drawing.Point(492, 332)
        Me.cmdLoadFromFile.LookAndFeel.SkinName = "iMaginary"
        Me.cmdLoadFromFile.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdLoadFromFile.Name = "cmdLoadFromFile"
        Me.cmdLoadFromFile.Size = New System.Drawing.Size(216, 32)
        Me.cmdLoadFromFile.TabIndex = 28
        Me.cmdLoadFromFile.TabStop = False
        Me.cmdLoadFromFile.Text = "Load From File"
        '
        'PicImage
        '
        Me.PicImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicImage.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PicImage.Location = New System.Drawing.Point(492, 91)
        Me.PicImage.Name = "PicImage"
        Me.PicImage.Size = New System.Drawing.Size(216, 216)
        Me.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImage.TabIndex = 40
        Me.PicImage.TabStop = False
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboCourse.Location = New System.Drawing.Point(141, 325)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(289, 24)
        Me.cboCourse.TabIndex = 20
        '
        'KryptonHeader8
        '
        Me.KryptonHeader8.AutoSize = False
        Me.KryptonHeader8.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader8.Location = New System.Drawing.Point(12, 325)
        Me.KryptonHeader8.Name = "KryptonHeader8"
        Me.KryptonHeader8.Size = New System.Drawing.Size(186, 24)
        Me.KryptonHeader8.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader8.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader8.TabIndex = 19
        Me.KryptonHeader8.Text = "Course:"
        Me.KryptonHeader8.Values.Description = ""
        Me.KryptonHeader8.Values.Heading = "Course:"
        Me.KryptonHeader8.Values.Image = Nothing
        '
        'txtContactPersonNumber
        '
        Me.txtContactPersonNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactPersonNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPersonNumber.Location = New System.Drawing.Point(141, 419)
        Me.txtContactPersonNumber.Name = "txtContactPersonNumber"
        Me.txtContactPersonNumber.Size = New System.Drawing.Size(289, 23)
        Me.txtContactPersonNumber.TabIndex = 25
        '
        'KryptonHeader9
        '
        Me.KryptonHeader9.AutoSize = False
        Me.KryptonHeader9.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader9.Location = New System.Drawing.Point(12, 419)
        Me.KryptonHeader9.Name = "KryptonHeader9"
        Me.KryptonHeader9.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader9.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader9.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader9.TabIndex = 24
        Me.KryptonHeader9.Text = "Contact Number:"
        Me.KryptonHeader9.Values.Description = ""
        Me.KryptonHeader9.Values.Heading = "Contact Number:"
        Me.KryptonHeader9.Values.Image = Nothing
        '
        'txtContactPersonName
        '
        Me.txtContactPersonName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactPersonName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPersonName.Location = New System.Drawing.Point(141, 390)
        Me.txtContactPersonName.Name = "txtContactPersonName"
        Me.txtContactPersonName.Size = New System.Drawing.Size(289, 23)
        Me.txtContactPersonName.TabIndex = 23
        '
        'KryptonHeader12
        '
        Me.KryptonHeader12.AutoSize = False
        Me.KryptonHeader12.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader12.Location = New System.Drawing.Point(12, 390)
        Me.KryptonHeader12.Name = "KryptonHeader12"
        Me.KryptonHeader12.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader12.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader12.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader12.TabIndex = 22
        Me.KryptonHeader12.Text = "Name:"
        Me.KryptonHeader12.Values.Description = ""
        Me.KryptonHeader12.Values.Heading = "Name:"
        Me.KryptonHeader12.Values.Image = Nothing
        '
        'KryptonHeader13
        '
        Me.KryptonHeader13.AutoSize = False
        Me.KryptonHeader13.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader13.Location = New System.Drawing.Point(12, 361)
        Me.KryptonHeader13.Name = "KryptonHeader13"
        Me.KryptonHeader13.Size = New System.Drawing.Size(418, 24)
        Me.KryptonHeader13.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader13.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader13.TabIndex = 21
        Me.KryptonHeader13.Text = "In case of emergency, contact:"
        Me.KryptonHeader13.Values.Description = ""
        Me.KryptonHeader13.Values.Heading = "In case of emergency, contact:"
        Me.KryptonHeader13.Values.Image = Nothing
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyPictureToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(159, 26)
        '
        'CopyPictureToolStripMenuItem
        '
        Me.CopyPictureToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyPictureToolStripMenuItem.Name = "CopyPictureToolStripMenuItem"
        Me.CopyPictureToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CopyPictureToolStripMenuItem.Text = "Copy Picture"
        '
        'frmAddEditAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(756, 535)
        Me.Controls.Add(Me.KryptonHeader13)
        Me.Controls.Add(Me.txtContactPersonNumber)
        Me.Controls.Add(Me.KryptonHeader9)
        Me.Controls.Add(Me.txtContactPersonName)
        Me.Controls.Add(Me.KryptonHeader12)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.KryptonHeader8)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.cmdCapture)
        Me.Controls.Add(Me.cmdLoadFromFile)
        Me.Controls.Add(Me.PicImage)
        Me.Controls.Add(Me.txtHAdress)
        Me.Controls.Add(Me.KryptonHeader7)
        Me.Controls.Add(Me.txtPAddress)
        Me.Controls.Add(Me.KryptonHeader10)
        Me.Controls.Add(Me.dtpBirth)
        Me.Controls.Add(Me.KryptonHeader6)
        Me.Controls.Add(Me.cboCivilStatus)
        Me.Controls.Add(Me.KryptonHeader5)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.KryptonHeader4)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.KryptonHeader3)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.KryptonHeader2)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.KryptonHeader1)
        Me.Controls.Add(Me.txtEDPNumber)
        Me.Controls.Add(Me.KryptonHeader11)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditAdmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Admission"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtEDPNumber As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader11 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblHeader As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ErrProve As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtMiddle As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents dtpBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonHeader6 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader5 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader4 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtHAdress As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader7 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtPAddress As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader10 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCapture As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLoadFromFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PicImage As System.Windows.Forms.PictureBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader8 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents KryptonHeader13 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtContactPersonNumber As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader9 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtContactPersonName As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader12 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyPictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
