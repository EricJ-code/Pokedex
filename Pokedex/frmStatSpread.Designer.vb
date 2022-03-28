<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatSpread
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatSpread))
        Me.lblDexNum = New System.Windows.Forms.Label()
        Me.picPokemonStatSpread = New System.Windows.Forms.PictureBox()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblAtt = New System.Windows.Forms.Label()
        Me.lblDef = New System.Windows.Forms.Label()
        Me.lblSpAtt = New System.Windows.Forms.Label()
        Me.lblSpDef = New System.Windows.Forms.Label()
        Me.lblSpd = New System.Windows.Forms.Label()
        Me.lblUniqueHP = New System.Windows.Forms.Label()
        Me.lblUniqueAtt = New System.Windows.Forms.Label()
        Me.lblUniqueDef = New System.Windows.Forms.Label()
        Me.lblUniqueSpAtt = New System.Windows.Forms.Label()
        Me.lblUniqueSpDef = New System.Windows.Forms.Label()
        Me.lblUniqueSpd = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.picPokemonStatSpread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDexNum
        '
        Me.lblDexNum.AutoSize = True
        Me.lblDexNum.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDexNum.Location = New System.Drawing.Point(120, 12)
        Me.lblDexNum.Name = "lblDexNum"
        Me.lblDexNum.Size = New System.Drawing.Size(0, 21)
        Me.lblDexNum.TabIndex = 1
        '
        'picPokemonStatSpread
        '
        Me.picPokemonStatSpread.BackgroundImage = CType(resources.GetObject("picPokemonStatSpread.BackgroundImage"), System.Drawing.Image)
        Me.picPokemonStatSpread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPokemonStatSpread.Location = New System.Drawing.Point(12, 12)
        Me.picPokemonStatSpread.Name = "picPokemonStatSpread"
        Me.picPokemonStatSpread.Size = New System.Drawing.Size(102, 103)
        Me.picPokemonStatSpread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPokemonStatSpread.TabIndex = 0
        Me.picPokemonStatSpread.TabStop = False
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP.Location = New System.Drawing.Point(12, 130)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(47, 21)
        Me.lblHP.TabIndex = 2
        Me.lblHP.Text = "HP:"
        '
        'lblAtt
        '
        Me.lblAtt.AutoSize = True
        Me.lblAtt.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtt.Location = New System.Drawing.Point(12, 151)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(62, 21)
        Me.lblAtt.TabIndex = 3
        Me.lblAtt.Text = "ATT:"
        '
        'lblDef
        '
        Me.lblDef.AutoSize = True
        Me.lblDef.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDef.Location = New System.Drawing.Point(12, 172)
        Me.lblDef.Name = "lblDef"
        Me.lblDef.Size = New System.Drawing.Size(62, 21)
        Me.lblDef.TabIndex = 4
        Me.lblDef.Text = "DEF:"
        '
        'lblSpAtt
        '
        Me.lblSpAtt.AutoSize = True
        Me.lblSpAtt.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpAtt.Location = New System.Drawing.Point(12, 193)
        Me.lblSpAtt.Name = "lblSpAtt"
        Me.lblSpAtt.Size = New System.Drawing.Size(104, 21)
        Me.lblSpAtt.TabIndex = 5
        Me.lblSpAtt.Text = "SP. ATT:"
        '
        'lblSpDef
        '
        Me.lblSpDef.AutoSize = True
        Me.lblSpDef.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpDef.Location = New System.Drawing.Point(12, 214)
        Me.lblSpDef.Name = "lblSpDef"
        Me.lblSpDef.Size = New System.Drawing.Size(104, 21)
        Me.lblSpDef.TabIndex = 6
        Me.lblSpDef.Text = "SP. DEF:"
        '
        'lblSpd
        '
        Me.lblSpd.AutoSize = True
        Me.lblSpd.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpd.Location = New System.Drawing.Point(12, 235)
        Me.lblSpd.Name = "lblSpd"
        Me.lblSpd.Size = New System.Drawing.Size(62, 21)
        Me.lblSpd.TabIndex = 7
        Me.lblSpd.Text = "SPD:"
        '
        'lblUniqueHP
        '
        Me.lblUniqueHP.AutoSize = True
        Me.lblUniqueHP.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueHP.Location = New System.Drawing.Point(120, 130)
        Me.lblUniqueHP.Name = "lblUniqueHP"
        Me.lblUniqueHP.Size = New System.Drawing.Size(0, 21)
        Me.lblUniqueHP.TabIndex = 8
        '
        'lblUniqueAtt
        '
        Me.lblUniqueAtt.AutoSize = True
        Me.lblUniqueAtt.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueAtt.Location = New System.Drawing.Point(120, 151)
        Me.lblUniqueAtt.Name = "lblUniqueAtt"
        Me.lblUniqueAtt.Size = New System.Drawing.Size(0, 21)
        Me.lblUniqueAtt.TabIndex = 9
        '
        'lblUniqueDef
        '
        Me.lblUniqueDef.AutoSize = True
        Me.lblUniqueDef.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueDef.Location = New System.Drawing.Point(120, 172)
        Me.lblUniqueDef.Name = "lblUniqueDef"
        Me.lblUniqueDef.Size = New System.Drawing.Size(0, 21)
        Me.lblUniqueDef.TabIndex = 10
        '
        'lblUniqueSpAtt
        '
        Me.lblUniqueSpAtt.AutoSize = True
        Me.lblUniqueSpAtt.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueSpAtt.Location = New System.Drawing.Point(120, 193)
        Me.lblUniqueSpAtt.Name = "lblUniqueSpAtt"
        Me.lblUniqueSpAtt.Size = New System.Drawing.Size(0, 21)
        Me.lblUniqueSpAtt.TabIndex = 11
        '
        'lblUniqueSpDef
        '
        Me.lblUniqueSpDef.AutoSize = True
        Me.lblUniqueSpDef.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueSpDef.Location = New System.Drawing.Point(120, 214)
        Me.lblUniqueSpDef.Name = "lblUniqueSpDef"
        Me.lblUniqueSpDef.Size = New System.Drawing.Size(0, 21)
        Me.lblUniqueSpDef.TabIndex = 12
        '
        'lblUniqueSpd
        '
        Me.lblUniqueSpd.AutoSize = True
        Me.lblUniqueSpd.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueSpd.Location = New System.Drawing.Point(120, 235)
        Me.lblUniqueSpd.Name = "lblUniqueSpd"
        Me.lblUniqueSpd.Size = New System.Drawing.Size(0, 21)
        Me.lblUniqueSpd.TabIndex = 13
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Pokemon Classic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(120, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 21)
        Me.lblName.TabIndex = 14
        '
        'frmStatSpread
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(259, 293)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblUniqueSpd)
        Me.Controls.Add(Me.lblUniqueSpDef)
        Me.Controls.Add(Me.lblUniqueSpAtt)
        Me.Controls.Add(Me.lblUniqueDef)
        Me.Controls.Add(Me.lblUniqueAtt)
        Me.Controls.Add(Me.lblUniqueHP)
        Me.Controls.Add(Me.lblSpd)
        Me.Controls.Add(Me.lblSpDef)
        Me.Controls.Add(Me.lblSpAtt)
        Me.Controls.Add(Me.lblDef)
        Me.Controls.Add(Me.lblAtt)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.lblDexNum)
        Me.Controls.Add(Me.picPokemonStatSpread)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStatSpread"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmStatSpread"
        CType(Me.picPokemonStatSpread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPokemonStatSpread As PictureBox
    Friend WithEvents lblDexNum As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblAtt As Label
    Friend WithEvents lblDef As Label
    Friend WithEvents lblSpAtt As Label
    Friend WithEvents lblSpDef As Label
    Friend WithEvents lblSpd As Label
    Friend WithEvents lblUniqueHP As Label
    Friend WithEvents lblUniqueAtt As Label
    Friend WithEvents lblUniqueDef As Label
    Friend WithEvents lblUniqueSpAtt As Label
    Friend WithEvents lblUniqueSpDef As Label
    Friend WithEvents lblUniqueSpd As Label
    Friend WithEvents lblName As Label
End Class
