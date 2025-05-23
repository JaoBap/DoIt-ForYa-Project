<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.tbMenu = New System.Windows.Forms.TabControl()
        Me.tbpgMacro = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLoadSelectedMacro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveSelectedMacro = New System.Windows.Forms.Button()
        Me.txtWindowCaption = New System.Windows.Forms.TextBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.chkLoop = New System.Windows.Forms.CheckBox()
        Me.lblMacroname = New System.Windows.Forms.Label()
        Me.tbpgSettings = New System.Windows.Forms.TabPage()
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.tbSettings = New System.Windows.Forms.TabPage()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.chkDarkmode = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGetMousePosition = New System.Windows.Forms.Button()
        Me.btnHotkeyStop = New System.Windows.Forms.Button()
        Me.btnHotkeyStart = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpgLoad = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkLoop7 = New System.Windows.Forms.CheckBox()
        Me.btnStop7 = New System.Windows.Forms.Button()
        Me.btnStart7 = New System.Windows.Forms.Button()
        Me.chkLoop6 = New System.Windows.Forms.CheckBox()
        Me.btnStop6 = New System.Windows.Forms.Button()
        Me.chkLoop5 = New System.Windows.Forms.CheckBox()
        Me.btnStart6 = New System.Windows.Forms.Button()
        Me.btnStop5 = New System.Windows.Forms.Button()
        Me.btnStart5 = New System.Windows.Forms.Button()
        Me.chkLoop4 = New System.Windows.Forms.CheckBox()
        Me.btnStop4 = New System.Windows.Forms.Button()
        Me.btnStart4 = New System.Windows.Forms.Button()
        Me.chkLoop3 = New System.Windows.Forms.CheckBox()
        Me.btnStop3 = New System.Windows.Forms.Button()
        Me.btnStart3 = New System.Windows.Forms.Button()
        Me.chkLoop2 = New System.Windows.Forms.CheckBox()
        Me.btnStop2 = New System.Windows.Forms.Button()
        Me.btnStart2 = New System.Windows.Forms.Button()
        Me.chkLoop1 = New System.Windows.Forms.CheckBox()
        Me.btnStop1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label1231 = New System.Windows.Forms.Label()
        Me.btnStart1 = New System.Windows.Forms.Button()
        Me.gridSlotMacros = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_Location_Loaded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemoveSavedMacro = New System.Windows.Forms.Button()
        Me.btnLoadSavedMacro = New System.Windows.Forms.Button()
        Me.gridFavMacros = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gridSavedMacros = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUnFav = New System.Windows.Forms.Button()
        Me.btnFav = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpgHelp = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblStartHotkey = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblStopHotkey = New System.Windows.Forms.Label()
        Me.filedialogLoadMacroMain = New System.Windows.Forms.OpenFileDialog()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.filedialogSaveMacroMain = New System.Windows.Forms.SaveFileDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnHotkeyGetWindow = New System.Windows.Forms.Button()
        Me.tbMenu.SuspendLayout()
        Me.tbpgMacro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbpgSettings.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tbSettings.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbpgLoad.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gridSlotMacros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFavMacros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSavedMacros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpgHelp.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(6, 25)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInput.Size = New System.Drawing.Size(825, 368)
        Me.txtInput.TabIndex = 0
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(-3, 0)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(31, 13)
        Me.lblInput.TabIndex = 1
        Me.lblInput.Text = "Input"
        '
        'tbMenu
        '
        Me.tbMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMenu.Controls.Add(Me.tbpgMacro)
        Me.tbMenu.Controls.Add(Me.tbpgSettings)
        Me.tbMenu.Controls.Add(Me.tbpgLoad)
        Me.tbMenu.Controls.Add(Me.tbpgHelp)
        Me.tbMenu.Location = New System.Drawing.Point(0, -1)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.SelectedIndex = 0
        Me.tbMenu.Size = New System.Drawing.Size(857, 456)
        Me.tbMenu.TabIndex = 2
        '
        'tbpgMacro
        '
        Me.tbpgMacro.Controls.Add(Me.GroupBox1)
        Me.tbpgMacro.Location = New System.Drawing.Point(4, 22)
        Me.tbpgMacro.Name = "tbpgMacro"
        Me.tbpgMacro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgMacro.Size = New System.Drawing.Size(849, 430)
        Me.tbpgMacro.TabIndex = 0
        Me.tbpgMacro.Text = "Macro"
        Me.tbpgMacro.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnLoadSelectedMacro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSaveSelectedMacro)
        Me.GroupBox1.Controls.Add(Me.txtWindowCaption)
        Me.GroupBox1.Controls.Add(Me.btnCapture)
        Me.GroupBox1.Controls.Add(Me.chkLoop)
        Me.GroupBox1.Controls.Add(Me.lblMacroname)
        Me.GroupBox1.Controls.Add(Me.lblInput)
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 421)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnLoadSelectedMacro
        '
        Me.btnLoadSelectedMacro.Location = New System.Drawing.Point(34, 0)
        Me.btnLoadSelectedMacro.Name = "btnLoadSelectedMacro"
        Me.btnLoadSelectedMacro.Size = New System.Drawing.Size(58, 19)
        Me.btnLoadSelectedMacro.TabIndex = 13
        Me.btnLoadSelectedMacro.Text = "Load"
        Me.btnLoadSelectedMacro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Window:"
        '
        'btnSaveSelectedMacro
        '
        Me.btnSaveSelectedMacro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveSelectedMacro.Location = New System.Drawing.Point(775, 0)
        Me.btnSaveSelectedMacro.Name = "btnSaveSelectedMacro"
        Me.btnSaveSelectedMacro.Size = New System.Drawing.Size(58, 19)
        Me.btnSaveSelectedMacro.TabIndex = 11
        Me.btnSaveSelectedMacro.Text = "Save"
        Me.btnSaveSelectedMacro.UseVisualStyleBackColor = True
        '
        'txtWindowCaption
        '
        Me.txtWindowCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWindowCaption.Location = New System.Drawing.Point(55, 397)
        Me.txtWindowCaption.Name = "txtWindowCaption"
        Me.txtWindowCaption.Size = New System.Drawing.Size(519, 20)
        Me.txtWindowCaption.TabIndex = 10
        Me.txtWindowCaption.Text = "No Window!"
        '
        'btnCapture
        '
        Me.btnCapture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCapture.Location = New System.Drawing.Point(580, 398)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(129, 19)
        Me.btnCapture.TabIndex = 9
        Me.btnCapture.Text = "Capture Last Window"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'chkLoop
        '
        Me.chkLoop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLoop.AutoSize = True
        Me.chkLoop.Location = New System.Drawing.Point(715, 401)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(56, 17)
        Me.chkLoop.TabIndex = 7
        Me.chkLoop.Text = "Loop?"
        Me.chkLoop.UseVisualStyleBackColor = True
        '
        'lblMacroname
        '
        Me.lblMacroname.AutoSize = True
        Me.lblMacroname.Location = New System.Drawing.Point(98, 0)
        Me.lblMacroname.Name = "lblMacroname"
        Me.lblMacroname.Size = New System.Drawing.Size(62, 13)
        Me.lblMacroname.TabIndex = 2
        Me.lblMacroname.Text = "macroname"
        Me.lblMacroname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbpgSettings
        '
        Me.tbpgSettings.Controls.Add(Me.tabSettings)
        Me.tbpgSettings.Location = New System.Drawing.Point(4, 22)
        Me.tbpgSettings.Name = "tbpgSettings"
        Me.tbpgSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgSettings.Size = New System.Drawing.Size(849, 430)
        Me.tbpgSettings.TabIndex = 1
        Me.tbpgSettings.Text = "Settings"
        Me.tbpgSettings.UseVisualStyleBackColor = True
        '
        'tabSettings
        '
        Me.tabSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSettings.Controls.Add(Me.tbSettings)
        Me.tabSettings.Controls.Add(Me.TabPage2)
        Me.tabSettings.Location = New System.Drawing.Point(3, 6)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.Size = New System.Drawing.Size(840, 418)
        Me.tabSettings.TabIndex = 0
        '
        'tbSettings
        '
        Me.tbSettings.Controls.Add(Me.btnDefault)
        Me.tbSettings.Controls.Add(Me.chkDarkmode)
        Me.tbSettings.Location = New System.Drawing.Point(4, 22)
        Me.tbSettings.Name = "tbSettings"
        Me.tbSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSettings.Size = New System.Drawing.Size(832, 392)
        Me.tbSettings.TabIndex = 0
        Me.tbSettings.Text = "Basic"
        Me.tbSettings.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDefault.Location = New System.Drawing.Point(703, 354)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(123, 28)
        Me.btnDefault.TabIndex = 1
        Me.btnDefault.Text = "Default EVERYTHING"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'chkDarkmode
        '
        Me.chkDarkmode.AutoSize = True
        Me.chkDarkmode.Location = New System.Drawing.Point(6, 6)
        Me.chkDarkmode.Name = "chkDarkmode"
        Me.chkDarkmode.Size = New System.Drawing.Size(76, 17)
        Me.chkDarkmode.TabIndex = 0
        Me.chkDarkmode.Text = "DarkMode"
        Me.chkDarkmode.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(832, 392)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hotkeys"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Press the hotkey to re-assign it"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnHotkeyGetWindow)
        Me.GroupBox3.Controls.Add(Me.btnGetMousePosition)
        Me.GroupBox3.Controls.Add(Me.btnHotkeyStop)
        Me.GroupBox3.Controls.Add(Me.btnHotkeyStart)
        Me.GroupBox3.Location = New System.Drawing.Point(89, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(77, 369)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hotkey"
        '
        'btnGetMousePosition
        '
        Me.btnGetMousePosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGetMousePosition.Location = New System.Drawing.Point(5, 337)
        Me.btnGetMousePosition.Name = "btnGetMousePosition"
        Me.btnGetMousePosition.Size = New System.Drawing.Size(63, 23)
        Me.btnGetMousePosition.TabIndex = 3
        Me.btnGetMousePosition.Text = "None"
        Me.btnGetMousePosition.UseVisualStyleBackColor = True
        '
        'btnHotkeyStop
        '
        Me.btnHotkeyStop.Location = New System.Drawing.Point(5, 42)
        Me.btnHotkeyStop.Name = "btnHotkeyStop"
        Me.btnHotkeyStop.Size = New System.Drawing.Size(63, 23)
        Me.btnHotkeyStop.TabIndex = 2
        Me.btnHotkeyStop.Text = "None"
        Me.btnHotkeyStop.UseVisualStyleBackColor = True
        '
        'btnHotkeyStart
        '
        Me.btnHotkeyStart.Location = New System.Drawing.Point(5, 16)
        Me.btnHotkeyStart.Name = "btnHotkeyStart"
        Me.btnHotkeyStart.Size = New System.Drawing.Size(63, 23)
        Me.btnHotkeyStart.TabIndex = 1
        Me.btnHotkeyStart.Text = "None"
        Me.btnHotkeyStart.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(77, 369)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purpose"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 26)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Get Mouse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Stop Hotkey"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Start Hotkey"
        '
        'tbpgLoad
        '
        Me.tbpgLoad.Controls.Add(Me.GroupBox4)
        Me.tbpgLoad.Controls.Add(Me.gridSlotMacros)
        Me.tbpgLoad.Controls.Add(Me.btnRemoveSavedMacro)
        Me.tbpgLoad.Controls.Add(Me.btnLoadSavedMacro)
        Me.tbpgLoad.Controls.Add(Me.gridFavMacros)
        Me.tbpgLoad.Controls.Add(Me.gridSavedMacros)
        Me.tbpgLoad.Controls.Add(Me.Label7)
        Me.tbpgLoad.Controls.Add(Me.Label6)
        Me.tbpgLoad.Controls.Add(Me.btnUnFav)
        Me.tbpgLoad.Controls.Add(Me.btnFav)
        Me.tbpgLoad.Controls.Add(Me.Label5)
        Me.tbpgLoad.Location = New System.Drawing.Point(4, 22)
        Me.tbpgLoad.Name = "tbpgLoad"
        Me.tbpgLoad.Size = New System.Drawing.Size(849, 430)
        Me.tbpgLoad.TabIndex = 2
        Me.tbpgLoad.Text = "Macro Pages"
        Me.tbpgLoad.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.chkLoop7)
        Me.GroupBox4.Controls.Add(Me.btnStop7)
        Me.GroupBox4.Controls.Add(Me.btnStart7)
        Me.GroupBox4.Controls.Add(Me.chkLoop6)
        Me.GroupBox4.Controls.Add(Me.btnStop6)
        Me.GroupBox4.Controls.Add(Me.chkLoop5)
        Me.GroupBox4.Controls.Add(Me.btnStart6)
        Me.GroupBox4.Controls.Add(Me.btnStop5)
        Me.GroupBox4.Controls.Add(Me.btnStart5)
        Me.GroupBox4.Controls.Add(Me.chkLoop4)
        Me.GroupBox4.Controls.Add(Me.btnStop4)
        Me.GroupBox4.Controls.Add(Me.btnStart4)
        Me.GroupBox4.Controls.Add(Me.chkLoop3)
        Me.GroupBox4.Controls.Add(Me.btnStop3)
        Me.GroupBox4.Controls.Add(Me.btnStart3)
        Me.GroupBox4.Controls.Add(Me.chkLoop2)
        Me.GroupBox4.Controls.Add(Me.btnStop2)
        Me.GroupBox4.Controls.Add(Me.btnStart2)
        Me.GroupBox4.Controls.Add(Me.chkLoop1)
        Me.GroupBox4.Controls.Add(Me.btnStop1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.label1231)
        Me.GroupBox4.Controls.Add(Me.btnStart1)
        Me.GroupBox4.Location = New System.Drawing.Point(677, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(159, 405)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hotkeys for Slotted Macros"
        '
        'chkLoop7
        '
        Me.chkLoop7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLoop7.AutoSize = True
        Me.chkLoop7.Location = New System.Drawing.Point(9, 370)
        Me.chkLoop7.Name = "chkLoop7"
        Me.chkLoop7.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop7.TabIndex = 21
        Me.chkLoop7.Text = "Loop"
        Me.chkLoop7.UseVisualStyleBackColor = True
        '
        'btnStop7
        '
        Me.btnStop7.Location = New System.Drawing.Point(76, 341)
        Me.btnStop7.Name = "btnStop7"
        Me.btnStop7.Size = New System.Drawing.Size(60, 23)
        Me.btnStop7.TabIndex = 21
        Me.btnStop7.Text = "None"
        Me.btnStop7.UseVisualStyleBackColor = True
        '
        'btnStart7
        '
        Me.btnStart7.Location = New System.Drawing.Point(6, 341)
        Me.btnStart7.Name = "btnStart7"
        Me.btnStart7.Size = New System.Drawing.Size(60, 23)
        Me.btnStart7.TabIndex = 20
        Me.btnStart7.Text = "None"
        Me.btnStart7.UseVisualStyleBackColor = True
        '
        'chkLoop6
        '
        Me.chkLoop6.AutoSize = True
        Me.chkLoop6.Location = New System.Drawing.Point(6, 318)
        Me.chkLoop6.Name = "chkLoop6"
        Me.chkLoop6.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop6.TabIndex = 19
        Me.chkLoop6.Text = "Loop"
        Me.chkLoop6.UseVisualStyleBackColor = True
        '
        'btnStop6
        '
        Me.btnStop6.Location = New System.Drawing.Point(76, 289)
        Me.btnStop6.Name = "btnStop6"
        Me.btnStop6.Size = New System.Drawing.Size(60, 23)
        Me.btnStop6.TabIndex = 18
        Me.btnStop6.Text = "None"
        Me.btnStop6.UseVisualStyleBackColor = True
        '
        'chkLoop5
        '
        Me.chkLoop5.AutoSize = True
        Me.chkLoop5.Location = New System.Drawing.Point(6, 266)
        Me.chkLoop5.Name = "chkLoop5"
        Me.chkLoop5.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop5.TabIndex = 17
        Me.chkLoop5.Text = "Loop"
        Me.chkLoop5.UseVisualStyleBackColor = True
        '
        'btnStart6
        '
        Me.btnStart6.Location = New System.Drawing.Point(6, 289)
        Me.btnStart6.Name = "btnStart6"
        Me.btnStart6.Size = New System.Drawing.Size(60, 23)
        Me.btnStart6.TabIndex = 16
        Me.btnStart6.Text = "None"
        Me.btnStart6.UseVisualStyleBackColor = True
        '
        'btnStop5
        '
        Me.btnStop5.Location = New System.Drawing.Point(76, 237)
        Me.btnStop5.Name = "btnStop5"
        Me.btnStop5.Size = New System.Drawing.Size(60, 23)
        Me.btnStop5.TabIndex = 15
        Me.btnStop5.Text = "None"
        Me.btnStop5.UseVisualStyleBackColor = True
        '
        'btnStart5
        '
        Me.btnStart5.Location = New System.Drawing.Point(6, 237)
        Me.btnStart5.Name = "btnStart5"
        Me.btnStart5.Size = New System.Drawing.Size(60, 23)
        Me.btnStart5.TabIndex = 14
        Me.btnStart5.Text = "None"
        Me.btnStart5.UseVisualStyleBackColor = True
        '
        'chkLoop4
        '
        Me.chkLoop4.AutoSize = True
        Me.chkLoop4.Location = New System.Drawing.Point(6, 214)
        Me.chkLoop4.Name = "chkLoop4"
        Me.chkLoop4.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop4.TabIndex = 13
        Me.chkLoop4.Text = "Loop"
        Me.chkLoop4.UseVisualStyleBackColor = True
        '
        'btnStop4
        '
        Me.btnStop4.Location = New System.Drawing.Point(76, 185)
        Me.btnStop4.Name = "btnStop4"
        Me.btnStop4.Size = New System.Drawing.Size(60, 23)
        Me.btnStop4.TabIndex = 12
        Me.btnStop4.Text = "None"
        Me.btnStop4.UseVisualStyleBackColor = True
        '
        'btnStart4
        '
        Me.btnStart4.Location = New System.Drawing.Point(6, 185)
        Me.btnStart4.Name = "btnStart4"
        Me.btnStart4.Size = New System.Drawing.Size(60, 23)
        Me.btnStart4.TabIndex = 11
        Me.btnStart4.Text = "None"
        Me.btnStart4.UseVisualStyleBackColor = True
        '
        'chkLoop3
        '
        Me.chkLoop3.AutoSize = True
        Me.chkLoop3.Location = New System.Drawing.Point(6, 162)
        Me.chkLoop3.Name = "chkLoop3"
        Me.chkLoop3.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop3.TabIndex = 10
        Me.chkLoop3.Text = "Loop"
        Me.chkLoop3.UseVisualStyleBackColor = True
        '
        'btnStop3
        '
        Me.btnStop3.Location = New System.Drawing.Point(76, 133)
        Me.btnStop3.Name = "btnStop3"
        Me.btnStop3.Size = New System.Drawing.Size(60, 23)
        Me.btnStop3.TabIndex = 9
        Me.btnStop3.Text = "None"
        Me.btnStop3.UseVisualStyleBackColor = True
        '
        'btnStart3
        '
        Me.btnStart3.Location = New System.Drawing.Point(6, 133)
        Me.btnStart3.Name = "btnStart3"
        Me.btnStart3.Size = New System.Drawing.Size(60, 23)
        Me.btnStart3.TabIndex = 8
        Me.btnStart3.Text = "None"
        Me.btnStart3.UseVisualStyleBackColor = True
        '
        'chkLoop2
        '
        Me.chkLoop2.AutoSize = True
        Me.chkLoop2.Location = New System.Drawing.Point(6, 110)
        Me.chkLoop2.Name = "chkLoop2"
        Me.chkLoop2.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop2.TabIndex = 7
        Me.chkLoop2.Text = "Loop"
        Me.chkLoop2.UseVisualStyleBackColor = True
        '
        'btnStop2
        '
        Me.btnStop2.Location = New System.Drawing.Point(76, 79)
        Me.btnStop2.Name = "btnStop2"
        Me.btnStop2.Size = New System.Drawing.Size(60, 23)
        Me.btnStop2.TabIndex = 6
        Me.btnStop2.Text = "None"
        Me.btnStop2.UseVisualStyleBackColor = True
        '
        'btnStart2
        '
        Me.btnStart2.Location = New System.Drawing.Point(6, 79)
        Me.btnStart2.Name = "btnStart2"
        Me.btnStart2.Size = New System.Drawing.Size(60, 23)
        Me.btnStart2.TabIndex = 5
        Me.btnStart2.Text = "None"
        Me.btnStart2.UseVisualStyleBackColor = True
        '
        'chkLoop1
        '
        Me.chkLoop1.AutoSize = True
        Me.chkLoop1.Location = New System.Drawing.Point(6, 58)
        Me.chkLoop1.Name = "chkLoop1"
        Me.chkLoop1.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop1.TabIndex = 4
        Me.chkLoop1.Text = "Loop"
        Me.chkLoop1.UseVisualStyleBackColor = True
        '
        'btnStop1
        '
        Me.btnStop1.Location = New System.Drawing.Point(76, 34)
        Me.btnStop1.Name = "btnStop1"
        Me.btnStop1.Size = New System.Drawing.Size(60, 23)
        Me.btnStop1.TabIndex = 3
        Me.btnStop1.Text = "None"
        Me.btnStop1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Stop"
        '
        'label1231
        '
        Me.label1231.AutoSize = True
        Me.label1231.Location = New System.Drawing.Point(6, 18)
        Me.label1231.Name = "label1231"
        Me.label1231.Size = New System.Drawing.Size(29, 13)
        Me.label1231.TabIndex = 1
        Me.label1231.Text = "Start"
        '
        'btnStart1
        '
        Me.btnStart1.Location = New System.Drawing.Point(6, 34)
        Me.btnStart1.Name = "btnStart1"
        Me.btnStart1.Size = New System.Drawing.Size(60, 23)
        Me.btnStart1.TabIndex = 0
        Me.btnStart1.Text = "None"
        Me.btnStart1.UseVisualStyleBackColor = True
        '
        'gridSlotMacros
        '
        Me.gridSlotMacros.AllowUserToAddRows = False
        Me.gridSlotMacros.AllowUserToDeleteRows = False
        Me.gridSlotMacros.AllowUserToResizeColumns = False
        Me.gridSlotMacros.AllowUserToResizeRows = False
        Me.gridSlotMacros.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gridSlotMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSlotMacros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.File_Location_Loaded, Me.State})
        Me.gridSlotMacros.Location = New System.Drawing.Point(377, 21)
        Me.gridSlotMacros.Name = "gridSlotMacros"
        Me.gridSlotMacros.ReadOnly = True
        Me.gridSlotMacros.RowHeadersVisible = False
        Me.gridSlotMacros.Size = New System.Drawing.Size(238, 403)
        Me.gridSlotMacros.TabIndex = 14
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Macro Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'File_Location_Loaded
        '
        Me.File_Location_Loaded.HeaderText = "File Location"
        Me.File_Location_Loaded.Name = "File_Location_Loaded"
        Me.File_Location_Loaded.ReadOnly = True
        Me.File_Location_Loaded.Visible = False
        '
        'State
        '
        Me.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        '
        'btnRemoveSavedMacro
        '
        Me.btnRemoveSavedMacro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveSavedMacro.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemoveSavedMacro.Location = New System.Drawing.Point(88, 390)
        Me.btnRemoveSavedMacro.Name = "btnRemoveSavedMacro"
        Me.btnRemoveSavedMacro.Size = New System.Drawing.Size(82, 37)
        Me.btnRemoveSavedMacro.TabIndex = 13
        Me.btnRemoveSavedMacro.Text = "Remove Macro"
        Me.btnRemoveSavedMacro.UseVisualStyleBackColor = False
        '
        'btnLoadSavedMacro
        '
        Me.btnLoadSavedMacro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoadSavedMacro.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLoadSavedMacro.Location = New System.Drawing.Point(6, 390)
        Me.btnLoadSavedMacro.Name = "btnLoadSavedMacro"
        Me.btnLoadSavedMacro.Size = New System.Drawing.Size(82, 37)
        Me.btnLoadSavedMacro.TabIndex = 12
        Me.btnLoadSavedMacro.Text = "Add Macro to Load List"
        Me.btnLoadSavedMacro.UseVisualStyleBackColor = False
        '
        'gridFavMacros
        '
        Me.gridFavMacros.AllowUserToAddRows = False
        Me.gridFavMacros.AllowUserToDeleteRows = False
        Me.gridFavMacros.AllowUserToResizeColumns = False
        Me.gridFavMacros.AllowUserToResizeRows = False
        Me.gridFavMacros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gridFavMacros.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gridFavMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridFavMacros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.File_Location})
        Me.gridFavMacros.Location = New System.Drawing.Point(207, 21)
        Me.gridFavMacros.Name = "gridFavMacros"
        Me.gridFavMacros.ReadOnly = True
        Me.gridFavMacros.RowHeadersVisible = False
        Me.gridFavMacros.Size = New System.Drawing.Size(164, 403)
        Me.gridFavMacros.TabIndex = 11
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Macro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'File_Location
        '
        Me.File_Location.HeaderText = "File Location"
        Me.File_Location.Name = "File_Location"
        Me.File_Location.ReadOnly = True
        Me.File_Location.Visible = False
        '
        'gridSavedMacros
        '
        Me.gridSavedMacros.AllowUserToAddRows = False
        Me.gridSavedMacros.AllowUserToDeleteRows = False
        Me.gridSavedMacros.AllowUserToResizeColumns = False
        Me.gridSavedMacros.AllowUserToResizeRows = False
        Me.gridSavedMacros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gridSavedMacros.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridSavedMacros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridSavedMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSavedMacros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FileLocation})
        Me.gridSavedMacros.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.gridSavedMacros.Location = New System.Drawing.Point(6, 21)
        Me.gridSavedMacros.Name = "gridSavedMacros"
        Me.gridSavedMacros.RowHeadersVisible = False
        Me.gridSavedMacros.Size = New System.Drawing.Size(164, 363)
        Me.gridSavedMacros.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Macro"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FileLocation
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent
        Me.FileLocation.DefaultCellStyle = DataGridViewCellStyle3
        Me.FileLocation.HeaderText = "File Location"
        Me.FileLocation.Name = "FileLocation"
        Me.FileLocation.ReadOnly = True
        Me.FileLocation.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(374, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Slotted Macros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Favorite Macros"
        '
        'btnUnFav
        '
        Me.btnUnFav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUnFav.Location = New System.Drawing.Point(176, 200)
        Me.btnUnFav.Name = "btnUnFav"
        Me.btnUnFav.Size = New System.Drawing.Size(25, 172)
        Me.btnUnFav.TabIndex = 4
        Me.btnUnFav.Text = "<"
        Me.btnUnFav.UseVisualStyleBackColor = True
        '
        'btnFav
        '
        Me.btnFav.Location = New System.Drawing.Point(176, 22)
        Me.btnFav.Name = "btnFav"
        Me.btnFav.Size = New System.Drawing.Size(25, 172)
        Me.btnFav.TabIndex = 3
        Me.btnFav.Text = ">"
        Me.btnFav.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Saved Macros"
        '
        'tbpgHelp
        '
        Me.tbpgHelp.Controls.Add(Me.GroupBox5)
        Me.tbpgHelp.Location = New System.Drawing.Point(4, 22)
        Me.tbpgHelp.Name = "tbpgHelp"
        Me.tbpgHelp.Size = New System.Drawing.Size(849, 430)
        Me.tbpgHelp.TabIndex = 3
        Me.tbpgHelp.Text = "Help"
        Me.tbpgHelp.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.LinkLabel1)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(843, 418)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "This tab is for help on using Doit Forya"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Green
        Me.LinkLabel1.Location = New System.Drawing.Point(692, 1)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Link to Windows API Key list "
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(6, 17)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(831, 395)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.Location = New System.Drawing.Point(863, 418)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 38)
        Me.btnSave.TabIndex = 0
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save Everything!"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStart.Location = New System.Drawing.Point(863, 27)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(88, 31)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblStartHotkey
        '
        Me.lblStartHotkey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStartHotkey.AutoSize = True
        Me.lblStartHotkey.Location = New System.Drawing.Point(863, 9)
        Me.lblStartHotkey.Name = "lblStartHotkey"
        Me.lblStartHotkey.Size = New System.Drawing.Size(88, 13)
        Me.lblStartHotkey.TabIndex = 4
        Me.lblStartHotkey.Text = "Start Main Macro"
        Me.lblStartHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStop.Location = New System.Drawing.Point(863, 77)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(88, 31)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop All"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'lblStopHotkey
        '
        Me.lblStopHotkey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStopHotkey.AutoSize = True
        Me.lblStopHotkey.Location = New System.Drawing.Point(886, 61)
        Me.lblStopHotkey.Name = "lblStopHotkey"
        Me.lblStopHotkey.Size = New System.Drawing.Size(43, 13)
        Me.lblStopHotkey.TabIndex = 6
        Me.lblStopHotkey.Text = "Stop All"
        Me.lblStopHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'filedialogLoadMacroMain
        '
        Me.filedialogLoadMacroMain.FileName = "OpenFileDialog1"
        '
        'btnTest
        '
        Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTest.Enabled = False
        Me.btnTest.Location = New System.Drawing.Point(870, 335)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 77)
        Me.btnTest.TabIndex = 9
        Me.btnTest.Text = "test"
        Me.btnTest.UseVisualStyleBackColor = True
        Me.btnTest.Visible = False
        '
        'filedialogSaveMacroMain
        '
        Me.filedialogSaveMacroMain.FileName = "Macro"
        Me.filedialogSaveMacroMain.Filter = "Text Files(*.txt) | *.txt"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 26)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Get Current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Window"
        '
        'btnHotkeyGetWindow
        '
        Me.btnHotkeyGetWindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHotkeyGetWindow.Location = New System.Drawing.Point(5, 298)
        Me.btnHotkeyGetWindow.Name = "btnHotkeyGetWindow"
        Me.btnHotkeyGetWindow.Size = New System.Drawing.Size(63, 23)
        Me.btnHotkeyGetWindow.TabIndex = 4
        Me.btnHotkeyGetWindow.Text = "None"
        Me.btnHotkeyGetWindow.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(957, 457)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblStopHotkey)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.tbMenu)
        Me.Controls.Add(Me.lblStartHotkey)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(973, 496)
        Me.Name = "MainForm"
        Me.Text = "Do It For Ya"
        Me.tbMenu.ResumeLayout(False)
        Me.tbpgMacro.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbpgSettings.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.tbSettings.ResumeLayout(False)
        Me.tbSettings.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbpgLoad.ResumeLayout(False)
        Me.tbpgLoad.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.gridSlotMacros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFavMacros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSavedMacros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpgHelp.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInput As Label
    Friend WithEvents tbMenu As TabControl
    Friend WithEvents tbpgMacro As TabPage
    Friend WithEvents tbpgSettings As TabPage
    Friend WithEvents btnStart As Button
    Friend WithEvents tbpgLoad As TabPage
    Friend WithEvents lblStartHotkey As Label
    Friend WithEvents tbpgHelp As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMacroname As Label
    Friend WithEvents chkLoop As CheckBox
    Friend WithEvents btnStop As Button
    Friend WithEvents lblStopHotkey As Label
    Friend WithEvents tabSettings As TabControl
    Friend WithEvents tbSettings As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnHotkeyStart As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHotkeyStop As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCapture As Button
    Friend WithEvents txtWindowCaption As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUnFav As Button
    Friend WithEvents btnFav As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents filedialogLoadMacroMain As OpenFileDialog
    Friend WithEvents gridFavMacros As DataGridView
    Friend WithEvents gridSavedMacros As DataGridView
    Friend WithEvents btnRemoveSavedMacro As Button
    Friend WithEvents btnLoadSavedMacro As Button
    Friend WithEvents gridSlotMacros As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveSelectedMacro As Button
    Friend WithEvents btnLoadSelectedMacro As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents filedialogSaveMacroMain As SaveFileDialog
    Friend WithEvents btnDefault As Button
    Friend WithEvents btnSave As Button

    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents File_Location_Loaded As DataGridViewTextBoxColumn
    Friend WithEvents State As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents File_Location As DataGridViewTextBoxColumn
    Friend WithEvents chkLoop1 As CheckBox
    Friend WithEvents btnStop1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents label1231 As Label
    Friend WithEvents btnStart1 As Button
    Friend WithEvents chkDarkmode As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FileLocation As DataGridViewTextBoxColumn
    Friend WithEvents btnGetMousePosition As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents chkLoop7 As CheckBox
    Friend WithEvents btnStop7 As Button
    Friend WithEvents btnStart7 As Button
    Friend WithEvents chkLoop6 As CheckBox
    Friend WithEvents btnStop6 As Button
    Friend WithEvents chkLoop5 As CheckBox
    Friend WithEvents btnStart6 As Button
    Friend WithEvents btnStop5 As Button
    Friend WithEvents btnStart5 As Button
    Friend WithEvents chkLoop4 As CheckBox
    Friend WithEvents btnStop4 As Button
    Friend WithEvents btnStart4 As Button
    Friend WithEvents chkLoop3 As CheckBox
    Friend WithEvents btnStop3 As Button
    Friend WithEvents btnStart3 As Button
    Friend WithEvents chkLoop2 As CheckBox
    Friend WithEvents btnStop2 As Button
    Friend WithEvents btnStart2 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnHotkeyGetWindow As Button
    Friend WithEvents Label10 As Label
End Class
