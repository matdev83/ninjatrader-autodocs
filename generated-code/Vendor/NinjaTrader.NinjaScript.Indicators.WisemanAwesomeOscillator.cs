[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class WisemanAwesomeOscillator : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LineWidth.
        /// </summary>
        [DataMember]
        public Int32 LineWidth { get; set; }
        /// <summary>
        /// Gets or sets the HistogramUpBrush.
        /// </summary>
        [DataMember]
        public Brush HistogramUpBrush { get; set; }
        /// <summary>
        /// Gets or sets the HistogramUpBrushS.
        /// </summary>
        [DataMember]
        public String HistogramUpBrushS { get; set; }
        /// <summary>
        /// Gets or sets the HistogramDownBrush.
        /// </summary>
        [DataMember]
        public Brush HistogramDownBrush { get; set; }
        /// <summary>
        /// Gets or sets the HistogramDownBrushS.
        /// </summary>
        [DataMember]
        public String HistogramDownBrushS { get; set; }
        /// <summary>
        /// Gets or sets the BarColorEnabled.
        /// </summary>
        [DataMember]
        public Boolean BarColorEnabled { get; set; }
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
        /// Gets or sets the ColorNeutralBrush.
        /// </summary>
        [DataMember]
        public Brush ColorNeutralBrush { get; set; }
        /// <summary>
        /// Gets or sets the ColorNeutralBrushS.
        /// </summary>
        [DataMember]
        public String ColorNeutralBrushS { get; set; }
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
        /// <summary>
        /// Gets or sets the ColorUpBrush2.
        /// </summary>
        [DataMember]
        public Brush ColorUpBrush2 { get; set; }
        /// <summary>
        /// Gets or sets the ColorUpBrush2S.
        /// </summary>
        [DataMember]
        public String ColorUpBrush2S { get; set; }
        /// <summary>
        /// Gets or sets the ColorNeutralBrush2.
        /// </summary>
        [DataMember]
        public Brush ColorNeutralBrush2 { get; set; }
        /// <summary>
        /// Gets or sets the ColorNeutralBrush2S.
        /// </summary>
        [DataMember]
        public String ColorNeutralBrush2S { get; set; }
        /// <summary>
        /// Gets or sets the ColorDownBrush2.
        /// </summary>
        [DataMember]
        public Brush ColorDownBrush2 { get; set; }
        /// <summary>
        /// Gets or sets the ColorDownBrush2S.
        /// </summary>
        [DataMember]
        public String ColorDownBrush2S { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
