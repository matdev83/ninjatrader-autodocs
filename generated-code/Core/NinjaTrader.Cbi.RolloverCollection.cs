[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class RolloverCollection : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Rollover>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="rollover">NinjaTrader.Cbi.Rollover</param>
        public void Add(NinjaTrader.Cbi.Rollover rollover)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetOffsetSum method.
        /// </summary>
        /// <param name="expiry">System.DateTime</param>
        /// <param name="atDate">System.DateTime</param>
        /// <returns>double</returns>
        public double GetOffsetSum(System.DateTime expiry, System.DateTime atDate)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
