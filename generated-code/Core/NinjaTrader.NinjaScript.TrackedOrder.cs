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
        public Boolean IsTrailMode { get; set; }
        /// <summary>
        /// Gets or sets the OffsetTicks.
        /// </summary>
        [DataMember]
        public Int32 OffsetTicks { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Order Order { get; set; }
        /// <summary>
        /// Gets or sets the Plot.
        /// </summary>
        [DataMember]
        public Int32 Plot { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
