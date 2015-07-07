using FluentNHibernate.Automapping;
using T4FluentNH.Attributes;

namespace T4FluentNH.Tests.OneToOne
{
    //The right way to do one to one on same class
    public partial class O2OPerson : Domain.Entity
    {
        public virtual string Name { get; set; }

        [AsOneToOne] //cannot be unique
        public virtual O2OPerson MarriedWith
        {
            get { return _marriedWith; }
            set { ResetField(ref _marriedWith, value, ref _isMarriedWithIdSet); }
        }

        [AsOneToOne] //cannot be unique
        public virtual O2OPerson Twin
        {
            get { return _twin; }
            set { ResetField(ref _twin, value, ref _isTwinIdSet); }
        }

        //Custom Set method
        public virtual void SetMarriedWith(O2OPerson marriedWith)
        {
            this.SetOneToOne(o => o.MarriedWith, marriedWith, o => o.MarriedWith);
        }

        //Custom unset method
        public virtual void UnsetTwin()
        {
            this.UnsetOneToOne(o => o.Twin, o => o.Twin);
        }	
    }
}
