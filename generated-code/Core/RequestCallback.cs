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
        public Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the Callback.
        /// </summary>
        [DataMember]
        public Action<Bars, ErrorCode, String, Object> Callback { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public Object State { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
