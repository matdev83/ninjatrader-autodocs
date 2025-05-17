[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ExecutionPositions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DoRaiseAddTrade.
        /// </summary>
        [DataMember]
        public Boolean DoRaiseAddTrade { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, Position> Positions { get; set; }
        /// <summary>
        /// Gets or sets the UseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public Boolean UseFifo4AveragePrice { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="execution">Execution</param>
        public Void Add(Execution execution);
        #endregion
    }
}
