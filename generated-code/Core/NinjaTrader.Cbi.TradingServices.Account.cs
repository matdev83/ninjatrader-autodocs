[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Account
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        /// <summary>
        /// Gets or sets the AccountType.
        /// </summary>
        [DataMember]
        public string AccountType { get; set; }
        /// <summary>
        /// Gets or sets the Active.
        /// </summary>
        [DataMember]
        public bool Active { get; set; }
        /// <summary>
        /// Gets or sets the ClearingHouseId.
        /// </summary>
        [DataMember]
        public long ClearingHouseId { get; set; }
        /// <summary>
        /// Gets or sets the RiskCategoryId.
        /// </summary>
        [DataMember]
        public long RiskCategoryId { get; set; }
        /// <summary>
        /// Gets or sets the AutoLiqProfileId.
        /// </summary>
        [DataMember]
        public long AutoLiqProfileId { get; set; }
        /// <summary>
        /// Gets or sets the MarginAccountType.
        /// </summary>
        [DataMember]
        public string MarginAccountType { get; set; }
        /// <summary>
        /// Gets or sets the LegalStatus.
        /// </summary>
        [DataMember]
        public string LegalStatus { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the ReadOnly.
        /// </summary>
        [DataMember]
        public bool ReadOnly { get; set; }
        /// <summary>
        /// Gets or sets the Nickname.
        /// </summary>
        [DataMember]
        public string Nickname { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
