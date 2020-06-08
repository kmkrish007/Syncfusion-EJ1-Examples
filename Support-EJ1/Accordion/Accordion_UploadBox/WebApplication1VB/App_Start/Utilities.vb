Public Class Utilities
    Public Shared Function Coalesce(ParamArray myvals() As Object) As Object
        For i As Integer = 0 To myvals.Length - 1
            If myvals(i) Is Nothing OrElse IsDBNull(myvals(i)) Then Continue For
            Return myvals(i)
        Next
        Return Nothing
    End Function

    Public Shared Sub ASPNET_Confirm_MsgBox(ByVal Message As String)
        'JavaScript to display message box if User Name & Password not found
        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=""JavaScript"">" & vbCrLf)
        System.Web.HttpContext.Current.Response.Write("var retval = confirm(""" & Message & """)" & vbCrLf)
        System.Web.HttpContext.Current.Response.Write("</SCRIPT>")
    End Sub
    Public Shared Function UploadFile(fileUploadObject As FileUpload, sUserUpload As String, blnActiveFile As Boolean, Optional OverWriteFileID As Integer = 0) As Integer
        Dim contentType As String = fileUploadObject.PostedFile.ContentType
        Dim fileData As Byte() = New Byte(fileUploadObject.PostedFile.InputStream.Length - 1) {}
        fileUploadObject.PostedFile.InputStream.Read(fileData, 0, fileData.Length)
        Dim fileSize As Long = fileUploadObject.PostedFile.ContentLength
        Dim originalName As String = IO.Path.GetFileName(fileUploadObject.PostedFile.FileName)

        Dim FileID As Integer
        'SQL Code goes here to upload the file
        ' FileID = SimpleSQL.runProcedureScalar("csWebData", "TACTmplt_SaveFiles", FileID, Today, sUserUpload, blnActiveFile, OverWriteFileID, originalName, contentType, fileSize, fileData)

        Return FileID
    End Function
End Class
