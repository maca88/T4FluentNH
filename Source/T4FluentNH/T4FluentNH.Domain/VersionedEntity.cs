using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Domain
{
    public class VersionedEntity : Entity
    {
        public virtual User CreatedBy { get; set; }  
    }
}
