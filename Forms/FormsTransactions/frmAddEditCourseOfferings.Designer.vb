<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditCourseOfferings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditCourseOfferings))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.txtCode = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtDescriptiveTitle = New System.Windows.Forms.TextBox
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.lblHeader = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.ErrProve = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboSubject = New System.Windows.Forms.ComboBox
        Me.KryptonHeader4 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtTime1 = New System.Windows.Forms.TextBox
        Me.txtDay1 = New System.Windows.Forms.TextBox
        Me.KryptonHeader5 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtRoom1 = New System.Windows.Forms.TextBox
        Me.KryptonHeader6 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtRoom2 = New System.Windows.Forms.TextBox
        Me.KryptonHeader7 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtDay2 = New System.Windows.Forms.TextBox
        Me.KryptonHeader8 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtTime2 = New System.Windows.Forms.TextBox
        Me.KryptonHeader9 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.cboInstructor = New System.Windows.Forms.ComboBox
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtUnits = New System.Windows.Forms.TextBox
        Me.KryptonHeader10 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtLabCode = New System.Windows.Forms.TextBox
        Me.KryptonHeader11 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.txtSubCode = New System.Windows.Forms.TextBox
        Me.txtSeats = New System.Windows.Forms.TextBox
        Me.KryptonHeader12 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 513)
        Me.StatusStrip1.Margin = New System.Windows.Forms.Padding(1)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(687, 22)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = " ToolStripStatusLabel1"
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubjectCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectCode.Location = New System.Drawing.Point(141, 62)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.ReadOnly = True
        Me.txtSubjectCode.Size = New System.Drawing.Size(512, 23)
        Me.txtSubjectCode.TabIndex = 2
        Me.txtSubjectCode.TabStop = False
        '
        'txtCode
        '
        Me.txtCode.AutoSize = False
        Me.txtCode.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.txtCode.Location = New System.Drawing.Point(12, 62)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(186, 23)
        Me.txtCode.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCode.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.TabIndex = 1
        Me.txtCode.Text = "Section Code:"
        Me.txtCode.Values.Description = ""
        Me.txtCode.Values.Heading = "Section Code:"
        Me.txtCode.Values.Image = Nothing
        '
        'txtDescriptiveTitle
        '
        Me.txtDescriptiveTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescriptiveTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescriptiveTitle.Location = New System.Drawing.Point(141, 120)
        Me.txtDescriptiveTitle.Name = "txtDescriptiveTitle"
        Me.txtDescriptiveTitle.ReadOnly = True
        Me.txtDescriptiveTitle.Size = New System.Drawing.Size(512, 23)
        Me.txtDescriptiveTitle.TabIndex = 6
        Me.txtDescriptiveTitle.TabStop = False
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AutoSize = False
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(12, 120)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader1.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader1.TabIndex = 5
        Me.KryptonHeader1.Text = "Descriptive Title:"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Descriptive Title:"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(425, 443)
        Me.cmdSave.LookAndFeel.SkinName = "iMaginary"
        Me.cmdSave.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 32)
        Me.cmdSave.TabIndex = 28
        Me.cmdSave.TabStop = False
        Me.cmdSave.Text = "Save [F2]"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(542, 443)
        Me.cmdCancel.LookAndFeel.SkinName = "iMaginary"
        Me.cmdCancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 32)
        Me.cmdCancel.TabIndex = 29
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
        Me.lblHeader.Size = New System.Drawing.Size(641, 23)
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
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader3.Location = New System.Drawing.Point(12, 91)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader3.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader3.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader3.TabIndex = 3
        Me.KryptonHeader3.Text = "Subject:"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Subject:"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'cboSubject
        '
        Me.cboSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSubject.FormattingEnabled = True
        Me.cboSubject.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboSubject.Location = New System.Drawing.Point(141, 91)
        Me.cboSubject.Name = "cboSubject"
        Me.cboSubject.Size = New System.Drawing.Size(512, 24)
        Me.cboSubject.TabIndex = 4
        '
        'KryptonHeader4
        '
        Me.KryptonHeader4.AutoSize = False
        Me.KryptonHeader4.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader4.Location = New System.Drawing.Point(12, 194)
        Me.KryptonHeader4.Name = "KryptonHeader4"
        Me.KryptonHeader4.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader4.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader4.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader4.TabIndex = 11
        Me.KryptonHeader4.Text = "Time1:"
        Me.KryptonHeader4.Values.Description = ""
        Me.KryptonHeader4.Values.Heading = "Time1:"
        Me.KryptonHeader4.Values.Image = Nothing
        '
        'txtTime1
        '
        Me.txtTime1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTime1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTime1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime1.Location = New System.Drawing.Point(141, 194)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(512, 23)
        Me.txtTime1.TabIndex = 12
        '
        'txtDay1
        '
        Me.txtDay1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDay1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDay1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay1.Location = New System.Drawing.Point(141, 223)
        Me.txtDay1.Name = "txtDay1"
        Me.txtDay1.Size = New System.Drawing.Size(512, 23)
        Me.txtDay1.TabIndex = 14
        '
        'KryptonHeader5
        '
        Me.KryptonHeader5.AutoSize = False
        Me.KryptonHeader5.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader5.Location = New System.Drawing.Point(12, 223)
        Me.KryptonHeader5.Name = "KryptonHeader5"
        Me.KryptonHeader5.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader5.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader5.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader5.TabIndex = 13
        Me.KryptonHeader5.Text = "Day1:"
        Me.KryptonHeader5.Values.Description = ""
        Me.KryptonHeader5.Values.Heading = "Day1:"
        Me.KryptonHeader5.Values.Image = Nothing
        '
        'txtRoom1
        '
        Me.txtRoom1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRoom1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoom1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom1.Location = New System.Drawing.Point(141, 252)
        Me.txtRoom1.Name = "txtRoom1"
        Me.txtRoom1.Size = New System.Drawing.Size(512, 23)
        Me.txtRoom1.TabIndex = 16
        '
        'KryptonHeader6
        '
        Me.KryptonHeader6.AutoSize = False
        Me.KryptonHeader6.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader6.Location = New System.Drawing.Point(12, 252)
        Me.KryptonHeader6.Name = "KryptonHeader6"
        Me.KryptonHeader6.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader6.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader6.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader6.TabIndex = 15
        Me.KryptonHeader6.Text = "Room1:"
        Me.KryptonHeader6.Values.Description = ""
        Me.KryptonHeader6.Values.Heading = "Room1:"
        Me.KryptonHeader6.Values.Image = Nothing
        '
        'txtRoom2
        '
        Me.txtRoom2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRoom2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoom2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom2.Location = New System.Drawing.Point(141, 339)
        Me.txtRoom2.Name = "txtRoom2"
        Me.txtRoom2.Size = New System.Drawing.Size(512, 23)
        Me.txtRoom2.TabIndex = 22
        '
        'KryptonHeader7
        '
        Me.KryptonHeader7.AutoSize = False
        Me.KryptonHeader7.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader7.Location = New System.Drawing.Point(12, 339)
        Me.KryptonHeader7.Name = "KryptonHeader7"
        Me.KryptonHeader7.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader7.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader7.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader7.TabIndex = 21
        Me.KryptonHeader7.Text = "Room2:"
        Me.KryptonHeader7.Values.Description = ""
        Me.KryptonHeader7.Values.Heading = "Room2:"
        Me.KryptonHeader7.Values.Image = Nothing
        '
        'txtDay2
        '
        Me.txtDay2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDay2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDay2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay2.Location = New System.Drawing.Point(141, 310)
        Me.txtDay2.Name = "txtDay2"
        Me.txtDay2.Size = New System.Drawing.Size(512, 23)
        Me.txtDay2.TabIndex = 20
        '
        'KryptonHeader8
        '
        Me.KryptonHeader8.AutoSize = False
        Me.KryptonHeader8.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader8.Location = New System.Drawing.Point(12, 310)
        Me.KryptonHeader8.Name = "KryptonHeader8"
        Me.KryptonHeader8.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader8.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader8.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader8.TabIndex = 19
        Me.KryptonHeader8.Text = "Day2:"
        Me.KryptonHeader8.Values.Description = ""
        Me.KryptonHeader8.Values.Heading = "Day2:"
        Me.KryptonHeader8.Values.Image = Nothing
        '
        'txtTime2
        '
        Me.txtTime2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTime2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTime2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime2.Location = New System.Drawing.Point(141, 281)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(512, 23)
        Me.txtTime2.TabIndex = 18
        '
        'KryptonHeader9
        '
        Me.KryptonHeader9.AutoSize = False
        Me.KryptonHeader9.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader9.Location = New System.Drawing.Point(12, 281)
        Me.KryptonHeader9.Name = "KryptonHeader9"
        Me.KryptonHeader9.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader9.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader9.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader9.TabIndex = 17
        Me.KryptonHeader9.Text = "Time2:"
        Me.KryptonHeader9.Values.Description = ""
        Me.KryptonHeader9.Values.Heading = "Time2:"
        Me.KryptonHeader9.Values.Image = Nothing
        '
        'cboInstructor
        '
        Me.cboInstructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInstructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboInstructor.FormattingEnabled = True
        Me.cboInstructor.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboInstructor.Location = New System.Drawing.Point(141, 408)
        Me.cboInstructor.Name = "cboInstructor"
        Me.cboInstructor.Size = New System.Drawing.Size(512, 24)
        Me.cboInstructor.TabIndex = 26
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.AutoSize = False
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(12, 408)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader2.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader2.TabIndex = 25
        Me.KryptonHeader2.Text = "Instructor:"
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "Instructor:"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'txtUnits
        '
        Me.txtUnits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnits.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Location = New System.Drawing.Point(141, 149)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.ReadOnly = True
        Me.txtUnits.Size = New System.Drawing.Size(168, 23)
        Me.txtUnits.TabIndex = 8
        Me.txtUnits.TabStop = False
        '
        'KryptonHeader10
        '
        Me.KryptonHeader10.AutoSize = False
        Me.KryptonHeader10.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader10.Location = New System.Drawing.Point(12, 149)
        Me.KryptonHeader10.Name = "KryptonHeader10"
        Me.KryptonHeader10.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader10.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader10.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader10.TabIndex = 7
        Me.KryptonHeader10.Text = "Units:"
        Me.KryptonHeader10.Values.Description = ""
        Me.KryptonHeader10.Values.Heading = "Units:"
        Me.KryptonHeader10.Values.Image = Nothing
        '
        'txtLabCode
        '
        Me.txtLabCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLabCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabCode.Location = New System.Drawing.Point(454, 149)
        Me.txtLabCode.Name = "txtLabCode"
        Me.txtLabCode.ReadOnly = True
        Me.txtLabCode.Size = New System.Drawing.Size(199, 23)
        Me.txtLabCode.TabIndex = 10
        Me.txtLabCode.TabStop = False
        '
        'KryptonHeader11
        '
        Me.KryptonHeader11.AutoSize = False
        Me.KryptonHeader11.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader11.Location = New System.Drawing.Point(337, 149)
        Me.KryptonHeader11.Name = "KryptonHeader11"
        Me.KryptonHeader11.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader11.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader11.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader11.TabIndex = 9
        Me.KryptonHeader11.Text = "Lab. Code:"
        Me.KryptonHeader11.Values.Description = ""
        Me.KryptonHeader11.Values.Heading = "Lab. Code:"
        Me.KryptonHeader11.Values.Image = Nothing
        '
        'txtSubCode
        '
        Me.txtSubCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCode.Location = New System.Drawing.Point(454, 178)
        Me.txtSubCode.Name = "txtSubCode"
        Me.txtSubCode.ReadOnly = True
        Me.txtSubCode.Size = New System.Drawing.Size(199, 23)
        Me.txtSubCode.TabIndex = 27
        Me.txtSubCode.TabStop = False
        Me.txtSubCode.Visible = False
        '
        'txtSeats
        '
        Me.txtSeats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSeats.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSeats.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeats.Location = New System.Drawing.Point(141, 368)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(512, 23)
        Me.txtSeats.TabIndex = 24
        Me.txtSeats.Text = "0"
        '
        'KryptonHeader12
        '
        Me.KryptonHeader12.AutoSize = False
        Me.KryptonHeader12.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader12.Location = New System.Drawing.Point(12, 368)
        Me.KryptonHeader12.Name = "KryptonHeader12"
        Me.KryptonHeader12.Size = New System.Drawing.Size(186, 23)
        Me.KryptonHeader12.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonHeader12.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader12.TabIndex = 23
        Me.KryptonHeader12.Text = "Num. of Seats:"
        Me.KryptonHeader12.Values.Description = ""
        Me.KryptonHeader12.Values.Heading = "Num. of Seats:"
        Me.KryptonHeader12.Values.Image = Nothing
        '
        'frmAddEditCourseOfferings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(687, 535)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.KryptonHeader12)
        Me.Controls.Add(Me.txtSubCode)
        Me.Controls.Add(Me.txtLabCode)
        Me.Controls.Add(Me.KryptonHeader11)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.KryptonHeader10)
        Me.Controls.Add(Me.cboInstructor)
        Me.Controls.Add(Me.KryptonHeader2)
        Me.Controls.Add(Me.txtRoom2)
        Me.Controls.Add(Me.KryptonHeader7)
        Me.Controls.Add(Me.txtDay2)
        Me.Controls.Add(Me.KryptonHeader8)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.KryptonHeader9)
        Me.Controls.Add(Me.txtRoom1)
        Me.Controls.Add(Me.KryptonHeader6)
        Me.Controls.Add(Me.txtDay1)
        Me.Controls.Add(Me.KryptonHeader5)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.cboSubject)
        Me.Controls.Add(Me.KryptonHeader4)
        Me.Controls.Add(Me.KryptonHeader3)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtDescriptiveTitle)
        Me.Controls.Add(Me.KryptonHeader1)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditCourseOfferings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Course Offering"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ErrProve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtDescriptiveTitle As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblHeader As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents ErrProve As System.Windows.Forms.ErrorProvider
    Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboSubject As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader4 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtRoom1 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader6 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtDay1 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader5 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRoom2 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader7 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtDay2 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader8 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtTime2 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader9 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents cboInstructor As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader10 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtLabCode As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader11 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents txtSubCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSeats As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeader12 As ComponentFactory.Krypton.Toolkit.KryptonHeader
End Class
