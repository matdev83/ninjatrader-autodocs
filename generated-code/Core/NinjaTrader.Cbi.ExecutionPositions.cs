[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ExecutionPositions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DoRaiseAddTrade.
        /// </summary>
        [DataMember]
        public bool DoRaiseAddTrade { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.Instrument, NinjaTrader.Cbi.Position> Positions { get; set; }
        /// <summary>
        /// Gets or sets the UseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public bool UseFifo4AveragePrice { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="execution">NinjaTrader.Cbi.Execution</param>
        public void Add(NinjaTrader.Cbi.Execution execution)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
