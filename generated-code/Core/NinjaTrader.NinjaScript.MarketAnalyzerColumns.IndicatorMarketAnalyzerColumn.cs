[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class IndicatorMarketAnalyzerColumn : NinjaTrader.NinjaScript.MarketAnalyzerColumnBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Calculate.
        /// </summary>
        [DataMember]
        public Calculate Calculate { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the Indicator.
        /// </summary>
        [DataMember]
        public string Indicator { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorInstance.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.IndicatorBase IndicatorInstance { get; set; }
        /// <summary>
        /// Gets or sets the IsCustomName.
        /// </summary>
        [DataMember]
        public bool IsCustomName { get; set; }
        /// <summary>
        /// Gets or sets the MaximumBarsLookBack.
        /// </summary>
        [DataMember]
        public MaximumBarsLookBack MaximumBarsLookBack { get; set; }
        /// <summary>
        /// Gets or sets the Plot.
        /// </summary>
        [DataMember]
        public string Plot { get; set; }
        /// <summary>
        /// Gets or sets the PlotIndex.
        /// </summary>
        [DataMember]
        public int PlotIndex { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the UseDefaultNameLogic.
        /// </summary>
        [DataMember]
        public bool UseDefaultNameLogic { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CheckPlotValueNow method.
        /// </summary>
        public void CheckPlotValueNow()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">double</param>
        /// <returns>string</returns>
        public string Format(double value)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
