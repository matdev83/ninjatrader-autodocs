[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class InstrumentRisk
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BuyIntradayMargin.
        /// </summary>
        [DataMember]
        public Double BuyIntradayMargin { get; set; }
        /// <summary>
        /// Gets or sets the InitialMargin.
        /// </summary>
        [DataMember]
        public Double InitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the IsEnabledForTrading.
        /// </summary>
        [DataMember]
        public Boolean IsEnabledForTrading { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceMargin.
        /// </summary>
        [DataMember]
        public Double MaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the MaxOrderSize.
        /// </summary>
        [DataMember]
        public Int32 MaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the MaxPositionSize.
        /// </summary>
        [DataMember]
        public Int32 MaxPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the SellIntradayMargin.
        /// </summary>
        [DataMember]
        public Double SellIntradayMargin { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
