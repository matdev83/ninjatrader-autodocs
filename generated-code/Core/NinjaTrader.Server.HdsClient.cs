[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class HdsClient
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DoSuppressServerMessages.
        /// </summary>
        [DataMember]
        public bool DoSuppressServerMessages { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the Options.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NTConnectOptions Options { get; set; }
        /// <summary>
        /// Gets or sets the UseSsl.
        /// </summary>
        [DataMember]
        public bool UseSsl { get; set; }
        /// <summary>
        /// Gets or sets the IsHdsBackfill.
        /// </summary>
        [DataMember]
        public bool IsHdsBackfill { get; set; }
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
        /// Disconnect method.
        /// </summary>
        public void Disconnect()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DownloadInfoFromServer method.
        /// </summary>
        /// <param name="callback">System.Action<ErrorCode, string></param>
        /// <param name="syncStartupInfoCallback">System.Func<CoreDialogType, System.String[], bool></param>
        /// <param name="onDemandInfoType">StartupInfoType</param>
        /// <param name="demandUpdateOptions">OnDemandUpdateOptions</param>
        /// <param name="system">string</param>
        public void DownloadInfoFromServer(System.Action<ErrorCode, string> callback, System.Func<CoreDialogType, System.String[], bool> syncStartupInfoCallback, StartupInfoType onDemandInfoType, OnDemandUpdateOptions demandUpdateOptions, string system)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.IBars</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.IBars, ErrorCode, string></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        public void RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestMarketReplay method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="dateEst">System.DateTime</param>
        /// <param name="callback">System.Action<ErrorCode, string, object></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="state">object</param>
        public void RequestMarketReplay(NinjaTrader.Cbi.Instrument instrument, System.DateTime dateEst, System.Action<ErrorCode, string, object> callback, NinjaTrader.Core.IProgress progress, object state)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
