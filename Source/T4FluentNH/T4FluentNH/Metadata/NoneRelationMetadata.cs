using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Metadata
{
    public class NoneRelationMetadata : RelationMetadata
    {
        public override RelationType Type { get { return RelationType.None; } }
    }
}
