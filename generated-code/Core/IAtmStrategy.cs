namespace NinjaTrader.NinjaScript
{
    public partial interface IAtmStrategy : IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AtmSelector.
        /// </summary>
        [DataMember]
        public String AtmSelector { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
