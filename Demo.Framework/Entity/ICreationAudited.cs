namespace Demo.Framework.EF.Entity
{
    public interface ICreationAudited : IHasCreationTime
    {
        long? CreatorUserId { get; set; }
    }
}