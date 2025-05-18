[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class DocumentTypes
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DocTypes.
        /// </summary>
        [DataMember]
        public List<String> DocTypes { get; set; }
        /// <summary>
        /// Gets or sets the Header.
        /// </summary>
        [DataMember]
        public String Header { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the RequesterId.
        /// </summary>
        [DataMember]
        public Int64 RequesterId { get; set; }
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
