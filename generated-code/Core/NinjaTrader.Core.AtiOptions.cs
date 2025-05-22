[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class AtiOptions : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAtiEnabled.
        /// </summary>
        [DataMember]
        public bool IsAtiEnabled { get; set; }
        /// <summary>
        /// Gets or sets the DefaultAccount.
        /// </summary>
        [DataMember]
        public string DefaultAccount { get; set; }
        /// <summary>
        /// Gets or sets the IgnoreDuplicateOifFiles.
        /// </summary>
        [DataMember]
        public bool IgnoreDuplicateOifFiles { get; set; }
        /// <summary>
        /// Gets or sets the IsTradeStationEmailInterfaceEnabled.
        /// </summary>
        [DataMember]
        public bool IsTradeStationEmailInterfaceEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the ServerPort.
        /// </summary>
        [DataMember]
        public int ServerPort { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationLimitPriceOffset.
        /// </summary>
        [DataMember]
        public int TradeStationLimitPriceOffset { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationOrderHandlingSubmit.
        /// </summary>
        [DataMember]
        public TSOrderHandling TradeStationOrderHandlingSubmit { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationStopOrderHandlingSubmit.
        /// </summary>
        [DataMember]
        public TSStopOrderHandling TradeStationStopOrderHandlingSubmit { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationSubmitMarketOrderIfStopRejected.
        /// </summary>
        [DataMember]
        public bool TradeStationSubmitMarketOrderIfStopRejected { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationSyncTimeout.
        /// </summary>
        [DataMember]
        public int TradeStationSyncTimeout { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationUnfilledToMarketDelay.
        /// </summary>
        [DataMember]
        public int TradeStationUnfilledToMarketDelay { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">NinjaTrader.Core.AtiOptions</param>
        public void CopyTo(NinjaTrader.Core.AtiOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
