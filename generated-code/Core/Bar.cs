[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class Bar
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public Double Open { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public Double High { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public Double Low { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public Double Close { get; set; }
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
        #endregion
    }
}
