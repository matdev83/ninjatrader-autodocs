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
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the AccountHolderContact.
        /// </summary>
        [DataMember]
        public string AccountHolderContact { get; set; }
        /// <summary>
        /// Gets or sets the AccountHolderEmail.
        /// </summary>
        [DataMember]
        public string AccountHolderEmail { get; set; }
        /// <summary>
        /// Gets or sets the CtaContact.
        /// </summary>
        [DataMember]
        public string CtaContact { get; set; }
        /// <summary>
        /// Gets or sets the CtaEmail.
        /// </summary>
        [DataMember]
        public string CtaEmail { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets the Updated.
        /// </summary>
        [DataMember]
        public System.DateTime Updated { get; set; }
        /// <summary>
        /// Gets or sets the ApprovedById.
        /// </summary>
        [DataMember]
        public long ApprovedById { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
