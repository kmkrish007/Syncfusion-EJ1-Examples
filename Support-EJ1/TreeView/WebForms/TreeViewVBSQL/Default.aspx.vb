Imports System.Data.SqlClient

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim conn As New SqlConnection
        Dim SQLCMD As New SqlCommand

        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NORTHWND.MDF;Integrated Security=True"
        conn.Open()
        'Check the postback
        If IsPostBack Then
            'if postback then get the data from table TreeData1
            TreeViewPlans.DataSource = Nothing

            'SQLCMD = New SqlCommand("SELECT * FROM TreeData1", conn)

            SQLCMD = New SqlCommand("SELECT * FROM CTreeData", conn)
            SQLCMD.ExecuteNonQuery()
            Dim dt = New DataTable
            Dim A = New SqlDataAdapter(SQLCMD)
            A.Fill(dt)
            'TreeViewPlans.DataSource = dt

            TreeViewPlans.Fields.Id = "Id"
            TreeViewPlans.Fields.ParentId = "ParentID"
            TreeViewPlans.Fields.Text = "Text"
            TreeViewPlans.Fields.Expanded = "Expanded"
            TreeViewPlans.Fields.HasChild = "HasChild"
            TreeViewPlans.Fields.IsChecked = "Checking"
            TreeViewPlans.Fields.DataSource = dt
        Else
            'if not postback then get the data from table TreeData
            SQLCMD = New SqlCommand("SELECT * FROM TreeData", conn)
            SQLCMD.ExecuteNonQuery()
            Dim dt = New DataTable
            Dim A = New SqlDataAdapter(SQLCMD)
            A.Fill(dt)
            TreeViewPlans.DataSource = dt

        End If
    End Sub

End Class