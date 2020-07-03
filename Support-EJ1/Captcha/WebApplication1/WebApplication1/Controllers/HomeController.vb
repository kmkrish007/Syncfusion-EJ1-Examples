Imports Syncfusion.JavaScript
Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Function Index() As ActionResult
        Dim targetInstance As New Syncfusion.JavaScript.Models.CaptchaProperties()
        Dim strangeType As Type = GetType(Syncfusion.JavaScript.Models.CaptchaProperties)
        Dim PropertyUppercase As Reflection.PropertyInfo = strangeType.GetProperty("EnableAudio")
        PropertyUppercase.SetValue(targetInstance, True)
        PropertyUppercase = strangeType.GetProperty("EnableRefreshImage")
        PropertyUppercase.SetValue(targetInstance, True)
        PropertyUppercase = strangeType.GetProperty("EnableCaseSensitivity")
        PropertyUppercase.SetValue(targetInstance, True)
        PropertyUppercase = strangeType.GetProperty("Height")
        PropertyUppercase.SetValue(targetInstance, 66)

        ViewBag.CaptchaUrl = targetInstance.RenderCaptchaImage
        PropertyUppercase = strangeType.GetProperty("EncryptedCode")
        ViewBag.EncryptedCode = PropertyUppercase.GetValue(targetInstance)
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Refresh(params As CaptchaParams) As ActionResult
        Return params.CaptchaActions
    End Function


End Class
