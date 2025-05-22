[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class Api : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Challenge.
        /// </summary>
        [DataMember]
        public string Challenge { get; set; }
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the CurrentCulture.
        /// </summary>
        [DataMember]
        public System.Globalization.CultureInfo CurrentCulture { get; set; }
        /// <summary>
        /// Gets or sets the CurrentUICulture.
        /// </summary>
        [DataMember]
        public System.Globalization.CultureInfo CurrentUICulture { get; set; }
        /// <summary>
        /// Gets or sets the ResolveInstrumentCallbacks.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.Instrument, System.Collections.Generic.List<System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string>>> ResolveInstrumentCallbacks { get; set; }
        /// <summary>
        /// Gets or sets the Secret.
        /// </summary>
        [DataMember]
        public string Secret { get; set; }
        /// <summary>
        /// Gets or sets the ServerAccounts.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.Account> ServerAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.Instrument> ServerInstruments { get; set; }
        /// <summary>
        /// Gets or sets the ServerOrders.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.Order> ServerOrders { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedAccounts.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Cbi.Account> SubscribedAccounts { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.User User { get; set; }
        /// <summary>
        /// Gets or sets the IsDisposed.
        /// </summary>
        [DataMember]
        public bool IsDisposed { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NinjaTraderProxy NT { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ForcedLogout method.
        /// </summary>
        public void ForcedLogout()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetResource method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string</returns>
        public string GetResource(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnAccountItemUpdate method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.AccountItemEventArgs</param>
        public void OnAccountItemUpdate(object sender, NinjaTrader.Cbi.AccountItemEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnExecutionUpdate method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.ExecutionEventArgs</param>
        public void OnExecutionUpdate(object sender, NinjaTrader.Cbi.ExecutionEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnLogEvent method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.LogEventArgs</param>
        public void OnLogEvent(object sender, NinjaTrader.Cbi.LogEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnOrderUpdate method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.OrderEventArgs</param>
        public void OnOrderUpdate(object sender, NinjaTrader.Cbi.OrderEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnPositionUpdate method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.PositionEventArgs</param>
        public void OnPositionUpdate(object sender, NinjaTrader.Cbi.PositionEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnSoundEvent method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Core.SoundEventArgs</param>
        public void OnSoundEvent(object sender, NinjaTrader.Core.SoundEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SynchronizeInstrument method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void SynchronizeInstrument(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
