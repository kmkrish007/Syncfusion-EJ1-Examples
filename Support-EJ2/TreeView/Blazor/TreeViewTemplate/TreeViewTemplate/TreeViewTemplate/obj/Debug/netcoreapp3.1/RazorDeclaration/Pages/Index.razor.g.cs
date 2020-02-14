#pragma checksum "D:\EJ2\Support\Blazor\Treeview\TreeViewTemplate\TreeViewTemplate\TreeViewTemplate\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fed931ecd5b1e131c613dc0a2de445e7832180e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591