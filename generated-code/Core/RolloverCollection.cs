[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class RolloverCollection : Collection<Rollover>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="rollover">Rollover</param>
        public Void Add(Rollover rollover);
        /// <summary>
        /// GetOffsetSum method.
        /// </summary>
        /// <param name="expiry">DateTime</param>
        /// <param name="atDate">DateTime</param>
        /// <returns>Double</returns>
        public Double GetOffsetSum(DateTime expiry, DateTime atDate);
        #endregion
    }
}
