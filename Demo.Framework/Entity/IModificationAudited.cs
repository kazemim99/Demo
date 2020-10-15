namespace Demo.Framework.EF.Entity
{
    public interface IModificationAudited : IHasModificationTime
    {
        long? LastModifierUserId { get; set; }
    }
}