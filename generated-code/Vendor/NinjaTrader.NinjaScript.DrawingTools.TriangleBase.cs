[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class TriangleBase : ChartMarker
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsUpTriangle.
        /// </summary>
        [DataMember]
        public Boolean IsUpTriangle { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        public Void OnRender(ChartControl chartControl, ChartScale chartScale);
        #endregion
    }
}
