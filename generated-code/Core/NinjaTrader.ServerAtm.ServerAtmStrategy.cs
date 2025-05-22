[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class ServerAtmStrategy : NinjaTrader.NinjaScript.IAtmStrategy, NinjaTrader.NinjaScript.IDisplayNameProvider, System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the AtmSelector.
        /// </summary>
        [DataMember]
        public string AtmSelector { get; set; }
        /// <summary>
        /// Gets or sets the Brackets.
        /// </summary>
        [DataMember]
        public NinjaTrader.ServerAtm.ServerBracket[] Brackets { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode.
        /// </summary>
        [DataMember]
        public ServerCalculationMode CalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the Enabled.
        /// </summary>
        [DataMember]
        public bool Enabled { get; set; }
        /// <summary>
        /// Gets or sets the EntryQuantity.
        /// </summary>
        [DataMember]
        public int EntryQuantity { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.MasterInstrument MasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public string DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the OrderIds.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.HashSet<string> OrderIds { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        /// <summary>
        /// Gets or sets the StrategyId.
        /// </summary>
        [DataMember]
        public long StrategyId { get; set; }
        /// <summary>
        /// Gets or sets the Template.
        /// </summary>
        [DataMember]
        public string Template { get; set; }
        /// <summary>
        /// Gets or sets the Units.
        /// </summary>
        [DataMember]
        public string Units { get; set; }
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
        /// <param name="other">NinjaTrader.ServerAtm.ServerAtmStrategy</param>
        public void CopyTo(NinjaTrader.ServerAtm.ServerAtmStrategy other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="strategy">NinjaTrader.ServerAtm.ServerAtmStrategy</param>
        /// <returns>bool</returns>
        public bool IsEqual(NinjaTrader.ServerAtm.ServerAtmStrategy strategy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CloseStrategy method.
        /// </summary>
        public void CloseStrategy()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reverse method.
        /// </summary>
        /// <param name="mode">AtmStrategySelectionMode</param>
        /// <param name="tif">TimeInForce</param>
        /// <param name="expire">System.DateTime</param>
        public void Reverse(AtmStrategySelectionMode mode, TimeInForce tif, System.DateTime expire)
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
        /// <summary>
        /// ToConfigJson method.
        /// </summary>
        /// <returns>System.Text.Json.Nodes.JsonObject</returns>
        public System.Text.Json.Nodes.JsonObject ToConfigJson()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToParamJson method.
        /// </summary>
        /// <param name="action">OrderAction</param>
        /// <returns>System.Text.Json.Nodes.JsonObject</returns>
        public System.Text.Json.Nodes.JsonObject ToParamJson(OrderAction action)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
