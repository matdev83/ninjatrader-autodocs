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
        public double Open { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public double High { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public double Low { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public double Close { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public long Volume { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
