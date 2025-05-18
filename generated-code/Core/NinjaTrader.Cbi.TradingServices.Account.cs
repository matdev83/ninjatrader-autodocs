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
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        /// <summary>
        /// Gets or sets the AccountType.
        /// </summary>
        [DataMember]
        public String AccountType { get; set; }
        /// <summary>
        /// Gets or sets the Active.
        /// </summary>
        [DataMember]
        public Boolean Active { get; set; }
        /// <summary>
        /// Gets or sets the ClearingHouseId.
        /// </summary>
        [DataMember]
        public Int64 ClearingHouseId { get; set; }
        /// <summary>
        /// Gets or sets the RiskCategoryId.
        /// </summary>
        [DataMember]
        public Int64 RiskCategoryId { get; set; }
        /// <summary>
        /// Gets or sets the AutoLiqProfileId.
        /// </summary>
        [DataMember]
        public Int64 AutoLiqProfileId { get; set; }
        /// <summary>
        /// Gets or sets the MarginAccountType.
        /// </summary>
        [DataMember]
        public String MarginAccountType { get; set; }
        /// <summary>
        /// Gets or sets the LegalStatus.
        /// </summary>
        [DataMember]
        public String LegalStatus { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the ReadOnly.
        /// </summary>
        [DataMember]
        public Boolean ReadOnly { get; set; }
        /// <summary>
        /// Gets or sets the Nickname.
        /// </summary>
        [DataMember]
        public String Nickname { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
