[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Contract
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ContractMaturityId.
        /// </summary>
        [DataMember]
        public Int64 ContractMaturityId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the IsPut.
        /// </summary>
        [DataMember]
        public Boolean IsPut { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the ProviderTickSize.
        /// </summary>
        [DataMember]
        public Double ProviderTickSize { get; set; }
        /// <summary>
        /// Gets or sets the StrikePrice.
        /// </summary>
        [DataMember]
        public Double StrikePrice { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
