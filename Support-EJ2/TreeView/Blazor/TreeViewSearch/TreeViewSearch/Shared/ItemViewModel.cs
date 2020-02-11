
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeViewSearch.Shared
{
   
    public class ItemViewModel
    {
        public ItemViewModel()
        {

        }
        public ItemViewModel(Guid EmployeeID, string FirstName, bool expanded, bool hasChild, bool selected, bool hasallowances, bool HasWorkSchedule, Guid? ParentId)
        {
            this.ItemGuid = EmployeeID;
            this.ItemName = FirstName;
            this.Expanded = expanded;
            this.HasChildren = hasChild;
            this.Selected = selected;
            this.HasAllowances = hasallowances;
            this.HasWorkSchedule = false;
            this.ParentItemGuid = ParentId;
        }
        public Guid ItemGuid { get; set; }
        public Guid? ParentItemGuid { get; set; }
        public string ItemName { get; set; }
        public bool HasChildren { get; set; }
        public bool Expanded { get; set; }
        public bool Selected { get; set; }
        public bool HasAllowances { get; set; }
        public bool HasWorkSchedule { get; set; }

    }
}
