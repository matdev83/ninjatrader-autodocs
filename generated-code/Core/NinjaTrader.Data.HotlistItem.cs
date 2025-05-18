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
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Rank.
        /// </summary>
        [DataMember]
        public Int32 Rank { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
