[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class Strategy : StrategyRenderBase
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// CurrentDayOHL method.
        /// </summary>
        /// <returns>CurrentDayOHL</returns>
        public CurrentDayOHL CurrentDayOHL();
        /// <summary>
        /// CurrentDayOHL method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>CurrentDayOHL</returns>
        public CurrentDayOHL CurrentDayOHL(ISeries<Double> input);
        /// <summary>
        /// EMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>EMA</returns>
        public EMA EMA(Int32 period);
        /// <summary>
        /// EMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>EMA</returns>
        public EMA EMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// LinReg method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>LinReg</returns>
        public LinReg LinReg(Int32 period);
        /// <summary>
        /// LinReg method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>LinReg</returns>
        public LinReg LinReg(ISeries<Double> input, Int32 period);
        /// <summary>
        /// SMA method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>SMA</returns>
        public SMA SMA(Int32 period);
        /// <summary>
        /// SMA method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>SMA</returns>
        public SMA SMA(ISeries<Double> input, Int32 period);
        /// <summary>
        /// SUM method.
        /// </summary>
        /// <param name="period">Int32</param>
        /// <returns>SUM</returns>
        public SUM SUM(Int32 period);
        /// <summary>
        /// SUM method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>SUM</returns>
        public SUM SUM(ISeries<Double> input, Int32 period);
        /// <summary>
        /// Swing method.
        /// </summary>
        /// <param name="strength">Int32</param>
        /// <returns>Swing</returns>
        public Swing Swing(Int32 strength);
        /// <summary>
        /// Swing method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="strength">Int32</param>
        /// <returns>Swing</returns>
        public Swing Swing(ISeries<Double> input, Int32 strength);
        /// <summary>
        /// OrderFlowCumulativeDelta method.
        /// </summary>
        /// <param name="deltaType">CumulativeDeltaType</param>
        /// <param name="period">CumulativeDeltaPeriod</param>
        /// <param name="sizeFilter">Int32</param>
        /// <returns>OrderFlowCumulativeDelta</returns>
        public OrderFlowCumulativeDelta OrderFlowCumulativeDelta(CumulativeDeltaType deltaType, CumulativeDeltaPeriod period, Int32 sizeFilter);
        /// <summary>
        /// OrderFlowCumulativeDelta method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="deltaType">CumulativeDeltaType</param>
        /// <param name="period">CumulativeDeltaPeriod</param>
        /// <param name="sizeFilter">Int32</param>
        /// <returns>OrderFlowCumulativeDelta</returns>
        public OrderFlowCumulativeDelta OrderFlowCumulativeDelta(ISeries<Double> input, CumulativeDeltaType deltaType, CumulativeDeltaPeriod period, Int32 sizeFilter);
        /// <summary>
        /// OrderFlowMarketDepthMap method.
        /// </summary>
        /// <param name="baseRange">BaseVolumeRange</param>
        /// <param name="maxRange">Int32</param>
        /// <param name="minRange">Int32</param>
        /// <param name="opacityDistribution">OpacityDistribution</param>
        /// <param name="realTimeDepthWidth">Int32</param>
        /// <param name="extendLastKnown">Boolean</param>
        /// <param name="showBidAskLine">Boolean</param>
        /// <returns>OrderFlowMarketDepthMap</returns>
        public OrderFlowMarketDepthMap OrderFlowMarketDepthMap(BaseVolumeRange baseRange, Int32 maxRange, Int32 minRange, OpacityDistribution opacityDistribution, Int32 realTimeDepthWidth, Boolean extendLastKnown, Boolean showBidAskLine);
        /// <summary>
        /// OrderFlowMarketDepthMap method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="baseRange">BaseVolumeRange</param>
        /// <param name="maxRange">Int32</param>
        /// <param name="minRange">Int32</param>
        /// <param name="opacityDistribution">OpacityDistribution</param>
        /// <param name="realTimeDepthWidth">Int32</param>
        /// <param name="extendLastKnown">Boolean</param>
        /// <param name="showBidAskLine">Boolean</param>
        /// <returns>OrderFlowMarketDepthMap</returns>
        public OrderFlowMarketDepthMap OrderFlowMarketDepthMap(ISeries<Double> input, BaseVolumeRange baseRange, Int32 maxRange, Int32 minRange, OpacityDistribution opacityDistribution, Int32 realTimeDepthWidth, Boolean extendLastKnown, Boolean showBidAskLine);
        /// <summary>
        /// OrderFlowTradeDetector method.
        /// </summary>
        /// <param name="baseLargeVolumeOn">TradeDetectorBaseLargeVolumeOn</param>
        /// <param name="minimumVolumeForMarker">Int32</param>
        /// <param name="maximumMarkerSize">Int32</param>
        /// <param name="baseMarkerSizeOn">TradeDetectorSizeBase</param>
        /// <param name="hoverValues">Boolean</param>
        /// <returns>OrderFlowTradeDetector</returns>
        public OrderFlowTradeDetector OrderFlowTradeDetector(TradeDetectorBaseLargeVolumeOn baseLargeVolumeOn, Int32 minimumVolumeForMarker, Int32 maximumMarkerSize, TradeDetectorSizeBase baseMarkerSizeOn, Boolean hoverValues);
        /// <summary>
        /// OrderFlowTradeDetector method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="baseLargeVolumeOn">TradeDetectorBaseLargeVolumeOn</param>
        /// <param name="minimumVolumeForMarker">Int32</param>
        /// <param name="maximumMarkerSize">Int32</param>
        /// <param name="baseMarkerSizeOn">TradeDetectorSizeBase</param>
        /// <param name="hoverValues">Boolean</param>
        /// <returns>OrderFlowTradeDetector</returns>
        public OrderFlowTradeDetector OrderFlowTradeDetector(ISeries<Double> input, TradeDetectorBaseLargeVolumeOn baseLargeVolumeOn, Int32 minimumVolumeForMarker, Int32 maximumMarkerSize, TradeDetectorSizeBase baseMarkerSizeOn, Boolean hoverValues);
        /// <summary>
        /// OrderFlowVWAP method.
        /// </summary>
        /// <param name="resolution">VWAPResolution</param>
        /// <param name="tradingHoursInstance">TradingHours</param>
        /// <param name="numStandardDeviations">VWAPStandardDeviations</param>
        /// <param name="sD1Multiplier">Double</param>
        /// <param name="sD2Multiplier">Double</param>
        /// <param name="sD3Multiplier">Double</param>
        /// <returns>OrderFlowVWAP</returns>
        public OrderFlowVWAP OrderFlowVWAP(VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, Double sD1Multiplier, Double sD2Multiplier, Double sD3Multiplier);
        /// <summary>
        /// OrderFlowVWAP method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="resolution">VWAPResolution</param>
        /// <param name="tradingHoursInstance">TradingHours</param>
        /// <param name="numStandardDeviations">VWAPStandardDeviations</param>
        /// <param name="sD1Multiplier">Double</param>
        /// <param name="sD2Multiplier">Double</param>
        /// <param name="sD3Multiplier">Double</param>
        /// <returns>OrderFlowVWAP</returns>
        public OrderFlowVWAP OrderFlowVWAP(ISeries<Double> input, VWAPResolution resolution, TradingHours tradingHoursInstance, VWAPStandardDeviations numStandardDeviations, Double sD1Multiplier, Double sD2Multiplier, Double sD3Multiplier);
        /// <summary>
        /// WisemanAlligator method.
        /// </summary>
        /// <param name="jawPeriod">Int32</param>
        /// <param name="teethPeriod">Int32</param>
        /// <param name="lipsPeriod">Int32</param>
        /// <param name="jawOffset">Int32</param>
        /// <param name="teethOffset">Int32</param>
        /// <param name="lipsOffset">Int32</param>
        /// <returns>WisemanAlligator</returns>
        public WisemanAlligator WisemanAlligator(Int32 jawPeriod, Int32 teethPeriod, Int32 lipsPeriod, Int32 jawOffset, Int32 teethOffset, Int32 lipsOffset);
        /// <summary>
        /// WisemanAlligator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="jawPeriod">Int32</param>
        /// <param name="teethPeriod">Int32</param>
        /// <param name="lipsPeriod">Int32</param>
        /// <param name="jawOffset">Int32</param>
        /// <param name="teethOffset">Int32</param>
        /// <param name="lipsOffset">Int32</param>
        /// <returns>WisemanAlligator</returns>
        public WisemanAlligator WisemanAlligator(ISeries<Double> input, Int32 jawPeriod, Int32 teethPeriod, Int32 lipsPeriod, Int32 jawOffset, Int32 teethOffset, Int32 lipsOffset);
        /// <summary>
        /// WisemanAwesomeOscillator method.
        /// </summary>
        /// <returns>WisemanAwesomeOscillator</returns>
        public WisemanAwesomeOscillator WisemanAwesomeOscillator();
        /// <summary>
        /// WisemanAwesomeOscillator method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <returns>WisemanAwesomeOscillator</returns>
        public WisemanAwesomeOscillator WisemanAwesomeOscillator(ISeries<Double> input);
        /// <summary>
        /// WisemanFractal method.
        /// </summary>
        /// <param name="strength">Int32</param>
        /// <param name="triangleOffset">Int32</param>
        /// <returns>WisemanFractal</returns>
        public WisemanFractal WisemanFractal(Int32 strength, Int32 triangleOffset);
        /// <summary>
        /// WisemanFractal method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="strength">Int32</param>
        /// <param name="triangleOffset">Int32</param>
        /// <returns>WisemanFractal</returns>
        public WisemanFractal WisemanFractal(ISeries<Double> input, Int32 strength, Int32 triangleOffset);
        /// <summary>
        /// WoodiesCCI method.
        /// </summary>
        /// <param name="chopIndicatorWidth">Int32</param>
        /// <param name="neutralBars">Int32</param>
        /// <param name="period">Int32</param>
        /// <param name="periodEma">Int32</param>
        /// <param name="periodLinReg">Int32</param>
        /// <param name="periodTurbo">Int32</param>
        /// <param name="sideWinderLimit0">Int32</param>
        /// <param name="sideWinderLimit1">Int32</param>
        /// <param name="sideWinderWidth">Int32</param>
        /// <returns>WoodiesCCI</returns>
        public WoodiesCCI WoodiesCCI(Int32 chopIndicatorWidth, Int32 neutralBars, Int32 period, Int32 periodEma, Int32 periodLinReg, Int32 periodTurbo, Int32 sideWinderLimit0, Int32 sideWinderLimit1, Int32 sideWinderWidth);
        /// <summary>
        /// WoodiesCCI method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="chopIndicatorWidth">Int32</param>
        /// <param name="neutralBars">Int32</param>
        /// <param name="period">Int32</param>
        /// <param name="periodEma">Int32</param>
        /// <param name="periodLinReg">Int32</param>
        /// <param name="periodTurbo">Int32</param>
        /// <param name="sideWinderLimit0">Int32</param>
        /// <param name="sideWinderLimit1">Int32</param>
        /// <param name="sideWinderWidth">Int32</param>
        /// <returns>WoodiesCCI</returns>
        public WoodiesCCI WoodiesCCI(ISeries<Double> input, Int32 chopIndicatorWidth, Int32 neutralBars, Int32 period, Int32 periodEma, Int32 periodLinReg, Int32 periodTurbo, Int32 sideWinderLimit0, Int32 sideWinderLimit1, Int32 sideWinderWidth);
        /// <summary>
        /// WoodiesPivots method.
        /// </summary>
        /// <param name="priorDayHlc">HLCCalculationModeWoodie</param>
        /// <param name="width">Int32</param>
        /// <returns>WoodiesPivots</returns>
        public WoodiesPivots WoodiesPivots(HLCCalculationModeWoodie priorDayHlc, Int32 width);
        /// <summary>
        /// WoodiesPivots method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        /// <param name="priorDayHlc">HLCCalculationModeWoodie</param>
        /// <param name="width">Int32</param>
        /// <returns>WoodiesPivots</returns>
        public WoodiesPivots WoodiesPivots(ISeries<Double> input, HLCCalculationModeWoodie priorDayHlc, Int32 width);
        #endregion
    }
}
