[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Globals
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ActiveWorkspace.
        /// </summary>
        [DataMember]
        public String ActiveWorkspace { get; set; }
        /// <summary>
        /// Gets or sets the AdapterCrashFileName.
        /// </summary>
        [DataMember]
        public String AdapterCrashFileName { get; set; }
        /// <summary>
        /// Gets or sets the AddOnRegistry.
        /// </summary>
        [DataMember]
        public Dictionary<String, AddOnAuthorization> AddOnRegistry { get; set; }
        /// <summary>
        /// Gets or sets the AssemblyRegistry.
        /// </summary>
        [DataMember]
        public AssemblyRegistry AssemblyRegistry { get; set; }
        /// <summary>
        /// Gets or sets the AtiOptions.
        /// </summary>
        [DataMember]
        public AtiOptions AtiOptions { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticatedUser.
        /// </summary>
        [DataMember]
        public AuthenticatedUser AuthenticatedUser { get; set; }
        /// <summary>
        /// Gets or sets the BrokerageConnectOptions.
        /// </summary>
        [DataMember]
        public List<ConnectOptions> BrokerageConnectOptions { get; set; }
        /// <summary>
        /// Gets or sets the BuyPlatformURL.
        /// </summary>
        [DataMember]
        public String BuyPlatformURL { get; set; }
        /// <summary>
        /// Gets or sets the CompanyName.
        /// </summary>
        [DataMember]
        public String CompanyName { get; set; }
        /// <summary>
        /// Gets or sets the ConnectOptions.
        /// </summary>
        [DataMember]
        public Collection<ConnectOptions> ConnectOptions { get; set; }
        /// <summary>
        /// Gets or sets the CoreCount.
        /// </summary>
        [DataMember]
        public Int32 CoreCount { get; set; }
        /// <summary>
        /// Gets or sets the CreateLoadingDialog.
        /// </summary>
        [DataMember]
        public Func<ILoadingDialog> CreateLoadingDialog { get; set; }
        /// <summary>
        /// Gets or sets the CreateProgressWindow.
        /// </summary>
        [DataMember]
        public Func<String, IProgress> CreateProgressWindow { get; set; }
        /// <summary>
        /// Gets or sets the CustomSubDirs.
        /// </summary>
        [DataMember]
        public String[] CustomSubDirs { get; set; }
        /// <summary>
        /// Gets or sets the D2DFactory.
        /// </summary>
        [DataMember]
        public Factory D2DFactory { get; set; }
        /// <summary>
        /// Gets or sets the DirectWriteFactory.
        /// </summary>
        [DataMember]
        public Factory DirectWriteFactory { get; set; }
        /// <summary>
        /// Gets or sets the HelpGuideUrl.
        /// </summary>
        [DataMember]
        public String HelpGuideUrl { get; set; }
        /// <summary>
        /// Gets or sets the HiddenAccoutValue.
        /// </summary>
        [DataMember]
        public String HiddenAccoutValue { get; set; }
        /// <summary>
        /// Gets or sets the InstallDir.
        /// </summary>
        [DataMember]
        public String InstallDir { get; set; }
        /// <summary>
        /// Gets or sets the IsBrokerageMode.
        /// </summary>
        [DataMember]
        public Boolean IsBrokerageMode { get; set; }
        /// <summary>
        /// Gets or sets the LongTimeMillisecondPattern.
        /// </summary>
        [DataMember]
        public String LongTimeMillisecondPattern { get; set; }
        /// <summary>
        /// Gets or sets the MainThreadDispatcher.
        /// </summary>
        [DataMember]
        public Dispatcher MainThreadDispatcher { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataOptions.
        /// </summary>
        [DataMember]
        public MarketDataOptions MarketDataOptions { get; set; }
        /// <summary>
        /// Gets or sets the InformationMessageCallback.
        /// </summary>
        [DataMember]
        public Action<String, Boolean, Boolean> InformationMessageCallback { get; set; }
        /// <summary>
        /// Gets or sets the PFConfig.
        /// </summary>
        [DataMember]
        public XDocument PFConfig { get; set; }
        /// <summary>
        /// Gets or sets the ProductVersion.
        /// </summary>
        [DataMember]
        public String ProductVersion { get; set; }
        /// <summary>
        /// Gets or sets the RandomDispatcher.
        /// </summary>
        [DataMember]
        public Dispatcher RandomDispatcher { get; set; }
        /// <summary>
        /// Gets or sets the RmsOptions.
        /// </summary>
        [DataMember]
        public RmsOptions RmsOptions { get; set; }
        /// <summary>
        /// Gets or sets the ScriptServer.
        /// </summary>
        [DataMember]
        public String ScriptServer { get; set; }
        /// <summary>
        /// Gets or sets the SslServerHost.
        /// </summary>
        [DataMember]
        public String SslServerHost { get; set; }
        /// <summary>
        /// Gets or sets the SslServerFtpPassword.
        /// </summary>
        [DataMember]
        public String SslServerFtpPassword { get; set; }
        /// <summary>
        /// Gets or sets the SslServerFtpUser.
        /// </summary>
        [DataMember]
        public String SslServerFtpUser { get; set; }
        /// <summary>
        /// Gets or sets the StrategiesOptions.
        /// </summary>
        [DataMember]
        public StrategiesOptions StrategiesOptions { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguages.
        /// </summary>
        [DataMember]
        public Collection<String> SupportedLanguages { get; set; }
        /// <summary>
        /// Gets or sets the UI.
        /// </summary>
        [DataMember]
        public XDocument UI { get; set; }
        /// <summary>
        /// Gets or sets the UserFeedbackCallback.
        /// </summary>
        [DataMember]
        public Func<CoreDialogType, String[], Boolean> UserFeedbackCallback { get; set; }
        /// <summary>
        /// Gets or sets the VendorLicenseNotification.
        /// </summary>
        [DataMember]
        public Action<String, String, String, String, String> VendorLicenseNotification { get; set; }
        /// <summary>
        /// Gets or sets the VendorCode.
        /// </summary>
        [DataMember]
        public String VendorCode { get; set; }
        /// <summary>
        /// Gets or sets the Website.
        /// </summary>
        [DataMember]
        public String Website { get; set; }
        /// <summary>
        /// Gets or sets the WicImagingFactory.
        /// </summary>
        [DataMember]
        public ImagingFactory WicImagingFactory { get; set; }
        /// <summary>
        /// Gets or sets the TradeUrlDemo.
        /// </summary>
        [DataMember]
        public String TradeUrlDemo { get; set; }
        /// <summary>
        /// Gets or sets the TradeUrlLive.
        /// </summary>
        [DataMember]
        public String TradeUrlLive { get; set; }
        /// <summary>
        /// Gets or sets the TradeUrlDemoDev.
        /// </summary>
        [DataMember]
        public String TradeUrlDemoDev { get; set; }
        /// <summary>
        /// Gets or sets the TradeUrlLiveDev.
        /// </summary>
        [DataMember]
        public String TradeUrlLiveDev { get; set; }
        /// <summary>
        /// Gets or sets the ConfigUrl.
        /// </summary>
        [DataMember]
        public String ConfigUrl { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlMarketDataDemoDev.
        /// </summary>
        [DataMember]
        public String SocketUrlMarketDataDemoDev { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlMarketDataDemoProd.
        /// </summary>
        [DataMember]
        public String SocketUrlMarketDataDemoProd { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlMarketDataLiveDev.
        /// </summary>
        [DataMember]
        public String SocketUrlMarketDataLiveDev { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlMarketDataLiveProd.
        /// </summary>
        [DataMember]
        public String SocketUrlMarketDataLiveProd { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlTradeDemoDev.
        /// </summary>
        [DataMember]
        public String SocketUrlTradeDemoDev { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlTradeDemoProd.
        /// </summary>
        [DataMember]
        public String SocketUrlTradeDemoProd { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlTradeLiveDev.
        /// </summary>
        [DataMember]
        public String SocketUrlTradeLiveDev { get; set; }
        /// <summary>
        /// Gets or sets the SocketUrlTradeLiveProd.
        /// </summary>
        [DataMember]
        public String SocketUrlTradeLiveProd { get; set; }
        /// <summary>
        /// Gets or sets the ReportDemoDevUrl.
        /// </summary>
        [DataMember]
        public String ReportDemoDevUrl { get; set; }
        /// <summary>
        /// Gets or sets the ReportDemoProdUrl.
        /// </summary>
        [DataMember]
        public String ReportDemoProdUrl { get; set; }
        /// <summary>
        /// Gets or sets the ReportLiveDevUrl.
        /// </summary>
        [DataMember]
        public String ReportLiveDevUrl { get; set; }
        /// <summary>
        /// Gets or sets the ReportLiveProdUrl.
        /// </summary>
        [DataMember]
        public String ReportLiveProdUrl { get; set; }
        /// <summary>
        /// Gets or sets the AdminOptions.
        /// </summary>
        [DataMember]
        public AdminOptions AdminOptions { get; set; }
        /// <summary>
        /// Gets or sets the Config.
        /// </summary>
        [DataMember]
        public XDocument Config { get; set; }
        /// <summary>
        /// Gets or sets the CurrencyRateDefaults.
        /// </summary>
        [DataMember]
        public Dictionary<String, Double> CurrencyRateDefaults { get; set; }
        /// <summary>
        /// Gets or sets the GeneralOptions.
        /// </summary>
        [DataMember]
        public GeneralOptions GeneralOptions { get; set; }
        /// <summary>
        /// Gets or sets the IsAdapterAsProcess.
        /// </summary>
        [DataMember]
        public Boolean IsAdapterAsProcess { get; set; }
        /// <summary>
        /// Gets or sets the IsApplicationExiting.
        /// </summary>
        [DataMember]
        public Boolean IsApplicationExiting { get; set; }
        /// <summary>
        /// Gets or sets the IsKoreanBuild.
        /// </summary>
        [DataMember]
        public Boolean IsKoreanBuild { get; set; }
        /// <summary>
        /// Gets or sets the IsInSafeMode.
        /// </summary>
        [DataMember]
        public Boolean IsInSafeMode { get; set; }
        /// <summary>
        /// Gets or sets the MachineName.
        /// </summary>
        [DataMember]
        public String MachineName { get; set; }
        /// <summary>
        /// Gets or sets the NTConfig.
        /// </summary>
        [DataMember]
        public XDocument NTConfig { get; set; }
        /// <summary>
        /// Gets or sets the Now.
        /// </summary>
        [DataMember]
        public DateTime Now { get; set; }
        /// <summary>
        /// Gets or sets the PrimaryServer.
        /// </summary>
        [DataMember]
        public String PrimaryServer { get; set; }
        /// <summary>
        /// Gets or sets the ProductName.
        /// </summary>
        [DataMember]
        public String ProductName { get; set; }
        /// <summary>
        /// Gets or sets the RemoteConfigFilePollingSeconds.
        /// </summary>
        [DataMember]
        public Int32 RemoteConfigFilePollingSeconds { get; set; }
        /// <summary>
        /// Gets or sets the ServerErrorCode.
        /// </summary>
        [DataMember]
        public String ServerErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the ServerOptions.
        /// </summary>
        [DataMember]
        public ServerOptions ServerOptions { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneInfoDictionary.
        /// </summary>
        [DataMember]
        public Dictionary<String, TimeZoneInfo> TimeZoneInfoDictionary { get; set; }
        /// <summary>
        /// Gets or sets the TraceListener.
        /// </summary>
        [DataMember]
        public TraceListener TraceListener { get; set; }
        /// <summary>
        /// Gets or sets the TradingOptions.
        /// </summary>
        [DataMember]
        public TradingOptions TradingOptions { get; set; }
        /// <summary>
        /// Gets or sets the DataFolderName.
        /// </summary>
        [DataMember]
        public String DataFolderName { get; set; }
        /// <summary>
        /// Gets or sets the UserDataDir.
        /// </summary>
        [DataMember]
        public String UserDataDir { get; set; }
        /// <summary>
        /// Gets or sets the UseBetaEnvironment.
        /// </summary>
        [DataMember]
        public Boolean UseBetaEnvironment { get; set; }
        /// <summary>
        /// Gets or sets the UseDevEnvironment.
        /// </summary>
        [DataMember]
        public Boolean UseDevEnvironment { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplicationExit method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean ApplicationExit();
        /// <summary>
        /// ApplicationStart method.
        /// </summary>
        /// <param name="errorCallback">Action`3</param>
        /// <param name="userFeedbackCallbackYesNoAll">Func`2</param>
        /// <returns>Boolean</returns>
        public Boolean ApplicationStart(Action<String, Boolean, Boolean> errorCallback, Func<String, Int32> userFeedbackCallbackYesNoAll);
        /// <summary>
        /// AutoConnect method.
        /// </summary>
        public Void AutoConnect();
        /// <summary>
        /// BackupWithConfigSettings method.
        /// </summary>
        /// <param name="callback">Action</param>
        public Void BackupWithConfigSettings(Action callback);
        /// <summary>
        /// CopyAndInstallAssemblies method.
        /// </summary>
        /// <param name="dir">String</param>
        /// <param name="isFirstAttempt">Boolean</param>
        /// <param name="assemblyToLoad">String</param>
        /// <param name="installedAssembliesToLeave">Collection`1</param>
        public Void CopyAndInstallAssemblies(String dir, Boolean isFirstAttempt, String assemblyToLoad, Collection<String> installedAssembliesToLeave);
        /// <summary>
        /// CreateNT8Mutex method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean CreateNT8Mutex();
        /// <summary>
        /// CreateSubDirs method.
        /// </summary>
        /// <param name="file">String</param>
        public Void CreateSubDirs(String file);
        /// <summary>
        /// EncryptLegacy method.
        /// </summary>
        /// <param name="text">String</param>
        /// <param name="decrKey">String</param>
        /// <returns>String</returns>
        public String EncryptLegacy(String text, String decrKey);
        /// <summary>
        /// DecompressArchiveToTmpDir method.
        /// </summary>
        /// <param name="archiveName">String</param>
        /// <param name="tmpDir">String</param>
        /// <param name="fromRestore">Boolean</param>
        /// <param name="allFiles">Collection`1</param>
        /// <param name="progress">IProgress</param>
        public Void DecompressArchiveToTmpDir(String archiveName, String tmpDir, Boolean fromRestore, Collection<String> allFiles, IProgress progress);
        /// <summary>
        /// Decrypt method.
        /// </summary>
        /// <param name="text">String</param>
        /// <param name="key">String</param>
        /// <returns>String</returns>
        public String Decrypt(String text, String key);
        /// <summary>
        /// DeleteFile method.
        /// </summary>
        /// <param name="path">String</param>
        public Void DeleteFile(String path);
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <param name="xml">String</param>
        /// <returns>T</returns>
        public T Deserialize(String xml);
        /// <summary>
        /// DoBackup method.
        /// </summary>
        /// <param name="info">XDocument</param>
        /// <param name="archiveName">String</param>
        /// <param name="hadCompileError">Boolean</param>
        /// <param name="backupConfigurationFiles">Boolean</param>
        /// <param name="backupDatabase">Boolean</param>
        /// <param name="backupHistoricalChartData">Boolean</param>
        /// <param name="backupLogAndTraceFiles">Boolean</param>
        /// <param name="backupMarketReplay">Boolean</param>
        /// <param name="backupNinjaScriptFiles">Boolean</param>
        /// <param name="backupTemplates">Boolean</param>
        /// <param name="backupWorkspaces">Boolean</param>
        /// <param name="progress">IProgress</param>
        /// <param name="messageCallback">Action`1</param>
        /// <param name="callback">Action</param>
        public Void DoBackup(XDocument info, String archiveName, Boolean hadCompileError, Boolean backupConfigurationFiles, Boolean backupDatabase, Boolean backupHistoricalChartData, Boolean backupLogAndTraceFiles, Boolean backupMarketReplay, Boolean backupNinjaScriptFiles, Boolean backupTemplates, Boolean backupWorkspaces, IProgress progress, Action<String> messageCallback, Action callback);
        /// <summary>
        /// DoRestore method.
        /// </summary>
        /// <param name="archiveName">String</param>
        /// <param name="entitiesToRestore">Int32</param>
        /// <param name="progress">IProgress</param>
        /// <param name="messageCallback">Action`3</param>
        /// <param name="callback">Action`1</param>
        public Void DoRestore(String archiveName, Int32 entitiesToRestore, IProgress progress, Action<String, Boolean, Boolean> messageCallback, Action<Boolean> callback);
        /// <summary>
        /// Encrypt method.
        /// </summary>
        /// <param name="text">String</param>
        /// <param name="key">String</param>
        /// <returns>String</returns>
        public String Encrypt(String text, String key);
        /// <summary>
        /// FormatCryptocurrencyQuantity method.
        /// </summary>
        /// <param name="quantity">Int64</param>
        /// <param name="truncate">Boolean</param>
        /// <returns>String</returns>
        public String FormatCryptocurrencyQuantity(Int64 quantity, Boolean truncate);
        /// <summary>
        /// FormatAccountName method.
        /// </summary>
        /// <param name="accountName">String</param>
        /// <returns>String</returns>
        public String FormatAccountName(String accountName);
        /// <summary>
        /// FormatAccountValues method.
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>String</returns>
        public String FormatAccountValues(String value);
        /// <summary>
        /// FormatCryptocurrencyQuantity method.
        /// </summary>
        /// <param name="quantity">Double</param>
        /// <param name="truncate">Boolean</param>
        /// <returns>String</returns>
        public String FormatCryptocurrencyQuantity(Double quantity, Boolean truncate);
        /// <summary>
        /// FormatCurrency method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String FormatCurrency(Double value);
        /// <summary>
        /// FormatCurrency method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <param name="position">Position</param>
        /// <returns>String</returns>
        public String FormatCurrency(Double value, Position position);
        /// <summary>
        /// FormatCurrency method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <param name="strategy">StrategyBase</param>
        /// <returns>String</returns>
        public String FormatCurrency(Double value, StrategyBase strategy);
        /// <summary>
        /// GetAddOnsInDll method.
        /// </summary>
        /// <param name="dllFile">String</param>
        /// <returns>String[]</returns>
        public String[] GetAddOnsInDll(String dllFile);
        /// <summary>
        /// GetAddOnsInZip method.
        /// </summary>
        /// <param name="zipFile">String</param>
        /// <returns>String[]</returns>
        public String[] GetAddOnsInZip(String zipFile);
        /// <summary>
        /// GetExpiryYear method.
        /// </summary>
        /// <param name="yearInDecade">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetExpiryYear(Int32 yearInDecade);
        /// <summary>
        /// GetFileHashCode method.
        /// </summary>
        /// <param name="value">IntPtr</param>
        /// <returns>Int64</returns>
        public Int64 GetFileHashCode(IntPtr value);
        /// <summary>
        /// GetIncrementedCounterName method.
        /// </summary>
        /// <param name="existingNames">Collection`1</param>
        /// <param name="newName">String</param>
        /// <returns>String</returns>
        public String GetIncrementedCounterName(Collection<String> existingNames, String newName);
        /// <summary>
        /// GetDecodedJwt method.
        /// </summary>
        /// <param name="jwt">String</param>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<Claim> GetDecodedJwt(String jwt);
        /// <summary>
        /// GetIncrementedCounterFileName method.
        /// </summary>
        /// <param name="existingNames">Collection`1</param>
        /// <param name="newName">String</param>
        /// <returns>String</returns>
        public String GetIncrementedCounterFileName(Collection<String> existingNames, String newName);
        /// <summary>
        /// GetLotSize method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="instrument">Instrument</param>
        /// <returns>Int32</returns>
        public Int32 GetLotSize(Account account, Instrument instrument);
        /// <summary>
        /// GetInstallFile method.
        /// </summary>
        /// <returns>XDocument</returns>
        public XDocument GetInstallFile();
        /// <summary>
        /// GetTwitterSignature method.
        /// </summary>
        /// <param name="url">String</param>
        /// <param name="method">String</param>
        /// <param name="parameters">OrderedDictionary</param>
        /// <returns>String</returns>
        public String GetTwitterSignature(String url, String method, OrderedDictionary parameters);
        /// <summary>
        /// GetTwitterSignature method.
        /// </summary>
        /// <param name="url">String</param>
        /// <param name="method">String</param>
        /// <param name="secret">String</param>
        /// <param name="parameters">OrderedDictionary</param>
        /// <returns>String</returns>
        public String GetTwitterSignature(String url, String method, String secret, OrderedDictionary parameters);
        /// <summary>
        /// GetWrapperFiles method.
        /// </summary>
        /// <param name="path">String</param>
        /// <returns>List`1</returns>
        public List<String> GetWrapperFiles(String path);
        /// <summary>
        /// IsImportVersionCheckOk method.
        /// </summary>
        /// <param name="zipFilename">String</param>
        /// <returns>Boolean</returns>
        public Boolean IsImportVersionCheckOk(String zipFilename);
        /// <summary>
        /// IsValidFileName method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidFileName(String name);
        /// <summary>
        /// LoadFrom3rdParty method.
        /// </summary>
        /// <param name="file">String</param>
        /// <returns>Assembly</returns>
        public Assembly LoadFrom3rdParty(String file);
        /// <summary>
        /// OnUnhandledApplicationException method.
        /// </summary>
        /// <param name="exception">Exception</param>
        public Void OnUnhandledApplicationException(Exception exception);
        /// <summary>
        /// ParseQuantity method.
        /// </summary>
        /// <param name="txt">String</param>
        /// <returns>Int64</returns>
        public Int64 ParseQuantity(String txt);
        /// <summary>
        /// PFConfigReset method.
        /// </summary>
        public Void PFConfigReset();
        /// <summary>
        /// PlaySound method.
        /// </summary>
        /// <param name="soundType">SoundType</param>
        /// <param name="account">Account</param>
        public Void PlaySound(SoundType soundType, Account account);
        /// <summary>
        /// PlaySound method.
        /// </summary>
        /// <param name="file">String</param>
        public Void PlaySound(String file);
        /// <summary>
        /// RemoveBasenameSubfiles method.
        /// </summary>
        /// <param name="dllBasenamesToRemove">Collection`1</param>
        public Void RemoveBasenameSubfiles(Collection<String> dllBasenamesToRemove);
        /// <summary>
        /// ReplaceNonXmlChars method.
        /// </summary>
        /// <param name="msg">String</param>
        /// <returns>String</returns>
        public String ReplaceNonXmlChars(String msg);
        /// <summary>
        /// SendGMail method.
        /// </summary>
        /// <param name="from">String</param>
        /// <param name="senderName">String</param>
        /// <param name="to">String[]</param>
        /// <param name="cc">String[]</param>
        /// <param name="body">String</param>
        /// <param name="subject">String</param>
        /// <param name="filePath">String</param>
        /// <param name="authToken">String</param>
        /// <returns>Task`1</returns>
        public Task<Boolean> SendGMail(String from, String senderName, String[] to, String[] cc, String body, String subject, String filePath, String authToken);
        /// <summary>
        /// SendMail method.
        /// </summary>
        /// <param name="to">String</param>
        /// <param name="cc">String</param>
        /// <param name="subject">String</param>
        /// <param name="text">String</param>
        /// <param name="attachmentPaths">String[]</param>
        public Void SendMail(String to, String cc, String subject, String text, String[] attachmentPaths);
        /// <summary>
        /// SendMail method.
        /// </summary>
        /// <param name="to">String</param>
        /// <param name="cc">String</param>
        /// <param name="subject">String</param>
        /// <param name="text">String</param>
        /// <param name="isBodyHtml">Boolean</param>
        /// <param name="attachmentPaths">String[]</param>
        public Void SendMail(String to, String cc, String subject, String text, Boolean isBodyHtml, String[] attachmentPaths);
        /// <summary>
        /// SendMailNow method.
        /// </summary>
        /// <param name="to">String</param>
        /// <param name="cc">String</param>
        /// <param name="subject">String</param>
        /// <param name="body">String</param>
        /// <param name="isBodyHtml">Boolean</param>
        /// <param name="attachmentPaths">String[]</param>
        public Void SendMailNow(String to, String cc, String subject, String body, Boolean isBodyHtml, String[] attachmentPaths);
        /// <summary>
        /// SendMailToServer method.
        /// </summary>
        /// <param name="from">String</param>
        /// <param name="senderName">String</param>
        /// <param name="to">String[]</param>
        /// <param name="cc">String[]</param>
        /// <param name="body">String</param>
        /// <param name="subject">String</param>
        /// <param name="filePath">String</param>
        /// <param name="server">String</param>
        /// <param name="port">Int32</param>
        /// <param name="username">String</param>
        /// <param name="password">String</param>
        /// <param name="isBodyHtml">Boolean</param>
        /// <returns>Task`1</returns>
        public Task<Boolean> SendMailToServer(String from, String senderName, String[] to, String[] cc, String body, String subject, String filePath, String server, Int32 port, String username, String password, Boolean isBodyHtml);
        /// <summary>
        /// SendMailToSupportAsync method.
        /// </summary>
        /// <param name="from">String</param>
        /// <param name="to">String</param>
        /// <param name="subject">String</param>
        /// <param name="body">String</param>
        /// <param name="cc">Boolean</param>
        /// <returns>Task`1</returns>
        public Task<Boolean> SendMailToSupportAsync(String from, String to, String subject, String body, Boolean cc);
        /// <summary>
        /// Serialize method.
        /// </summary>
        /// <param name="data">T</param>
        /// <returns>String</returns>
        public String Serialize(T data);
        /// <summary>
        /// SetFileTimestamp method.
        /// </summary>
        /// <param name="filename">String</param>
        /// <param name="newTime">DateTime</param>
        public Void SetFileTimestamp(String filename, DateTime newTime);
        /// <summary>
        /// ToApplicationTime method.
        /// </summary>
        /// <param name="localTime">DateTime</param>
        /// <param name="sourceTimeZone">TimeZoneInfo</param>
        /// <returns>DateTime</returns>
        public DateTime ToApplicationTime(DateTime localTime, TimeZoneInfo sourceTimeZone);
        /// <summary>
        /// ToFileName method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>String</returns>
        public String ToFileName(String name);
        /// <summary>
        /// FromCryptocurrencyVolume method.
        /// </summary>
        /// <param name="volume">Double</param>
        /// <returns>Int64</returns>
        public Int64 FromCryptocurrencyVolume(Double volume);
        /// <summary>
        /// ToLocalizedObject method.
        /// </summary>
        /// <param name="value">BarsPeriodType</param>
        /// <param name="cultureInfo">CultureInfo</param>
        /// <returns>String</returns>
        public String ToLocalizedObject(BarsPeriodType value, CultureInfo cultureInfo);
        /// <summary>
        /// UnzipInfoFile method.
        /// </summary>
        /// <param name="archiveName">String</param>
        /// <param name="tmpInfoDir">String</param>
        public Void UnzipInfoFile(String archiveName, String tmpInfoDir);
        /// <summary>
        /// UrlEncode method.
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>String</returns>
        public String UrlEncode(String value);
        /// <summary>
        /// CheckPasswordPolicy method.
        /// </summary>
        /// <param name="userName">String</param>
        /// <param name="password">String</param>
        /// <returns>Int32</returns>
        public Int32 CheckPasswordPolicy(String userName, String password);
        /// <summary>
        /// FormatCurrency method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <param name="currency">Currency</param>
        /// <returns>String</returns>
        public String FormatCurrency(Double value, Currency currency);
        /// <summary>
        /// FormatQuantity method.
        /// </summary>
        /// <param name="quantity">Int64</param>
        /// <param name="round">Boolean</param>
        /// <returns>String</returns>
        public String FormatQuantity(Int64 quantity, Boolean round);
        /// <summary>
        /// FormatYValue method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String FormatYValue(Double value);
        /// <summary>
        /// GetConnectPoint method.
        /// </summary>
        /// <param name="connectionType">ConnectionType</param>
        /// <param name="useWebSocket">Boolean</param>
        /// <param name="system">String</param>
        /// <returns>Tuple`3</returns>
        public Tuple<String, Int32, Boolean> GetConnectPoint(ConnectionType connectionType, Boolean useWebSocket, String system);
        /// <summary>
        /// GetCurrencySymbol method.
        /// </summary>
        /// <param name="currency">Currency</param>
        /// <returns>String</returns>
        public String GetCurrencySymbol(Currency currency);
        /// <summary>
        /// GetTechnologyNames method.
        /// </summary>
        /// <param name="provider">Provider</param>
        /// <returns>String[]</returns>
        public String[] GetTechnologyNames(Provider provider);
        /// <summary>
        /// GetTickFormatString method.
        /// </summary>
        /// <param name="tickSize">Double</param>
        /// <returns>String</returns>
        public String GetTickFormatString(Double tickSize);
        /// <summary>
        /// GetToVGoogleAuthorizationCode method.
        /// </summary>
        /// <param name="code">String</param>
        /// <param name="useDevEnv">Boolean</param>
        /// <returns>Task`1</returns>
        public Task<String> GetToVGoogleAuthorizationCode(String code, Boolean useDevEnv);
        /// <summary>
        /// GetValidTime method.
        /// </summary>
        /// <param name="timeZoneInfo">TimeZoneInfo</param>
        /// <param name="time">DateTime</param>
        /// <param name="resolveAmbigous">Boolean</param>
        /// <returns>DateTime</returns>
        public DateTime GetValidTime(TimeZoneInfo timeZoneInfo, DateTime time, Boolean resolveAmbigous);
        /// <summary>
        /// File2ZipArchive method.
        /// </summary>
        /// <param name="zipArchive">ZipArchive</param>
        /// <param name="entryName">String</param>
        /// <param name="fileName">String</param>
        /// <param name="isBackup">Boolean</param>
        public Void File2ZipArchive(ZipArchive zipArchive, String entryName, String fileName, Boolean isBackup);
        /// <summary>
        /// FromLocalizedObject method.
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="txt">String</param>
        /// <param name="currentUICulture">CultureInfo</param>
        /// <returns>Object</returns>
        public Object FromLocalizedObject(Type type, String txt, CultureInfo currentUICulture);
        /// <summary>
        /// GenerateLicenseCode method.
        /// </summary>
        /// <returns>String</returns>
        public String GenerateLicenseCode();
        /// <summary>
        /// ToApplicationTime method.
        /// </summary>
        /// <param name="localTime">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime ToApplicationTime(DateTime localTime);
        /// <summary>
        /// ToCryptocurrencyVolume method.
        /// </summary>
        /// <param name="volume">Int64</param>
        /// <returns>Double</returns>
        public Double ToCryptocurrencyVolume(Int64 volume);
        /// <summary>
        /// ToLocalizedObject method.
        /// </summary>
        /// <param name="value">Object</param>
        /// <param name="cultureInfo">CultureInfo</param>
        /// <returns>String</returns>
        public String ToLocalizedObject(Object value, CultureInfo cultureInfo);
        /// <summary>
        /// ToLocalizedObject method.
        /// </summary>
        /// <param name="orderAction">OrderAction</param>
        /// <returns>String</returns>
        public String ToLocalizedObject(OrderAction orderAction);
        /// <summary>
        /// ToLocalizedObject method.
        /// </summary>
        /// <param name="orderState">OrderState</param>
        /// <returns>String</returns>
        public String ToLocalizedObject(OrderState orderState);
        /// <summary>
        /// ToLocalizedObject method.
        /// </summary>
        /// <param name="orderType">OrderType</param>
        /// <returns>String</returns>
        public String ToLocalizedObject(OrderType orderType);
        /// <summary>
        /// ToLocalizedObject method.
        /// </summary>
        /// <param name="timeInForce">TimeInForce</param>
        /// <returns>String</returns>
        public String ToLocalizedObject(TimeInForce timeInForce);
        /// <summary>
        /// ToTradingServicesOrderType method.
        /// </summary>
        /// <param name="orderType">OrderType</param>
        /// <returns>TradingServicesOrderType</returns>
        public TradingServicesOrderType ToTradingServicesOrderType(OrderType orderType);
        /// <summary>
        /// ToTradingServicesTimeInForce method.
        /// </summary>
        /// <param name="tif">TimeInForce</param>
        /// <returns>TradingServicesTimeInForce</returns>
        public TradingServicesTimeInForce ToTradingServicesTimeInForce(TimeInForce tif);
        #endregion
    }
}
