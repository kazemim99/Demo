namespace Demo.Framework.EF.Entity
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}