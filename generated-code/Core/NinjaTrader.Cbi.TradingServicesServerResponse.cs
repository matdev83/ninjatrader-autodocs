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
        public System.Text.Json.Nodes.JsonNode Data { get; set; }
        /// <summary>
        /// Gets or sets the RequestId.
        /// </summary>
        [DataMember]
        public int RequestId { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public int Status { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
