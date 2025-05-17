namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial interface IPreconfiguredProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PreconfiguredNames.
        /// </summary>
        [DataMember]
        public List<String> PreconfiguredNames { get; set; }
        /// <summary>
        /// Gets or sets the SelectedPreconfiguredSetting.
        /// </summary>
        [DataMember]
        public String SelectedPreconfiguredSetting { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplyPreconfiguredSettings method.
        /// </summary>
        /// <param name="name">String</param>
        public Void ApplyPreconfiguredSettings(String name);
        #endregion
    }
}
