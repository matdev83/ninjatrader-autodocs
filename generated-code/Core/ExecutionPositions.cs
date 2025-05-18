[Serializable]
[DataContract]
    public partial class ExecutionPositions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, Position> Positions { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="execution">Execution</param>
        public Void Add(Execution execution);
        #endregion
    }
