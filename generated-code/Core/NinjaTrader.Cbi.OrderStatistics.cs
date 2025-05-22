[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class OrderStatistics
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelledTimed.
        /// </summary>
        [DataMember]
        public int OrdersCancelledTimed { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelledTotal.
        /// </summary>
        [DataMember]
        public int OrdersCancelledTotal { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChangedTimed.
        /// </summary>
        [DataMember]
        public int OrdersChangedTimed { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChangedTotal.
        /// </summary>
        [DataMember]
        public int OrdersChangedTotal { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmittedTimed.
        /// </summary>
        [DataMember]
        public int OrdersSubmittedTimed { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmittedTotal.
        /// </summary>
        [DataMember]
        public int OrdersSubmittedTotal { get; set; }
        /// <summary>
        /// Gets or sets the TicksCancelled.
        /// </summary>
        [DataMember]
        public long TicksCancelled { get; set; }
        /// <summary>
        /// Gets or sets the TicksChanged.
        /// </summary>
        [DataMember]
        public long TicksChanged { get; set; }
        /// <summary>
        /// Gets or sets the TicksSubmitted.
        /// </summary>
        [DataMember]
        public long TicksSubmitted { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
