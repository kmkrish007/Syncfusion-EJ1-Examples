Imports System.Reflection

Public Class TACSettings
    Public Shared Sub AddAreaIndxFieldItems(ByVal IndexItems As Dictionary(Of Integer, IndexAreaField), ByVal indxFieldName As String,
                                     ByVal indxFieldType As String, ByVal indxFieldId As Integer)
        Dim oIdxArFld As New IndexAreaField
        With oIdxArFld
            .FieldName = indxFieldName
            .FieldType = indxFieldType
            .IndexColId = indxFieldId
        End With

        IndexItems.Add(key:=oIdxArFld.IndexColId, value:=oIdxArFld)

    End Sub

    Public Shared Function ToDataTable(Of T)(ByVal items As List(Of T)) As DataTable

        Dim types As List(Of Type) = Nothing

        types = New List(Of Type)() From {
                GetType(Boolean),
                GetType(Integer),
                GetType(Double),
                GetType(Decimal),
                GetType(Single),
                GetType(Long)
            }
        Dim dataTable As DataTable = New DataTable(GetType(T).Name)
        Dim Props As PropertyInfo() = GetType(T).GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)

        For Each prop As PropertyInfo In Props
            dataTable.Columns.Add(prop.Name, prop.PropertyType)
        Next

        For Each item As T In items

            If item IsNot Nothing Then
                Dim dr As DataRow = dataTable.NewRow()

                For Each p As PropertyInfo In Props

                    If types.IndexOf(p.PropertyType) >= 0 Then
                        dr(p.Name) = p.GetValue(item)
                    Else
                        dr(p.Name) = If(p.GetValue(item), Nothing)
                    End If
                Next

                dataTable.Rows.Add(dr)
            End If
        Next

        Return dataTable
    End Function




End Class
Public Class TACTemplateAreas
    Public Property TACAppArea As String
    Public Shared Function GetAppAreaList() As List(Of TACTemplateAreas)
        Dim datatypeRef As List(Of TACTemplateAreas) = New List(Of TACTemplateAreas)()
        datatypeRef.Add(New TACTemplateAreas With {.TACAppArea = "TEL"})
        datatypeRef.Add(New TACTemplateAreas With {.TACAppArea = "TEB"})
        datatypeRef.Add(New TACTemplateAreas With {.TACAppArea = "KEL"})
        Return datatypeRef
    End Function
End Class

Public Class IndexFieldType
    Public Property TypeDescRef As String
    Public Shared Function GetTypeRefList() As List(Of IndexFieldType)
        Dim datatypeRef As List(Of IndexFieldType) = New List(Of IndexFieldType)()
        datatypeRef.Add(New IndexFieldType With {.TypeDescRef = "Text"})
        datatypeRef.Add(New IndexFieldType With {.TypeDescRef = "Text Multiline"})
        datatypeRef.Add(New IndexFieldType With {.TypeDescRef = "Date"})
        datatypeRef.Add(New IndexFieldType With {.TypeDescRef = "Boolean"})
        datatypeRef.Add(New IndexFieldType With {.TypeDescRef = "Text Multiple Choice"})
        Return datatypeRef
    End Function


End Class

<Serializable> Public Class IndexAreaField
    Public Property FieldName As String
    Public Property FieldType As String
    Public Property IndexColId As Integer



End Class
<Serializable>
Public Class Question
    'Public Sub New()
    'End Sub

    'Public Sub New(ByVal DataId As Integer, ByVal Question As String, ByVal FieldType As String, ByVal SectioHeader As String, ByVal Display As Boolean)
    '    Me.DataFieldId = DataId
    '    Me.QuestionDesc = Question
    '    Me.DataFieldType = FieldType
    '    Me.QnSectioHeader = SectioHeader
    '    Me.blnDisplay = Display

    'End Sub

    Public Property DataFieldId As Integer
    Public Property QuestionDesc As String
    Public Property DataFieldType As String
    Public Property QnSectioHeader As String
    Public Property blnDisplay As Boolean
End Class

