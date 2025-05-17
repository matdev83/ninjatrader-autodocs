[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class SmtpServer : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instance.
        /// </summary>
        [DataMember]
        public SmtpServer Instance { get; set; }
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
        #endregion
    }
}
