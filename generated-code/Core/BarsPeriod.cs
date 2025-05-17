[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsPeriod : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsPeriodType.
        /// </summary>
        [DataMember]
        public BarsPeriodType BarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeSerialize.
        /// </summary>
        [DataMember]
        public Int32 BarsPeriodTypeSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeName.
        /// </summary>
        [DataMember]
        [Obsolete]
        public String BarsPeriodTypeName { get; set; }
        /// <summary>
        /// Gets or sets the BaseBarsPeriodType.
        /// </summary>
        [DataMember]
        public BarsPeriodType BaseBarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the BaseBarsPeriodValue.
        /// </summary>
        [DataMember]
        public Int32 BaseBarsPeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricDeltaType.
        /// </summary>
        [DataMember]
        public VolumetricDeltaType VolumetricDeltaType { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType.
        /// </summary>
        [DataMember]
        public MarketDataType MarketDataType { get; set; }
        /// <summary>
        /// Gets or sets the PointAndFigurePriceType.
        /// </summary>
        [DataMember]
        public PointAndFigurePriceType PointAndFigurePriceType { get; set; }
        /// <summary>
        /// Gets or sets the ReversalType.
        /// </summary>
        [DataMember]
        public ReversalType ReversalType { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Int32 Value { get; set; }
        /// <summary>
        /// Gets or sets the Value2.
        /// </summary>
        [DataMember]
        public Int32 Value2 { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CompareTo method.
        /// </summary>
        /// <param name="value">Object</param>
        /// <returns>Int32</returns>
        public Int32 CompareTo(Object value);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object obj);
        /// <summary>
        /// FromXml method.
        /// </summary>
        /// <param name="element">XElement</param>
        /// <returns>BarsPeriod</returns>
        public BarsPeriod FromXml(XElement element);
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        /// <summary>
        /// IsRemoveLastBarSupported method.
        /// </summary>
        /// <param name="barsPeriod">BarsPeriod</param>
        /// <returns>Boolean</returns>
        public Boolean IsRemoveLastBarSupported(BarsPeriod barsPeriod);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// ToXml method.
        /// </summary>
        /// <param name="element">XElement</param>
        public Void ToXml(XElement element);
        #endregion
    }
}
