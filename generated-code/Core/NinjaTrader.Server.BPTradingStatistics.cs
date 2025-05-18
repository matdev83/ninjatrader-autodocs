[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class BPTradingStatistics
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsUpdated.
        /// </summary>
        [DataMember]
        public Boolean IsUpdated { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActive.
        /// </summary>
        [DataMember]
        public Int32 OrdersActive { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersActiveSim { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveMax.
        /// </summary>
        [DataMember]
        public Int32 OrdersActiveMax { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveMaxSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersActiveMaxSim { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveTotal.
        /// </summary>
        [DataMember]
        public Int32 OrdersActiveTotal { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveTotalSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersActiveTotalSim { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelled.
        /// </summary>
        [DataMember]
        public Int32 OrdersCancelled { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelledSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersCancelledSim { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChanged.
        /// </summary>
        [DataMember]
        public Int32 OrdersChanged { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChangedSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersChangedSim { get; set; }
        /// <summary>
        /// Gets or sets the OrdersFilled.
        /// </summary>
        [DataMember]
        public Int32 OrdersFilled { get; set; }
        /// <summary>
        /// Gets or sets the OrdersFilledSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersFilledSim { get; set; }
        /// <summary>
        /// Gets or sets the OrdersRejected.
        /// </summary>
        [DataMember]
        public Int32 OrdersRejected { get; set; }
        /// <summary>
        /// Gets or sets the OrdersRejectedSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersRejectedSim { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmitted.
        /// </summary>
        [DataMember]
        public Int32 OrdersSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmittedSim.
        /// </summary>
        [DataMember]
        public Int32 OrdersSubmittedSim { get; set; }
        /// <summary>
        /// Gets or sets the UnitsTraded.
        /// </summary>
        [DataMember]
        public Int64 UnitsTraded { get; set; }
        /// <summary>
        /// Gets or sets the UnitsTradedSim.
        /// </summary>
        [DataMember]
        public Int64 UnitsTradedSim { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
