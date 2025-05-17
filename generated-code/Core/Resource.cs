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
        public ResourceManager ResourceManager { get; set; }
        /// <summary>
        /// Gets or sets the Culture.
        /// </summary>
        [DataMember]
        public CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAccountStartException.
        /// </summary>
        [DataMember]
        public String AdapterAccountStartException { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAccountStopException.
        /// </summary>
        [DataMember]
        public String AdapterAccountStopException { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAdapterProxyBufferOverflow.
        /// </summary>
        [DataMember]
        public String AdapterAdapterProxyBufferOverflow { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAdapterProxyHeartbeatTimeout.
        /// </summary>
        [DataMember]
        public String AdapterAdapterProxyHeartbeatTimeout { get; set; }
        /// <summary>
        /// Gets or sets the AdapterAdapterProxySerialize.
        /// </summary>
        [DataMember]
        public String AdapterAdapterProxySerialize { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterCantConnectToDS.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterCantConnectToDS { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterCantConnectToEndPoint.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterCantConnectToEndPoint { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterConnect.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterConnect { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterInvalidAccount.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterInvalidAccount { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterInvalidEmail.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterInvalidEmail { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterInvalidOrder.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterInvalidOrder { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterLostConnectionToHds.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterLostConnectionToHds { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterNoRealtimeDataConnection.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterNoRealtimeDataConnection { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterSslError.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterSslError { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterTooMuchWorkspaceData.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterTooMuchWorkspaceData { get; set; }
        /// <summary>
        /// Gets or sets the AdapterClientAdapterUnableToResolveInstrument.
        /// </summary>
        [DataMember]
        public String AdapterClientAdapterUnableToResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the AdapterConnectRunAsProcessNotSupported.
        /// </summary>
        [DataMember]
        public String AdapterConnectRunAsProcessNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the AdapterGatewayAdapterException.
        /// </summary>
        [DataMember]
        public String AdapterGatewayAdapterException { get; set; }
        /// <summary>
        /// Gets or sets the AdapterGatewayAdapterNumConnections.
        /// </summary>
        [DataMember]
        public String AdapterGatewayAdapterNumConnections { get; set; }
        /// <summary>
        /// Gets or sets the AdapterHistoricalLoadingMessage.
        /// </summary>
        [DataMember]
        public String AdapterHistoricalLoadingMessage { get; set; }
        /// <summary>
        /// Gets or sets the AdapterISVSimulatorOnOnlyGW.
        /// </summary>
        [DataMember]
        public String AdapterISVSimulatorOnOnlyGW { get; set; }
        /// <summary>
        /// Gets or sets the AdapterPlaybackAdapterInit.
        /// </summary>
        [DataMember]
        public String AdapterPlaybackAdapterInit { get; set; }
        /// <summary>
        /// Gets or sets the AdapterSimulationAdapterNewsHeadline.
        /// </summary>
        [DataMember]
        public String AdapterSimulationAdapterNewsHeadline { get; set; }
        /// <summary>
        /// Gets or sets the AdapterSimulationAdapterNewsStory.
        /// </summary>
        [DataMember]
        public String AdapterSimulationAdapterNewsStory { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationAccessIsDenied.
        /// </summary>
        [DataMember]
        public String AuthenticationAccessIsDenied { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationNoAccountsFound.
        /// </summary>
        [DataMember]
        public String AuthenticationNoAccountsFound { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationServerNotAvailable.
        /// </summary>
        [DataMember]
        public String AuthenticationServerNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the AuthenticationTimePenaltyLogin.
        /// </summary>
        [DataMember]
        public String AuthenticationTimePenaltyLogin { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccount.
        /// </summary>
        [DataMember]
        public String CbiAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountAtmNotAllowed.
        /// </summary>
        [DataMember]
        public String CbiAccountAtmNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountAutoClose1.
        /// </summary>
        [DataMember]
        public String CbiAccountAutoClose1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountAutoClose2.
        /// </summary>
        [DataMember]
        public String CbiAccountAutoClose2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancel.
        /// </summary>
        [DataMember]
        public String CbiAccountCancel { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelAllOrders.
        /// </summary>
        [DataMember]
        public String CbiAccountCancelAllOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelException.
        /// </summary>
        [DataMember]
        public String CbiAccountCancelException { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelGlobalSimulation.
        /// </summary>
        [DataMember]
        public String CbiAccountCancelGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelNotAllowed.
        /// </summary>
        [DataMember]
        public String CbiAccountCancelNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelNotConnected.
        /// </summary>
        [DataMember]
        public String CbiAccountCancelNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelSimulatedMITAlreadySubmitted.
        /// </summary>
        [DataMember]
        public String CbiAccountCancelSimulatedMITAlreadySubmitted { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCancelSimulationOnly.
        /// </summary>
        [DataMember]
        public String CbiAccountCancelSimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange.
        /// </summary>
        [DataMember]
        public String CbiAccountChange { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange10.
        /// </summary>
        [DataMember]
        public String CbiAccountChange10 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange11.
        /// </summary>
        [DataMember]
        public String CbiAccountChange11 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange12.
        /// </summary>
        [DataMember]
        public String CbiAccountChange12 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange13.
        /// </summary>
        [DataMember]
        public String CbiAccountChange13 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange14.
        /// </summary>
        [DataMember]
        public String CbiAccountChange14 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange15.
        /// </summary>
        [DataMember]
        public String CbiAccountChange15 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange2.
        /// </summary>
        [DataMember]
        public String CbiAccountChange2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange3.
        /// </summary>
        [DataMember]
        public String CbiAccountChange3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange4.
        /// </summary>
        [DataMember]
        public String CbiAccountChange4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange6.
        /// </summary>
        [DataMember]
        public String CbiAccountChange6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange7.
        /// </summary>
        [DataMember]
        public String CbiAccountChange7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange8.
        /// </summary>
        [DataMember]
        public String CbiAccountChange8 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChange9.
        /// </summary>
        [DataMember]
        public String CbiAccountChange9 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeException.
        /// </summary>
        [DataMember]
        public String CbiAccountChangeException { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeGlobalSimulation.
        /// </summary>
        [DataMember]
        public String CbiAccountChangeGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeNotAllowed.
        /// </summary>
        [DataMember]
        public String CbiAccountChangeNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeNotConnected.
        /// </summary>
        [DataMember]
        public String CbiAccountChangeNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountChangeSimulationOnly.
        /// </summary>
        [DataMember]
        public String CbiAccountChangeSimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountCreateOrderNoLiveOrders.
        /// </summary>
        [DataMember]
        public String CbiAccountCreateOrderNoLiveOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountExecutionNull.
        /// </summary>
        [DataMember]
        public String CbiAccountExecutionNull { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountExecutionNull_Duplicate_1_.
        /// </summary>
        [DataMember]
        public String CbiAccountExecutionNull_Duplicate_1_ { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountFlatten.
        /// </summary>
        [DataMember]
        public String CbiAccountFlatten { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountFlattenEverything.
        /// </summary>
        [DataMember]
        public String CbiAccountFlattenEverything { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountOcoCancelOnBehalfOf.
        /// </summary>
        [DataMember]
        public String CbiAccountOcoCancelOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountOcoChangeOnBehalfOf.
        /// </summary>
        [DataMember]
        public String CbiAccountOcoChangeOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountOnMaterialized.
        /// </summary>
        [DataMember]
        public String CbiAccountOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessOrderStatusArgsError.
        /// </summary>
        [DataMember]
        public String CbiAccountProcessOrderStatusArgsError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessOrderStatusEventArgs.
        /// </summary>
        [DataMember]
        public String CbiAccountProcessOrderStatusEventArgs { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessOrderStatusEventArgs2.
        /// </summary>
        [DataMember]
        public String CbiAccountProcessOrderStatusEventArgs2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountProcessPositionUpdateEventArgs.
        /// </summary>
        [DataMember]
        public String CbiAccountProcessPositionUpdateEventArgs { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountRestore2.
        /// </summary>
        [DataMember]
        public String CbiAccountRestore2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountRestore3.
        /// </summary>
        [DataMember]
        public String CbiAccountRestore3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountRestoreStrategy.
        /// </summary>
        [DataMember]
        public String CbiAccountRestoreStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSimulatedGtd.
        /// </summary>
        [DataMember]
        public String CbiAccountSimulatedGtd { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSimulationAccountReset.
        /// </summary>
        [DataMember]
        public String CbiAccountSimulationAccountReset { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit10.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit10 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit11.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit11 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit12.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit12 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit13.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit13 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit15.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit15 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit16.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit16 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit17.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit17 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit18.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit18 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit19.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit19 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit2.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit20.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit20 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit21.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit21 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit22.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit22 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit23.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit23 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit24.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit24 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit25.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit25 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit3.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit4.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit5.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit6.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit7.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit8.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit8 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmit9.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmit9 { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitException.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmitException { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitGlobalSimulation.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmitGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitIsFreeEdition.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmitIsFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitIsFreeEditionMIT.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmitIsFreeEditionMIT { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitNotAllowed.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmitNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitNotConnected.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmitNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountSubmitSimulationOnly.
        /// </summary>
        [DataMember]
        public String CbiAccountSubmitSimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiAccountUnableToCreateOrder.
        /// </summary>
        [DataMember]
        public String CbiAccountUnableToCreateOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoChase.
        /// </summary>
        [DataMember]
        public String CbiAutoChase { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeAccountNotConnected.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeAccountNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeConnectionStatusError.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeConnectionStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeDeleteError.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeDeleteError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeEntryOrderQuantity.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeEntryOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidAction.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeInvalidAction { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidLimitPrice.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeInvalidLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidOrderID.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeInvalidOrderID { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidOrderType.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeInvalidOrderType { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidQuantity.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeInvalidQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidStopPrice.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeInvalidStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeInvalidTif.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeInvalidTif { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeLineReadError.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeLineReadError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNoEntryOrderFilled.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeNoEntryOrderFilled { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNoOrderID.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeNoOrderID { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNoSuchOrder.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeNoSuchOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeNumParameters.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeNumParameters { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeOrderCantBeChanged.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeOrderCantBeChanged { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeOrderQuantity.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeOrderStatusError.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeOrderStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradePositionStatusError.
        /// </summary>
        [DataMember]
        public String CbiAutoTradePositionStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeProcessing.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeProcessing { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeProcessingATI.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeProcessingATI { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeReadError.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeReadError { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTraderUnkonwOifType.
        /// </summary>
        [DataMember]
        public String CbiAutoTraderUnkonwOifType { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeStrategyDoesNotExist.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeStrategyDoesNotExist { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeStrategyIDAlreadyInUse.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeStrategyIDAlreadyInUse { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeStrategyIDMissing.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeStrategyIDMissing { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeSubmitOrder.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeSubmitOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeSubmitOrderToStrategy.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeSubmitOrderToStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeSubmitOrderWithStrategy.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeSubmitOrderWithStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeTifNotSupported.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeTifNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnableToCancelOrder.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnableToCancelOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnableToChangeOrder.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnableToChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnableToDeleteFile.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnableToDeleteFile { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownAccount.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownInstrument.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownOrder.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnknownOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownParameter.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnknownParameter { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnknownStrategy.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnknownStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTradeUnkownPosition.
        /// </summary>
        [DataMember]
        public String CbiAutoTradeUnkownPosition { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTrail.
        /// </summary>
        [DataMember]
        public String CbiAutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTrailAutoBreakEven.
        /// </summary>
        [DataMember]
        public String CbiAutoTrailAutoBreakEven { get; set; }
        /// <summary>
        /// Gets or sets the CbiAutoTrailAutoTrail.
        /// </summary>
        [DataMember]
        public String CbiAutoTrailAutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the CbiBigTickOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiBigTickOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiClientOnCompletedConnectError.
        /// </summary>
        [DataMember]
        public String CbiClientOnCompletedConnectError { get; set; }
        /// <summary>
        /// Gets or sets the CbiCommisionUnableToLoad.
        /// </summary>
        [DataMember]
        public String CbiCommisionUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiCommission.
        /// </summary>
        [DataMember]
        public String CbiCommission { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCallbackAutoClose.
        /// </summary>
        [DataMember]
        public String CbiConnectionCallbackAutoClose { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionClose.
        /// </summary>
        [DataMember]
        public String CbiConnectionClose { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCloseOpenOrder.
        /// </summary>
        [DataMember]
        public String CbiConnectionCloseOpenOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectAssembly.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectAssembly { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectBrandName.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectBrandName { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectException.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectException { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectExclusive1.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectExclusive1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectExclusive2.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectExclusive2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectNoDuplicates.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectNoDuplicates { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectServer.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectTimeout.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectTimeout { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionConnectVendorLicense.
        /// </summary>
        [DataMember]
        public String CbiConnectionConnectVendorLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCreateAccount.
        /// </summary>
        [DataMember]
        public String CbiConnectionCreateAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCreateOrder.
        /// </summary>
        [DataMember]
        public String CbiConnectionCreateOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionCreateSimAccount.
        /// </summary>
        [DataMember]
        public String CbiConnectionCreateSimAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionDuplicateAccount.
        /// </summary>
        [DataMember]
        public String CbiConnectionDuplicateAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionDuplicateAccountTdvCqg.
        /// </summary>
        [DataMember]
        public String CbiConnectionDuplicateAccountTdvCqg { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionKinetickGlobexNonProFeesFailure.
        /// </summary>
        [DataMember]
        public String CbiConnectionKinetickGlobexNonProFeesFailure { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionKinetickGlobexNonProFeesSuccess.
        /// </summary>
        [DataMember]
        public String CbiConnectionKinetickGlobexNonProFeesSuccess { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionOpenConnectNotFound.
        /// </summary>
        [DataMember]
        public String CbiConnectionOpenConnectNotFound { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionProcessAccount.
        /// </summary>
        [DataMember]
        public String CbiConnectionProcessAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionProcessConnectionStatusError.
        /// </summary>
        [DataMember]
        public String CbiConnectionProcessConnectionStatusError { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionProcessConnectionStatusUpdate.
        /// </summary>
        [DataMember]
        public String CbiConnectionProcessConnectionStatusUpdate { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionQueryMasterInstrumentMapping.
        /// </summary>
        [DataMember]
        public String CbiConnectionQueryMasterInstrumentMapping { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionQueryMasterInstrumentMappingNoSuchSymbol.
        /// </summary>
        [DataMember]
        public String CbiConnectionQueryMasterInstrumentMappingNoSuchSymbol { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveInstrument.
        /// </summary>
        [DataMember]
        public String CbiConnectionResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveSymbol.
        /// </summary>
        [DataMember]
        public String CbiConnectionResolveSymbol { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveSymbolInstrumentExists.
        /// </summary>
        [DataMember]
        public String CbiConnectionResolveSymbolInstrumentExists { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionResolveSymbolNoMapping.
        /// </summary>
        [DataMember]
        public String CbiConnectionResolveSymbolNoMapping { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionStatusAlreadySubscribed.
        /// </summary>
        [DataMember]
        public String CbiConnectionStatusAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiConnectionTimerTickAlreadySubscribed.
        /// </summary>
        [DataMember]
        public String CbiConnectionTimerTickAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiCqgOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiCqgOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCqgOptionsWebApiDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiCqgOptionsWebApiDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCqgOptionsWebApiUnexepctedDisconnect.
        /// </summary>
        [DataMember]
        public String CbiCqgOptionsWebApiUnexepctedDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGQuotesNetworkInterface.
        /// </summary>
        [DataMember]
        public String CbiCQGQuotesNetworkInterface { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerFeedIds.
        /// </summary>
        [DataMember]
        public String CbiCQGServerFeedIds { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerHost.
        /// </summary>
        [DataMember]
        public String CbiCQGServerHost { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerIsCertificationMode.
        /// </summary>
        [DataMember]
        public String CbiCQGServerIsCertificationMode { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerOptionsSenderSubId.
        /// </summary>
        [DataMember]
        public String CbiCQGServerOptionsSenderSubId { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerOrderServer.
        /// </summary>
        [DataMember]
        public String CbiCQGServerOrderServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerPort.
        /// </summary>
        [DataMember]
        public String CbiCQGServerPort { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerQuotes.
        /// </summary>
        [DataMember]
        public String CbiCQGServerQuotes { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerSecurityDefinitionIsDemo.
        /// </summary>
        [DataMember]
        public String CbiCQGServerSecurityDefinitionIsDemo { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerSecurityDefinitionServer.
        /// </summary>
        [DataMember]
        public String CbiCQGServerSecurityDefinitionServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiCQGServerUseOnBehalfOf.
        /// </summary>
        [DataMember]
        public String CbiCQGServerUseOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the CbiCTraderOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiCTraderOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiDBLoadingAccounts.
        /// </summary>
        [DataMember]
        public String CbiDBLoadingAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CbiDBLoadingInstruments.
        /// </summary>
        [DataMember]
        public String CbiDBLoadingInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CbiDbMigrationFailed.
        /// </summary>
        [DataMember]
        public String CbiDbMigrationFailed { get; set; }
        /// <summary>
        /// Gets or sets the CbiDBRepairFailed.
        /// </summary>
        [DataMember]
        public String CbiDBRepairFailed { get; set; }
        /// <summary>
        /// Gets or sets the CbiDisabledFeature.
        /// </summary>
        [DataMember]
        public String CbiDisabledFeature { get; set; }
        /// <summary>
        /// Gets or sets the CbiDividendAmount.
        /// </summary>
        [DataMember]
        public String CbiDividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the CbiEndOfDayPositions.
        /// </summary>
        [DataMember]
        public String CbiEndOfDayPositions { get; set; }
        /// <summary>
        /// Gets or sets the CbiEntry.
        /// </summary>
        [DataMember]
        public String CbiEntry { get; set; }
        /// <summary>
        /// Gets or sets the CbiEntryExit.
        /// </summary>
        [DataMember]
        public String CbiEntryExit { get; set; }
        /// <summary>
        /// Gets or sets the CbiEX.
        /// </summary>
        [DataMember]
        public String CbiEX { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionDuplicateExecution.
        /// </summary>
        [DataMember]
        public String CbiExecutionDuplicateExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionId.
        /// </summary>
        [DataMember]
        public String CbiExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionName.
        /// </summary>
        [DataMember]
        public String CbiExecutionName { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionOrderId.
        /// </summary>
        [DataMember]
        public String CbiExecutionOrderId { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionPrice.
        /// </summary>
        [DataMember]
        public String CbiExecutionPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutions.
        /// </summary>
        [DataMember]
        public String CbiExecutions { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionUpdateEventArgs0.
        /// </summary>
        [DataMember]
        public String CbiExecutionUpdateEventArgs0 { get; set; }
        /// <summary>
        /// Gets or sets the CbiExecutionVirtualEntryExecution.
        /// </summary>
        [DataMember]
        public String CbiExecutionVirtualEntryExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiExit.
        /// </summary>
        [DataMember]
        public String CbiExit { get; set; }
        /// <summary>
        /// Gets or sets the CbiExternalDataFeed.
        /// </summary>
        [DataMember]
        public String CbiExternalDataFeed { get; set; }
        /// <summary>
        /// Gets or sets the CbiFee.
        /// </summary>
        [DataMember]
        public String CbiFee { get; set; }
        /// <summary>
        /// Gets or sets the CbiFeeUnableToLoad.
        /// </summary>
        [DataMember]
        public String CbiFeeUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiFromDateSmallerThanToDate.
        /// </summary>
        [DataMember]
        public String CbiFromDateSmallerThanToDate { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiFxcmOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerConnectionType.
        /// </summary>
        [DataMember]
        public String CbiFxcmServerConnectionType { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerHost.
        /// </summary>
        [DataMember]
        public String CbiFxcmServerHost { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerPort.
        /// </summary>
        [DataMember]
        public String CbiFxcmServerPort { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerSenderCompID.
        /// </summary>
        [DataMember]
        public String CbiFxcmServerSenderCompID { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerTargetCompID.
        /// </summary>
        [DataMember]
        public String CbiFxcmServerTargetCompID { get; set; }
        /// <summary>
        /// Gets or sets the CbiFxcmServerTargetSubID.
        /// </summary>
        [DataMember]
        public String CbiFxcmServerTargetSubID { get; set; }
        /// <summary>
        /// Gets or sets the CbiGainOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiGainOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiGainOptionsG2Disclaimer.
        /// </summary>
        [DataMember]
        public String CbiGainOptionsG2Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordChangeAtLeast7Characters.
        /// </summary>
        [DataMember]
        public String CbiGlobalsPasswordChangeAtLeast7Characters { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordChangeMatchUsername.
        /// </summary>
        [DataMember]
        public String CbiGlobalsPasswordChangeMatchUsername { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordChangePasswordMustContainItems.
        /// </summary>
        [DataMember]
        public String CbiGlobalsPasswordChangePasswordMustContainItems { get; set; }
        /// <summary>
        /// Gets or sets the CbiGlobalsPasswordContainsWhitespaces.
        /// </summary>
        [DataMember]
        public String CbiGlobalsPasswordContainsWhitespaces { get; set; }
        /// <summary>
        /// Gets or sets the CbiIbOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiIbOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiICQGOptionsUseHistoricalTickData.
        /// </summary>
        [DataMember]
        public String CbiICQGOptionsUseHistoricalTickData { get; set; }
        /// <summary>
        /// Gets or sets the CbiICQGOptionsUseWebApi.
        /// </summary>
        [DataMember]
        public String CbiICQGOptionsUseWebApi { get; set; }
        /// <summary>
        /// Gets or sets the CbiIEXOptionsPublicToken.
        /// </summary>
        [DataMember]
        public String CbiIEXOptionsPublicToken { get; set; }
        /// <summary>
        /// Gets or sets the CbiIEXOptionsReplayFile.
        /// </summary>
        [DataMember]
        public String CbiIEXOptionsReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the CbiIndicatorTracking.
        /// </summary>
        [DataMember]
        public String CbiIndicatorTracking { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentErrorInRealTimeTimer.
        /// </summary>
        [DataMember]
        public String CbiInstrumentErrorInRealTimeTimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFailedToStartRecorder.
        /// </summary>
        [DataMember]
        public String CbiInstrumentFailedToStartRecorder { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFundamentalDataAlreadySubscribed.
        /// </summary>
        [DataMember]
        public String CbiInstrumentFundamentalDataAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFundamentalDataCallbackDividends.
        /// </summary>
        [DataMember]
        public String CbiInstrumentFundamentalDataCallbackDividends { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentFundamentalDataCallbackSplits.
        /// </summary>
        [DataMember]
        public String CbiInstrumentFundamentalDataCallbackSplits { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentMarketDataAlreadySubscribed.
        /// </summary>
        [DataMember]
        public String CbiInstrumentMarketDataAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentMarketDepthAlreadySubscribed.
        /// </summary>
        [DataMember]
        public String CbiInstrumentMarketDepthAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentName.
        /// </summary>
        [DataMember]
        public String CbiInstrumentName { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentRealtimeDataTimerAlreadySubscribed.
        /// </summary>
        [DataMember]
        public String CbiInstrumentRealtimeDataTimerAlreadySubscribed { get; set; }
        /// <summary>
        /// Gets or sets the CbiInstrumentResetMarketDepth.
        /// </summary>
        [DataMember]
        public String CbiInstrumentResetMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicense.
        /// </summary>
        [DataMember]
        public String CbiLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseAccountBalance.
        /// </summary>
        [DataMember]
        public String CbiLicenseAccountBalance { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseAccountBalanceError.
        /// </summary>
        [DataMember]
        public String CbiLicenseAccountBalanceError { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseCantUseThisFeature.
        /// </summary>
        [DataMember]
        public String CbiLicenseCantUseThisFeature { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseDirect.
        /// </summary>
        [DataMember]
        public String CbiLicenseDirect { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseEnter.
        /// </summary>
        [DataMember]
        public String CbiLicenseEnter { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseFirewall.
        /// </summary>
        [DataMember]
        public String CbiLicenseFirewall { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseInvalidMessage1.
        /// </summary>
        [DataMember]
        public String CbiLicenseInvalidMessage1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseLog.
        /// </summary>
        [DataMember]
        public String CbiLicenseLog { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMachineID.
        /// </summary>
        [DataMember]
        public String CbiLicenseMachineID { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMachineIDBios.
        /// </summary>
        [DataMember]
        public String CbiLicenseMachineIDBios { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMachineIDProcessor.
        /// </summary>
        [DataMember]
        public String CbiLicenseMachineIDProcessor { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseMultiBroker.
        /// </summary>
        [DataMember]
        public String CbiLicenseMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseSim.
        /// </summary>
        [DataMember]
        public String CbiLicenseSim { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseStandard.
        /// </summary>
        [DataMember]
        public String CbiLicenseStandard { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseTyAgain.
        /// </summary>
        [DataMember]
        public String CbiLicenseTyAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseVerify1.
        /// </summary>
        [DataMember]
        public String CbiLicenseVerify1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseVerify2.
        /// </summary>
        [DataMember]
        public String CbiLicenseVerify2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseVersion.
        /// </summary>
        [DataMember]
        public String CbiLicenseVersion { get; set; }
        /// <summary>
        /// Gets or sets the CbiLicenseWillExpireShortly.
        /// </summary>
        [DataMember]
        public String CbiLicenseWillExpireShortly { get; set; }
        /// <summary>
        /// Gets or sets the CbiLiveAccount.
        /// </summary>
        [DataMember]
        public String CbiLiveAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogAlert.
        /// </summary>
        [DataMember]
        public String CbiLogAlert { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogAssert.
        /// </summary>
        [DataMember]
        public String CbiLogAssert { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogCategory.
        /// </summary>
        [DataMember]
        public String CbiLogCategory { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogGeneric.
        /// </summary>
        [DataMember]
        public String CbiLogGeneric { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogLevel.
        /// </summary>
        [DataMember]
        public String CbiLogLevel { get; set; }
        /// <summary>
        /// Gets or sets the CbiLogMailQueueOverFlow.
        /// </summary>
        [DataMember]
        public String CbiLogMailQueueOverFlow { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketAfterTime.
        /// </summary>
        [DataMember]
        public String CbiMarketAfterTime { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketDataEntitlementUnableToLoad.
        /// </summary>
        [DataMember]
        public String CbiMarketDataEntitlementUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketIfTouchedSimulated.
        /// </summary>
        [DataMember]
        public String CbiMarketIfTouchedSimulated { get; set; }
        /// <summary>
        /// Gets or sets the CbiMarketPosition.
        /// </summary>
        [DataMember]
        public String CbiMarketPosition { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentDuplicateMappings.
        /// </summary>
        [DataMember]
        public String CbiMasterInstrumentDuplicateMappings { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentOnMaterialized.
        /// </summary>
        [DataMember]
        public String CbiMasterInstrumentOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentSymbolMapDescriptorDescription.
        /// </summary>
        [DataMember]
        public String CbiMasterInstrumentSymbolMapDescriptorDescription { get; set; }
        /// <summary>
        /// Gets or sets the CbiMasterInstrumentUpdateRolloverCollectionError.
        /// </summary>
        [DataMember]
        public String CbiMasterInstrumentUpdateRolloverCollectionError { get; set; }
        /// <summary>
        /// Gets or sets the CbiMbtOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiMbtOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiMessage.
        /// </summary>
        [DataMember]
        public String CbiMessage { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateAccountConnectionsException.
        /// </summary>
        [DataMember]
        public String CbiMigrateAccountConnectionsException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateClearCacheException.
        /// </summary>
        [DataMember]
        public String CbiMigrateClearCacheException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBAccount.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBAtmStrategy.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBAtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBException.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBExecution.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBInstrument.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBInstrumentList.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBMasterInstrument.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDBOrder.
        /// </summary>
        [DataMember]
        public String CbiMigrateDBOrder { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateDoYouWantToMigrateNT7.
        /// </summary>
        [DataMember]
        public String CbiMigrateDoYouWantToMigrateNT7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateHistoricalDataException.
        /// </summary>
        [DataMember]
        public String CbiMigrateHistoricalDataException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateHistoricalDataException2.
        /// </summary>
        [DataMember]
        public String CbiMigrateHistoricalDataException2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateHistoricalDataNoInstrument.
        /// </summary>
        [DataMember]
        public String CbiMigrateHistoricalDataNoInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessAccountConnections.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessAccountConnections { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessAccounts.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessAtmStrategies.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessAtmStrategies { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessDB.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessDB { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessExecutions.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessExecutions { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessHistoricalData.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessHistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessInstrumentLists.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessInstrumentLists { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessInstruments.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessMasterInstruments.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessOrders.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessReplayData.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessReplayData { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateProcessSettings.
        /// </summary>
        [DataMember]
        public String CbiMigrateProcessSettings { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateReplayData.
        /// </summary>
        [DataMember]
        public String CbiMigrateReplayData { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateReplayDataNoInstrument.
        /// </summary>
        [DataMember]
        public String CbiMigrateReplayDataNoInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateSettingsException.
        /// </summary>
        [DataMember]
        public String CbiMigrateSettingsException { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateShutdownNT7.
        /// </summary>
        [DataMember]
        public String CbiMigrateShutdownNT7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiMigrateSuccess.
        /// </summary>
        [DataMember]
        public String CbiMigrateSuccess { get; set; }
        /// <summary>
        /// Gets or sets the CbiNewFxcmLicenses.
        /// </summary>
        [DataMember]
        public String CbiNewFxcmLicenses { get; set; }
        /// <summary>
        /// Gets or sets the CbiNewLicenses.
        /// </summary>
        [DataMember]
        public String CbiNewLicenses { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity1.
        /// </summary>
        [DataMember]
        public String CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity1 { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity2.
        /// </summary>
        [DataMember]
        public String CbiNinjaScriptAtmStrategySetOutstandingEntryQuantity2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaTraderCreateStrategy.
        /// </summary>
        [DataMember]
        public String CbiNinjaTraderCreateStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiNinjaTraderProxyInstrumentUpdateSuccessful.
        /// </summary>
        [DataMember]
        public String CbiNinjaTraderProxyInstrumentUpdateSuccessful { get; set; }
        /// <summary>
        /// Gets or sets the CbiNoEndOfDayPositions.
        /// </summary>
        [DataMember]
        public String CbiNoEndOfDayPositions { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTConnectAlreadyConnected.
        /// </summary>
        [DataMember]
        public String CbiNTConnectAlreadyConnected { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTConnectIncorrectAccountPassword.
        /// </summary>
        [DataMember]
        public String CbiNTConnectIncorrectAccountPassword { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTResolveInstrument.
        /// </summary>
        [DataMember]
        public String CbiNTResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTResolveInstrumentList.
        /// </summary>
        [DataMember]
        public String CbiNTResolveInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the CbiNTSystem.
        /// </summary>
        [DataMember]
        public String CbiNTSystem { get; set; }
        /// <summary>
        /// Gets or sets the CbiNull.
        /// </summary>
        [DataMember]
        public String CbiNull { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderAction.
        /// </summary>
        [DataMember]
        public String CbiOrderAction { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderAverageFillPrice.
        /// </summary>
        [DataMember]
        public String CbiOrderAverageFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderComment.
        /// </summary>
        [DataMember]
        public String CbiOrderComment { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderError.
        /// </summary>
        [DataMember]
        public String CbiOrderError { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderExternal.
        /// </summary>
        [DataMember]
        public String CbiOrderExternal { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderFilled.
        /// </summary>
        [DataMember]
        public String CbiOrderFilled { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderFromBytes.
        /// </summary>
        [DataMember]
        public String CbiOrderFromBytes { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderId.
        /// </summary>
        [DataMember]
        public String CbiOrderId { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderLimitPrice.
        /// </summary>
        [DataMember]
        public String CbiOrderLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderOrderState.
        /// </summary>
        [DataMember]
        public String CbiOrderOrderState { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderQuantity.
        /// </summary>
        [DataMember]
        public String CbiOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrders.
        /// </summary>
        [DataMember]
        public String CbiOrders { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderStopPrice.
        /// </summary>
        [DataMember]
        public String CbiOrderStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderSuperDomRoyaltiesExcess.
        /// </summary>
        [DataMember]
        public String CbiOrderSuperDomRoyaltiesExcess { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderTracking.
        /// </summary>
        [DataMember]
        public String CbiOrderTracking { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderTrailing.
        /// </summary>
        [DataMember]
        public String CbiOrderTrailing { get; set; }
        /// <summary>
        /// Gets or sets the CbiOrderType.
        /// </summary>
        [DataMember]
        public String CbiOrderType { get; set; }
        /// <summary>
        /// Gets or sets the CbiPlaybackAccount.
        /// </summary>
        [DataMember]
        public String CbiPlaybackAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiPlaybackConnection.
        /// </summary>
        [DataMember]
        public String CbiPlaybackConnection { get; set; }
        /// <summary>
        /// Gets or sets the CbiPosition.
        /// </summary>
        [DataMember]
        public String CbiPosition { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionAddExecution.
        /// </summary>
        [DataMember]
        public String CbiPositionAddExecution { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionAveragePrice.
        /// </summary>
        [DataMember]
        public String CbiPositionAveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionCloseDisableStrategy.
        /// </summary>
        [DataMember]
        public String CbiPositionCloseDisableStrategy { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionCloseFailed.
        /// </summary>
        [DataMember]
        public String CbiPositionCloseFailed { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionCloseTimeoutWaitingForCancellations.
        /// </summary>
        [DataMember]
        public String CbiPositionCloseTimeoutWaitingForCancellations { get; set; }
        /// <summary>
        /// Gets or sets the CbiPositionStatementDate.
        /// </summary>
        [DataMember]
        public String CbiPositionStatementDate { get; set; }
        /// <summary>
        /// Gets or sets the CbiProductFreeEdition.
        /// </summary>
        [DataMember]
        public String CbiProductFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiProductMultiBrokerEdition.
        /// </summary>
        [DataMember]
        public String CbiProductMultiBrokerEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiProductStandardEdition.
        /// </summary>
        [DataMember]
        public String CbiProductStandardEdition { get; set; }
        /// <summary>
        /// Gets or sets the CbiProviderUnknown.
        /// </summary>
        [DataMember]
        public String CbiProviderUnknown { get; set; }
        /// <summary>
        /// Gets or sets the CbiQuantity.
        /// </summary>
        [DataMember]
        public String CbiQuantity { get; set; }
        /// <summary>
        /// Gets or sets the CbiRate.
        /// </summary>
        [DataMember]
        public String CbiRate { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportAccountEntitlementMissing.
        /// </summary>
        [DataMember]
        public String CbiReportAccountEntitlementMissing { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportLicenseFileNotFound.
        /// </summary>
        [DataMember]
        public String CbiReportLicenseFileNotFound { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNewCustomers.
        /// </summary>
        [DataMember]
        public String CbiReportNewCustomers { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoManageUserNorReportPermission.
        /// </summary>
        [DataMember]
        public String CbiReportNoManageUserNorReportPermission { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoMonitorNorReportPermission.
        /// </summary>
        [DataMember]
        public String CbiReportNoMonitorNorReportPermission { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoMonitorPermissions.
        /// </summary>
        [DataMember]
        public String CbiReportNoMonitorPermissions { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoPermissionToViewUserData.
        /// </summary>
        [DataMember]
        public String CbiReportNoPermissionToViewUserData { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNoReportPermission.
        /// </summary>
        [DataMember]
        public String CbiReportNoReportPermission { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportNotAllowedToManageUsers.
        /// </summary>
        [DataMember]
        public String CbiReportNotAllowedToManageUsers { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportParameterMissing.
        /// </summary>
        [DataMember]
        public String CbiReportParameterMissing { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportsUnavailable.
        /// </summary>
        [DataMember]
        public String CbiReportsUnavailable { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownAccount.
        /// </summary>
        [DataMember]
        public String CbiReportUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownInstrument.
        /// </summary>
        [DataMember]
        public String CbiReportUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownLogCategory.
        /// </summary>
        [DataMember]
        public String CbiReportUnknownLogCategory { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownLogLevel.
        /// </summary>
        [DataMember]
        public String CbiReportUnknownLogLevel { get; set; }
        /// <summary>
        /// Gets or sets the CbiReportUnknownUser.
        /// </summary>
        [DataMember]
        public String CbiReportUnknownUser { get; set; }
        /// <summary>
        /// Gets or sets the CbiRiskUnableToLoad.
        /// </summary>
        [DataMember]
        public String CbiRiskUnableToLoad { get; set; }
        /// <summary>
        /// Gets or sets the CbiRithmicOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiRithmicOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiRMSOnly.
        /// </summary>
        [DataMember]
        public String CbiRMSOnly { get; set; }
        /// <summary>
        /// Gets or sets the CbiRolloverContractMonth.
        /// </summary>
        [DataMember]
        public String CbiRolloverContractMonth { get; set; }
        /// <summary>
        /// Gets or sets the CbiRolloverDate.
        /// </summary>
        [DataMember]
        public String CbiRolloverDate { get; set; }
        /// <summary>
        /// Gets or sets the CbiRolloverOffset.
        /// </summary>
        [DataMember]
        public String CbiRolloverOffset { get; set; }
        /// <summary>
        /// Gets or sets the CbiScanOnMaterialized.
        /// </summary>
        [DataMember]
        public String CbiScanOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiSchwabOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiSchwabOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiServer.
        /// </summary>
        [DataMember]
        public String CbiServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiServerException.
        /// </summary>
        [DataMember]
        public String CbiServerException { get; set; }
        /// <summary>
        /// Gets or sets the CbiSharpPointOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiSharpPointOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimFeed.
        /// </summary>
        [DataMember]
        public String CbiSimFeed { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatedStopLimit.
        /// </summary>
        [DataMember]
        public String CbiSimulatedStopLimit { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatedStopMarket.
        /// </summary>
        [DataMember]
        public String CbiSimulatedStopMarket { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulationAccount.
        /// </summary>
        [DataMember]
        public String CbiSimulationAccount { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorChange.
        /// </summary>
        [DataMember]
        public String CbiSimulatorChange { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorChange2.
        /// </summary>
        [DataMember]
        public String CbiSimulatorChange2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorChange3.
        /// </summary>
        [DataMember]
        public String CbiSimulatorChange3 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorNoMarketData.
        /// </summary>
        [DataMember]
        public String CbiSimulatorNoMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorOrderAlreadyCancelled.
        /// </summary>
        [DataMember]
        public String CbiSimulatorOrderAlreadyCancelled { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorOrderAlreadyFilled.
        /// </summary>
        [DataMember]
        public String CbiSimulatorOrderAlreadyFilled { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorOrderAlreadyRejected.
        /// </summary>
        [DataMember]
        public String CbiSimulatorOrderAlreadyRejected { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit10.
        /// </summary>
        [DataMember]
        public String CbiSimulatorSubmit10 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit11.
        /// </summary>
        [DataMember]
        public String CbiSimulatorSubmit11 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit6.
        /// </summary>
        [DataMember]
        public String CbiSimulatorSubmit6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit7.
        /// </summary>
        [DataMember]
        public String CbiSimulatorSubmit7 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit8.
        /// </summary>
        [DataMember]
        public String CbiSimulatorSubmit8 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSimulatorSubmit9.
        /// </summary>
        [DataMember]
        public String CbiSimulatorSubmit9 { get; set; }
        /// <summary>
        /// Gets or sets the CbiSnapShotApplyError.
        /// </summary>
        [DataMember]
        public String CbiSnapShotApplyError { get; set; }
        /// <summary>
        /// Gets or sets the CbiSnapShotDiffError.
        /// </summary>
        [DataMember]
        public String CbiSnapShotDiffError { get; set; }
        /// <summary>
        /// Gets or sets the CbiSnapShotMakeError.
        /// </summary>
        [DataMember]
        public String CbiSnapShotMakeError { get; set; }
        /// <summary>
        /// Gets or sets the CbiSplitFactor.
        /// </summary>
        [DataMember]
        public String CbiSplitFactor { get; set; }
        /// <summary>
        /// Gets or sets the CbiStartOfDayPositions.
        /// </summary>
        [DataMember]
        public String CbiStartOfDayPositions { get; set; }
        /// <summary>
        /// Gets or sets the CbiSubmitIfTouched.
        /// </summary>
        [DataMember]
        public String CbiSubmitIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the CbiTdaOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiTdaOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyCedroTech.
        /// </summary>
        [DataMember]
        public String CbiTechnologyCedroTech { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyContinuum.
        /// </summary>
        [DataMember]
        public String CbiTechnologyContinuum { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyCqg.
        /// </summary>
        [DataMember]
        public String CbiTechnologyCqg { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyCTrader.
        /// </summary>
        [DataMember]
        public String CbiTechnologyCTrader { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyFXCM.
        /// </summary>
        [DataMember]
        public String CbiTechnologyFXCM { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyGain.
        /// </summary>
        [DataMember]
        public String CbiTechnologyGain { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyInteractiveBrokers.
        /// </summary>
        [DataMember]
        public String CbiTechnologyInteractiveBrokers { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyMBTrading.
        /// </summary>
        [DataMember]
        public String CbiTechnologyMBTrading { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyModalMais.
        /// </summary>
        [DataMember]
        public String CbiTechnologyModalMais { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyMultiBroker.
        /// </summary>
        [DataMember]
        public String CbiTechnologyMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyNinjaTraderBrokerage.
        /// </summary>
        [DataMember]
        public String CbiTechnologyNinjaTraderBrokerage { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyPatsystems.
        /// </summary>
        [DataMember]
        public String CbiTechnologyPatsystems { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyRithmic.
        /// </summary>
        [DataMember]
        public String CbiTechnologyRithmic { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologySchwab.
        /// </summary>
        [DataMember]
        public String CbiTechnologySchwab { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyTDAmeritrade.
        /// </summary>
        [DataMember]
        public String CbiTechnologyTDAmeritrade { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyTradovate.
        /// </summary>
        [DataMember]
        public String CbiTechnologyTradovate { get; set; }
        /// <summary>
        /// Gets or sets the CbiTechnologyVisionFinancialMarkets.
        /// </summary>
        [DataMember]
        public String CbiTechnologyVisionFinancialMarkets { get; set; }
        /// <summary>
        /// Gets or sets the CbiThereWasMoreData.
        /// </summary>
        [DataMember]
        public String CbiThereWasMoreData { get; set; }
        /// <summary>
        /// Gets or sets the CbiTime.
        /// </summary>
        [DataMember]
        public String CbiTime { get; set; }
        /// <summary>
        /// Gets or sets the CbiTransactionPurchase.
        /// </summary>
        [DataMember]
        public String CbiTransactionPurchase { get; set; }
        /// <summary>
        /// Gets or sets the CbiTTOptionsDisclaimer.
        /// </summary>
        [DataMember]
        public String CbiTTOptionsDisclaimer { get; set; }
        /// <summary>
        /// Gets or sets the CbiUnableToCreateInstance.
        /// </summary>
        [DataMember]
        public String CbiUnableToCreateInstance { get; set; }
        /// <summary>
        /// Gets or sets the CbiUnableToCreateInstance2.
        /// </summary>
        [DataMember]
        public String CbiUnableToCreateInstance2 { get; set; }
        /// <summary>
        /// Gets or sets the CbiUser.
        /// </summary>
        [DataMember]
        public String CbiUser { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserLogons.
        /// </summary>
        [DataMember]
        public String CbiUserLogons { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserMarketDataEntitlements.
        /// </summary>
        [DataMember]
        public String CbiUserMarketDataEntitlements { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserMarketDataEntitlementsChanges.
        /// </summary>
        [DataMember]
        public String CbiUserMarketDataEntitlementsChanges { get; set; }
        /// <summary>
        /// Gets or sets the CbiUserOnMaterialized.
        /// </summary>
        [DataMember]
        public String CbiUserOnMaterialized { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrial.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseFreeTrial { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpirationNotificationLog4.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseFreeTrialExpirationNotificationLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpirationNotificationLog5.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseFreeTrialExpirationNotificationLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpiredLog4.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseFreeTrialExpiredLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseFreeTrialExpiredLog5.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseFreeTrialExpiredLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseContactPurchase.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseInvalidLicenseContactPurchase { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseContactPurchaseOptions.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseInvalidLicenseContactPurchaseOptions { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseLog4.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseInvalidLicenseLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseInvalidLicenseLog5.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseInvalidLicenseLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseLicenseNotStartedLog4.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseLicenseNotStartedLog4 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseLicenseNotStartedLog5.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseLicenseNotStartedLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseNotificationMailSignature.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseNotificationMailSignature { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseOrderFlowPlusInvalid.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseOrderFlowPlusInvalid { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpirationNotificationLog5.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseRegularLicenseExpirationNotificationLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpirationNotificationLog6.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseRegularLicenseExpirationNotificationLog6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpiredLog5.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseRegularLicenseExpiredLog5 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseRegularLicenseExpiredLog6.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseRegularLicenseExpiredLog6 { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseUnableConnectVerifyTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseUnableConnectVerifyTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseVerify.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseVerify { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseVerifyingPrimaryServer.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseVerifyingPrimaryServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicenseVerifyingSecondaryServer.
        /// </summary>
        [DataMember]
        public String CbiVendorLicenseVerifyingSecondaryServer { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingCheckingTreeTrial.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingCheckingTreeTrial { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedRemoveLicense.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedRemoveLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedRemoveLicenseTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedRemoveLicenseTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateLicense.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedUpdateLicense { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateLicenseTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedUpdateLicenseTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateMessages.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedUpdateMessages { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUpdateMessagesTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedUpdateMessagesTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUploadProducts.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedUploadProducts { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedUploadProductsTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedUploadProductsTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedVerifyVendorNameKey.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedVerifyVendorNameKey { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingFailedVerifyVendorTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingFailedVerifyVendorTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingGetLicensesFailedTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingGetLicensesFailedTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVendorLicensingGetMessagesFailedTryAgain.
        /// </summary>
        [DataMember]
        public String CbiVendorLicensingGetMessagesFailedTryAgain { get; set; }
        /// <summary>
        /// Gets or sets the CbiVolumeTraded.
        /// </summary>
        [DataMember]
        public String CbiVolumeTraded { get; set; }
        /// <summary>
        /// Gets or sets the CodeCompilerException.
        /// </summary>
        [DataMember]
        public String CodeCompilerException { get; set; }
        /// <summary>
        /// Gets or sets the CodeCompilerIntellisenseCopyFailed.
        /// </summary>
        [DataMember]
        public String CodeCompilerIntellisenseCopyFailed { get; set; }
        /// <summary>
        /// Gets or sets the CodeCompilerLoadNewException.
        /// </summary>
        [DataMember]
        public String CodeCompilerLoadNewException { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingAssemblies.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorCopyingAssemblies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingCommissionTemplates.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorCopyingCommissionTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingFeeTemplates.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorCopyingFeeTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingMarketDataEntitlementTemplates.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorCopyingMarketDataEntitlementTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingRiskTemplates.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorCopyingRiskTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCopyingTradingHoursTemplates.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorCopyingTradingHoursTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorCreatingTemplatesFolder.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorCreatingTemplatesFolder { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorInstallationCorrupted.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorInstallationCorrupted { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorLoadingCustomAssembly1.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorLoadingCustomAssembly1 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorLoadingCustomAssembly2.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorLoadingCustomAssembly2 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorLoadingVendorAssembly.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorLoadingVendorAssembly { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationErrorOutdated.
        /// </summary>
        [DataMember]
        public String CoreApplicationErrorOutdated { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart1.
        /// </summary>
        [DataMember]
        public String CoreApplicationStart1 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart2.
        /// </summary>
        [DataMember]
        public String CoreApplicationStart2 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart3.
        /// </summary>
        [DataMember]
        public String CoreApplicationStart3 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStart4.
        /// </summary>
        [DataMember]
        public String CoreApplicationStart4 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartAtiDisabled.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartAtiDisabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartAtiEnabled.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartAtiEnabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartAutoConnect.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartAutoConnect { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartClearCache.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartClearCache { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCompile.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartCompile { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCompile2.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartCompile2 { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCompiling.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartCompiling { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartCopyingAssemblies.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartCopyingAssemblies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartGlobalSimulationDisabled.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartGlobalSimulationDisabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartGlobalSimulationEnabled.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartGlobalSimulationEnabled { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartInitializingDB.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartInitializingDB { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartInstallFile.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartInstallFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingAccounts.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingAssemblies.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingAssemblies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingExecutions.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingExecutions { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingInstruments.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingMasterInstruments.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingOrders.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingOrders { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingSimulationAccountsPositions.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingSimulationAccountsPositions { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingStrategies.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingStrategies { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartLoadingUsers.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartLoadingUsers { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartNewAddOnsMessage.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartNewAddOnsMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreApplicationStartObjectVersionMessage.
        /// </summary>
        [DataMember]
        public String CoreApplicationStartObjectVersionMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreAssemblyDictionaryGetType.
        /// </summary>
        [DataMember]
        public String CoreAssemblyDictionaryGetType { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerDeserializeAccount.
        /// </summary>
        [DataMember]
        public String CoreDeserializerDeserializeAccount { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerDeserializeInstrument.
        /// </summary>
        [DataMember]
        public String CoreDeserializerDeserializeInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerDeserializeOrder.
        /// </summary>
        [DataMember]
        public String CoreDeserializerDeserializeOrder { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerQueryEntitiesLimit.
        /// </summary>
        [DataMember]
        public String CoreDeserializerQueryEntitiesLimit { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerScanIndicator.
        /// </summary>
        [DataMember]
        public String CoreDeserializerScanIndicator { get; set; }
        /// <summary>
        /// Gets or sets the CoreDeserializerSnapShotApplyFailed.
        /// </summary>
        [DataMember]
        public String CoreDeserializerSnapShotApplyFailed { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingChartData.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingChartData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingConfigFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingConfigFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingDatabase.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingDatabase { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingLogAndTrace.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingLogAndTrace { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingMarketRecordings.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingMarketRecordings { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingTemplates.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupArchivingWorkspaces.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupArchivingWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupBackingUp.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupBackingUp { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupErrorMessage.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupErrorMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupNonCompileableWarning.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupNonCompileableWarning { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsBackupSuccessMessageLog.
        /// </summary>
        [DataMember]
        public String CoreGlobalsBackupSuccessMessageLog { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsCantImportNinjaScriptFilesProgrammingErrors.
        /// </summary>
        [DataMember]
        public String CoreGlobalsCantImportNinjaScriptFilesProgrammingErrors { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsChartData.
        /// </summary>
        [DataMember]
        public String CoreGlobalsChartData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsCQGAndContinuumNotIdentical.
        /// </summary>
        [DataMember]
        public String CoreGlobalsCQGAndContinuumNotIdentical { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsD2DFactoryException.
        /// </summary>
        [DataMember]
        public String CoreGlobalsD2DFactoryException { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsDatabase.
        /// </summary>
        [DataMember]
        public String CoreGlobalsDatabase { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsFailedLoadVendorAssembly.
        /// </summary>
        [DataMember]
        public String CoreGlobalsFailedLoadVendorAssembly { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsFromLocalizedObject.
        /// </summary>
        [DataMember]
        public String CoreGlobalsFromLocalizedObject { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsGetExpiryYear.
        /// </summary>
        [DataMember]
        public String CoreGlobalsGetExpiryYear { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsKinetickAndIQNotIdentical.
        /// </summary>
        [DataMember]
        public String CoreGlobalsKinetickAndIQNotIdentical { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsLogAndTraceFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsLogAndTraceFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsMainConfigurationFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsMainConfigurationFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsMarketReplayData.
        /// </summary>
        [DataMember]
        public String CoreGlobalsMarketReplayData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNeedToCloseAccountConnectionToRestore.
        /// </summary>
        [DataMember]
        public String CoreGlobalsNeedToCloseAccountConnectionToRestore { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNinjaScriptCantRestoredCorruptInstallation.
        /// </summary>
        [DataMember]
        public String CoreGlobalsNinjaScriptCantRestoredCorruptInstallation { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsNinjaScriptFilesNotRestored.
        /// </summary>
        [DataMember]
        public String CoreGlobalsNinjaScriptFilesNotRestored { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsPlaySound.
        /// </summary>
        [DataMember]
        public String CoreGlobalsPlaySound { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoredProgrammingErrors.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoredProgrammingErrors { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoredWithErrorsMessage.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoredWithErrorsMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreFailedNewerVersion.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoreFailedNewerVersion { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreFailedOlderVersion.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoreFailedOlderVersion { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreUnpackingArchive.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoreUnpackingArchive { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoreUnsuccessful.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoreUnsuccessful { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoring.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoring { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringChartData.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringChartData { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringConfigurationFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringConfigurationFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringDatabase.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringDatabase { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringLogAndTraceFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringLogAndTraceFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringMarketRecordings.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringMarketRecordings { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringTemplates.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsRestoringWorkspaces.
        /// </summary>
        [DataMember]
        public String CoreGlobalsRestoringWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsSendMail.
        /// </summary>
        [DataMember]
        public String CoreGlobalsSendMail { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsSuccessfullyRestoredLog.
        /// </summary>
        [DataMember]
        public String CoreGlobalsSuccessfullyRestoredLog { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsSuccessfullyRestoredMessage.
        /// </summary>
        [DataMember]
        public String CoreGlobalsSuccessfullyRestoredMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsTemplates.
        /// </summary>
        [DataMember]
        public String CoreGlobalsTemplates { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsThirdPartyInvalidStateMustShutDown.
        /// </summary>
        [DataMember]
        public String CoreGlobalsThirdPartyInvalidStateMustShutDown { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsToLocalizedObject.
        /// </summary>
        [DataMember]
        public String CoreGlobalsToLocalizedObject { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsUnableRestoreContainsCorruptNinjaScriptFiles.
        /// </summary>
        [DataMember]
        public String CoreGlobalsUnableRestoreContainsCorruptNinjaScriptFiles { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsUnableToLoadPFConfigFile.
        /// </summary>
        [DataMember]
        public String CoreGlobalsUnableToLoadPFConfigFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsUnableToLoadServerConfigFile.
        /// </summary>
        [DataMember]
        public String CoreGlobalsUnableToLoadServerConfigFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsVendorAssemblyLoaded.
        /// </summary>
        [DataMember]
        public String CoreGlobalsVendorAssemblyLoaded { get; set; }
        /// <summary>
        /// Gets or sets the CoreGlobalsWorkspaces.
        /// </summary>
        [DataMember]
        public String CoreGlobalsWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the CoreGobalsDoYouWishToRestore.
        /// </summary>
        [DataMember]
        public String CoreGobalsDoYouWishToRestore { get; set; }
        /// <summary>
        /// Gets or sets the CoreImportBackupFile.
        /// </summary>
        [DataMember]
        public String CoreImportBackupFile { get; set; }
        /// <summary>
        /// Gets or sets the CoreInstrumentationInitializeError.
        /// </summary>
        [DataMember]
        public String CoreInstrumentationInitializeError { get; set; }
        /// <summary>
        /// Gets or sets the CoreMailThreadProc.
        /// </summary>
        [DataMember]
        public String CoreMailThreadProc { get; set; }
        /// <summary>
        /// Gets or sets the CoreSerializerSerialize.
        /// </summary>
        [DataMember]
        public String CoreSerializerSerialize { get; set; }
        /// <summary>
        /// Gets or sets the CoreServerHdsClientDeserializeCorruptDataMessage.
        /// </summary>
        [DataMember]
        public String CoreServerHdsClientDeserializeCorruptDataMessage { get; set; }
        /// <summary>
        /// Gets or sets the CoreSoundThreadProc.
        /// </summary>
        [DataMember]
        public String CoreSoundThreadProc { get; set; }
        /// <summary>
        /// Gets or sets the CoreStatBetaCf.
        /// </summary>
        [DataMember]
        public String CoreStatBetaCf { get; set; }
        /// <summary>
        /// Gets or sets the CoreUnhandledException.
        /// </summary>
        [DataMember]
        public String CoreUnhandledException { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField.
        /// </summary>
        [DataMember]
        public String CotReportField { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType.
        /// </summary>
        [DataMember]
        public String CotReportType { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterBufferOverflow.
        /// </summary>
        [DataMember]
        public String CqgAdapterBufferOverflow { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCancel.
        /// </summary>
        [DataMember]
        public String CqgAdapterCancel { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterChange.
        /// </summary>
        [DataMember]
        public String CqgAdapterChange { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterClOrderIdMissing.
        /// </summary>
        [DataMember]
        public String CqgAdapterClOrderIdMissing { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCollateralSubscriptionFailed.
        /// </summary>
        [DataMember]
        public String CqgAdapterCollateralSubscriptionFailed { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCompoundOrderError.
        /// </summary>
        [DataMember]
        public String CqgAdapterCompoundOrderError { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM.
        /// </summary>
        [DataMember]
        public String CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM2.
        /// </summary>
        [DataMember]
        public String CqgAdapterConnectionStatusHandlerDisconnectInvalidFCM2 { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterCqgOrderIdMissing.
        /// </summary>
        [DataMember]
        public String CqgAdapterCqgOrderIdMissing { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterErrorOnHistoricalData.
        /// </summary>
        [DataMember]
        public String CqgAdapterErrorOnHistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterException.
        /// </summary>
        [DataMember]
        public String CqgAdapterException { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterExchangeMapChanged.
        /// </summary>
        [DataMember]
        public String CqgAdapterExchangeMapChanged { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterHistoricalRequestTooFarBack.
        /// </summary>
        [DataMember]
        public String CqgAdapterHistoricalRequestTooFarBack { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterInvalidLotSize.
        /// </summary>
        [DataMember]
        public String CqgAdapterInvalidLotSize { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterMarketDataSubError.
        /// </summary>
        [DataMember]
        public String CqgAdapterMarketDataSubError { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterMissingCurrency.
        /// </summary>
        [DataMember]
        public String CqgAdapterMissingCurrency { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterMissingTickSize.
        /// </summary>
        [DataMember]
        public String CqgAdapterMissingTickSize { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterOnlyTwoOcoOrders.
        /// </summary>
        [DataMember]
        public String CqgAdapterOnlyTwoOcoOrders { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterOrdersSubscriptionFailed.
        /// </summary>
        [DataMember]
        public String CqgAdapterOrdersSubscriptionFailed { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterOrderUnknownAccount.
        /// </summary>
        [DataMember]
        public String CqgAdapterOrderUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterPositionsSubscriptionFailed.
        /// </summary>
        [DataMember]
        public String CqgAdapterPositionsSubscriptionFailed { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterPositionUnknownAccount.
        /// </summary>
        [DataMember]
        public String CqgAdapterPositionUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterSubmit.
        /// </summary>
        [DataMember]
        public String CqgAdapterSubmit { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnableToConnect.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnableToConnect { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedCsvFormat.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnexpectedCsvFormat { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedFileType.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnexpectedFileType { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedInstrument.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnexpectedInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnexpectedZipPath.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnexpectedZipPath { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownContractIdForOrder.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnknownContractIdForOrder { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownContractIdForPosition.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnknownContractIdForPosition { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownInstrument.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterUnknownOrder.
        /// </summary>
        [DataMember]
        public String CqgAdapterUnknownOrder { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterWebApiBalanceUnknownAccount.
        /// </summary>
        [DataMember]
        public String CqgAdapterWebApiBalanceUnknownAccount { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterWebApiInformationReportError.
        /// </summary>
        [DataMember]
        public String CqgAdapterWebApiInformationReportError { get; set; }
        /// <summary>
        /// Gets or sets the CqgAdapterWebApiSymbolMismatch.
        /// </summary>
        [DataMember]
        public String CqgAdapterWebApiSymbolMismatch { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsAddFailed.
        /// </summary>
        [DataMember]
        public String DataBarsAddFailed { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsDownloadFromProviderError.
        /// </summary>
        [DataMember]
        public String DataBarsDownloadFromProviderError { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsHistoricalDataCorruptedDaily.
        /// </summary>
        [DataMember]
        public String DataBarsHistoricalDataCorruptedDaily { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsHistoricalDataCorruptedIntraday.
        /// </summary>
        [DataMember]
        public String DataBarsHistoricalDataCorruptedIntraday { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriod.
        /// </summary>
        [DataMember]
        public String DataBarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodBasePeriodType.
        /// </summary>
        [DataMember]
        public String DataBarsPeriodBasePeriodType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodBasePeriodValue.
        /// </summary>
        [DataMember]
        public String DataBarsPeriodBasePeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodPointAndFigurePriceType.
        /// </summary>
        [DataMember]
        public String DataBarsPeriodPointAndFigurePriceType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodPriceBasedOn.
        /// </summary>
        [DataMember]
        public String DataBarsPeriodPriceBasedOn { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodReversalType.
        /// </summary>
        [DataMember]
        public String DataBarsPeriodReversalType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodValue2.
        /// </summary>
        [DataMember]
        public String DataBarsPeriodValue2 { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsPeriodVolumetricBarsTypeDeltaType.
        /// </summary>
        [DataMember]
        public String DataBarsPeriodVolumetricBarsTypeDeltaType { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsRemoveLastBarNotSupportedTickReplay.
        /// </summary>
        [DataMember]
        public String DataBarsRemoveLastBarNotSupportedTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsRequestBarsSeriesError.
        /// </summary>
        [DataMember]
        public String DataBarsRequestBarsSeriesError { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsSeriesAbortOnDisconnect.
        /// </summary>
        [DataMember]
        public String DataBarsSeriesAbortOnDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsSeriesExportingDataRemaining.
        /// </summary>
        [DataMember]
        public String DataBarsSeriesExportingDataRemaining { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsSeriesFromSmallerTo.
        /// </summary>
        [DataMember]
        public String DataBarsSeriesFromSmallerTo { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeRemoveLastBar.
        /// </summary>
        [DataMember]
        public String DataBarsTypeRemoveLastBar { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableClearCacheData.
        /// </summary>
        [DataMember]
        public String DataBarsUnableClearCacheData { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableCreateFile.
        /// </summary>
        [DataMember]
        public String DataBarsUnableCreateFile { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableReadCacheData.
        /// </summary>
        [DataMember]
        public String DataBarsUnableReadCacheData { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableSaveData.
        /// </summary>
        [DataMember]
        public String DataBarsUnableSaveData { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsUnableWriteCacheData.
        /// </summary>
        [DataMember]
        public String DataBarsUnableWriteCacheData { get; set; }
        /// <summary>
        /// Gets or sets the DataColorSeriesSetError.
        /// </summary>
        [DataMember]
        public String DataColorSeriesSetError { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataGetProperties.
        /// </summary>
        [DataMember]
        public String DataFundamentalDataGetProperties { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStartException.
        /// </summary>
        [DataMember]
        public String DataFundamentalDataStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStartInstrument.
        /// </summary>
        [DataMember]
        public String DataFundamentalDataStartInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStartNotSupported.
        /// </summary>
        [DataMember]
        public String DataFundamentalDataStartNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStopException.
        /// </summary>
        [DataMember]
        public String DataFundamentalDataStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStopInstrument.
        /// </summary>
        [DataMember]
        public String DataFundamentalDataStopInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataFundamentalDataStopNotSupported.
        /// </summary>
        [DataMember]
        public String DataFundamentalDataStopNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataGetHostListsException.
        /// </summary>
        [DataMember]
        public String DataGetHostListsException { get; set; }
        /// <summary>
        /// Gets or sets the DataGetPropertyValueException.
        /// </summary>
        [DataMember]
        public String DataGetPropertyValueException { get; set; }
        /// <summary>
        /// Gets or sets the DataHotListStartException.
        /// </summary>
        [DataMember]
        public String DataHotListStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataHotListStopException.
        /// </summary>
        [DataMember]
        public String DataHotListStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataImportDataMetaStockImportTypeLoad.
        /// </summary>
        [DataMember]
        public String DataImportDataMetaStockImportTypeLoad { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalAskMaxSpread.
        /// </summary>
        [DataMember]
        public String DataImportIllegalAskMaxSpread { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalAskOpen.
        /// </summary>
        [DataMember]
        public String DataImportIllegalAskOpen { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalBidMaxSpread.
        /// </summary>
        [DataMember]
        public String DataImportIllegalBidMaxSpread { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalBidOpen.
        /// </summary>
        [DataMember]
        public String DataImportIllegalBidOpen { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalCloseHigh.
        /// </summary>
        [DataMember]
        public String DataImportIllegalCloseHigh { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalCloseLow.
        /// </summary>
        [DataMember]
        public String DataImportIllegalCloseLow { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalHighLow.
        /// </summary>
        [DataMember]
        public String DataImportIllegalHighLow { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalLowHigh.
        /// </summary>
        [DataMember]
        public String DataImportIllegalLowHigh { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalOpenHigh.
        /// </summary>
        [DataMember]
        public String DataImportIllegalOpenHigh { get; set; }
        /// <summary>
        /// Gets or sets the DataImportIllegalOpenLow.
        /// </summary>
        [DataMember]
        public String DataImportIllegalOpenLow { get; set; }
        /// <summary>
        /// Gets or sets the DataImportMessage.
        /// </summary>
        [DataMember]
        public String DataImportMessage { get; set; }
        /// <summary>
        /// Gets or sets the DataImportTimestampInvalid.
        /// </summary>
        [DataMember]
        public String DataImportTimestampInvalid { get; set; }
        /// <summary>
        /// Gets or sets the DataImportTimeStampSmaller.
        /// </summary>
        [DataMember]
        public String DataImportTimeStampSmaller { get; set; }
        /// <summary>
        /// Gets or sets the DataImportTimeStampSmallerEqual.
        /// </summary>
        [DataMember]
        public String DataImportTimeStampSmallerEqual { get; set; }
        /// <summary>
        /// Gets or sets the DataImportVolumeGreaterEqualZero.
        /// </summary>
        [DataMember]
        public String DataImportVolumeGreaterEqualZero { get; set; }
        /// <summary>
        /// Gets or sets the DataInvalidPropertyRange.
        /// </summary>
        [DataMember]
        public String DataInvalidPropertyRange { get; set; }
        /// <summary>
        /// Gets or sets the DataLineDefaultName.
        /// </summary>
        [DataMember]
        public String DataLineDefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStartException.
        /// </summary>
        [DataMember]
        public String DataMarketDataStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStartInstrument.
        /// </summary>
        [DataMember]
        public String DataMarketDataStartInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStartNotSupported.
        /// </summary>
        [DataMember]
        public String DataMarketDataStartNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStopException.
        /// </summary>
        [DataMember]
        public String DataMarketDataStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStopInstrument.
        /// </summary>
        [DataMember]
        public String DataMarketDataStopInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDataStopNotSupported.
        /// </summary>
        [DataMember]
        public String DataMarketDataStopNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStartException.
        /// </summary>
        [DataMember]
        public String DataMarketDepthStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStartInstrument.
        /// </summary>
        [DataMember]
        public String DataMarketDepthStartInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStartNotSupported.
        /// </summary>
        [DataMember]
        public String DataMarketDepthStartNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStopException.
        /// </summary>
        [DataMember]
        public String DataMarketDepthStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStopInstrument.
        /// </summary>
        [DataMember]
        public String DataMarketDepthStopInstrument { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketDepthStopNotSupported.
        /// </summary>
        [DataMember]
        public String DataMarketDepthStopNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMarketReplayStart.
        /// </summary>
        [DataMember]
        public String DataMarketReplayStart { get; set; }
        /// <summary>
        /// Gets or sets the DataMemBarsExceedsTimeGap.
        /// </summary>
        [DataMember]
        public String DataMemBarsExceedsTimeGap { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeImportError.
        /// </summary>
        [DataMember]
        public String DataMetaStockImportTypeImportError { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInitialize64bitNotSupported.
        /// </summary>
        [DataMember]
        public String DataMetaStockImportTypeInitialize64bitNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInitializeDirectoryError.
        /// </summary>
        [DataMember]
        public String DataMetaStockImportTypeInitializeDirectoryError { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInitializeInvalidSymbol.
        /// </summary>
        [DataMember]
        public String DataMetaStockImportTypeInitializeInvalidSymbol { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInstrumentNotSupported.
        /// </summary>
        [DataMember]
        public String DataMetaStockImportTypeInstrumentNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeInvalidTimeStamp.
        /// </summary>
        [DataMember]
        public String DataMetaStockImportTypeInvalidTimeStamp { get; set; }
        /// <summary>
        /// Gets or sets the DataMetaStockImportTypeOnlyIntraday.
        /// </summary>
        [DataMember]
        public String DataMetaStockImportTypeOnlyIntraday { get; set; }
        /// <summary>
        /// Gets or sets the DataNewsStartException.
        /// </summary>
        [DataMember]
        public String DataNewsStartException { get; set; }
        /// <summary>
        /// Gets or sets the DataNewsStopException.
        /// </summary>
        [DataMember]
        public String DataNewsStopException { get; set; }
        /// <summary>
        /// Gets or sets the DataSessionBarSimulatorBarsError.
        /// </summary>
        [DataMember]
        public String DataSessionBarSimulatorBarsError { get; set; }
        /// <summary>
        /// Gets or sets the DataSessionBarSimulatorNoBarsFound.
        /// </summary>
        [DataMember]
        public String DataSessionBarSimulatorNoBarsFound { get; set; }
        /// <summary>
        /// Gets or sets the DataSubscribeInstrumentIsNull.
        /// </summary>
        [DataMember]
        public String DataSubscribeInstrumentIsNull { get; set; }
        /// <summary>
        /// Gets or sets the DataSubscribeInWrongThread.
        /// </summary>
        [DataMember]
        public String DataSubscribeInWrongThread { get; set; }
        /// <summary>
        /// Gets or sets the DataTradingHoursUnableLoadTradingHours.
        /// </summary>
        [DataMember]
        public String DataTradingHoursUnableLoadTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the DataTradingHoursUseDataSeriesSettings.
        /// </summary>
        [DataMember]
        public String DataTradingHoursUseDataSeriesSettings { get; set; }
        /// <summary>
        /// Gets or sets the DataTradingHoursUseInstrumentSettings.
        /// </summary>
        [DataMember]
        public String DataTradingHoursUseInstrumentSettings { get; set; }
        /// <summary>
        /// Gets or sets the DbThreadExecute.
        /// </summary>
        [DataMember]
        public String DbThreadExecute { get; set; }
        /// <summary>
        /// Gets or sets the Default.
        /// </summary>
        [DataMember]
        public String Default { get; set; }
        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        [DataMember]
        public String Error { get; set; }
        /// <summary>
        /// Gets or sets the FileFilterAnyWinForms.
        /// </summary>
        [DataMember]
        public String FileFilterAnyWinForms { get; set; }
        /// <summary>
        /// Gets or sets the Gui12Hour.
        /// </summary>
        [DataMember]
        public String Gui12Hour { get; set; }
        /// <summary>
        /// Gets or sets the Gui24Hour.
        /// </summary>
        [DataMember]
        public String Gui24Hour { get; set; }
        /// <summary>
        /// Gets or sets the GuiAccounts.
        /// </summary>
        [DataMember]
        public String GuiAccounts { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdapterServer.
        /// </summary>
        [DataMember]
        public String GuiAdapterServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdjustBalanceBy.
        /// </summary>
        [DataMember]
        public String GuiAdjustBalanceBy { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdmin.
        /// </summary>
        [DataMember]
        public String GuiAdmin { get; set; }
        /// <summary>
        /// Gets or sets the GuiAdminServer.
        /// </summary>
        [DataMember]
        public String GuiAdminServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiAlert.
        /// </summary>
        [DataMember]
        public String GuiAlert { get; set; }
        /// <summary>
        /// Gets or sets the GuiAlertDisabled.
        /// </summary>
        [DataMember]
        public String GuiAlertDisabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiAlertEnabled.
        /// </summary>
        [DataMember]
        public String GuiAlertEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiApplicationType.
        /// </summary>
        [DataMember]
        public String GuiApplicationType { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIAtInterface.
        /// </summary>
        [DataMember]
        public String GuiATIAtInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIDefaultAccount.
        /// </summary>
        [DataMember]
        public String GuiATIDefaultAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIIgnoreDuplicateOifFiles.
        /// </summary>
        [DataMember]
        public String GuiATIIgnoreDuplicateOifFiles { get; set; }
        /// <summary>
        /// Gets or sets the GuiATIServerPort.
        /// </summary>
        [DataMember]
        public String GuiATIServerPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationEmailInterface.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationEmailInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationEmailInterfaceEnabled.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationEmailInterfaceEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationLimitPriceOffset.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationLimitPriceOffset { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationOrderHandingSubmit.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationOrderHandingSubmit { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationOrderHandling.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationOrderHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationStopOrderHandling.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationStopOrderHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationStopOrderHandlingSubmit.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationStopOrderHandlingSubmit { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationSubmitMarketOrderIfStopRejected.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationSubmitMarketOrderIfStopRejected { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationSyncTimeout.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationSyncTimeout { get; set; }
        /// <summary>
        /// Gets or sets the GuiATITradeStationUnfilledToMarketDelay.
        /// </summary>
        [DataMember]
        public String GuiATITradeStationUnfilledToMarketDelay { get; set; }
        /// <summary>
        /// Gets or sets the GuiATMStrategy.
        /// </summary>
        [DataMember]
        public String GuiATMStrategy { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePosition.
        /// </summary>
        [DataMember]
        public String GuiAutoClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionEnable.
        /// </summary>
        [DataMember]
        public String GuiAutoClosePositionEnable { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionInstruments.
        /// </summary>
        [DataMember]
        public String GuiAutoClosePositionInstruments { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionInstrumentsPrompt.
        /// </summary>
        [DataMember]
        public String GuiAutoClosePositionInstrumentsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoClosePositionTime.
        /// </summary>
        [DataMember]
        public String GuiAutoClosePositionTime { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenAccount.
        /// </summary>
        [DataMember]
        public String GuiAutoFlattenAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenAccountEnable.
        /// </summary>
        [DataMember]
        public String GuiAutoFlattenAccountEnable { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenAllPositions.
        /// </summary>
        [DataMember]
        public String GuiAutoFlattenAllPositions { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoFlattenTime.
        /// </summary>
        [DataMember]
        public String GuiAutoFlattenTime { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutoLiquidation.
        /// </summary>
        [DataMember]
        public String GuiAutoLiquidation { get; set; }
        /// <summary>
        /// Gets or sets the GuiAutomatedTradingInterface.
        /// </summary>
        [DataMember]
        public String GuiAutomatedTradingInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiBP.
        /// </summary>
        [DataMember]
        public String GuiBP { get; set; }
        /// <summary>
        /// Gets or sets the GuiBuy.
        /// </summary>
        [DataMember]
        public String GuiBuy { get; set; }
        /// <summary>
        /// Gets or sets the GuiCalculations.
        /// </summary>
        [DataMember]
        public String GuiCalculations { get; set; }
        /// <summary>
        /// Gets or sets the GuiCancelEntriesOnStrategyDisable.
        /// </summary>
        [DataMember]
        public String GuiCancelEntriesOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the GuiCancelExitsOnStrategyDisable.
        /// </summary>
        [DataMember]
        public String GuiCancelExitsOnStrategyDisable { get; set; }
        /// <summary>
        /// Gets or sets the GuiCbiMasterInstrumentDividendsPrompt.
        /// </summary>
        [DataMember]
        public String GuiCbiMasterInstrumentDividendsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiCbiMasterInstrumentSplitsPrompt.
        /// </summary>
        [DataMember]
        public String GuiCbiMasterInstrumentSplitsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiChart.
        /// </summary>
        [DataMember]
        public String GuiChart { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartForceSoftwareRendering.
        /// </summary>
        [DataMember]
        public String GuiChartForceSoftwareRendering { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartPerformanceOutput.
        /// </summary>
        [DataMember]
        public String GuiChartPerformanceOutput { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartRefreshInterval.
        /// </summary>
        [DataMember]
        public String GuiChartRefreshInterval { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartShowThumbnails.
        /// </summary>
        [DataMember]
        public String GuiChartShowThumbnails { get; set; }
        /// <summary>
        /// Gets or sets the GuiCommission.
        /// </summary>
        [DataMember]
        public String GuiCommission { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmClosePosition.
        /// </summary>
        [DataMember]
        public String GuiConfirmClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmOrderCancellation.
        /// </summary>
        [DataMember]
        public String GuiConfirmOrderCancellation { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmOrderChange.
        /// </summary>
        [DataMember]
        public String GuiConfirmOrderChange { get; set; }
        /// <summary>
        /// Gets or sets the GuiConfirmOrderPlacement.
        /// </summary>
        [DataMember]
        public String GuiConfirmOrderPlacement { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnect.
        /// </summary>
        [DataMember]
        public String GuiConnect { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionAutoSubscribe2Instruments.
        /// </summary>
        [DataMember]
        public String GuiConnectionAutoSubscribe2Instruments { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionBigTickEnvironment.
        /// </summary>
        [DataMember]
        public String GuiConnectionBigTickEnvironment { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionClearUseDemoData.
        /// </summary>
        [DataMember]
        public String GuiConnectionClearUseDemoData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseApiKey.
        /// </summary>
        [DataMember]
        public String GuiConnectionCoinbaseApiKey { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseApiPassphrase.
        /// </summary>
        [DataMember]
        public String GuiConnectionCoinbaseApiPassphrase { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseApiSecret.
        /// </summary>
        [DataMember]
        public String GuiConnectionCoinbaseApiSecret { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCoinbaseCancelOnDisconnect.
        /// </summary>
        [DataMember]
        public String GuiConnectionCoinbaseCancelOnDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionConnectOnStartup.
        /// </summary>
        [DataMember]
        public String GuiConnectionConnectOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCqgIncludeFX.
        /// </summary>
        [DataMember]
        public String GuiConnectionCqgIncludeFX { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCredentials.
        /// </summary>
        [DataMember]
        public String GuiConnectionCredentials { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionCredentialsProvider.
        /// </summary>
        [DataMember]
        public String GuiConnectionCredentialsProvider { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionDemo.
        /// </summary>
        [DataMember]
        public String GuiConnectionDemo { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionDisableL2Data.
        /// </summary>
        [DataMember]
        public String GuiConnectionDisableL2Data { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalDailyHost.
        /// </summary>
        [DataMember]
        public String GuiConnectionESignalDailyHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalIntlTickHost.
        /// </summary>
        [DataMember]
        public String GuiConnectionESignalIntlTickHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalLevel2Host.
        /// </summary>
        [DataMember]
        public String GuiConnectionESignalLevel2Host { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalNewsHost.
        /// </summary>
        [DataMember]
        public String GuiConnectionESignalNewsHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalProxyCategory.
        /// </summary>
        [DataMember]
        public String GuiConnectionESignalProxyCategory { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalTickHost.
        /// </summary>
        [DataMember]
        public String GuiConnectionESignalTickHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionESignalTracing.
        /// </summary>
        [DataMember]
        public String GuiConnectionESignalTracing { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionFxcmPin.
        /// </summary>
        [DataMember]
        public String GuiConnectionFxcmPin { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionGainBrandCode.
        /// </summary>
        [DataMember]
        public String GuiConnectionGainBrandCode { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionGainG2Account.
        /// </summary>
        [DataMember]
        public String GuiConnectionGainG2Account { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionHistoricalDataServer.
        /// </summary>
        [DataMember]
        public String GuiConnectionHistoricalDataServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionHost.
        /// </summary>
        [DataMember]
        public String GuiConnectionHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionHostOptional.
        /// </summary>
        [DataMember]
        public String GuiConnectionHostOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBAutoLogOn.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBAutoLogOn { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBAutoLogonPath.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBAutoLogonPath { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBClientId.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBClientId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBConnectWith.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBConnectWith { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBFxLotSize.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBFxLotSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBLogLevel.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBLogLevel { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBNewApi.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBNewApi { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBPasswordOptional.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBPasswordOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBPortGateway.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBPortGateway { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBPortTws.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBPortTws { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBRuntimePopupHandling.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBRuntimePopupHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBTriggerAfterHours.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBTriggerAfterHours { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIBUseUserSettings.
        /// </summary>
        [DataMember]
        public String GuiConnectionIBUseUserSettings { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionIsPasswordRequiredOnStartup.
        /// </summary>
        [DataMember]
        public String GuiConnectionIsPasswordRequiredOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionKinetickGlobexNonProFees.
        /// </summary>
        [DataMember]
        public String GuiConnectionKinetickGlobexNonProFees { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionKinetickUseBackAdjusted.
        /// </summary>
        [DataMember]
        public String GuiConnectionKinetickUseBackAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionKinetickUseFundamentalData.
        /// </summary>
        [DataMember]
        public String GuiConnectionKinetickUseFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public String GuiConnectionLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionLogin.
        /// </summary>
        [DataMember]
        public String GuiConnectionLogin { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionLossHandling.
        /// </summary>
        [DataMember]
        public String GuiConnectionLossHandling { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionManageOrders.
        /// </summary>
        [DataMember]
        public String GuiConnectionManageOrders { get; set; }
        /// <summary>
        /// Gets or sets the GUIConnectionMBTShowNavigator.
        /// </summary>
        [DataMember]
        public String GUIConnectionMBTShowNavigator { get; set; }
        /// <summary>
        /// Gets or sets the GUIConnectionMBTUseSnapshot.
        /// </summary>
        [DataMember]
        public String GUIConnectionMBTUseSnapshot { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionModalMaisDigitalSignature.
        /// </summary>
        [DataMember]
        public String GuiConnectionModalMaisDigitalSignature { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionMode.
        /// </summary>
        [DataMember]
        public String GuiConnectionMode { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionName.
        /// </summary>
        [DataMember]
        public String GuiConnectionName { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionNinjaTraderHistoricalDataServer.
        /// </summary>
        [DataMember]
        public String GuiConnectionNinjaTraderHistoricalDataServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionPassword.
        /// </summary>
        [DataMember]
        public String GuiConnectionPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionPasswordOptional.
        /// </summary>
        [DataMember]
        public String GuiConnectionPasswordOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionPort.
        /// </summary>
        [DataMember]
        public String GuiConnectionPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionProvider.
        /// </summary>
        [DataMember]
        public String GuiConnectionProvider { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionRithmicConnection.
        /// </summary>
        [DataMember]
        public String GuiConnectionRithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionRunAsProcess.
        /// </summary>
        [DataMember]
        public String GuiConnectionRunAsProcess { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionSettings.
        /// </summary>
        [DataMember]
        public String GuiConnectionSettings { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionSSL.
        /// </summary>
        [DataMember]
        public String GuiConnectionSSL { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTradovateAccountType.
        /// </summary>
        [DataMember]
        public String GuiConnectionTradovateAccountType { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTradovateUseDevEnv.
        /// </summary>
        [DataMember]
        public String GuiConnectionTradovateUseDevEnv { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTradovateUseNativeHistData.
        /// </summary>
        [DataMember]
        public String GuiConnectionTradovateUseNativeHistData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTAccountNumber.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTAccountNumber { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerHost.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTOrderServerHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerPassword.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTOrderServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerPort.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTOrderServerPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerSenderId.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTOrderServerSenderId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTOrderServerTargetId.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTOrderServerTargetId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerHost.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTPriceServerHost { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerPassword.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTPriceServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerPort.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTPriceServerPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerSenderId.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTPriceServerSenderId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionTTPriceServerTargetId.
        /// </summary>
        [DataMember]
        public String GuiConnectionTTPriceServerTargetId { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionUsePluginData.
        /// </summary>
        [DataMember]
        public String GuiConnectionUsePluginData { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionUsername.
        /// </summary>
        [DataMember]
        public String GuiConnectionUsername { get; set; }
        /// <summary>
        /// Gets or sets the GuiConnectionUsernameOptional.
        /// </summary>
        [DataMember]
        public String GuiConnectionUsernameOptional { get; set; }
        /// <summary>
        /// Gets or sets the GuiContracts.
        /// </summary>
        [DataMember]
        public String GuiContracts { get; set; }
        /// <summary>
        /// Gets or sets the GuiCrosshairType.
        /// </summary>
        [DataMember]
        public String GuiCrosshairType { get; set; }
        /// <summary>
        /// Gets or sets the GuiCurrency.
        /// </summary>
        [DataMember]
        public String GuiCurrency { get; set; }
        /// <summary>
        /// Gets or sets the GuiDaily.
        /// </summary>
        [DataMember]
        public String GuiDaily { get; set; }
        /// <summary>
        /// Gets or sets the GuiDark.
        /// </summary>
        [DataMember]
        public String GuiDark { get; set; }
        /// <summary>
        /// Gets or sets the GuiDatabase.
        /// </summary>
        [DataMember]
        public String GuiDatabase { get; set; }
        /// <summary>
        /// Gets or sets the GuiDatabaseOptionsConnectionString.
        /// </summary>
        [DataMember]
        public String GuiDatabaseOptionsConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the GuiDatabaseOptionsDbType.
        /// </summary>
        [DataMember]
        public String GuiDatabaseOptionsDbType { get; set; }
        /// <summary>
        /// Gets or sets the GuiDate.
        /// </summary>
        [DataMember]
        public String GuiDate { get; set; }
        /// <summary>
        /// Gets or sets the GuiDay.
        /// </summary>
        [DataMember]
        public String GuiDay { get; set; }
        /// <summary>
        /// Gets or sets the GuiDenomination.
        /// </summary>
        [DataMember]
        public String GuiDenomination { get; set; }
        /// <summary>
        /// Gets or sets the GuiDisableUI.
        /// </summary>
        [DataMember]
        public String GuiDisableUI { get; set; }
        /// <summary>
        /// Gets or sets the GuiDisconnectDelaySeconds.
        /// </summary>
        [DataMember]
        public String GuiDisconnectDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiDomanName.
        /// </summary>
        [DataMember]
        public String GuiDomanName { get; set; }
        /// <summary>
        /// Gets or sets the GuiDownloadCotData.
        /// </summary>
        [DataMember]
        public String GuiDownloadCotData { get; set; }
        /// <summary>
        /// Gets or sets the GuiDS.
        /// </summary>
        [DataMember]
        public String GuiDS { get; set; }
        /// <summary>
        /// Gets or sets the GuiEnabled.
        /// </summary>
        [DataMember]
        public String GuiEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiExchangesPrompt.
        /// </summary>
        [DataMember]
        public String GuiExchangesPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiGarbageCollection.
        /// </summary>
        [DataMember]
        public String GuiGarbageCollection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneral.
        /// </summary>
        [DataMember]
        public String GuiGeneral { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralDisplayNextStepButton.
        /// </summary>
        [DataMember]
        public String GuiGeneralDisplayNextStepButton { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsConfirmWindowClose.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsConfirmWindowClose { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsDownBrushPrimary.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsDownBrushPrimary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsDownBrushSecondary.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsDownBrushSecondary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsFlipBuySell.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsFlipBuySell { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsGlobalLayoutDocking.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsGlobalLayoutDocking { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsGlobalLinkButton.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsGlobalLinkButton { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsIsDrawingObjectsGlobalAcrossWorkspaces.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsIsDrawingObjectsGlobalAcrossWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMail.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMail { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailAlertMsgs.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMailAlertMsgs { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailPassword.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMailPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailPort.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMailPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailServer.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMailServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailTest.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMailTest { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailUser.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMailUser { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsMailUseSsl.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsMailUseSsl { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsPerformanceMetrics.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsPerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsPerformanceMetricsPrompt.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsPerformanceMetricsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsReopenWorkspaces.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsReopenWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSaveUsername.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSaveUsername { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShareServicesPrompt.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsShareServicesPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSharingConnections.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSharingConnections { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShowAccountNumbersAndBalances.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsShowAccountNumbersAndBalances { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShowDefaultWorkspaces.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsShowDefaultWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsShowToolTips.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsShowToolTips { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAnnouncement.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundAnnouncement { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAutoBreakEven.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundAutoBreakEven { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAutoChase.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundAutoChase { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundAutoTrail.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundAutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundCompiledSuccessfully.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundCompiledSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundConnected.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundConnected { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundConnectionLost.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderCanceled.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundOrderCanceled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderFilled.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundOrderFilled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderPending.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundOrderPending { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundOrderSubmitted.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundOrderSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundPlayConsecutively.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundPlayConsecutively { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundReversing.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundReversing { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSounds.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSounds { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundStopFilled.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundStopFilled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSoundTargetFilled.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSoundTargetFilled { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsSymbology.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsSymbology { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsTimeZone.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsTimeZone { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsUpBrushPrimary.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsUpBrushPrimary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsUpBrushSecondary.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsUpBrushSecondary { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsUseOrderEntryHotKeys.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsUseOrderEntryHotKeys { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralOptionsVersionsRecoveryWorkspaces.
        /// </summary>
        [DataMember]
        public String GuiGeneralOptionsVersionsRecoveryWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredCfdConnection.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredCfdConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredConnectionsHistorical.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredConnectionsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredConnectionsRealtime.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredConnectionsRealtime { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredCryptocurrencyConnection.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredCryptocurrencyConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredForexConnection.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredForexConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredFutureConnection.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredFutureConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredIndexConnection.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredIndexConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredOptionConnection.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredOptionConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralPreferredStockConnection.
        /// </summary>
        [DataMember]
        public String GuiGeneralPreferredStockConnection { get; set; }
        /// <summary>
        /// Gets or sets the GuiGeneralSendTestEmail.
        /// </summary>
        [DataMember]
        public String GuiGeneralSendTestEmail { get; set; }
        /// <summary>
        /// Gets or sets the GuiHDS.
        /// </summary>
        [DataMember]
        public String GuiHDS { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistorical.
        /// </summary>
        [DataMember]
        public String GuiHistorical { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAdjustForDividends.
        /// </summary>
        [DataMember]
        public String GuiHistoricalAdjustForDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAdjustForSplitsOnDaily.
        /// </summary>
        [DataMember]
        public String GuiHistoricalAdjustForSplitsOnDaily { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAdjustForSplitsOnIntraday.
        /// </summary>
        [DataMember]
        public String GuiHistoricalAdjustForSplitsOnIntraday { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalAutomaticallyChooseTimeBased.
        /// </summary>
        [DataMember]
        public String GuiHistoricalAutomaticallyChooseTimeBased { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalGetDataFromServer.
        /// </summary>
        [DataMember]
        public String GuiHistoricalGetDataFromServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalGlobalMergePolicy.
        /// </summary>
        [DataMember]
        public String GuiHistoricalGlobalMergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the GuiHistoricalShowTickReplay.
        /// </summary>
        [DataMember]
        public String GuiHistoricalShowTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsFeatures.
        /// </summary>
        [DataMember]
        public String GuiIEXOptionsFeatures { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsFundamentalData.
        /// </summary>
        [DataMember]
        public String GuiIEXOptionsFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsNews.
        /// </summary>
        [DataMember]
        public String GuiIEXOptionsNews { get; set; }
        /// <summary>
        /// Gets or sets the GuiIEXOptionsRealtimeData.
        /// </summary>
        [DataMember]
        public String GuiIEXOptionsRealtimeData { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvAccountsUsers.
        /// </summary>
        [DataMember]
        public String GuiIsvAccountsUsers { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvActiveOrdersPerAccount.
        /// </summary>
        [DataMember]
        public String GuiIsvActiveOrdersPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvExecutionsPerAccount.
        /// </summary>
        [DataMember]
        public String GuiIsvExecutionsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvOrderRate.
        /// </summary>
        [DataMember]
        public String GuiIsvOrderRate { get; set; }
        /// <summary>
        /// Gets or sets the GuiIsvSodsPerAccount.
        /// </summary>
        [DataMember]
        public String GuiIsvSodsPerAccount { get; set; }
        /// <summary>
        /// Gets or sets the GuiLanguage.
        /// </summary>
        [DataMember]
        public String GuiLanguage { get; set; }
        /// <summary>
        /// Gets or sets the GuiLight.
        /// </summary>
        [DataMember]
        public String GuiLight { get; set; }
        /// <summary>
        /// Gets or sets the GuiLmt.
        /// </summary>
        [DataMember]
        public String GuiLmt { get; set; }
        /// <summary>
        /// Gets or sets the GuiMail.
        /// </summary>
        [DataMember]
        public String GuiMail { get; set; }
        /// <summary>
        /// Gets or sets the GuiMarketData.
        /// </summary>
        [DataMember]
        public String GuiMarketData { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentContractMonths.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentContractMonths { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentContractMonthsLong.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentContractMonthsLong { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentDescription.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentDescription { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentDividends.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentExchanges.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentExchanges { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentInstrumentType.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentInstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentIsServerSupported.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentIsServerSupported { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentMasterInstrument.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentMergePolicy.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentMergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentPointValue.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentPointValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentRolloverPrompt.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentRolloverPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSimFeedPrice.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentSimFeedPrice { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSplits.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentSplits { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSplitsDividends.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentSplitsDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentSymbolMap.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentSymbolMap { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterInstrumentTickSize.
        /// </summary>
        [DataMember]
        public String GuiMasterInstrumentTickSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiMasterUpdateInstrumentSplitsDividends.
        /// </summary>
        [DataMember]
        public String GuiMasterUpdateInstrumentSplitsDividends { get; set; }
        /// <summary>
        /// Gets or sets the GuiMaxOrderSize.
        /// </summary>
        [DataMember]
        public String GuiMaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiMaxPositionSize.
        /// </summary>
        [DataMember]
        public String GuiMaxPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiMinimumCashValue.
        /// </summary>
        [DataMember]
        public String GuiMinimumCashValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiMisc.
        /// </summary>
        [DataMember]
        public String GuiMisc { get; set; }
        /// <summary>
        /// Gets or sets the GuiMit.
        /// </summary>
        [DataMember]
        public String GuiMit { get; set; }
        /// <summary>
        /// Gets or sets the GuiModifyInnerBracket.
        /// </summary>
        [DataMember]
        public String GuiModifyInnerBracket { get; set; }
        /// <summary>
        /// Gets or sets the GuiModifyNearestBracket.
        /// </summary>
        [DataMember]
        public String GuiModifyNearestBracket { get; set; }
        /// <summary>
        /// Gets or sets the GuiMonth.
        /// </summary>
        [DataMember]
        public String GuiMonth { get; set; }
        /// <summary>
        /// Gets or sets the GuiMonthly.
        /// </summary>
        [DataMember]
        public String GuiMonthly { get; set; }
        /// <summary>
        /// Gets or sets the GuiMultiProvider.
        /// </summary>
        [DataMember]
        public String GuiMultiProvider { get; set; }
        /// <summary>
        /// Gets or sets the GuiName.
        /// </summary>
        [DataMember]
        public String GuiName { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScript.
        /// </summary>
        [DataMember]
        public String GuiNinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBarsPeriodCannotCreate.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptBarsPeriodCannotCreate { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBarsPeriodNull.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptBarsPeriodNull { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBarsPeriodTypeExists.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptBarsPeriodTypeExists { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseAlreadyCalled.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptBaseVendorLicenseAlreadyCalled { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseProductLettersDigits.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptBaseVendorLicenseProductLettersDigits { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseVendorNameLettersDigits.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptBaseVendorLicenseVendorNameLettersDigits { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptBaseVendorLicenseVendorNameOneCharacter.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptBaseVendorLicenseVendorNameOneCharacter { get; set; }
        /// <summary>
        /// Gets or sets the GuiNinjaScriptShareServiceOnShareException.
        /// </summary>
        [DataMember]
        public String GuiNinjaScriptShareServiceOnShareException { get; set; }
        /// <summary>
        /// Gets or sets the GuiNoSSL.
        /// </summary>
        [DataMember]
        public String GuiNoSSL { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumberRestartAttempts.
        /// </summary>
        [DataMember]
        public String GuiNumberRestartAttempts { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumberWorkedThreads.
        /// </summary>
        [DataMember]
        public String GuiNumberWorkedThreads { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumericValue.
        /// </summary>
        [DataMember]
        public String GuiNumericValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiNumGWConnections.
        /// </summary>
        [DataMember]
        public String GuiNumGWConnections { get; set; }
        /// <summary>
        /// Gets or sets the GuiOnConnectionLoss.
        /// </summary>
        [DataMember]
        public String GuiOnConnectionLoss { get; set; }
        /// <summary>
        /// Gets or sets the GuiOrderEntryHotkeysEnabled.
        /// </summary>
        [DataMember]
        public String GuiOrderEntryHotkeysEnabled { get; set; }
        /// <summary>
        /// Gets or sets the GuiOrderTypeNotSupported.
        /// </summary>
        [DataMember]
        public String GuiOrderTypeNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedCommissions.
        /// </summary>
        [DataMember]
        public String GuiOverwriteModifiedCommissions { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedMasterInstruments.
        /// </summary>
        [DataMember]
        public String GuiOverwriteModifiedMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedRisks.
        /// </summary>
        [DataMember]
        public String GuiOverwriteModifiedRisks { get; set; }
        /// <summary>
        /// Gets or sets the GuiOverwriteModifiedTradingHours.
        /// </summary>
        [DataMember]
        public String GuiOverwriteModifiedTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the GuiPort.
        /// </summary>
        [DataMember]
        public String GuiPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiPositionClose.
        /// </summary>
        [DataMember]
        public String GuiPositionClose { get; set; }
        /// <summary>
        /// Gets or sets the GuiPreconfiguredSettings.
        /// </summary>
        [DataMember]
        public String GuiPreconfiguredSettings { get; set; }
        /// <summary>
        /// Gets or sets the GuiPreferences.
        /// </summary>
        [DataMember]
        public String GuiPreferences { get; set; }
        /// <summary>
        /// Gets or sets the GuiPrimaryLicenseServer.
        /// </summary>
        [DataMember]
        public String GuiPrimaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiPrimaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public String GuiPrimaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiPrimaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public String GuiPrimaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the GuiProduct.
        /// </summary>
        [DataMember]
        public String GuiProduct { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryLines.
        /// </summary>
        [DataMember]
        public String GuiPropertyCategoryLines { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryMiscellaneous.
        /// </summary>
        [DataMember]
        public String GuiPropertyCategoryMiscellaneous { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryPlots.
        /// </summary>
        [DataMember]
        public String GuiPropertyCategoryPlots { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyCategoryVisual.
        /// </summary>
        [DataMember]
        public String GuiPropertyCategoryVisual { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameAutoScale.
        /// </summary>
        [DataMember]
        public String GuiPropertyNameAutoScale { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameDisplacement.
        /// </summary>
        [DataMember]
        public String GuiPropertyNameDisplacement { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameDisplayInDataBox.
        /// </summary>
        [DataMember]
        public String GuiPropertyNameDisplayInDataBox { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNamePanel.
        /// </summary>
        [DataMember]
        public String GuiPropertyNamePanel { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNamePriceMarkers.
        /// </summary>
        [DataMember]
        public String GuiPropertyNamePriceMarkers { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyNameScaleJustification.
        /// </summary>
        [DataMember]
        public String GuiPropertyNameScaleJustification { get; set; }
        /// <summary>
        /// Gets or sets the GuiPropertyValuePlot.
        /// </summary>
        [DataMember]
        public String GuiPropertyValuePlot { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealizedPnlIncludesCommissions.
        /// </summary>
        [DataMember]
        public String GuiRealizedPnlIncludesCommissions { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtime.
        /// </summary>
        [DataMember]
        public String GuiRealtime { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtimeFilterBadTicks.
        /// </summary>
        [DataMember]
        public String GuiRealtimeFilterBadTicks { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtimeFilterBadTicksPercent.
        /// </summary>
        [DataMember]
        public String GuiRealtimeFilterBadTicksPercent { get; set; }
        /// <summary>
        /// Gets or sets the GuiRealtimeRecordForPlayback.
        /// </summary>
        [DataMember]
        public String GuiRealtimeRecordForPlayback { get; set; }
        /// <summary>
        /// Gets or sets the GuiRecordLiveDataAsHistorical.
        /// </summary>
        [DataMember]
        public String GuiRecordLiveDataAsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the GuiRecordSimFeedData.
        /// </summary>
        [DataMember]
        public String GuiRecordSimFeedData { get; set; }
        /// <summary>
        /// Gets or sets the GuiRestartsWithinMinutes.
        /// </summary>
        [DataMember]
        public String GuiRestartsWithinMinutes { get; set; }
        /// <summary>
        /// Gets or sets the GuiRisk.
        /// </summary>
        [DataMember]
        public String GuiRisk { get; set; }
        /// <summary>
        /// Gets or sets the GuiRiskManagement.
        /// </summary>
        [DataMember]
        public String GuiRiskManagement { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsExcessPositionMarginLimit.
        /// </summary>
        [DataMember]
        public String GuiRmsOptionsExcessPositionMarginLimit { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxAccountLossPercentage.
        /// </summary>
        [DataMember]
        public String GuiRmsOptionsMaxAccountLossPercentage { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxBidAskSpread.
        /// </summary>
        [DataMember]
        public String GuiRmsOptionsMaxBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxLiquidationValue.
        /// </summary>
        [DataMember]
        public String GuiRmsOptionsMaxLiquidationValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsMaxOrderSize.
        /// </summary>
        [DataMember]
        public String GuiRmsOptionsMaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiRmsOptionsOnBehalfOf.
        /// </summary>
        [DataMember]
        public String GuiRmsOptionsOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the GuiRunWebServer.
        /// </summary>
        [DataMember]
        public String GuiRunWebServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecond.
        /// </summary>
        [DataMember]
        public String GuiSecond { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecondaryLicenseServer.
        /// </summary>
        [DataMember]
        public String GuiSecondaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecondaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public String GuiSecondaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the GuiSecondaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public String GuiSecondaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the GuiSeconds.
        /// </summary>
        [DataMember]
        public String GuiSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiSell.
        /// </summary>
        [DataMember]
        public String GuiSell { get; set; }
        /// <summary>
        /// Gets or sets the GuiServer.
        /// </summary>
        [DataMember]
        public String GuiServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerDataPort.
        /// </summary>
        [DataMember]
        public String GuiServerDataPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerDataWebPort.
        /// </summary>
        [DataMember]
        public String GuiServerDataWebPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerDomainName.
        /// </summary>
        [DataMember]
        public String GuiServerDomainName { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerFanOutMilliSeconds.
        /// </summary>
        [DataMember]
        public String GuiServerFanOutMilliSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerId.
        /// </summary>
        [DataMember]
        public String GuiServerId { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerName.
        /// </summary>
        [DataMember]
        public String GuiServerName { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerNetworkInterface.
        /// </summary>
        [DataMember]
        public String GuiServerNetworkInterface { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerRecorderCantRMSOnlyInstrumentError.
        /// </summary>
        [DataMember]
        public String GuiServerRecorderCantRMSOnlyInstrumentError { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerSystem.
        /// </summary>
        [DataMember]
        public String GuiServerSystem { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerTradingPort.
        /// </summary>
        [DataMember]
        public String GuiServerTradingPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerTradingWebPort.
        /// </summary>
        [DataMember]
        public String GuiServerTradingWebPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiServerUseNagleForFanningOutData.
        /// </summary>
        [DataMember]
        public String GuiServerUseNagleForFanningOutData { get; set; }
        /// <summary>
        /// Gets or sets the GuiShares.
        /// </summary>
        [DataMember]
        public String GuiShares { get; set; }
        /// <summary>
        /// Gets or sets the GuiShareServiceProperties.
        /// </summary>
        [DataMember]
        public String GuiShareServiceProperties { get; set; }
        /// <summary>
        /// Gets or sets the GuiSignInWithApple.
        /// </summary>
        [DataMember]
        public String GuiSignInWithApple { get; set; }
        /// <summary>
        /// Gets or sets the GuiSignInWithGoogle.
        /// </summary>
        [DataMember]
        public String GuiSignInWithGoogle { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatedOrderAsYellow.
        /// </summary>
        [DataMember]
        public String GuiSimulatedOrderAsYellow { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulationAccountsPrompt.
        /// </summary>
        [DataMember]
        public String GuiSimulationAccountsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulationColor.
        /// </summary>
        [DataMember]
        public String GuiSimulationColor { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulator.
        /// </summary>
        [DataMember]
        public String GuiSimulator { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorDelayExchange.
        /// </summary>
        [DataMember]
        public String GuiSimulatorDelayExchange { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorDelayInternet.
        /// </summary>
        [DataMember]
        public String GuiSimulatorDelayInternet { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorEnforceImmediateFills.
        /// </summary>
        [DataMember]
        public String GuiSimulatorEnforceImmediateFills { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorEnforcePartialFills.
        /// </summary>
        [DataMember]
        public String GuiSimulatorEnforcePartialFills { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorFxLotSize.
        /// </summary>
        [DataMember]
        public String GuiSimulatorFxLotSize { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorInitialCash.
        /// </summary>
        [DataMember]
        public String GuiSimulatorInitialCash { get; set; }
        /// <summary>
        /// Gets or sets the GuiSimulatorLocalOcoCancelBehavior.
        /// </summary>
        [DataMember]
        public String GuiSimulatorLocalOcoCancelBehavior { get; set; }
        /// <summary>
        /// Gets or sets the GuiSkin.
        /// </summary>
        [DataMember]
        public String GuiSkin { get; set; }
        /// <summary>
        /// Gets or sets the GuiSkinSelection.
        /// </summary>
        [DataMember]
        public String GuiSkinSelection { get; set; }
        /// <summary>
        /// Gets or sets the GuiSlm.
        /// </summary>
        [DataMember]
        public String GuiSlm { get; set; }
        /// <summary>
        /// Gets or sets the GuiSound.
        /// </summary>
        [DataMember]
        public String GuiSound { get; set; }
        /// <summary>
        /// Gets or sets the GuiStartInGlobalSimulationMode.
        /// </summary>
        [DataMember]
        public String GuiStartInGlobalSimulationMode { get; set; }
        /// <summary>
        /// Gets or sets the GuiStp.
        /// </summary>
        [DataMember]
        public String GuiStp { get; set; }
        /// <summary>
        /// Gets or sets the GuiStrategies.
        /// </summary>
        [DataMember]
        public String GuiStrategies { get; set; }
        /// <summary>
        /// Gets or sets the GuiSubmittingOrderToActiveAtm.
        /// </summary>
        [DataMember]
        public String GuiSubmittingOrderToActiveAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiSubmittingOrderWithAtm.
        /// </summary>
        [DataMember]
        public String GuiSubmittingOrderWithAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiSubmittingOrderWithoutAtm.
        /// </summary>
        [DataMember]
        public String GuiSubmittingOrderWithoutAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiTest.
        /// </summary>
        [DataMember]
        public String GuiTest { get; set; }
        /// <summary>
        /// Gets or sets the GuiTicksPerSecond.
        /// </summary>
        [DataMember]
        public String GuiTicksPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the GuiTimerMilliseconds.
        /// </summary>
        [DataMember]
        public String GuiTimerMilliseconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiTrace.
        /// </summary>
        [DataMember]
        public String GuiTrace { get; set; }
        /// <summary>
        /// Gets or sets the GuiTrading.
        /// </summary>
        [DataMember]
        public String GuiTrading { get; set; }
        /// <summary>
        /// Gets or sets the GuiTradingOptionsPositionCloseWaitMilliSeconds.
        /// </summary>
        [DataMember]
        public String GuiTradingOptionsPositionCloseWaitMilliSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuiType.
        /// </summary>
        [DataMember]
        public String GuiType { get; set; }
        /// <summary>
        /// Gets or sets the GuiUnits.
        /// </summary>
        [DataMember]
        public String GuiUnits { get; set; }
        /// <summary>
        /// Gets or sets the GuiUrl.
        /// </summary>
        [DataMember]
        public String GuiUrl { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public String GuiUseFifo4AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseLastPrice4AutoTrail.
        /// </summary>
        [DataMember]
        public String GuiUseLastPrice4AutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseLastPriceForProfitLossCalc.
        /// </summary>
        [DataMember]
        public String GuiUseLastPriceForProfitLossCalc { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseLegacyCompiler.
        /// </summary>
        [DataMember]
        public String GuiUseLegacyCompiler { get; set; }
        /// <summary>
        /// Gets or sets the GuiUseServerAtm.
        /// </summary>
        [DataMember]
        public String GuiUseServerAtm { get; set; }
        /// <summary>
        /// Gets or sets the GuiValue.
        /// </summary>
        [DataMember]
        public String GuiValue { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseUnableVerifyVendorLicense.
        /// </summary>
        [DataMember]
        public String GuiVendorLicenseUnableVerifyVendorLicense { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseVerifyingFreeTrialPrimaryServer.
        /// </summary>
        [DataMember]
        public String GuiVendorLicenseVerifyingFreeTrialPrimaryServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseVerifyingFreeTrialSecondaryServer.
        /// </summary>
        [DataMember]
        public String GuiVendorLicenseVerifyingFreeTrialSecondaryServer { get; set; }
        /// <summary>
        /// Gets or sets the GuiVendorLicenseVerifyingLocalHarddrive.
        /// </summary>
        [DataMember]
        public String GuiVendorLicenseVerifyingLocalHarddrive { get; set; }
        /// <summary>
        /// Gets or sets the GuiWebSocketPort.
        /// </summary>
        [DataMember]
        public String GuiWebSocketPort { get; set; }
        /// <summary>
        /// Gets or sets the GuiWeekly.
        /// </summary>
        [DataMember]
        public String GuiWeekly { get; set; }
        /// <summary>
        /// Gets or sets the GuiWeeks.
        /// </summary>
        [DataMember]
        public String GuiWeeks { get; set; }
        /// <summary>
        /// Gets or sets the GuiYearly.
        /// </summary>
        [DataMember]
        public String GuiYearly { get; set; }
        /// <summary>
        /// Gets or sets the GuiYears.
        /// </summary>
        [DataMember]
        public String GuiYears { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseEndDate.
        /// </summary>
        [DataMember]
        public String IndicatorSuperDomBaseEndDate { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseIsStableSession.
        /// </summary>
        [DataMember]
        public String IndicatorSuperDomBaseIsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseIsTickReplay.
        /// </summary>
        [DataMember]
        public String IndicatorSuperDomBaseIsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseRangeType.
        /// </summary>
        [DataMember]
        public String IndicatorSuperDomBaseRangeType { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseStartDate.
        /// </summary>
        [DataMember]
        public String IndicatorSuperDomBaseStartDate { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorSuperDomBaseTradingHoursTemplate.
        /// </summary>
        [DataMember]
        public String IndicatorSuperDomBaseTradingHoursTemplate { get; set; }
        /// <summary>
        /// Gets or sets the LogDisableAttachOrderToIndicator.
        /// </summary>
        [DataMember]
        public String LogDisableAttachOrderToIndicator { get; set; }
        /// <summary>
        /// Gets or sets the LogEnableAttachOrderToIndicator.
        /// </summary>
        [DataMember]
        public String LogEnableAttachOrderToIndicator { get; set; }
        /// <summary>
        /// Gets or sets the MailSentSuccessfully.
        /// </summary>
        [DataMember]
        public String MailSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the MailSentUnsuccessfully.
        /// </summary>
        [DataMember]
        public String MailSentUnsuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAdapter.
        /// </summary>
        [DataMember]
        public String NinjaScriptAdapter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAddOn.
        /// </summary>
        [DataMember]
        public String NinjaScriptAddOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjascriptAddOnBaseLegacyAtmUseNotAllowed.
        /// </summary>
        [DataMember]
        public String NinjascriptAddOnBaseLegacyAtmUseNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertAction.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertAction { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertActions.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertActions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionDynamicOffset.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertConditionDynamicOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionItemFormat.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertConditionItemFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionOffset.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertConditionOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditions.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertConditions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertConditionsOperator.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertConditionsOperator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertDefaultMessage.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertDefaultMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertMessage.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertOffset.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertOffsetType.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertOffsetType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertPriority.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertPriority { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertRearmSeconds.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertRearmSeconds { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertRearmType.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertRearmType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertScreenshotType.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertScreenshotType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsDynamicMessageDetailsString.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertsDynamicMessageDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertShareService.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertShareService { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsNoMessage.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertsNoMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsNoSoundFile.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertsNoSoundFile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsPlaySoundDetailsString.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertsPlaySoundDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsShareDetailsString.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertsShareDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsShowMessageDetailsString.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertsShowMessageDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertsSubmitOrderDetailsString.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertsSubmitOrderDetailsString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAlertUsingAtmStrategy.
        /// </summary>
        [DataMember]
        public String NinjaScriptAlertUsingAtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategy.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyActiveCustom.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyActiveCustom { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCancellingOrders.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyCancellingOrders { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCanChangeExitOrder1.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyCanChangeExitOrder1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCanChangeExitOrder2.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyCanChangeExitOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyCantChangeOrder.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyCantChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyClosingPositionStrategy.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyClosingPositionStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyEntryOrderNotFilledYet.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyEntryOrderNotFilledYet { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyLoadTemplateError.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyLoadTemplateError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyNone.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyNone { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyShadowError.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyShadowError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptAtmStrategyTifConverted.
        /// </summary>
        [DataMember]
        public String NinjaScriptAtmStrategyTifConverted { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsRequestError.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsRequestError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsType.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeMinute.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigure.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBuyColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptBuyColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptCellConditionBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptCellConditionForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionGeneral.
        /// </summary>
        [DataMember]
        public String NinjaScriptCellConditionGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionText.
        /// </summary>
        [DataMember]
        public String NinjaScriptCellConditionText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCellConditionToString.
        /// </summary>
        [DataMember]
        public String NinjaScriptCellConditionToString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBase.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAccount.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseAccount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAlert.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseAlert { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAlertDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseAlertDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseAltBarColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseAltBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarGraphGrowthMaxValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseBarGraphGrowthMaxValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarGraphGrowthType.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseBarGraphGrowthType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarGraphReferenceValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseBarGraphReferenceValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseBarsToLoad.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseBarsToLoad { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseCell.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseCell { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseCellDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseCellDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorDistribution.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseColorDistribution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMaxBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseColorMaxBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMaxForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseColorMaxForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMinBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseColorMinBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseColorMinForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseColorMinForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseConditionPrompt.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseConditionPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseConditions.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseConditions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseDaysBack.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseDaysBack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseEnableColorDistribution.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseEnableColorDistribution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseEndDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseEndDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseFilter.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseFilter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseFilterDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseFilterDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseGeneral.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseIndicator.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseIndicator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseIsStableSession.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseIsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseIsTickReplay.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseIsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseLoadDataBasedOn.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseLoadDataBasedOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseLoadingText.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseLoadingText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseMaxValueRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseMaxValueRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseMinValueRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseMinValueRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBasePlot.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBasePlot { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseShowInTotalRow.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseShowInTotalRow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseStartDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseStartDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseTradingHoursTemplate.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseTradingHoursTemplate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptColumnBaseVisible.
        /// </summary>
        [DataMember]
        public String NinjaScriptColumnBaseVisible { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptCommissionTemplate.
        /// </summary>
        [DataMember]
        public String NinjaScriptCommissionTemplate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionApplyTo.
        /// </summary>
        [DataMember]
        public String NinjaScriptConditionApplyTo { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionCondition.
        /// </summary>
        [DataMember]
        public String NinjaScriptConditionCondition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionTrigger.
        /// </summary>
        [DataMember]
        public String NinjaScriptConditionTrigger { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptConditionValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptConditionValueValidationError.
        /// </summary>
        [DataMember]
        public String NinjaScriptConditionValueValidationError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDataSeries.
        /// </summary>
        [DataMember]
        public String NinjaScriptDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDataSessionIteratorWrongConstructor.
        /// </summary>
        [DataMember]
        public String NinjaScriptDataSessionIteratorWrongConstructor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDaysToLoad.
        /// </summary>
        [DataMember]
        public String NinjaScriptDaysToLoad { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDeafultFillTypeName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDeafultFillTypeName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDisplayText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDisplayText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDisplayType.
        /// </summary>
        [DataMember]
        public String NinjaScriptDisplayType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDisplayUnit.
        /// </summary>
        [DataMember]
        public String NinjaScriptDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolShapesSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolShapesSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDuplicatePlotOrLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptDuplicatePlotOrLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFillType.
        /// </summary>
        [DataMember]
        public String NinjaScriptFillType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFilterConditionGeneral.
        /// </summary>
        [DataMember]
        public String NinjaScriptFilterConditionGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFilterConditionMatchesAll.
        /// </summary>
        [DataMember]
        public String NinjaScriptFilterConditionMatchesAll { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptFilterConditionToString.
        /// </summary>
        [DataMember]
        public String NinjaScriptFilterConditionToString { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneratedStrategyLogicBaseClassNameNotFound.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneratedStrategyLogicBaseClassNameNotFound { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneratedStrategyLogicBaseTypeNotFound.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneratedStrategyLogicBaseTypeNotFound { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneratedStrategyLogicBaseWrongType.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneratedStrategyLogicBaseWrongType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerProperties.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGetDayBarPriorTradingDay.
        /// </summary>
        [DataMember]
        public String NinjaScriptGetDayBarPriorTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptImportType.
        /// </summary>
        [DataMember]
        public String NinjaScriptImportType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptImportTypeMetaStock.
        /// </summary>
        [DataMember]
        public String NinjaScriptImportTypeMetaStock { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIncludeCommission.
        /// </summary>
        [DataMember]
        public String NinjaScriptIncludeCommission { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseDisplayNameOf.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBaseDisplayNameOf { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColumnDisplayName.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColumnDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColumnGetPlotError.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColumnGetPlotError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInput.
        /// </summary>
        [DataMember]
        public String NinjaScriptInput { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInputPrompt.
        /// </summary>
        [DataMember]
        public String NinjaScriptInputPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInstrument.
        /// </summary>
        [DataMember]
        public String NinjaScriptInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInvalidBaseBarsPeriodType.
        /// </summary>
        [DataMember]
        public String NinjaScriptInvalidBaseBarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInvalidStateForMethod.
        /// </summary>
        [DataMember]
        public String NinjaScriptInvalidStateForMethod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptInvalidStateForProperty.
        /// </summary>
        [DataMember]
        public String NinjaScriptInvalidStateForProperty { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLabel.
        /// </summary>
        [DataMember]
        public String NinjaScriptLabel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLimitPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartMiniColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartMiniOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartMiniOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartMiniSpan.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartMiniSpan { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeDownArea.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartNetChangeDownArea { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeDownOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartNetChangeDownOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeUpArea.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartNetChangeUpArea { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnChartNetChangeUpOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnChartNetChangeUpOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendAboveAsk.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnTSTrendAboveAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendAtAsk.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnTSTrendAtAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendAtBid.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnTSTrendAtBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendBarWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnTSTrendBarWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendBelowBid.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnTSTrendBelowBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnTSTrendBetween.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnTSTrendBetween { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptName.
        /// </summary>
        [DataMember]
        public String NinjaScriptName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNegativeBackgroundColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptNegativeBackgroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNegativeForegroundColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptNegativeForegroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAccountNotConnected.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAccountNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidBarsPeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddDataSeriesInvalidBarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidInstrumentName.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddDataSeriesInvalidInstrumentName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidMarketDataType.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddDataSeriesInvalidMarketDataType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesInvalidTradingHoursName.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddDataSeriesInvalidTradingHoursName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddDataSeriesNegativePeriodValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddDataSeriesNegativePeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAdditionalDataError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAdditionalDataError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddKagi.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddKagi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddLineBreak.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddLineBreak { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddPointAndFigure.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddPointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAddSeries.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAddSeries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAtmStrategyIdAlreadyUsed.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAtmStrategyIdAlreadyUsed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAtmStrategyTerminated.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAtmStrategyTerminated { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseAtmStratgyIdDoesNotExist.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseAtmStratgyIdDoesNotExist { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseBeforeEvent.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseBeforeEvent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseClosePosition.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseCountIfException.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseCountIfException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseCountIfPeriodError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseCountIfPeriodError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentAsk.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseGetCurrentAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentAskVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseGetCurrentAskVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentBid.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseGetCurrentBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetCurrentBidVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseGetCurrentBidVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetExceptionMessage.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseGetExceptionMessage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetSetError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseGetSetError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseGetSetError2.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseGetSetError2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseInitializeBarsPoolError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseInitializeBarsPoolError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseInvalidOrderName.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseInvalidOrderName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLimitAndStopPriceRequired.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseLimitAndStopPriceRequired { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLimitPriceZero.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseLimitPriceZero { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLroException.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseLroException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLroInstanceError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseLroInstanceError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseLroLookBackPeriodError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseLroLookBackPeriodError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMissingAtmStrategyId.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseMissingAtmStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMissingLimitOrStopPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseMissingLimitOrStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMissingOrderId.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseMissingOrderId { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMroException.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseMroException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMroInstanceError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseMroInstanceError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseMroLockBackPeriodError.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseMroLockBackPeriodError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseNotInRealtimeState.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseNotInRealtimeState { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseOrderIdAlreadyUsed.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseOrderIdAlreadyUsed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseOrderIdDoesNotExist.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseOrderIdDoesNotExist { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBasePlotDefaultName.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBasePlotDefaultName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseSimulationMode.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseSimulationMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseSlopeArguments.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseSlopeArguments { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseStopPriceZero.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseStopPriceZero { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTemplateNameMissing.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseTemplateNameMissing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTickReplayLast.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseTickReplayLast { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTifNotSupported.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseTifNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTriggerCustomEvent.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseTriggerCustomEvent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptBaseTriggerCustomEventException.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptBaseTriggerCustomEventException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptCustomMethodError1.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptCustomMethodError1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptCustomMethodError2.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptCustomMethodError2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNinjaScriptErrorSerializing.
        /// </summary>
        [DataMember]
        public String NinjaScriptNinjaScriptErrorSerializing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNoAccount.
        /// </summary>
        [DataMember]
        public String NinjaScriptNoAccount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNoInstrument.
        /// </summary>
        [DataMember]
        public String NinjaScriptNoInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimize.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizer.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerFitness.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizerFitness { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerKeepBestResults.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizerKeepBestResults { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerMultiObjectiveOptimizeOn.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizerMultiObjectiveOptimizeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerMultiObjectivePrompt.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizerMultiObjectivePrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOrderAction.
        /// </summary>
        [DataMember]
        public String NinjaScriptOrderAction { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOrderType.
        /// </summary>
        [DataMember]
        public String NinjaScriptOrderType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterIncrement.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameterIncrement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterMax.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameterMax { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterMin.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameterMin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameters.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterSetPropertyValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameterSetPropertyValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameterSetPropertyValueInvalidType.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameterSetPropertyValueInvalidType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPerformanceBase.
        /// </summary>
        [DataMember]
        public String NinjaScriptPerformanceBase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPerformanceMetric.
        /// </summary>
        [DataMember]
        public String NinjaScriptPerformanceMetric { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlotAutoWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptPlotAutoWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlots.
        /// </summary>
        [DataMember]
        public String NinjaScriptPlots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlotStyle.
        /// </summary>
        [DataMember]
        public String NinjaScriptPlotStyle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPositiveBackgroundColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptPositiveBackgroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPositiveForegroundColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptPositiveForegroundColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPriceTypeLowercase.
        /// </summary>
        [DataMember]
        public String NinjaScriptPriceTypeLowercase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptProperties.
        /// </summary>
        [DataMember]
        public String NinjaScriptProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptQuantity.
        /// </summary>
        [DataMember]
        public String NinjaScriptQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSellColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptSellColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSensitivity.
        /// </summary>
        [DataMember]
        public String NinjaScriptSensitivity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSeries256Error.
        /// </summary>
        [DataMember]
        public String NinjaScriptSeries256Error { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSeriesBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptSeriesBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSetup.
        /// </summary>
        [DataMember]
        public String NinjaScriptSetup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptShareService.
        /// </summary>
        [DataMember]
        public String NinjaScriptShareService { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptShareServiceCannotFindName.
        /// </summary>
        [DataMember]
        public String NinjaScriptShareServiceCannotFindName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStartegyBaseBarsSince.
        /// </summary>
        [DataMember]
        public String NinjaScriptStartegyBaseBarsSince { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStopCancelClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptStopCancelClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStopPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategy.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAccount.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyAccount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAccountSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyAccountSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAggregated.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyAggregated { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyAIGenerate.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyAIGenerate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptAccountPosition.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseAdoptAccountPosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptPosition1.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseAdoptPosition1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptPosition2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseAdoptPosition2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseAdoptPosition3.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseAdoptPosition3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCancelExpiredOrders.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseCancelExpiredOrders { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCancelOrderUnmanaged.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseCancelOrderUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseChangeOrderUnmanaged.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseChangeOrderUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseClosePosition.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseClosePosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCopyTo.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseCopyTo { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseCreateOrderError.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseCreateOrderError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseDbFromCommand1.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseDbFromCommand1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseDbFromCommand2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseDbFromCommand2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseDisabling.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseDisabling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseEnabling1.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseEnabling1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseEnabling2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseEnabling2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseExitOnSessionClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseExitOnSessionClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseExitOnSessionCloseHandling.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseExitOnSessionCloseHandling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseGetOptimizationParameters.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseGetOptimizationParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseGetTradingHours.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseGetTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData_Duplicate_1_.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseHighOrderFillResolutionInsufficientData_Duplicate_1_ { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseInstantiateOnEachOptimizationIteration.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseInstantiateOnEachOptimizationIteration { get; set; }
        /// <summary>
        /// Gets or sets the NinjascriptStrategyBaseLegacyAtmUseNotAllowed.
        /// </summary>
        [DataMember]
        public String NinjascriptStrategyBaseLegacyAtmUseNotAllowed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLoadError.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLoadError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostConnectionDisable.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostConnectionDisable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionDisable.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostOrderConnectionDisable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionKeepRunning.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostOrderConnectionKeepRunning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionRecalculate.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostOrderConnectionRecalculate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostOrderConnectionRecalculate2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostOrderConnectionRecalculate2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostPriceConnectionDisable.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostPriceConnectionDisable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostPriceConnectionKeepRunning.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostPriceConnectionKeepRunning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseLostPriceConnectionRecalculate.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseLostPriceConnectionRecalculate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseNoTickReplay.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseNoTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderError.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOrderError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderErrorCancelTimeOut.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOrderErrorCancelTimeOut { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderFillResolutionHighError1.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOrderFillResolutionHighError1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderFillResolutionHighError2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOrderFillResolutionHighError2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderFillResolutionHighError3.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOrderFillResolutionHighError3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOrderHistoricalToLive.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOrderHistoricalToLive { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOverFill.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOverFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseOverFillCancelTimeOut.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseOverFillCancelTimeOut { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBasePositions.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBasePositions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseProcessBacktestOrdersEod.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseProcessBacktestOrdersEod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseProcessBacktestOrdersOco.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseProcessBacktestOrdersOco { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseProcessBacktestOrdersOppositeSide.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseProcessBacktestOrdersOppositeSide { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBasePropertyError.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBasePropertyError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAlreadySubmitted.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetAlreadySubmitted { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedParabolicStopOrder2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetAmendedParabolicStopOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedStopOrder2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetAmendedStopOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedTargetOrder2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetAmendedTargetOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetAmendedTrailStopOrder2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetAmendedTrailStopOrder2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetHistorical.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetHistorical { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetIgnore.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetIgnore { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSetStopTargetTrace.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSetStopTargetTrace { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderBarsInProgress.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderBarsInProgress { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTrade.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTrade { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTradedNotMet.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderBarsRequiredToTradedNotMet { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderEntryOrder.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderEntryOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderExitOrder.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderExitOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderGenericStopPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderGenericStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderInvalidQuantity.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderInvalidQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderInvalidState.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderInvalidState { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManaged.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedAmended.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedAmended { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedAmendMatchingOrder.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedAmendMatchingOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedIgnore.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedIgnore { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedInvalidEnterOrder.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedInvalidEnterOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedInvalidExitOrder.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedInvalidExitOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedInvalidPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedInvalidPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedMatchingOrderExists.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedMatchingOrderExists { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedNoMatchingSignal.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedNoMatchingSignal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedNoPosition.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedNoPosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedNoRemainingQty.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedNoRemainingQty { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedQty2Small.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedQty2Small { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedQty2Small2.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedQty2Small2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedQuantity.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedSignalExcess.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedSignalExcess { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedTrace.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedTrace { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderManagedUnchanged.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderManagedUnchanged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderOnlyUnmanaged.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderOnlyUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderUnmanagedIgnore.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderUnmanagedIgnore { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSubmitOrderUnmanagedTrace.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSubmitOrderUnmanagedTrace { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSyncAfterFlat.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSyncAfterFlat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseSynchronize.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseSynchronize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseTifNotSupported.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseTifNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseUnableToCancelLiveOrders.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseUnableToCancelLiveOrders { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyBaseVirtualEntryExecution.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyBaseVirtualEntryExecution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyCalculate.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyCalculate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDefaultQuantity.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyDefaultQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyEntriesPerDirection.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyEntriesPerDirection { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyEntryHandling.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyEntryHandling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyExitOnSessionClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyExitOnSessionClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyExitOnSessionCloseSeconds.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyExitOnSessionCloseSeconds { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyFillLimitOrderOnTouch.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyFillLimitOrderOnTouch { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorDayOfWeek.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorDayOfWeek { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorEntries.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorEntries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorExits.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorExits { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorProperties.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseCandleStickPattern.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseCandleStickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseIndicators.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseIndicators { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseParabolicStop.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseParabolicStop { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseSessionClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseSessionClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseSessionTime.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseSessionTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseStopTargets.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseStopTargets { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyHistoricalFillProcessing.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyHistoricalFillProcessing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyIsStableSession.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyIsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyIsTickReplay.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyIsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyMaximumBaseLookBack.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyMaximumBaseLookBack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyMinimumBarsRequired.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyMinimumBarsRequired { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizationFitness.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOptimizationFitness { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizationPeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOptimizationPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizeDataSeries.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOptimizeDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOptimizer.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOptimizer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderFillResolution.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOrderFillResolution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderFillResolutionType.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOrderFillResolutionType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderFillResolutionValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOrderFillResolutionValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderHandling.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOrderHandling { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyOrderProperties.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyOrderProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyParameters.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategySetOrderQuantity.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategySetOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategySlippage.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategySlippage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyStartBehavior.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyStartBehavior { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyStopTargetSubmission.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyStopTargetSubmission { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategySubmittingOrder.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategySubmittingOrder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTestPeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyTestPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTimeInForce.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyTimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTradingHours.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyTradingHoursTemplate.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyTradingHoursTemplate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitOrderSignalLength.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitOrderSignalLength { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetCalculationMode.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitStopTargetCalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetCurrency.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitStopTargetCurrency { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetNow.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitStopTargetNow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetParabolicStopPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitStopTargetParabolicStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetStopPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitStopTargetStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetTargetPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitStopTargetTargetPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSubmitStopTargetTrailStopPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptSubmitStopTargetTrailStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumn.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomIndicatorBase.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomIndicatorBase { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTimeFrame.
        /// </summary>
        [DataMember]
        public String NinjaScriptTimeFrame { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTimeframeFrom.
        /// </summary>
        [DataMember]
        public String NinjaScriptTimeframeFrom { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTimeframeTo.
        /// </summary>
        [DataMember]
        public String NinjaScriptTimeframeTo { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptUnfrozenBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptUnfrozenBrush { get; set; }
        /// <summary>
        /// Gets or sets the OnlyApplicationTypeGW.
        /// </summary>
        [DataMember]
        public String OnlyApplicationTypeGW { get; set; }
        /// <summary>
        /// Gets or sets the PositionRemoveFirstExecutionCancel.
        /// </summary>
        [DataMember]
        public String PositionRemoveFirstExecutionCancel { get; set; }
        /// <summary>
        /// Gets or sets the PositionRemoveFirstExecutionChange.
        /// </summary>
        [DataMember]
        public String PositionRemoveFirstExecutionChange { get; set; }
        /// <summary>
        /// Gets or sets the PropertyCategoryDataSeries.
        /// </summary>
        [DataMember]
        public String PropertyCategoryDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the PropertyCategoryVisual.
        /// </summary>
        [DataMember]
        public String PropertyCategoryVisual { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameAutoWidth.
        /// </summary>
        [DataMember]
        public String PropertyNameAutoWidth { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameBrush.
        /// </summary>
        [DataMember]
        public String PropertyNameBrush { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameDashStyle.
        /// </summary>
        [DataMember]
        public String PropertyNameDashStyle { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameIsVisible.
        /// </summary>
        [DataMember]
        public String PropertyNameIsVisible { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameOpacityPercent.
        /// </summary>
        [DataMember]
        public String PropertyNameOpacityPercent { get; set; }
        /// <summary>
        /// Gets or sets the PropertyNameThickness.
        /// </summary>
        [DataMember]
        public String PropertyNameThickness { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeFundamentalData.
        /// </summary>
        [DataMember]
        public String SampleAdapterCannotSubscribeFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeHotlist.
        /// </summary>
        [DataMember]
        public String SampleAdapterCannotSubscribeHotlist { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeMarketData.
        /// </summary>
        [DataMember]
        public String SampleAdapterCannotSubscribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeMarketDepth.
        /// </summary>
        [DataMember]
        public String SampleAdapterCannotSubscribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterCannotSubscribeNews.
        /// </summary>
        [DataMember]
        public String SampleAdapterCannotSubscribeNews { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubcribeMarketData.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorSubcribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubcribeMarketDepth.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorSubcribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubcribeNews.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorSubcribeNews { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubscribeFundamentalData.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorSubscribeFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorSubscribeHotlist.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorSubscribeHotlist { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeFundamentalData.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorUnsubcribeFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeHotlist.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorUnsubcribeHotlist { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeMarketData.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorUnsubcribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeMarketDepth.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorUnsubcribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterErrorUnsubcribeNews.
        /// </summary>
        [DataMember]
        public String SampleAdapterErrorUnsubcribeNews { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterHotlistUnknownInstrument.
        /// </summary>
        [DataMember]
        public String SampleAdapterHotlistUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterNoContinuousContracts.
        /// </summary>
        [DataMember]
        public String SampleAdapterNoContinuousContracts { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterRequestBarsException.
        /// </summary>
        [DataMember]
        public String SampleAdapterRequestBarsException { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterRequestHotlistNamesException.
        /// </summary>
        [DataMember]
        public String SampleAdapterRequestHotlistNamesException { get; set; }
        /// <summary>
        /// Gets or sets the SampleAdapterResolveInstrumentException.
        /// </summary>
        [DataMember]
        public String SampleAdapterResolveInstrumentException { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiAtmCommand.
        /// </summary>
        [DataMember]
        public String ServerApiAtmCommand { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiCancelAccountNotEnabled.
        /// </summary>
        [DataMember]
        public String ServerApiCancelAccountNotEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiChangeAccountNotEnabled.
        /// </summary>
        [DataMember]
        public String ServerApiChangeAccountNotEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeClientInstrumentNotFound.
        /// </summary>
        [DataMember]
        public String ServerApiDeserializeClientInstrumentNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeConnectionApplySnapshotException.
        /// </summary>
        [DataMember]
        public String ServerApiDeserializeConnectionApplySnapshotException { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeHDSISDisconnect.
        /// </summary>
        [DataMember]
        public String ServerApiDeserializeHDSISDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeHDSISDsiconnect.
        /// </summary>
        [DataMember]
        public String ServerApiDeserializeHDSISDsiconnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeHDSISNoDataConnection.
        /// </summary>
        [DataMember]
        public String ServerApiDeserializeHDSISNoDataConnection { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiDeserializeWorkspaceException.
        /// </summary>
        [DataMember]
        public String ServerApiDeserializeWorkspaceException { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInstrumentNotEntitledForFundamentalData.
        /// </summary>
        [DataMember]
        public String ServerApiInstrumentNotEntitledForFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInstrumentNotEntitledForMarketData.
        /// </summary>
        [DataMember]
        public String ServerApiInstrumentNotEntitledForMarketData { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInstrumentNotEntitledForMarketDepth.
        /// </summary>
        [DataMember]
        public String ServerApiInstrumentNotEntitledForMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInvalidInstrument.
        /// </summary>
        [DataMember]
        public String ServerApiInvalidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInvalidInstrumentList.
        /// </summary>
        [DataMember]
        public String ServerApiInvalidInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiInvalidUserPassword.
        /// </summary>
        [DataMember]
        public String ServerApiInvalidUserPassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLoginExpired.
        /// </summary>
        [DataMember]
        public String ServerApiLoginExpired { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLogonFailedMaxConcurrentLogins.
        /// </summary>
        [DataMember]
        public String ServerApiLogonFailedMaxConcurrentLogins { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLogonFailedNoConnection.
        /// </summary>
        [DataMember]
        public String ServerApiLogonFailedNoConnection { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiLogonFailedTarPitted.
        /// </summary>
        [DataMember]
        public String ServerApiLogonFailedTarPitted { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiMaxConcurrentLoginsExceeded.
        /// </summary>
        [DataMember]
        public String ServerApiMaxConcurrentLoginsExceeded { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingParseError.
        /// </summary>
        [DataMember]
        public String ServerApiPacingParseError { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingSubscribeMarketData.
        /// </summary>
        [DataMember]
        public String ServerApiPacingSubscribeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingSubscribeMarketDepth.
        /// </summary>
        [DataMember]
        public String ServerApiPacingSubscribeMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingViolationGeneric.
        /// </summary>
        [DataMember]
        public String ServerApiPacingViolationGeneric { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPacingViolationOnce.
        /// </summary>
        [DataMember]
        public String ServerApiPacingViolationOnce { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiPendingUserRegistration.
        /// </summary>
        [DataMember]
        public String ServerApiPendingUserRegistration { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiScanHasStarted.
        /// </summary>
        [DataMember]
        public String ServerApiScanHasStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiSubmitAccountNotConnected.
        /// </summary>
        [DataMember]
        public String ServerApiSubmitAccountNotConnected { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiSubmitAccountNotEnabled.
        /// </summary>
        [DataMember]
        public String ServerApiSubmitAccountNotEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTarPitted.
        /// </summary>
        [DataMember]
        public String ServerApiTarPitted { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTooManyFundamentalDataSubscriptions.
        /// </summary>
        [DataMember]
        public String ServerApiTooManyFundamentalDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTooManyMarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public String ServerApiTooManyMarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiTooManyMarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public String ServerApiTooManyMarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnableToCancelOrder.
        /// </summary>
        [DataMember]
        public String ServerApiUnableToCancelOrder { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnableToChangeOrder.
        /// </summary>
        [DataMember]
        public String ServerApiUnableToChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownAtm.
        /// </summary>
        [DataMember]
        public String ServerApiUnknownAtm { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownInstrument.
        /// </summary>
        [DataMember]
        public String ServerApiUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownServerInstrument.
        /// </summary>
        [DataMember]
        public String ServerApiUnknownServerInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUnknownUserName.
        /// </summary>
        [DataMember]
        public String ServerApiUnknownUserName { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUserAlreadyExists.
        /// </summary>
        [DataMember]
        public String ServerApiUserAlreadyExists { get; set; }
        /// <summary>
        /// Gets or sets the ServerApiUserNotEnabledToTrade.
        /// </summary>
        [DataMember]
        public String ServerApiUserNotEnabledToTrade { get; set; }
        /// <summary>
        /// Gets or sets the ServerApplicationTypeServer.
        /// </summary>
        [DataMember]
        public String ServerApplicationTypeServer { get; set; }
        /// <summary>
        /// Gets or sets the ServerAtiServerUnableToStart.
        /// </summary>
        [DataMember]
        public String ServerAtiServerUnableToStart { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPDataLogoff.
        /// </summary>
        [DataMember]
        public String ServerBPDataLogoff { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPDataLogonSuccess.
        /// </summary>
        [DataMember]
        public String ServerBPDataLogonSuccess { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPLostConnectionToGW.
        /// </summary>
        [DataMember]
        public String ServerBPLostConnectionToGW { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPTradingLogoff.
        /// </summary>
        [DataMember]
        public String ServerBPTradingLogoff { get; set; }
        /// <summary>
        /// Gets or sets the ServerBPTradingLogonSuccess.
        /// </summary>
        [DataMember]
        public String ServerBPTradingLogonSuccess { get; set; }
        /// <summary>
        /// Gets or sets the ServerCastInvalidUrl.
        /// </summary>
        [DataMember]
        public String ServerCastInvalidUrl { get; set; }
        /// <summary>
        /// Gets or sets the ServerCastInvalidUserNamePassword.
        /// </summary>
        [DataMember]
        public String ServerCastInvalidUserNamePassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPassword.
        /// </summary>
        [DataMember]
        public String ServerChangeUserPassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPassword2.
        /// </summary>
        [DataMember]
        public String ServerChangeUserPassword2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordSubject.
        /// </summary>
        [DataMember]
        public String ServerChangeUserPasswordSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordSubject2.
        /// </summary>
        [DataMember]
        public String ServerChangeUserPasswordSubject2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordText.
        /// </summary>
        [DataMember]
        public String ServerChangeUserPasswordText { get; set; }
        /// <summary>
        /// Gets or sets the ServerChangeUserPasswordText2.
        /// </summary>
        [DataMember]
        public String ServerChangeUserPasswordText2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerClientErrorResettingInstrumentMappings.
        /// </summary>
        [DataMember]
        public String ServerClientErrorResettingInstrumentMappings { get; set; }
        /// <summary>
        /// Gets or sets the ServerClientLoadingData.
        /// </summary>
        [DataMember]
        public String ServerClientLoadingData { get; set; }
        /// <summary>
        /// Gets or sets the ServerClientUnableToConnect.
        /// </summary>
        [DataMember]
        public String ServerClientUnableToConnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastAccountTemplateNotFound.
        /// </summary>
        [DataMember]
        public String ServerCqgCastAccountTemplateNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastException.
        /// </summary>
        [DataMember]
        public String ServerCqgCastException { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastUpdateAccountError.
        /// </summary>
        [DataMember]
        public String ServerCqgCastUpdateAccountError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCastUpdateUserError.
        /// </summary>
        [DataMember]
        public String ServerCqgCastUpdateUserError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsAccountNotFound.
        /// </summary>
        [DataMember]
        public String ServerCqgCmsAccountNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsAccountTemplateNotFound.
        /// </summary>
        [DataMember]
        public String ServerCqgCmsAccountTemplateNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsInvalidUrl.
        /// </summary>
        [DataMember]
        public String ServerCqgCmsInvalidUrl { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsInvalidUserNamePassword.
        /// </summary>
        [DataMember]
        public String ServerCqgCmsInvalidUserNamePassword { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsUpdateAccountError.
        /// </summary>
        [DataMember]
        public String ServerCqgCmsUpdateAccountError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCqgCmsUpdateUserError.
        /// </summary>
        [DataMember]
        public String ServerCqgCmsUpdateUserError { get; set; }
        /// <summary>
        /// Gets or sets the ServerCtorCertificate.
        /// </summary>
        [DataMember]
        public String ServerCtorCertificate { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataClientConnect.
        /// </summary>
        [DataMember]
        public String ServerDataClientConnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataClientCouldNotConnect.
        /// </summary>
        [DataMember]
        public String ServerDataClientCouldNotConnect { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataHDSConnectionLost.
        /// </summary>
        [DataMember]
        public String ServerDataHDSConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataHDSConnectionRestored.
        /// </summary>
        [DataMember]
        public String ServerDataHDSConnectionRestored { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataISConnectionLost.
        /// </summary>
        [DataMember]
        public String ServerDataISConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataISConnectionRestored.
        /// </summary>
        [DataMember]
        public String ServerDataISConnectionRestored { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataMarketReplayNoData.
        /// </summary>
        [DataMember]
        public String ServerDataMarketReplayNoData { get; set; }
        /// <summary>
        /// Gets or sets the ServerDataUnableToLoadEntities.
        /// </summary>
        [DataMember]
        public String ServerDataUnableToLoadEntities { get; set; }
        /// <summary>
        /// Gets or sets the ServerDeserializeMissingEmail.
        /// </summary>
        [DataMember]
        public String ServerDeserializeMissingEmail { get; set; }
        /// <summary>
        /// Gets or sets the ServerForcedLogout.
        /// </summary>
        [DataMember]
        public String ServerForcedLogout { get; set; }
        /// <summary>
        /// Gets or sets the ServerForcedLogoutMaintenance.
        /// </summary>
        [DataMember]
        public String ServerForcedLogoutMaintenance { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCancellationNote.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeCancellationNote { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCancelLicense.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeCancelLicense { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteNtlmManagementUser.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeCantDeleteNtlmManagementUser { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteUserManageUsers.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeCantDeleteUserManageUsers { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteUserWithAccounts.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeCantDeleteUserWithAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeCantDeleteUserWithLicences.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeCantDeleteUserWithLicences { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeGenerateLicense.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeGenerateLicense { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeInvalidTechnology.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeInvalidTechnology { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeInvalidUser.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeInvalidUser { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeLifetimeLicenseTerms.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeLifetimeLicenseTerms { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializePrimaryFtp.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializePrimaryFtp { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSecondaryFtp.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeSecondaryFtp { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSubscriptionFreeEdition.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeSubscriptionFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSubscriptionGeneral.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeSubscriptionGeneral { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeSubscriptionMultiBroker.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeSubscriptionMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUnknownLicense.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeUnknownLicense { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUnknownLicenseCode.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeUnknownLicenseCode { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUnknownUser.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeUnknownUser { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericDeserializeUserDeleted.
        /// </summary>
        [DataMember]
        public String ServerGenericDeserializeUserDeleted { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericProcessPaymentProductAlreadyRegistered.
        /// </summary>
        [DataMember]
        public String ServerGenericProcessPaymentProductAlreadyRegistered { get; set; }
        /// <summary>
        /// Gets or sets the ServerGenericProcessPaymentUnknownItemNumber.
        /// </summary>
        [DataMember]
        public String ServerGenericProcessPaymentUnknownItemNumber { get; set; }
        /// <summary>
        /// Gets or sets the ServerGWNoConnectionForAccount.
        /// </summary>
        [DataMember]
        public String ServerGWNoConnectionForAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerGWNoSuchAccount.
        /// </summary>
        [DataMember]
        public String ServerGWNoSuchAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderInvalidInstrument.
        /// </summary>
        [DataMember]
        public String ServerHDSRecorderInvalidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderStarting.
        /// </summary>
        [DataMember]
        public String ServerHDSRecorderStarting { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderStopping.
        /// </summary>
        [DataMember]
        public String ServerHDSRecorderStopping { get; set; }
        /// <summary>
        /// Gets or sets the ServerHDSRecorderUnable2Start.
        /// </summary>
        [DataMember]
        public String ServerHDSRecorderUnable2Start { get; set; }
        /// <summary>
        /// Gets or sets the ServerLoginCredentialsBody.
        /// </summary>
        [DataMember]
        public String ServerLoginCredentialsBody { get; set; }
        /// <summary>
        /// Gets or sets the ServerLoginCredentialsSubject.
        /// </summary>
        [DataMember]
        public String ServerLoginCredentialsSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackingUp.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceBackingUp { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackingUpFileDone.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceBackingUpFileDone { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupCompleted.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceBackupCompleted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupFailed.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceBackupFailed { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupFailedRetry.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceBackupFailedRetry { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceBackupStarted.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceBackupStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceDeletedDataFile.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceDeletedDataFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceDeletedReplayFile.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceDeletedReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceDirectoryNotDefined.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceDirectoryNotDefined { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceMaintenanceCompleted.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceMaintenanceCompleted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceMaintenanceFailed.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceMaintenanceFailed { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceMaintenanceStarted.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceMaintenanceStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceUpdatingRollOvers.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceUpdatingRollOvers { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceZippedDataFile.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceZippedDataFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMaintenanceZippedReplayFile.
        /// </summary>
        [DataMember]
        public String ServerMaintenanceZippedReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the ServerMissingEmailSubjectWarning.
        /// </summary>
        [DataMember]
        public String ServerMissingEmailSubjectWarning { get; set; }
        /// <summary>
        /// Gets or sets the ServerMissingEmailTemplateError.
        /// </summary>
        [DataMember]
        public String ServerMissingEmailTemplateError { get; set; }
        /// <summary>
        /// Gets or sets the ServerMissingEmailTemplateWarning.
        /// </summary>
        [DataMember]
        public String ServerMissingEmailTemplateWarning { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationAccountExcluded.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationAccountExcluded { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationAccountReenabled.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationAccountReenabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationActivated.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationActivated { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationActive.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationActive { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationBegin.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationBegin { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationDeactivated.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationDeactivated { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationException.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationException { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationFail.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationFail { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationInactive.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationInactive { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiquidationSuccess.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiquidationSuccess { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValBidAskNotAvailable.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiqValBidAskNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValBidAskSpread.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiqValBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValExceedsPositionQuantity.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiqValExceedsPositionQuantity { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValInstrumentNotSupported.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiqValInstrumentNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValMaxAccountLoss.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiqValMaxAccountLoss { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValMaxAutoliquidationValue.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiqValMaxAutoliquidationValue { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerAutoLiqValMultipleContractsOnSameMasterInstruments.
        /// </summary>
        [DataMember]
        public String ServerNTServerAutoLiqValMultipleContractsOnSameMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDeserializeBPAccountDisabled.
        /// </summary>
        [DataMember]
        public String ServerNTServerDeserializeBPAccountDisabled { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDeserializeBPNoAccount.
        /// </summary>
        [DataMember]
        public String ServerNTServerDeserializeBPNoAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDeserializeBPOperationNotSupported.
        /// </summary>
        [DataMember]
        public String ServerNTServerDeserializeBPOperationNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerDSNotAvailable.
        /// </summary>
        [DataMember]
        public String ServerNTServerDSNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerNotAvailable.
        /// </summary>
        [DataMember]
        public String ServerNTServerNotAvailable { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerSendConnectPoints1.
        /// </summary>
        [DataMember]
        public String ServerNTServerSendConnectPoints1 { get; set; }
        /// <summary>
        /// Gets or sets the ServerNTServerSendConnectPoints2.
        /// </summary>
        [DataMember]
        public String ServerNTServerSendConnectPoints2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerPostedNoValue.
        /// </summary>
        [DataMember]
        public String ServerPostedNoValue { get; set; }
        /// <summary>
        /// Gets or sets the ServerRenewExpirationSubject.
        /// </summary>
        [DataMember]
        public String ServerRenewExpirationSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardActiveLicences.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardActiveLicences { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardActiveLiveLicencesByProvider.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardActiveLiveLicencesByProvider { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardActiveSimulationLicencesByProvider.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardActiveSimulationLicencesByProvider { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardEditions.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardEditions { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardExistingCustomers.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardExistingCustomers { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardNewCustomers.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardNewCustomers { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardPaymentPlans.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardPaymentPlans { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardProviders.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardProviders { get; set; }
        /// <summary>
        /// Gets or sets the ServerReportsScoreCardTotalLicences.
        /// </summary>
        [DataMember]
        public String ServerReportsScoreCardTotalLicences { get; set; }
        /// <summary>
        /// Gets or sets the ServerResetPasswordByTokenSubject.
        /// </summary>
        [DataMember]
        public String ServerResetPasswordByTokenSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerResetPasswordSubject.
        /// </summary>
        [DataMember]
        public String ServerResetPasswordSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerScannerInvalidInstrument.
        /// </summary>
        [DataMember]
        public String ServerScannerInvalidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerBPDomainNameNotConfigured.
        /// </summary>
        [DataMember]
        public String ServerServerBPDomainNameNotConfigured { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerException.
        /// </summary>
        [DataMember]
        public String ServerServerException { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerFailedToApply.
        /// </summary>
        [DataMember]
        public String ServerServerFailedToApply { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerFailedToPRocessIpn.
        /// </summary>
        [DataMember]
        public String ServerServerFailedToPRocessIpn { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerFreeEditionRegistrationDetails.
        /// </summary>
        [DataMember]
        public String ServerServerFreeEditionRegistrationDetails { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnCancelType1.
        /// </summary>
        [DataMember]
        public String ServerServerIpnCancelType1 { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnFailedToSyncWithPayPal.
        /// </summary>
        [DataMember]
        public String ServerServerIpnFailedToSyncWithPayPal { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnFailure.
        /// </summary>
        [DataMember]
        public String ServerServerIpnFailure { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalid.
        /// </summary>
        [DataMember]
        public String ServerServerIpnInvalid { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidAmount.
        /// </summary>
        [DataMember]
        public String ServerServerIpnInvalidAmount { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidAmountItemCombination.
        /// </summary>
        [DataMember]
        public String ServerServerIpnInvalidAmountItemCombination { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidCurrency.
        /// </summary>
        [DataMember]
        public String ServerServerIpnInvalidCurrency { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidItemNumber.
        /// </summary>
        [DataMember]
        public String ServerServerIpnInvalidItemNumber { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnInvalidReceiverEmail.
        /// </summary>
        [DataMember]
        public String ServerServerIpnInvalidReceiverEmail { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerIpnPending.
        /// </summary>
        [DataMember]
        public String ServerServerIpnPending { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerManageAccount1.
        /// </summary>
        [DataMember]
        public String ServerServerManageAccount1 { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerManageAccount2.
        /// </summary>
        [DataMember]
        public String ServerServerManageAccount2 { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerNetworkInterfaceError.
        /// </summary>
        [DataMember]
        public String ServerServerNetworkInterfaceError { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerPayPalTransactionDetails.
        /// </summary>
        [DataMember]
        public String ServerServerPayPalTransactionDetails { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerProcessFreeEdition.
        /// </summary>
        [DataMember]
        public String ServerServerProcessFreeEdition { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerStarted.
        /// </summary>
        [DataMember]
        public String ServerServerStarted { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerStarting.
        /// </summary>
        [DataMember]
        public String ServerServerStarting { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerStopping.
        /// </summary>
        [DataMember]
        public String ServerServerStopping { get; set; }
        /// <summary>
        /// Gets or sets the ServerServerUserRegistrationSubject.
        /// </summary>
        [DataMember]
        public String ServerServerUserRegistrationSubject { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerApplyingQtyMult.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerApplyingQtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvert_QtyMult.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerConvert_QtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertFractionalPrice.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerConvertFractionalPrice { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertLimitPrice.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerConvertLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertMultiplier.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerConvertMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertOrderQuantity.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerConvertOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertQtyMult.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerConvertQtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerConvertStopPrice.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerConvertStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerEmailIgnored.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerEmailIgnored { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerErrorProcessingTsMail.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerErrorProcessingTsMail { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerGlobalSimulation.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerGlobalSimulation { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerIgnoreMsg.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerIgnoreMsg { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerInvalidAccount.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerInvalidAccount { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerInvalidMultiplier.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerInvalidMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerInvalidQtyMult.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerInvalidQtyMult { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerLimitPriceGreaterAsk.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerLimitPriceGreaterAsk { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerLimitPriceSmallerBid.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerLimitPriceSmallerBid { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerMultiplierSyntax.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerMultiplierSyntax { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerNtPending.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerNtPending { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerOnAccounts.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerOnAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerProcessing.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerProcessing { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerShuttingDown.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerShuttingDown { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerStarting.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerStarting { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerTsPending.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerTsPending { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnableToStart.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerUnableToStart { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnexpectedSmtpCommand.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerUnexpectedSmtpCommand { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnknownInstrument.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerUnknownInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnknownInstrumentMapped.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerUnknownInstrumentMapped { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnkownOrderAction.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerUnkownOrderAction { get; set; }
        /// <summary>
        /// Gets or sets the ServerSmtpServerUnkownOrderType.
        /// </summary>
        [DataMember]
        public String ServerSmtpServerUnkownOrderType { get; set; }
        /// <summary>
        /// Gets or sets the ServerStartGWDontLoadSimAccounts.
        /// </summary>
        [DataMember]
        public String ServerStartGWDontLoadSimAccounts { get; set; }
        /// <summary>
        /// Gets or sets the ServerUnableToStartAtiServer.
        /// </summary>
        [DataMember]
        public String ServerUnableToStartAtiServer { get; set; }
        /// <summary>
        /// Gets or sets the ServerWebPacingParseError.
        /// </summary>
        [DataMember]
        public String ServerWebPacingParseError { get; set; }
        /// <summary>
        /// Gets or sets the ServerWebPacingRecovered.
        /// </summary>
        [DataMember]
        public String ServerWebPacingRecovered { get; set; }
        /// <summary>
        /// Gets or sets the ServerWebPacingViolation.
        /// </summary>
        [DataMember]
        public String ServerWebPacingViolation { get; set; }
        /// <summary>
        /// Gets or sets the ShareEmailNoDefaultEmailDefined.
        /// </summary>
        [DataMember]
        public String ShareEmailNoDefaultEmailDefined { get; set; }
        /// <summary>
        /// Gets or sets the ShareEmailNoEmailServicesDefined.
        /// </summary>
        [DataMember]
        public String ShareEmailNoEmailServicesDefined { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailException.
        /// </summary>
        [DataMember]
        public String ShareMailException { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceAccountName.
        /// </summary>
        [DataMember]
        public String ShareServiceAccountName { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceIsDefault.
        /// </summary>
        [DataMember]
        public String ShareServiceIsDefault { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceParameters.
        /// </summary>
        [DataMember]
        public String ShareServiceParameters { get; set; }
        /// <summary>
        /// Gets or sets the SocketError.
        /// </summary>
        [DataMember]
        public String SocketError { get; set; }
        /// <summary>
        /// Gets or sets the SocketUnexpectedDisconnect.
        /// </summary>
        [DataMember]
        public String SocketUnexpectedDisconnect { get; set; }
        /// <summary>
        /// Gets or sets the StartupRunning32bitOn64SystemAdvice.
        /// </summary>
        [DataMember]
        public String StartupRunning32bitOn64SystemAdvice { get; set; }
        /// <summary>
        /// Gets or sets the StartupRunning32bitOn64SystemQuestion.
        /// </summary>
        [DataMember]
        public String StartupRunning32bitOn64SystemQuestion { get; set; }
        /// <summary>
        /// Gets or sets the StartupServerIdNotSet.
        /// </summary>
        [DataMember]
        public String StartupServerIdNotSet { get; set; }
        /// <summary>
        /// Gets or sets the StartupServerTraceNotSet.
        /// </summary>
        [DataMember]
        public String StartupServerTraceNotSet { get; set; }
        /// <summary>
        /// Gets or sets the String1.
        /// </summary>
        [DataMember]
        public String String1 { get; set; }
        /// <summary>
        /// Gets or sets the TradingOptionsAutoCloseChanged.
        /// </summary>
        [DataMember]
        public String TradingOptionsAutoCloseChanged { get; set; }
        /// <summary>
        /// Gets or sets the TradingServicesMigrationError.
        /// </summary>
        [DataMember]
        public String TradingServicesMigrationError { get; set; }
        /// <summary>
        /// Gets or sets the UserNameLengthExceeded.
        /// </summary>
        [DataMember]
        public String UserNameLengthExceeded { get; set; }
        /// <summary>
        /// Gets or sets the WebServerNoSuchInstrument.
        /// </summary>
        [DataMember]
        public String WebServerNoSuchInstrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
