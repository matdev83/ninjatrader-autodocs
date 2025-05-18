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
        public String AccountType { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationStatus.
        /// </summary>
        [DataMember]
        public String ApplicationStatus { get; set; }
        /// <summary>
        /// Gets or sets the Archived.
        /// </summary>
        [DataMember]
        public Boolean Archived { get; set; }
        /// <summary>
        /// Gets or sets the ClearingHouseId.
        /// </summary>
        [DataMember]
        public Int64 ClearingHouseId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the LegalStatus.
        /// </summary>
        [DataMember]
        public String LegalStatus { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
