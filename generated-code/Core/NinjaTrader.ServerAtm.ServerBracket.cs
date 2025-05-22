[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class ServerBracket : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoTrail.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.AutoTrailStep AutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StopLimit.
        /// </summary>
        [DataMember]
        public double StopLimit { get; set; }
        /// <summary>
        /// Gets or sets the StopLoss.
        /// </summary>
        [DataMember]
        public double StopLoss { get; set; }
        /// <summary>
        /// Gets or sets the StopLossType.
        /// </summary>
        [DataMember]
        public ServerStopLossType StopLossType { get; set; }
        /// <summary>
        /// Gets or sets the Target.
        /// </summary>
        [DataMember]
        public double Target { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public int Type { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the BreakEvenPlus.
        /// </summary>
        [DataMember]
        public double BreakEvenPlus { get; set; }
        /// <summary>
        /// Gets or sets the BreakEvenTrigger.
        /// </summary>
        [DataMember]
        public double BreakEvenTrigger { get; set; }
        /// <summary>
        /// Gets or sets the IsBreakeven.
        /// </summary>
        [DataMember]
        public bool IsBreakeven { get; set; }
        /// <summary>
        /// Gets or sets the IsStopLimit.
        /// </summary>
        [DataMember]
        public bool IsStopLimit { get; set; }
        /// <summary>
        /// Gets or sets the IsTrailing.
        /// </summary>
        [DataMember]
        public bool IsTrailing { get; set; }
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
        /// IsEqual method.
        /// </summary>
        /// <param name="strategyBracket">NinjaTrader.ServerAtm.ServerBracket</param>
        /// <returns>bool</returns>
        public bool IsEqual(NinjaTrader.ServerAtm.ServerBracket strategyBracket)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToParamJson method.
        /// </summary>
        /// <param name="masterInstrument">NinjaTrader.Cbi.MasterInstrument</param>
        /// <param name="mode">ServerCalculationMode</param>
        /// <param name="action">OrderAction</param>
        /// <returns>System.Text.Json.Nodes.JsonObject</returns>
        public System.Text.Json.Nodes.JsonObject ToParamJson(NinjaTrader.Cbi.MasterInstrument masterInstrument, ServerCalculationMode mode, OrderAction action)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
