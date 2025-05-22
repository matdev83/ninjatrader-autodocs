[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class StatisticsUpdatedEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Statistics.
        /// </summary>
        [DataMember]
        public NinjaTrader.Server.Statistics Statistics { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
