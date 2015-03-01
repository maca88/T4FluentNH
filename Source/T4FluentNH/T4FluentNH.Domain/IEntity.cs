using System;

namespace T4FluentNH.Domain
{
    public interface IEntity
    {
    }

    public abstract partial class Entity : IEntity
    {
        public virtual int Id { get; set; }

        public virtual bool IsTransient()
        {
            return Id.Equals(default(int));
        }

        public virtual Type GetTypeUnproxied()
        {
            return GetType();
        }

    }
}
