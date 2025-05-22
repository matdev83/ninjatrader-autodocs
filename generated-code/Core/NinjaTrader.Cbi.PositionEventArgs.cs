[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class PositionEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AveragePrice.
        /// </summary>
        [DataMember]
        public double AveragePrice { get; set; }
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
        public NinjaTrader.Cbi.Position Position { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
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
