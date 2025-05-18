[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class GannAngle : NotifyPropertyChangedBase, IStrokeProvider, ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the RatioX.
        /// </summary>
        [DataMember]
        public Double RatioX { get; set; }
        /// <summary>
        /// Gets or sets the RatioY.
        /// </summary>
        [DataMember]
        public Double RatioY { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the IsVisible.
        /// </summary>
        [DataMember]
        public Boolean IsVisible { get; set; }
        /// <summary>
        /// Gets or sets the IsValueVisible.
        /// </summary>
        [DataMember]
        public Boolean IsValueVisible { get; set; }
        /// <summary>
        /// Gets or sets the Stroke.
        /// </summary>
        [DataMember]
        public Stroke Stroke { get; set; }
        /// <summary>
        /// Gets or sets the Tag.
        /// </summary>
        [DataMember]
        public Object Tag { get; set; }
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
        /// <param name="other">GannAngle</param>
        public Void CopyTo(GannAngle other);
        #endregion
    }
}
