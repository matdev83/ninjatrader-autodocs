[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class OrderEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public System.DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the AverageFillPrice.
        /// </summary>
        [DataMember]
        public double AverageFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the Comment.
        /// </summary>
        [DataMember]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        [DataMember]
        public ErrorCode Error { get; set; }
        /// <summary>
        /// Gets or sets the Filled.
        /// </summary>
        [DataMember]
        public int Filled { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public double LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Order Order { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public string OrderId { get; set; }
        /// <summary>
        /// Gets or sets the OrderState.
        /// </summary>
        [DataMember]
        public OrderState OrderState { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public double StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
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
