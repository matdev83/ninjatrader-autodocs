[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ExecutionEventArgs : EventArgs
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
        public Execution Execution { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionId.
        /// </summary>
        [DataMember]
        public String ExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the IsSod.
        /// </summary>
        [DataMember]
        public Boolean IsSod { get; set; }
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
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Double Price { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public DateTime StatementDate { get; set; }
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
