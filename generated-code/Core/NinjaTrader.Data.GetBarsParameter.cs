[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class GetBarsParameter
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsBarsBack.
        /// </summary>
        [DataMember]
        public bool IsBarsBack { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FromDateLocal.
        /// </summary>
        [DataMember]
        public System.DateTime FromDateLocal { get; set; }
        /// <summary>
        /// Gets or sets the BarsBack.
        /// </summary>
        [DataMember]
        public int BarsBack { get; set; }
        /// <summary>
        /// Gets or sets the ToDateLocal.
        /// </summary>
        [DataMember]
        public System.DateTime ToDateLocal { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours TradingHours { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public bool IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsSplitAdjusted.
        /// </summary>
        [DataMember]
        public bool IsSplitAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsSubscribed.
        /// </summary>
        [DataMember]
        public bool IsSubscribed { get; set; }
        /// <summary>
        /// Gets or sets the IsResetOnNewTradingDay.
        /// </summary>
        [DataMember]
        public bool IsResetOnNewTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public bool IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the LookupPolicies.
        /// </summary>
        [DataMember]
        public LookupPolicies LookupPolicies { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy.
        /// </summary>
        [DataMember]
        public MergePolicy MergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the Progress.
        /// </summary>
        [DataMember]
        public NinjaTrader.Core.IProgress Progress { get; set; }
        /// <summary>
        /// Gets or sets the CalculateRollovers.
        /// </summary>
        [DataMember]
        public bool CalculateRollovers { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public object State { get; set; }
        /// <summary>
        /// Gets or sets the Callback.
        /// </summary>
        [DataMember]
        public System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> Callback { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
