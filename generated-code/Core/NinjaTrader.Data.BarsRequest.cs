[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsRequest : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Bars.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.Bars Bars { get; set; }
        /// <summary>
        /// Gets or sets the BarsBack.
        /// </summary>
        [DataMember]
        public int BarsBack { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FromLocal.
        /// </summary>
        [DataMember]
        public System.DateTime FromLocal { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public bool IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsResetOnNewTradingDay.
        /// </summary>
        [DataMember]
        public bool IsResetOnNewTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the IsSplitAdjusted.
        /// </summary>
        [DataMember]
        public bool IsSplitAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the LookupPolicy.
        /// </summary>
        [DataMember]
        public LookupPolicies LookupPolicy { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy.
        /// </summary>
        [DataMember]
        public MergePolicy MergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours TradingHours { get; set; }
        /// <summary>
        /// Gets or sets the ToLocal.
        /// </summary>
        [DataMember]
        public System.DateTime ToLocal { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Request method.
        /// </summary>
        /// <param name="callback">System.Action<NinjaTrader.Data.BarsRequest, ErrorCode, string></param>
        public void Request(System.Action<NinjaTrader.Data.BarsRequest, ErrorCode, string> callback)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
