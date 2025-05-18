[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class PriorDayOHLC : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PriorOpen.
        /// </summary>
        [DataMember]
        public Series<Double> PriorOpen { get; set; }
        /// <summary>
        /// Gets or sets the PriorHigh.
        /// </summary>
        [DataMember]
        public Series<Double> PriorHigh { get; set; }
        /// <summary>
        /// Gets or sets the PriorLow.
        /// </summary>
        [DataMember]
        public Series<Double> PriorLow { get; set; }
        /// <summary>
        /// Gets or sets the PriorClose.
        /// </summary>
        [DataMember]
        public Series<Double> PriorClose { get; set; }
        /// <summary>
        /// Gets or sets the ShowClose.
        /// </summary>
        [DataMember]
        public Boolean ShowClose { get; set; }
        /// <summary>
        /// Gets or sets the ShowHigh.
        /// </summary>
        [DataMember]
        public Boolean ShowHigh { get; set; }
        /// <summary>
        /// Gets or sets the ShowLow.
        /// </summary>
        [DataMember]
        public Boolean ShowLow { get; set; }
        /// <summary>
        /// Gets or sets the ShowOpen.
        /// </summary>
        [DataMember]
        public Boolean ShowOpen { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// FormatPriceMarker method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>String</returns>
        public String FormatPriceMarker(Double price);
        #endregion
    }
}
