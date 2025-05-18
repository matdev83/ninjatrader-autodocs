[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class InstrumentInfo
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public Currency Currency { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the Exchange.
        /// </summary>
        [DataMember]
        public Exchange Exchange { get; set; }
        /// <summary>
        /// Gets or sets the Expiry.
        /// </summary>
        [DataMember]
        public DateTime Expiry { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType.
        /// </summary>
        [DataMember]
        public InstrumentType InstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the UnderlyingInstrumentType.
        /// </summary>
        [DataMember]
        public InstrumentType UnderlyingInstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight.
        /// </summary>
        [DataMember]
        public OptionRight OptionRight { get; set; }
        /// <summary>
        /// Gets or sets the PointValue.
        /// </summary>
        [DataMember]
        public Double PointValue { get; set; }
        /// <summary>
        /// Gets or sets the StrikePrice.
        /// </summary>
        [DataMember]
        public Double StrikePrice { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursName.
        /// </summary>
        [DataMember]
        public String TradingHoursName { get; set; }
        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        [DataMember]
        public String Key { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
