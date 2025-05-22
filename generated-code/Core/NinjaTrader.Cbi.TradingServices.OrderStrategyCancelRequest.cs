[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class OrderStrategyCancelRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the OrderStrategyId.
        /// </summary>
        [DataMember]
        public long OrderStrategyId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
