[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CustomOrder : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAutoBreakEvenConfigured.
        /// </summary>
        [DataMember]
        public bool IsAutoBreakEvenConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoChaseConfigured.
        /// </summary>
        [DataMember]
        public bool IsAutoChaseConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoTrailConfigured.
        /// </summary>
        [DataMember]
        public bool IsAutoTrailConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketAfterTimeConfigured.
        /// </summary>
        [DataMember]
        public bool IsMarketAfterTimeConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketIfTouchedConfigured.
        /// </summary>
        [DataMember]
        public bool IsMarketIfTouchedConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsSimulatedStopConfigured.
        /// </summary>
        [DataMember]
        public bool IsSimulatedStopConfigured { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public string OnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Order Order { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoBreakEvenEnabled.
        /// </summary>
        [DataMember]
        public bool IsAutoBreakEvenEnabled { get; set; }
        /// <summary>
        /// Gets or sets the AutoBreakEvenPlus.
        /// </summary>
        [DataMember]
        public double AutoBreakEvenPlus { get; set; }
        /// <summary>
        /// Gets or sets the AutoBreakEvenProfitTrigger.
        /// </summary>
        [DataMember]
        public double AutoBreakEvenProfitTrigger { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode.
        /// </summary>
        [DataMember]
        public CalculationMode CalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the ChaseLimit.
        /// </summary>
        [DataMember]
        public double ChaseLimit { get; set; }
        /// <summary>
        /// Gets or sets the IsChaseIfTouched.
        /// </summary>
        [DataMember]
        public bool IsChaseIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoTrailEnabled.
        /// </summary>
        [DataMember]
        public bool IsAutoTrailEnabled { get; set; }
        /// <summary>
        /// Gets or sets the AutoTrailSteps.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.AutoTrailStep> AutoTrailSteps { get; set; }
        /// <summary>
        /// Gets or sets the AverageEntryPrice.
        /// </summary>
        [DataMember]
        public double AverageEntryPrice { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketAfterTimeEnabled.
        /// </summary>
        [DataMember]
        public bool IsMarketAfterTimeEnabled { get; set; }
        /// <summary>
        /// Gets or sets the MarketAfterSeconds.
        /// </summary>
        [DataMember]
        public int MarketAfterSeconds { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketIfTouchedEnabled.
        /// </summary>
        [DataMember]
        public bool IsMarketIfTouchedEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsSimulatedStopEnabled.
        /// </summary>
        [DataMember]
        public bool IsSimulatedStopEnabled { get; set; }
        /// <summary>
        /// Gets or sets the VolumeTrigger.
        /// </summary>
        [DataMember]
        public int VolumeTrigger { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoChaseEnabled.
        /// </summary>
        [DataMember]
        public bool IsAutoChaseEnabled { get; set; }
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
        /// OnStartUp method.
        /// </summary>
        public void OnStartUp()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Update method.
        /// </summary>
        public void Update()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ret">NinjaTrader.Cbi.CustomOrder</param>
        public void CopyTo(NinjaTrader.Cbi.CustomOrder ret)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
