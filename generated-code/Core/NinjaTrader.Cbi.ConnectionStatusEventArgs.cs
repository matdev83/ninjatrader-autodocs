[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ConnectionStatusEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        [DataMember]
        public ErrorCode Error { get; set; }
        /// <summary>
        /// Gets or sets the NativeError.
        /// </summary>
        [DataMember]
        public String NativeError { get; set; }
        /// <summary>
        /// Gets or sets the PreviousStatus.
        /// </summary>
        [DataMember]
        public ConnectionStatus PreviousStatus { get; set; }
        /// <summary>
        /// Gets or sets the PreviousPriceStatus.
        /// </summary>
        [DataMember]
        public ConnectionStatus PreviousPriceStatus { get; set; }
        /// <summary>
        /// Gets or sets the PriceStatus.
        /// </summary>
        [DataMember]
        public ConnectionStatus PriceStatus { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
