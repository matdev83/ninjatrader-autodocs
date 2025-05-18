[Serializable]
[DataContract]
    public partial class Individual : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public IndividualType Type { get; set; }
        /// <summary>
        /// Gets or sets the Parameters.
        /// </summary>
        [DataMember]
        public Parameter[] Parameters { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceValue.
        /// </summary>
        [DataMember]
        public Double PerformanceValue { get; set; }
        /// <summary>
        /// Gets or sets the Weight.
        /// </summary>
        [DataMember]
        public Double Weight { get; set; }
        /// <summary>
        /// Gets or sets the IndividualName.
        /// </summary>
        [DataMember]
        public String IndividualName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
