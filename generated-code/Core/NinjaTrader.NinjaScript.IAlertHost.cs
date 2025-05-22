namespace NinjaTrader.NinjaScript
{
    public partial interface IAlertHost : NinjaTrader.NinjaScript.IConditionProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ActiveInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Instrument> ActiveInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Alerts.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.IList<NinjaTrader.NinjaScript.Alert> Alerts { get; set; }
        /// <summary>
        /// Gets or sets the AlertHostType.
        /// </summary>
        [DataMember]
        public AlertHostType AlertHostType { get; set; }
        /// <summary>
        /// Gets or sets the AlertCheckConditionFunc.
        /// </summary>
        [DataMember]
        public System.Func<NinjaTrader.Cbi.Instrument, NinjaTrader.NinjaScript.AlertCondition, bool> AlertCheckConditionFunc { get; set; }
        /// <summary>
        /// Gets or sets the Workspace.
        /// </summary>
        [DataMember]
        public string Workspace { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// BuildAlertMessagePart method.
        /// </summary>
        /// <param name="variable">string</param>
        /// <param name="e">NinjaTrader.NinjaScript.AlertEventArgs</param>
        /// <returns>string</returns>
        public string BuildAlertMessagePart(string variable, NinjaTrader.NinjaScript.AlertEventArgs e);
        /// <summary>
        /// UpdateAllAlerts method.
        /// </summary>
        public void UpdateAllAlerts();
        /// <summary>
        /// VerifyAlertActions method.
        /// </summary>
        /// <param name="actions">System.Collections.Generic.IEnumerable<NinjaTrader.NinjaScript.AlertAction></param>
        /// <returns>bool</returns>
        public bool VerifyAlertActions(System.Collections.Generic.IEnumerable<NinjaTrader.NinjaScript.AlertAction> actions);
        /// <summary>
        /// VerifyAlertConditions method.
        /// </summary>
        /// <param name="conditions">System.Collections.Generic.IEnumerable<NinjaTrader.NinjaScript.AlertCondition></param>
        /// <returns>bool</returns>
        public bool VerifyAlertConditions(System.Collections.Generic.IEnumerable<NinjaTrader.NinjaScript.AlertCondition> conditions);
        #endregion
    }
}
