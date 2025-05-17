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
        public Int64 AdminAlertId { get; set; }
        /// <summary>
        /// Gets or sets the Completed.
        /// </summary>
        [DataMember]
        public DateTime Completed { get; set; }
        /// <summary>
        /// Gets or sets the EmailSent.
        /// </summary>
        [DataMember]
        public Boolean EmailSent { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the OwnedByAdminId.
        /// </summary>
        [DataMember]
        public Int64 OwnedByAdminId { get; set; }
        /// <summary>
        /// Gets or sets the RelatedToAccountId.
        /// </summary>
        [DataMember]
        public Int64 RelatedToAccountId { get; set; }
        /// <summary>
        /// Gets or sets the RelatedToUserId.
        /// </summary>
        [DataMember]
        public Int64 RelatedToUserId { get; set; }
        /// <summary>
        /// Gets or sets the ShowAsPopup.
        /// </summary>
        [DataMember]
        public Boolean ShowAsPopup { get; set; }
        /// <summary>
        /// Gets or sets the SubjectId.
        /// </summary>
        [DataMember]
        public Int64 SubjectId { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the Meta.
        /// </summary>
        [DataMember]
        public String Meta { get; set; }
        /// <summary>
        /// Gets or sets the DocumentTypes.
        /// </summary>
        [DataMember]
        public DocumentTypes DocumentTypes { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
