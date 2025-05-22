[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TimerTickEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the Now.
        /// </summary>
        [DataMember]
        public System.DateTime Now { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// New method.
        /// </summary>
        /// <param name="connection">NinjaTrader.Cbi.Connection</param>
        /// <param name="time">System.DateTime</param>
        /// <returns>NinjaTrader.Cbi.TimerTickEventArgs</returns>
        public NinjaTrader.Cbi.TimerTickEventArgs New(NinjaTrader.Cbi.Connection connection, System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
