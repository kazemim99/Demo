namespace Demo.Framework.EF.Entity
{
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        protected Entity()
        {
        }

        public virtual TPrimaryKey Id { get; set; }
    }
}