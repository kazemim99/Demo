namespace Demo.Framework.EF
{
    public interface ILimitedResultRequest
    {
        int MaxResultCount { get; set; }
    }
}