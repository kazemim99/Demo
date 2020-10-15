using Demo.Framework.EF.Entity;

namespace Demo.Core
{
    public class City : FullAuditedEntity<int>
    {
        #region Constroctor

        public City()
        {
        }

        #endregion Constroctor

        #region + Property

        public string Title { get; set; }

        #endregion + Property
    }
}