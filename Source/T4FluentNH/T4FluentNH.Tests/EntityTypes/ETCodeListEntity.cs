using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace T4FluentNH.Tests.EntityTypes
{
    public partial class ETCodeListEntity : CodeList
    {
        public virtual string Name { get; set; }

        public virtual ETSimpleEntity SimpleEntity
        {
            get { return _simpleEntity; }
            set { SetField(ref _simpleEntity, value, ref _simpleEntityId); }
        }
        
    }

    public class ETCodeListEntityMapping : IAutoMappingOverride<ETCodeListEntity>
    {
        public void Override(AutoMapping<ETCodeListEntity> mapping)
        {
            mapping.Id(o => o.Code).GeneratedBy.Assigned();
        }
    }
}
