[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AddExecutionEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Execution.
        /// </summary>
        [DataMember]
        public Execution Execution { get; set; }
        /// <summary>
        /// Gets or sets the Strategy.
        /// </summary>
        [DataMember]
        public StrategyBase Strategy { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
