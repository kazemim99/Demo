using System;

namespace Demo.Framework.EF.Entity
{
    public abstract class FullAuditedEntity<TPrimaryKey> : AuditedEntity<TPrimaryKey>, IFullAudited, IAudited, ICreationAudited, IHasCreationTime, IModificationAudited, IHasModificationTime, IDeletionAudited, IHasDeletionTime, ISoftDelete
    {
        protected FullAuditedEntity()
        {
        }

        public virtual bool IsDeleted { get; set; }

        public virtual long? DeleterUserId { get; set; }

        public virtual DateTime? DeletionTime { get; set; }
    }
}