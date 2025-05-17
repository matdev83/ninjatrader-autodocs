[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class IndicatorMarketAnalyzerColumn : MarketAnalyzerColumnBase
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
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the Indicator.
        /// </summary>
        [DataMember]
        public String Indicator { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorInstance.
        /// </summary>
        [DataMember]
        public IndicatorBase IndicatorInstance { get; set; }
        /// <summary>
        /// Gets or sets the IsCustomName.
        /// </summary>
        [DataMember]
        public Boolean IsCustomName { get; set; }
        /// <summary>
        /// Gets or sets the MaximumBarsLookBack.
        /// </summary>
        [DataMember]
        public MaximumBarsLookBack MaximumBarsLookBack { get; set; }
        /// <summary>
        /// Gets or sets the Plot.
        /// </summary>
        [DataMember]
        public String Plot { get; set; }
        /// <summary>
        /// Gets or sets the PlotIndex.
        /// </summary>
        [DataMember]
        public Int32 PlotIndex { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the UseDefaultNameLogic.
        /// </summary>
        [DataMember]
        public Boolean UseDefaultNameLogic { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CheckPlotValueNow method.
        /// </summary>
        public Void CheckPlotValueNow();
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String Format(Double value);
        #endregion
    }
}
