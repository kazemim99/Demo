using System;

namespace Demo.Framework.EF.Entity
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; set; }
    }
}