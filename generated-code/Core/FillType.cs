[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class FillType : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BacktestPassNumber.
        /// </summary>
        [DataMember]
        public Int64 BacktestPassNumber { get; set; }
        /// <summary>
        /// Gets or sets the BarTravelPrices.
        /// </summary>
        [DataMember]
        public Double[] BarTravelPrices { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the OrderEnumerator.
        /// </summary>
        [DataMember]
        public IEnumerator<Order> OrderEnumerator { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        /// <summary>
        /// Gets or sets the Strategy.
        /// </summary>
        [DataMember]
        public StrategyBase Strategy { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="fillType">FillType</param>
        public Void CopyTo(FillType fillType);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
