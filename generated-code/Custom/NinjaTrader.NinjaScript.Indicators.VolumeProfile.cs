[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class VolumeProfile : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        [DataMember]
        public Double Opacity { get; set; }
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
        /// Gets or sets the VolumeDownBrush.
        /// </summary>
        [DataMember]
        public Brush VolumeDownBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDownBrushSerialize.
        /// </summary>
        [DataMember]
        public String VolumeDownBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the VolumeNeutralBrush.
        /// </summary>
        [DataMember]
        public Brush VolumeNeutralBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumeNeutralBrushSerialize.
        /// </summary>
        [DataMember]
        public String VolumeNeutralBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the VolumeUpBrush.
        /// </summary>
        [DataMember]
        public Brush VolumeUpBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumeUpBrushSerialize.
        /// </summary>
        [DataMember]
        public String VolumeUpBrushSerialize { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
