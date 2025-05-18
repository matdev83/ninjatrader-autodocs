[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class MarketAnalyzerColumnBase : NinjaScriptBase, IBarsPeriodProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AltBarColorSerialize.
        /// </summary>
        [DataMember]
        public String AltBarColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BackColorSerialize.
        /// </summary>
        [DataMember]
        public String BackColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the MinBackgroundColorSerialize.
        /// </summary>
        [DataMember]
        public String MinBackgroundColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the MaxBackgroundColorSerialize.
        /// </summary>
        [DataMember]
        public String MaxBackgroundColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the MinForegroundColorSerialize.
        /// </summary>
        [DataMember]
        public String MinForegroundColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the MaxForegroundColorSerialize.
        /// </summary>
        [DataMember]
        public String MaxForegroundColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BarColorSerializable.
        /// </summary>
        [DataMember]
        public String BarColorSerializable { get; set; }
        /// <summary>
        /// Gets or sets the BarsToLoad.
        /// </summary>
        [DataMember]
        public Int32 BarsToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CellConditionsSerialize.
        /// </summary>
        [DataMember]
        public CellCondition[] CellConditionsSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DataTypeSerialize.
        /// </summary>
        [DataMember]
        public String DataTypeSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DaysBack.
        /// </summary>
        [DataMember]
        public Int32 DaysBack { get; set; }
        /// <summary>
        /// Gets or sets the FilterConditionsSerialize.
        /// </summary>
        [DataMember]
        public FilterCondition[] FilterConditionsSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ForeColorSerialize.
        /// </summary>
        [DataMember]
        public String ForeColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the HighlightTicks.
        /// </summary>
        [DataMember]
        public Int32 HighlightTicks { get; set; }
        /// <summary>
        /// Gets or sets the IsStableSession.
        /// </summary>
        [DataMember]
        public Boolean IsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public Boolean IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the PriorValue.
        /// </summary>
        [DataMember]
        public Double PriorValue { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursInstance.
        /// </summary>
        [DataMember]
        public TradingHours TradingHoursInstance { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursSerializable.
        /// </summary>
        [DataMember]
        public String TradingHoursSerializable { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the IsColorDistributionEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsColorDistributionEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ColorDistribution.
        /// </summary>
        [DataMember]
        public MarketAnalyzerColumnColorDistribution ColorDistribution { get; set; }
        /// <summary>
        /// Gets or sets the MaxValueRange.
        /// </summary>
        [DataMember]
        public Double MaxValueRange { get; set; }
        /// <summary>
        /// Gets or sets the MinValueRange.
        /// </summary>
        [DataMember]
        public Double MinValueRange { get; set; }
        /// <summary>
        /// Gets or sets the MaxBackgroundColor.
        /// </summary>
        [DataMember]
        public Brush MaxBackgroundColor { get; set; }
        /// <summary>
        /// Gets or sets the MinBackgroundColor.
        /// </summary>
        [DataMember]
        public Brush MinBackgroundColor { get; set; }
        /// <summary>
        /// Gets or sets the MaxForegroundColor.
        /// </summary>
        [DataMember]
        public Brush MaxForegroundColor { get; set; }
        /// <summary>
        /// Gets or sets the MinForegroundColor.
        /// </summary>
        [DataMember]
        public Brush MinForegroundColor { get; set; }
        /// <summary>
        /// Gets or sets the AltBarColor.
        /// </summary>
        [DataMember]
        public Brush AltBarColor { get; set; }
        /// <summary>
        /// Gets or sets the BackColor.
        /// </summary>
        [DataMember]
        public Brush BackColor { get; set; }
        /// <summary>
        /// Gets or sets the BarColor.
        /// </summary>
        [DataMember]
        public Brush BarColor { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthType.
        /// </summary>
        [DataMember]
        public BarGraphGrowthType BarGraphGrowthType { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthMaxValue.
        /// </summary>
        [DataMember]
        public Double BarGraphGrowthMaxValue { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphReferenceValue.
        /// </summary>
        [DataMember]
        public Double BarGraphReferenceValue { get; set; }
        /// <summary>
        /// Gets or sets the CellConditions.
        /// </summary>
        [DataMember]
        public Collection<CellCondition> CellConditions { get; set; }
        /// <summary>
        /// Gets or sets the ColumnType.
        /// </summary>
        [DataMember]
        public ColumnType ColumnType { get; set; }
        /// <summary>
        /// Gets or sets the CurrentText.
        /// </summary>
        [DataMember]
        public String CurrentText { get; set; }
        /// <summary>
        /// Gets or sets the CurrentValue.
        /// </summary>
        [DataMember]
        public Double CurrentValue { get; set; }
        /// <summary>
        /// Gets or sets the DataType.
        /// </summary>
        [DataMember]
        public Type DataType { get; set; }
        /// <summary>
        /// Gets or sets the FilterConditions.
        /// </summary>
        [DataMember]
        public Collection<FilterCondition> FilterConditions { get; set; }
        /// <summary>
        /// Gets or sets the ForeColor.
        /// </summary>
        [DataMember]
        public Brush ForeColor { get; set; }
        /// <summary>
        /// Gets or sets the FormatDecimals.
        /// </summary>
        [DataMember]
        public Int32 FormatDecimals { get; set; }
        /// <summary>
        /// Gets or sets the DefaultAccountName.
        /// </summary>
        [DataMember]
        public String DefaultAccountName { get; set; }
        /// <summary>
        /// Gets or sets the IsCurrentTextSet.
        /// </summary>
        [DataMember]
        public Boolean IsCurrentTextSet { get; set; }
        /// <summary>
        /// Gets or sets the IsCurrentValueSet.
        /// </summary>
        [DataMember]
        public Boolean IsCurrentValueSet { get; set; }
        /// <summary>
        /// Gets or sets the IsEditable.
        /// </summary>
        [DataMember]
        public Boolean IsEditable { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the RangeType.
        /// </summary>
        [DataMember]
        public RangeType RangeType { get; set; }
        /// <summary>
        /// Gets or sets the ShowInTotalRow.
        /// </summary>
        [DataMember]
        public Boolean ShowInTotalRow { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetActiveCellCondition method.
        /// </summary>
        /// <returns>CellCondition</returns>
        public CellCondition GetActiveCellCondition();
        /// <summary>
        /// GetActiveFilterCondition method.
        /// </summary>
        /// <returns>FilterCondition</returns>
        public FilterCondition GetActiveFilterCondition();
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="column">MarketAnalyzerColumnBase</param>
        /// <returns>Boolean</returns>
        [Obsolete]
        public Boolean IsEqual(MarketAnalyzerColumnBase column);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String Format(Double value);
        /// <summary>
        /// SaveInputToXml method.
        /// </summary>
        /// <returns>XElement</returns>
        public XElement SaveInputToXml();
        #endregion
    }
}
