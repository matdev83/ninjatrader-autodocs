[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class Stroke : NotifyPropertyChangedBase, ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Brush.
        /// </summary>
        [DataMember]
        public Brush Brush { get; set; }
        /// <summary>
        /// Gets or sets the BrushDX.
        /// </summary>
        [DataMember]
        public Brush BrushDX { get; set; }
        /// <summary>
        /// Gets or sets the BrushSerialize.
        /// </summary>
        [DataMember]
        public String BrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper.
        /// </summary>
        [DataMember]
        public DashStyleHelper DashStyleHelper { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleDX.
        /// </summary>
        [DataMember]
        public DashStyle DashStyleDX { get; set; }
        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        [DataMember]
        public Int32 Opacity { get; set; }
        /// <summary>
        /// Gets or sets the RenderTarget.
        /// </summary>
        [DataMember]
        public RenderTarget RenderTarget { get; set; }
        /// <summary>
        /// Gets or sets the StrokeStyle.
        /// </summary>
        [DataMember]
        public StrokeStyle StrokeStyle { get; set; }
        /// <summary>
        /// Gets or sets the StringFormat.
        /// </summary>
        [DataMember]
        public String StringFormat { get; set; }
        /// <summary>
        /// Gets or sets the Pen.
        /// </summary>
        [DataMember]
        public Pen Pen { get; set; }
        /// <summary>
        /// Gets or sets the Width.
        /// </summary>
        [DataMember]
        public Single Width { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AreDashStylesEqual method.
        /// </summary>
        /// <param name="ds1">DashStyle</param>
        /// <param name="ds2">DashStyle</param>
        /// <returns>Boolean</returns>
        public Boolean AreDashStylesEqual(DashStyle ds1, DashStyle ds2);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="stroke">Stroke</param>
        public Void CopyTo(Stroke stroke);
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        #endregion
    }
}
