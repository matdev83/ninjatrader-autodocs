[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ExecutionEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Exchange.
        /// </summary>
        [DataMember]
        public Exchange Exchange { get; set; }
        /// <summary>
        /// Gets or sets the Execution.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Execution Execution { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionId.
        /// </summary>
        [DataMember]
        public string ExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the IsSod.
        /// </summary>
        [DataMember]
        public bool IsSod { get; set; }
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
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public string OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public System.DateTime StatementDate { get; set; }
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
