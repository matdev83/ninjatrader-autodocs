[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class HotlistItem
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Rank.
        /// </summary>
        [DataMember]
        public int Rank { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
