[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AlertAction : NinjaTrader.NinjaScript.AlertConditionItem, System.IEquatable<NinjaTrader.NinjaScript.AlertAction>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public AlertActionType Action { get; set; }
        /// <summary>
        /// Gets or sets the AtmStrategy.
        /// </summary>
        [DataMember]
        public string AtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the DetailsString.
        /// </summary>
        [DataMember]
        public string DetailsString { get; set; }
        /// <summary>
        /// Gets or sets the HostType.
        /// </summary>
        [DataMember]
        public AlertHostType HostType { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public double LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the OrderInstrument.
        /// </summary>
        [DataMember]
        public string OrderInstrument { get; set; }
        /// <summary>
        /// Gets or sets the OrderAccount.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account OrderAccount { get; set; }
        /// <summary>
        /// Gets or sets the OrderAccountSerialize.
        /// </summary>
        [DataMember]
        public string OrderAccountSerialize { get; set; }
        /// <summary>
        /// Gets or sets the OrderTimeInForce.
        /// </summary>
        [DataMember]
        public TimeInForce OrderTimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction.
        /// </summary>
        [DataMember]
        public OrderAction OrderAction { get; set; }
        /// <summary>
        /// Gets or sets the OrderQuantity.
        /// </summary>
        [DataMember]
        public int OrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public OrderType OrderType { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public string Message { get; set; }
        /// <summary>
        /// Gets or sets the ShareToService.
        /// </summary>
        [DataMember]
        public string ShareToService { get; set; }
        /// <summary>
        /// Gets or sets the ShareToServiceSettings.
        /// </summary>
        [DataMember]
        public string ShareToServiceSettings { get; set; }
        /// <summary>
        /// Gets or sets the ShareMessage.
        /// </summary>
        [DataMember]
        public string ShareMessage { get; set; }
        /// <summary>
        /// Gets or sets the ShareToServiceProxy.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.ShareServices.ShareService ShareToServiceProxy { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType.
        /// </summary>
        [DataMember]
        public ShareScreenshotType ShareScreenshotType { get; set; }
        /// <summary>
        /// Gets or sets the SoundLocation.
        /// </summary>
        [DataMember]
        public string SoundLocation { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public double StopPrice { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplyShareServiceSettings method.
        /// </summary>
        /// <param name="shareServiceSettings">string</param>
        /// <param name="instance">NinjaTrader.NinjaScript.ShareServices.ShareService</param>
        public void ApplyShareServiceSettings(string shareServiceSettings, NinjaTrader.NinjaScript.ShareServices.ShareService instance)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.ConditionItem</param>
        public void CopyTo(NinjaTrader.NinjaScript.ConditionItem other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SaveAppliedShareServiceSettings method.
        /// </summary>
        /// <param name="instance">NinjaTrader.NinjaScript.ShareServices.ShareService</param>
        /// <returns>string</returns>
        public string SaveAppliedShareServiceSettings(NinjaTrader.NinjaScript.ShareServices.ShareService instance)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public bool Equals(object obj)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.AlertAction</param>
        /// <returns>bool</returns>
        public bool Equals(NinjaTrader.NinjaScript.AlertAction other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>int</returns>
        public int GetHashCode()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
