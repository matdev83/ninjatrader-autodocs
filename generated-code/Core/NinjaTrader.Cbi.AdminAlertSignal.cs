[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AdminAlertSignal
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdminAlertId.
        /// </summary>
        [DataMember]
        public long AdminAlertId { get; set; }
        /// <summary>
        /// Gets or sets the Completed.
        /// </summary>
        [DataMember]
        public System.DateTime Completed { get; set; }
        /// <summary>
        /// Gets or sets the EmailSent.
        /// </summary>
        [DataMember]
        public bool EmailSent { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the OwnedByAdminId.
        /// </summary>
        [DataMember]
        public long OwnedByAdminId { get; set; }
        /// <summary>
        /// Gets or sets the RelatedToAccountId.
        /// </summary>
        [DataMember]
        public long RelatedToAccountId { get; set; }
        /// <summary>
        /// Gets or sets the RelatedToUserId.
        /// </summary>
        [DataMember]
        public long RelatedToUserId { get; set; }
        /// <summary>
        /// Gets or sets the ShowAsPopup.
        /// </summary>
        [DataMember]
        public bool ShowAsPopup { get; set; }
        /// <summary>
        /// Gets or sets the SubjectId.
        /// </summary>
        [DataMember]
        public long SubjectId { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public string Text { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the Meta.
        /// </summary>
        [DataMember]
        public string Meta { get; set; }
        /// <summary>
        /// Gets or sets the DocumentTypes.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.DocumentTypes DocumentTypes { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
