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
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Bought.
        /// </summary>
        [DataMember]
        public int Bought { get; set; }
        /// <summary>
        /// Gets or sets the BoughtValue.
        /// </summary>
        [DataMember]
        public double BoughtValue { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public long ContractId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the NetPos.
        /// </summary>
        [DataMember]
        public int NetPos { get; set; }
        /// <summary>
        /// Gets or sets the NetPrice.
        /// </summary>
        [DataMember]
        public double NetPrice { get; set; }
        /// <summary>
        /// Gets or sets the PrevPos.
        /// </summary>
        [DataMember]
        public int PrevPos { get; set; }
        /// <summary>
        /// Gets or sets the PrevPrice.
        /// </summary>
        [DataMember]
        public double PrevPrice { get; set; }
        /// <summary>
        /// Gets or sets the Sold.
        /// </summary>
        [DataMember]
        public int Sold { get; set; }
        /// <summary>
        /// Gets or sets the SoldValue.
        /// </summary>
        [DataMember]
        public double SoldValue { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.TradeDate TradeDate { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
