[Serializable]
[DataContract]
namespace NinjaTrader.FIX
{
    public partial class FixSocket : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SyncSend.
        /// </summary>
        [DataMember]
        public object SyncSend { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the UseSsl.
        /// </summary>
        [DataMember]
        public bool UseSsl { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Connect method.
        /// </summary>
        public void Connect()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetFixMessage method.
        /// </summary>
        /// <returns>NinjaTrader.FIX.FixMessage</returns>
        public NinjaTrader.FIX.FixMessage GetFixMessage()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnSocketCompleted method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.Net.Sockets.SocketAsyncEventArgs</param>
        public void OnSocketCompleted(object sender, System.Net.Sockets.SocketAsyncEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SendAsync method.
        /// </summary>
        public void SendAsync()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
