namespace NinjaTrader.Core
{
    public partial interface IProgress
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAborted.
        /// </summary>
        [DataMember]
        public bool IsAborted { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public string Message { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// PerformStep method.
        /// </summary>
        public void PerformStep();
        /// <summary>
        /// SetUp method.
        /// </summary>
        /// <param name="maxSteps">long</param>
        /// <param name="isAbortable">bool</param>
        public void SetUp(long maxSteps, bool isAbortable);
        /// <summary>
        /// TearDown method.
        /// </summary>
        public void TearDown();
        #endregion
    }
}
