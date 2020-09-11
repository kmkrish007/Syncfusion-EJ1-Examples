Imports System.Drawing

Public Class About
    Inherits Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim txt As New TextBox
        txt.ID = "DynControl"
        Dim rfv As New RequiredFieldValidator
        rfv.ErrorMessage = "Error is for Dynamic Control"
        rfv.ForeColor = Color.Red
        rfv.ControlToValidate = "DynControl"

        divTest.Controls.Add(txt) 'This Is the div i spoke about In 3Rd point
        divTest.Controls.Add(rfv)
    End Sub
End Class

