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
        public long ContractMaturityId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the IsPut.
        /// </summary>
        [DataMember]
        public bool IsPut { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the ProviderTickSize.
        /// </summary>
        [DataMember]
        public double ProviderTickSize { get; set; }
        /// <summary>
        /// Gets or sets the StrikePrice.
        /// </summary>
        [DataMember]
        public double StrikePrice { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
