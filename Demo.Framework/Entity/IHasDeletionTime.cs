using System;

namespace Demo.Framework.EF.Entity
{
    public interface IHasDeletionTime : ISoftDelete
    {
        DateTime? DeletionTime { get; set; }
    }
}