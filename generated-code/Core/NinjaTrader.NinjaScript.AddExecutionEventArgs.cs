[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AddExecutionEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Execution.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Execution Execution { get; set; }
        /// <summary>
        /// Gets or sets the Strategy.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.StrategyBase Strategy { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
