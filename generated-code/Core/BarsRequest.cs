[Serializable]
[DataContract]
    public partial class BarsRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ContractMetadata.
        /// </summary>
        [DataMember]
        public ContractMetadata ContractMetadata { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetDateTime method.
        /// </summary>
        /// <param name="offsetMilliSeconds">Int64</param>
        /// <returns>DateTime</returns>
        public DateTime GetDateTime(Int64 offsetMilliSeconds);
        #endregion
    }
