[Serializable]
[DataContract]
namespace NinjaTrader.FIX
{
    public partial class FixSocket : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SyncSend.
        /// </summary>
        [DataMember]
        public Object SyncSend { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the UseSsl.
        /// </summary>
        [DataMember]
        public Boolean UseSsl { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Connect method.
        /// </summary>
        public Void Connect();
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// GetFixMessage method.
        /// </summary>
        /// <returns>FixMessage</returns>
        public FixMessage GetFixMessage();
        /// <summary>
        /// OnSocketCompleted method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">SocketAsyncEventArgs</param>
        public Void OnSocketCompleted(Object sender, SocketAsyncEventArgs e);
        /// <summary>
        /// SendAsync method.
        /// </summary>
        public Void SendAsync();
        #endregion
    }
}
