using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCManager_WPF_NetCore6.AppLayer.ViewModels
{
    public class IntentAction
    {
        public enum Types { View, Delete, Add, Edit }
        public Types Type { get; set; }
    }
}
