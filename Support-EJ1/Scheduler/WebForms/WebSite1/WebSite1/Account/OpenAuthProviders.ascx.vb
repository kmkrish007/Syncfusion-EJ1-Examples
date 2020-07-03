Imports Microsoft.AspNet.Membership.OpenAuth

Partial Class Account_OpenAuthProviders
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        AddHandler Page.PreRenderComplete, AddressOf Page_PreRenderComplete

        
        If IsPostBack Then
            Dim provider = Request.Form("provider")
            If provider Is Nothing Then
                Return
            End If

            Dim redirectUrl = "~/Account/RegisterExternalLogin"
            If Not String.IsNullOrEmpty(ReturnUrl) Then
                Dim resolvedReturnUrl = ResolveUrl(ReturnUrl)
                redirectUrl += "?ReturnUrl=" + HttpUtility.UrlEncode(resolvedReturnUrl)
            End If

            OpenAuth.RequestAuthentication(provider, redirectUrl)
        End If
    End Sub

    
    Protected Sub Page_PreRenderComplete(ByVal sender As Object, ByVal e As System.EventArgs)
        providersList.DataSource = OpenAuth.AuthenticationClients.GetAll()
        providersList.DataBind()
    End Sub

    Protected Function Item(Of T As Class)() As T
        Return TryCast(Page.GetDataItem(), T)
    End Function
    

    Public Property ReturnUrl As String

    
End Class
