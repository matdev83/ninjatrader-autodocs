[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class McClellanOscillator : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the FastPeriod.
        /// </summary>
        [DataMember]
        public Int32 FastPeriod { get; set; }
        /// <summary>
        /// Gets or sets the SlowPeriod.
        /// </summary>
        [DataMember]
        public Int32 SlowPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NegativeColor.
        /// </summary>
        [DataMember]
        public Brush NegativeColor { get; set; }
        /// <summary>
        /// Gets or sets the NegativeColorSerialize.
        /// </summary>
        [DataMember]
        public String NegativeColorSerialize { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
