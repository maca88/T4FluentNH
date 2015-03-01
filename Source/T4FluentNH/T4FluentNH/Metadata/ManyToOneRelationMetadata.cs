using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Metadata
{
    public class ManyToOneRelationMetadata : OneRelationMetadata
    {
        public override RelationType Type { get { return RelationType.ManyToOne; } }

        public MethodInfo RelatedModelRemoveMethod { get; set; }
    }
}
