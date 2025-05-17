[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradingPermission
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the AccountHolderContact.
        /// </summary>
        [DataMember]
        public String AccountHolderContact { get; set; }
        /// <summary>
        /// Gets or sets the AccountHolderEmail.
        /// </summary>
        [DataMember]
        public String AccountHolderEmail { get; set; }
        /// <summary>
        /// Gets or sets the CtaContact.
        /// </summary>
        [DataMember]
        public String CtaContact { get; set; }
        /// <summary>
        /// Gets or sets the CtaEmail.
        /// </summary>
        [DataMember]
        public String CtaEmail { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public String Status { get; set; }
        /// <summary>
        /// Gets or sets the Updated.
        /// </summary>
        [DataMember]
        public DateTime Updated { get; set; }
        /// <summary>
        /// Gets or sets the ApprovedById.
        /// </summary>
        [DataMember]
        public Int64 ApprovedById { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
