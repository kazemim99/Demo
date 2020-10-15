using System;

namespace Demo.Framework.EF.Entity
{
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited, IHasCreationTime
    {
        protected CreationAuditedEntity()
        {
        }

        public virtual DateTime CreationTime { get; set; }

        public virtual long? CreatorUserId { get; set; }
    }
}