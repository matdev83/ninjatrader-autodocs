[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class RequestCallback
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the Callback.
        /// </summary>
        [DataMember]
        public System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> Callback { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public object State { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
