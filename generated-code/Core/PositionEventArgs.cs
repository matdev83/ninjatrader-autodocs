[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class PositionEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AveragePrice.
        /// </summary>
        [DataMember]
        public Double AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition.
        /// </summary>
        [DataMember]
        public MarketPosition MarketPosition { get; set; }
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Operation Operation { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public Position Position { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
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
