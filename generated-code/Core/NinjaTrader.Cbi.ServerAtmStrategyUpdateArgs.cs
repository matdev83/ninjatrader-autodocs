[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ServerAtmStrategyUpdateArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the TemplateName.
        /// </summary>
        [DataMember]
        public string TemplateName { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMessage.
        /// </summary>
        [DataMember]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Operation Operation { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public string OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ServerStrategyStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the StrategyId.
        /// </summary>
        [DataMember]
        public long StrategyId { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
