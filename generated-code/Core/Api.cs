[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class Api : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Challenge.
        /// </summary>
        [DataMember]
        public String Challenge { get; set; }
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the CurrentCulture.
        /// </summary>
        [DataMember]
        public CultureInfo CurrentCulture { get; set; }
        /// <summary>
        /// Gets or sets the CurrentUICulture.
        /// </summary>
        [DataMember]
        public CultureInfo CurrentUICulture { get; set; }
        /// <summary>
        /// Gets or sets the ResolveInstrumentCallbacks.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, List<Action<Instrument, ErrorCode, String>>> ResolveInstrumentCallbacks { get; set; }
        /// <summary>
        /// Gets or sets the Secret.
        /// </summary>
        [DataMember]
        public String Secret { get; set; }
        /// <summary>
        /// Gets or sets the ServerAccounts.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, Account> ServerAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerInstruments.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, Instrument> ServerInstruments { get; set; }
        /// <summary>
        /// Gets or sets the ServerOrders.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, Order> ServerOrders { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedAccounts.
        /// </summary>
        [DataMember]
        public List<Account> SubscribedAccounts { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public User User { get; set; }
        /// <summary>
        /// Gets or sets the IsDisposed.
        /// </summary>
        [DataMember]
        public Boolean IsDisposed { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTraderProxy NT { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// ForcedLogout method.
        /// </summary>
        public Void ForcedLogout();
        /// <summary>
        /// GetResource method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>String</returns>
        public String GetResource(String key);
        /// <summary>
        /// OnAccountItemUpdate method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">AccountItemEventArgs</param>
        public Void OnAccountItemUpdate(Object sender, AccountItemEventArgs e);
        /// <summary>
        /// OnExecutionUpdate method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">ExecutionEventArgs</param>
        public Void OnExecutionUpdate(Object sender, ExecutionEventArgs e);
        /// <summary>
        /// OnLogEvent method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">LogEventArgs</param>
        public Void OnLogEvent(Object sender, LogEventArgs e);
        /// <summary>
        /// OnOrderUpdate method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">OrderEventArgs</param>
        public Void OnOrderUpdate(Object sender, OrderEventArgs e);
        /// <summary>
        /// OnPositionUpdate method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">PositionEventArgs</param>
        public Void OnPositionUpdate(Object sender, PositionEventArgs e);
        /// <summary>
        /// OnSoundEvent method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">SoundEventArgs</param>
        public Void OnSoundEvent(Object sender, SoundEventArgs e);
        /// <summary>
        /// SynchronizeInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void SynchronizeInstrument(Instrument instrument);
        #endregion
    }
}
