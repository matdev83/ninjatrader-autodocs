[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Swing : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Strength.
        /// </summary>
        [DataMember]
        public Int32 Strength { get; set; }
        /// <summary>
        /// Gets or sets the SwingHigh.
        /// </summary>
        [DataMember]
        public Series<Double> SwingHigh { get; set; }
        /// <summary>
        /// Gets or sets the SwingLow.
        /// </summary>
        [DataMember]
        public Series<Double> SwingLow { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// SwingLowBar method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <param name="instance">Int32</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Int32</returns>
        public Int32 SwingLowBar(Int32 barsAgo, Int32 instance, Int32 lookBackPeriod);
        /// <summary>
        /// SwingHighBar method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <param name="instance">Int32</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Int32</returns>
        public Int32 SwingHighBar(Int32 barsAgo, Int32 instance, Int32 lookBackPeriod);
        #endregion
    }
}
