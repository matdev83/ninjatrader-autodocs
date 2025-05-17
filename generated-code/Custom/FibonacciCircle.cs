[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class FibonacciCircle : FibonacciRetracements
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the IsTextDisplayed.
        /// </summary>
        [DataMember]
        public Boolean IsTextDisplayed { get; set; }
        /// <summary>
        /// Gets or sets the IsTimePriceDividedSeparately.
        /// </summary>
        [DataMember]
        public Boolean IsTimePriceDividedSeparately { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        /// <summary>
        /// GetValidAlertConditions method.
        /// </summary>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<Condition> GetValidAlertConditions();
        /// <summary>
        /// IsAlertConditionTrue method.
        /// </summary>
        /// <param name="conditionItem">AlertConditionItem</param>
        /// <param name="condition">Condition</param>
        /// <param name="values">ChartAlertValue[]</param>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <returns>Boolean</returns>
        public Boolean IsAlertConditionTrue(AlertConditionItem conditionItem, Condition condition, ChartAlertValue[] values, ChartControl chartControl, ChartScale chartScale);
        /// <summary>
        /// IsVisibleOnChart method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="firstTimeOnChart">DateTime</param>
        /// <param name="lastTimeOnChart">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsVisibleOnChart(ChartControl chartControl, ChartScale chartScale, DateTime firstTimeOnChart, DateTime lastTimeOnChart);
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        public Void OnRender(ChartControl chartControl, ChartScale chartScale);
        #endregion
    }
}
