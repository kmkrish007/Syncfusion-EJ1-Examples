#pragma checksum "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fed931ecd5b1e131c613dc0a2de445e7832180e"
// <auto-generated/>
#pragma warning disable 1591
namespace TreeViewTemplate.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using TreeViewTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using TreeViewTemplate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor"
using Syncfusion.EJ2.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor"
using Syncfusion.EJ2.Blazor.Inputs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "control_wrapper");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.Inputs.EjsTextBox>(3);
            __builder.AddAttribute(4, "Placeholder", "Search");
            __builder.AddAttribute(5, "Input", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.EJ2.Blazor.Inputs.InputEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.EJ2.Blazor.Inputs.InputEventArgs>(this, 
#nullable restore
#line 7 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor"
                                                Change

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Syncfusion.EJ2.Blazor.Navigations.EjsTreeView<TreeData>>(7);
            __builder.AddAttribute(8, "ModelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor"
                                 ModelType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __Blazor.TreeViewTemplate.Pages.Index.TypeInference.CreateTreeViewFieldsSettings_0(__builder2, 11, 12, "Id", 13, "Name", 14, "Pid", 15, "HasChild", 16, "Selected", 17, "Expanded", 18, 
#nullable restore
#line 9 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor"
                                                                                                                                                   Data

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n        ");
            }
            ));
            __builder.AddComponentReferenceCapture(20, (__value) => {
#nullable restore
#line 8 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor"
                                                                    tree = (Syncfusion.EJ2.Blazor.Navigations.EjsTreeView<TreeData>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.AddMarkupContent(23, @"<style>
    .control_wrapper {
        max-width: 320px;
        margin: auto;
        border: 1px solid #dddddd;
        border-radius: 3px;
    }

    .e-treeview .e-list-text {
        width: 100%;
    }

    .treeCount.e-badge {
        padding: 0.4em;
        vertical-align: text-bottom;
    }

    .material .treeCount.e-badge {
        vertical-align: middle;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor"
      

    List<TreeData> Data = new List<TreeData>();
    TreeData ModelType = new TreeData();
    int index = 100;
    EjsTreeView<TreeData> tree;
    void Change(InputEventArgs args)
    {
        string value = args.Value;
        List<TreeData> NewData = this.GetData();
        var FilterData = NewData.Where(data => data.Name.Contains(value));
        var ParentData = NewData.Where(data => FilterData.FirstOrDefault(matched => matched.Pid == data.Id) != null);
        Data = FilterData.Union(ParentData).ToList();
    }
    protected override void OnInitialized()
    {
        base.OnInitialized();
        Data = this.GetData();
    }
    class TreeData
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }
        public int Count { get; set; }
        public bool Selected { get; set; }
    }
    List<TreeData> GetData()
    {
        List<TreeData> LocalData = new List<TreeData>();
        LocalData.Add(new TreeData
        {
            Id = 1,
            Name = "Favorites",
            HasChild = true,
        });
        LocalData.Add(new TreeData
        {
            Id = 2,
            Pid = 1,
            Name = "Sales Reports",
            Count = 4
        });
        LocalData.Add(new TreeData
        {
            Id = 3,
            Pid = 1,
            Name = "Sent Items"
        });
        LocalData.Add(new TreeData
        {
            Id = 4,
            Pid = 1,
            Name = "Marketing Reports",
            Count = 6
        });
        LocalData.Add(new TreeData
        {
            Id = 5,
            HasChild = true,
            Name = "My Folder",
            Expanded = true
        });
        LocalData.Add(new TreeData
        {
            Id = 6,
            Pid = 5,
            Name = "Inbox",
            Selected = true,
            Count = 20
        });
        LocalData.Add(new TreeData
        {
            Id = 7,
            Pid = 5,
            Name = "Drafts",
            Count = 5
        });
        LocalData.Add(new TreeData
        {
            Id = 8,
            Pid = 5,
            Name = "Deleted Items"
        });
        LocalData.Add(new TreeData
        {
            Id = 9,
            Pid = 5,
            Name = "Sent Items"
        });
        LocalData.Add(new TreeData
        {
            Id = 10,
            Pid = 5,
            Name = "Sales Reports",
            Count = 4
        });
        LocalData.Add(new TreeData
        {
            Id = 11,
            Pid = 5,
            Name = "Marketing Reports",
            Count = 6
        });
        LocalData.Add(new TreeData
        {
            Id = 12,
            Pid = 5,
            Name = "Outbox"
        });
        return LocalData;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TreeViewTemplate.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTreeViewFieldsSettings_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Collections.Generic.IEnumerable<TValue> __arg6)
        {
        __builder.OpenComponent<global::Syncfusion.EJ2.Blazor.Navigations.TreeViewFieldsSettings<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Id", __arg0);
        __builder.AddAttribute(__seq1, "Text", __arg1);
        __builder.AddAttribute(__seq2, "ParentID", __arg2);
        __builder.AddAttribute(__seq3, "HasChildren", __arg3);
        __builder.AddAttribute(__seq4, "Selected", __arg4);
        __builder.AddAttribute(__seq5, "Expanded", __arg5);
        __builder.AddAttribute(__seq6, "DataSource", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591