[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ServerAtmStrategyUpdateArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the TemplateName.
        /// </summary>
        [DataMember]
        public String TemplateName { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMessage.
        /// </summary>
        [DataMember]
        public String ErrorMessage { get; set; }
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Operation Operation { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ServerStrategyStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the StrategyId.
        /// </summary>
        [DataMember]
        public Int64 StrategyId { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
