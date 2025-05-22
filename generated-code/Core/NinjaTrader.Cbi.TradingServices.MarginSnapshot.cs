[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class MarginSnapshot
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoLiqLevel.
        /// </summary>
        [DataMember]
        public double AutoLiqLevel { get; set; }
        /// <summary>
        /// Gets or sets the FullInitialMargin.
        /// </summary>
        [DataMember]
        public double FullInitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the InitialMargin.
        /// </summary>
        [DataMember]
        public double InitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the LiqOnlyLevel.
        /// </summary>
        [DataMember]
        public double LiqOnlyLevel { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceMargin.
        /// </summary>
        [DataMember]
        public double MaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the RiskTimePeriodId.
        /// </summary>
        [DataMember]
        public long RiskTimePeriodId { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TotalUsedMargin.
        /// </summary>
        [DataMember]
        public double TotalUsedMargin { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
