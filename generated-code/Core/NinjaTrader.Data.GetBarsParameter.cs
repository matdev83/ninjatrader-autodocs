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
        public Boolean IsBarsBack { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FromDateLocal.
        /// </summary>
        [DataMember]
        public DateTime FromDateLocal { get; set; }
        /// <summary>
        /// Gets or sets the BarsBack.
        /// </summary>
        [DataMember]
        public Int32 BarsBack { get; set; }
        /// <summary>
        /// Gets or sets the ToDateLocal.
        /// </summary>
        [DataMember]
        public DateTime ToDateLocal { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public TradingHours TradingHours { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsSplitAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsSplitAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsSubscribed.
        /// </summary>
        [DataMember]
        public Boolean IsSubscribed { get; set; }
        /// <summary>
        /// Gets or sets the IsResetOnNewTradingDay.
        /// </summary>
        [DataMember]
        public Boolean IsResetOnNewTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public Boolean IsTickReplay { get; set; }
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
        public IProgress Progress { get; set; }
        /// <summary>
        /// Gets or sets the CalculateRollovers.
        /// </summary>
        [DataMember]
        public Boolean CalculateRollovers { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public Object State { get; set; }
        /// <summary>
        /// Gets or sets the Callback.
        /// </summary>
        [DataMember]
        public Action<Bars, ErrorCode, String, Object> Callback { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
