[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class GeneralOptions : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrushDownPrimary.
        /// </summary>
        [DataMember]
        public Brush BrushDownPrimary { get; set; }
        /// <summary>
        /// Gets or sets the BrushDownSecondary.
        /// </summary>
        [DataMember]
        public Brush BrushDownSecondary { get; set; }
        /// <summary>
        /// Gets or sets the BrushUpPrimary.
        /// </summary>
        [DataMember]
        public Brush BrushUpPrimary { get; set; }
        /// <summary>
        /// Gets or sets the BrushUpSecondary.
        /// </summary>
        [DataMember]
        public Brush BrushUpSecondary { get; set; }
        /// <summary>
        /// Gets or sets the ConfirmWindowClose.
        /// </summary>
        [DataMember]
        public Boolean ConfirmWindowClose { get; set; }
        /// <summary>
        /// Gets or sets the IsGlobalDrawingObjectsAcrossWorkspaces.
        /// </summary>
        [DataMember]
        public Boolean IsGlobalDrawingObjectsAcrossWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the IsGlobalLinkButtonEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsGlobalLinkButtonEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsLayoutDockingEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsLayoutDockingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Language.
        /// </summary>
        [DataMember]
        public SupportedLanguage Language { get; set; }
        /// <summary>
        /// Gets or sets the MultiProvider.
        /// </summary>
        [DataMember]
        public Boolean MultiProvider { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetrics.
        /// </summary>
        [DataMember]
        public Collection<String> PerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the ReopenWorkspaces.
        /// </summary>
        [DataMember]
        public Boolean ReopenWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the SaveUsername.
        /// </summary>
        [DataMember]
        public Boolean SaveUsername { get; set; }
        /// <summary>
        /// Gets or sets the ShareServices.
        /// </summary>
        [DataMember]
        public Collection<ShareService> ShareServices { get; set; }
        /// <summary>
        /// Gets or sets the ShowAccountNumbersAndBalances.
        /// </summary>
        [DataMember]
        public Boolean ShowAccountNumbersAndBalances { get; set; }
        /// <summary>
        /// Gets or sets the ShowDefaultWorkspaces.
        /// </summary>
        [DataMember]
        public Boolean ShowDefaultWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the ShowToolTips.
        /// </summary>
        [DataMember]
        public Boolean ShowToolTips { get; set; }
        /// <summary>
        /// Gets or sets the Skin.
        /// </summary>
        [DataMember]
        public String Skin { get; set; }
        /// <summary>
        /// Gets or sets the RecoveryWorkspaces.
        /// </summary>
        [DataMember]
        public Int32 RecoveryWorkspaces { get; set; }
        /// <summary>
        /// Gets or sets the SoundPlayConsecutively.
        /// </summary>
        [DataMember]
        public Boolean SoundPlayConsecutively { get; set; }
        /// <summary>
        /// Gets or sets the SoundAnnouncement.
        /// </summary>
        [DataMember]
        public String SoundAnnouncement { get; set; }
        /// <summary>
        /// Gets or sets the SoundAutoBreakeven.
        /// </summary>
        [DataMember]
        public String SoundAutoBreakeven { get; set; }
        /// <summary>
        /// Gets or sets the SoundAutoChase.
        /// </summary>
        [DataMember]
        public String SoundAutoChase { get; set; }
        /// <summary>
        /// Gets or sets the SoundAutoTrail.
        /// </summary>
        [DataMember]
        public String SoundAutoTrail { get; set; }
        /// <summary>
        /// Gets or sets the SoundCompiledSuccessfully.
        /// </summary>
        [DataMember]
        public String SoundCompiledSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the SoundConnected.
        /// </summary>
        [DataMember]
        public String SoundConnected { get; set; }
        /// <summary>
        /// Gets or sets the SoundConnectionLost.
        /// </summary>
        [DataMember]
        public String SoundConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the SoundOrderCanceled.
        /// </summary>
        [DataMember]
        public String SoundOrderCanceled { get; set; }
        /// <summary>
        /// Gets or sets the SoundOrderFilled.
        /// </summary>
        [DataMember]
        public String SoundOrderFilled { get; set; }
        /// <summary>
        /// Gets or sets the SoundOrderPending.
        /// </summary>
        [DataMember]
        public String SoundOrderPending { get; set; }
        /// <summary>
        /// Gets or sets the SoundReversing.
        /// </summary>
        [DataMember]
        public String SoundReversing { get; set; }
        /// <summary>
        /// Gets or sets the SoundStopFilled.
        /// </summary>
        [DataMember]
        public String SoundStopFilled { get; set; }
        /// <summary>
        /// Gets or sets the SoundTargetFilled.
        /// </summary>
        [DataMember]
        public String SoundTargetFilled { get; set; }
        /// <summary>
        /// Gets or sets the BrushUpPrimarySerialize.
        /// </summary>
        [DataMember]
        public String BrushUpPrimarySerialize { get; set; }
        /// <summary>
        /// Gets or sets the BrushUpSecondarySerialize.
        /// </summary>
        [DataMember]
        public String BrushUpSecondarySerialize { get; set; }
        /// <summary>
        /// Gets or sets the BrushDownPrimarySerialize.
        /// </summary>
        [DataMember]
        public String BrushDownPrimarySerialize { get; set; }
        /// <summary>
        /// Gets or sets the BrushDownSecondarySerialize.
        /// </summary>
        [DataMember]
        public String BrushDownSecondarySerialize { get; set; }
        /// <summary>
        /// Gets or sets the BrushUpPrimarySerializeKo.
        /// </summary>
        [DataMember]
        public String BrushUpPrimarySerializeKo { get; set; }
        /// <summary>
        /// Gets or sets the BrushUpSecondarySerializeKo.
        /// </summary>
        [DataMember]
        public String BrushUpSecondarySerializeKo { get; set; }
        /// <summary>
        /// Gets or sets the BrushDownPrimarySerializeKo.
        /// </summary>
        [DataMember]
        public String BrushDownPrimarySerializeKo { get; set; }
        /// <summary>
        /// Gets or sets the BrushDownSecondarySerializeKo.
        /// </summary>
        [DataMember]
        public String BrushDownSecondarySerializeKo { get; set; }
        /// <summary>
        /// Gets or sets the CurrentUICultureSerializable.
        /// </summary>
        [DataMember]
        public String CurrentUICultureSerializable { get; set; }
        /// <summary>
        /// Gets or sets the MailFrom.
        /// </summary>
        [DataMember]
        public String MailFrom { get; set; }
        /// <summary>
        /// Gets or sets the KinetickGlobexNonProFees.
        /// </summary>
        [DataMember]
        public Boolean KinetickGlobexNonProFees { get; set; }
        /// <summary>
        /// Gets or sets the LogsLoaded.
        /// </summary>
        [DataMember]
        public Int32 LogsLoaded { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the PromptLanguageWarningForBasicEntry.
        /// </summary>
        [DataMember]
        public Boolean PromptLanguageWarningForBasicEntry { get; set; }
        /// <summary>
        /// Gets or sets the TabRespositioningImmediate.
        /// </summary>
        [DataMember]
        public Boolean TabRespositioningImmediate { get; set; }
        /// <summary>
        /// Gets or sets the CurrentCulture.
        /// </summary>
        [DataMember]
        public CultureInfo CurrentCulture { get; set; }
        /// <summary>
        /// Gets or sets the CurrentUICulture.
        /// </summary>
        [DataMember]
        public CultureInfo CurrentUICulture { get; set; }
        /// <summary>
        /// Gets or sets the LogsMaintainedDays.
        /// </summary>
        [DataMember]
        public Int32 LogsMaintainedDays { get; set; }
        /// <summary>
        /// Gets or sets the MailAlertMessagesTo.
        /// </summary>
        [DataMember]
        public String MailAlertMessagesTo { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneInfo.
        /// </summary>
        [DataMember]
        public TimeZoneInfo TimeZoneInfo { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneMinDate.
        /// </summary>
        [DataMember]
        public DateTime TimeZoneMinDate { get; set; }
        /// <summary>
        /// Gets or sets the ExpiryDisplayMode.
        /// </summary>
        [DataMember]
        public UserSymbologySetting ExpiryDisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneInfoPersisted.
        /// </summary>
        [DataMember]
        public TimeZoneInfo TimeZoneInfoPersisted { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneInfoSerializable.
        /// </summary>
        [DataMember]
        public String TimeZoneInfoSerializable { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetOrderTypeBrush method.
        /// </summary>
        /// <param name="orderType">OrderType</param>
        /// <returns>Brush</returns>
        public Brush GetOrderTypeBrush(OrderType orderType);
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">GeneralOptions</param>
        public Void CopyTo(GeneralOptions options);
        #endregion
    }
}
