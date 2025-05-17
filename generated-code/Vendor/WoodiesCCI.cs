[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class WoodiesCCI : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ChopIndicatorWidth.
        /// </summary>
        [DataMember]
        public Int32 ChopIndicatorWidth { get; set; }
        /// <summary>
        /// Gets or sets the ChopZone.
        /// </summary>
        [DataMember]
        public Series<Double> ChopZone { get; set; }
        /// <summary>
        /// Gets or sets the ColorLsmaNegative.
        /// </summary>
        [DataMember]
        public Brush ColorLsmaNegative { get; set; }
        /// <summary>
        /// Gets or sets the ColorLsmaNegativeSerialize.
        /// </summary>
        [DataMember]
        public String ColorLsmaNegativeSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorLsmaPositive.
        /// </summary>
        [DataMember]
        public Brush ColorLsmaPositive { get; set; }
        /// <summary>
        /// Gets or sets the ColorLsmaPositiveSerialize.
        /// </summary>
        [DataMember]
        public String ColorLsmaPositiveSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorNegativ.
        /// </summary>
        [DataMember]
        public Brush ColorNegativ { get; set; }
        /// <summary>
        /// Gets or sets the ColorNegativSerialize.
        /// </summary>
        [DataMember]
        public String ColorNegativSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorNeutral.
        /// </summary>
        [DataMember]
        public Brush ColorNeutral { get; set; }
        /// <summary>
        /// Gets or sets the ColorNeutralSerialize.
        /// </summary>
        [DataMember]
        public String ColorNeutralSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorNeutralLeave.
        /// </summary>
        [DataMember]
        public Brush ColorNeutralLeave { get; set; }
        /// <summary>
        /// Gets or sets the ColorNeutralLeaveSerialize.
        /// </summary>
        [DataMember]
        public String ColorNeutralLeaveSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorPositive.
        /// </summary>
        [DataMember]
        public Brush ColorPositive { get; set; }
        /// <summary>
        /// Gets or sets the ColorPositiveSerialize.
        /// </summary>
        [DataMember]
        public String ColorPositiveSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorSwNeutral.
        /// </summary>
        [DataMember]
        public Brush ColorSwNeutral { get; set; }
        /// <summary>
        /// Gets or sets the ColorSwNeutralSerialize.
        /// </summary>
        [DataMember]
        public String ColorSwNeutralSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorSwTrend.
        /// </summary>
        [DataMember]
        public Brush ColorSwTrend { get; set; }
        /// <summary>
        /// Gets or sets the ColorSwTrendSerialize.
        /// </summary>
        [DataMember]
        public String ColorSwTrendSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorSwWarn.
        /// </summary>
        [DataMember]
        public Brush ColorSwWarn { get; set; }
        /// <summary>
        /// Gets or sets the ColorSwWarnSerialize.
        /// </summary>
        [DataMember]
        public String ColorSwWarnSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Default.
        /// </summary>
        [DataMember]
        public Series<Double> Default { get; set; }
        /// <summary>
        /// Gets or sets the DisplayCciPanel.
        /// </summary>
        [DataMember]
        public Boolean DisplayCciPanel { get; set; }
        /// <summary>
        /// Gets or sets the NeutralBars.
        /// </summary>
        [DataMember]
        public Int32 NeutralBars { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the PeriodEma.
        /// </summary>
        [DataMember]
        public Int32 PeriodEma { get; set; }
        /// <summary>
        /// Gets or sets the PeriodLinReg.
        /// </summary>
        [DataMember]
        public Int32 PeriodLinReg { get; set; }
        /// <summary>
        /// Gets or sets the PeriodTurbo.
        /// </summary>
        [DataMember]
        public Int32 PeriodTurbo { get; set; }
        /// <summary>
        /// Gets or sets the SideWinderLimit0.
        /// </summary>
        [DataMember]
        public Int32 SideWinderLimit0 { get; set; }
        /// <summary>
        /// Gets or sets the SideWinderLimit1.
        /// </summary>
        [DataMember]
        public Int32 SideWinderLimit1 { get; set; }
        /// <summary>
        /// Gets or sets the Sidewinder.
        /// </summary>
        [DataMember]
        public Series<Double> Sidewinder { get; set; }
        /// <summary>
        /// Gets or sets the SideWinderWidth.
        /// </summary>
        [DataMember]
        public Int32 SideWinderWidth { get; set; }
        /// <summary>
        /// Gets or sets the Turbo.
        /// </summary>
        [DataMember]
        public Series<Double> Turbo { get; set; }
        /// <summary>
        /// Gets or sets the ZoneBars.
        /// </summary>
        [DataMember]
        public Series<Double> ZoneBars { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
