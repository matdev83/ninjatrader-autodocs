namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial interface IPreconfiguredProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PreconfiguredNames.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<string> PreconfiguredNames { get; set; }
        /// <summary>
        /// Gets or sets the SelectedPreconfiguredSetting.
        /// </summary>
        [DataMember]
        public string SelectedPreconfiguredSetting { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplyPreconfiguredSettings method.
        /// </summary>
        /// <param name="name">string</param>
        public void ApplyPreconfiguredSettings(string name);
        #endregion
    }
}
