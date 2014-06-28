using T4FluentNH.Attributes;

namespace T4FluentNH.Tests.OneToOne
{
    //The right way to do one to one on same class
    public partial class O2OPerson : Entity
    {
        public virtual string Name { get; set; }

        [AsOneToOne] //cannot be unique
        public virtual O2OPerson MarriedWith { get; protected internal set; }

        [AsOneToOne] //cannot be unique
        public virtual O2OPerson Twin { get; protected internal set; }

    }
}
