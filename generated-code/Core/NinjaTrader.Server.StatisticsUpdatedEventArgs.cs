[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class StatisticsUpdatedEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Statistics.
        /// </summary>
        [DataMember]
        public Statistics Statistics { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
