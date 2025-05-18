[Serializable]
[DataContract]
    public partial class Pace
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Actions.
        /// </summary>
        [DataMember]
        public Queue<DateTime> Actions { get; set; }
        /// <summary>
        /// Gets or sets the DoneOnce.
        /// </summary>
        [DataMember]
        public Boolean DoneOnce { get; set; }
        /// <summary>
        /// Gets or sets the DoSendLog.
        /// </summary>
        [DataMember]
        public Boolean DoSendLog { get; set; }
        /// <summary>
        /// Gets or sets the MaxActions.
        /// </summary>
        [DataMember]
        public Double MaxActions { get; set; }
        /// <summary>
        /// Gets or sets the Once.
        /// </summary>
        [DataMember]
        public Boolean Once { get; set; }
        /// <summary>
        /// Gets or sets the Seconds.
        /// </summary>
        [DataMember]
        public Double Seconds { get; set; }
        #endregion
        #region Methods
        #endregion
    }
