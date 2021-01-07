using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Listi.Server.Entities
{
    public class ToDo : Content
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public UserInfo User {get;set;}
    }
}
