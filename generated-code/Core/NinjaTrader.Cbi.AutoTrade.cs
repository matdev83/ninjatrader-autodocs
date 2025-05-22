[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AutoTrade : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FindOrderByUserOrderId method.
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order FindOrderByUserOrderId(string id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FindStrategyByName method.
        /// </summary>
        /// <param name="strategyName">string</param>
        /// <returns>NinjaTrader.NinjaScript.AtmStrategy</returns>
        public NinjaTrader.NinjaScript.AtmStrategy FindStrategyByName(string strategyName)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
