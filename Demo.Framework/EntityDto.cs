namespace Demo.Framework.EF
{
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public EntityDto()
        {
        }

        public EntityDto(TPrimaryKey id)
        {
        }

        public TPrimaryKey Id { get; set; }
    }
}