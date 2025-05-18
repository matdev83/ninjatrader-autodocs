[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class OrderFlowTradeDetector : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BaseLargeVolumeOn.
        /// </summary>
        [DataMember]
        public TradeDetectorBaseLargeVolumeOn BaseLargeVolumeOn { get; set; }
        /// <summary>
        /// Gets or sets the MinimumVolumeForMarker.
        /// </summary>
        [DataMember]
        public Int32 MinimumVolumeForMarker { get; set; }
        /// <summary>
        /// Gets or sets the MaximumMarkerSize.
        /// </summary>
        [DataMember]
        public Int32 MaximumMarkerSize { get; set; }
        /// <summary>
        /// Gets or sets the BaseMarkerSizeOn.
        /// </summary>
        [DataMember]
        public TradeDetectorSizeBase BaseMarkerSizeOn { get; set; }
        /// <summary>
        /// Gets or sets the HoverValues.
        /// </summary>
        [DataMember]
        public Boolean HoverValues { get; set; }
        /// <summary>
        /// Gets or sets the AskBrush.
        /// </summary>
        [DataMember]
        public Brush AskBrush { get; set; }
        /// <summary>
        /// Gets or sets the AskBrushSeralizer.
        /// </summary>
        [DataMember]
        public String AskBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the BidBrush.
        /// </summary>
        [DataMember]
        public Brush BidBrush { get; set; }
        /// <summary>
        /// Gets or sets the BidBrushSeralizer.
        /// </summary>
        [DataMember]
        public String BidBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the OutlineBrush.
        /// </summary>
        [DataMember]
        public Brush OutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the OutlineBrushSeralizer.
        /// </summary>
        [DataMember]
        public String OutlineBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the FillOpacity.
        /// </summary>
        [DataMember]
        public Int32 FillOpacity { get; set; }
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
