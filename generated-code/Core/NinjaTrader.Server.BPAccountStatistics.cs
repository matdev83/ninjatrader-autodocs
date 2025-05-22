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
        public bool IsUpdated { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActive.
        /// </summary>
        [DataMember]
        public int OrdersActive { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveMax.
        /// </summary>
        [DataMember]
        public int OrdersActiveMax { get; set; }
        /// <summary>
        /// Gets or sets the OrdersActiveTotal.
        /// </summary>
        [DataMember]
        public int OrdersActiveTotal { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelled.
        /// </summary>
        [DataMember]
        public int OrdersCancelled { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChanged.
        /// </summary>
        [DataMember]
        public int OrdersChanged { get; set; }
        /// <summary>
        /// Gets or sets the OrdersFilled.
        /// </summary>
        [DataMember]
        public int OrdersFilled { get; set; }
        /// <summary>
        /// Gets or sets the OrdersRejected.
        /// </summary>
        [DataMember]
        public int OrdersRejected { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmitted.
        /// </summary>
        [DataMember]
        public int OrdersSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the UnitsTraded.
        /// </summary>
        [DataMember]
        public long UnitsTraded { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
