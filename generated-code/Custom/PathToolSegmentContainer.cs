[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class PathToolSegmentContainer : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PathToolSegments.
        /// </summary>
        [DataMember]
        public List<PathToolSegment> PathToolSegments { get; set; }
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
