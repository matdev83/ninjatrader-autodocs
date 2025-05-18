[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CustomOrder : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAutoBreakEvenConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsAutoBreakEvenConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoChaseConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsAutoChaseConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoTrailConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsAutoTrailConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketAfterTimeConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsMarketAfterTimeConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketIfTouchedConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsMarketIfTouchedConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsSimulatedStopConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsSimulatedStopConfigured { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public String OnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Order Order { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoBreakEvenEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAutoBreakEvenEnabled { get; set; }
        /// <summary>
        /// Gets or sets the AutoBreakEvenPlus.
        /// </summary>
        [DataMember]
        public Double AutoBreakEvenPlus { get; set; }
        /// <summary>
        /// Gets or sets the AutoBreakEvenProfitTrigger.
        /// </summary>
        [DataMember]
        public Double AutoBreakEvenProfitTrigger { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode.
        /// </summary>
        [DataMember]
        public CalculationMode CalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the ChaseLimit.
        /// </summary>
        [DataMember]
        public Double ChaseLimit { get; set; }
        /// <summary>
        /// Gets or sets the IsChaseIfTouched.
        /// </summary>
        [DataMember]
        public Boolean IsChaseIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoTrailEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAutoTrailEnabled { get; set; }
        /// <summary>
        /// Gets or sets the AutoTrailSteps.
        /// </summary>
        [DataMember]
        public Collection<AutoTrailStep> AutoTrailSteps { get; set; }
        /// <summary>
        /// Gets or sets the AverageEntryPrice.
        /// </summary>
        [DataMember]
        public Double AverageEntryPrice { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketAfterTimeEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsMarketAfterTimeEnabled { get; set; }
        /// <summary>
        /// Gets or sets the MarketAfterSeconds.
        /// </summary>
        [DataMember]
        public Int32 MarketAfterSeconds { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketIfTouchedEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsMarketIfTouchedEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsSimulatedStopEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsSimulatedStopEnabled { get; set; }
        /// <summary>
        /// Gets or sets the VolumeTrigger.
        /// </summary>
        [DataMember]
        public Int32 VolumeTrigger { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoChaseEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAutoChaseEnabled { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// OnStartUp method.
        /// </summary>
        public Void OnStartUp();
        /// <summary>
        /// Update method.
        /// </summary>
        public Void Update();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ret">CustomOrder</param>
        public Void CopyTo(CustomOrder ret);
        #endregion
    }
}
