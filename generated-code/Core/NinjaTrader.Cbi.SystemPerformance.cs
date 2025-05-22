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
        public NinjaTrader.Cbi.TradeCollection AllTrades { get; set; }
        /// <summary>
        /// Gets or sets the Denomination.
        /// </summary>
        [DataMember]
        public Currency Denomination { get; set; }
        /// <summary>
        /// Gets or sets the LongTrades.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradeCollection LongTrades { get; set; }
        /// <summary>
        /// Gets or sets the ParameterValues.
        /// </summary>
        [DataMember]
        public System.Object[] ParameterValues { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceValue.
        /// </summary>
        [DataMember]
        public double PerformanceValue { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        /// <summary>
        /// Gets or sets the RealTimeTrades.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradeCollection RealTimeTrades { get; set; }
        /// <summary>
        /// Gets or sets the ShortTrades.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradeCollection ShortTrades { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="executions">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Execution></param>
        /// <returns>NinjaTrader.Cbi.SystemPerformance</returns>
        public NinjaTrader.Cbi.SystemPerformance Calculate(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Execution> executions)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyPerformance method.
        /// </summary>
        /// <param name="target">NinjaTrader.Cbi.SystemPerformance</param>
        public void CopyPerformance(NinjaTrader.Cbi.SystemPerformance target)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetBacktestExecutionsReverse method.
        /// </summary>
        /// <returns>System.Collections.Generic.IEnumerator<NinjaTrader.Cbi.Execution></returns>
        public System.Collections.Generic.IEnumerator<NinjaTrader.Cbi.Execution> GetBacktestExecutionsReverse()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetBacktestOrdersReverse method.
        /// </summary>
        /// <returns>System.Collections.Generic.IEnumerator<NinjaTrader.Cbi.Order></returns>
        public System.Collections.Generic.IEnumerator<NinjaTrader.Cbi.Order> GetBacktestOrdersReverse()
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
