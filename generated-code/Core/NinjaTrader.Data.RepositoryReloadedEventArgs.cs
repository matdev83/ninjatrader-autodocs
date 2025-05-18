[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class RepositoryReloadedEventArgs : EventArgs
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
        public MasterInstrument MasterInstrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
