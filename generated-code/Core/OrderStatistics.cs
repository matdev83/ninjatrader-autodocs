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
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelledTimed.
        /// </summary>
        [DataMember]
        public Int32 OrdersCancelledTimed { get; set; }
        /// <summary>
        /// Gets or sets the OrdersCancelledTotal.
        /// </summary>
        [DataMember]
        public Int32 OrdersCancelledTotal { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChangedTimed.
        /// </summary>
        [DataMember]
        public Int32 OrdersChangedTimed { get; set; }
        /// <summary>
        /// Gets or sets the OrdersChangedTotal.
        /// </summary>
        [DataMember]
        public Int32 OrdersChangedTotal { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmittedTimed.
        /// </summary>
        [DataMember]
        public Int32 OrdersSubmittedTimed { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSubmittedTotal.
        /// </summary>
        [DataMember]
        public Int32 OrdersSubmittedTotal { get; set; }
        /// <summary>
        /// Gets or sets the TicksCancelled.
        /// </summary>
        [DataMember]
        public Int64 TicksCancelled { get; set; }
        /// <summary>
        /// Gets or sets the TicksChanged.
        /// </summary>
        [DataMember]
        public Int64 TicksChanged { get; set; }
        /// <summary>
        /// Gets or sets the TicksSubmitted.
        /// </summary>
        [DataMember]
        public Int64 TicksSubmitted { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
