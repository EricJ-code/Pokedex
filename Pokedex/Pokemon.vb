Public Class Pokemon

    Public Property DexNum() As Integer
    Public Property Name() As String
    Public Property HP() As Integer
    Public Property Att() As Integer
    Public Property Def() As Integer
    Public Property SAtt() As Integer
    Public Property SDef() As Integer
    Public Property Spd() As Integer
    Public Property TotalBaseStat() As Integer
    Public Type() As String 'Change to type class once created
    Public Property DexEntry() As String

    Function GetTotalBaseStat()
        Return (HP + Att + Def + SAtt + SDef + Spd)
    End Function

End Class
