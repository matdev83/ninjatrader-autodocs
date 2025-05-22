[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsPeriod : System.ICloneable
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
        public int BarsPeriodTypeSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeName.
        /// </summary>
        [DataMember]
        [Obsolete]
        public string BarsPeriodTypeName { get; set; }
        /// <summary>
        /// Gets or sets the BaseBarsPeriodType.
        /// </summary>
        [DataMember]
        public BarsPeriodType BaseBarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the BaseBarsPeriodValue.
        /// </summary>
        [DataMember]
        public int BaseBarsPeriodValue { get; set; }
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
        public int Value { get; set; }
        /// <summary>
        /// Gets or sets the Value2.
        /// </summary>
        [DataMember]
        public int Value2 { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CompareTo method.
        /// </summary>
        /// <param name="value">object</param>
        /// <returns>int</returns>
        public int CompareTo(object value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public bool Equals(object obj)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FromXml method.
        /// </summary>
        /// <param name="element">System.Xml.Linq.XElement</param>
        /// <returns>NinjaTrader.Data.BarsPeriod</returns>
        public NinjaTrader.Data.BarsPeriod FromXml(System.Xml.Linq.XElement element)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>int</returns>
        public int GetHashCode()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsRemoveLastBarSupported method.
        /// </summary>
        /// <param name="barsPeriod">NinjaTrader.Data.BarsPeriod</param>
        /// <returns>bool</returns>
        public bool IsRemoveLastBarSupported(NinjaTrader.Data.BarsPeriod barsPeriod)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToXml method.
        /// </summary>
        /// <param name="element">System.Xml.Linq.XElement</param>
        public void ToXml(System.Xml.Linq.XElement element)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
