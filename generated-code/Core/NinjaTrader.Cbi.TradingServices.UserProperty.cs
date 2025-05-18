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
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        /// <summary>
        /// Gets or sets the PropertyId.
        /// </summary>
        [DataMember]
        public Int64 PropertyId { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public String Value { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
