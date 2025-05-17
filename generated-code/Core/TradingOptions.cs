[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class TradingOptions : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountsChanged.
        /// </summary>
        [DataMember]
        public Boolean AccountsChanged { get; set; }
        /// <summary>
        /// Gets or sets the AutoClosePosition.
        /// </summary>
        [DataMember]
        public Boolean AutoClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the AutoClosePositionTime.
        /// </summary>
        [DataMember]
        public DateTime AutoClosePositionTime { get; set; }
        /// <summary>
        /// Gets or sets the AutoClosePositionAllInstruments.
        /// </summary>
        [DataMember]
        public Boolean AutoClosePositionAllInstruments { get; set; }
        /// <summary>
        /// Gets or sets the AutoClosePositionInstruments.
        /// </summary>
        [DataMember]
        public Instrument[] AutoClosePositionInstruments { get; set; }
        /// <summary>
        /// Gets or sets the AutoClosePositionInstrumentsSerializable.
        /// </summary>
        [DataMember]
        public String[] AutoClosePositionInstrumentsSerializable { get; set; }
        /// <summary>
        /// Gets or sets the IsGlobalSimulationMode.
        /// </summary>
        [DataMember]
        public Boolean IsGlobalSimulationMode { get; set; }
        /// <summary>
        /// Gets or sets the IsOrderEntryHotKeysEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsOrderEntryHotKeysEnabled { get; set; }
        /// <summary>
        /// Gets or sets the LocalOcoCancelBehavior.
        /// </summary>
        [DataMember]
        public LocalOcoCancelBehavior LocalOcoCancelBehavior { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the SimulationColor.
        /// </summary>
        [DataMember]
        public Brush SimulationColor { get; set; }
        /// <summary>
        /// Gets or sets the SimulationColorSerialize.
        /// </summary>
        [DataMember]
        public String SimulationColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorEnforceImmediateFills.
        /// </summary>
        [DataMember]
        public Boolean SimulatorEnforceImmediateFills { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorEnforcePartialFills.
        /// </summary>
        [DataMember]
        public Boolean SimulatorEnforcePartialFills { get; set; }
        /// <summary>
        /// Gets or sets the StartInGlobalSimulationMode.
        /// </summary>
        [DataMember]
        public Boolean StartInGlobalSimulationMode { get; set; }
        /// <summary>
        /// Gets or sets the RealizedPnlIncludesCommissions.
        /// </summary>
        [DataMember]
        public Boolean RealizedPnlIncludesCommissions { get; set; }
        /// <summary>
        /// Gets or sets the UseLastPrice4ProfitLossCalc.
        /// </summary>
        [DataMember]
        public Boolean UseLastPrice4ProfitLossCalc { get; set; }
        /// <summary>
        /// Gets or sets the IsBuySellFlipped.
        /// </summary>
        [DataMember]
        public Boolean IsBuySellFlipped { get; set; }
        /// <summary>
        /// Gets or sets the IsBuySellFlippedSerialize.
        /// </summary>
        [DataMember]
        public Boolean IsBuySellFlippedSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ConfirmOrderPlacement.
        /// </summary>
        [DataMember]
        public Boolean ConfirmOrderPlacement { get; set; }
        /// <summary>
        /// Gets or sets the PositionCloseWaitMilliSeconds.
        /// </summary>
        [DataMember]
        public Int32 PositionCloseWaitMilliSeconds { get; set; }
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
        /// <param name="options">TradingOptions</param>
        public Void CopyTo(TradingOptions options);
        /// <summary>
        /// RollInstrument method.
        /// </summary>
        /// <param name="oldInstrument">Instrument</param>
        /// <param name="newInstrument">Instrument</param>
        public Void RollInstrument(Instrument oldInstrument, Instrument newInstrument);
        /// <summary>
        /// LogAutoCloseSettings method.
        /// </summary>
        public Void LogAutoCloseSettings();
        #endregion
    }
}
