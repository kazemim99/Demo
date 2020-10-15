using System;

namespace Demo.Framework.EF.Entity
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}