[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class VolumeZones : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarCount.
        /// </summary>
        [DataMember]
        public Int32 BarCount { get; set; }
        /// <summary>
        /// Gets or sets the BarSpacing.
        /// </summary>
        [DataMember]
        public Int32 BarSpacing { get; set; }
        /// <summary>
        /// Gets or sets the BarDownBrush.
        /// </summary>
        [DataMember]
        public Brush BarDownBrush { get; set; }
        /// <summary>
        /// Gets or sets the BarColorDownSerialize.
        /// </summary>
        [DataMember]
        public String BarColorDownSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DrawLines.
        /// </summary>
        [DataMember]
        public Boolean DrawLines { get; set; }
        /// <summary>
        /// Gets or sets the LineBrush.
        /// </summary>
        [DataMember]
        public Brush LineBrush { get; set; }
        /// <summary>
        /// Gets or sets the LineBrushSerialize.
        /// </summary>
        [DataMember]
        public String LineBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BarUpBrush.
        /// </summary>
        [DataMember]
        public Brush BarUpBrush { get; set; }
        /// <summary>
        /// Gets or sets the BarColorUpSerialize.
        /// </summary>
        [DataMember]
        public String BarColorUpSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        [DataMember]
        public Double Opacity { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
