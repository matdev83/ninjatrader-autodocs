[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ChartStyles
{
    public partial class PointAndFigureStyle : ChartStyle
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetBarPaintWidth method.
        /// </summary>
        /// <param name="barWidth">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetBarPaintWidth(Int32 barWidth);
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="chartBars">ChartBars</param>
        public Void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars);
        #endregion
    }
}
