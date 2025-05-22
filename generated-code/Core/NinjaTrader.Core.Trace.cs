[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Trace
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Bars.
        /// </summary>
        [DataMember]
        public bool Bars { get; set; }
        /// <summary>
        /// Gets or sets the Database.
        /// </summary>
        [DataMember]
        public bool Database { get; set; }
        /// <summary>
        /// Gets or sets the Connect.
        /// </summary>
        [DataMember]
        public bool Connect { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalData.
        /// </summary>
        [DataMember]
        public bool FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the Hotlists.
        /// </summary>
        [DataMember]
        public bool Hotlists { get; set; }
        /// <summary>
        /// Gets or sets the MarketData.
        /// </summary>
        [DataMember]
        public bool MarketData { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepth.
        /// </summary>
        [DataMember]
        public bool MarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the Native.
        /// </summary>
        [DataMember]
        public bool Native { get; set; }
        /// <summary>
        /// Gets or sets the News.
        /// </summary>
        [DataMember]
        public bool News { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public bool Order { get; set; }
        /// <summary>
        /// Gets or sets the ResolveInstrument.
        /// </summary>
        [DataMember]
        public bool ResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the Server.
        /// </summary>
        [DataMember]
        public bool Server { get; set; }
        /// <summary>
        /// Gets or sets the Strict.
        /// </summary>
        [DataMember]
        public bool Strict { get; set; }
        /// <summary>
        /// Gets or sets the Test.
        /// </summary>
        [DataMember]
        public bool Test { get; set; }
        /// <summary>
        /// Gets or sets the Timer.
        /// </summary>
        [DataMember]
        public bool Timer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// TraceAsync method.
        /// </summary>
        /// <param name="connection">NinjaTrader.Cbi.IConnection</param>
        /// <param name="func">System.Func<object, string></param>
        /// <param name="args">object</param>
        public void TraceAsync(NinjaTrader.Cbi.IConnection connection, System.Func<object, string> func, object args)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetReproducibleIntId method.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int GetReproducibleIntId(int id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetReproducibleLongId method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>long</returns>
        public long GetReproducibleLongId(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetReproducibleStringId method.
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>string</returns>
        public string GetReproducibleStringId(string id)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
