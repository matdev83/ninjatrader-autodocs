[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ChartStyles
{
    public partial class VolumetricStyle : ChartStyle, ISubModeProvider, IVolumetric, IBarStatistics
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the SubModes.
        /// </summary>
        [DataMember]
        public IEnumerable<Object> SubModes { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType.
        /// </summary>
        [DataMember]
        public VolumetricChartStyleType VolumetricChartStyleType { get; set; }
        /// <summary>
        /// Gets or sets the CenterOpenClose.
        /// </summary>
        [DataMember]
        public Boolean CenterOpenClose { get; set; }
        /// <summary>
        /// Gets or sets the ShowAsProfile.
        /// </summary>
        [DataMember]
        public Boolean ShowAsProfile { get; set; }
        /// <summary>
        /// Gets or sets the ShowVolumeProfile.
        /// </summary>
        [DataMember]
        public Boolean ShowVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the GradientsDepthSlots.
        /// </summary>
        [DataMember]
        public Int32 GradientsDepthSlots { get; set; }
        /// <summary>
        /// Gets or sets the SizeDisplayFilter.
        /// </summary>
        [DataMember]
        public Int32 SizeDisplayFilter { get; set; }
        /// <summary>
        /// Gets or sets the ShowImbalance.
        /// </summary>
        [DataMember]
        public Boolean ShowImbalance { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceRatio.
        /// </summary>
        [DataMember]
        public Double ImbalanceRatio { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceMode.
        /// </summary>
        [DataMember]
        public VolumetricImbalanceMode ImbalanceMode { get; set; }
        /// <summary>
        /// Gets or sets the MinDelta.
        /// </summary>
        [DataMember]
        public Int64 MinDelta { get; set; }
        /// <summary>
        /// Gets or sets the ColorDominantSide.
        /// </summary>
        [DataMember]
        public Boolean ColorDominantSide { get; set; }
        /// <summary>
        /// Gets or sets the DojiBrush.
        /// </summary>
        [DataMember]
        public Brush DojiBrush { get; set; }
        /// <summary>
        /// Gets or sets the DojiBrushSerialize.
        /// </summary>
        [DataMember]
        public String DojiBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DojiBrushDX.
        /// </summary>
        [DataMember]
        public Brush DojiBrushDX { get; set; }
        /// <summary>
        /// Gets or sets the BoxGrid.
        /// </summary>
        [DataMember]
        public Stroke BoxGrid { get; set; }
        /// <summary>
        /// Gets or sets the BoxOutline.
        /// </summary>
        [DataMember]
        public Stroke BoxOutline { get; set; }
        /// <summary>
        /// Gets or sets the PositiveStrengthBrush.
        /// </summary>
        [DataMember]
        public Brush PositiveStrengthBrush { get; set; }
        /// <summary>
        /// Gets or sets the PositiveStrengthBrushBrushSerialize.
        /// </summary>
        [DataMember]
        public String PositiveStrengthBrushBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the NegativeStrengthBrush.
        /// </summary>
        [DataMember]
        public Brush NegativeStrengthBrush { get; set; }
        /// <summary>
        /// Gets or sets the NegativeStrengthBrushBrushSerialize.
        /// </summary>
        [DataMember]
        public String NegativeStrengthBrushBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceBuyBrush.
        /// </summary>
        [DataMember]
        public Brush ImbalanceBuyBrush { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceBuyBrushSerialize.
        /// </summary>
        [DataMember]
        public String ImbalanceBuyBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceBuyBrushDX.
        /// </summary>
        [DataMember]
        public Brush ImbalanceBuyBrushDX { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceSellBrush.
        /// </summary>
        [DataMember]
        public Brush ImbalanceSellBrush { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceSellBrushSerialize.
        /// </summary>
        [DataMember]
        public String ImbalanceSellBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ImbalanceSellBrushDX.
        /// </summary>
        [DataMember]
        public Brush ImbalanceSellBrushDX { get; set; }
        /// <summary>
        /// Gets or sets the ShowMaximum.
        /// </summary>
        [DataMember]
        public Boolean ShowMaximum { get; set; }
        /// <summary>
        /// Gets or sets the MaxBrush.
        /// </summary>
        [DataMember]
        public Brush MaxBrush { get; set; }
        /// <summary>
        /// Gets or sets the MaxBrushSerialize.
        /// </summary>
        [DataMember]
        public String MaxBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the MaxBrushDX.
        /// </summary>
        [DataMember]
        public Brush MaxBrushDX { get; set; }
        /// <summary>
        /// Gets or sets the VolBrush.
        /// </summary>
        [DataMember]
        public Brush VolBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolBrushSerialize.
        /// </summary>
        [DataMember]
        public String VolBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the VolBrushDX.
        /// </summary>
        [DataMember]
        public Brush VolBrushDX { get; set; }
        /// <summary>
        /// Gets or sets the HideText.
        /// </summary>
        [DataMember]
        public Boolean HideText { get; set; }
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
        /// Gets or sets the TextBrushDX.
        /// </summary>
        [DataMember]
        public Brush TextBrushDX { get; set; }
        /// <summary>
        /// Gets or sets the ShowBarStatistics.
        /// </summary>
        [DataMember]
        public Boolean ShowBarStatistics { get; set; }
        /// <summary>
        /// Gets or sets the ShowTrades.
        /// </summary>
        [DataMember]
        public Boolean ShowTrades { get; set; }
        /// <summary>
        /// Gets or sets the ShowVolume.
        /// </summary>
        [DataMember]
        public Boolean ShowVolume { get; set; }
        /// <summary>
        /// Gets or sets the ShowBuyVol.
        /// </summary>
        [DataMember]
        public Boolean ShowBuyVol { get; set; }
        /// <summary>
        /// Gets or sets the ShowSellVol.
        /// </summary>
        [DataMember]
        public Boolean ShowSellVol { get; set; }
        /// <summary>
        /// Gets or sets the ShowDeltaBar.
        /// </summary>
        [DataMember]
        public Boolean ShowDeltaBar { get; set; }
        /// <summary>
        /// Gets or sets the ShowDeltaPercent.
        /// </summary>
        [DataMember]
        public Boolean ShowDeltaPercent { get; set; }
        /// <summary>
        /// Gets or sets the ShowDeltaCumulative.
        /// </summary>
        [DataMember]
        public Boolean ShowDeltaCumulative { get; set; }
        /// <summary>
        /// Gets or sets the ShowMinDelta.
        /// </summary>
        [DataMember]
        public Boolean ShowMinDelta { get; set; }
        /// <summary>
        /// Gets or sets the ShowMaxDelta.
        /// </summary>
        [DataMember]
        public Boolean ShowMaxDelta { get; set; }
        /// <summary>
        /// Gets or sets the ShowDeltaDelta.
        /// </summary>
        [DataMember]
        public Boolean ShowDeltaDelta { get; set; }
        /// <summary>
        /// Gets or sets the ShowDeltaSh.
        /// </summary>
        [DataMember]
        public Boolean ShowDeltaSh { get; set; }
        /// <summary>
        /// Gets or sets the ShowDeltaSl.
        /// </summary>
        [DataMember]
        public Boolean ShowDeltaSl { get; set; }
        /// <summary>
        /// Gets or sets the BaseBrush.
        /// </summary>
        [DataMember]
        public Brush BaseBrush { get; set; }
        /// <summary>
        /// Gets or sets the StatGrid.
        /// </summary>
        [DataMember]
        public Stroke StatGrid { get; set; }
        /// <summary>
        /// Gets or sets the BaseBrushSerialize.
        /// </summary>
        [DataMember]
        public String BaseBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the CountTrueProperties.
        /// </summary>
        [DataMember]
        public Int32 CountTrueProperties { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsNames.
        /// </summary>
        [DataMember]
        public String[] StatisticsNames { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CheckMenuItems method.
        /// </summary>
        public Void CheckMenuItems();
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// GetBarPaintWidth method.
        /// </summary>
        /// <param name="barWidth">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetBarPaintWidth(Int32 barWidth);
        /// <summary>
        /// GetContextMenu method.
        /// </summary>
        /// <returns>ContextMenu</returns>
        public ContextMenu GetContextMenu();
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="chartBars">ChartBars</param>
        public Void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars);
        /// <summary>
        /// OnRenderTargetChanged method.
        /// </summary>
        public Void OnRenderTargetChanged();
        /// <summary>
        /// SetSubmode method.
        /// </summary>
        /// <param name="mode">Object</param>
        public Void SetSubmode(Object mode);
        /// <summary>
        /// BarStatisticsHeight method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <returns>Int32</returns>
        public Int32 BarStatisticsHeight(ChartControl chartControl);
        #endregion
    }
}
