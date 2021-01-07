using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Listi.Server.Entities
{
    /// <summary>
    /// main entity of the system 
    /// </summary>
    public class Entity
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

