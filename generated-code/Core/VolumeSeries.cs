[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class VolumeSeries : ISeries<Double>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public Double Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetValueAt method.
        /// </summary>
        /// <param name="barIndex">Int32</param>
        /// <returns>Double</returns>
        public Double GetValueAt(Int32 barIndex);
        /// <summary>
        /// IsValidDataPoint method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPoint(Int32 barsAgo);
        /// <summary>
        /// IsValidDataPointAt method.
        /// </summary>
        /// <param name="barIndex">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPointAt(Int32 barIndex);
        #endregion
    }
}
