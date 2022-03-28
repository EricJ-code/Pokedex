Option Explicit On
Option Strict On
Public Class frmStatSpread
    Private Sub FrmStatSpread_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picPokemonStatSpread.Image = frmMain.picSprite.Image

        If frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).DexNum < 10 Then
            lblDexNum.Text = ("#00" & frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).DexNum)
        ElseIf frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).DexNum < 100 Then
            lblDexNum.Text = ("#0" & frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).DexNum)
        Else
            lblDexNum.Text = ("#" & frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).DexNum)
        End If

        lblName.Text = frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).Name

        lblUniqueHP.Text = frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).HP.ToString()
        lblUniqueAtt.Text = frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).Att.ToString()
        lblUniqueDef.Text = frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).Def.ToString()
        lblUniqueSpAtt.Text = frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).SAtt.ToString()
        lblUniqueSpDef.Text = frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).SDef.ToString()
        lblUniqueSpd.Text = frmMain.pokemon(frmMain.lstPokedex.SelectedIndex).Spd.ToString()
    End Sub
End Class