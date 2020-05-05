using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMenu.Model
{
    public class MenuModel
    {
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string ParentId { get; set; }

        public string IconClass { get; set; }

        public int SerialNumber { get; set; }
               
       
    }
}
