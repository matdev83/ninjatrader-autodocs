[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class UserProperty
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        /// <summary>
        /// Gets or sets the PropertyId.
        /// </summary>
        [DataMember]
        public long PropertyId { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public string Value { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
