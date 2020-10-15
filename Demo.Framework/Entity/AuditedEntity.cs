using System;

namespace Demo.Framework.EF.Entity
{
    public abstract class AuditedEntity<TPrimaryKey> : CreationAuditedEntity<TPrimaryKey>, IAudited, ICreationAudited, IHasCreationTime, IModificationAudited, IHasModificationTime
    {
        protected AuditedEntity()
        {
        }

        public virtual DateTime? LastModificationTime { get; set; }

        public virtual long? LastModifierUserId { get; set; }
    }
}