[Serializable]
[DataContract]
    public partial class StopwatchTime
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the TotalTicks.
        /// </summary>
        [DataMember]
        public Int64 TotalTicks { get; set; }
        #endregion
        #region Methods
        #endregion
    }
