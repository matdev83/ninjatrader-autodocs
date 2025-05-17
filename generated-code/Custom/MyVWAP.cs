[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MyVWAP : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the VWAPSeries.
        /// </summary>
        [DataMember]
        public Series<Double> VWAPSeries { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetVWAP method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <returns>Double</returns>
        public Double GetVWAP(Int32 barsAgo);
        #endregion
    }
}
