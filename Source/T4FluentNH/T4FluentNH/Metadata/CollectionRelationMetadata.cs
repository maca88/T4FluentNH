using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Metadata
{
    public abstract class CollectionRelationMetadata : RelationMetadata
    {
        public CollectionMapType CollectionMapType { get; set; }

        public MethodInfo AddMethod { get; set; }

        public MethodInfo RemoveMethod { get; set; }
    }
}
