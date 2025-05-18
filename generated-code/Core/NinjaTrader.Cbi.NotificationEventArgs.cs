[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class NotificationEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the CompletedTimestamp.
        /// </summary>
        [DataMember]
        public DateTime CompletedTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the EmailSent.
        /// </summary>
        [DataMember]
        public Boolean EmailSent { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
