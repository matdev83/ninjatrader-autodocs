[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class FillType : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BacktestPassNumber.
        /// </summary>
        [DataMember]
        public long BacktestPassNumber { get; set; }
        /// <summary>
        /// Gets or sets the BarTravelPrices.
        /// </summary>
        [DataMember]
        public System.Double[] BarTravelPrices { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the OrderEnumerator.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.IEnumerator<NinjaTrader.Cbi.Order> OrderEnumerator { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        /// <summary>
        /// Gets or sets the Strategy.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.StrategyBase Strategy { get; set; }
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
        /// CopyTo method.
        /// </summary>
        /// <param name="fillType">NinjaTrader.NinjaScript.FillType</param>
        public void CopyTo(NinjaTrader.NinjaScript.FillType fillType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public void SetState(State state)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
