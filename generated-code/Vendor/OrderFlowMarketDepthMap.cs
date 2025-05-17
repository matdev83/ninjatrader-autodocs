[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class OrderFlowMarketDepthMap : Indicator, IVolumetric, IPersistable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BaseRange.
        /// </summary>
        [DataMember]
        public BaseVolumeRange BaseRange { get; set; }
        /// <summary>
        /// Gets or sets the MaxRange.
        /// </summary>
        [DataMember]
        public Int32 MaxRange { get; set; }
        /// <summary>
        /// Gets or sets the MinRange.
        /// </summary>
        [DataMember]
        public Int32 MinRange { get; set; }
        /// <summary>
        /// Gets or sets the LevelsToTrack.
        /// </summary>
        [DataMember]
        public Int32 LevelsToTrack { get; set; }
        /// <summary>
        /// Gets or sets the OpacityDistribution.
        /// </summary>
        [DataMember]
        public OpacityDistribution OpacityDistribution { get; set; }
        /// <summary>
        /// Gets or sets the DisplayMode.
        /// </summary>
        [DataMember]
        public DepthMapDisplayMode DisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the DepthMargin.
        /// </summary>
        [DataMember]
        public Int32 DepthMargin { get; set; }
        /// <summary>
        /// Gets or sets the ShowCumulative.
        /// </summary>
        [DataMember]
        public Boolean ShowCumulative { get; set; }
        /// <summary>
        /// Gets or sets the ExtendLastKnown.
        /// </summary>
        [DataMember]
        public Boolean ExtendLastKnown { get; set; }
        /// <summary>
        /// Gets or sets the BidDepthBrush.
        /// </summary>
        [DataMember]
        public Brush BidDepthBrush { get; set; }
        /// <summary>
        /// Gets or sets the BidDepthBrushSeralizer.
        /// </summary>
        [DataMember]
        public String BidDepthBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the AskDepthBrush.
        /// </summary>
        [DataMember]
        public Brush AskDepthBrush { get; set; }
        /// <summary>
        /// Gets or sets the AskDepthBrushSeralizer.
        /// </summary>
        [DataMember]
        public String AskDepthBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the TextBrush.
        /// </summary>
        [DataMember]
        public Brush TextBrush { get; set; }
        /// <summary>
        /// Gets or sets the TextBrushSerialize.
        /// </summary>
        [DataMember]
        public String TextBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ShowBidAskLine.
        /// </summary>
        [DataMember]
        public Boolean ShowBidAskLine { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyDataFrom method.
        /// </summary>
        /// <param name="indicatorBase">IndicatorBase</param>
        public Void CopyDataFrom(IndicatorBase indicatorBase);
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
