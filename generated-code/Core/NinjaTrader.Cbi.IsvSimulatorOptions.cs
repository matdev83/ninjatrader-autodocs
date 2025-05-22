[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IsvSimulatorOptions : NinjaTrader.Cbi.SimulatorOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public bool IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the AccountsAndUsers.
        /// </summary>
        [DataMember]
        public int AccountsAndUsers { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveOrdersPerAccount.
        /// </summary>
        [DataMember]
        public int NumActiveOrdersPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the NumExecutionsPerAccount.
        /// </summary>
        [DataMember]
        public int NumExecutionsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the NumSodExecutionsPerAccount.
        /// </summary>
        [DataMember]
        public int NumSodExecutionsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the OrderRate.
        /// </summary>
        [DataMember]
        public double OrderRate { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
