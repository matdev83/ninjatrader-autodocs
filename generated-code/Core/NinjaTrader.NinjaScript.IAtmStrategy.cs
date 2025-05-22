namespace NinjaTrader.NinjaScript
{
    public partial interface IAtmStrategy : NinjaTrader.NinjaScript.IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AtmSelector.
        /// </summary>
        [DataMember]
        public string AtmSelector { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
