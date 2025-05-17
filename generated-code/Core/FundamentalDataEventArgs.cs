[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class FundamentalDataEventArgs : EventArgs, IInstrumentProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DateTimeValue.
        /// </summary>
        [DataMember]
        public DateTime DateTimeValue { get; set; }
        /// <summary>
        /// Gets or sets the DoubleValue.
        /// </summary>
        [DataMember]
        public Double DoubleValue { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsReset.
        /// </summary>
        [DataMember]
        public Boolean IsReset { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType.
        /// </summary>
        [DataMember]
        public FundamentalDataType FundamentalDataType { get; set; }
        /// <summary>
        /// Gets or sets the LongValue.
        /// </summary>
        [DataMember]
        public Int64 LongValue { get; set; }
        /// <summary>
        /// Gets or sets the StringValue.
        /// </summary>
        [DataMember]
        public String StringValue { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
