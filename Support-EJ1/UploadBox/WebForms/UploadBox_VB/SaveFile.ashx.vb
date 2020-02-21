Imports System.IO
Imports System.Web
Imports System.Web.Services

Public Class SaveFile
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim targetFolder As String = HttpContext.Current.Server.MapPath("tempFiles")
        If Not Directory.Exists(targetFolder) Then
            Directory.CreateDirectory(targetFolder)
        End If

        Dim request As HttpRequest = context.Request
        Dim uploadedFiles As HttpFileCollection = context.Request.Files
        If uploadedFiles IsNot Nothing AndAlso uploadedFiles.Count > 0 Then

            Dim i As Integer = 0

            While i < uploadedFiles.Count
                Dim fileName As String = uploadedFiles(i).FileName
                Dim indx As Integer = fileName.LastIndexOf("\")
                If indx > -1 Then
                    fileName = fileName.Substring(indx + 1)
                End If

                'fileName = "TEMP-" & DateTime.Now.ToString("MMddyyyy") & "_" & Replace(LCase(Strings.Trim(fileName)), " ", "_") 
                uploadedFiles(i).SaveAs(targetFolder & "\" & LCase(fileName))

                i += 1


            End While

        Else
        End If

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class