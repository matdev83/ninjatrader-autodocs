[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TimerTickEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the Now.
        /// </summary>
        [DataMember]
        public DateTime Now { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// New method.
        /// </summary>
        /// <param name="connection">Connection</param>
        /// <param name="time">DateTime</param>
        /// <returns>TimerTickEventArgs</returns>
        public TimerTickEventArgs New(Connection connection, DateTime time);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
