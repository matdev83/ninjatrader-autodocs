[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class ServerBracket : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoTrail.
        /// </summary>
        [DataMember]
        public AutoTrailStep AutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StopLimit.
        /// </summary>
        [DataMember]
        public Double StopLimit { get; set; }
        /// <summary>
        /// Gets or sets the StopLoss.
        /// </summary>
        [DataMember]
        public Double StopLoss { get; set; }
        /// <summary>
        /// Gets or sets the StopLossType.
        /// </summary>
        [DataMember]
        public ServerStopLossType StopLossType { get; set; }
        /// <summary>
        /// Gets or sets the Target.
        /// </summary>
        [DataMember]
        public Double Target { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public Int32 Type { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the BreakEvenPlus.
        /// </summary>
        [DataMember]
        public Double BreakEvenPlus { get; set; }
        /// <summary>
        /// Gets or sets the BreakEvenTrigger.
        /// </summary>
        [DataMember]
        public Double BreakEvenTrigger { get; set; }
        /// <summary>
        /// Gets or sets the IsBreakeven.
        /// </summary>
        [DataMember]
        public Boolean IsBreakeven { get; set; }
        /// <summary>
        /// Gets or sets the IsStopLimit.
        /// </summary>
        [DataMember]
        public Boolean IsStopLimit { get; set; }
        /// <summary>
        /// Gets or sets the IsTrailing.
        /// </summary>
        [DataMember]
        public Boolean IsTrailing { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="strategyBracket">ServerBracket</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(ServerBracket strategyBracket);
        /// <summary>
        /// ToParamJson method.
        /// </summary>
        /// <param name="masterInstrument">MasterInstrument</param>
        /// <param name="mode">ServerCalculationMode</param>
        /// <param name="action">OrderAction</param>
        /// <returns>JsonObject</returns>
        public JsonObject ToParamJson(MasterInstrument masterInstrument, ServerCalculationMode mode, OrderAction action);
        #endregion
    }
}
