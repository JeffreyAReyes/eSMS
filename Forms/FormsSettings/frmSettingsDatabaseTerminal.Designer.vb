<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsDatabaseTerminal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingsDatabaseTerminal))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.cmdTest = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDatabase = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtHost = New System.Windows.Forms.TextBox
        Me.cmdClose = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cmdSave = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.errprove = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.errprove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 248)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(382, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(114, 17)
        Me.ToolStripStatusLabel1.Text = " ToolStripStatusLabel1"
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(100, 151)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(208, 25)
        Me.cmdTest.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest.TabIndex = 17
        Me.cmdTest.Text = "&Test Connection [F2]"
        Me.cmdTest.UseMnemonic = False
        Me.cmdTest.Values.ExtraText = ""
        Me.cmdTest.Values.Image = CType(resources.GetObject("cmdTest.Values.Image"), System.Drawing.Image)
        Me.cmdTest.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdTest.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdTest.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdTest.Values.Text = "&Test Connection [F2]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(53, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Database:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDatabase.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatabase.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDatabase.Location = New System.Drawing.Point(138, 113)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(170, 23)
        Me.txtDatabase.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(53, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtPassword.Location = New System.Drawing.Point(138, 84)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(170, 23)
        Me.txtPassword.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(53, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtName.Location = New System.Drawing.Point(138, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(170, 23)
        Me.txtName.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(39, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Server Host:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHost
        '
        Me.txtHost.AutoCompleteCustomSource.AddRange(New String() {"localhost"})
        Me.txtHost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtHost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtHost.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtHost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHost.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtHost.Location = New System.Drawing.Point(138, 26)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(170, 23)
        Me.txtHost.TabIndex = 10
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(204, 199)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(128, 25)
        Me.cmdClose.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "&Close [ESC]"
        Me.cmdClose.Values.ExtraText = ""
        Me.cmdClose.Values.Image = CType(resources.GetObject("cmdClose.Values.Image"), System.Drawing.Image)
        Me.cmdClose.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdClose.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdClose.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdClose.Values.Text = "&Close [ESC]"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(83, 199)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(115, 25)
        Me.cmdSave.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.TabStop = False
        Me.cmdSave.Text = "&Save [F12]"
        Me.cmdSave.UseMnemonic = False
        Me.cmdSave.Values.ExtraText = ""
        Me.cmdSave.Values.Image = CType(resources.GetObject("cmdSave.Values.Image"), System.Drawing.Image)
        Me.cmdSave.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.cmdSave.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.cmdSave.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.cmdSave.Values.Text = "&Save [F12]"
        '
        'errprove
        '
        Me.errprove.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errprove.ContainerControl = Me
        '
        'frmSettingsDatabaseTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(382, 270)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsDatabaseTerminal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Settings"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.errprove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdTest As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdSave As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents errprove As System.Windows.Forms.ErrorProvider
End Class
