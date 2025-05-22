[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class SmtpServer : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Server.SmtpServer Instance { get; set; }
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
        #endregion
    }
}
