[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ConstantLines : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Line1.
        /// </summary>
        [DataMember]
        public Series<Double> Line1 { get; set; }
        /// <summary>
        /// Gets or sets the Line2.
        /// </summary>
        [DataMember]
        public Series<Double> Line2 { get; set; }
        /// <summary>
        /// Gets or sets the Line3.
        /// </summary>
        [DataMember]
        public Series<Double> Line3 { get; set; }
        /// <summary>
        /// Gets or sets the Line4.
        /// </summary>
        [DataMember]
        public Series<Double> Line4 { get; set; }
        /// <summary>
        /// Gets or sets the Line1Value.
        /// </summary>
        [DataMember]
        public Double Line1Value { get; set; }
        /// <summary>
        /// Gets or sets the Line2Value.
        /// </summary>
        [DataMember]
        public Double Line2Value { get; set; }
        /// <summary>
        /// Gets or sets the Line3Value.
        /// </summary>
        [DataMember]
        public Double Line3Value { get; set; }
        /// <summary>
        /// Gets or sets the Line4Value.
        /// </summary>
        [DataMember]
        public Double Line4Value { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
