[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AddOrderEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Order Order { get; set; }
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
