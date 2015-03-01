using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Metadata
{
    public abstract class OneRelationMetadata : RelationMetadata
    {
        public PropertyInfo SyntheticProperty { get; set; }

        public FieldInfo SyntheticField { get; set; }

        public int? SyntheticPropertyMaxLength { get; set; }

        public bool IsSyntheticPropertyTypeRequired { get; set; }

        public MethodInfo SetMethod { get; set; }

        public MethodInfo UnsetMethod { get; set; }
    }
}
