namespace NinjaTrader.NinjaScript
{
    public partial interface ITrackedOrdersProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TrackedOrders.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Cbi.Order> TrackedOrders { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ClearOrderTracking method.
        /// </summary>
        public void ClearOrderTracking();
        #endregion
    }
}
