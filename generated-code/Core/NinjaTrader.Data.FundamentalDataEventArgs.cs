[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class FundamentalDataEventArgs : System.EventArgs, NinjaTrader.Data.IInstrumentProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DateTimeValue.
        /// </summary>
        [DataMember]
        public System.DateTime DateTimeValue { get; set; }
        /// <summary>
        /// Gets or sets the DoubleValue.
        /// </summary>
        [DataMember]
        public double DoubleValue { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsReset.
        /// </summary>
        [DataMember]
        public bool IsReset { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType.
        /// </summary>
        [DataMember]
        public FundamentalDataType FundamentalDataType { get; set; }
        /// <summary>
        /// Gets or sets the LongValue.
        /// </summary>
        [DataMember]
        public long LongValue { get; set; }
        /// <summary>
        /// Gets or sets the StringValue.
        /// </summary>
        [DataMember]
        public string StringValue { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
