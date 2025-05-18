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
        public Double AutoLiqLevel { get; set; }
        /// <summary>
        /// Gets or sets the FullInitialMargin.
        /// </summary>
        [DataMember]
        public Double FullInitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the InitialMargin.
        /// </summary>
        [DataMember]
        public Double InitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the LiqOnlyLevel.
        /// </summary>
        [DataMember]
        public Double LiqOnlyLevel { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceMargin.
        /// </summary>
        [DataMember]
        public Double MaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the RiskTimePeriodId.
        /// </summary>
        [DataMember]
        public Int64 RiskTimePeriodId { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TotalUsedMargin.
        /// </summary>
        [DataMember]
        public Double TotalUsedMargin { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
