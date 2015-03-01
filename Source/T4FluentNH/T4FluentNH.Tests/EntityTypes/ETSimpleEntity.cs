using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4FluentNH.Tests.EntityTypes
{
    public partial class ETSimpleEntity : Domain.Entity
    {
        public virtual string Name { get; set; }

        public virtual ETCodeListEntity CodeListEntity
        {
            get { return _codeListEntity; }
            set { SetField(ref _codeListEntity, value, ref _codeListEntityCode); }
        }

        public virtual ETInheritedCodeListEntity InheritCodeListEntity
        {
            get { return _inheritCodeListEntity; }
            set { SetField(ref _inheritCodeListEntity, value, ref _inheritCodeListEntityCode); }
        }

        public virtual ETLengthCodeList LengthCodeListEntity
        {
            get { return _lengthCodeListEntity; }
            set { SetField(ref _lengthCodeListEntity, value, ref _lengthCodeListEntityCode); }
        }
    }
}
