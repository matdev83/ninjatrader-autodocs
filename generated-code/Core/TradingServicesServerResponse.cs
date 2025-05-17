[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradingServicesServerResponse
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Data.
        /// </summary>
        [DataMember]
        public JsonNode Data { get; set; }
        /// <summary>
        /// Gets or sets the RequestId.
        /// </summary>
        [DataMember]
        public Int32 RequestId { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public Int32 Status { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
