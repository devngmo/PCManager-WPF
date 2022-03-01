using PCManager_WPF_NetCore6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCManager_WPF_NetCore6.AppLayer.ViewModels
{
    public class NoteViewModel
    {
        public NoteEntity note { get; set; }
        public IntentAction action { get; set; }
    }
}
