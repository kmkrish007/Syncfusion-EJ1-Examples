Imports System.Data.SqlClient
Imports Syncfusion.JavaScript

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    <System.Web.Services.WebMethod>
    Public Shared Function FileActionDefault(ByVal ActionType As String, ByVal Path As String, ByVal ExtensionsAllow As String, ByVal LocationFrom As String, ByVal LocationTo As String, ByVal Name As String, ByVal Names As String(), ByVal NewName As String, ByVal Action As String, ByVal CommonFiles As IEnumerable(Of CommonFileDetails)) As Object
        Dim operation As FileExplorerOperations = New FileExplorerOperations()

        Select Case ActionType
            Case "Read"
                Return (operation.Read(Path, ExtensionsAllow))
            Case "CreateFolder"
                Return (operation.CreateFolder(Path, Name))
            Case "Paste"
                operation.Paste(LocationFrom, LocationTo, Names, Action, CommonFiles)
            Case "Remove"
                operation.Remove(Names, Path)
            Case "Rename"
                operation.Rename(Path, Name, NewName, CommonFiles)
            Case "GetDetails"
                Return (operation.GetDetails(Path, Names))
        End Select

        Return ""
    End Function
End Class