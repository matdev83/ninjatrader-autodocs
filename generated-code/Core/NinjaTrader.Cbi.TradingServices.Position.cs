[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Position
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Bought.
        /// </summary>
        [DataMember]
        public Int32 Bought { get; set; }
        /// <summary>
        /// Gets or sets the BoughtValue.
        /// </summary>
        [DataMember]
        public Double BoughtValue { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public Int64 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the NetPos.
        /// </summary>
        [DataMember]
        public Int32 NetPos { get; set; }
        /// <summary>
        /// Gets or sets the NetPrice.
        /// </summary>
        [DataMember]
        public Double NetPrice { get; set; }
        /// <summary>
        /// Gets or sets the PrevPos.
        /// </summary>
        [DataMember]
        public Int32 PrevPos { get; set; }
        /// <summary>
        /// Gets or sets the PrevPrice.
        /// </summary>
        [DataMember]
        public Double PrevPrice { get; set; }
        /// <summary>
        /// Gets or sets the Sold.
        /// </summary>
        [DataMember]
        public Int32 Sold { get; set; }
        /// <summary>
        /// Gets or sets the SoldValue.
        /// </summary>
        [DataMember]
        public Double SoldValue { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public TradeDate TradeDate { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
