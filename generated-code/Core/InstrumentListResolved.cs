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
        public String Error { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int32 Id { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentList.
        /// </summary>
        [DataMember]
        public InstrumentList InstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
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
