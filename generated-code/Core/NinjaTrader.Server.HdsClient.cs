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
        public Boolean DoSuppressServerMessages { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the Options.
        /// </summary>
        [DataMember]
        public NTConnectOptions Options { get; set; }
        /// <summary>
        /// Gets or sets the UseSsl.
        /// </summary>
        [DataMember]
        public Boolean UseSsl { get; set; }
        /// <summary>
        /// Gets or sets the IsHdsBackfill.
        /// </summary>
        [DataMember]
        public Boolean IsHdsBackfill { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Connect method.
        /// </summary>
        public Void Connect();
        /// <summary>
        /// Disconnect method.
        /// </summary>
        public Void Disconnect();
        /// <summary>
        /// DownloadInfoFromServer method.
        /// </summary>
        /// <param name="callback">Action`2</param>
        /// <param name="syncStartupInfoCallback">Func`3</param>
        /// <param name="onDemandInfoType">StartupInfoType</param>
        /// <param name="demandUpdateOptions">OnDemandUpdateOptions</param>
        /// <param name="system">String</param>
        public Void DownloadInfoFromServer(Action<ErrorCode, String> callback, Func<CoreDialogType, String[], Boolean> syncStartupInfoCallback, StartupInfoType onDemandInfoType, OnDemandUpdateOptions demandUpdateOptions, String system);
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">IBars</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        public Void RequestBars(IBars bars, Action<IBars, ErrorCode, String> callback, IProgress progress);
        /// <summary>
        /// RequestMarketReplay method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="dateEst">DateTime</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        /// <param name="state">Object</param>
        public Void RequestMarketReplay(Instrument instrument, DateTime dateEst, Action<ErrorCode, String, Object> callback, IProgress progress, Object state);
        #endregion
    }
}
