[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class FXTile : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HighlightDuration.
        /// </summary>
        [DataMember]
        public Int32 HighlightDuration { get; set; }
        /// <summary>
        /// Gets or sets the TileSize.
        /// </summary>
        [DataMember]
        public FxBoardTileSize TileSize { get; set; }
        /// <summary>
        /// Gets or sets the ButtonBackground.
        /// </summary>
        [DataMember]
        public Brush ButtonBackground { get; set; }
        /// <summary>
        /// Gets or sets the ButtonBackgroundSeralizer.
        /// </summary>
        [DataMember]
        public String ButtonBackgroundSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the ButtonForeground.
        /// </summary>
        [DataMember]
        public Brush ButtonForeground { get; set; }
        /// <summary>
        /// Gets or sets the ButtonForegroundSeralizer.
        /// </summary>
        [DataMember]
        public String ButtonForegroundSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the DownTickBackground.
        /// </summary>
        [DataMember]
        public Brush DownTickBackground { get; set; }
        /// <summary>
        /// Gets or sets the DownTickBackgroundSeralizer.
        /// </summary>
        [DataMember]
        public String DownTickBackgroundSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the DownTickForeground.
        /// </summary>
        [DataMember]
        public Brush DownTickForeground { get; set; }
        /// <summary>
        /// Gets or sets the DownTickForegroundSeralizer.
        /// </summary>
        [DataMember]
        public String DownTickForegroundSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the UpTickBackground.
        /// </summary>
        [DataMember]
        public Brush UpTickBackground { get; set; }
        /// <summary>
        /// Gets or sets the UpTickBackgroundSeralizer.
        /// </summary>
        [DataMember]
        public String UpTickBackgroundSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the UpTickForeground.
        /// </summary>
        [DataMember]
        public Brush UpTickForeground { get; set; }
        /// <summary>
        /// Gets or sets the UpTickForegroundSeralizer.
        /// </summary>
        [DataMember]
        public String UpTickForegroundSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the Top.
        /// </summary>
        [DataMember]
        public Double Top { get; set; }
        /// <summary>
        /// Gets or sets the Left.
        /// </summary>
        [DataMember]
        public Double Left { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        #endregion
    }
}
