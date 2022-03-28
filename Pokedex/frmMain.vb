Public Class frmMain
    Private Const FILENAME As String = "Pokemon.txt"
    Private Const ENTRYFILE As String = "Entry.txt"
    Private file() As String
    Private dexEntryFile() As String
    Public pokemon() As Pokemon
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadIn(FILENAME)
        ReadInEntry(ENTRYFILE)
        Sort()
        AddToListBox()
        AddToAutoComplete()
    End Sub

    'SUB ReadIn
    'Reads in from .txt to array
    Private Sub ReadIn(FileName As String)
        file = IO.File.ReadAllLines(FileName)
        ReDim pokemon(file.Count - 1)

        'Reads in to an Array of class pokemon
        For i As Integer = 0 To pokemon.Count - 1
            pokemon(i) = New Pokemon()
            pokemon(i).DexNum = file(i).Split(",")(0)
            pokemon(i).Name = file(i).Split(",")(1)
            pokemon(i).HP = file(i).Split(",")(2)
            pokemon(i).Att = file(i).Split(",")(3)
            pokemon(i).Def = file(i).Split(",")(4)
            pokemon(i).SAtt = file(i).Split(",")(5)
            pokemon(i).SDef = file(i).Split(",")(6)
            pokemon(i).Spd = file(i).Split(",")(7)
            pokemon(i).TotalBaseStat = pokemon(i).GetTotalBaseStat()

            ReDim pokemon(i).Type(1)
            pokemon(i).Type(0) = file(i).Split(",")(8)
            pokemon(i).Type(1) = file(i).Split(",")(9)
        Next
    End Sub
    'SUB ReadInEntry
    'Reads in from .txt to array
    Private Sub ReadInEntry(FileName As String)
        dexEntryFile = IO.File.ReadAllLines(FileName)

        For i As Integer = 0 To pokemon.Count - 1
            For j As Integer = 0 To pokemon.Count - 1
                If pokemon(i).Name = dexEntryFile(j).Split("|")(1) Then
                    pokemon(i).DexEntry = dexEntryFile(j).Split("|")(2)
                End If
            Next
        Next
    End Sub
    'SUB Sort
    'Sorts the input data of the .txt according to dex number
    Private Sub Sort()
        For i As Integer = 0 To pokemon.Count - 1
            For j As Integer = 1 To pokemon.Count - 1
                If pokemon(j).DexNum < pokemon(j - 1).DexNum Then
                    Dim temp As Pokemon = pokemon(j)
                    pokemon(j) = pokemon(j - 1)
                    pokemon(j - 1) = temp
                End If
            Next
        Next
    End Sub

    'SUB AddToListBox
    'Adds all DexNum and Name values in pokemon() to lstPokedex
    Private Sub AddToListBox()
        For i As Integer = 0 To pokemon.Count - 1
            If pokemon(i).DexNum < 10 Then
                lstPokedex.Items.Add("#00" & pokemon(i).DexNum & " " & pokemon(i).Name)
            ElseIf pokemon(i).DexNum < 100 Then
                lstPokedex.Items.Add("#0" & pokemon(i).DexNum & " " & pokemon(i).Name)
            Else
                lstPokedex.Items.Add("#" & pokemon(i).DexNum & " " & pokemon(i).Name)
            End If
        Next
    End Sub

    'SUB AddToAutoComplete()
    'Adds all DexNum and Name values in pokemon() to the auto complete set for search
    Private Sub AddToAutoComplete()
        For i As Integer = 0 To pokemon.Count - 1
            SearchToolStripMenuItem.AutoCompleteCustomSource.Add(pokemon(i).Name)
        Next
    End Sub

    Sub ProgBarPowerLevelLogic(i As Integer)

        progPowerLevel.Value = pokemon(i).TotalBaseStat
        If progPowerLevel.Value < 300 Then
            progPowerLevel.ForeColor = Color.Firebrick
        ElseIf progPowerLevel.Value >= 300 And progPowerLevel.Value < 500 Then
            progPowerLevel.ForeColor = Color.Gold
        Else
            progPowerLevel.ForeColor = Color.Green
        End If

        lblTotalBaseStats.Text = ("Stat Total: " & pokemon(i).TotalBaseStat)

    End Sub

    'SUB CheckLogic
    'Contains the logic for chkRetro, chkRetro, lstPokemon 
    Private Sub CheckLogic()
        Try
            If chkRetro.Checked = True Then
                chkShiny.Checked = False
                chkShiny.Enabled = False
                lblType1.Visible = True
                lblType2.Visible = True
                picSprite.Image() = Image.FromFile("RetroPokemon\" & lstPokedex.SelectedItem.ToString().Substring(5).ToLower() & ".png")
                lblType1.Text = pokemon(CInt(lstPokedex.SelectedItem.ToString().Substring(1, 3)) - 1).Type(0)
                lblType2.Text = pokemon(CInt(lstPokedex.SelectedItem.ToString().Substring(1, 3)) - 1).Type(1)
                'If lblType1.Text = "fighting" Then
                '    lblType1.Text = "fight"
                'End If
                Select Case lblType1.Text
                    Case "fighting"
                        lblType1.Text = "fight"
                    Case "electric"
                        lblType1.Text = "electr"
                End Select
                Select Case lblType2.Text
                    Case "fighting"
                        lblType2.Text = "fight"
                    Case "electric"
                        Text = "electr"
                End Select
            Else
                ''''''''''
                lblType1.Visible = False
                lblType2.Visible = False
                picType1.Image() = Image.FromFile("TypeImg\" & pokemon(CInt(lstPokedex.SelectedItem.ToString().Substring(1, 3)) - 1).Type(0) & ".gif")
                If pokemon(CInt(lstPokedex.SelectedItem.ToString().Substring(1, 3)) - 1).Type(1) <> "" Then
                    picType2.Show()
                    picType2.Image() = Image.FromFile("TypeImg\" & pokemon(CInt(lstPokedex.SelectedItem.ToString().Substring(1, 3)) - 1).Type(1) & ".gif")
                Else
                    picType2.Hide()
                End If
                ''''''''''
                chkShiny.Enabled = True
                If chkShiny.Checked = True Then
                    picSprite.Image() = Image.FromFile("PokemonGifs\shiny" & lstPokedex.SelectedItem.ToString().Substring(5).ToLower() & ".gif")
                Else
                    picSprite.Image() = Image.FromFile("PokemonGifs\" & lstPokedex.SelectedItem.ToString().Substring(5).ToLower() & ".gif")
                End If
            End If
            lblPokedexEntry.Text = pokemon(CInt(lstPokedex.SelectedItem.ToString().Substring(1, 3)) - 1).DexEntry
            ProgBarPowerLevelLogic(CInt(lstPokedex.SelectedItem.ToString().Substring(1, 3)) - 1)

        Catch ex As Exception
            If lstPokedex.SelectedIndex <> -1 Then
                MessageBox.Show("Image not found")
                lblPokedexEntry.Text = pokemon(lstPokedex.SelectedIndex).DexEntry
                ProgBarPowerLevelLogic(lstPokedex.SelectedIndex)
                picSprite.Image() = picSprite.ErrorImage()
                lblType1.Visible = False
                lblType2.Visible = False
                picType1.Image() = Image.FromFile("TypeImg\" & pokemon(lstPokedex.SelectedIndex).Type(0) & ".gif")
                If pokemon(lstPokedex.SelectedIndex).Type(1) <> "" Then
                    picType2.Show()
                    picType2.Image() = Image.FromFile("TypeImg\" & pokemon(lstPokedex.SelectedIndex).Type(1) & ".gif")
                Else
                    picType2.Hide()
                End If
            End If
        End Try
    End Sub
    Private Sub ChkShiny_Click(sender As Object, e As EventArgs) Handles chkShiny.Click
        CheckLogic()
    End Sub

    Private Sub ChkRetro_Click(sender As Object, e As EventArgs) Handles chkRetro.Click
        CheckLogic()
    End Sub

    Private Sub LstPokedex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPokedex.SelectedIndexChanged
        CheckLogic()
    End Sub
    '--------------------------------------------------------------------
    '--------------------------------------------------------------------
    '--------------------------------------------------------------------


    'Filter by Type
    Private Sub TypeToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles TypeToolStripMenuItem.MouseLeave
        With TypeToolStripMenuItem
            If .Text = "None" Or .Text = "" Then
                .Text = "Type"
            End If
        End With
    End Sub

    Private Sub TypeToolStripMenuItem_KeyDown(sender As Object, e As KeyEventArgs) Handles TypeToolStripMenuItem.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            lstPokedex.Items.Clear()
            If TypeToolStripMenuItem.Text = "None" Then
                AddToListBox()
            Else
                For i As Integer = 0 To pokemon.Count - 1
                    If pokemon(i).Type(0) = TypeToolStripMenuItem.Text.ToLower() Or pokemon(i).Type(1) = TypeToolStripMenuItem.Text.ToLower() Then
                        If pokemon(i).DexNum < 10 Then
                            lstPokedex.Items.Add("#00" & pokemon(i).DexNum & " " & pokemon(i).Name)
                        ElseIf pokemon(i).DexNum < 100 Then
                            lstPokedex.Items.Add("#0" & pokemon(i).DexNum & " " & pokemon(i).Name)
                        Else
                            lstPokedex.Items.Add("#" & pokemon(i).DexNum & " " & pokemon(i).Name)
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub TypeToolStripMenuItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeToolStripMenuItem.SelectedIndexChanged
        lstPokedex.Items.Clear()
        If TypeToolStripMenuItem.Text = "None" Then
            AddToListBox()
        Else
            For i As Integer = 0 To pokemon.Count - 1
                If pokemon(i).Type(0) = TypeToolStripMenuItem.Text.ToLower() Or pokemon(i).Type(1) = TypeToolStripMenuItem.Text.ToLower() Then
                    If pokemon(i).DexNum < 10 Then
                        lstPokedex.Items.Add("#00" & pokemon(i).DexNum & " " & pokemon(i).Name)
                    ElseIf pokemon(i).DexNum < 100 Then
                        lstPokedex.Items.Add("#0" & pokemon(i).DexNum & " " & pokemon(i).Name)
                    Else
                        lstPokedex.Items.Add("#" & pokemon(i).DexNum & " " & pokemon(i).Name)
                    End If
                End If
            Next
        End If
    End Sub

    'Search By Name 
    Private Sub SearchToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.MouseEnter
        SearchToolStripMenuItem.Clear()
    End Sub
    Private Sub SearchToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.MouseLeave
        With SearchToolStripMenuItem
            If .Text = "" Then
                SearchToolStripMenuItem.Text = "Search By Name"
            End If
        End With
    End Sub
    Private Sub SearchToolStripMenuItem_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchToolStripMenuItem.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            lstPokedex.Items.Clear()
            If SearchToolStripMenuItem.Text = "" Or SearchToolStripMenuItem.Text = "Search By Name" Then
                AddToListBox()
            Else

                For i As Integer = 0 To pokemon.Count - 1
                    If pokemon(i).Name().ToLower() = SearchToolStripMenuItem.Text.ToLower() Then
                        If pokemon(i).DexNum < 10 Then
                            lstPokedex.Items.Add("#00" & pokemon(i).DexNum & " " & pokemon(i).Name)
                        ElseIf pokemon(i).DexNum < 100 Then
                            lstPokedex.Items.Add("#0" & pokemon(i).DexNum & " " & pokemon(i).Name)
                        Else
                            lstPokedex.Items.Add("#" & pokemon(i).DexNum & " " & pokemon(i).Name)
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Loading new stat spreads
    Private Sub LblTotalBaseStats_Click(sender As Object, e As EventArgs) Handles lblTotalBaseStats.Click
        Dim statSpecific As frmStatSpread = New frmStatSpread
        statSpecific.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub


End Class
