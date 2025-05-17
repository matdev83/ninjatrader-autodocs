[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class StrategiesOptions : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the UseServerAtmSerialize.
        /// </summary>
        [DataMember]
        public Boolean UseServerAtmSerialize { get; set; }
        /// <summary>
        /// Gets or sets the UseServerAtm.
        /// </summary>
        [DataMember]
        public Boolean UseServerAtm { get; set; }
        /// <summary>
        /// Gets or sets the ModifyInnerBracket.
        /// </summary>
        [DataMember]
        public Boolean ModifyInnerBracket { get; set; }
        /// <summary>
        /// Gets or sets the ModifyNearestBracket.
        /// </summary>
        [DataMember]
        public Boolean ModifyNearestBracket { get; set; }
        /// <summary>
        /// Gets or sets the SimulatedOrderAsYellow.
        /// </summary>
        [DataMember]
        public Boolean SimulatedOrderAsYellow { get; set; }
        /// <summary>
        /// Gets or sets the UseLastPrice4AutoTrail.
        /// </summary>
        [DataMember]
        public Boolean UseLastPrice4AutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the CancelEntriesOnStrategyDisable.
        /// </summary>
        [DataMember]
        public Boolean CancelEntriesOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the CancelExitsOnStrategyDisable.
        /// </summary>
        [DataMember]
        public Boolean CancelExitsOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling.
        /// </summary>
        [DataMember]
        public ConnectionLossHandling ConnectionLossHandling { get; set; }
        /// <summary>
        /// Gets or sets the DisconnectDelaySeconds.
        /// </summary>
        [DataMember]
        public Int32 DisconnectDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the NumberRestartAttempts.
        /// </summary>
        [DataMember]
        public Int32 NumberRestartAttempts { get; set; }
        /// <summary>
        /// Gets or sets the RestartsWithinMinutes.
        /// </summary>
        [DataMember]
        public Int32 RestartsWithinMinutes { get; set; }
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
        /// <param name="options">StrategiesOptions</param>
        public Void CopyTo(StrategiesOptions options);
        #endregion
    }
}
