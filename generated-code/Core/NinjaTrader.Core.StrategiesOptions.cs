[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class StrategiesOptions : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the UseServerAtmSerialize.
        /// </summary>
        [DataMember]
        public bool UseServerAtmSerialize { get; set; }
        /// <summary>
        /// Gets or sets the UseServerAtm.
        /// </summary>
        [DataMember]
        public bool UseServerAtm { get; set; }
        /// <summary>
        /// Gets or sets the ModifyInnerBracket.
        /// </summary>
        [DataMember]
        public bool ModifyInnerBracket { get; set; }
        /// <summary>
        /// Gets or sets the ModifyNearestBracket.
        /// </summary>
        [DataMember]
        public bool ModifyNearestBracket { get; set; }
        /// <summary>
        /// Gets or sets the SimulatedOrderAsYellow.
        /// </summary>
        [DataMember]
        public bool SimulatedOrderAsYellow { get; set; }
        /// <summary>
        /// Gets or sets the UseLastPrice4AutoTrail.
        /// </summary>
        [DataMember]
        public bool UseLastPrice4AutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the CancelEntriesOnStrategyDisable.
        /// </summary>
        [DataMember]
        public bool CancelEntriesOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the CancelExitsOnStrategyDisable.
        /// </summary>
        [DataMember]
        public bool CancelExitsOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling.
        /// </summary>
        [DataMember]
        public ConnectionLossHandling ConnectionLossHandling { get; set; }
        /// <summary>
        /// Gets or sets the DisconnectDelaySeconds.
        /// </summary>
        [DataMember]
        public int DisconnectDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the NumberRestartAttempts.
        /// </summary>
        [DataMember]
        public int NumberRestartAttempts { get; set; }
        /// <summary>
        /// Gets or sets the RestartsWithinMinutes.
        /// </summary>
        [DataMember]
        public int RestartsWithinMinutes { get; set; }
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
        /// <param name="options">NinjaTrader.Core.StrategiesOptions</param>
        public void CopyTo(NinjaTrader.Core.StrategiesOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
