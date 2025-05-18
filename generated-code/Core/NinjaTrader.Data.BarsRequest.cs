[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsRequest : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Bars.
        /// </summary>
        [DataMember]
        public Bars Bars { get; set; }
        /// <summary>
        /// Gets or sets the BarsBack.
        /// </summary>
        [DataMember]
        public Int32 BarsBack { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FromLocal.
        /// </summary>
        [DataMember]
        public DateTime FromLocal { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsResetOnNewTradingDay.
        /// </summary>
        [DataMember]
        public Boolean IsResetOnNewTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the IsSplitAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsSplitAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
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
        public TradingHours TradingHours { get; set; }
        /// <summary>
        /// Gets or sets the ToLocal.
        /// </summary>
        [DataMember]
        public DateTime ToLocal { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// Request method.
        /// </summary>
        /// <param name="callback">Action`3</param>
        public Void Request(Action<BarsRequest, ErrorCode, String> callback);
        #endregion
    }
}
