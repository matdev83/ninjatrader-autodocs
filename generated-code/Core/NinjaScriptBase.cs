[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class NinjaScriptBase : NinjaScript, ISeries<Double>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AreLinesConfigurable.
        /// </summary>
        [DataMember]
        public Boolean AreLinesConfigurable { get; set; }
        /// <summary>
        /// Gets or sets the ArePlotsConfigurable.
        /// </summary>
        [DataMember]
        public Boolean ArePlotsConfigurable { get; set; }
        /// <summary>
        /// Gets or sets the BackBrush.
        /// </summary>
        [DataMember]
        public Brush BackBrush { get; set; }
        /// <summary>
        /// Gets or sets the BackBrushes.
        /// </summary>
        [DataMember]
        public BrushSeries BackBrushes { get; set; }
        /// <summary>
        /// Gets or sets the BackBrushAll.
        /// </summary>
        [DataMember]
        public Brush BackBrushAll { get; set; }
        /// <summary>
        /// Gets or sets the BackBrushesAll.
        /// </summary>
        [DataMember]
        public BrushSeries BackBrushesAll { get; set; }
        /// <summary>
        /// Gets or sets the BarBrush.
        /// </summary>
        [DataMember]
        public Brush BarBrush { get; set; }
        /// <summary>
        /// Gets or sets the BarBrushes.
        /// </summary>
        [DataMember]
        public BrushSeries BarBrushes { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodSerializable.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriodSerializable { get; set; }
        /// <summary>
        /// Gets or sets the BarsToDispose.
        /// </summary>
        [DataMember]
        public List<Bars> BarsToDispose { get; set; }
        /// <summary>
        /// Gets or sets the BarsToLoad.
        /// </summary>
        [DataMember]
        public Int32 BarsToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CandleOutlineBrush.
        /// </summary>
        [DataMember]
        public Brush CandleOutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the CandleOutlineBrushes.
        /// </summary>
        [DataMember]
        public BrushSeries CandleOutlineBrushes { get; set; }
        /// <summary>
        /// Gets or sets the Dispatcher.
        /// </summary>
        [DataMember]
        public Dispatcher Dispatcher { get; set; }
        /// <summary>
        /// Gets or sets the DisplayInDataBox.
        /// </summary>
        [DataMember]
        public Boolean DisplayInDataBox { get; set; }
        /// <summary>
        /// Gets or sets the ForcePlotsMaximumBarsLookBackInfinite.
        /// </summary>
        [DataMember]
        [Obsolete("Don't use, since it's not wired up anyway. It's only there to not break existing code.")]
        public Boolean ForcePlotsMaximumBarsLookBackInfinite { get; set; }
        /// <summary>
        /// Gets or sets the From.
        /// </summary>
        [DataMember]
        public DateTime From { get; set; }
        /// <summary>
        /// Gets or sets the InputUI.
        /// </summary>
        [DataMember]
        public ISeries<Double> InputUI { get; set; }
        /// <summary>
        /// Gets or sets the IsInputSeries.
        /// </summary>
        [DataMember]
        public Boolean IsInputSeries { get; set; }
        /// <summary>
        /// Gets or sets the IsOnlySeriesOnPanel.
        /// </summary>
        [DataMember]
        public Boolean IsOnlySeriesOnPanel { get; set; }
        /// <summary>
        /// Gets or sets the LookupPolicies.
        /// </summary>
        [DataMember]
        public LookupPolicies LookupPolicies { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfPanels.
        /// </summary>
        [DataMember]
        public Int32 NumberOfPanels { get; set; }
        /// <summary>
        /// Gets or sets the OnAfterOnBarUpdate.
        /// </summary>
        [DataMember]
        public Action<Instrument> OnAfterOnBarUpdate { get; set; }
        /// <summary>
        /// Gets or sets the Owner.
        /// </summary>
        [DataMember]
        public Window Owner { get; set; }
        /// <summary>
        /// Gets or sets the Panel.
        /// </summary>
        [DataMember]
        public Int32 Panel { get; set; }
        /// <summary>
        /// Gets or sets the PlotBrushes.
        /// </summary>
        [DataMember]
        public BrushSeries[] PlotBrushes { get; set; }
        /// <summary>
        /// Gets or sets the ScaleJustification.
        /// </summary>
        [DataMember]
        public ScaleJustification ScaleJustification { get; set; }
        /// <summary>
        /// Gets or sets the ShowTransparentPlotsInDataBox.
        /// </summary>
        [DataMember]
        public Boolean ShowTransparentPlotsInDataBox { get; set; }
        /// <summary>
        /// Gets or sets the To.
        /// </summary>
        [DataMember]
        public DateTime To { get; set; }
        /// <summary>
        /// Gets or sets the Bars.
        /// </summary>
        [DataMember]
        public Bars Bars { get; set; }
        /// <summary>
        /// Gets or sets the BarsArray.
        /// </summary>
        [DataMember]
        public Bars[] BarsArray { get; set; }
        /// <summary>
        /// Gets or sets the BarsInProgress.
        /// </summary>
        [DataMember]
        public Int32 BarsInProgress { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriods.
        /// </summary>
        [DataMember]
        public BarsPeriod[] BarsPeriods { get; set; }
        /// <summary>
        /// Gets or sets the BarsRequiredToPlot.
        /// </summary>
        [DataMember]
        public Int32 BarsRequiredToPlot { get; set; }
        /// <summary>
        /// Gets or sets the Calculate.
        /// </summary>
        [DataMember]
        public Calculate Calculate { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public ISeries<Double> Close { get; set; }
        /// <summary>
        /// Gets or sets the Closes.
        /// </summary>
        [DataMember]
        public PriceSeries[] Closes { get; set; }
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the CurrentBar.
        /// </summary>
        [DataMember]
        public Int32 CurrentBar { get; set; }
        /// <summary>
        /// Gets or sets the CurrentBars.
        /// </summary>
        [DataMember]
        public Int32[] CurrentBars { get; set; }
        /// <summary>
        /// Gets or sets the Displacement.
        /// </summary>
        [DataMember]
        public Int32 Displacement { get; set; }
        /// <summary>
        /// Gets or sets the DrawingToolsHidden.
        /// </summary>
        [DataMember]
        public Boolean DrawingToolsHidden { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public ISeries<Double> High { get; set; }
        /// <summary>
        /// Gets or sets the Highs.
        /// </summary>
        [DataMember]
        public PriceSeries[] Highs { get; set; }
        /// <summary>
        /// Gets or sets the Input.
        /// </summary>
        [DataMember]
        public ISeries<Double> Input { get; set; }
        /// <summary>
        /// Gets or sets the Inputs.
        /// </summary>
        [DataMember]
        public ISeries`1[] Inputs { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Instruments.
        /// </summary>
        [DataMember]
        public Instrument[] Instruments { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoScale.
        /// </summary>
        [DataMember]
        public Boolean IsAutoScale { get; set; }
        /// <summary>
        /// Gets or sets the IsDataSeriesRequired.
        /// </summary>
        [DataMember]
        public Boolean IsDataSeriesRequired { get; set; }
        /// <summary>
        /// Gets or sets the IsFirstTickOfBar.
        /// </summary>
        [DataMember]
        public Boolean IsFirstTickOfBar { get; set; }
        /// <summary>
        /// Gets or sets the IsHiddenDataSeries.
        /// </summary>
        [DataMember]
        public Boolean[] IsHiddenDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the IsOverlay.
        /// </summary>
        [DataMember]
        public Boolean IsOverlay { get; set; }
        /// <summary>
        /// Gets or sets the IsResetOnNewTradingDays.
        /// </summary>
        [DataMember]
        public Nullable`1[] IsResetOnNewTradingDays { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplays.
        /// </summary>
        [DataMember]
        public Nullable`1[] IsTickReplays { get; set; }
        /// <summary>
        /// Gets or sets the Lines.
        /// </summary>
        [DataMember]
        public Line[] Lines { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public ISeries<Double> Low { get; set; }
        /// <summary>
        /// Gets or sets the Lows.
        /// </summary>
        [DataMember]
        public PriceSeries[] Lows { get; set; }
        /// <summary>
        /// Gets or sets the MaxProcessedEvents.
        /// </summary>
        [DataMember]
        public Int32 MaxProcessedEvents { get; set; }
        /// <summary>
        /// Gets or sets the MaximumBarsLookBack.
        /// </summary>
        [DataMember]
        public MaximumBarsLookBack MaximumBarsLookBack { get; set; }
        /// <summary>
        /// Gets or sets the Median.
        /// </summary>
        [DataMember]
        public ISeries<Double> Median { get; set; }
        /// <summary>
        /// Gets or sets the Medians.
        /// </summary>
        [DataMember]
        public PriceSeries[] Medians { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScripts.
        /// </summary>
        [DataMember]
        public Collection<NinjaScriptBase> NinjaScripts { get; set; }
        /// <summary>
        /// Gets or sets the OldBarsArrayCurrentBars.
        /// </summary>
        [DataMember]
        public Int32[] OldBarsArrayCurrentBars { get; set; }
        /// <summary>
        /// Gets or sets the OldCurrentBars.
        /// </summary>
        [DataMember]
        public Int32[] OldCurrentBars { get; set; }
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public ISeries<Double> Open { get; set; }
        /// <summary>
        /// Gets or sets the Opens.
        /// </summary>
        [DataMember]
        public PriceSeries[] Opens { get; set; }
        /// <summary>
        /// Gets or sets the Parent.
        /// </summary>
        [DataMember]
        public NinjaScriptBase Parent { get; set; }
        /// <summary>
        /// Gets or sets the Plots.
        /// </summary>
        [DataMember]
        public Plot[] Plots { get; set; }
        /// <summary>
        /// Gets or sets the ProfilerOnBarUpdateCount.
        /// </summary>
        [DataMember]
        public Int64 ProfilerOnBarUpdateCount { get; set; }
        /// <summary>
        /// Gets or sets the ProfilerOnBarUpdateCycleTime.
        /// </summary>
        [DataMember]
        public Int64 ProfilerOnBarUpdateCycleTime { get; set; }
        /// <summary>
        /// Gets or sets the SelectedValueSeries.
        /// </summary>
        [DataMember]
        public Int32 SelectedValueSeries { get; set; }
        /// <summary>
        /// Gets or sets the SyncRealtimeData.
        /// </summary>
        [DataMember]
        public Object SyncRealtimeData { get; set; }
        /// <summary>
        /// Gets or sets the SyncUpdate.
        /// </summary>
        [DataMember]
        public Object SyncUpdate { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public Double Item { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public TimeSeries Time { get; set; }
        /// <summary>
        /// Gets or sets the Times.
        /// </summary>
        [DataMember]
        public TimeSeries[] Times { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public TradingHours TradingHours { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursArray.
        /// </summary>
        [DataMember]
        public TradingHours[] TradingHoursArray { get; set; }
        /// <summary>
        /// Gets or sets the Typical.
        /// </summary>
        [DataMember]
        public ISeries<Double> Typical { get; set; }
        /// <summary>
        /// Gets or sets the Typicals.
        /// </summary>
        [DataMember]
        public PriceSeries[] Typicals { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Series<Double> Value { get; set; }
        /// <summary>
        /// Gets or sets the Values.
        /// </summary>
        [DataMember]
        public Series`1[] Values { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public VolumeSeries Volume { get; set; }
        /// <summary>
        /// Gets or sets the Volumes.
        /// </summary>
        [DataMember]
        public VolumeSeries[] Volumes { get; set; }
        /// <summary>
        /// Gets or sets the Weighted.
        /// </summary>
        [DataMember]
        public ISeries<Double> Weighted { get; set; }
        /// <summary>
        /// Gets or sets the Weighteds.
        /// </summary>
        [DataMember]
        public PriceSeries[] Weighteds { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Alert method.
        /// </summary>
        /// <param name="id">String</param>
        /// <param name="priority">Priority</param>
        /// <param name="message">String</param>
        /// <param name="soundLocation">String</param>
        /// <param name="rearmSeconds">Int32</param>
        /// <param name="backBrush">Brush</param>
        /// <param name="foregroundBrush">Brush</param>
        public Void Alert(String id, Priority priority, String message, String soundLocation, Int32 rearmSeconds, Brush backBrush, Brush foregroundBrush);
        /// <summary>
        /// CheckInstances method.
        /// </summary>
        public Void CheckInstances();
        /// <summary>
        /// GetAllNinjaScripts method.
        /// </summary>
        /// <returns>Collection`1</returns>
        public Collection<NinjaScriptBase> GetAllNinjaScripts();
        /// <summary>
        /// InitializeBars method.
        /// </summary>
        /// <param name="barsArray">Bars[]</param>
        /// <param name="progress">IProgress</param>
        /// <param name="callback">Action`1</param>
        public Void InitializeBars(Bars[] barsArray, IProgress progress, Action<NinjaScriptBase> callback);
        /// <summary>
        /// IsRising method.
        /// </summary>
        /// <param name="series">ISeries`1</param>
        /// <returns>Boolean</returns>
        public Boolean IsRising(ISeries<Double> series);
        /// <summary>
        /// ReloadAllHistoricalData method.
        /// </summary>
        public Void ReloadAllHistoricalData();
        /// <summary>
        /// RearmAlert method.
        /// </summary>
        /// <param name="id">String</param>
        public Void RearmAlert(String id);
        /// <summary>
        /// TriggerCustomEvent method.
        /// </summary>
        /// <param name="customEvent">Action`1</param>
        /// <param name="state">Object</param>
        public Void TriggerCustomEvent(Action<Object> customEvent, Object state);
        /// <summary>
        /// TriggerCustomEvent method.
        /// </summary>
        /// <param name="customEvent">Action`1</param>
        /// <param name="barsSeriesIndex">Int32</param>
        /// <param name="state">Object</param>
        public Void TriggerCustomEvent(Action<Object> customEvent, Int32 barsSeriesIndex, Object state);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// CountIf method.
        /// </summary>
        /// <param name="condition">Func`1</param>
        /// <param name="period">Int32</param>
        /// <returns>Int32</returns>
        public Int32 CountIf(Func<Boolean> condition, Int32 period);
        /// <summary>
        /// CrossAbove method.
        /// </summary>
        /// <param name="series1">ISeries`1</param>
        /// <param name="series2">ISeries`1</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean CrossAbove(ISeries<Double> series1, ISeries<Double> series2, Int32 lookBackPeriod);
        /// <summary>
        /// CrossAbove method.
        /// </summary>
        /// <param name="series1">ISeries`1</param>
        /// <param name="value">Double</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean CrossAbove(ISeries<Double> series1, Double value, Int32 lookBackPeriod);
        /// <summary>
        /// CrossAbove method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <param name="series2">ISeries`1</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean CrossAbove(Double value, ISeries<Double> series2, Int32 lookBackPeriod);
        /// <summary>
        /// CrossBelow method.
        /// </summary>
        /// <param name="series1">ISeries`1</param>
        /// <param name="series2">ISeries`1</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean CrossBelow(ISeries<Double> series1, ISeries<Double> series2, Int32 lookBackPeriod);
        /// <summary>
        /// CrossBelow method.
        /// </summary>
        /// <param name="series1">ISeries`1</param>
        /// <param name="value">Double</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean CrossBelow(ISeries<Double> series1, Double value, Int32 lookBackPeriod);
        /// <summary>
        /// CrossBelow method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <param name="series2">ISeries`1</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean CrossBelow(Double value, ISeries<Double> series2, Int32 lookBackPeriod);
        /// <summary>
        /// EqualsInput method.
        /// </summary>
        /// <param name="series">ISeries`1</param>
        /// <returns>Boolean</returns>
        public Boolean EqualsInput(ISeries<Double> series);
        /// <summary>
        /// FormatPriceMarker method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>String</returns>
        public String FormatPriceMarker(Double price);
        /// <summary>
        /// GetCurrentAsk method.
        /// </summary>
        /// <returns>Double</returns>
        public Double GetCurrentAsk();
        /// <summary>
        /// GetCurrentAsk method.
        /// </summary>
        /// <param name="barsSeriesIndex">Int32</param>
        /// <returns>Double</returns>
        public Double GetCurrentAsk(Int32 barsSeriesIndex);
        /// <summary>
        /// GetCurrentAskVolume method.
        /// </summary>
        /// <returns>Int64</returns>
        public Int64 GetCurrentAskVolume();
        /// <summary>
        /// GetCurrentAskVolume method.
        /// </summary>
        /// <param name="barsSeriesIndex">Int32</param>
        /// <returns>Int64</returns>
        public Int64 GetCurrentAskVolume(Int32 barsSeriesIndex);
        /// <summary>
        /// GetCurrentBid method.
        /// </summary>
        /// <returns>Double</returns>
        public Double GetCurrentBid();
        /// <summary>
        /// GetCurrentBid method.
        /// </summary>
        /// <param name="barsSeriesIndex">Int32</param>
        /// <returns>Double</returns>
        public Double GetCurrentBid(Int32 barsSeriesIndex);
        /// <summary>
        /// GetCurrentBidVolume method.
        /// </summary>
        /// <returns>Int64</returns>
        public Int64 GetCurrentBidVolume();
        /// <summary>
        /// GetCurrentBidVolume method.
        /// </summary>
        /// <param name="barsSeriesIndex">Int32</param>
        /// <returns>Int64</returns>
        public Int64 GetCurrentBidVolume(Int32 barsSeriesIndex);
        /// <summary>
        /// GetExceptionMessage method.
        /// </summary>
        /// <param name="exp">Exception</param>
        /// <returns>String</returns>
        public String GetExceptionMessage(Exception exp);
        /// <summary>
        /// GetMedian method.
        /// </summary>
        /// <param name="series">ISeries`1</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Double</returns>
        public Double GetMedian(ISeries<Double> series, Int32 lookBackPeriod);
        /// <summary>
        /// GetValueAt method.
        /// </summary>
        /// <param name="barIndex">Int32</param>
        /// <returns>Double</returns>
        public Double GetValueAt(Int32 barIndex);
        /// <summary>
        /// HighestBar method.
        /// </summary>
        /// <param name="series">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>Int32</returns>
        public Int32 HighestBar(ISeries<Double> series, Int32 period);
        /// <summary>
        /// IsEqualBars method.
        /// </summary>
        /// <param name="bars">Bars</param>
        /// <param name="ninjaScript">NinjaScriptBase</param>
        /// <param name="bip">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqualBars(Bars bars, NinjaScriptBase ninjaScript, Int32 bip);
        /// <summary>
        /// IsFalling method.
        /// </summary>
        /// <param name="series">ISeries`1</param>
        /// <returns>Boolean</returns>
        public Boolean IsFalling(ISeries<Double> series);
        /// <summary>
        /// IsValidDataPoint method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPoint(Int32 barsAgo);
        /// <summary>
        /// IsValidDataPointAt method.
        /// </summary>
        /// <param name="barIndex">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPointAt(Int32 barIndex);
        /// <summary>
        /// LowestBar method.
        /// </summary>
        /// <param name="series">ISeries`1</param>
        /// <param name="period">Int32</param>
        /// <returns>Int32</returns>
        public Int32 LowestBar(ISeries<Double> series, Int32 period);
        /// <summary>
        /// LRO method.
        /// </summary>
        /// <param name="condition">Func`1</param>
        /// <param name="instance">Int32</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Int32</returns>
        public Int32 LRO(Func<Boolean> condition, Int32 instance, Int32 lookBackPeriod);
        /// <summary>
        /// MRO method.
        /// </summary>
        /// <param name="condition">Func`1</param>
        /// <param name="instance">Int32</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Int32</returns>
        public Int32 MRO(Func<Boolean> condition, Int32 instance, Int32 lookBackPeriod);
        /// <summary>
        /// RaiseChanged method.
        /// </summary>
        /// <param name="ninjaScriptBase">NinjaScriptBase</param>
        /// <param name="operation">Operation</param>
        public Void RaiseChanged(NinjaScriptBase ninjaScriptBase, Operation operation);
        /// <summary>
        /// SetInput method.
        /// </summary>
        /// <param name="input">ISeries`1</param>
        public Void SetInput(ISeries<Double> input);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        /// <summary>
        /// Slope method.
        /// </summary>
        /// <param name="series">ISeries`1</param>
        /// <param name="startBarsAgo">Int32</param>
        /// <param name="endBarsAgo">Int32</param>
        /// <returns>Double</returns>
        public Double Slope(ISeries<Double> series, Int32 startBarsAgo, Int32 endBarsAgo);
        /// <summary>
        /// ToDay method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <returns>Int32</returns>
        public Int32 ToDay(DateTime time);
        /// <summary>
        /// ToTime method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <returns>Int32</returns>
        public Int32 ToTime(DateTime time);
        /// <summary>
        /// ToTime method.
        /// </summary>
        /// <param name="hour">Int32</param>
        /// <param name="minute">Int32</param>
        /// <param name="second">Int32</param>
        /// <returns>Int32</returns>
        public Int32 ToTime(Int32 hour, Int32 minute, Int32 second);
        /// <summary>
        /// Update method.
        /// </summary>
        public Void Update();
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="idx">Int32</param>
        /// <param name="bip">Int32</param>
        public Void Update(Int32 idx, Int32 bip);
        #endregion
    }
}
