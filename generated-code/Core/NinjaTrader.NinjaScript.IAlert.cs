namespace NinjaTrader.NinjaScript
{
    public partial interface IAlert
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Actions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.ObservableCollection<NinjaTrader.NinjaScript.AlertAction> Actions { get; set; }
        /// <summary>
        /// Gets or sets the Conditions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.ObservableCollection<NinjaTrader.NinjaScript.AlertCondition> Conditions { get; set; }
        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
