[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class InstrumentResolved
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        [DataMember]
        public string Error { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Symbol.
        /// </summary>
        [DataMember]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public object State { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
