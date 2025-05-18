[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class PathToolSegment : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EndAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor EndAnchor { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the StartAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor StartAnchor { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AssemblyClone method.
        /// </summary>
        /// <param name="t">Type</param>
        /// <returns>Object</returns>
        public Object AssemblyClone(Type t);
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">PathToolSegment</param>
        public Void CopyTo(PathToolSegment other);
        #endregion
    }
}
