[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AlertAction : AlertConditionItem, IEquatable<AlertAction>
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
        public String AtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the DetailsString.
        /// </summary>
        [DataMember]
        public String DetailsString { get; set; }
        /// <summary>
        /// Gets or sets the HostType.
        /// </summary>
        [DataMember]
        public AlertHostType HostType { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public Double LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the OrderInstrument.
        /// </summary>
        [DataMember]
        public String OrderInstrument { get; set; }
        /// <summary>
        /// Gets or sets the OrderAccount.
        /// </summary>
        [DataMember]
        public Account OrderAccount { get; set; }
        /// <summary>
        /// Gets or sets the OrderAccountSerialize.
        /// </summary>
        [DataMember]
        public String OrderAccountSerialize { get; set; }
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
        public Int32 OrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public OrderType OrderType { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public String Message { get; set; }
        /// <summary>
        /// Gets or sets the ShareToService.
        /// </summary>
        [DataMember]
        public String ShareToService { get; set; }
        /// <summary>
        /// Gets or sets the ShareToServiceSettings.
        /// </summary>
        [DataMember]
        public String ShareToServiceSettings { get; set; }
        /// <summary>
        /// Gets or sets the ShareMessage.
        /// </summary>
        [DataMember]
        public String ShareMessage { get; set; }
        /// <summary>
        /// Gets or sets the ShareToServiceProxy.
        /// </summary>
        [DataMember]
        public ShareService ShareToServiceProxy { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType.
        /// </summary>
        [DataMember]
        public ShareScreenshotType ShareScreenshotType { get; set; }
        /// <summary>
        /// Gets or sets the SoundLocation.
        /// </summary>
        [DataMember]
        public String SoundLocation { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public Double StopPrice { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplyShareServiceSettings method.
        /// </summary>
        /// <param name="shareServiceSettings">String</param>
        /// <param name="instance">ShareService</param>
        public Void ApplyShareServiceSettings(String shareServiceSettings, ShareService instance);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">ConditionItem</param>
        public Void CopyTo(ConditionItem other);
        /// <summary>
        /// SaveAppliedShareServiceSettings method.
        /// </summary>
        /// <param name="instance">ShareService</param>
        /// <returns>String</returns>
        public String SaveAppliedShareServiceSettings(ShareService instance);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object obj);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">AlertAction</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(AlertAction other);
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        #endregion
    }
}
