
Imports System.IO

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    <System.Web.Services.WebMethod>
    Public Shared Function Upload(ByVal target As String) As String
        Dim imageData, path, fileNameWitPath As String
        imageData = target
        path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + "Images\"
        fileNameWitPath = path & DateTime.Now.ToString().Replace("/", "-").Replace(" ", "- ").Replace(":", "") & ".png"

        Using fs As FileStream = New FileStream(fileNameWitPath, FileMode.Create)

            Using bw As BinaryWriter = New BinaryWriter(fs)
                Dim data As Byte() = Convert.FromBase64String(imageData)
                bw.Write(data)
                bw.Close()
            End Using
        End Using
        Return "successfully saved in folder"
    End Function

End Class