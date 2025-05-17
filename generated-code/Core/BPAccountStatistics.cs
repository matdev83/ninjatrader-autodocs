[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class BPAccountStatistics
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
        /// Gets or sets the OrdersActiveMax.
        /// </summary>
        [DataMember]
        public Int32 OrdersActiveMax { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveTotal.
        /// </summary>
        [DataMember]
        public Int32 OrdersActiveTotal { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelled.
        /// </summary>
        [DataMember]
        public Int32 OrdersCancelled { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChanged.
        /// </summary>
        [DataMember]
        public Int32 OrdersChanged { get; set; }
        /// <summary>
        /// Gets or sets the OrdersFilled.
        /// </summary>
        [DataMember]
        public Int32 OrdersFilled { get; set; }
        /// <summary>
        /// Gets or sets the OrdersRejected.
        /// </summary>
        [DataMember]
        public Int32 OrdersRejected { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmitted.
        /// </summary>
        [DataMember]
        public Int32 OrdersSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the UnitsTraded.
        /// </summary>
        [DataMember]
        public Int64 UnitsTraded { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
