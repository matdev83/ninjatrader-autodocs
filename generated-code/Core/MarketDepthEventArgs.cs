[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketDepthEventArgs : EventArgs, IInstrumentProvider
    {
        #region Properties
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
        /// Gets or sets the MarketDataType.
        /// </summary>
        [DataMember]
        public MarketDataType MarketDataType { get; set; }
        /// <summary>
        /// Gets or sets the MarketMaker.
        /// </summary>
        [DataMember]
        public String MarketMaker { get; set; }
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public Operation Operation { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public Int32 Position { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Double Price { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public Int64 Volume { get; set; }
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
