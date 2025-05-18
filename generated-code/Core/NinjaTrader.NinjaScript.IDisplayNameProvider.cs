namespace NinjaTrader.NinjaScript
{
    public partial interface IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public String DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
