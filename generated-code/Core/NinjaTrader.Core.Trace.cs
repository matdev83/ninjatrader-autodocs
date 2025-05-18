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
        public Boolean Bars { get; set; }
        /// <summary>
        /// Gets or sets the Database.
        /// </summary>
        [DataMember]
        public Boolean Database { get; set; }
        /// <summary>
        /// Gets or sets the Connect.
        /// </summary>
        [DataMember]
        public Boolean Connect { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalData.
        /// </summary>
        [DataMember]
        public Boolean FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the Hotlists.
        /// </summary>
        [DataMember]
        public Boolean Hotlists { get; set; }
        /// <summary>
        /// Gets or sets the MarketData.
        /// </summary>
        [DataMember]
        public Boolean MarketData { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepth.
        /// </summary>
        [DataMember]
        public Boolean MarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the Native.
        /// </summary>
        [DataMember]
        public Boolean Native { get; set; }
        /// <summary>
        /// Gets or sets the News.
        /// </summary>
        [DataMember]
        public Boolean News { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Boolean Order { get; set; }
        /// <summary>
        /// Gets or sets the ResolveInstrument.
        /// </summary>
        [DataMember]
        public Boolean ResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the Server.
        /// </summary>
        [DataMember]
        public Boolean Server { get; set; }
        /// <summary>
        /// Gets or sets the Strict.
        /// </summary>
        [DataMember]
        public Boolean Strict { get; set; }
        /// <summary>
        /// Gets or sets the Test.
        /// </summary>
        [DataMember]
        public Boolean Test { get; set; }
        /// <summary>
        /// Gets or sets the Timer.
        /// </summary>
        [DataMember]
        public Boolean Timer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// TraceAsync method.
        /// </summary>
        /// <param name="connection">IConnection</param>
        /// <param name="func">Func`2</param>
        /// <param name="args">Object</param>
        public Void TraceAsync(IConnection connection, Func<Object, String> func, Object args);
        /// <summary>
        /// GetReproducibleIntId method.
        /// </summary>
        /// <param name="id">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetReproducibleIntId(Int32 id);
        /// <summary>
        /// GetReproducibleLongId method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>Int64</returns>
        public Int64 GetReproducibleLongId(Int64 id);
        /// <summary>
        /// GetReproducibleStringId method.
        /// </summary>
        /// <param name="id">String</param>
        /// <returns>String</returns>
        public String GetReproducibleStringId(String id);
        #endregion
    }
}
