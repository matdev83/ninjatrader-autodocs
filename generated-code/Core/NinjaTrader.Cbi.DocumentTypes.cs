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
        public System.Collections.Generic.List<string> DocTypes { get; set; }
        /// <summary>
        /// Gets or sets the Header.
        /// </summary>
        [DataMember]
        public string Header { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the RequesterId.
        /// </summary>
        [DataMember]
        public long RequesterId { get; set; }
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
