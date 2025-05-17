namespace NinjaTrader.Core
{
    public partial interface IProgress
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAborted.
        /// </summary>
        [DataMember]
        public Boolean IsAborted { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public String Message { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// PerformStep method.
        /// </summary>
        public Void PerformStep();
        /// <summary>
        /// SetUp method.
        /// </summary>
        /// <param name="maxSteps">Int64</param>
        /// <param name="isAbortable">Boolean</param>
        public Void SetUp(Int64 maxSteps, Boolean isAbortable);
        /// <summary>
        /// TearDown method.
        /// </summary>
        public Void TearDown();
        #endregion
    }
}
