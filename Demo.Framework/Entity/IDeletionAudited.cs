namespace Demo.Framework.EF.Entity
{
    public interface IDeletionAudited : IHasDeletionTime, ISoftDelete
    {
        long? DeleterUserId { get; set; }
    }
}