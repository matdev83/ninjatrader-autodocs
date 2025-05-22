[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class NotificationEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the CompletedTimestamp.
        /// </summary>
        [DataMember]
        public System.DateTime CompletedTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the EmailSent.
        /// </summary>
        [DataMember]
        public bool EmailSent { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
