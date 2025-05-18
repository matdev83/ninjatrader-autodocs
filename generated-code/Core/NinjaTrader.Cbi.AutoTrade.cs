[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AutoTrade : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsEnabled { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// FindOrderByUserOrderId method.
        /// </summary>
        /// <param name="id">String</param>
        /// <returns>Order</returns>
        public Order FindOrderByUserOrderId(String id);
        /// <summary>
        /// FindStrategyByName method.
        /// </summary>
        /// <param name="strategyName">String</param>
        /// <returns>AtmStrategy</returns>
        public AtmStrategy FindStrategyByName(String strategyName);
        #endregion
    }
}
