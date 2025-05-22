[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class TrackedOrder
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsTrailMode.
        /// </summary>
        [DataMember]
        public bool IsTrailMode { get; set; }
        /// <summary>
        /// Gets or sets the OffsetTicks.
        /// </summary>
        [DataMember]
        public int OffsetTicks { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Order Order { get; set; }
        /// <summary>
        /// Gets or sets the Plot.
        /// </summary>
        [DataMember]
        public int Plot { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
