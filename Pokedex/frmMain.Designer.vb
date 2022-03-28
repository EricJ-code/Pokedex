<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeToolStripMenuItem = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripTextBox()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstPokedex = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkShiny = New System.Windows.Forms.CheckBox()
        Me.chkRetro = New System.Windows.Forms.CheckBox()
        Me.lblPokedexEntry = New System.Windows.Forms.Label()
        Me.picSprite = New System.Windows.Forms.PictureBox()
        Me.picType1 = New System.Windows.Forms.PictureBox()
        Me.picType2 = New System.Windows.Forms.PictureBox()
        Me.lblType1 = New System.Windows.Forms.Label()
        Me.lblType2 = New System.Windows.Forms.Label()
        Me.progPowerLevel = New System.Windows.Forms.ProgressBar()
        Me.lblTotalBaseStats = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picType1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picType2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TypeToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(68, 29)
        Me.FilterToolStripMenuItem.Text = "&Filter"
        '
        'TypeToolStripMenuItem
        '
        Me.TypeToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.TypeToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeToolStripMenuItem.Items.AddRange(New Object() {"None", "Bug", "Dark", "Dragon", "Electric", "Fairy", "Fighting", "Fire", "Flying", "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Psychic", "Rock", "Steel", "Water"})
        Me.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem"
        Me.TypeToolStripMenuItem.Size = New System.Drawing.Size(240, 28)
        Me.TypeToolStripMenuItem.Text = "Type"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.SearchToolStripMenuItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SearchToolStripMenuItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SearchToolStripMenuItem.Text = "Search By Name"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Gen1ToolStripMenuItem, Me.Gen2ToolStripMenuItem, Me.Gen3ToolStripMenuItem, Me.Gen4ToolStripMenuItem, Me.Gen5ToolStripMenuItem, Me.Gen6ToolStripMenuItem, Me.Gen7ToolStripMenuItem, Me.Gen8ToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(59, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'Gen1ToolStripMenuItem
        '
        Me.Gen1ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen1ToolStripMenuItem.Name = "Gen1ToolStripMenuItem"
        Me.Gen1ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen1ToolStripMenuItem.Text = "Gen 1"
        '
        'Gen2ToolStripMenuItem
        '
        Me.Gen2ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen2ToolStripMenuItem.Name = "Gen2ToolStripMenuItem"
        Me.Gen2ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen2ToolStripMenuItem.Text = "Gen 2"
        '
        'Gen3ToolStripMenuItem
        '
        Me.Gen3ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen3ToolStripMenuItem.Name = "Gen3ToolStripMenuItem"
        Me.Gen3ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen3ToolStripMenuItem.Text = "Gen 3"
        '
        'Gen4ToolStripMenuItem
        '
        Me.Gen4ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen4ToolStripMenuItem.Name = "Gen4ToolStripMenuItem"
        Me.Gen4ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen4ToolStripMenuItem.Text = "Gen 4"
        '
        'Gen5ToolStripMenuItem
        '
        Me.Gen5ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen5ToolStripMenuItem.Name = "Gen5ToolStripMenuItem"
        Me.Gen5ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen5ToolStripMenuItem.Text = "Gen 5"
        '
        'Gen6ToolStripMenuItem
        '
        Me.Gen6ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen6ToolStripMenuItem.Name = "Gen6ToolStripMenuItem"
        Me.Gen6ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen6ToolStripMenuItem.Text = "Gen 6"
        '
        'Gen7ToolStripMenuItem
        '
        Me.Gen7ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen7ToolStripMenuItem.Name = "Gen7ToolStripMenuItem"
        Me.Gen7ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen7ToolStripMenuItem.Text = "Gen 7"
        '
        'Gen8ToolStripMenuItem
        '
        Me.Gen8ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gen8ToolStripMenuItem.Name = "Gen8ToolStripMenuItem"
        Me.Gen8ToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.Gen8ToolStripMenuItem.Text = "Gen 8"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(66, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(150, 30)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'lstPokedex
        '
        Me.lstPokedex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPokedex.FormattingEnabled = True
        Me.lstPokedex.ItemHeight = 25
        Me.lstPokedex.Location = New System.Drawing.Point(471, 46)
        Me.lstPokedex.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstPokedex.Name = "lstPokedex"
        Me.lstPokedex.Size = New System.Drawing.Size(341, 304)
        Me.lstPokedex.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 33)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'chkShiny
        '
        Me.chkShiny.AutoSize = True
        Me.chkShiny.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShiny.Location = New System.Drawing.Point(235, 46)
        Me.chkShiny.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShiny.Name = "chkShiny"
        Me.chkShiny.Size = New System.Drawing.Size(134, 29)
        Me.chkShiny.TabIndex = 5
        Me.chkShiny.Text = "Shiny Form"
        Me.chkShiny.UseVisualStyleBackColor = True
        '
        'chkRetro
        '
        Me.chkRetro.AutoSize = True
        Me.chkRetro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetro.Location = New System.Drawing.Point(235, 84)
        Me.chkRetro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkRetro.Name = "chkRetro"
        Me.chkRetro.Size = New System.Drawing.Size(80, 29)
        Me.chkRetro.TabIndex = 6
        Me.chkRetro.Text = "Retro"
        Me.chkRetro.UseVisualStyleBackColor = True
        '
        'lblPokedexEntry
        '
        Me.lblPokedexEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPokedexEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPokedexEntry.Location = New System.Drawing.Point(16, 254)
        Me.lblPokedexEntry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPokedexEntry.Name = "lblPokedexEntry"
        Me.lblPokedexEntry.Size = New System.Drawing.Size(447, 117)
        Me.lblPokedexEntry.TabIndex = 7
        Me.lblPokedexEntry.Text = "[Entry]"
        '
        'picSprite
        '
        Me.picSprite.BackgroundImage = CType(resources.GetObject("picSprite.BackgroundImage"), System.Drawing.Image)
        Me.picSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSprite.Location = New System.Drawing.Point(16, 52)
        Me.picSprite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picSprite.Name = "picSprite"
        Me.picSprite.Size = New System.Drawing.Size(209, 175)
        Me.picSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSprite.TabIndex = 2
        Me.picSprite.TabStop = False
        '
        'picType1
        '
        Me.picType1.Location = New System.Drawing.Point(235, 128)
        Me.picType1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picType1.Name = "picType1"
        Me.picType1.Size = New System.Drawing.Size(107, 28)
        Me.picType1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picType1.TabIndex = 8
        Me.picType1.TabStop = False
        '
        'picType2
        '
        Me.picType2.Location = New System.Drawing.Point(356, 128)
        Me.picType2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picType2.Name = "picType2"
        Me.picType2.Size = New System.Drawing.Size(107, 28)
        Me.picType2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picType2.TabIndex = 9
        Me.picType2.TabStop = False
        '
        'lblType1
        '
        Me.lblType1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblType1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType1.Location = New System.Drawing.Point(235, 128)
        Me.lblType1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType1.Name = "lblType1"
        Me.lblType1.Size = New System.Drawing.Size(106, 28)
        Me.lblType1.TabIndex = 10
        Me.lblType1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblType2
        '
        Me.lblType2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType2.Location = New System.Drawing.Point(356, 128)
        Me.lblType2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblType2.Name = "lblType2"
        Me.lblType2.Size = New System.Drawing.Size(106, 28)
        Me.lblType2.TabIndex = 11
        Me.lblType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progPowerLevel
        '
        Me.progPowerLevel.ForeColor = System.Drawing.Color.Firebrick
        Me.progPowerLevel.Location = New System.Drawing.Point(235, 199)
        Me.progPowerLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.progPowerLevel.Maximum = 720
        Me.progPowerLevel.Name = "progPowerLevel"
        Me.progPowerLevel.Size = New System.Drawing.Size(228, 28)
        Me.progPowerLevel.TabIndex = 12
        '
        'lblTotalBaseStats
        '
        Me.lblTotalBaseStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBaseStats.Location = New System.Drawing.Point(235, 171)
        Me.lblTotalBaseStats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalBaseStats.Name = "lblTotalBaseStats"
        Me.lblTotalBaseStats.Size = New System.Drawing.Size(227, 25)
        Me.lblTotalBaseStats.TabIndex = 13
        Me.lblTotalBaseStats.Text = "Stat Total:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(829, 400)
        Me.Controls.Add(Me.lblTotalBaseStats)
        Me.Controls.Add(Me.progPowerLevel)
        Me.Controls.Add(Me.lblType2)
        Me.Controls.Add(Me.lblType1)
        Me.Controls.Add(Me.picType2)
        Me.Controls.Add(Me.picType1)
        Me.Controls.Add(Me.lblPokedexEntry)
        Me.Controls.Add(Me.chkRetro)
        Me.Controls.Add(Me.chkShiny)
        Me.Controls.Add(Me.picSprite)
        Me.Controls.Add(Me.lstPokedex)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokedex"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picType1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picType2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstPokedex As ListBox
    Friend WithEvents TypeToolStripMenuItem As ToolStripComboBox
    Friend WithEvents SearchToolStripMenuItem As ToolStripTextBox
    Friend WithEvents picSprite As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents chkShiny As CheckBox
    Friend WithEvents chkRetro As CheckBox
    Friend WithEvents Gen1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Gen2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Gen3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Gen4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Gen5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Gen6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Gen7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Gen8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPokedexEntry As Label
    Friend WithEvents picType1 As PictureBox
    Friend WithEvents picType2 As PictureBox
    Friend WithEvents lblType1 As Label
    Friend WithEvents lblType2 As Label
    Friend WithEvents progPowerLevel As ProgressBar
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTotalBaseStats As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
