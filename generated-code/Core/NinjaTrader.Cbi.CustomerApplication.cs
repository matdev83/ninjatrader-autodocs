[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CustomerApplication
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountType.
        /// </summary>
        [DataMember]
        public string AccountType { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationStatus.
        /// </summary>
        [DataMember]
        public string ApplicationStatus { get; set; }
        /// <summary>
        /// Gets or sets the Archived.
        /// </summary>
        [DataMember]
        public bool Archived { get; set; }
        /// <summary>
        /// Gets or sets the ClearingHouseId.
        /// </summary>
        [DataMember]
        public long ClearingHouseId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the LegalStatus.
        /// </summary>
        [DataMember]
        public string LegalStatus { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public System.DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
