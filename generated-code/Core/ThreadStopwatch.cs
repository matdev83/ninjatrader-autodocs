[Serializable]
[DataContract]
    public partial class ThreadStopwatch
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Stopwatch.
        /// </summary>
        [DataMember]
        public Stopwatch Stopwatch { get; set; }
        /// <summary>
        /// Gets or sets the StopwatchLevels.
        /// </summary>
        [DataMember]
        public Int32 StopwatchLevels { get; set; }
        #endregion
        #region Methods
        #endregion
    }
