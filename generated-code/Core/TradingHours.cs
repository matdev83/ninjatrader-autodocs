[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class TradingHours : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HolidaysSerializable.
        /// </summary>
        [DataMember]
        public Holiday[] HolidaysSerializable { get; set; }
        /// <summary>
        /// Gets or sets the PartialHolidaysSerializable.
        /// </summary>
        [DataMember]
        public PartialHoliday[] PartialHolidaysSerializable { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursTemplateDir.
        /// </summary>
        [DataMember]
        public String TradingHoursTemplateDir { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneDisplayName.
        /// </summary>
        [DataMember]
        public String TimeZoneDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneInfo.
        /// </summary>
        [DataMember]
        public TimeZoneInfo TimeZoneInfo { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public Int32 Version { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<TradingHours> All { get; set; }
        /// <summary>
        /// Gets or sets the Holidays.
        /// </summary>
        [DataMember]
        public Dictionary<DateTime, String> Holidays { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the PartialHolidays.
        /// </summary>
        [DataMember]
        public Dictionary<DateTime, PartialHoliday> PartialHolidays { get; set; }
        /// <summary>
        /// Gets or sets the Sessions.
        /// </summary>
        [DataMember]
        public Collection<Session> Sessions { get; set; }
        /// <summary>
        /// Gets or sets the SystemDefault.
        /// </summary>
        [DataMember]
        public String SystemDefault { get; set; }
        /// <summary>
        /// Gets or sets the TimeZone.
        /// </summary>
        [DataMember]
        public String TimeZone { get; set; }
        /// <summary>
        /// Gets or sets the UseDataSeriesSettings.
        /// </summary>
        [DataMember]
        public String UseDataSeriesSettings { get; set; }
        /// <summary>
        /// Gets or sets the UseDataSeriesSettingsInstance.
        /// </summary>
        [DataMember]
        public TradingHours UseDataSeriesSettingsInstance { get; set; }
        /// <summary>
        /// Gets or sets the UseInstrumentSettings.
        /// </summary>
        [DataMember]
        public String UseInstrumentSettings { get; set; }
        /// <summary>
        /// Gets or sets the UseInstrumentSettingsInstance.
        /// </summary>
        [DataMember]
        public TradingHours UseInstrumentSettingsInstance { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="tradingHours">TradingHours</param>
        public Void CopyTo(TradingHours tradingHours);
        /// <summary>
        /// GetPreviousTradingDayEnd method.
        /// </summary>
        /// <param name="timeLocal">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime GetPreviousTradingDayEnd(DateTime timeLocal);
        /// <summary>
        /// Remove method.
        /// </summary>
        public Void Remove();
        /// <summary>
        /// Save method.
        /// </summary>
        /// <param name="persist">Boolean</param>
        public Void Save(Boolean persist);
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>TradingHours</returns>
        public TradingHours Get(String name);
        /// <summary>
        /// GetEthRth method.
        /// </summary>
        /// <param name="masterInstrument">MasterInstrument</param>
        /// <returns>Tuple`3</returns>
        public Tuple<TradingHours, TradingHours, TradingHours> GetEthRth(MasterInstrument masterInstrument);
        /// <summary>
        /// String2TradingHours method.
        /// </summary>
        /// <param name="tradingHoursData">String</param>
        /// <returns>TradingHours</returns>
        public TradingHours String2TradingHours(String tradingHoursData);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
