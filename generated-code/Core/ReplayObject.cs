[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class ReplayObject
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public Double Ask { get; set; }
        /// <summary>
        /// Gets or sets the BarIndex.
        /// </summary>
        [DataMember]
        public Int32 BarIndex { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public Double Bid { get; set; }
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
