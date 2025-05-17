[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class OrderFlowCumulativeDelta : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DeltaOpen.
        /// </summary>
        [DataMember]
        public Series<Double> DeltaOpen { get; set; }
        /// <summary>
        /// Gets or sets the DeltaHigh.
        /// </summary>
        [DataMember]
        public Series<Double> DeltaHigh { get; set; }
        /// <summary>
        /// Gets or sets the DeltaLow.
        /// </summary>
        [DataMember]
        public Series<Double> DeltaLow { get; set; }
        /// <summary>
        /// Gets or sets the DeltaClose.
        /// </summary>
        [DataMember]
        public Series<Double> DeltaClose { get; set; }
        /// <summary>
        /// Gets or sets the DeltaType.
        /// </summary>
        [DataMember]
        public CumulativeDeltaType DeltaType { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public CumulativeDeltaPeriod Period { get; set; }
        /// <summary>
        /// Gets or sets the SizeFilter.
        /// </summary>
        [DataMember]
        public Int32 SizeFilter { get; set; }
        /// <summary>
        /// Gets or sets the OutlineStroke.
        /// </summary>
        [DataMember]
        public Stroke OutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the WickStroke.
        /// </summary>
        [DataMember]
        public Stroke WickStroke { get; set; }
        /// <summary>
        /// Gets or sets the DownBrush.
        /// </summary>
        [DataMember]
        public Brush DownBrush { get; set; }
        /// <summary>
        /// Gets or sets the DownBrushSeralizer.
        /// </summary>
        [DataMember]
        public String DownBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the UpBrush.
        /// </summary>
        [DataMember]
        public Brush UpBrush { get; set; }
        /// <summary>
        /// Gets or sets the UpBrushSeralizer.
        /// </summary>
        [DataMember]
        public String UpBrushSeralizer { get; set; }
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
