[Serializable]
[DataContract]
namespace NinjaTrader
{
    public partial class Resource
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ResourceManager.
        /// </summary>
        [DataMember]
        public System.Resources.ResourceManager ResourceManager { get; set; }
        /// <summary>
        /// Gets or sets the Culture.
        /// </summary>
        [DataMember]
        public System.Globalization.CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAccountStartException.
        /// </summary>
        [DataMember]
        public string AdapterAccountStartException { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAccountStopException.
        /// </summary>
        [DataMember]
        public string AdapterAccountStopException { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAdapterProxyBufferOverflow.
        /// </summary>
        [DataMember]
        public string AdapterAdapterProxyBufferOverflow { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAdapterProxyHeartbeatTimeout.
        /// </summary>
        [DataMember]
        public string AdapterAdapterProxyHeartbeatTimeout { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAdapterProxySerialize.
        /// </summary>
        [DataMember]
        public string AdapterAdapterProxySerialize { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterCantConnectToDS.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterCantConnectToDS { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterCantConnectToEndPoint.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterCantConnectToEndPoint { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterConnect.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterConnect { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterInvalidAccount.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterInvalidAccount { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterInvalidEmail.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterInvalidEmail { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterInvalidOrder.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterInvalidOrder { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterLostConnectionToHds.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterLostConnectionToHds { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterNoRealtimeDataConnection.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterNoRealtimeDataConnection { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterSslError.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterSslError { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterTooMuchWorkspaceData.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterTooMuchWorkspaceData { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterUnableToResolveInstrument.
        /// </summary>
        [DataMember]
        public string AdapterClientAdapterUnableToResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the AdapterConnectRunAsProcessNotSupported.
        /// </summary>
        [DataMember]
        public string AdapterConnectRunAsProcessNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the AdapterGatewayAdapterException.
        /// </summary>
        [DataMember]
        public string AdapterGatewayAdapterException { get; set; }
        /// <summary>
        /// Gets or sets the AdapterGatewayAdapterNumConnections.
        /// </summary>
        [DataMember]
        public string AdapterGatewayAdapterNumConnections { get; set; }
        /// <summary>
        /// Gets or sets the AdapterHistoricalLoadingMessage.
        /// </summary>
        [DataMember]
        public string AdapterHistoricalLoadingMessage { get; set; }
        /// <summary>
        /// Gets or sets the AdapterISVSimulatorOnOnlyGW.
        /// </summary>
        [DataMember]
        public string AdapterISVSimulatorOnOnlyGW { get; set; }
        /// <summary>
        /// Gets or sets the AdapterPlaybackAdapterInit.
        /// </summary>
        [DataMember]
        public string AdapterPlaybackAdapterInit { get; set; }
        /// <summary>
        /// Gets or sets the AdapterSimulationAdapterNewsHeadline.
        /// </summary>
        [DataMember]
        public string AdapterSimulationAdapterNewsHeadline { get; set; }
        /// <summary>
        /// Gets or sets the AdapterSimulationAdapterNewsStory.
        /// </summary>
        [DataMember]
        public string AdapterSimulationAdapterNewsStory { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationAccessIsDenied.
        /// </summary>
        [DataMember]
        public string AuthenticationAccessIsDenied { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationNoAccountsFound.
        /// </summary>
        [DataMember]
        public string AuthenticationNoAccountsFound { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationServerNotAvailable.
        /// </summary>
        [DataMember]
        public string AuthenticationServerNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationTimePenaltyLogin.
        /// </summary>
        [DataMember]
        public string AuthenticationTimePenaltyLogin { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccount.
        /// </summary>
        [DataMember]
        public string CbiAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountAtmNotAllowed.
        /// </summary>
        [DataMember]
        public string CbiAccountAtmNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountAutoClose1.
        /// </summary>
        [DataMember]
        public string CbiAccountAutoClose1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountAutoClose2.
        /// </summary>
        [DataMember]
        public string CbiAccountAutoClose2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancel.
        /// </summary>
        [DataMember]
        public string CbiAccountCancel { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelAllOrders.
        /// </summary>
        [DataMember]
        public string CbiAccountCancelAllOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelException.
        /// </summary>
        [DataMember]
        public string CbiAccountCancelException { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelGlobalSimulation.
        /// </summary>
        [DataMember]
        public string CbiAccountCancelGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelNotAllowed.
        /// </summary>
        [DataMember]
        public string CbiAccountCancelNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelNotConnected.
        /// </summary>
        [DataMember]
        public string CbiAccountCancelNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelSimulatedMITAlreadySubmitted.
        /// </summary>
        [DataMember]
        public string CbiAccountCancelSimulatedMITAlreadySubmitted { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelSimulationOnly.
        /// </summary>
        [DataMember]
        public string CbiAccountCancelSimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange.
        /// </summary>
        [DataMember]
        public string CbiAccountChange { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange10.
        /// </summary>
        [DataMember]
        public string CbiAccountChange10 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange11.
        /// </summary>
        [DataMember]
        public string CbiAccountChange11 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange12.
        /// </summary>
        [DataMember]
        public string CbiAccountChange12 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange13.
        /// </summary>
        [DataMember]
        public string CbiAccountChange13 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange14.
        /// </summary>
        [DataMember]
        public string CbiAccountChange14 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange15.
        /// </summary>
        [DataMember]
        public string CbiAccountChange15 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange2.
        /// </summary>
        [DataMember]
        public string CbiAccountChange2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange3.
        /// </summary>
        [DataMember]
        public string CbiAccountChange3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange4.
        /// </summary>
        [DataMember]
        public string CbiAccountChange4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange6.
        /// </summary>
        [DataMember]
        public string CbiAccountChange6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange7.
        /// </summary>
        [DataMember]
        public string CbiAccountChange7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange8.
        /// </summary>
        [DataMember]
        public string CbiAccountChange8 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange9.
        /// </summary>
        [DataMember]
        public string CbiAccountChange9 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeException.
        /// </summary>
        [DataMember]
        public string CbiAccountChangeException { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeGlobalSimulation.
        /// </summary>
        [DataMember]
        public string CbiAccountChangeGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeNotAllowed.
        /// </summary>
        [DataMember]
        public string CbiAccountChangeNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeNotConnected.
        /// </summary>
        [DataMember]
        public string CbiAccountChangeNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeSimulationOnly.
        /// </summary>
        [DataMember]
        public string CbiAccountChangeSimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCreateOrderNoLiveOrders.
        /// </summary>
        [DataMember]
        public string CbiAccountCreateOrderNoLiveOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountExecutionNull.
        /// </summary>
        [DataMember]
        public string CbiAccountExecutionNull { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountExecutionNull_Duplicate_1_.
        /// </summary>
        [DataMember]
        public string CbiAccountExecutionNull_Duplicate_1_ { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountFlatten.
        /// </summary>
        [DataMember]
        public string CbiAccountFlatten { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountFlattenEverything.
        /// </summary>
        [DataMember]
        public string CbiAccountFlattenEverything { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountOcoCancelOnBehalfOf.
        /// </summary>
        [DataMember]
        public string CbiAccountOcoCancelOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountOcoChangeOnBehalfOf.
        /// </summary>
        [DataMember]
        public string CbiAccountOcoChangeOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountOnMaterialized.
        /// </summary>
        [DataMember]
        public string CbiAccountOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessOrderStatusArgsError.
        /// </summary>
        [DataMember]
        public string CbiAccountProcessOrderStatusArgsError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessOrderStatusEventArgs.
        /// </summary>
        [DataMember]
        public string CbiAccountProcessOrderStatusEventArgs { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessOrderStatusEventArgs2.
        /// </summary>
        [DataMember]
        public string CbiAccountProcessOrderStatusEventArgs2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessPositionUpdateEventArgs.
        /// </summary>
        [DataMember]
        public string CbiAccountProcessPositionUpdateEventArgs { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountRestore2.
        /// </summary>
        [DataMember]
        public string CbiAccountRestore2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountRestore3.
        /// </summary>
        [DataMember]
        public string CbiAccountRestore3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountRestoreStrategy.
        /// </summary>
        [DataMember]
        public string CbiAccountRestoreStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSimulatedGtd.
        /// </summary>
        [DataMember]
        public string CbiAccountSimulatedGtd { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSimulationAccountReset.
        /// </summary>
        [DataMember]
        public string CbiAccountSimulationAccountReset { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit10.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit10 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit11.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit11 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit12.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit12 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit13.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit13 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit15.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit15 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit16.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit16 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit17.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit17 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit18.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit18 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit19.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit19 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit2.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit20.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit20 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit21.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit21 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit22.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit22 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit23.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit23 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit24.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit24 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit25.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit25 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit3.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit4.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit5.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit6.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit7.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit8.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit8 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit9.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmit9 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitException.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmitException { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitGlobalSimulation.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmitGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitIsFreeEdition.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmitIsFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitIsFreeEditionMIT.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmitIsFreeEditionMIT { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitNotAllowed.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmitNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitNotConnected.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmitNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitSimulationOnly.
        /// </summary>
        [DataMember]
        public string CbiAccountSubmitSimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountUnableToCreateOrder.
        /// </summary>
        [DataMember]
        public string CbiAccountUnableToCreateOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoChase.
        /// </summary>
        [DataMember]
        public string CbiAutoChase { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeAccountNotConnected.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeAccountNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeConnectionStatusError.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeConnectionStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeDeleteError.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeDeleteError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeEntryOrderQuantity.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeEntryOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidAction.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeInvalidAction { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidLimitPrice.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeInvalidLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidOrderID.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeInvalidOrderID { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidOrderType.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeInvalidOrderType { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidQuantity.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeInvalidQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidStopPrice.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeInvalidStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidTif.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeInvalidTif { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeLineReadError.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeLineReadError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNoEntryOrderFilled.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeNoEntryOrderFilled { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNoOrderID.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeNoOrderID { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNoSuchOrder.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeNoSuchOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNumParameters.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeNumParameters { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeOrderCantBeChanged.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeOrderCantBeChanged { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeOrderQuantity.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeOrderStatusError.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeOrderStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradePositionStatusError.
        /// </summary>
        [DataMember]
        public string CbiAutoTradePositionStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeProcessing.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeProcessing { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeProcessingATI.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeProcessingATI { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeReadError.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeReadError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTraderUnkonwOifType.
        /// </summary>
        [DataMember]
        public string CbiAutoTraderUnkonwOifType { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeStrategyDoesNotExist.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeStrategyDoesNotExist { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeStrategyIDAlreadyInUse.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeStrategyIDAlreadyInUse { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeStrategyIDMissing.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeStrategyIDMissing { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeSubmitOrder.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeSubmitOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeSubmitOrderToStrategy.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeSubmitOrderToStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeSubmitOrderWithStrategy.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeSubmitOrderWithStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeTifNotSupported.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeTifNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnableToCancelOrder.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnableToCancelOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnableToChangeOrder.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnableToChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnableToDeleteFile.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnableToDeleteFile { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownAccount.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownInstrument.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownOrder.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnknownOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownParameter.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnknownParameter { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownStrategy.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnknownStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnkownPosition.
        /// </summary>
        [DataMember]
        public string CbiAutoTradeUnkownPosition { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTrail.
        /// </summary>
        [DataMember]
        public string CbiAutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTrailAutoBreakEven.
        /// </summary>
        [DataMember]
        public string CbiAutoTrailAutoBreakEven { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTrailAutoTrail.
        /// </summary>
        [DataMember]
        public string CbiAutoTrailAutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the CbiBigTickOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiBigTickOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiClientOnCompletedConnectError.
        /// </summary>
        [DataMember]
        public string CbiClientOnCompletedConnectError { get; set; }
        /// <summary>
        /// Gets or sets the CbiCommisionUnableToLoad.
        /// </summary>
        [DataMember]
        public string CbiCommisionUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiCommission.
        /// </summary>
        [DataMember]
        public string CbiCommission { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCallbackAutoClose.
        /// </summary>
        [DataMember]
        public string CbiConnectionCallbackAutoClose { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionClose.
        /// </summary>
        [DataMember]
        public string CbiConnectionClose { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCloseOpenOrder.
        /// </summary>
        [DataMember]
        public string CbiConnectionCloseOpenOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectAssembly.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectAssembly { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectBrandName.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectBrandName { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectException.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectException { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectExclusive1.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectExclusive1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectExclusive2.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectExclusive2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectNoDuplicates.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectNoDuplicates { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectServer.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectTimeout.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectTimeout { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectVendorLicense.
        /// </summary>
        [DataMember]
        public string CbiConnectionConnectVendorLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCreateAccount.
        /// </summary>
        [DataMember]
        public string CbiConnectionCreateAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCreateOrder.
        /// </summary>
        [DataMember]
        public string CbiConnectionCreateOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCreateSimAccount.
        /// </summary>
        [DataMember]
        public string CbiConnectionCreateSimAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionDuplicateAccount.
        /// </summary>
        [DataMember]
        public string CbiConnectionDuplicateAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionDuplicateAccountTdvCqg.
        /// </summary>
        [DataMember]
        public string CbiConnectionDuplicateAccountTdvCqg { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionKinetickGlobexNonProFeesFailure.
        /// </summary>
        [DataMember]
        public string CbiConnectionKinetickGlobexNonProFeesFailure { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionKinetickGlobexNonProFeesSuccess.
        /// </summary>
        [DataMember]
        public string CbiConnectionKinetickGlobexNonProFeesSuccess { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionOpenConnectNotFound.
        /// </summary>
        [DataMember]
        public string CbiConnectionOpenConnectNotFound { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionProcessAccount.
        /// </summary>
        [DataMember]
        public string CbiConnectionProcessAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionProcessConnectionStatusError.
        /// </summary>
        [DataMember]
        public string CbiConnectionProcessConnectionStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionProcessConnectionStatusUpdate.
        /// </summary>
        [DataMember]
        public string CbiConnectionProcessConnectionStatusUpdate { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionQueryMasterInstrumentMapping.
        /// </summary>
        [DataMember]
        public string CbiConnectionQueryMasterInstrumentMapping { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionQueryMasterInstrumentMappingNoSuchSymbol.
        /// </summary>
        [DataMember]
        public string CbiConnectionQueryMasterInstrumentMappingNoSuchSymbol { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveInstrument.
        /// </summary>
        [DataMember]
        public string CbiConnectionResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveSymbol.
        /// </summary>
        [DataMember]
        public string CbiConnectionResolveSymbol { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveSymbolInstrumentExists.
        /// </summary>
        [DataMember]
        public string CbiConnectionResolveSymbolInstrumentExists { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveSymbolNoMapping.
        /// </summary>
        [DataMember]
        public string CbiConnectionResolveSymbolNoMapping { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionStatusAlreadySubscribed.
        /// </summary>
        [DataMember]
        public string CbiConnectionStatusAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionTimerTickAlreadySubscribed.
        /// </summary>
        [DataMember]
        public string CbiConnectionTimerTickAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiCqgOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiCqgOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCqgOptionsWebApiDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiCqgOptionsWebApiDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCqgOptionsWebApiUnexepctedDisconnect.
        /// </summary>
        [DataMember]
        public string CbiCqgOptionsWebApiUnexepctedDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGQuotesNetworkInterface.
        /// </summary>
        [DataMember]
        public string CbiCQGQuotesNetworkInterface { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerFeedIds.
        /// </summary>
        [DataMember]
        public string CbiCQGServerFeedIds { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerHost.
        /// </summary>
        [DataMember]
        public string CbiCQGServerHost { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerIsCertificationMode.
        /// </summary>
        [DataMember]
        public string CbiCQGServerIsCertificationMode { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerOptionsSenderSubId.
        /// </summary>
        [DataMember]
        public string CbiCQGServerOptionsSenderSubId { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerOrderServer.
        /// </summary>
        [DataMember]
        public string CbiCQGServerOrderServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerPort.
        /// </summary>
        [DataMember]
        public string CbiCQGServerPort { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerQuotes.
        /// </summary>
        [DataMember]
        public string CbiCQGServerQuotes { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerSecurityDefinitionIsDemo.
        /// </summary>
        [DataMember]
        public string CbiCQGServerSecurityDefinitionIsDemo { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerSecurityDefinitionServer.
        /// </summary>
        [DataMember]
        public string CbiCQGServerSecurityDefinitionServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerUseOnBehalfOf.
        /// </summary>
        [DataMember]
        public string CbiCQGServerUseOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the CbiCTraderOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiCTraderOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiDBLoadingAccounts.
        /// </summary>
        [DataMember]
        public string CbiDBLoadingAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CbiDBLoadingInstruments.
        /// </summary>
        [DataMember]
        public string CbiDBLoadingInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CbiDbMigrationFailed.
        /// </summary>
        [DataMember]
        public string CbiDbMigrationFailed { get; set; }
        /// <summary>
        /// Gets or sets the CbiDBRepairFailed.
        /// </summary>
        [DataMember]
        public string CbiDBRepairFailed { get; set; }
        /// <summary>
        /// Gets or sets the CbiDisabledFeature.
        /// </summary>
        [DataMember]
        public string CbiDisabledFeature { get; set; }
        /// <summary>
        /// Gets or sets the CbiDividendAmount.
        /// </summary>
        [DataMember]
        public string CbiDividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the CbiEndOfDayPositions.
        /// </summary>
        [DataMember]
        public string CbiEndOfDayPositions { get; set; }
        /// <summary>
        /// Gets or sets the CbiEntry.
        /// </summary>
        [DataMember]
        public string CbiEntry { get; set; }
        /// <summary>
        /// Gets or sets the CbiEntryExit.
        /// </summary>
        [DataMember]
        public string CbiEntryExit { get; set; }
        /// <summary>
        /// Gets or sets the CbiEX.
        /// </summary>
        [DataMember]
        public string CbiEX { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionDuplicateExecution.
        /// </summary>
        [DataMember]
        public string CbiExecutionDuplicateExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionId.
        /// </summary>
        [DataMember]
        public string CbiExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionName.
        /// </summary>
        [DataMember]
        public string CbiExecutionName { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionOrderId.
        /// </summary>
        [DataMember]
        public string CbiExecutionOrderId { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionPrice.
        /// </summary>
        [DataMember]
        public string CbiExecutionPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutions.
        /// </summary>
        [DataMember]
        public string CbiExecutions { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionUpdateEventArgs0.
        /// </summary>
        [DataMember]
        public string CbiExecutionUpdateEventArgs0 { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionVirtualEntryExecution.
        /// </summary>
        [DataMember]
        public string CbiExecutionVirtualEntryExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiExit.
        /// </summary>
        [DataMember]
        public string CbiExit { get; set; }
        /// <summary>
        /// Gets or sets the CbiExternalDataFeed.
        /// </summary>
        [DataMember]
        public string CbiExternalDataFeed { get; set; }
        /// <summary>
        /// Gets or sets the CbiFee.
        /// </summary>
        [DataMember]
        public string CbiFee { get; set; }
        /// <summary>
        /// Gets or sets the CbiFeeUnableToLoad.
        /// </summary>
        [DataMember]
        public string CbiFeeUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiFromDateSmallerThanToDate.
        /// </summary>
        [DataMember]
        public string CbiFromDateSmallerThanToDate { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiFxcmOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerConnectionType.
        /// </summary>
        [DataMember]
        public string CbiFxcmServerConnectionType { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerHost.
        /// </summary>
        [DataMember]
        public string CbiFxcmServerHost { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerPort.
        /// </summary>
        [DataMember]
        public string CbiFxcmServerPort { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerSenderCompID.
        /// </summary>
        [DataMember]
        public string CbiFxcmServerSenderCompID { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerTargetCompID.
        /// </summary>
        [DataMember]
        public string CbiFxcmServerTargetCompID { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerTargetSubID.
        /// </summary>
        [DataMember]
        public string CbiFxcmServerTargetSubID { get; set; }
        /// <summary>
        /// Gets or sets the CbiGainOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiGainOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiGainOptionsG2Disclaimer.
        /// </summary>
        [DataMember]
        public string CbiGainOptionsG2Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordChangeAtLeast7Characters.
        /// </summary>
        [DataMember]
        public string CbiGlobalsPasswordChangeAtLeast7Characters { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordChangeMatchUsername.
        /// </summary>
        [DataMember]
        public string CbiGlobalsPasswordChangeMatchUsername { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordChangePasswordMustContainItems.
        /// </summary>
        [DataMember]
        public string CbiGlobalsPasswordChangePasswordMustContainItems { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordContainsWhitespaces.
        /// </summary>
        [DataMember]
        public string CbiGlobalsPasswordContainsWhitespaces { get; set; }
        /// <summary>
        /// Gets or sets the CbiIbOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiIbOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiICQGOptionsUseHistoricalTickData.
        /// </summary>
        [DataMember]
        public string CbiICQGOptionsUseHistoricalTickData { get; set; }
        /// <summary>
        /// Gets or sets the CbiICQGOptionsUseWebApi.
        /// </summary>
        [DataMember]
        public string CbiICQGOptionsUseWebApi { get; set; }
        /// <summary>
        /// Gets or sets the CbiIEXOptionsPublicToken.
        /// </summary>
        [DataMember]
        public string CbiIEXOptionsPublicToken { get; set; }
        /// <summary>
        /// Gets or sets the CbiIEXOptionsReplayFile.
        /// </summary>
        [DataMember]
        public string CbiIEXOptionsReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the CbiIndicatorTracking.
        /// </summary>
        [DataMember]
        public string CbiIndicatorTracking { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentErrorInRealTimeTimer.
        /// </summary>
        [DataMember]
        public string CbiInstrumentErrorInRealTimeTimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFailedToStartRecorder.
        /// </summary>
        [DataMember]
        public string CbiInstrumentFailedToStartRecorder { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFundamentalDataAlreadySubscribed.
        /// </summary>
        [DataMember]
        public string CbiInstrumentFundamentalDataAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFundamentalDataCallbackDividends.
        /// </summary>
        [DataMember]
        public string CbiInstrumentFundamentalDataCallbackDividends { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFundamentalDataCallbackSplits.
        /// </summary>
        [DataMember]
        public string CbiInstrumentFundamentalDataCallbackSplits { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentMarketDataAlreadySubscribed.
        /// </summary>
        [DataMember]
        public string CbiInstrumentMarketDataAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentMarketDepthAlreadySubscribed.
        /// </summary>
        [DataMember]
        public string CbiInstrumentMarketDepthAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentName.
        /// </summary>
        [DataMember]
        public string CbiInstrumentName { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentRealtimeDataTimerAlreadySubscribed.
        /// </summary>
        [DataMember]
        public string CbiInstrumentRealtimeDataTimerAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentResetMarketDepth.
        /// </summary>
        [DataMember]
        public string CbiInstrumentResetMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicense.
        /// </summary>
        [DataMember]
        public string CbiLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseAccountBalance.
        /// </summary>
        [DataMember]
        public string CbiLicenseAccountBalance { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseAccountBalanceError.
        /// </summary>
        [DataMember]
        public string CbiLicenseAccountBalanceError { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseCantUseThisFeature.
        /// </summary>
        [DataMember]
        public string CbiLicenseCantUseThisFeature { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseDirect.
        /// </summary>
        [DataMember]
        public string CbiLicenseDirect { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseEnter.
        /// </summary>
        [DataMember]
        public string CbiLicenseEnter { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseFirewall.
        /// </summary>
        [DataMember]
        public string CbiLicenseFirewall { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseInvalidMessage1.
        /// </summary>
        [DataMember]
        public string CbiLicenseInvalidMessage1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseLog.
        /// </summary>
        [DataMember]
        public string CbiLicenseLog { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMachineID.
        /// </summary>
        [DataMember]
        public string CbiLicenseMachineID { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMachineIDBios.
        /// </summary>
        [DataMember]
        public string CbiLicenseMachineIDBios { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMachineIDProcessor.
        /// </summary>
        [DataMember]
        public string CbiLicenseMachineIDProcessor { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMultiBroker.
        /// </summary>
        [DataMember]
        public string CbiLicenseMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseSim.
        /// </summary>
        [DataMember]
        public string CbiLicenseSim { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseStandard.
        /// </summary>
        [DataMember]
        public string CbiLicenseStandard { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseTyAgain.
        /// </summary>
        [DataMember]
        public string CbiLicenseTyAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseVerify1.
        /// </summary>
        [DataMember]
        public string CbiLicenseVerify1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseVerify2.
        /// </summary>
        [DataMember]
        public string CbiLicenseVerify2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseVersion.
        /// </summary>
        [DataMember]
        public string CbiLicenseVersion { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseWillExpireShortly.
        /// </summary>
        [DataMember]
        public string CbiLicenseWillExpireShortly { get; set; }
        /// <summary>
        /// Gets or sets the CbiLiveAccount.
        /// </summary>
        [DataMember]
        public string CbiLiveAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogAlert.
        /// </summary>
        [DataMember]
        public string CbiLogAlert { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogAssert.
        /// </summary>
        [DataMember]
        public string CbiLogAssert { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogCategory.
        /// </summary>
        [DataMember]
        public string CbiLogCategory { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogGeneric.
        /// </summary>
        [DataMember]
        public string CbiLogGeneric { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogLevel.
        /// </summary>
        [DataMember]
        public string CbiLogLevel { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogMailQueueOverFlow.
        /// </summary>
        [DataMember]
        public string CbiLogMailQueueOverFlow { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketAfterTime.
        /// </summary>
        [DataMember]
        public string CbiMarketAfterTime { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketDataEntitlementUnableToLoad.
        /// </summary>
        [DataMember]
        public string CbiMarketDataEntitlementUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketIfTouchedSimulated.
        /// </summary>
        [DataMember]
        public string CbiMarketIfTouchedSimulated { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketPosition.
        /// </summary>
        [DataMember]
        public string CbiMarketPosition { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentDuplicateMappings.
        /// </summary>
        [DataMember]
        public string CbiMasterInstrumentDuplicateMappings { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentOnMaterialized.
        /// </summary>
        [DataMember]
        public string CbiMasterInstrumentOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentSymbolMapDescriptorDescription.
        /// </summary>
        [DataMember]
        public string CbiMasterInstrumentSymbolMapDescriptorDescription { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentUpdateRolloverCollectionError.
        /// </summary>
        [DataMember]
        public string CbiMasterInstrumentUpdateRolloverCollectionError { get; set; }
        /// <summary>
        /// Gets or sets the CbiMbtOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiMbtOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiMessage.
        /// </summary>
        [DataMember]
        public string CbiMessage { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateAccountConnectionsException.
        /// </summary>
        [DataMember]
        public string CbiMigrateAccountConnectionsException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateClearCacheException.
        /// </summary>
        [DataMember]
        public string CbiMigrateClearCacheException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBAccount.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBAtmStrategy.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBAtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBException.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBExecution.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBInstrument.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBInstrumentList.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBMasterInstrument.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBOrder.
        /// </summary>
        [DataMember]
        public string CbiMigrateDBOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDoYouWantToMigrateNT7.
        /// </summary>
        [DataMember]
        public string CbiMigrateDoYouWantToMigrateNT7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateHistoricalDataException.
        /// </summary>
        [DataMember]
        public string CbiMigrateHistoricalDataException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateHistoricalDataException2.
        /// </summary>
        [DataMember]
        public string CbiMigrateHistoricalDataException2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateHistoricalDataNoInstrument.
        /// </summary>
        [DataMember]
        public string CbiMigrateHistoricalDataNoInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessAccountConnections.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessAccountConnections { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessAccounts.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessAtmStrategies.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessAtmStrategies { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessDB.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessDB { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessExecutions.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessExecutions { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessHistoricalData.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessHistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessInstrumentLists.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessInstrumentLists { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessInstruments.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessMasterInstruments.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessOrders.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessReplayData.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessReplayData { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessSettings.
        /// </summary>
        [DataMember]
        public string CbiMigrateProcessSettings { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateReplayData.
        /// </summary>
        [DataMember]
        public string CbiMigrateReplayData { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateReplayDataNoInstrument.
        /// </summary>
        [DataMember]
        public string CbiMigrateReplayDataNoInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateSettingsException.
        /// </summary>
        [DataMember]
        public string CbiMigrateSettingsException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateShutdownNT7.
        /// </summary>
        [DataMember]
        public string CbiMigrateShutdownNT7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateSuccess.
        /// </summary>
        [DataMember]
        public string CbiMigrateSuccess { get; set; }
        /// <summary>
        /// Gets or sets the CbiNewFxcmLicenses.
        /// </summary>
        [DataMember]
        public string CbiNewFxcmLicenses { get; set; }
        /// <summary>
        /// Gets or sets the CbiNewLicenses.
        /// </summary>
        [DataMember]
        public string CbiNewLicenses { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity1.
        /// </summary>
        [DataMember]
        public string CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity2.
        /// </summary>
        [DataMember]
        public string CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaTraderCreateStrategy.
        /// </summary>
        [DataMember]
        public string CbiNinjaTraderCreateStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaTraderProxyInstrumentUpdateSuccessful.
        /// </summary>
        [DataMember]
        public string CbiNinjaTraderProxyInstrumentUpdateSuccessful { get; set; }
        /// <summary>
        /// Gets or sets the CbiNoEndOfDayPositions.
        /// </summary>
        [DataMember]
        public string CbiNoEndOfDayPositions { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTConnectAlreadyConnected.
        /// </summary>
        [DataMember]
        public string CbiNTConnectAlreadyConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTConnectIncorrectAccountPassword.
        /// </summary>
        [DataMember]
        public string CbiNTConnectIncorrectAccountPassword { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTResolveInstrument.
        /// </summary>
        [DataMember]
        public string CbiNTResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTResolveInstrumentList.
        /// </summary>
        [DataMember]
        public string CbiNTResolveInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTSystem.
        /// </summary>
        [DataMember]
        public string CbiNTSystem { get; set; }
        /// <summary>
        /// Gets or sets the CbiNull.
        /// </summary>
        [DataMember]
        public string CbiNull { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderAction.
        /// </summary>
        [DataMember]
        public string CbiOrderAction { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderAverageFillPrice.
        /// </summary>
        [DataMember]
        public string CbiOrderAverageFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderComment.
        /// </summary>
        [DataMember]
        public string CbiOrderComment { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderError.
        /// </summary>
        [DataMember]
        public string CbiOrderError { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderExternal.
        /// </summary>
        [DataMember]
        public string CbiOrderExternal { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderFilled.
        /// </summary>
        [DataMember]
        public string CbiOrderFilled { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderFromBytes.
        /// </summary>
        [DataMember]
        public string CbiOrderFromBytes { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderId.
        /// </summary>
        [DataMember]
        public string CbiOrderId { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderLimitPrice.
        /// </summary>
        [DataMember]
        public string CbiOrderLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderOrderState.
        /// </summary>
        [DataMember]
        public string CbiOrderOrderState { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderQuantity.
        /// </summary>
        [DataMember]
        public string CbiOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrders.
        /// </summary>
        [DataMember]
        public string CbiOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderStopPrice.
        /// </summary>
        [DataMember]
        public string CbiOrderStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderSuperDomRoyaltiesExcess.
        /// </summary>
        [DataMember]
        public string CbiOrderSuperDomRoyaltiesExcess { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderTracking.
        /// </summary>
        [DataMember]
        public string CbiOrderTracking { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderTrailing.
        /// </summary>
        [DataMember]
        public string CbiOrderTrailing { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderType.
        /// </summary>
        [DataMember]
        public string CbiOrderType { get; set; }
        /// <summary>
        /// Gets or sets the CbiPlaybackAccount.
        /// </summary>
        [DataMember]
        public string CbiPlaybackAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiPlaybackConnection.
        /// </summary>
        [DataMember]
        public string CbiPlaybackConnection { get; set; }
        /// <summary>
        /// Gets or sets the CbiPosition.
        /// </summary>
        [DataMember]
        public string CbiPosition { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionAddExecution.
        /// </summary>
        [DataMember]
        public string CbiPositionAddExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionAveragePrice.
        /// </summary>
        [DataMember]
        public string CbiPositionAveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionCloseDisableStrategy.
        /// </summary>
        [DataMember]
        public string CbiPositionCloseDisableStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionCloseFailed.
        /// </summary>
        [DataMember]
        public string CbiPositionCloseFailed { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionCloseTimeoutWaitingForCancellations.
        /// </summary>
        [DataMember]
        public string CbiPositionCloseTimeoutWaitingForCancellations { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionStatementDate.
        /// </summary>
        [DataMember]
        public string CbiPositionStatementDate { get; set; }
        /// <summary>
        /// Gets or sets the CbiProductFreeEdition.
        /// </summary>
        [DataMember]
        public string CbiProductFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiProductMultiBrokerEdition.
        /// </summary>
        [DataMember]
        public string CbiProductMultiBrokerEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiProductStandardEdition.
        /// </summary>
        [DataMember]
        public string CbiProductStandardEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiProviderUnknown.
        /// </summary>
        [DataMember]
        public string CbiProviderUnknown { get; set; }
        /// <summary>
        /// Gets or sets the CbiQuantity.
        /// </summary>
        [DataMember]
        public string CbiQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiRate.
        /// </summary>
        [DataMember]
        public string CbiRate { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportAccountEntitlementMissing.
        /// </summary>
        [DataMember]
        public string CbiReportAccountEntitlementMissing { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportLicenseFileNotFound.
        /// </summary>
        [DataMember]
        public string CbiReportLicenseFileNotFound { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNewCustomers.
        /// </summary>
        [DataMember]
        public string CbiReportNewCustomers { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoManageUserNorReportPermission.
        /// </summary>
        [DataMember]
        public string CbiReportNoManageUserNorReportPermission { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoMonitorNorReportPermission.
        /// </summary>
        [DataMember]
        public string CbiReportNoMonitorNorReportPermission { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoMonitorPermissions.
        /// </summary>
        [DataMember]
        public string CbiReportNoMonitorPermissions { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoPermissionToViewUserData.
        /// </summary>
        [DataMember]
        public string CbiReportNoPermissionToViewUserData { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoReportPermission.
        /// </summary>
        [DataMember]
        public string CbiReportNoReportPermission { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNotAllowedToManageUsers.
        /// </summary>
        [DataMember]
        public string CbiReportNotAllowedToManageUsers { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportParameterMissing.
        /// </summary>
        [DataMember]
        public string CbiReportParameterMissing { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportsUnavailable.
        /// </summary>
        [DataMember]
        public string CbiReportsUnavailable { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownAccount.
        /// </summary>
        [DataMember]
        public string CbiReportUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownInstrument.
        /// </summary>
        [DataMember]
        public string CbiReportUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownLogCategory.
        /// </summary>
        [DataMember]
        public string CbiReportUnknownLogCategory { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownLogLevel.
        /// </summary>
        [DataMember]
        public string CbiReportUnknownLogLevel { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownUser.
        /// </summary>
        [DataMember]
        public string CbiReportUnknownUser { get; set; }
        /// <summary>
        /// Gets or sets the CbiRiskUnableToLoad.
        /// </summary>
        [DataMember]
        public string CbiRiskUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiRithmicOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiRithmicOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiRMSOnly.
        /// </summary>
        [DataMember]
        public string CbiRMSOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiRolloverContractMonth.
        /// </summary>
        [DataMember]
        public string CbiRolloverContractMonth { get; set; }
        /// <summary>
        /// Gets or sets the CbiRolloverDate.
        /// </summary>
        [DataMember]
        public string CbiRolloverDate { get; set; }
        /// <summary>
        /// Gets or sets the CbiRolloverOffset.
        /// </summary>
        [DataMember]
        public string CbiRolloverOffset { get; set; }
        /// <summary>
        /// Gets or sets the CbiScanOnMaterialized.
        /// </summary>
        [DataMember]
        public string CbiScanOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiSchwabOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiSchwabOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiServer.
        /// </summary>
        [DataMember]
        public string CbiServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiServerException.
        /// </summary>
        [DataMember]
        public string CbiServerException { get; set; }
        /// <summary>
        /// Gets or sets the CbiSharpPointOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiSharpPointOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimFeed.
        /// </summary>
        [DataMember]
        public string CbiSimFeed { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatedStopLimit.
        /// </summary>
        [DataMember]
        public string CbiSimulatedStopLimit { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatedStopMarket.
        /// </summary>
        [DataMember]
        public string CbiSimulatedStopMarket { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulationAccount.
        /// </summary>
        [DataMember]
        public string CbiSimulationAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorChange.
        /// </summary>
        [DataMember]
        public string CbiSimulatorChange { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorChange2.
        /// </summary>
        [DataMember]
        public string CbiSimulatorChange2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorChange3.
        /// </summary>
        [DataMember]
        public string CbiSimulatorChange3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorNoMarketData.
        /// </summary>
        [DataMember]
        public string CbiSimulatorNoMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorOrderAlreadyCancelled.
        /// </summary>
        [DataMember]
        public string CbiSimulatorOrderAlreadyCancelled { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorOrderAlreadyFilled.
        /// </summary>
        [DataMember]
        public string CbiSimulatorOrderAlreadyFilled { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorOrderAlreadyRejected.
        /// </summary>
        [DataMember]
        public string CbiSimulatorOrderAlreadyRejected { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit10.
        /// </summary>
        [DataMember]
        public string CbiSimulatorSubmit10 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit11.
        /// </summary>
        [DataMember]
        public string CbiSimulatorSubmit11 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit6.
        /// </summary>
        [DataMember]
        public string CbiSimulatorSubmit6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit7.
        /// </summary>
        [DataMember]
        public string CbiSimulatorSubmit7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit8.
        /// </summary>
        [DataMember]
        public string CbiSimulatorSubmit8 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit9.
        /// </summary>
        [DataMember]
        public string CbiSimulatorSubmit9 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSnapShotApplyError.
        /// </summary>
        [DataMember]
        public string CbiSnapShotApplyError { get; set; }
        /// <summary>
        /// Gets or sets the CbiSnapShotDiffError.
        /// </summary>
        [DataMember]
        public string CbiSnapShotDiffError { get; set; }
        /// <summary>
        /// Gets or sets the CbiSnapShotMakeError.
        /// </summary>
        [DataMember]
        public string CbiSnapShotMakeError { get; set; }
        /// <summary>
        /// Gets or sets the CbiSplitFactor.
        /// </summary>
        [DataMember]
        public string CbiSplitFactor { get; set; }
        /// <summary>
        /// Gets or sets the CbiStartOfDayPositions.
        /// </summary>
        [DataMember]
        public string CbiStartOfDayPositions { get; set; }
        /// <summary>
        /// Gets or sets the CbiSubmitIfTouched.
        /// </summary>
        [DataMember]
        public string CbiSubmitIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the CbiTdaOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiTdaOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyCedroTech.
        /// </summary>
        [DataMember]
        public string CbiTechnologyCedroTech { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyContinuum.
        /// </summary>
        [DataMember]
        public string CbiTechnologyContinuum { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyCqg.
        /// </summary>
        [DataMember]
        public string CbiTechnologyCqg { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyCTrader.
        /// </summary>
        [DataMember]
        public string CbiTechnologyCTrader { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyFXCM.
        /// </summary>
        [DataMember]
        public string CbiTechnologyFXCM { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyGain.
        /// </summary>
        [DataMember]
        public string CbiTechnologyGain { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyInteractiveBrokers.
        /// </summary>
        [DataMember]
        public string CbiTechnologyInteractiveBrokers { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyMBTrading.
        /// </summary>
        [DataMember]
        public string CbiTechnologyMBTrading { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyModalMais.
        /// </summary>
        [DataMember]
        public string CbiTechnologyModalMais { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyMultiBroker.
        /// </summary>
        [DataMember]
        public string CbiTechnologyMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyNinjaTraderBrokerage.
        /// </summary>
        [DataMember]
        public string CbiTechnologyNinjaTraderBrokerage { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyPatsystems.
        /// </summary>
        [DataMember]
        public string CbiTechnologyPatsystems { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyRithmic.
        /// </summary>
        [DataMember]
        public string CbiTechnologyRithmic { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologySchwab.
        /// </summary>
        [DataMember]
        public string CbiTechnologySchwab { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyTDAmeritrade.
        /// </summary>
        [DataMember]
        public string CbiTechnologyTDAmeritrade { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyTradovate.
        /// </summary>
        [DataMember]
        public string CbiTechnologyTradovate { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyVisionFinancialMarkets.
        /// </summary>
        [DataMember]
        public string CbiTechnologyVisionFinancialMarkets { get; set; }
        /// <summary>
        /// Gets or sets the CbiThereWasMoreData.
        /// </summary>
        [DataMember]
        public string CbiThereWasMoreData { get; set; }
        /// <summary>
        /// Gets or sets the CbiTime.
        /// </summary>
        [DataMember]
        public string CbiTime { get; set; }
        /// <summary>
        /// Gets or sets the CbiTransactionPurchase.
        /// </summary>
        [DataMember]
        public string CbiTransactionPurchase { get; set; }
        /// <summary>
        /// Gets or sets the CbiTTOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public string CbiTTOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiUnableToCreateInstance.
        /// </summary>
        [DataMember]
        public string CbiUnableToCreateInstance { get; set; }
        /// <summary>
        /// Gets or sets the CbiUnableToCreateInstance2.
        /// </summary>
        [DataMember]
        public string CbiUnableToCreateInstance2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiUser.
        /// </summary>
        [DataMember]
        public string CbiUser { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserLogons.
        /// </summary>
        [DataMember]
        public string CbiUserLogons { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserMarketDataEntitlements.
        /// </summary>
        [DataMember]
        public string CbiUserMarketDataEntitlements { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserMarketDataEntitlementsChanges.
        /// </summary>
        [DataMember]
        public string CbiUserMarketDataEntitlementsChanges { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserOnMaterialized.
        /// </summary>
        [DataMember]
        public string CbiUserOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrial.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseFreeTrial { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpirationNotificationLog4.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseFreeTrialExpirationNotificationLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpirationNotificationLog5.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseFreeTrialExpirationNotificationLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpiredLog4.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseFreeTrialExpiredLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpiredLog5.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseFreeTrialExpiredLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseContactPurchase.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseInvalidLicenseContactPurchase { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseContactPurchaseOptions.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseInvalidLicenseContactPurchaseOptions { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseLog4.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseInvalidLicenseLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseLog5.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseInvalidLicenseLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseLicenseNotStartedLog4.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseLicenseNotStartedLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseLicenseNotStartedLog5.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseLicenseNotStartedLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseNotificationMailSignature.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseNotificationMailSignature { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseOrderFlowPlusInvalid.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseOrderFlowPlusInvalid { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpirationNotificationLog5.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseRegularLicenseExpirationNotificationLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpirationNotificationLog6.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseRegularLicenseExpirationNotificationLog6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpiredLog5.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseRegularLicenseExpiredLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpiredLog6.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseRegularLicenseExpiredLog6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseUnableConnectVerifyTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseUnableConnectVerifyTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseVerify.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseVerify { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseVerifyingPrimaryServer.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseVerifyingPrimaryServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseVerifyingSecondaryServer.
        /// </summary>
        [DataMember]
        public string CbiVendorLicenseVerifyingSecondaryServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingCheckingTreeTrial.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingCheckingTreeTrial { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedRemoveLicense.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedRemoveLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedRemoveLicenseTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedRemoveLicenseTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateLicense.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedUpdateLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateLicenseTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedUpdateLicenseTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateMessages.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedUpdateMessages { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateMessagesTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedUpdateMessagesTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUploadProducts.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedUploadProducts { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUploadProductsTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedUploadProductsTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedVerifyVendorNameKey.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedVerifyVendorNameKey { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedVerifyVendorTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingFailedVerifyVendorTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingGetLicensesFailedTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingGetLicensesFailedTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingGetMessagesFailedTryAgain.
        /// </summary>
        [DataMember]
        public string CbiVendorLicensingGetMessagesFailedTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVolumeTraded.
        /// </summary>
        [DataMember]
        public string CbiVolumeTraded { get; set; }
        /// <summary>
        /// Gets or sets the CodeCompilerException.
        /// </summary>
        [DataMember]
        public string CodeCompilerException { get; set; }
        /// <summary>
        /// Gets or sets the CodeCompilerIntellisenseCopyFailed.
        /// </summary>
        [DataMember]
        public string CodeCompilerIntellisenseCopyFailed { get; set; }
        /// <summary>
        /// Gets or sets the CodeCompilerLoadNewException.
        /// </summary>
        [DataMember]
        public string CodeCompilerLoadNewException { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingAssemblies.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorCopyingAssemblies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingCommissionTemplates.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorCopyingCommissionTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingFeeTemplates.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorCopyingFeeTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingMarketDataEntitlementTemplates.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorCopyingMarketDataEntitlementTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingRiskTemplates.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorCopyingRiskTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingTradingHoursTemplates.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorCopyingTradingHoursTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCreatingTemplatesFolder.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorCreatingTemplatesFolder { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorInstallationCorrupted.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorInstallationCorrupted { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorLoadingCustomAssembly1.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorLoadingCustomAssembly1 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorLoadingCustomAssembly2.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorLoadingCustomAssembly2 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorLoadingVendorAssembly.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorLoadingVendorAssembly { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorOutdated.
        /// </summary>
        [DataMember]
        public string CoreApplicationErrorOutdated { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart1.
        /// </summary>
        [DataMember]
        public string CoreApplicationStart1 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart2.
        /// </summary>
        [DataMember]
        public string CoreApplicationStart2 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart3.
        /// </summary>
        [DataMember]
        public string CoreApplicationStart3 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart4.
        /// </summary>
        [DataMember]
        public string CoreApplicationStart4 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartAtiDisabled.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartAtiDisabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartAtiEnabled.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartAtiEnabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartAutoConnect.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartAutoConnect { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartClearCache.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartClearCache { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCompile.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartCompile { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCompile2.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartCompile2 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCompiling.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartCompiling { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCopyingAssemblies.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartCopyingAssemblies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartGlobalSimulationDisabled.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartGlobalSimulationDisabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartGlobalSimulationEnabled.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartGlobalSimulationEnabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartInitializingDB.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartInitializingDB { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartInstallFile.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartInstallFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingAccounts.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingAssemblies.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingAssemblies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingExecutions.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingExecutions { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingInstruments.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingMasterInstruments.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingOrders.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingOrders { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingSimulationAccountsPositions.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingSimulationAccountsPositions { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingStrategies.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingStrategies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingUsers.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartLoadingUsers { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartNewAddOnsMessage.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartNewAddOnsMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartObjectVersionMessage.
        /// </summary>
        [DataMember]
        public string CoreApplicationStartObjectVersionMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreAssemblyDictionaryGetType.
        /// </summary>
        [DataMember]
        public string CoreAssemblyDictionaryGetType { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerDeserializeAccount.
        /// </summary>
        [DataMember]
        public string CoreDeserializerDeserializeAccount { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerDeserializeInstrument.
        /// </summary>
        [DataMember]
        public string CoreDeserializerDeserializeInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerDeserializeOrder.
        /// </summary>
        [DataMember]
        public string CoreDeserializerDeserializeOrder { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerQueryEntitiesLimit.
        /// </summary>
        [DataMember]
        public string CoreDeserializerQueryEntitiesLimit { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerScanIndicator.
        /// </summary>
        [DataMember]
        public string CoreDeserializerScanIndicator { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerSnapShotApplyFailed.
        /// </summary>
        [DataMember]
        public string CoreDeserializerSnapShotApplyFailed { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingChartData.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingChartData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingConfigFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingConfigFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingDatabase.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingDatabase { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingLogAndTrace.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingLogAndTrace { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingMarketRecordings.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingMarketRecordings { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingTemplates.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingWorkspaces.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupArchivingWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupBackingUp.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupBackingUp { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupErrorMessage.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupErrorMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupNonCompileableWarning.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupNonCompileableWarning { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupSuccessMessageLog.
        /// </summary>
        [DataMember]
        public string CoreGlobalsBackupSuccessMessageLog { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsCantImportNinjaScriptFilesProgrammingErrors.
        /// </summary>
        [DataMember]
        public string CoreGlobalsCantImportNinjaScriptFilesProgrammingErrors { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsChartData.
        /// </summary>
        [DataMember]
        public string CoreGlobalsChartData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsCQGAndContinuumNotIdentical.
        /// </summary>
        [DataMember]
        public string CoreGlobalsCQGAndContinuumNotIdentical { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsD2DFactoryException.
        /// </summary>
        [DataMember]
        public string CoreGlobalsD2DFactoryException { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsDatabase.
        /// </summary>
        [DataMember]
        public string CoreGlobalsDatabase { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsFailedLoadVendorAssembly.
        /// </summary>
        [DataMember]
        public string CoreGlobalsFailedLoadVendorAssembly { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsFromLocalizedObject.
        /// </summary>
        [DataMember]
        public string CoreGlobalsFromLocalizedObject { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsGetExpiryYear.
        /// </summary>
        [DataMember]
        public string CoreGlobalsGetExpiryYear { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsKinetickAndIQNotIdentical.
        /// </summary>
        [DataMember]
        public string CoreGlobalsKinetickAndIQNotIdentical { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsLogAndTraceFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsLogAndTraceFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsMainConfigurationFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsMainConfigurationFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsMarketReplayData.
        /// </summary>
        [DataMember]
        public string CoreGlobalsMarketReplayData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNeedToCloseAccountConnectionToRestore.
        /// </summary>
        [DataMember]
        public string CoreGlobalsNeedToCloseAccountConnectionToRestore { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNinjaScriptCantRestoredCorruptInstallation.
        /// </summary>
        [DataMember]
        public string CoreGlobalsNinjaScriptCantRestoredCorruptInstallation { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNinjaScriptFilesNotRestored.
        /// </summary>
        [DataMember]
        public string CoreGlobalsNinjaScriptFilesNotRestored { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsPlaySound.
        /// </summary>
        [DataMember]
        public string CoreGlobalsPlaySound { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoredProgrammingErrors.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoredProgrammingErrors { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoredWithErrorsMessage.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoredWithErrorsMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreFailedNewerVersion.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoreFailedNewerVersion { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreFailedOlderVersion.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoreFailedOlderVersion { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreUnpackingArchive.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoreUnpackingArchive { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreUnsuccessful.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoreUnsuccessful { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoring.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoring { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringChartData.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringChartData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringConfigurationFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringConfigurationFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringDatabase.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringDatabase { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringLogAndTraceFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringLogAndTraceFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringMarketRecordings.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringMarketRecordings { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringTemplates.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringWorkspaces.
        /// </summary>
        [DataMember]
        public string CoreGlobalsRestoringWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsSendMail.
        /// </summary>
        [DataMember]
        public string CoreGlobalsSendMail { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsSuccessfullyRestoredLog.
        /// </summary>
        [DataMember]
        public string CoreGlobalsSuccessfullyRestoredLog { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsSuccessfullyRestoredMessage.
        /// </summary>
        [DataMember]
        public string CoreGlobalsSuccessfullyRestoredMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsTemplates.
        /// </summary>
        [DataMember]
        public string CoreGlobalsTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsThirdPartyInvalidStateMustShutDown.
        /// </summary>
        [DataMember]
        public string CoreGlobalsThirdPartyInvalidStateMustShutDown { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsToLocalizedObject.
        /// </summary>
        [DataMember]
        public string CoreGlobalsToLocalizedObject { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsUnableRestoreContainsCorruptNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public string CoreGlobalsUnableRestoreContainsCorruptNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsUnableToLoadPFConfigFile.
        /// </summary>
        [DataMember]
        public string CoreGlobalsUnableToLoadPFConfigFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsUnableToLoadServerConfigFile.
        /// </summary>
        [DataMember]
        public string CoreGlobalsUnableToLoadServerConfigFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsVendorAssemblyLoaded.
        /// </summary>
        [DataMember]
        public string CoreGlobalsVendorAssemblyLoaded { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsWorkspaces.
        /// </summary>
        [DataMember]
        public string CoreGlobalsWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the CoreGobalsDoYouWishToRestore.
        /// </summary>
        [DataMember]
        public string CoreGobalsDoYouWishToRestore { get; set; }
        /// <summary>
        /// Gets or sets the CoreImportBackupFile.
        /// </summary>
        [DataMember]
        public string CoreImportBackupFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreInstrumentationInitializeError.
        /// </summary>
        [DataMember]
        public string CoreInstrumentationInitializeError { get; set; }
        /// <summary>
        /// Gets or sets the CoreMailThreadProc.
        /// </summary>
        [DataMember]
        public string CoreMailThreadProc { get; set; }
        /// <summary>
        /// Gets or sets the CoreSerializerSerialize.
        /// </summary>
        [DataMember]
        public string CoreSerializerSerialize { get; set; }
        /// <summary>
        /// Gets or sets the CoreServerHdsClientDeserializeCorruptDataMessage.
        /// </summary>
        [DataMember]
        public string CoreServerHdsClientDeserializeCorruptDataMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreSoundThreadProc.
        /// </summary>
        [DataMember]
        public string CoreSoundThreadProc { get; set; }
        /// <summary>
        /// Gets or sets the CoreStatBetaCf.
        /// </summary>
        [DataMember]
        public string CoreStatBetaCf { get; set; }
        /// <summary>
        /// Gets or sets the CoreUnhandledException.
        /// </summary>
        [DataMember]
        public string CoreUnhandledException { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField.
        /// </summary>
        [DataMember]
        public string CotReportField { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType.
        /// </summary>
        [DataMember]
        public string CotReportType { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterBufferOverflow.
        /// </summary>
        [DataMember]
        public string CqgAdapterBufferOverflow { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCancel.
        /// </summary>
        [DataMember]
        public string CqgAdapterCancel { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterChange.
        /// </summary>
        [DataMember]
        public string CqgAdapterChange { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterClOrderIdMissing.
        /// </summary>
        [DataMember]
        public string CqgAdapterClOrderIdMissing { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCollateralSubscriptionFailed.
        /// </summary>
        [DataMember]
        public string CqgAdapterCollateralSubscriptionFailed { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCompoundOrderError.
        /// </summary>
        [DataMember]
        public string CqgAdapterCompoundOrderError { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM.
        /// </summary>
        [DataMember]
        public string CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM2.
        /// </summary>
        [DataMember]
        public string CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM2 { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCqgOrderIdMissing.
        /// </summary>
        [DataMember]
        public string CqgAdapterCqgOrderIdMissing { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterErrorOnHistoricalData.
        /// </summary>
        [DataMember]
        public string CqgAdapterErrorOnHistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterException.
        /// </summary>
        [DataMember]
        public string CqgAdapterException { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterExchangeMapChanged.
        /// </summary>
        [DataMember]
        public string CqgAdapterExchangeMapChanged { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterHistoricalRequestTooFarBack.
        /// </summary>
        [DataMember]
        public string CqgAdapterHistoricalRequestTooFarBack { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterInvalidLotSize.
        /// </summary>
        [DataMember]
        public string CqgAdapterInvalidLotSize { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterMarketDataSubError.
        /// </summary>
        [DataMember]
        public string CqgAdapterMarketDataSubError { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterMissingCurrency.
        /// </summary>
        [DataMember]
        public string CqgAdapterMissingCurrency { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterMissingTickSize.
        /// </summary>
        [DataMember]
        public string CqgAdapterMissingTickSize { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterOnlyTwoOcoOrders.
        /// </summary>
        [DataMember]
        public string CqgAdapterOnlyTwoOcoOrders { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterOrdersSubscriptionFailed.
        /// </summary>
        [DataMember]
        public string CqgAdapterOrdersSubscriptionFailed { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterOrderUnknownAccount.
        /// </summary>
        [DataMember]
        public string CqgAdapterOrderUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterPositionsSubscriptionFailed.
        /// </summary>
        [DataMember]
        public string CqgAdapterPositionsSubscriptionFailed { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterPositionUnknownAccount.
        /// </summary>
        [DataMember]
        public string CqgAdapterPositionUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterSubmit.
        /// </summary>
        [DataMember]
        public string CqgAdapterSubmit { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnableToConnect.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnableToConnect { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedCsvFormat.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnexpectedCsvFormat { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedFileType.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnexpectedFileType { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedInstrument.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnexpectedInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedZipPath.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnexpectedZipPath { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownContractIdForOrder.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnknownContractIdForOrder { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownContractIdForPosition.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnknownContractIdForPosition { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownInstrument.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownOrder.
        /// </summary>
        [DataMember]
        public string CqgAdapterUnknownOrder { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterWebApiBalanceUnknownAccount.
        /// </summary>
        [DataMember]
        public string CqgAdapterWebApiBalanceUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterWebApiInformationReportError.
        /// </summary>
        [DataMember]
        public string CqgAdapterWebApiInformationReportError { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterWebApiSymbolMismatch.
        /// </summary>
        [DataMember]
        public string CqgAdapterWebApiSymbolMismatch { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsAddFailed.
        /// </summary>
        [DataMember]
        public string DataBarsAddFailed { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsDownloadFromProviderError.
        /// </summary>
        [DataMember]
        public string DataBarsDownloadFromProviderError { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsHistoricalDataCorruptedDaily.
        /// </summary>
        [DataMember]
        public string DataBarsHistoricalDataCorruptedDaily { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsHistoricalDataCorruptedIntraday.
        /// </summary>
        [DataMember]
        public string DataBarsHistoricalDataCorruptedIntraday { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriod.
        /// </summary>
        [DataMember]
        public string DataBarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodBasePeriodType.
        /// </summary>
        [DataMember]
        public string DataBarsPeriodBasePeriodType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodBasePeriodValue.
        /// </summary>
        [DataMember]
        public string DataBarsPeriodBasePeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodPointAndFigurePriceType.
        /// </summary>
        [DataMember]
        public string DataBarsPeriodPointAndFigurePriceType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodPriceBasedOn.
        /// </summary>
        [DataMember]
        public string DataBarsPeriodPriceBasedOn { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodReversalType.
        /// </summary>
        [DataMember]
        public string DataBarsPeriodReversalType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodValue2.
        /// </summary>
        [DataMember]
        public string DataBarsPeriodValue2 { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodVolumetricBarsTypeDeltaType.
        /// </summary>
        [DataMember]
        public string DataBarsPeriodVolumetricBarsTypeDeltaType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsRemoveLastBarNotSupportedTickReplay.
        /// </summary>
        [DataMember]
        public string DataBarsRemoveLastBarNotSupportedTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsRequestBarsSeriesError.
        /// </summary>
        [DataMember]
        public string DataBarsRequestBarsSeriesError { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsSeriesAbortOnDisconnect.
        /// </summary>
        [DataMember]
        public string DataBarsSeriesAbortOnDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsSeriesExportingDataRemaining.
        /// </summary>
        [DataMember]
        public string DataBarsSeriesExportingDataRemaining { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsSeriesFromSmallerTo.
        /// </summary>
        [DataMember]
        public string DataBarsSeriesFromSmallerTo { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeRemoveLastBar.
        /// </summary>
        [DataMember]
        public string DataBarsTypeRemoveLastBar { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableClearCacheData.
        /// </summary>
        [DataMember]
        public string DataBarsUnableClearCacheData { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableCreateFile.
        /// </summary>
        [DataMember]
        public string DataBarsUnableCreateFile { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableReadCacheData.
        /// </summary>
        [DataMember]
        public string DataBarsUnableReadCacheData { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableSaveData.
        /// </summary>
        [DataMember]
        public string DataBarsUnableSaveData { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableWriteCacheData.
        /// </summary>
        [DataMember]
        public string DataBarsUnableWriteCacheData { get; set; }
        /// <summary>
        /// Gets or sets the DataColorSeriesSetError.
        /// </summary>
        [DataMember]
        public string DataColorSeriesSetError { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataGetProperties.
        /// </summary>
        [DataMember]
        public string DataFundamentalDataGetProperties { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStartException.
        /// </summary>
        [DataMember]
        public string DataFundamentalDataStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStartInstrument.
        /// </summary>
        [DataMember]
        public string DataFundamentalDataStartInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStartNotSupported.
        /// </summary>
        [DataMember]
        public string DataFundamentalDataStartNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStopException.
        /// </summary>
        [DataMember]
        public string DataFundamentalDataStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStopInstrument.
        /// </summary>
        [DataMember]
        public string DataFundamentalDataStopInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStopNotSupported.
        /// </summary>
        [DataMember]
        public string DataFundamentalDataStopNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataGetHostListsException.
        /// </summary>
        [DataMember]
        public string DataGetHostListsException { get; set; }
        /// <summary>
        /// Gets or sets the DataGetPropertyValueException.
        /// </summary>
        [DataMember]
        public string DataGetPropertyValueException { get; set; }
        /// <summary>
        /// Gets or sets the DataHotListStartException.
        /// </summary>
        [DataMember]
        public string DataHotListStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataHotListStopException.
        /// </summary>
        [DataMember]
        public string DataHotListStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataImportDataMetaStockImportTypeLoad.
        /// </summary>
        [DataMember]
        public string DataImportDataMetaStockImportTypeLoad { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalAskMaxSpread.
        /// </summary>
        [DataMember]
        public string DataImportIllegalAskMaxSpread { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalAskOpen.
        /// </summary>
        [DataMember]
        public string DataImportIllegalAskOpen { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalBidMaxSpread.
        /// </summary>
        [DataMember]
        public string DataImportIllegalBidMaxSpread { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalBidOpen.
        /// </summary>
        [DataMember]
        public string DataImportIllegalBidOpen { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalCloseHigh.
        /// </summary>
        [DataMember]
        public string DataImportIllegalCloseHigh { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalCloseLow.
        /// </summary>
        [DataMember]
        public string DataImportIllegalCloseLow { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalHighLow.
        /// </summary>
        [DataMember]
        public string DataImportIllegalHighLow { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalLowHigh.
        /// </summary>
        [DataMember]
        public string DataImportIllegalLowHigh { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalOpenHigh.
        /// </summary>
        [DataMember]
        public string DataImportIllegalOpenHigh { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalOpenLow.
        /// </summary>
        [DataMember]
        public string DataImportIllegalOpenLow { get; set; }
        /// <summary>
        /// Gets or sets the DataImportMessage.
        /// </summary>
        [DataMember]
        public string DataImportMessage { get; set; }
        /// <summary>
        /// Gets or sets the DataImportTimestampInvalid.
        /// </summary>
        [DataMember]
        public string DataImportTimestampInvalid { get; set; }
        /// <summary>
        /// Gets or sets the DataImportTimeStampSmaller.
        /// </summary>
        [DataMember]
        public string DataImportTimeStampSmaller { get; set; }
        /// <summary>
        /// Gets or sets the DataImportTimeStampSmallerEqual.
        /// </summary>
        [DataMember]
        public string DataImportTimeStampSmallerEqual { get; set; }
        /// <summary>
        /// Gets or sets the DataImportVolumeGreaterEqualZero.
        /// </summary>
        [DataMember]
        public string DataImportVolumeGreaterEqualZero { get; set; }
        /// <summary>
        /// Gets or sets the DataInvalidPropertyRange.
        /// </summary>
        [DataMember]
        public string DataInvalidPropertyRange { get; set; }
        /// <summary>
        /// Gets or sets the DataLineDefaultName.
        /// </summary>
        [DataMember]
        public string DataLineDefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStartException.
        /// </summary>
        [DataMember]
        public string DataMarketDataStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStartInstrument.
        /// </summary>
        [DataMember]
        public string DataMarketDataStartInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStartNotSupported.
        /// </summary>
        [DataMember]
        public string DataMarketDataStartNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStopException.
        /// </summary>
        [DataMember]
        public string DataMarketDataStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStopInstrument.
        /// </summary>
        [DataMember]
        public string DataMarketDataStopInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStopNotSupported.
        /// </summary>
        [DataMember]
        public string DataMarketDataStopNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStartException.
        /// </summary>
        [DataMember]
        public string DataMarketDepthStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStartInstrument.
        /// </summary>
        [DataMember]
        public string DataMarketDepthStartInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStartNotSupported.
        /// </summary>
        [DataMember]
        public string DataMarketDepthStartNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStopException.
        /// </summary>
        [DataMember]
        public string DataMarketDepthStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStopInstrument.
        /// </summary>
        [DataMember]
        public string DataMarketDepthStopInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStopNotSupported.
        /// </summary>
        [DataMember]
        public string DataMarketDepthStopNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketReplayStart.
        /// </summary>
        [DataMember]
        public string DataMarketReplayStart { get; set; }
        /// <summary>
        /// Gets or sets the DataMemBarsExceedsTimeGap.
        /// </summary>
        [DataMember]
        public string DataMemBarsExceedsTimeGap { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeImportError.
        /// </summary>
        [DataMember]
        public string DataMetaStockImportTypeImportError { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInitialize64bitNotSupported.
        /// </summary>
        [DataMember]
        public string DataMetaStockImportTypeInitialize64bitNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInitializeDirectoryError.
        /// </summary>
        [DataMember]
        public string DataMetaStockImportTypeInitializeDirectoryError { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInitializeInvalidSymbol.
        /// </summary>
        [DataMember]
        public string DataMetaStockImportTypeInitializeInvalidSymbol { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInstrumentNotSupported.
        /// </summary>
        [DataMember]
        public string DataMetaStockImportTypeInstrumentNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInvalidTimeStamp.
        /// </summary>
        [DataMember]
        public string DataMetaStockImportTypeInvalidTimeStamp { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeOnlyIntraday.
        /// </summary>
        [DataMember]
        public string DataMetaStockImportTypeOnlyIntraday { get; set; }
        /// <summary>
        /// Gets or sets the DataNewsStartException.
        /// </summary>
        [DataMember]
        public string DataNewsStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataNewsStopException.
        /// </summary>
        [DataMember]
        public string DataNewsStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataSessionBarSimulatorBarsError.
        /// </summary>
        [DataMember]
        public string DataSessionBarSimulatorBarsError { get; set; }
        /// <summary>
        /// Gets or sets the DataSessionBarSimulatorNoBarsFound.
        /// </summary>
        [DataMember]
        public string DataSessionBarSimulatorNoBarsFound { get; set; }
        /// <summary>
        /// Gets or sets the DataSubscribeInstrumentIsNull.
        /// </summary>
        [DataMember]
        public string DataSubscribeInstrumentIsNull { get; set; }
        /// <summary>
        /// Gets or sets the DataSubscribeInWrongThread.
        /// </summary>
        [DataMember]
        public string DataSubscribeInWrongThread { get; set; }
        /// <summary>
        /// Gets or sets the DataTradingHoursUnableLoadTradingHours.
        /// </summary>
        [DataMember]
        public string DataTradingHoursUnableLoadTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the DataTradingHoursUseDataSeriesSettings.
        /// </summary>
        [DataMember]
        public string DataTradingHoursUseDataSeriesSettings { get; set; }
        /// <summary>
        /// Gets or sets the DataTradingHoursUseInstrumentSettings.
        /// </summary>
        [DataMember]
        public string DataTradingHoursUseInstrumentSettings { get; set; }
        /// <summary>
        /// Gets or sets the DbThreadExecute.
        /// </summary>
        [DataMember]
        public string DbThreadExecute { get; set; }
        /// <summary>
        /// Gets or sets the Default.
        /// </summary>
        [DataMember]
        public string Default { get; set; }
        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        [DataMember]
        public string Error { get; set; }
        /// <summary>
        /// Gets or sets the FileFilterAnyWinForms.
        /// </summary>
        [DataMember]
        public string FileFilterAnyWinForms { get; set; }
        /// <summary>
        /// Gets or sets the Gui12Hour.
        /// </summary>
        [DataMember]
        public string Gui12Hour { get; set; }
        /// <summary>
        /// Gets or sets the Gui24Hour.
        /// </summary>
        [DataMember]
        public string Gui24Hour { get; set; }
        /// <summary>
        /// Gets or sets the GuiAccounts.
        /// </summary>
        [DataMember]
        public string GuiAccounts { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdapterServer.
        /// </summary>
        [DataMember]
        public string GuiAdapterServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdjustBalanceBy.
        /// </summary>
        [DataMember]
        public string GuiAdjustBalanceBy { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdmin.
        /// </summary>
        [DataMember]
        public string GuiAdmin { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdminServer.
        /// </summary>
        [DataMember]
        public string GuiAdminServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiAlert.
        /// </summary>
        [DataMember]
        public string GuiAlert { get; set; }
        /// <summary>
        /// Gets or sets the GuiAlertDisabled.
        /// </summary>
        [DataMember]
        public string GuiAlertDisabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiAlertEnabled.
        /// </summary>
        [DataMember]
        public string GuiAlertEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiApplicationType.
        /// </summary>
        [DataMember]
        public string GuiApplicationType { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIAtInterface.
        /// </summary>
        [DataMember]
        public string GuiATIAtInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIDefaultAccount.
        /// </summary>
        [DataMember]
        public string GuiATIDefaultAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIIgnoreDuplicateOifFiles.
        /// </summary>
        [DataMember]
        public string GuiATIIgnoreDuplicateOifFiles { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIServerPort.
        /// </summary>
        [DataMember]
        public string GuiATIServerPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationEmailInterface.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationEmailInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationEmailInterfaceEnabled.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationEmailInterfaceEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationLimitPriceOffset.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationLimitPriceOffset { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationOrderHandingSubmit.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationOrderHandingSubmit { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationOrderHandling.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationOrderHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationStopOrderHandling.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationStopOrderHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationStopOrderHandlingSubmit.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationStopOrderHandlingSubmit { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationSubmitMarketOrderIfStopRejected.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationSubmitMarketOrderIfStopRejected { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationSyncTimeout.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationSyncTimeout { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationUnfilledToMarketDelay.
        /// </summary>
        [DataMember]
        public string GuiATITradeStationUnfilledToMarketDelay { get; set; }
        /// <summary>
        /// Gets or sets the GuiATMStrategy.
        /// </summary>
        [DataMember]
        public string GuiATMStrategy { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePosition.
        /// </summary>
        [DataMember]
        public string GuiAutoClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionEnable.
        /// </summary>
        [DataMember]
        public string GuiAutoClosePositionEnable { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionInstruments.
        /// </summary>
        [DataMember]
        public string GuiAutoClosePositionInstruments { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionInstrumentsPrompt.
        /// </summary>
        [DataMember]
        public string GuiAutoClosePositionInstrumentsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionTime.
        /// </summary>
        [DataMember]
        public string GuiAutoClosePositionTime { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenAccount.
        /// </summary>
        [DataMember]
        public string GuiAutoFlattenAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenAccountEnable.
        /// </summary>
        [DataMember]
        public string GuiAutoFlattenAccountEnable { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenAllPositions.
        /// </summary>
        [DataMember]
        public string GuiAutoFlattenAllPositions { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenTime.
        /// </summary>
        [DataMember]
        public string GuiAutoFlattenTime { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoLiquidation.
        /// </summary>
        [DataMember]
        public string GuiAutoLiquidation { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutomatedTradingInterface.
        /// </summary>
        [DataMember]
        public string GuiAutomatedTradingInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiBP.
        /// </summary>
        [DataMember]
        public string GuiBP { get; set; }
        /// <summary>
        /// Gets or sets the GuiBuy.
        /// </summary>
        [DataMember]
        public string GuiBuy { get; set; }
        /// <summary>
        /// Gets or sets the GuiCalculations.
        /// </summary>
        [DataMember]
        public string GuiCalculations { get; set; }
        /// <summary>
        /// Gets or sets the GuiCancelEntriesOnStrategyDisable.
        /// </summary>
        [DataMember]
        public string GuiCancelEntriesOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the GuiCancelExitsOnStrategyDisable.
        /// </summary>
        [DataMember]
        public string GuiCancelExitsOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the GuiCbiMasterInstrumentDividendsPrompt.
        /// </summary>
        [DataMember]
        public string GuiCbiMasterInstrumentDividendsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiCbiMasterInstrumentSplitsPrompt.
        /// </summary>
        [DataMember]
        public string GuiCbiMasterInstrumentSplitsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiChart.
        /// </summary>
        [DataMember]
        public string GuiChart { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartForceSoftwareRendering.
        /// </summary>
        [DataMember]
        public string GuiChartForceSoftwareRendering { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartPerformanceOutput.
        /// </summary>
        [DataMember]
        public string GuiChartPerformanceOutput { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartRefreshInterval.
        /// </summary>
        [DataMember]
        public string GuiChartRefreshInterval { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartShowThumbnails.
        /// </summary>
        [DataMember]
        public string GuiChartShowThumbnails { get; set; }
        /// <summary>
        /// Gets or sets the GuiCommission.
        /// </summary>
        [DataMember]
        public string GuiCommission { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmClosePosition.
        /// </summary>
        [DataMember]
        public string GuiConfirmClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmOrderCancellation.
        /// </summary>
        [DataMember]
        public string GuiConfirmOrderCancellation { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmOrderChange.
        /// </summary>
        [DataMember]
        public string GuiConfirmOrderChange { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmOrderPlacement.
        /// </summary>
        [DataMember]
        public string GuiConfirmOrderPlacement { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnect.
        /// </summary>
        [DataMember]
        public string GuiConnect { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionAutoSubscribe2Instruments.
        /// </summary>
        [DataMember]
        public string GuiConnectionAutoSubscribe2Instruments { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionBigTickEnvironment.
        /// </summary>
        [DataMember]
        public string GuiConnectionBigTickEnvironment { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionClearUseDemoData.
        /// </summary>
        [DataMember]
        public string GuiConnectionClearUseDemoData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseApiKey.
        /// </summary>
        [DataMember]
        public string GuiConnectionCoinbaseApiKey { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseApiPassphrase.
        /// </summary>
        [DataMember]
        public string GuiConnectionCoinbaseApiPassphrase { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseApiSecret.
        /// </summary>
        [DataMember]
        public string GuiConnectionCoinbaseApiSecret { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseCancelOnDisconnect.
        /// </summary>
        [DataMember]
        public string GuiConnectionCoinbaseCancelOnDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionConnectOnStartup.
        /// </summary>
        [DataMember]
        public string GuiConnectionConnectOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCqgIncludeFX.
        /// </summary>
        [DataMember]
        public string GuiConnectionCqgIncludeFX { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCredentials.
        /// </summary>
        [DataMember]
        public string GuiConnectionCredentials { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCredentialsProvider.
        /// </summary>
        [DataMember]
        public string GuiConnectionCredentialsProvider { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionDemo.
        /// </summary>
        [DataMember]
        public string GuiConnectionDemo { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionDisableL2Data.
        /// </summary>
        [DataMember]
        public string GuiConnectionDisableL2Data { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalDailyHost.
        /// </summary>
        [DataMember]
        public string GuiConnectionESignalDailyHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalIntlTickHost.
        /// </summary>
        [DataMember]
        public string GuiConnectionESignalIntlTickHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalLevel2Host.
        /// </summary>
        [DataMember]
        public string GuiConnectionESignalLevel2Host { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalNewsHost.
        /// </summary>
        [DataMember]
        public string GuiConnectionESignalNewsHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalProxyCategory.
        /// </summary>
        [DataMember]
        public string GuiConnectionESignalProxyCategory { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalTickHost.
        /// </summary>
        [DataMember]
        public string GuiConnectionESignalTickHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalTracing.
        /// </summary>
        [DataMember]
        public string GuiConnectionESignalTracing { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionFxcmPin.
        /// </summary>
        [DataMember]
        public string GuiConnectionFxcmPin { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionGainBrandCode.
        /// </summary>
        [DataMember]
        public string GuiConnectionGainBrandCode { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionGainG2Account.
        /// </summary>
        [DataMember]
        public string GuiConnectionGainG2Account { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionHistoricalDataServer.
        /// </summary>
        [DataMember]
        public string GuiConnectionHistoricalDataServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionHost.
        /// </summary>
        [DataMember]
        public string GuiConnectionHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionHostOptional.
        /// </summary>
        [DataMember]
        public string GuiConnectionHostOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBAutoLogOn.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBAutoLogOn { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBAutoLogonPath.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBAutoLogonPath { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBClientId.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBClientId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBConnectWith.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBConnectWith { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBFxLotSize.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBFxLotSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBLogLevel.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBLogLevel { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBNewApi.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBNewApi { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBPasswordOptional.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBPasswordOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBPortGateway.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBPortGateway { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBPortTws.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBPortTws { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBRuntimePopupHandling.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBRuntimePopupHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBTriggerAfterHours.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBTriggerAfterHours { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBUseUserSettings.
        /// </summary>
        [DataMember]
        public string GuiConnectionIBUseUserSettings { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIsPasswordRequiredOnStartup.
        /// </summary>
        [DataMember]
        public string GuiConnectionIsPasswordRequiredOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionKinetickGlobexNonProFees.
        /// </summary>
        [DataMember]
        public string GuiConnectionKinetickGlobexNonProFees { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionKinetickUseBackAdjusted.
        /// </summary>
        [DataMember]
        public string GuiConnectionKinetickUseBackAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionKinetickUseFundamentalData.
        /// </summary>
        [DataMember]
        public string GuiConnectionKinetickUseFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public string GuiConnectionLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionLogin.
        /// </summary>
        [DataMember]
        public string GuiConnectionLogin { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionLossHandling.
        /// </summary>
        [DataMember]
        public string GuiConnectionLossHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionManageOrders.
        /// </summary>
        [DataMember]
        public string GuiConnectionManageOrders { get; set; }
        /// <summary>
        /// Gets or sets the GUIConnectionMBTShowNavigator.
        /// </summary>
        [DataMember]
        public string GUIConnectionMBTShowNavigator { get; set; }
        /// <summary>
        /// Gets or sets the GUIConnectionMBTUseSnapshot.
        /// </summary>
        [DataMember]
        public string GUIConnectionMBTUseSnapshot { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionModalMaisDigitalSignature.
        /// </summary>
        [DataMember]
        public string GuiConnectionModalMaisDigitalSignature { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionMode.
        /// </summary>
        [DataMember]
        public string GuiConnectionMode { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionName.
        /// </summary>
        [DataMember]
        public string GuiConnectionName { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionNinjaTraderHistoricalDataServer.
        /// </summary>
        [DataMember]
        public string GuiConnectionNinjaTraderHistoricalDataServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionPassword.
        /// </summary>
        [DataMember]
        public string GuiConnectionPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionPasswordOptional.
        /// </summary>
        [DataMember]
        public string GuiConnectionPasswordOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionPort.
        /// </summary>
        [DataMember]
        public string GuiConnectionPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionProvider.
        /// </summary>
        [DataMember]
        public string GuiConnectionProvider { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionRithmicConnection.
        /// </summary>
        [DataMember]
        public string GuiConnectionRithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionRunAsProcess.
        /// </summary>
        [DataMember]
        public string GuiConnectionRunAsProcess { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionSettings.
        /// </summary>
        [DataMember]
        public string GuiConnectionSettings { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionSSL.
        /// </summary>
        [DataMember]
        public string GuiConnectionSSL { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTradovateAccountType.
        /// </summary>
        [DataMember]
        public string GuiConnectionTradovateAccountType { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTradovateUseDevEnv.
        /// </summary>
        [DataMember]
        public string GuiConnectionTradovateUseDevEnv { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTradovateUseNativeHistData.
        /// </summary>
        [DataMember]
        public string GuiConnectionTradovateUseNativeHistData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTAccountNumber.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTAccountNumber { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerHost.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTOrderServerHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerPassword.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTOrderServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerPort.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTOrderServerPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerSenderId.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTOrderServerSenderId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerTargetId.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTOrderServerTargetId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerHost.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTPriceServerHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerPassword.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTPriceServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerPort.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTPriceServerPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerSenderId.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTPriceServerSenderId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerTargetId.
        /// </summary>
        [DataMember]
        public string GuiConnectionTTPriceServerTargetId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionUsePluginData.
        /// </summary>
        [DataMember]
        public string GuiConnectionUsePluginData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionUsername.
        /// </summary>
        [DataMember]
        public string GuiConnectionUsername { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionUsernameOptional.
        /// </summary>
        [DataMember]
        public string GuiConnectionUsernameOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiContracts.
        /// </summary>
        [DataMember]
        public string GuiContracts { get; set; }
        /// <summary>
        /// Gets or sets the GuiCrosshairType.
        /// </summary>
        [DataMember]
        public string GuiCrosshairType { get; set; }
        /// <summary>
        /// Gets or sets the GuiCurrency.
        /// </summary>
        [DataMember]
        public string GuiCurrency { get; set; }
        /// <summary>
        /// Gets or sets the GuiDaily.
        /// </summary>
        [DataMember]
        public string GuiDaily { get; set; }
        /// <summary>
        /// Gets or sets the GuiDark.
        /// </summary>
        [DataMember]
        public string GuiDark { get; set; }
        /// <summary>
        /// Gets or sets the GuiDatabase.
        /// </summary>
        [DataMember]
        public string GuiDatabase { get; set; }
        /// <summary>
        /// Gets or sets the GuiDatabaseOptionsConnectionString.
        /// </summary>
        [DataMember]
        public string GuiDatabaseOptionsConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the GuiDatabaseOptionsDbType.
        /// </summary>
        [DataMember]
        public string GuiDatabaseOptionsDbType { get; set; }
        /// <summary>
        /// Gets or sets the GuiDate.
        /// </summary>
        [DataMember]
        public string GuiDate { get; set; }
        /// <summary>
        /// Gets or sets the GuiDay.
        /// </summary>
        [DataMember]
        public string GuiDay { get; set; }
        /// <summary>
        /// Gets or sets the GuiDenomination.
        /// </summary>
        [DataMember]
        public string GuiDenomination { get; set; }
        /// <summary>
        /// Gets or sets the GuiDisableUI.
        /// </summary>
        [DataMember]
        public string GuiDisableUI { get; set; }
        /// <summary>
        /// Gets or sets the GuiDisconnectDelaySeconds.
        /// </summary>
        [DataMember]
        public string GuiDisconnectDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiDomanName.
        /// </summary>
        [DataMember]
        public string GuiDomanName { get; set; }
        /// <summary>
        /// Gets or sets the GuiDownloadCotData.
        /// </summary>
        [DataMember]
        public string GuiDownloadCotData { get; set; }
        /// <summary>
        /// Gets or sets the GuiDS.
        /// </summary>
        [DataMember]
        public string GuiDS { get; set; }
        /// <summary>
        /// Gets or sets the GuiEnabled.
        /// </summary>
        [DataMember]
        public string GuiEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiExchangesPrompt.
        /// </summary>
        [DataMember]
        public string GuiExchangesPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiGarbageCollection.
        /// </summary>
        [DataMember]
        public string GuiGarbageCollection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneral.
        /// </summary>
        [DataMember]
        public string GuiGeneral { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralDisplayNextStepButton.
        /// </summary>
        [DataMember]
        public string GuiGeneralDisplayNextStepButton { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsConfirmWindowClose.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsConfirmWindowClose { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsDownBrushPrimary.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsDownBrushPrimary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsDownBrushSecondary.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsDownBrushSecondary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsFlipBuySell.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsFlipBuySell { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsGlobalLayoutDocking.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsGlobalLayoutDocking { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsGlobalLinkButton.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsGlobalLinkButton { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsIsDrawingObjectsGlobalAcrossWorkspaces.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsIsDrawingObjectsGlobalAcrossWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMail.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMail { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailAlertMsgs.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMailAlertMsgs { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailPassword.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMailPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailPort.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMailPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailServer.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMailServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailTest.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMailTest { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailUser.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMailUser { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailUseSsl.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsMailUseSsl { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsPerformanceMetrics.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsPerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsPerformanceMetricsPrompt.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsPerformanceMetricsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsReopenWorkspaces.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsReopenWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSaveUsername.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSaveUsername { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShareServicesPrompt.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsShareServicesPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSharingConnections.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSharingConnections { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShowAccountNumbersAndBalances.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsShowAccountNumbersAndBalances { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShowDefaultWorkspaces.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsShowDefaultWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShowToolTips.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsShowToolTips { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAnnouncement.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundAnnouncement { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAutoBreakEven.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundAutoBreakEven { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAutoChase.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundAutoChase { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAutoTrail.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundAutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundCompiledSuccessfully.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundCompiledSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundConnected.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundConnected { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundConnectionLost.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderCanceled.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundOrderCanceled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderFilled.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundOrderFilled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderPending.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundOrderPending { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderSubmitted.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundOrderSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundPlayConsecutively.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundPlayConsecutively { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundReversing.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundReversing { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSounds.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSounds { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundStopFilled.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundStopFilled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundTargetFilled.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSoundTargetFilled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSymbology.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsSymbology { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsTimeZone.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsTimeZone { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsUpBrushPrimary.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsUpBrushPrimary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsUpBrushSecondary.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsUpBrushSecondary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsUseOrderEntryHotKeys.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsUseOrderEntryHotKeys { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsVersionsRecoveryWorkspaces.
        /// </summary>
        [DataMember]
        public string GuiGeneralOptionsVersionsRecoveryWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredCfdConnection.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredCfdConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredConnectionsHistorical.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredConnectionsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredConnectionsRealtime.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredConnectionsRealtime { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredCryptocurrencyConnection.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredCryptocurrencyConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredForexConnection.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredForexConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredFutureConnection.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredFutureConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredIndexConnection.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredIndexConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredOptionConnection.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredOptionConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredStockConnection.
        /// </summary>
        [DataMember]
        public string GuiGeneralPreferredStockConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralSendTestEmail.
        /// </summary>
        [DataMember]
        public string GuiGeneralSendTestEmail { get; set; }
        /// <summary>
        /// Gets or sets the GuiHDS.
        /// </summary>
        [DataMember]
        public string GuiHDS { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistorical.
        /// </summary>
        [DataMember]
        public string GuiHistorical { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAdjustForDividends.
        /// </summary>
        [DataMember]
        public string GuiHistoricalAdjustForDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAdjustForSplitsOnDaily.
        /// </summary>
        [DataMember]
        public string GuiHistoricalAdjustForSplitsOnDaily { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAdjustForSplitsOnIntraday.
        /// </summary>
        [DataMember]
        public string GuiHistoricalAdjustForSplitsOnIntraday { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAutomaticallyChooseTimeBased.
        /// </summary>
        [DataMember]
        public string GuiHistoricalAutomaticallyChooseTimeBased { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalGetDataFromServer.
        /// </summary>
        [DataMember]
        public string GuiHistoricalGetDataFromServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalGlobalMergePolicy.
        /// </summary>
        [DataMember]
        public string GuiHistoricalGlobalMergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalShowTickReplay.
        /// </summary>
        [DataMember]
        public string GuiHistoricalShowTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsFeatures.
        /// </summary>
        [DataMember]
        public string GuiIEXOptionsFeatures { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsFundamentalData.
        /// </summary>
        [DataMember]
        public string GuiIEXOptionsFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsNews.
        /// </summary>
        [DataMember]
        public string GuiIEXOptionsNews { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsRealtimeData.
        /// </summary>
        [DataMember]
        public string GuiIEXOptionsRealtimeData { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvAccountsUsers.
        /// </summary>
        [DataMember]
        public string GuiIsvAccountsUsers { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvActiveOrdersPerAccount.
        /// </summary>
        [DataMember]
        public string GuiIsvActiveOrdersPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvExecutionsPerAccount.
        /// </summary>
        [DataMember]
        public string GuiIsvExecutionsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvOrderRate.
        /// </summary>
        [DataMember]
        public string GuiIsvOrderRate { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvSodsPerAccount.
        /// </summary>
        [DataMember]
        public string GuiIsvSodsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiLanguage.
        /// </summary>
        [DataMember]
        public string GuiLanguage { get; set; }
        /// <summary>
        /// Gets or sets the GuiLight.
        /// </summary>
        [DataMember]
        public string GuiLight { get; set; }
        /// <summary>
        /// Gets or sets the GuiLmt.
        /// </summary>
        [DataMember]
        public string GuiLmt { get; set; }
        /// <summary>
        /// Gets or sets the GuiMail.
        /// </summary>
        [DataMember]
        public string GuiMail { get; set; }
        /// <summary>
        /// Gets or sets the GuiMarketData.
        /// </summary>
        [DataMember]
        public string GuiMarketData { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentContractMonths.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentContractMonths { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentContractMonthsLong.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentContractMonthsLong { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentDescription.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentDescription { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentDividends.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentExchanges.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentExchanges { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentInstrumentType.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentInstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentIsServerSupported.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentIsServerSupported { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentMasterInstrument.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentMergePolicy.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentMergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentPointValue.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentPointValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentRolloverPrompt.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentRolloverPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSimFeedPrice.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentSimFeedPrice { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSplits.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentSplits { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSplitsDividends.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentSplitsDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSymbolMap.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentSymbolMap { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentTickSize.
        /// </summary>
        [DataMember]
        public string GuiMasterInstrumentTickSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterUpdateInstrumentSplitsDividends.
        /// </summary>
        [DataMember]
        public string GuiMasterUpdateInstrumentSplitsDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiMaxOrderSize.
        /// </summary>
        [DataMember]
        public string GuiMaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiMaxPositionSize.
        /// </summary>
        [DataMember]
        public string GuiMaxPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiMinimumCashValue.
        /// </summary>
        [DataMember]
        public string GuiMinimumCashValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiMisc.
        /// </summary>
        [DataMember]
        public string GuiMisc { get; set; }
        /// <summary>
        /// Gets or sets the GuiMit.
        /// </summary>
        [DataMember]
        public string GuiMit { get; set; }
        /// <summary>
        /// Gets or sets the GuiModifyInnerBracket.
        /// </summary>
        [DataMember]
        public string GuiModifyInnerBracket { get; set; }
        /// <summary>
        /// Gets or sets the GuiModifyNearestBracket.
        /// </summary>
        [DataMember]
        public string GuiModifyNearestBracket { get; set; }
        /// <summary>
        /// Gets or sets the GuiMonth.
        /// </summary>
        [DataMember]
        public string GuiMonth { get; set; }
        /// <summary>
        /// Gets or sets the GuiMonthly.
        /// </summary>
        [DataMember]
        public string GuiMonthly { get; set; }
        /// <summary>
        /// Gets or sets the GuiMultiProvider.
        /// </summary>
        [DataMember]
        public string GuiMultiProvider { get; set; }
        /// <summary>
        /// Gets or sets the GuiName.
        /// </summary>
        [DataMember]
        public string GuiName { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScript.
        /// </summary>
        [DataMember]
        public string GuiNinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBarsPeriodCannotCreate.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptBarsPeriodCannotCreate { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBarsPeriodNull.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptBarsPeriodNull { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBarsPeriodTypeExists.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptBarsPeriodTypeExists { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseAlreadyCalled.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptBaseVendorLicenseAlreadyCalled { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseProductLettersDigits.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptBaseVendorLicenseProductLettersDigits { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseVendorNameLettersDigits.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptBaseVendorLicenseVendorNameLettersDigits { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseVendorNameOneCharacter.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptBaseVendorLicenseVendorNameOneCharacter { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptShareServiceOnShareException.
        /// </summary>
        [DataMember]
        public string GuiNinjaScriptShareServiceOnShareException { get; set; }
        /// <summary>
        /// Gets or sets the GuiNoSSL.
        /// </summary>
        [DataMember]
        public string GuiNoSSL { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumberRestartAttempts.
        /// </summary>
        [DataMember]
        public string GuiNumberRestartAttempts { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumberWorkedThreads.
        /// </summary>
        [DataMember]
        public string GuiNumberWorkedThreads { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumericValue.
        /// </summary>
        [DataMember]
        public string GuiNumericValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumGWConnections.
        /// </summary>
        [DataMember]
        public string GuiNumGWConnections { get; set; }
        /// <summary>
        /// Gets or sets the GuiOnConnectionLoss.
        /// </summary>
        [DataMember]
        public string GuiOnConnectionLoss { get; set; }
        /// <summary>
        /// Gets or sets the GuiOrderEntryHotkeysEnabled.
        /// </summary>
        [DataMember]
        public string GuiOrderEntryHotkeysEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiOrderTypeNotSupported.
        /// </summary>
        [DataMember]
        public string GuiOrderTypeNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedCommissions.
        /// </summary>
        [DataMember]
        public string GuiOverwriteModifiedCommissions { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedMasterInstruments.
        /// </summary>
        [DataMember]
        public string GuiOverwriteModifiedMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedRisks.
        /// </summary>
        [DataMember]
        public string GuiOverwriteModifiedRisks { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedTradingHours.
        /// </summary>
        [DataMember]
        public string GuiOverwriteModifiedTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the GuiPort.
        /// </summary>
        [DataMember]
        public string GuiPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiPositionClose.
        /// </summary>
        [DataMember]
        public string GuiPositionClose { get; set; }
        /// <summary>
        /// Gets or sets the GuiPreconfiguredSettings.
        /// </summary>
        [DataMember]
        public string GuiPreconfiguredSettings { get; set; }
        /// <summary>
        /// Gets or sets the GuiPreferences.
        /// </summary>
        [DataMember]
        public string GuiPreferences { get; set; }
        /// <summary>
        /// Gets or sets the GuiPrimaryLicenseServer.
        /// </summary>
        [DataMember]
        public string GuiPrimaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiPrimaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public string GuiPrimaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiPrimaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public string GuiPrimaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the GuiProduct.
        /// </summary>
        [DataMember]
        public string GuiProduct { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryLines.
        /// </summary>
        [DataMember]
        public string GuiPropertyCategoryLines { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryMiscellaneous.
        /// </summary>
        [DataMember]
        public string GuiPropertyCategoryMiscellaneous { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryPlots.
        /// </summary>
        [DataMember]
        public string GuiPropertyCategoryPlots { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryVisual.
        /// </summary>
        [DataMember]
        public string GuiPropertyCategoryVisual { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameAutoScale.
        /// </summary>
        [DataMember]
        public string GuiPropertyNameAutoScale { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameDisplacement.
        /// </summary>
        [DataMember]
        public string GuiPropertyNameDisplacement { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameDisplayInDataBox.
        /// </summary>
        [DataMember]
        public string GuiPropertyNameDisplayInDataBox { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNamePanel.
        /// </summary>
        [DataMember]
        public string GuiPropertyNamePanel { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNamePriceMarkers.
        /// </summary>
        [DataMember]
        public string GuiPropertyNamePriceMarkers { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameScaleJustification.
        /// </summary>
        [DataMember]
        public string GuiPropertyNameScaleJustification { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyValuePlot.
        /// </summary>
        [DataMember]
        public string GuiPropertyValuePlot { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealizedPnlIncludesCommissions.
        /// </summary>
        [DataMember]
        public string GuiRealizedPnlIncludesCommissions { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtime.
        /// </summary>
        [DataMember]
        public string GuiRealtime { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtimeFilterBadTicks.
        /// </summary>
        [DataMember]
        public string GuiRealtimeFilterBadTicks { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtimeFilterBadTicksPercent.
        /// </summary>
        [DataMember]
        public string GuiRealtimeFilterBadTicksPercent { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtimeRecordForPlayback.
        /// </summary>
        [DataMember]
        public string GuiRealtimeRecordForPlayback { get; set; }
        /// <summary>
        /// Gets or sets the GuiRecordLiveDataAsHistorical.
        /// </summary>
        [DataMember]
        public string GuiRecordLiveDataAsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the GuiRecordSimFeedData.
        /// </summary>
        [DataMember]
        public string GuiRecordSimFeedData { get; set; }
        /// <summary>
        /// Gets or sets the GuiRestartsWithinMinutes.
        /// </summary>
        [DataMember]
        public string GuiRestartsWithinMinutes { get; set; }
        /// <summary>
        /// Gets or sets the GuiRisk.
        /// </summary>
        [DataMember]
        public string GuiRisk { get; set; }
        /// <summary>
        /// Gets or sets the GuiRiskManagement.
        /// </summary>
        [DataMember]
        public string GuiRiskManagement { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsExcessPositionMarginLimit.
        /// </summary>
        [DataMember]
        public string GuiRmsOptionsExcessPositionMarginLimit { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxAccountLossPercentage.
        /// </summary>
        [DataMember]
        public string GuiRmsOptionsMaxAccountLossPercentage { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxBidAskSpread.
        /// </summary>
        [DataMember]
        public string GuiRmsOptionsMaxBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxLiquidationValue.
        /// </summary>
        [DataMember]
        public string GuiRmsOptionsMaxLiquidationValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxOrderSize.
        /// </summary>
        [DataMember]
        public string GuiRmsOptionsMaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsOnBehalfOf.
        /// </summary>
        [DataMember]
        public string GuiRmsOptionsOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the GuiRunWebServer.
        /// </summary>
        [DataMember]
        public string GuiRunWebServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecond.
        /// </summary>
        [DataMember]
        public string GuiSecond { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecondaryLicenseServer.
        /// </summary>
        [DataMember]
        public string GuiSecondaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecondaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public string GuiSecondaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecondaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public string GuiSecondaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the GuiSeconds.
        /// </summary>
        [DataMember]
        public string GuiSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiSell.
        /// </summary>
        [DataMember]
        public string GuiSell { get; set; }
        /// <summary>
        /// Gets or sets the GuiServer.
        /// </summary>
        [DataMember]
        public string GuiServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerDataPort.
        /// </summary>
        [DataMember]
        public string GuiServerDataPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerDataWebPort.
        /// </summary>
        [DataMember]
        public string GuiServerDataWebPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerDomainName.
        /// </summary>
        [DataMember]
        public string GuiServerDomainName { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerFanOutMilliSeconds.
        /// </summary>
        [DataMember]
        public string GuiServerFanOutMilliSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerId.
        /// </summary>
        [DataMember]
        public string GuiServerId { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerName.
        /// </summary>
        [DataMember]
        public string GuiServerName { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerNetworkInterface.
        /// </summary>
        [DataMember]
        public string GuiServerNetworkInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerRecorderCantRMSOnlyInstrumentError.
        /// </summary>
        [DataMember]
        public string GuiServerRecorderCantRMSOnlyInstrumentError { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerSystem.
        /// </summary>
        [DataMember]
        public string GuiServerSystem { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerTradingPort.
        /// </summary>
        [DataMember]
        public string GuiServerTradingPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerTradingWebPort.
        /// </summary>
        [DataMember]
        public string GuiServerTradingWebPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerUseNagleForFanningOutData.
        /// </summary>
        [DataMember]
        public string GuiServerUseNagleForFanningOutData { get; set; }
        /// <summary>
        /// Gets or sets the GuiShares.
        /// </summary>
        [DataMember]
        public string GuiShares { get; set; }
        /// <summary>
        /// Gets or sets the GuiShareServiceProperties.
        /// </summary>
        [DataMember]
        public string GuiShareServiceProperties { get; set; }
        /// <summary>
        /// Gets or sets the GuiSignInWithApple.
        /// </summary>
        [DataMember]
        public string GuiSignInWithApple { get; set; }
        /// <summary>
        /// Gets or sets the GuiSignInWithGoogle.
        /// </summary>
        [DataMember]
        public string GuiSignInWithGoogle { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatedOrderAsYellow.
        /// </summary>
        [DataMember]
        public string GuiSimulatedOrderAsYellow { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulationAccountsPrompt.
        /// </summary>
        [DataMember]
        public string GuiSimulationAccountsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulationColor.
        /// </summary>
        [DataMember]
        public string GuiSimulationColor { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulator.
        /// </summary>
        [DataMember]
        public string GuiSimulator { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorDelayExchange.
        /// </summary>
        [DataMember]
        public string GuiSimulatorDelayExchange { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorDelayInternet.
        /// </summary>
        [DataMember]
        public string GuiSimulatorDelayInternet { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorEnforceImmediateFills.
        /// </summary>
        [DataMember]
        public string GuiSimulatorEnforceImmediateFills { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorEnforcePartialFills.
        /// </summary>
        [DataMember]
        public string GuiSimulatorEnforcePartialFills { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorFxLotSize.
        /// </summary>
        [DataMember]
        public string GuiSimulatorFxLotSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorInitialCash.
        /// </summary>
        [DataMember]
        public string GuiSimulatorInitialCash { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorLocalOcoCancelBehavior.
        /// </summary>
        [DataMember]
        public string GuiSimulatorLocalOcoCancelBehavior { get; set; }
        /// <summary>
        /// Gets or sets the GuiSkin.
        /// </summary>
        [DataMember]
        public string GuiSkin { get; set; }
        /// <summary>
        /// Gets or sets the GuiSkinSelection.
        /// </summary>
        [DataMember]
        public string GuiSkinSelection { get; set; }
        /// <summary>
        /// Gets or sets the GuiSlm.
        /// </summary>
        [DataMember]
        public string GuiSlm { get; set; }
        /// <summary>
        /// Gets or sets the GuiSound.
        /// </summary>
        [DataMember]
        public string GuiSound { get; set; }
        /// <summary>
        /// Gets or sets the GuiStartInGlobalSimulationMode.
        /// </summary>
        [DataMember]
        public string GuiStartInGlobalSimulationMode { get; set; }
        /// <summary>
        /// Gets or sets the GuiStp.
        /// </summary>
        [DataMember]
        public string GuiStp { get; set; }
        /// <summary>
        /// Gets or sets the GuiStrategies.
        /// </summary>
        [DataMember]
        public string GuiStrategies { get; set; }
        /// <summary>
        /// Gets or sets the GuiSubmittingOrderToActiveAtm.
        /// </summary>
        [DataMember]
        public string GuiSubmittingOrderToActiveAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiSubmittingOrderWithAtm.
        /// </summary>
        [DataMember]
        public string GuiSubmittingOrderWithAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiSubmittingOrderWithoutAtm.
        /// </summary>
        [DataMember]
        public string GuiSubmittingOrderWithoutAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiTest.
        /// </summary>
        [DataMember]
        public string GuiTest { get; set; }
        /// <summary>
        /// Gets or sets the GuiTicksPerSecond.
        /// </summary>
        [DataMember]
        public string GuiTicksPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the GuiTimerMilliseconds.
        /// </summary>
        [DataMember]
        public string GuiTimerMilliseconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiTrace.
        /// </summary>
        [DataMember]
        public string GuiTrace { get; set; }
        /// <summary>
        /// Gets or sets the GuiTrading.
        /// </summary>
        [DataMember]
        public string GuiTrading { get; set; }
        /// <summary>
        /// Gets or sets the GuiTradingOptionsPositionCloseWaitMilliSeconds.
        /// </summary>
        [DataMember]
        public string GuiTradingOptionsPositionCloseWaitMilliSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiType.
        /// </summary>
        [DataMember]
        public string GuiType { get; set; }
        /// <summary>
        /// Gets or sets the GuiUnits.
        /// </summary>
        [DataMember]
        public string GuiUnits { get; set; }
        /// <summary>
        /// Gets or sets the GuiUrl.
        /// </summary>
        [DataMember]
        public string GuiUrl { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public string GuiUseFifo4AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseLastPrice4AutoTrail.
        /// </summary>
        [DataMember]
        public string GuiUseLastPrice4AutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseLastPriceForProfitLossCalc.
        /// </summary>
        [DataMember]
        public string GuiUseLastPriceForProfitLossCalc { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseLegacyCompiler.
        /// </summary>
        [DataMember]
        public string GuiUseLegacyCompiler { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseServerAtm.
        /// </summary>
        [DataMember]
        public string GuiUseServerAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiValue.
        /// </summary>
        [DataMember]
        public string GuiValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseUnableVerifyVendorLicense.
        /// </summary>
        [DataMember]
        public string GuiVendorLicenseUnableVerifyVendorLicense { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseVerifyingFreeTrialPrimaryServer.
        /// </summary>
        [DataMember]
        public string GuiVendorLicenseVerifyingFreeTrialPrimaryServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseVerifyingFreeTrialSecondaryServer.
        /// </summary>
        [DataMember]
        public string GuiVendorLicenseVerifyingFreeTrialSecondaryServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseVerifyingLocalHarddrive.
        /// </summary>
        [DataMember]
        public string GuiVendorLicenseVerifyingLocalHarddrive { get; set; }
        /// <summary>
        /// Gets or sets the GuiWebSocketPort.
        /// </summary>
        [DataMember]
        public string GuiWebSocketPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiWeekly.
        /// </summary>
        [DataMember]
        public string GuiWeekly { get; set; }
        /// <summary>
        /// Gets or sets the GuiWeeks.
        /// </summary>
        [DataMember]
        public string GuiWeeks { get; set; }
        /// <summary>
        /// Gets or sets the GuiYearly.
        /// </summary>
        [DataMember]
        public string GuiYearly { get; set; }
        /// <summary>
        /// Gets or sets the GuiYears.
        /// </summary>
        [DataMember]
        public string GuiYears { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseEndDate.
        /// </summary>
        [DataMember]
        public string IndicatorSuperDomBaseEndDate { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseIsStableSession.
        /// </summary>
        [DataMember]
        public string IndicatorSuperDomBaseIsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseIsTickReplay.
        /// </summary>
        [DataMember]
        public string IndicatorSuperDomBaseIsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseRangeType.
        /// </summary>
        [DataMember]
        public string IndicatorSuperDomBaseRangeType { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseStartDate.
        /// </summary>
        [DataMember]
        public string IndicatorSuperDomBaseStartDate { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseTradingHoursTemplate.
        /// </summary>
        [DataMember]
        public string IndicatorSuperDomBaseTradingHoursTemplate { get; set; }
        /// <summary>
        /// Gets or sets the LogDisableAttachOrderToIndicator.
        /// </summary>
        [DataMember]
        public string LogDisableAttachOrderToIndicator { get; set; }
        /// <summary>
        /// Gets or sets the LogEnableAttachOrderToIndicator.
        /// </summary>
        [DataMember]
        public string LogEnableAttachOrderToIndicator { get; set; }
        /// <summary>
        /// Gets or sets the MailSentSuccessfully.
        /// </summary>
        [DataMember]
        public string MailSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the MailSentUnsuccessfully.
        /// </summary>
        [DataMember]
        public string MailSentUnsuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAdapter.
        /// </summary>
        [DataMember]
        public string NinjaScriptAdapter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAddOn.
        /// </summary>
        [DataMember]
        public string NinjaScriptAddOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjascriptAddOnBaseLegacyAtmUseNotAllowed.
        /// </summary>
        [DataMember]
        public string NinjascriptAddOnBaseLegacyAtmUseNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertAction.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertAction { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertActions.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertActions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionDynamicOffset.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertConditionDynamicOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionItemFormat.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertConditionItemFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionOffset.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertConditionOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditions.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertConditions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionsOperator.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertConditionsOperator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertDefaultMessage.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertDefaultMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertMessage.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertOffset.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertOffsetType.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertOffsetType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertPriority.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertPriority { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertRearmSeconds.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertRearmSeconds { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertRearmType.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertRearmType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertScreenshotType.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertScreenshotType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsDynamicMessageDetailsString.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertsDynamicMessageDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertShareService.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertShareService { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsNoMessage.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertsNoMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsNoSoundFile.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertsNoSoundFile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsPlaySoundDetailsString.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertsPlaySoundDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsShareDetailsString.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertsShareDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsShowMessageDetailsString.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertsShowMessageDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsSubmitOrderDetailsString.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertsSubmitOrderDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertUsingAtmStrategy.
        /// </summary>
        [DataMember]
        public string NinjaScriptAlertUsingAtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategy.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyActiveCustom.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyActiveCustom { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCancellingOrders.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyCancellingOrders { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCanChangeExitOrder1.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyCanChangeExitOrder1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCanChangeExitOrder2.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyCanChangeExitOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCantChangeOrder.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyCantChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyClosingPositionStrategy.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyClosingPositionStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyEntryOrderNotFilledYet.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyEntryOrderNotFilledYet { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyLoadTemplateError.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyLoadTemplateError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyNone.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyNone { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyShadowError.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyShadowError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyTifConverted.
        /// </summary>
        [DataMember]
        public string NinjaScriptAtmStrategyTifConverted { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsRequestError.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsRequestError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsType.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeMinute.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigure.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBuyColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptBuyColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptCellConditionBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptCellConditionForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionGeneral.
        /// </summary>
        [DataMember]
        public string NinjaScriptCellConditionGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionText.
        /// </summary>
        [DataMember]
        public string NinjaScriptCellConditionText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionToString.
        /// </summary>
        [DataMember]
        public string NinjaScriptCellConditionToString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBase.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAccount.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseAccount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAlert.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseAlert { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAlertDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseAlertDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAltBarColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseAltBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarGraphGrowthMaxValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseBarGraphGrowthMaxValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarGraphGrowthType.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseBarGraphGrowthType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarGraphReferenceValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseBarGraphReferenceValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarsToLoad.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseBarsToLoad { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseCell.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseCell { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseCellDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseCellDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorDistribution.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseColorDistribution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMaxBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseColorMaxBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMaxForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseColorMaxForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMinBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseColorMinBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMinForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseColorMinForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseConditionPrompt.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseConditionPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseConditions.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseConditions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseDaysBack.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseDaysBack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseEnableColorDistribution.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseEnableColorDistribution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseEndDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseEndDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseFilter.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseFilter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseFilterDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseFilterDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseGeneral.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseIndicator.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseIndicator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseIsStableSession.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseIsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseIsTickReplay.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseIsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseLoadDataBasedOn.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseLoadDataBasedOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseLoadingText.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseLoadingText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseMaxValueRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseMaxValueRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseMinValueRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseMinValueRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBasePlot.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBasePlot { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseShowInTotalRow.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseShowInTotalRow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseStartDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseStartDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseTradingHoursTemplate.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseTradingHoursTemplate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseVisible.
        /// </summary>
        [DataMember]
        public string NinjaScriptColumnBaseVisible { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCommissionTemplate.
        /// </summary>
        [DataMember]
        public string NinjaScriptCommissionTemplate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionApplyTo.
        /// </summary>
        [DataMember]
        public string NinjaScriptConditionApplyTo { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionCondition.
        /// </summary>
        [DataMember]
        public string NinjaScriptConditionCondition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionTrigger.
        /// </summary>
        [DataMember]
        public string NinjaScriptConditionTrigger { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptConditionValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionValueValidationError.
        /// </summary>
        [DataMember]
        public string NinjaScriptConditionValueValidationError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDataSeries.
        /// </summary>
        [DataMember]
        public string NinjaScriptDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDataSessionIteratorWrongConstructor.
        /// </summary>
        [DataMember]
        public string NinjaScriptDataSessionIteratorWrongConstructor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDaysToLoad.
        /// </summary>
        [DataMember]
        public string NinjaScriptDaysToLoad { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDeafultFillTypeName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDeafultFillTypeName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDisplayText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDisplayText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDisplayType.
        /// </summary>
        [DataMember]
        public string NinjaScriptDisplayType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDisplayUnit.
        /// </summary>
        [DataMember]
        public string NinjaScriptDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolShapesSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolShapesSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDuplicatePlotOrLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptDuplicatePlotOrLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFillType.
        /// </summary>
        [DataMember]
        public string NinjaScriptFillType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFilterConditionGeneral.
        /// </summary>
        [DataMember]
        public string NinjaScriptFilterConditionGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFilterConditionMatchesAll.
        /// </summary>
        [DataMember]
        public string NinjaScriptFilterConditionMatchesAll { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFilterConditionToString.
        /// </summary>
        [DataMember]
        public string NinjaScriptFilterConditionToString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneratedStrategyLogicBaseClassNameNotFound.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneratedStrategyLogicBaseClassNameNotFound { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneratedStrategyLogicBaseTypeNotFound.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneratedStrategyLogicBaseTypeNotFound { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneratedStrategyLogicBaseWrongType.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneratedStrategyLogicBaseWrongType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerProperties.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGetDayBarPriorTradingDay.
        /// </summary>
        [DataMember]
        public string NinjaScriptGetDayBarPriorTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptImportType.
        /// </summary>
        [DataMember]
        public string NinjaScriptImportType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptImportTypeMetaStock.
        /// </summary>
        [DataMember]
        public string NinjaScriptImportTypeMetaStock { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIncludeCommission.
        /// </summary>
        [DataMember]
        public string NinjaScriptIncludeCommission { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseDisplayNameOf.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBaseDisplayNameOf { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColumnDisplayName.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColumnDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColumnGetPlotError.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColumnGetPlotError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInput.
        /// </summary>
        [DataMember]
        public string NinjaScriptInput { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInputPrompt.
        /// </summary>
        [DataMember]
        public string NinjaScriptInputPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInstrument.
        /// </summary>
        [DataMember]
        public string NinjaScriptInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInvalidBaseBarsPeriodType.
        /// </summary>
        [DataMember]
        public string NinjaScriptInvalidBaseBarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInvalidStateForMethod.
        /// </summary>
        [DataMember]
        public string NinjaScriptInvalidStateForMethod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInvalidStateForProperty.
        /// </summary>
        [DataMember]
        public string NinjaScriptInvalidStateForProperty { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLabel.
        /// </summary>
        [DataMember]
        public string NinjaScriptLabel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLimitPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartMiniColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartMiniOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartMiniOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniSpan.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartMiniSpan { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeDownArea.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartNetChangeDownArea { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeDownOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartNetChangeDownOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeUpArea.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartNetChangeUpArea { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeUpOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnChartNetChangeUpOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendAboveAsk.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnTSTrendAboveAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendAtAsk.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnTSTrendAtAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendAtBid.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnTSTrendAtBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendBarWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnTSTrendBarWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendBelowBid.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnTSTrendBelowBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendBetween.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnTSTrendBetween { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptName.
        /// </summary>
        [DataMember]
        public string NinjaScriptName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNegativeBackgroundColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptNegativeBackgroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNegativeForegroundColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptNegativeForegroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAccountNotConnected.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAccountNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidBarsPeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddDataSeriesInvalidBarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidInstrumentName.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddDataSeriesInvalidInstrumentName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidMarketDataType.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddDataSeriesInvalidMarketDataType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidTradingHoursName.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddDataSeriesInvalidTradingHoursName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesNegativePeriodValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddDataSeriesNegativePeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAdditionalDataError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAdditionalDataError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddKagi.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddKagi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddLineBreak.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddLineBreak { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddPointAndFigure.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddPointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddSeries.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAddSeries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAtmStrategyIdAlreadyUsed.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAtmStrategyIdAlreadyUsed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAtmStrategyTerminated.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAtmStrategyTerminated { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAtmStratgyIdDoesNotExist.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseAtmStratgyIdDoesNotExist { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseBeforeEvent.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseBeforeEvent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseClosePosition.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseCountIfException.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseCountIfException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseCountIfPeriodError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseCountIfPeriodError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentAsk.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseGetCurrentAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentAskVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseGetCurrentAskVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentBid.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseGetCurrentBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentBidVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseGetCurrentBidVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetExceptionMessage.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseGetExceptionMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetSetError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseGetSetError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetSetError2.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseGetSetError2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseInitializeBarsPoolError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseInitializeBarsPoolError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseInvalidOrderName.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseInvalidOrderName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLimitAndStopPriceRequired.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseLimitAndStopPriceRequired { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLimitPriceZero.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseLimitPriceZero { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLroException.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseLroException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLroInstanceError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseLroInstanceError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLroLookBackPeriodError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseLroLookBackPeriodError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMissingAtmStrategyId.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseMissingAtmStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMissingLimitOrStopPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseMissingLimitOrStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMissingOrderId.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseMissingOrderId { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMroException.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseMroException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMroInstanceError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseMroInstanceError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMroLockBackPeriodError.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseMroLockBackPeriodError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseNotInRealtimeState.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseNotInRealtimeState { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseOrderIdAlreadyUsed.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseOrderIdAlreadyUsed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseOrderIdDoesNotExist.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseOrderIdDoesNotExist { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBasePlotDefaultName.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBasePlotDefaultName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseSimulationMode.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseSimulationMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseSlopeArguments.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseSlopeArguments { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseStopPriceZero.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseStopPriceZero { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTemplateNameMissing.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseTemplateNameMissing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTickReplayLast.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseTickReplayLast { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTifNotSupported.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseTifNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTriggerCustomEvent.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseTriggerCustomEvent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTriggerCustomEventException.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptBaseTriggerCustomEventException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptCustomMethodError1.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptCustomMethodError1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptCustomMethodError2.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptCustomMethodError2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptErrorSerializing.
        /// </summary>
        [DataMember]
        public string NinjaScriptNinjaScriptErrorSerializing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNoAccount.
        /// </summary>
        [DataMember]
        public string NinjaScriptNoAccount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNoInstrument.
        /// </summary>
        [DataMember]
        public string NinjaScriptNoInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimize.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizer.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerFitness.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizerFitness { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerKeepBestResults.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizerKeepBestResults { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerMultiObjectiveOptimizeOn.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizerMultiObjectiveOptimizeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerMultiObjectivePrompt.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizerMultiObjectivePrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOrderAction.
        /// </summary>
        [DataMember]
        public string NinjaScriptOrderAction { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOrderType.
        /// </summary>
        [DataMember]
        public string NinjaScriptOrderType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterIncrement.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameterIncrement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterMax.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameterMax { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterMin.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameterMin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameters.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterSetPropertyValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameterSetPropertyValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterSetPropertyValueInvalidType.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameterSetPropertyValueInvalidType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPerformanceBase.
        /// </summary>
        [DataMember]
        public string NinjaScriptPerformanceBase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPerformanceMetric.
        /// </summary>
        [DataMember]
        public string NinjaScriptPerformanceMetric { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlotAutoWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptPlotAutoWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlots.
        /// </summary>
        [DataMember]
        public string NinjaScriptPlots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlotStyle.
        /// </summary>
        [DataMember]
        public string NinjaScriptPlotStyle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPositiveBackgroundColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptPositiveBackgroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPositiveForegroundColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptPositiveForegroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPriceTypeLowercase.
        /// </summary>
        [DataMember]
        public string NinjaScriptPriceTypeLowercase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptProperties.
        /// </summary>
        [DataMember]
        public string NinjaScriptProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptQuantity.
        /// </summary>
        [DataMember]
        public string NinjaScriptQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSellColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptSellColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSensitivity.
        /// </summary>
        [DataMember]
        public string NinjaScriptSensitivity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSeries256Error.
        /// </summary>
        [DataMember]
        public string NinjaScriptSeries256Error { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSeriesBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptSeriesBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSetup.
        /// </summary>
        [DataMember]
        public string NinjaScriptSetup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptShareService.
        /// </summary>
        [DataMember]
        public string NinjaScriptShareService { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptShareServiceCannotFindName.
        /// </summary>
        [DataMember]
        public string NinjaScriptShareServiceCannotFindName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStartegyBaseBarsSince.
        /// </summary>
        [DataMember]
        public string NinjaScriptStartegyBaseBarsSince { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStopCancelClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptStopCancelClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStopPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategy.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAccount.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyAccount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAccountSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyAccountSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAggregated.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyAggregated { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAIGenerate.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyAIGenerate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptAccountPosition.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseAdoptAccountPosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptPosition1.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseAdoptPosition1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptPosition2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseAdoptPosition2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptPosition3.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseAdoptPosition3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCancelExpiredOrders.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseCancelExpiredOrders { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCancelOrderUnmanaged.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseCancelOrderUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseChangeOrderUnmanaged.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseChangeOrderUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseClosePosition.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCopyTo.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseCopyTo { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCreateOrderError.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseCreateOrderError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseDbFromCommand1.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseDbFromCommand1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseDbFromCommand2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseDbFromCommand2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseDisabling.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseDisabling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseEnabling1.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseEnabling1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseEnabling2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseEnabling2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseExitOnSessionClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseExitOnSessionClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseExitOnSessionCloseHandling.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseExitOnSessionCloseHandling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseGetOptimizationParameters.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseGetOptimizationParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseGetTradingHours.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseGetTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData_Duplicate_1_.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData_Duplicate_1_ { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseInstantiateOnEachOptimizationIteration.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseInstantiateOnEachOptimizationIteration { get; set; }
        /// <summary>
        /// Gets or sets the NinjascriptStrategyBaseLegacyAtmUseNotAllowed.
        /// </summary>
        [DataMember]
        public string NinjascriptStrategyBaseLegacyAtmUseNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLoadError.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLoadError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostConnectionDisable.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostConnectionDisable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionDisable.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostOrderConnectionDisable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionKeepRunning.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostOrderConnectionKeepRunning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionRecalculate.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostOrderConnectionRecalculate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionRecalculate2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostOrderConnectionRecalculate2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostPriceConnectionDisable.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostPriceConnectionDisable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostPriceConnectionKeepRunning.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostPriceConnectionKeepRunning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostPriceConnectionRecalculate.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseLostPriceConnectionRecalculate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseNoTickReplay.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseNoTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderError.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOrderError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderErrorCancelTimeOut.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOrderErrorCancelTimeOut { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderFillResolutionHighError1.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOrderFillResolutionHighError1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderFillResolutionHighError2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOrderFillResolutionHighError2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderFillResolutionHighError3.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOrderFillResolutionHighError3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderHistoricalToLive.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOrderHistoricalToLive { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOverFill.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOverFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOverFillCancelTimeOut.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseOverFillCancelTimeOut { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBasePositions.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBasePositions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseProcessBacktestOrdersEod.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseProcessBacktestOrdersEod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseProcessBacktestOrdersOco.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseProcessBacktestOrdersOco { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseProcessBacktestOrdersOppositeSide.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseProcessBacktestOrdersOppositeSide { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBasePropertyError.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBasePropertyError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAlreadySubmitted.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetAlreadySubmitted { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedParabolicStopOrder2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetAmendedParabolicStopOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedStopOrder2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetAmendedStopOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedTargetOrder2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetAmendedTargetOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedTrailStopOrder2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetAmendedTrailStopOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetHistorical.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetHistorical { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetIgnore.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetIgnore { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetTrace.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSetStopTargetTrace { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderBarsInProgress.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderBarsInProgress { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTrade.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTrade { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTradedNotMet.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTradedNotMet { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderEntryOrder.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderEntryOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderExitOrder.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderExitOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderGenericStopPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderGenericStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderInvalidQuantity.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderInvalidQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderInvalidState.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderInvalidState { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManaged.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedAmended.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedAmended { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedAmendMatchingOrder.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedAmendMatchingOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedIgnore.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedIgnore { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedInvalidEnterOrder.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedInvalidEnterOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedInvalidExitOrder.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedInvalidExitOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedInvalidPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedInvalidPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedMatchingOrderExists.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedMatchingOrderExists { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedNoMatchingSignal.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedNoMatchingSignal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedNoPosition.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedNoPosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedNoRemainingQty.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedNoRemainingQty { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedQty2Small.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedQty2Small { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedQty2Small2.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedQty2Small2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedQuantity.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedSignalExcess.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedSignalExcess { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedTrace.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedTrace { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedUnchanged.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderManagedUnchanged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderOnlyUnmanaged.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderOnlyUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderUnmanagedIgnore.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderUnmanagedIgnore { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderUnmanagedTrace.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSubmitOrderUnmanagedTrace { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSyncAfterFlat.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSyncAfterFlat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSynchronize.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseSynchronize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseTifNotSupported.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseTifNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseUnableToCancelLiveOrders.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseUnableToCancelLiveOrders { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseVirtualEntryExecution.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyBaseVirtualEntryExecution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyCalculate.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyCalculate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDefaultQuantity.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyDefaultQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyEntriesPerDirection.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyEntriesPerDirection { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyEntryHandling.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyEntryHandling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyExitOnSessionClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyExitOnSessionClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyExitOnSessionCloseSeconds.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyExitOnSessionCloseSeconds { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyFillLimitOrderOnTouch.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyFillLimitOrderOnTouch { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorDayOfWeek.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorDayOfWeek { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorEntries.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorEntries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorExits.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorExits { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorProperties.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseCandleStickPattern.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseCandleStickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseIndicators.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseIndicators { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseParabolicStop.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseParabolicStop { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseSessionClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseSessionClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseSessionTime.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseSessionTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseStopTargets.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseStopTargets { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyHistoricalFillProcessing.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyHistoricalFillProcessing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyIsStableSession.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyIsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyIsTickReplay.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyIsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyMaximumBaseLookBack.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyMaximumBaseLookBack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyMinimumBarsRequired.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyMinimumBarsRequired { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizationFitness.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOptimizationFitness { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizationPeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOptimizationPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizeDataSeries.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOptimizeDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizer.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOptimizer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderFillResolution.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOrderFillResolution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderFillResolutionType.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOrderFillResolutionType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderFillResolutionValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOrderFillResolutionValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderHandling.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOrderHandling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderProperties.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyOrderProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyParameters.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategySetOrderQuantity.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategySetOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategySlippage.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategySlippage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyStartBehavior.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyStartBehavior { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyStopTargetSubmission.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyStopTargetSubmission { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategySubmittingOrder.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategySubmittingOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTestPeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyTestPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTimeInForce.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyTimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTradingHours.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTradingHoursTemplate.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyTradingHoursTemplate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitOrderSignalLength.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitOrderSignalLength { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetCalculationMode.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitStopTargetCalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetCurrency.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitStopTargetCurrency { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetNow.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitStopTargetNow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetParabolicStopPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitStopTargetParabolicStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetStopPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitStopTargetStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetTargetPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitStopTargetTargetPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetTrailStopPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptSubmitStopTargetTrailStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumn.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomIndicatorBase.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomIndicatorBase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTimeFrame.
        /// </summary>
        [DataMember]
        public string NinjaScriptTimeFrame { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTimeframeFrom.
        /// </summary>
        [DataMember]
        public string NinjaScriptTimeframeFrom { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTimeframeTo.
        /// </summary>
        [DataMember]
        public string NinjaScriptTimeframeTo { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptUnfrozenBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptUnfrozenBrush { get; set; }
        /// <summary>
        /// Gets or sets the OnlyApplicationTypeGW.
        /// </summary>
        [DataMember]
        public string OnlyApplicationTypeGW { get; set; }
        /// <summary>
        /// Gets or sets the PositionRemoveFirstExecutionCancel.
        /// </summary>
        [DataMember]
        public string PositionRemoveFirstExecutionCancel { get; set; }
        /// <summary>
        /// Gets or sets the PositionRemoveFirstExecutionChange.
        /// </summary>
        [DataMember]
        public string PositionRemoveFirstExecutionChange { get; set; }
        /// <summary>
        /// Gets or sets the PropertyCategoryDataSeries.
        /// </summary>
        [DataMember]
        public string PropertyCategoryDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the PropertyCategoryVisual.
        /// </summary>
        [DataMember]
        public string PropertyCategoryVisual { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameAutoWidth.
        /// </summary>
        [DataMember]
        public string PropertyNameAutoWidth { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameBrush.
        /// </summary>
        [DataMember]
        public string PropertyNameBrush { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameDashStyle.
        /// </summary>
        [DataMember]
        public string PropertyNameDashStyle { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameIsVisible.
        /// </summary>
        [DataMember]
        public string PropertyNameIsVisible { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameOpacityPercent.
        /// </summary>
        [DataMember]
        public string PropertyNameOpacityPercent { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameThickness.
        /// </summary>
        [DataMember]
        public string PropertyNameThickness { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeFundamentalData.
        /// </summary>
        [DataMember]
        public string SampleAdapterCannotSubscribeFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeHotlist.
        /// </summary>
        [DataMember]
        public string SampleAdapterCannotSubscribeHotlist { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeMarketData.
        /// </summary>
        [DataMember]
        public string SampleAdapterCannotSubscribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeMarketDepth.
        /// </summary>
        [DataMember]
        public string SampleAdapterCannotSubscribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeNews.
        /// </summary>
        [DataMember]
        public string SampleAdapterCannotSubscribeNews { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubcribeMarketData.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorSubcribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubcribeMarketDepth.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorSubcribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubcribeNews.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorSubcribeNews { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubscribeFundamentalData.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorSubscribeFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubscribeHotlist.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorSubscribeHotlist { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeFundamentalData.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorUnsubcribeFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeHotlist.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorUnsubcribeHotlist { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeMarketData.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorUnsubcribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeMarketDepth.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorUnsubcribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeNews.
        /// </summary>
        [DataMember]
        public string SampleAdapterErrorUnsubcribeNews { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterHotlistUnknownInstrument.
        /// </summary>
        [DataMember]
        public string SampleAdapterHotlistUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterNoContinuousContracts.
        /// </summary>
        [DataMember]
        public string SampleAdapterNoContinuousContracts { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterRequestBarsException.
        /// </summary>
        [DataMember]
        public string SampleAdapterRequestBarsException { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterRequestHotlistNamesException.
        /// </summary>
        [DataMember]
        public string SampleAdapterRequestHotlistNamesException { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterResolveInstrumentException.
        /// </summary>
        [DataMember]
        public string SampleAdapterResolveInstrumentException { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiAtmCommand.
        /// </summary>
        [DataMember]
        public string ServerApiAtmCommand { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiCancelAccountNotEnabled.
        /// </summary>
        [DataMember]
        public string ServerApiCancelAccountNotEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiChangeAccountNotEnabled.
        /// </summary>
        [DataMember]
        public string ServerApiChangeAccountNotEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeClientInstrumentNotFound.
        /// </summary>
        [DataMember]
        public string ServerApiDeserializeClientInstrumentNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeConnectionApplySnapshotException.
        /// </summary>
        [DataMember]
        public string ServerApiDeserializeConnectionApplySnapshotException { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeHDSISDisconnect.
        /// </summary>
        [DataMember]
        public string ServerApiDeserializeHDSISDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeHDSISDsiconnect.
        /// </summary>
        [DataMember]
        public string ServerApiDeserializeHDSISDsiconnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeHDSISNoDataConnection.
        /// </summary>
        [DataMember]
        public string ServerApiDeserializeHDSISNoDataConnection { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeWorkspaceException.
        /// </summary>
        [DataMember]
        public string ServerApiDeserializeWorkspaceException { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInstrumentNotEntitledForFundamentalData.
        /// </summary>
        [DataMember]
        public string ServerApiInstrumentNotEntitledForFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInstrumentNotEntitledForMarketData.
        /// </summary>
        [DataMember]
        public string ServerApiInstrumentNotEntitledForMarketData { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInstrumentNotEntitledForMarketDepth.
        /// </summary>
        [DataMember]
        public string ServerApiInstrumentNotEntitledForMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInvalidInstrument.
        /// </summary>
        [DataMember]
        public string ServerApiInvalidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInvalidInstrumentList.
        /// </summary>
        [DataMember]
        public string ServerApiInvalidInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInvalidUserPassword.
        /// </summary>
        [DataMember]
        public string ServerApiInvalidUserPassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLoginExpired.
        /// </summary>
        [DataMember]
        public string ServerApiLoginExpired { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLogonFailedMaxConcurrentLogins.
        /// </summary>
        [DataMember]
        public string ServerApiLogonFailedMaxConcurrentLogins { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLogonFailedNoConnection.
        /// </summary>
        [DataMember]
        public string ServerApiLogonFailedNoConnection { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLogonFailedTarPitted.
        /// </summary>
        [DataMember]
        public string ServerApiLogonFailedTarPitted { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiMaxConcurrentLoginsExceeded.
        /// </summary>
        [DataMember]
        public string ServerApiMaxConcurrentLoginsExceeded { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingParseError.
        /// </summary>
        [DataMember]
        public string ServerApiPacingParseError { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingSubscribeMarketData.
        /// </summary>
        [DataMember]
        public string ServerApiPacingSubscribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingSubscribeMarketDepth.
        /// </summary>
        [DataMember]
        public string ServerApiPacingSubscribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingViolationGeneric.
        /// </summary>
        [DataMember]
        public string ServerApiPacingViolationGeneric { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingViolationOnce.
        /// </summary>
        [DataMember]
        public string ServerApiPacingViolationOnce { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPendingUserRegistration.
        /// </summary>
        [DataMember]
        public string ServerApiPendingUserRegistration { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiScanHasStarted.
        /// </summary>
        [DataMember]
        public string ServerApiScanHasStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiSubmitAccountNotConnected.
        /// </summary>
        [DataMember]
        public string ServerApiSubmitAccountNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiSubmitAccountNotEnabled.
        /// </summary>
        [DataMember]
        public string ServerApiSubmitAccountNotEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTarPitted.
        /// </summary>
        [DataMember]
        public string ServerApiTarPitted { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTooManyFundamentalDataSubscriptions.
        /// </summary>
        [DataMember]
        public string ServerApiTooManyFundamentalDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTooManyMarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public string ServerApiTooManyMarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTooManyMarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public string ServerApiTooManyMarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnableToCancelOrder.
        /// </summary>
        [DataMember]
        public string ServerApiUnableToCancelOrder { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnableToChangeOrder.
        /// </summary>
        [DataMember]
        public string ServerApiUnableToChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownAtm.
        /// </summary>
        [DataMember]
        public string ServerApiUnknownAtm { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownInstrument.
        /// </summary>
        [DataMember]
        public string ServerApiUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownServerInstrument.
        /// </summary>
        [DataMember]
        public string ServerApiUnknownServerInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownUserName.
        /// </summary>
        [DataMember]
        public string ServerApiUnknownUserName { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUserAlreadyExists.
        /// </summary>
        [DataMember]
        public string ServerApiUserAlreadyExists { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUserNotEnabledToTrade.
        /// </summary>
        [DataMember]
        public string ServerApiUserNotEnabledToTrade { get; set; }
        /// <summary>
        /// Gets or sets the ServerApplicationTypeServer.
        /// </summary>
        [DataMember]
        public string ServerApplicationTypeServer { get; set; }
        /// <summary>
        /// Gets or sets the ServerAtiServerUnableToStart.
        /// </summary>
        [DataMember]
        public string ServerAtiServerUnableToStart { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPDataLogoff.
        /// </summary>
        [DataMember]
        public string ServerBPDataLogoff { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPDataLogonSuccess.
        /// </summary>
        [DataMember]
        public string ServerBPDataLogonSuccess { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPLostConnectionToGW.
        /// </summary>
        [DataMember]
        public string ServerBPLostConnectionToGW { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPTradingLogoff.
        /// </summary>
        [DataMember]
        public string ServerBPTradingLogoff { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPTradingLogonSuccess.
        /// </summary>
        [DataMember]
        public string ServerBPTradingLogonSuccess { get; set; }
        /// <summary>
        /// Gets or sets the ServerCastInvalidUrl.
        /// </summary>
        [DataMember]
        public string ServerCastInvalidUrl { get; set; }
        /// <summary>
        /// Gets or sets the ServerCastInvalidUserNamePassword.
        /// </summary>
        [DataMember]
        public string ServerCastInvalidUserNamePassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPassword.
        /// </summary>
        [DataMember]
        public string ServerChangeUserPassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPassword2.
        /// </summary>
        [DataMember]
        public string ServerChangeUserPassword2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordSubject.
        /// </summary>
        [DataMember]
        public string ServerChangeUserPasswordSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordSubject2.
        /// </summary>
        [DataMember]
        public string ServerChangeUserPasswordSubject2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordText.
        /// </summary>
        [DataMember]
        public string ServerChangeUserPasswordText { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordText2.
        /// </summary>
        [DataMember]
        public string ServerChangeUserPasswordText2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerClientErrorResettingInstrumentMappings.
        /// </summary>
        [DataMember]
        public string ServerClientErrorResettingInstrumentMappings { get; set; }
        /// <summary>
        /// Gets or sets the ServerClientLoadingData.
        /// </summary>
        [DataMember]
        public string ServerClientLoadingData { get; set; }
        /// <summary>
        /// Gets or sets the ServerClientUnableToConnect.
        /// </summary>
        [DataMember]
        public string ServerClientUnableToConnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastAccountTemplateNotFound.
        /// </summary>
        [DataMember]
        public string ServerCqgCastAccountTemplateNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastException.
        /// </summary>
        [DataMember]
        public string ServerCqgCastException { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastUpdateAccountError.
        /// </summary>
        [DataMember]
        public string ServerCqgCastUpdateAccountError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastUpdateUserError.
        /// </summary>
        [DataMember]
        public string ServerCqgCastUpdateUserError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsAccountNotFound.
        /// </summary>
        [DataMember]
        public string ServerCqgCmsAccountNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsAccountTemplateNotFound.
        /// </summary>
        [DataMember]
        public string ServerCqgCmsAccountTemplateNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsInvalidUrl.
        /// </summary>
        [DataMember]
        public string ServerCqgCmsInvalidUrl { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsInvalidUserNamePassword.
        /// </summary>
        [DataMember]
        public string ServerCqgCmsInvalidUserNamePassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsUpdateAccountError.
        /// </summary>
        [DataMember]
        public string ServerCqgCmsUpdateAccountError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsUpdateUserError.
        /// </summary>
        [DataMember]
        public string ServerCqgCmsUpdateUserError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCtorCertificate.
        /// </summary>
        [DataMember]
        public string ServerCtorCertificate { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataClientConnect.
        /// </summary>
        [DataMember]
        public string ServerDataClientConnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataClientCouldNotConnect.
        /// </summary>
        [DataMember]
        public string ServerDataClientCouldNotConnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataHDSConnectionLost.
        /// </summary>
        [DataMember]
        public string ServerDataHDSConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataHDSConnectionRestored.
        /// </summary>
        [DataMember]
        public string ServerDataHDSConnectionRestored { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataISConnectionLost.
        /// </summary>
        [DataMember]
        public string ServerDataISConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataISConnectionRestored.
        /// </summary>
        [DataMember]
        public string ServerDataISConnectionRestored { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataMarketReplayNoData.
        /// </summary>
        [DataMember]
        public string ServerDataMarketReplayNoData { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataUnableToLoadEntities.
        /// </summary>
        [DataMember]
        public string ServerDataUnableToLoadEntities { get; set; }
        /// <summary>
        /// Gets or sets the ServerDeserializeMissingEmail.
        /// </summary>
        [DataMember]
        public string ServerDeserializeMissingEmail { get; set; }
        /// <summary>
        /// Gets or sets the ServerForcedLogout.
        /// </summary>
        [DataMember]
        public string ServerForcedLogout { get; set; }
        /// <summary>
        /// Gets or sets the ServerForcedLogoutMaintenance.
        /// </summary>
        [DataMember]
        public string ServerForcedLogoutMaintenance { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCancellationNote.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeCancellationNote { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCancelLicense.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeCancelLicense { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteNtlmManagementUser.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeCantDeleteNtlmManagementUser { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteUserManageUsers.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeCantDeleteUserManageUsers { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteUserWithAccounts.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeCantDeleteUserWithAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteUserWithLicences.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeCantDeleteUserWithLicences { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeGenerateLicense.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeGenerateLicense { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeInvalidTechnology.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeInvalidTechnology { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeInvalidUser.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeInvalidUser { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeLifetimeLicenseTerms.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeLifetimeLicenseTerms { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializePrimaryFtp.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializePrimaryFtp { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSecondaryFtp.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeSecondaryFtp { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSubscriptionFreeEdition.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeSubscriptionFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSubscriptionGeneral.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeSubscriptionGeneral { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSubscriptionMultiBroker.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeSubscriptionMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUnknownLicense.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeUnknownLicense { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUnknownLicenseCode.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeUnknownLicenseCode { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUnknownUser.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeUnknownUser { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUserDeleted.
        /// </summary>
        [DataMember]
        public string ServerGenericDeserializeUserDeleted { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericProcessPaymentProductAlreadyRegistered.
        /// </summary>
        [DataMember]
        public string ServerGenericProcessPaymentProductAlreadyRegistered { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericProcessPaymentUnknownItemNumber.
        /// </summary>
        [DataMember]
        public string ServerGenericProcessPaymentUnknownItemNumber { get; set; }
        /// <summary>
        /// Gets or sets the ServerGWNoConnectionForAccount.
        /// </summary>
        [DataMember]
        public string ServerGWNoConnectionForAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerGWNoSuchAccount.
        /// </summary>
        [DataMember]
        public string ServerGWNoSuchAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderInvalidInstrument.
        /// </summary>
        [DataMember]
        public string ServerHDSRecorderInvalidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderStarting.
        /// </summary>
        [DataMember]
        public string ServerHDSRecorderStarting { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderStopping.
        /// </summary>
        [DataMember]
        public string ServerHDSRecorderStopping { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderUnable2Start.
        /// </summary>
        [DataMember]
        public string ServerHDSRecorderUnable2Start { get; set; }
        /// <summary>
        /// Gets or sets the ServerLoginCredentialsBody.
        /// </summary>
        [DataMember]
        public string ServerLoginCredentialsBody { get; set; }
        /// <summary>
        /// Gets or sets the ServerLoginCredentialsSubject.
        /// </summary>
        [DataMember]
        public string ServerLoginCredentialsSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackingUp.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceBackingUp { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackingUpFileDone.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceBackingUpFileDone { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupCompleted.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceBackupCompleted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupFailed.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceBackupFailed { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupFailedRetry.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceBackupFailedRetry { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupStarted.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceBackupStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceDeletedDataFile.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceDeletedDataFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceDeletedReplayFile.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceDeletedReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceDirectoryNotDefined.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceDirectoryNotDefined { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceMaintenanceCompleted.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceMaintenanceCompleted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceMaintenanceFailed.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceMaintenanceFailed { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceMaintenanceStarted.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceMaintenanceStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceUpdatingRollOvers.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceUpdatingRollOvers { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceZippedDataFile.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceZippedDataFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceZippedReplayFile.
        /// </summary>
        [DataMember]
        public string ServerMaintenanceZippedReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMissingEmailSubjectWarning.
        /// </summary>
        [DataMember]
        public string ServerMissingEmailSubjectWarning { get; set; }
        /// <summary>
        /// Gets or sets the ServerMissingEmailTemplateError.
        /// </summary>
        [DataMember]
        public string ServerMissingEmailTemplateError { get; set; }
        /// <summary>
        /// Gets or sets the ServerMissingEmailTemplateWarning.
        /// </summary>
        [DataMember]
        public string ServerMissingEmailTemplateWarning { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationAccountExcluded.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationAccountExcluded { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationAccountReenabled.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationAccountReenabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationActivated.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationActivated { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationActive.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationActive { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationBegin.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationBegin { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationDeactivated.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationDeactivated { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationException.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationException { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationFail.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationFail { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationInactive.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationInactive { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationSuccess.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiquidationSuccess { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValBidAskNotAvailable.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiqValBidAskNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValBidAskSpread.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiqValBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValExceedsPositionQuantity.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiqValExceedsPositionQuantity { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValInstrumentNotSupported.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiqValInstrumentNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValMaxAccountLoss.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiqValMaxAccountLoss { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValMaxAutoliquidationValue.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiqValMaxAutoliquidationValue { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValMultipleContractsOnSameMasterInstruments.
        /// </summary>
        [DataMember]
        public string ServerNTServerAutoLiqValMultipleContractsOnSameMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDeserializeBPAccountDisabled.
        /// </summary>
        [DataMember]
        public string ServerNTServerDeserializeBPAccountDisabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDeserializeBPNoAccount.
        /// </summary>
        [DataMember]
        public string ServerNTServerDeserializeBPNoAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDeserializeBPOperationNotSupported.
        /// </summary>
        [DataMember]
        public string ServerNTServerDeserializeBPOperationNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDSNotAvailable.
        /// </summary>
        [DataMember]
        public string ServerNTServerDSNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerNotAvailable.
        /// </summary>
        [DataMember]
        public string ServerNTServerNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerSendConnectPoints1.
        /// </summary>
        [DataMember]
        public string ServerNTServerSendConnectPoints1 { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerSendConnectPoints2.
        /// </summary>
        [DataMember]
        public string ServerNTServerSendConnectPoints2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerPostedNoValue.
        /// </summary>
        [DataMember]
        public string ServerPostedNoValue { get; set; }
        /// <summary>
        /// Gets or sets the ServerRenewExpirationSubject.
        /// </summary>
        [DataMember]
        public string ServerRenewExpirationSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardActiveLicences.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardActiveLicences { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardActiveLiveLicencesByProvider.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardActiveLiveLicencesByProvider { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardActiveSimulationLicencesByProvider.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardActiveSimulationLicencesByProvider { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardEditions.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardEditions { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardExistingCustomers.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardExistingCustomers { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardNewCustomers.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardNewCustomers { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardPaymentPlans.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardPaymentPlans { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardProviders.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardProviders { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardTotalLicences.
        /// </summary>
        [DataMember]
        public string ServerReportsScoreCardTotalLicences { get; set; }
        /// <summary>
        /// Gets or sets the ServerResetPasswordByTokenSubject.
        /// </summary>
        [DataMember]
        public string ServerResetPasswordByTokenSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerResetPasswordSubject.
        /// </summary>
        [DataMember]
        public string ServerResetPasswordSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerScannerInvalidInstrument.
        /// </summary>
        [DataMember]
        public string ServerScannerInvalidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerBPDomainNameNotConfigured.
        /// </summary>
        [DataMember]
        public string ServerServerBPDomainNameNotConfigured { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerException.
        /// </summary>
        [DataMember]
        public string ServerServerException { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerFailedToApply.
        /// </summary>
        [DataMember]
        public string ServerServerFailedToApply { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerFailedToPRocessIpn.
        /// </summary>
        [DataMember]
        public string ServerServerFailedToPRocessIpn { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerFreeEditionRegistrationDetails.
        /// </summary>
        [DataMember]
        public string ServerServerFreeEditionRegistrationDetails { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnCancelType1.
        /// </summary>
        [DataMember]
        public string ServerServerIpnCancelType1 { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnFailedToSyncWithPayPal.
        /// </summary>
        [DataMember]
        public string ServerServerIpnFailedToSyncWithPayPal { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnFailure.
        /// </summary>
        [DataMember]
        public string ServerServerIpnFailure { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalid.
        /// </summary>
        [DataMember]
        public string ServerServerIpnInvalid { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidAmount.
        /// </summary>
        [DataMember]
        public string ServerServerIpnInvalidAmount { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidAmountItemCombination.
        /// </summary>
        [DataMember]
        public string ServerServerIpnInvalidAmountItemCombination { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidCurrency.
        /// </summary>
        [DataMember]
        public string ServerServerIpnInvalidCurrency { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidItemNumber.
        /// </summary>
        [DataMember]
        public string ServerServerIpnInvalidItemNumber { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidReceiverEmail.
        /// </summary>
        [DataMember]
        public string ServerServerIpnInvalidReceiverEmail { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnPending.
        /// </summary>
        [DataMember]
        public string ServerServerIpnPending { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerManageAccount1.
        /// </summary>
        [DataMember]
        public string ServerServerManageAccount1 { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerManageAccount2.
        /// </summary>
        [DataMember]
        public string ServerServerManageAccount2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerNetworkInterfaceError.
        /// </summary>
        [DataMember]
        public string ServerServerNetworkInterfaceError { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerPayPalTransactionDetails.
        /// </summary>
        [DataMember]
        public string ServerServerPayPalTransactionDetails { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerProcessFreeEdition.
        /// </summary>
        [DataMember]
        public string ServerServerProcessFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerStarted.
        /// </summary>
        [DataMember]
        public string ServerServerStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerStarting.
        /// </summary>
        [DataMember]
        public string ServerServerStarting { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerStopping.
        /// </summary>
        [DataMember]
        public string ServerServerStopping { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerUserRegistrationSubject.
        /// </summary>
        [DataMember]
        public string ServerServerUserRegistrationSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerApplyingQtyMult.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerApplyingQtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvert_QtyMult.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerConvert_QtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertFractionalPrice.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerConvertFractionalPrice { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertLimitPrice.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerConvertLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertMultiplier.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerConvertMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertOrderQuantity.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerConvertOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertQtyMult.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerConvertQtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertStopPrice.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerConvertStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerEmailIgnored.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerEmailIgnored { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerErrorProcessingTsMail.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerErrorProcessingTsMail { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerGlobalSimulation.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerIgnoreMsg.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerIgnoreMsg { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerInvalidAccount.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerInvalidAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerInvalidMultiplier.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerInvalidMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerInvalidQtyMult.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerInvalidQtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerLimitPriceGreaterAsk.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerLimitPriceGreaterAsk { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerLimitPriceSmallerBid.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerLimitPriceSmallerBid { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerMultiplierSyntax.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerMultiplierSyntax { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerNtPending.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerNtPending { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerOnAccounts.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerOnAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerProcessing.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerProcessing { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerShuttingDown.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerShuttingDown { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerStarting.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerStarting { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerTsPending.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerTsPending { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnableToStart.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerUnableToStart { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnexpectedSmtpCommand.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerUnexpectedSmtpCommand { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnknownInstrument.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnknownInstrumentMapped.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerUnknownInstrumentMapped { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnkownOrderAction.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerUnkownOrderAction { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnkownOrderType.
        /// </summary>
        [DataMember]
        public string ServerSmtpServerUnkownOrderType { get; set; }
        /// <summary>
        /// Gets or sets the ServerStartGWDontLoadSimAccounts.
        /// </summary>
        [DataMember]
        public string ServerStartGWDontLoadSimAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerUnableToStartAtiServer.
        /// </summary>
        [DataMember]
        public string ServerUnableToStartAtiServer { get; set; }
        /// <summary>
        /// Gets or sets the ServerWebPacingParseError.
        /// </summary>
        [DataMember]
        public string ServerWebPacingParseError { get; set; }
        /// <summary>
        /// Gets or sets the ServerWebPacingRecovered.
        /// </summary>
        [DataMember]
        public string ServerWebPacingRecovered { get; set; }
        /// <summary>
        /// Gets or sets the ServerWebPacingViolation.
        /// </summary>
        [DataMember]
        public string ServerWebPacingViolation { get; set; }
        /// <summary>
        /// Gets or sets the ShareEmailNoDefaultEmailDefined.
        /// </summary>
        [DataMember]
        public string ShareEmailNoDefaultEmailDefined { get; set; }
        /// <summary>
        /// Gets or sets the ShareEmailNoEmailServicesDefined.
        /// </summary>
        [DataMember]
        public string ShareEmailNoEmailServicesDefined { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailException.
        /// </summary>
        [DataMember]
        public string ShareMailException { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceAccountName.
        /// </summary>
        [DataMember]
        public string ShareServiceAccountName { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceIsDefault.
        /// </summary>
        [DataMember]
        public string ShareServiceIsDefault { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceParameters.
        /// </summary>
        [DataMember]
        public string ShareServiceParameters { get; set; }
        /// <summary>
        /// Gets or sets the SocketError.
        /// </summary>
        [DataMember]
        public string SocketError { get; set; }
        /// <summary>
        /// Gets or sets the SocketUnexpectedDisconnect.
        /// </summary>
        [DataMember]
        public string SocketUnexpectedDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the StartupRunning32bitOn64SystemAdvice.
        /// </summary>
        [DataMember]
        public string StartupRunning32bitOn64SystemAdvice { get; set; }
        /// <summary>
        /// Gets or sets the StartupRunning32bitOn64SystemQuestion.
        /// </summary>
        [DataMember]
        public string StartupRunning32bitOn64SystemQuestion { get; set; }
        /// <summary>
        /// Gets or sets the StartupServerIdNotSet.
        /// </summary>
        [DataMember]
        public string StartupServerIdNotSet { get; set; }
        /// <summary>
        /// Gets or sets the StartupServerTraceNotSet.
        /// </summary>
        [DataMember]
        public string StartupServerTraceNotSet { get; set; }
        /// <summary>
        /// Gets or sets the String1.
        /// </summary>
        [DataMember]
        public string String1 { get; set; }
        /// <summary>
        /// Gets or sets the TradingOptionsAutoCloseChanged.
        /// </summary>
        [DataMember]
        public string TradingOptionsAutoCloseChanged { get; set; }
        /// <summary>
        /// Gets or sets the TradingServicesMigrationError.
        /// </summary>
        [DataMember]
        public string TradingServicesMigrationError { get; set; }
        /// <summary>
        /// Gets or sets the UserNameLengthExceeded.
        /// </summary>
        [DataMember]
        public string UserNameLengthExceeded { get; set; }
        /// <summary>
        /// Gets or sets the WebServerNoSuchInstrument.
        /// </summary>
        [DataMember]
        public string WebServerNoSuchInstrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
