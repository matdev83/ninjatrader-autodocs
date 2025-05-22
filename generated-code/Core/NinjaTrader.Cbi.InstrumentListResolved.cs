[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class InstrumentListResolved
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
        /// Gets or sets the InstrumentList.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.InstrumentList InstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
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
