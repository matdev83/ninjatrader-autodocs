[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class WisemanFractal : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Strength.
        /// </summary>
        [DataMember]
        public Int32 Strength { get; set; }
        /// <summary>
        /// Gets or sets the TriangleOffset.
        /// </summary>
        [DataMember]
        public Int32 TriangleOffset { get; set; }
        /// <summary>
        /// Gets or sets the ColorUpBrush.
        /// </summary>
        [DataMember]
        public Brush ColorUpBrush { get; set; }
        /// <summary>
        /// Gets or sets the ColorUpBrushS.
        /// </summary>
        [DataMember]
        public String ColorUpBrushS { get; set; }
        /// <summary>
        /// Gets or sets the ColorDownBrush.
        /// </summary>
        [DataMember]
        public Brush ColorDownBrush { get; set; }
        /// <summary>
        /// Gets or sets the ColorDownBrushS.
        /// </summary>
        [DataMember]
        public String ColorDownBrushS { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        /// <summary>
        /// OnRenderTargetChanged method.
        /// </summary>
        public Void OnRenderTargetChanged();
        #endregion
    }
}
