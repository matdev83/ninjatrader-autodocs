[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ChartStyles
{
    public partial class OhlcStyle : ChartStyle, ISubModeProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the Mode.
        /// </summary>
        [DataMember]
        public OhlcMode Mode { get; set; }
        /// <summary>
        /// Gets or sets the SubModes.
        /// </summary>
        [DataMember]
        public IEnumerable<Object> SubModes { get; set; }
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
        /// <summary>
        /// SetSubmode method.
        /// </summary>
        /// <param name="mode">Object</param>
        public Void SetSubmode(Object mode);
        #endregion
    }
}
