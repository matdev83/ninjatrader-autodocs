[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class CellCondition : FilterCondition
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Background.
        /// </summary>
        [DataMember]
        public Brush Background { get; set; }
        /// <summary>
        /// Gets or sets the BackgroundSerialize.
        /// </summary>
        [DataMember]
        public String BackgroundSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Foreground.
        /// </summary>
        [DataMember]
        public Brush Foreground { get; set; }
        /// <summary>
        /// Gets or sets the ForegroundSerialize.
        /// </summary>
        [DataMember]
        public String ForegroundSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="cellCondition">CellCondition</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(CellCondition cellCondition);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
