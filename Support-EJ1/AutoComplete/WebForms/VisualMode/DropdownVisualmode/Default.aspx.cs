using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropdownVisualmode
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string val = ComponentList.Value;
            }
            List<ComponentsList> component = new List<ComponentsList>();
            component.Add(new ComponentsList { ComponentName = "Autocomplete" });
            component.Add(new ComponentsList { ComponentName = "Accordion" });
            component.Add(new ComponentsList { ComponentName = "BulletGraph" });
            component.Add(new ComponentsList { ComponentName = "Chart" });
            component.Add(new ComponentsList { ComponentName = "DatePicker" });
            component.Add(new ComponentsList { ComponentName = "Dialog" });
            component.Add(new ComponentsList { ComponentName = "Diagram" });
            component.Add(new ComponentsList { ComponentName = "DropDown" });
            component.Add(new ComponentsList { ComponentName = "Gauge" });
            component.Add(new ComponentsList { ComponentName = "Schedule" });
            component.Add(new ComponentsList { ComponentName = "Scrollbar" });
            component.Add(new ComponentsList { ComponentName = "Slider" });
            component.Add(new ComponentsList { ComponentName = "RangeNavigator" });
            component.Add(new ComponentsList { ComponentName = "Rating" });
            component.Add(new ComponentsList { ComponentName = "RichTextEditor" });
            component.Add(new ComponentsList { ComponentName = "Tab" });
            component.Add(new ComponentsList { ComponentName = "TagCloud" });
            component.Add(new ComponentsList { ComponentName = "Toolbar" });
            component.Add(new ComponentsList { ComponentName = "TreeView" });
            this.ComponentList.DataSource = component;
        }
    }

        public class ComponentsList
    {
        public string ComponentName { get; set; }
    }
}