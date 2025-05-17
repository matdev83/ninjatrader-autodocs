[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AddOrderEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Order Order { get; set; }
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
