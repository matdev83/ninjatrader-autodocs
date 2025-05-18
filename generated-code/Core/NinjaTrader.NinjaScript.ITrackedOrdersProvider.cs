namespace NinjaTrader.NinjaScript
{
    public partial interface ITrackedOrdersProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TrackedOrders.
        /// </summary>
        [DataMember]
        public List<Order> TrackedOrders { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ClearOrderTracking method.
        /// </summary>
        public Void ClearOrderTracking();
        #endregion
    }
}
