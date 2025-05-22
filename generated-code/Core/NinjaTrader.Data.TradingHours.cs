[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class TradingHours : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HolidaysSerializable.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.Holiday[] HolidaysSerializable { get; set; }
        /// <summary>
        /// Gets or sets the PartialHolidaysSerializable.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.PartialHoliday[] PartialHolidaysSerializable { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursTemplateDir.
        /// </summary>
        [DataMember]
        public string TradingHoursTemplateDir { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneDisplayName.
        /// </summary>
        [DataMember]
        public string TimeZoneDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the TimeZoneInfo.
        /// </summary>
        [DataMember]
        public System.TimeZoneInfo TimeZoneInfo { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public int Version { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Data.TradingHours> All { get; set; }
        /// <summary>
        /// Gets or sets the Holidays.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<System.DateTime, string> Holidays { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PartialHolidays.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<System.DateTime, NinjaTrader.Data.PartialHoliday> PartialHolidays { get; set; }
        /// <summary>
        /// Gets or sets the Sessions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Data.Session> Sessions { get; set; }
        /// <summary>
        /// Gets or sets the SystemDefault.
        /// </summary>
        [DataMember]
        public string SystemDefault { get; set; }
        /// <summary>
        /// Gets or sets the TimeZone.
        /// </summary>
        [DataMember]
        public string TimeZone { get; set; }
        /// <summary>
        /// Gets or sets the UseDataSeriesSettings.
        /// </summary>
        [DataMember]
        public string UseDataSeriesSettings { get; set; }
        /// <summary>
        /// Gets or sets the UseDataSeriesSettingsInstance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours UseDataSeriesSettingsInstance { get; set; }
        /// <summary>
        /// Gets or sets the UseInstrumentSettings.
        /// </summary>
        [DataMember]
        public string UseInstrumentSettings { get; set; }
        /// <summary>
        /// Gets or sets the UseInstrumentSettingsInstance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours UseInstrumentSettingsInstance { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="tradingHours">NinjaTrader.Data.TradingHours</param>
        public void CopyTo(NinjaTrader.Data.TradingHours tradingHours)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetPreviousTradingDayEnd method.
        /// </summary>
        /// <param name="timeLocal">System.DateTime</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetPreviousTradingDayEnd(System.DateTime timeLocal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Remove method.
        /// </summary>
        public void Remove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Save method.
        /// </summary>
        /// <param name="persist">bool</param>
        public void Save(bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Data.TradingHours</returns>
        public NinjaTrader.Data.TradingHours Get(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetEthRth method.
        /// </summary>
        /// <param name="masterInstrument">NinjaTrader.Cbi.MasterInstrument</param>
        /// <returns>System.Tuple<NinjaTrader.Data.TradingHours, NinjaTrader.Data.TradingHours, NinjaTrader.Data.TradingHours></returns>
        public System.Tuple<NinjaTrader.Data.TradingHours, NinjaTrader.Data.TradingHours, NinjaTrader.Data.TradingHours> GetEthRth(NinjaTrader.Cbi.MasterInstrument masterInstrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// String2TradingHours method.
        /// </summary>
        /// <param name="tradingHoursData">string</param>
        /// <returns>NinjaTrader.Data.TradingHours</returns>
        public NinjaTrader.Data.TradingHours String2TradingHours(string tradingHoursData)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
