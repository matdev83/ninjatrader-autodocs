namespace NinjaTrader.NinjaScript
{
    public partial interface IAlert
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Actions.
        /// </summary>
        [DataMember]
        public ObservableCollection<AlertAction> Actions { get; set; }
        /// <summary>
        /// Gets or sets the Conditions.
        /// </summary>
        [DataMember]
        public ObservableCollection<AlertCondition> Conditions { get; set; }
        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
