using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCManager_WPF_NetCore6.Domain.Entities
{
    public class AutoTaskEntity
    {
        public enum Types { News, SystemIssue }
        public Types Type { get; set; }
        public States State { get; set; }
        public string Content { get; set; }
    }
}
