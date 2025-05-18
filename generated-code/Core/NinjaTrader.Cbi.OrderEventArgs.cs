[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class OrderEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public String ServerName { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the AverageFillPrice.
        /// </summary>
        [DataMember]
        public Double AverageFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the Comment.
        /// </summary>
        [DataMember]
        public String Comment { get; set; }
        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        [DataMember]
        public ErrorCode Error { get; set; }
        /// <summary>
        /// Gets or sets the Filled.
        /// </summary>
        [DataMember]
        public Int32 Filled { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public Double LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Order Order { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the OrderState.
        /// </summary>
        [DataMember]
        public OrderState OrderState { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public Double StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
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
