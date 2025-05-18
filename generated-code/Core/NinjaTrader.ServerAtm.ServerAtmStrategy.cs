[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class ServerAtmStrategy : IAtmStrategy, IDisplayNameProvider, ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the AtmSelector.
        /// </summary>
        [DataMember]
        public String AtmSelector { get; set; }
        /// <summary>
        /// Gets or sets the Brackets.
        /// </summary>
        [DataMember]
        public ServerBracket[] Brackets { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode.
        /// </summary>
        [DataMember]
        public ServerCalculationMode CalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the Enabled.
        /// </summary>
        [DataMember]
        public Boolean Enabled { get; set; }
        /// <summary>
        /// Gets or sets the EntryQuantity.
        /// </summary>
        [DataMember]
        public Int32 EntryQuantity { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrument.
        /// </summary>
        [DataMember]
        public MasterInstrument MasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public String DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the OrderIds.
        /// </summary>
        [DataMember]
        public HashSet<String> OrderIds { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public Collection<Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        /// <summary>
        /// Gets or sets the StrategyId.
        /// </summary>
        [DataMember]
        public Int64 StrategyId { get; set; }
        /// <summary>
        /// Gets or sets the Template.
        /// </summary>
        [DataMember]
        public String Template { get; set; }
        /// <summary>
        /// Gets or sets the Units.
        /// </summary>
        [DataMember]
        public String Units { get; set; }
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
        /// <param name="other">ServerAtmStrategy</param>
        public Void CopyTo(ServerAtmStrategy other);
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="strategy">ServerAtmStrategy</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(ServerAtmStrategy strategy);
        /// <summary>
        /// CloseStrategy method.
        /// </summary>
        public Void CloseStrategy();
        /// <summary>
        /// Reverse method.
        /// </summary>
        /// <param name="mode">AtmStrategySelectionMode</param>
        /// <param name="tif">TimeInForce</param>
        /// <param name="expire">DateTime</param>
        public Void Reverse(AtmStrategySelectionMode mode, TimeInForce tif, DateTime expire);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        /// <summary>
        /// ToConfigJson method.
        /// </summary>
        /// <returns>JsonObject</returns>
        public JsonObject ToConfigJson();
        /// <summary>
        /// ToParamJson method.
        /// </summary>
        /// <param name="action">OrderAction</param>
        /// <returns>JsonObject</returns>
        public JsonObject ToParamJson(OrderAction action);
        #endregion
    }
}
