[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class PriceLevel : NotifyPropertyChangedBase, IStrokeProvider, ICloneable
    {
        #region Properties
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
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
        /// <summary>
        /// Gets or sets the ValueFormatFunc.
        /// </summary>
        [DataMember]
        public Func<Double, String> ValueFormatFunc { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// AssemblyClone method.
        /// </summary>
        /// <param name="t">Type</param>
        /// <returns>Object</returns>
        public Object AssemblyClone(Type t);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">PriceLevel</param>
        public Void CopyTo(PriceLevel other);
        /// <summary>
        /// GetPrice method.
        /// </summary>
        /// <param name="startPrice">Double</param>
        /// <param name="totalPriceRange">Double</param>
        /// <param name="isInverted">Boolean</param>
        /// <returns>Double</returns>
        public Double GetPrice(Double startPrice, Double totalPriceRange, Boolean isInverted);
        /// <summary>
        /// GetY method.
        /// </summary>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="startPrice">Double</param>
        /// <param name="totalPriceRange">Double</param>
        /// <param name="isInverted">Boolean</param>
        /// <returns>Single</returns>
        public Single GetY(ChartScale chartScale, Double startPrice, Double totalPriceRange, Boolean isInverted);
        #endregion
    }
}
