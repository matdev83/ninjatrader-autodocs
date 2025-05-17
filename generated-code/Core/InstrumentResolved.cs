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
        public String Error { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int32 Id { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Symbol.
        /// </summary>
        [DataMember]
        public String Symbol { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public Object State { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
