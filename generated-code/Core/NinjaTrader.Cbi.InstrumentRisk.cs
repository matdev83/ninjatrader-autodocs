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
        public double BuyIntradayMargin { get; set; }
        /// <summary>
        /// Gets or sets the InitialMargin.
        /// </summary>
        [DataMember]
        public double InitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the IsEnabledForTrading.
        /// </summary>
        [DataMember]
        public bool IsEnabledForTrading { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceMargin.
        /// </summary>
        [DataMember]
        public double MaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the MaxOrderSize.
        /// </summary>
        [DataMember]
        public int MaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the MaxPositionSize.
        /// </summary>
        [DataMember]
        public int MaxPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the SellIntradayMargin.
        /// </summary>
        [DataMember]
        public double SellIntradayMargin { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
