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
        public Boolean Archived { get; set; }
        /// <summary>
        /// Gets or sets the DocumentType.
        /// </summary>
        [DataMember]
        public String DocumentType { get; set; }
        /// <summary>
        /// Gets or sets the Filename.
        /// </summary>
        [DataMember]
        public String Filename { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the Process.
        /// </summary>
        [DataMember]
        public String Process { get; set; }
        /// <summary>
        /// Gets or sets the RequestSignalId.
        /// </summary>
        [DataMember]
        public Int64 RequestSignalId { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the UploadUserId.
        /// </summary>
        [DataMember]
        public Int64 UploadUserId { get; set; }
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
