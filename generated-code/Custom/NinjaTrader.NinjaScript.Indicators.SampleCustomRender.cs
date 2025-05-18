[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class SampleCustomRender : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AreaBrush.
        /// </summary>
        [DataMember]
        public Brush AreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the AreaBrushSerialize.
        /// </summary>
        [DataMember]
        public String AreaBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the AreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 AreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the SmallAreaBrush.
        /// </summary>
        [DataMember]
        public Brush SmallAreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the SmallAreaBrushSerialize.
        /// </summary>
        [DataMember]
        public String SmallAreaBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the TestPlot.
        /// </summary>
        [DataMember]
        public Series<Double> TestPlot { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
