[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class RepositoryReloadedEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BuiltFromPeriodType.
        /// </summary>
        [DataMember]
        public BarsPeriodType BuiltFromPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.MasterInstrument MasterInstrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
