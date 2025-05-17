[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class NetChangeDisplay : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the NetChange.
        /// </summary>
        [DataMember]
        public Double NetChange { get; set; }
        /// <summary>
        /// Gets or sets the Unit.
        /// </summary>
        [DataMember]
        public PerformanceUnit Unit { get; set; }
        /// <summary>
        /// Gets or sets the PositiveBrush.
        /// </summary>
        [DataMember]
        public Brush PositiveBrush { get; set; }
        /// <summary>
        /// Gets or sets the PositiveBrushSerialize.
        /// </summary>
        [DataMember]
        public String PositiveBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the NegativeBrush.
        /// </summary>
        [DataMember]
        public Brush NegativeBrush { get; set; }
        /// <summary>
        /// Gets or sets the NegativeBrushSerialize.
        /// </summary>
        [DataMember]
        public String NegativeBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Location.
        /// </summary>
        [DataMember]
        public NetChangePosition Location { get; set; }
        /// <summary>
        /// Gets or sets the Font.
        /// </summary>
        [DataMember]
        public SimpleFont Font { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// FormatValue method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String FormatValue(Double value);
        #endregion
    }
}
