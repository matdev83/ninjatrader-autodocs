namespace NinjaTrader.NinjaScript
{
    public partial interface IDisplayNameProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DisplayNameExtended.
        /// </summary>
        [DataMember]
        public string DisplayNameExtended { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
