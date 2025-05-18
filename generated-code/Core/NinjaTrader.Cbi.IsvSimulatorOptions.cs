[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IsvSimulatorOptions : SimulatorOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public String BrandName { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public Boolean IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the AccountsAndUsers.
        /// </summary>
        [DataMember]
        public Int32 AccountsAndUsers { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveOrdersPerAccount.
        /// </summary>
        [DataMember]
        public Int32 NumActiveOrdersPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the NumExecutionsPerAccount.
        /// </summary>
        [DataMember]
        public Int32 NumExecutionsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the NumSodExecutionsPerAccount.
        /// </summary>
        [DataMember]
        public Int32 NumSodExecutionsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the OrderRate.
        /// </summary>
        [DataMember]
        public Double OrderRate { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
