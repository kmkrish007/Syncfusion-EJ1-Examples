Imports System.IO
Imports System.Web
Imports System.Web.Services

Public Class removeFile
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim s As System.Collections.Specialized.NameValueCollection = context.Request.Params
        Dim fileName As String = s("fileNames")
        Dim targetFolder As String = HttpContext.Current.Server.MapPath("uploadfiles")
        If Not Directory.Exists(targetFolder) Then
            Directory.CreateDirectory(targetFolder)
        End If
        Dim physicalPath As String = targetFolder + "\" + fileName
        If System.IO.File.Exists(physicalPath) Then
            System.IO.File.Delete(physicalPath)
        End If

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class