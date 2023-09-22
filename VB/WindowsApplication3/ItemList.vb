Imports System.ComponentModel

Namespace WindowsApplication3

    Public Module ItemList

        Public Function GetList() As BindingList(Of Item)
            Dim list = New BindingList(Of Item)()
            For i As Integer = 0 To 50 - 1
                list.Add(New Item() With {.Column1 = "Test1" & i, .Column2 = "Test2" & i, .Column3 = "Test3" & i, .Column4 = "Test4" & i, .Column5 = "Test5" & i, .Column6 = "Test6" & i, .Column7 = "Test7" & i, .Column8 = "Test8" & i, .Column9 = "Test9" & i, .Column10 = "Test10" & i, .Column11 = "Test11" & i, .Column12 = "Test12" & i, .Column13 = "Test13" & i, .Column14 = "Test14" & i, .Column15 = "Test15" & i, .Column16 = "Test16" & i})
            Next

            Return list
        End Function
    End Module

    Public Class Item

        Public Property Column1 As String

        Public Property Column2 As String

        Public Property Column3 As String

        Public Property Column4 As String

        Public Property Column5 As String

        Public Property Column6 As String

        Public Property Column7 As String

        Public Property Column8 As String

        Public Property Column9 As String

        Public Property Column10 As String

        Public Property Column11 As String

        Public Property Column12 As String

        Public Property Column13 As String

        Public Property Column14 As String

        Public Property Column15 As String

        Public Property Column16 As String
    End Class
End Namespace
