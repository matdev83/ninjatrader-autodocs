[Serializable]
[DataContract]
    public partial class Generation
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AveragePerformance.
        /// </summary>
        [DataMember]
        public Double AveragePerformance { get; set; }
        /// <summary>
        /// Gets or sets the ChildrenCount.
        /// </summary>
        [DataMember]
        public Int32 ChildrenCount { get; set; }
        /// <summary>
        /// Gets or sets the GenerationNumber.
        /// </summary>
        [DataMember]
        public Int32 GenerationNumber { get; set; }
        /// <summary>
        /// Gets or sets the IsStable.
        /// </summary>
        [DataMember]
        public Boolean IsStable { get; set; }
        /// <summary>
        /// Gets or sets the IsReset.
        /// </summary>
        [DataMember]
        public Boolean IsReset { get; set; }
        /// <summary>
        /// Gets or sets the MaxPerformance.
        /// </summary>
        [DataMember]
        public Double MaxPerformance { get; set; }
        /// <summary>
        /// Gets or sets the MinPerformance.
        /// </summary>
        [DataMember]
        public Double MinPerformance { get; set; }
        /// <summary>
        /// Gets or sets the MutantCount.
        /// </summary>
        [DataMember]
        public Double MutantCount { get; set; }
        /// <summary>
        /// Gets or sets the PercentImprovement.
        /// </summary>
        [DataMember]
        public Double PercentImprovement { get; set; }
        /// <summary>
        /// Gets or sets the ParentCount.
        /// </summary>
        [DataMember]
        public Int32 ParentCount { get; set; }
        /// <summary>
        /// Gets or sets the PopulationCount.
        /// </summary>
        [DataMember]
        public Int32 PopulationCount { get; set; }
        /// <summary>
        /// Gets or sets the RandomCount.
        /// </summary>
        [DataMember]
        public Int32 RandomCount { get; set; }
        /// <summary>
        /// Gets or sets the StabilityScore.
        /// </summary>
        [DataMember]
        public Double StabilityScore { get; set; }
        /// <summary>
        /// Gets or sets the TotalPerformance.
        /// </summary>
        [DataMember]
        public Double TotalPerformance { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AnalyzeInput method.
        /// </summary>
        /// <param name="individuals">Individual[]</param>
        public Void AnalyzeInput(Individual[] individuals);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
