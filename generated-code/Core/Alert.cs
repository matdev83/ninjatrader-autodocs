[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class Alert : NinjaScript, IAlert, INotifyPropertyChanged
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Actions.
        /// </summary>
        [DataMember]
        public ObservableCollection<AlertAction> Actions { get; set; }
        /// <summary>
        /// Gets or sets the AlertHistory.
        /// </summary>
        [DataMember]
        public ReadOnlyDictionary<String, IEnumerable<AlertEventArgs>> AlertHistory { get; set; }
        /// <summary>
        /// Gets or sets the AlertHostType.
        /// </summary>
        [DataMember]
        public AlertHostType AlertHostType { get; set; }
        /// <summary>
        /// Gets or sets the ApplyTo.
        /// </summary>
        [DataMember]
        public String ApplyTo { get; set; }
        /// <summary>
        /// Gets or sets the Background.
        /// </summary>
        [DataMember]
        public Brush Background { get; set; }
        /// <summary>
        /// Gets or sets the BackgroundSerialize.
        /// </summary>
        [DataMember]
        public String BackgroundSerialize { get; set; }
        /// <summary>
        /// Gets or sets the CheckConditionFunc.
        /// </summary>
        [DataMember]
        public Func<Instrument, AlertCondition, Boolean> CheckConditionFunc { get; set; }
        /// <summary>
        /// Gets or sets the Conditions.
        /// </summary>
        [DataMember]
        public ObservableCollection<AlertCondition> Conditions { get; set; }
        /// <summary>
        /// Gets or sets the ConditionsOperator.
        /// </summary>
        [DataMember]
        public AlertConditionOperator ConditionsOperator { get; set; }
        /// <summary>
        /// Gets or sets the Foreground.
        /// </summary>
        [DataMember]
        public Brush Foreground { get; set; }
        /// <summary>
        /// Gets or sets the ForegroundSerialize.
        /// </summary>
        [DataMember]
        public String ForegroundSerialize { get; set; }
        /// <summary>
        /// Gets or sets the HasExternalActions.
        /// </summary>
        [DataMember]
        public Boolean HasExternalActions { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public String Id { get; set; }
        /// <summary>
        /// Gets or sets the IsDirty.
        /// </summary>
        [DataMember]
        public Boolean IsDirty { get; set; }
        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsNewBar.
        /// </summary>
        [DataMember]
        public Boolean IsNewBar { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeTriggered.
        /// </summary>
        [DataMember]
        public DateTime LastTimeTriggered { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public String Message { get; set; }
        /// <summary>
        /// Gets or sets the MessageBuilt.
        /// </summary>
        [DataMember]
        public String MessageBuilt { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the NotifyAlertsDisabled.
        /// </summary>
        [DataMember]
        public Action<Dictionary<IAlertHost, List<Alert>>> NotifyAlertsDisabled { get; set; }
        /// <summary>
        /// Gets or sets the Priority.
        /// </summary>
        [DataMember]
        public Priority Priority { get; set; }
        /// <summary>
        /// Gets or sets the RearmSeconds.
        /// </summary>
        [DataMember]
        public Int32 RearmSeconds { get; set; }
        /// <summary>
        /// Gets or sets the RearmType.
        /// </summary>
        [DataMember]
        public AlertRearmType RearmType { get; set; }
        /// <summary>
        /// Gets or sets the SupportedMessageVariablesChart.
        /// </summary>
        [DataMember]
        public String[] SupportedMessageVariablesChart { get; set; }
        /// <summary>
        /// Gets or sets the SupportedMessageVariablesMarketAnalyzer.
        /// </summary>
        [DataMember]
        public String[] SupportedMessageVariablesMarketAnalyzer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AlertCallback method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="source">Object</param>
        /// <param name="id">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="priority">Priority</param>
        /// <param name="message">String</param>
        /// <param name="soundLocation">String</param>
        /// <param name="backBrush">Brush</param>
        /// <param name="foreBrush">Brush</param>
        /// <param name="rearmSeconds">Int32</param>
        public Void AlertCallback(Instrument instrument, Object source, String id, DateTime time, Priority priority, String message, String soundLocation, Brush backBrush, Brush foreBrush, Int32 rearmSeconds);
        /// <summary>
        /// BuildBaseAlertMessage method.
        /// </summary>
        /// <param name="msg">String</param>
        /// <param name="e">AlertEventArgs</param>
        /// <returns>String</returns>
        public String BuildBaseAlertMessage(String msg, AlertEventArgs e);
        /// <summary>
        /// ClearHostReferences method.
        /// </summary>
        /// <param name="host">IAlertHost</param>
        public Void ClearHostReferences(IAlertHost host);
        /// <summary>
        /// ClearRearm method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <returns>Boolean</returns>
        public Boolean ClearRearm(Instrument instrument);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// IsWaitingRearm method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <returns>Boolean</returns>
        public Boolean IsWaitingRearm(Instrument instrument);
        /// <summary>
        /// OnNewBarOpened method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="sourceName">String</param>
        public Void OnNewBarOpened(Instrument instrument, String sourceName);
        /// <summary>
        /// RearmAlert method.
        /// </summary>
        /// <param name="id">String</param>
        public Void RearmAlert(String id);
        /// <summary>
        /// RearmAllAlerts method.
        /// </summary>
        public Void RearmAllAlerts();
        /// <summary>
        /// RegisterHost method.
        /// </summary>
        /// <param name="host">IAlertHost</param>
        public Void RegisterHost(IAlertHost host);
        /// <summary>
        /// ResetAlertHistory method.
        /// </summary>
        /// <param name="workspace">String</param>
        public Void ResetAlertHistory(String workspace);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        /// <summary>
        /// ShutdownAlertTimer method.
        /// </summary>
        public Void ShutdownAlertTimer();
        /// <summary>
        /// UnregisterHost method.
        /// </summary>
        /// <param name="host">IAlertHost</param>
        public Void UnregisterHost(IAlertHost host);
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="uiSource">Object</param>
        /// <param name="tabName">String</param>
        /// <param name="workspace">String</param>
        public Void Update(Instrument instrument, Object uiSource, String tabName, String workspace);
        /// <summary>
        /// UpdateFromChart method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="uiSource">Object</param>
        /// <param name="bars">Bars</param>
        /// <param name="tabName">String</param>
        /// <param name="workspace">String</param>
        public Void UpdateFromChart(Instrument instrument, Object uiSource, Bars bars, String tabName, String workspace);
        #endregion
    }
}
