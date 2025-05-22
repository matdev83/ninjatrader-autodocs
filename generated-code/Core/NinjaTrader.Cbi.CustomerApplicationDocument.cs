[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CustomerApplicationDocument
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Archived.
        /// </summary>
        [DataMember]
        public bool Archived { get; set; }
        /// <summary>
        /// Gets or sets the DocumentType.
        /// </summary>
        [DataMember]
        public string DocumentType { get; set; }
        /// <summary>
        /// Gets or sets the Filename.
        /// </summary>
        [DataMember]
        public string Filename { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the Process.
        /// </summary>
        [DataMember]
        public string Process { get; set; }
        /// <summary>
        /// Gets or sets the RequestSignalId.
        /// </summary>
        [DataMember]
        public long RequestSignalId { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the UploadUserId.
        /// </summary>
        [DataMember]
        public long UploadUserId { get; set; }
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
