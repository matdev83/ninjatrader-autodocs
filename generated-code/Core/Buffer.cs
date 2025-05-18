[Serializable]
[DataContract]
    public partial class Buffer
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Bytes.
        /// </summary>
        [DataMember]
        public Byte[] Bytes { get; set; }
        /// <summary>
        /// Gets or sets the Capacity.
        /// </summary>
        [DataMember]
        public Int32 Capacity { get; set; }
        /// <summary>
        /// Gets or sets the Offset.
        /// </summary>
        [DataMember]
        public Int32 Offset { get; set; }
        /// <summary>
        /// Gets or sets the PayloadPosition.
        /// </summary>
        [DataMember]
        public Int32 PayloadPosition { get; set; }
        #endregion
        #region Methods
        #endregion
    }
