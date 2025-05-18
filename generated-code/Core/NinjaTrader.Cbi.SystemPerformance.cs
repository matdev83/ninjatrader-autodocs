[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SystemPerformance
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AllTrades.
        /// </summary>
        [DataMember]
        public TradeCollection AllTrades { get; set; }
        /// <summary>
        /// Gets or sets the Denomination.
        /// </summary>
        [DataMember]
        public Currency Denomination { get; set; }
        /// <summary>
        /// Gets or sets the LongTrades.
        /// </summary>
        [DataMember]
        public TradeCollection LongTrades { get; set; }
        /// <summary>
        /// Gets or sets the ParameterValues.
        /// </summary>
        [DataMember]
        public Object[] ParameterValues { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceValue.
        /// </summary>
        [DataMember]
        public Double PerformanceValue { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        /// <summary>
        /// Gets or sets the RealTimeTrades.
        /// </summary>
        [DataMember]
        public TradeCollection RealTimeTrades { get; set; }
        /// <summary>
        /// Gets or sets the ShortTrades.
        /// </summary>
        [DataMember]
        public TradeCollection ShortTrades { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="executions">ICollection`1</param>
        /// <returns>SystemPerformance</returns>
        public SystemPerformance Calculate(ICollection<Execution> executions);
        /// <summary>
        /// CopyPerformance method.
        /// </summary>
        /// <param name="target">SystemPerformance</param>
        public Void CopyPerformance(SystemPerformance target);
        /// <summary>
        /// GetBacktestExecutionsReverse method.
        /// </summary>
        /// <returns>IEnumerator`1</returns>
        public IEnumerator<Execution> GetBacktestExecutionsReverse();
        /// <summary>
        /// GetBacktestOrdersReverse method.
        /// </summary>
        /// <returns>IEnumerator`1</returns>
        public IEnumerator<Order> GetBacktestOrdersReverse();
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
