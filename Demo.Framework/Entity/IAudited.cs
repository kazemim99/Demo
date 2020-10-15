namespace Demo.Framework.EF.Entity
{
    public interface IAudited : ICreationAudited, IHasCreationTime, IModificationAudited, IHasModificationTime
    {
    }
}