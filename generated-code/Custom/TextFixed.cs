[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class TextFixed : Text
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TextPosition.
        /// </summary>
        [DataMember]
        public TextPosition TextPosition { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        /// <summary>
        /// IsVisibleOnChart method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="firstTimeOnChart">DateTime</param>
        /// <param name="lastTimeOnChart">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsVisibleOnChart(ChartControl chartControl, ChartScale chartScale, DateTime firstTimeOnChart, DateTime lastTimeOnChart);
        #endregion
    }
}
