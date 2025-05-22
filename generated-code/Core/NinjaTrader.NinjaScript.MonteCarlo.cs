[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class MonteCarlo
    {
        #region Properties
        /// <summary>
        /// Gets or sets the NumberOfSimulations.
        /// </summary>
        [DataMember]
        public int NumberOfSimulations { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfTrades.
        /// </summary>
        [DataMember]
        public int NumberOfTrades { get; set; }
        /// <summary>
        /// Gets or sets the RemoveLosingOutlierPercent.
        /// </summary>
        [DataMember]
        public int RemoveLosingOutlierPercent { get; set; }
        /// <summary>
        /// Gets or sets the RemoveWinningOutlierPercent.
        /// </summary>
        [DataMember]
        public int RemoveWinningOutlierPercent { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Run method.
        /// </summary>
        /// <param name="trades">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Trade></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Collections.Generic.List<NinjaTrader.Cbi.SystemPerformance></returns>
        public System.Collections.Generic.List<NinjaTrader.Cbi.SystemPerformance> Run(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Trade> trades, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Run method.
        /// </summary>
        /// <param name="trades">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Trade></param>
        /// <param name="includeCommmision">bool</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Collections.Generic.List<NinjaTrader.Cbi.SystemPerformance></returns>
        [Obsolete]
        public System.Collections.Generic.List<NinjaTrader.Cbi.SystemPerformance> Run(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Trade> trades, bool includeCommmision, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
