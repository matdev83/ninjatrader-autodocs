[Serializable]
[DataContract]
    public partial class StockTwitsAuthJsonResult
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Response.
        /// </summary>
        [DataMember]
        public String[] Response { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public String[] User { get; set; }
        #endregion
        #region Methods
        #endregion
    }
