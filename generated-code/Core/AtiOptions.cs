[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class AtiOptions : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAtiEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAtiEnabled { get; set; }
        /// <summary>
        /// Gets or sets the DefaultAccount.
        /// </summary>
        [DataMember]
        public String DefaultAccount { get; set; }
        /// <summary>
        /// Gets or sets the IgnoreDuplicateOifFiles.
        /// </summary>
        [DataMember]
        public Boolean IgnoreDuplicateOifFiles { get; set; }
        /// <summary>
        /// Gets or sets the IsTradeStationEmailInterfaceEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsTradeStationEmailInterfaceEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the ServerPort.
        /// </summary>
        [DataMember]
        public Int32 ServerPort { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationLimitPriceOffset.
        /// </summary>
        [DataMember]
        public Int32 TradeStationLimitPriceOffset { get; set; }
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
        public Boolean TradeStationSubmitMarketOrderIfStopRejected { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationSyncTimeout.
        /// </summary>
        [DataMember]
        public Int32 TradeStationSyncTimeout { get; set; }
        /// <summary>
        /// Gets or sets the TradeStationUnfilledToMarketDelay.
        /// </summary>
        [DataMember]
        public Int32 TradeStationUnfilledToMarketDelay { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">AtiOptions</param>
        public Void CopyTo(AtiOptions options);
        #endregion
    }
}
