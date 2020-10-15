﻿namespace Demo.Framework.EF
{
    public interface IPagedResultRequest : ILimitedResultRequest
    {
        //
        // Summary:
        //     Skip count (beginning of the page).
        int SkipCount { get; set; }
    }
}