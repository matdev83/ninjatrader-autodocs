namespace NinjaTrader.NinjaScript
{
    public partial interface IAlertHost : IConditionProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ActiveInstruments.
        /// </summary>
        [DataMember]
        public IEnumerable<Instrument> ActiveInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Alerts.
        /// </summary>
        [DataMember]
        public IList<Alert> Alerts { get; set; }
        /// <summary>
        /// Gets or sets the AlertHostType.
        /// </summary>
        [DataMember]
        public AlertHostType AlertHostType { get; set; }
        /// <summary>
        /// Gets or sets the AlertCheckConditionFunc.
        /// </summary>
        [DataMember]
        public Func<Instrument, AlertCondition, Boolean> AlertCheckConditionFunc { get; set; }
        /// <summary>
        /// Gets or sets the Workspace.
        /// </summary>
        [DataMember]
        public String Workspace { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// BuildAlertMessagePart method.
        /// </summary>
        /// <param name="variable">String</param>
        /// <param name="e">AlertEventArgs</param>
        /// <returns>String</returns>
        public String BuildAlertMessagePart(String variable, AlertEventArgs e);
        /// <summary>
        /// UpdateAllAlerts method.
        /// </summary>
        public Void UpdateAllAlerts();
        /// <summary>
        /// VerifyAlertActions method.
        /// </summary>
        /// <param name="actions">IEnumerable`1</param>
        /// <returns>Boolean</returns>
        public Boolean VerifyAlertActions(IEnumerable<AlertAction> actions);
        /// <summary>
        /// VerifyAlertConditions method.
        /// </summary>
        /// <param name="conditions">IEnumerable`1</param>
        /// <returns>Boolean</returns>
        public Boolean VerifyAlertConditions(IEnumerable<AlertCondition> conditions);
        #endregion
    }
}
