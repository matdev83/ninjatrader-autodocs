[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MatPSARScalper : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PSARAccelerationStart.
        /// </summary>
        [DataMember]
        public Double PSARAccelerationStart { get; set; }
        /// <summary>
        /// Gets or sets the PSARAccelerationStep.
        /// </summary>
        [DataMember]
        public Double PSARAccelerationStep { get; set; }
        /// <summary>
        /// Gets or sets the PSARAccelerationMax.
        /// </summary>
        [DataMember]
        public Double PSARAccelerationMax { get; set; }
        /// <summary>
        /// Gets or sets the VWMAPeriod.
        /// </summary>
        [DataMember]
        public Int32 VWMAPeriod { get; set; }
        /// <summary>
        /// Gets or sets the MinVWMAChange.
        /// </summary>
        [DataMember]
        public Double MinVWMAChange { get; set; }
        /// <summary>
        /// Gets or sets the MaxPriceDeviationPercent.
        /// </summary>
        [DataMember]
        public Double MaxPriceDeviationPercent { get; set; }
        /// <summary>
        /// Gets or sets the TradeLongs.
        /// </summary>
        [DataMember]
        public Boolean TradeLongs { get; set; }
        /// <summary>
        /// Gets or sets the TradeShorts.
        /// </summary>
        [DataMember]
        public Boolean TradeShorts { get; set; }
        /// <summary>
        /// Gets or sets the AllowSecondarySignalEntries.
        /// </summary>
        [DataMember]
        public Boolean AllowSecondarySignalEntries { get; set; }
        /// <summary>
        /// Gets or sets the DisableSignalsContrarianToDayRangeBreach.
        /// </summary>
        [DataMember]
        public Boolean DisableSignalsContrarianToDayRangeBreach { get; set; }
        /// <summary>
        /// Gets or sets the UseOrFilterDuringLondonSession.
        /// </summary>
        [DataMember]
        public Boolean UseOrFilterDuringLondonSession { get; set; }
        /// <summary>
        /// Gets or sets the UseOrFilterDuringCashSession.
        /// </summary>
        [DataMember]
        public Boolean UseOrFilterDuringCashSession { get; set; }
        /// <summary>
        /// Gets or sets the SignalChangeLookback.
        /// </summary>
        [DataMember]
        public Int32 SignalChangeLookback { get; set; }
        /// <summary>
        /// Gets or sets the MaxSignalChangesInLookback.
        /// </summary>
        [DataMember]
        public Int32 MaxSignalChangesInLookback { get; set; }
        /// <summary>
        /// Gets or sets the AtrPeriod.
        /// </summary>
        [DataMember]
        public Int32 AtrPeriod { get; set; }
        /// <summary>
        /// Gets or sets the EmergencyStopAtrMult.
        /// </summary>
        [DataMember]
        public Double EmergencyStopAtrMult { get; set; }
        /// <summary>
        /// Gets or sets the Tp1AtrMult.
        /// </summary>
        [DataMember]
        public Double Tp1AtrMult { get; set; }
        /// <summary>
        /// Gets or sets the Tp2AtrMult.
        /// </summary>
        [DataMember]
        public Double Tp2AtrMult { get; set; }
        /// <summary>
        /// Gets or sets the ExitConditionMinOpposingSarBars.
        /// </summary>
        [DataMember]
        public Int32 ExitConditionMinOpposingSarBars { get; set; }
        /// <summary>
        /// Gets or sets the GlobexSessionStartHour.
        /// </summary>
        [DataMember]
        public Int32 GlobexSessionStartHour { get; set; }
        /// <summary>
        /// Gets or sets the LondonSessionStartHour.
        /// </summary>
        [DataMember]
        public Int32 LondonSessionStartHour { get; set; }
        /// <summary>
        /// Gets or sets the EnableVerboseDebugging.
        /// </summary>
        [DataMember]
        public Boolean EnableVerboseDebugging { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentLength.
        /// </summary>
        [DataMember]
        public Int32 HurstExponentLength { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentBaseScale.
        /// </summary>
        [DataMember]
        public Int32 HurstExponentBaseScale { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentMaxScale.
        /// </summary>
        [DataMember]
        public Int32 HurstExponentMaxScale { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentMinValue.
        /// </summary>
        [DataMember]
        public Double HurstExponentMinValue { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentMaxValue.
        /// </summary>
        [DataMember]
        public Double HurstExponentMaxValue { get; set; }
        /// <summary>
        /// Gets or sets the DonchianChannelLen.
        /// </summary>
        [DataMember]
        public Int32 DonchianChannelLen { get; set; }
        /// <summary>
        /// Gets or sets the DonchianChannelMaxDistPct.
        /// </summary>
        [DataMember]
        public Double DonchianChannelMaxDistPct { get; set; }
        /// <summary>
        /// Gets or sets the TradingWindowStartInMinutes.
        /// </summary>
        [DataMember]
        public Int32 TradingWindowStartInMinutes { get; set; }
        /// <summary>
        /// Gets or sets the TradingWindowLengthInMinutes.
        /// </summary>
        [DataMember]
        public Int32 TradingWindowLengthInMinutes { get; set; }
        /// <summary>
        /// Gets or sets the TradeSunday.
        /// </summary>
        [DataMember]
        public Boolean TradeSunday { get; set; }
        /// <summary>
        /// Gets or sets the TradeMonday.
        /// </summary>
        [DataMember]
        public Boolean TradeMonday { get; set; }
        /// <summary>
        /// Gets or sets the TradeTuesday.
        /// </summary>
        [DataMember]
        public Boolean TradeTuesday { get; set; }
        /// <summary>
        /// Gets or sets the TradeWednesday.
        /// </summary>
        [DataMember]
        public Boolean TradeWednesday { get; set; }
        /// <summary>
        /// Gets or sets the TradeThursday.
        /// </summary>
        [DataMember]
        public Boolean TradeThursday { get; set; }
        /// <summary>
        /// Gets or sets the TradeFriday.
        /// </summary>
        [DataMember]
        public Boolean TradeFriday { get; set; }
        /// <summary>
        /// Gets or sets the ForbiddenDatesCsvFile.
        /// </summary>
        [DataMember]
        public String ForbiddenDatesCsvFile { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
