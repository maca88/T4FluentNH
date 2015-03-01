using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Metadata
{
    public abstract class RelationMetadata
    {
        public abstract RelationType Type { get; }

        public Type RelatedModelType { get; set; }

        public PropertyInfo RelatedModelProperty { get; set; }

        public PropertyInfo RelatedModelIdProperty { get; set; }

        public AssociationType AssociationType { get; set; }

        public FieldInfo Field { get; set; }

        public string ParameterName { get; set; }

        public PropertyInfo Property { get; set; }

    }
}
