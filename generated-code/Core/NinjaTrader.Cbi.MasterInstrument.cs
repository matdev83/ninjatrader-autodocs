[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MasterInstrument : System.ICloneable, NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAutoLiquidationEnabled.
        /// </summary>
        [DataMember]
        public bool IsAutoLiquidationEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Dividends.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Dividend> Dividends { get; set; }
        /// <summary>
        /// Gets or sets the Exchanges.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<Exchange> Exchanges { get; set; }
        /// <summary>
        /// Gets or sets the IsServerSupported.
        /// </summary>
        [DataMember]
        public bool IsServerSupported { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy.
        /// </summary>
        [DataMember]
        public MergePolicy MergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the PriceLevel.
        /// </summary>
        [DataMember]
        public double PriceLevel { get; set; }
        /// <summary>
        /// Gets or sets the Splits.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Split> Splits { get; set; }
        /// <summary>
        /// Gets or sets the SyncBarsBytesFiles.
        /// </summary>
        [DataMember]
        public object SyncBarsBytesFiles { get; set; }
        /// <summary>
        /// Gets or sets the SyncPlaybackFiles.
        /// </summary>
        [DataMember]
        public object SyncPlaybackFiles { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public System.Uri Url { get; set; }
        /// <summary>
        /// Gets or sets the UrlSerializable.
        /// </summary>
        [DataMember]
        public string UrlSerializable { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public System.Xml.Linq.XDocument UserData { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public int Version { get; set; }
        /// <summary>
        /// Gets or sets the Sync.
        /// </summary>
        [DataMember]
        public object Sync { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.MasterInstrument> All { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public Currency Currency { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalData.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.FundamentalData FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType.
        /// </summary>
        [DataMember]
        public InstrumentType InstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PointValue.
        /// </summary>
        [DataMember]
        public double PointValue { get; set; }
        /// <summary>
        /// Gets or sets the ProviderNames.
        /// </summary>
        [DataMember]
        public System.String[] ProviderNames { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollection.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.RolloverCollection RolloverCollection { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours TradingHours { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="masterInstrument">NinjaTrader.Cbi.MasterInstrument</param>
        public void CopyTo(NinjaTrader.Cbi.MasterInstrument masterInstrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="masterInstrument">NinjaTrader.Cbi.MasterInstrument</param>
        /// <param name="generalPropertiesOnly">bool</param>
        public void CopyTo(NinjaTrader.Cbi.MasterInstrument masterInstrument, bool generalPropertiesOnly)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateInstruments method.
        /// </summary>
        /// <param name="strikePrice">double</param>
        /// <param name="right">OptionRight</param>
        public void CreateInstruments(double strikePrice, OptionRight right)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbAdd method.
        /// </summary>
        [Obsolete("Don't use, but call DbAdd(true) instead. It's only there to not break existing code.")]
        public void DbAdd()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">bool</param>
        public void DbAdd(bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">long</param>
        /// <param name="forceDbQuery">bool</param>
        /// <returns>NinjaTrader.Cbi.MasterInstrument</returns>
        public NinjaTrader.Cbi.MasterInstrument DbGet(long id, bool forceDbQuery)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbPersist method.
        /// </summary>
        public void DbPersist()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public void DbRemove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbUpdate method.
        /// </summary>
        public void DbUpdate()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbUpdateCache method.
        /// </summary>
        public void DbUpdateCache()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDividendSum method.
        /// </summary>
        /// <param name="atDate">System.DateTime</param>
        /// <returns>double</returns>
        public double GetDividendSum(System.DateTime atDate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInstrumentByDate method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="date">System.DateTime</param>
        /// <param name="getActualExiry">bool</param>
        /// <param name="suppressCalculateRollOvers">bool</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument GetInstrumentByDate(NinjaTrader.Cbi.Instrument instrument, System.DateTime date, bool getActualExiry, bool suppressCalculateRollOvers, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetNextExpiry method.
        /// </summary>
        /// <param name="afterDate">System.DateTime</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetNextExpiry(System.DateTime afterDate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetNextRolloverDate method.
        /// </summary>
        /// <param name="date">System.DateTime</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetNextRolloverDate(System.DateTime date)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetSplitFactor method.
        /// </summary>
        /// <param name="atDate">System.DateTime</param>
        /// <returns>double</returns>
        public double GetSplitFactor(System.DateTime atDate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RoundDownToTickSize method.
        /// </summary>
        /// <param name="price">double</param>
        /// <returns>double</returns>
        public double RoundDownToTickSize(double price)
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
        /// TryParsePrice method.
        /// </summary>
        /// <param name="value">string</param>
        /// <param name="price">System.Double&</param>
        /// <returns>bool</returns>
        public bool TryParsePrice(string value, System.Double& price)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TryParsePrice method.
        /// </summary>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="tickSize">double</param>
        /// <param name="value">string</param>
        /// <param name="price">System.Double&</param>
        /// <returns>bool</returns>
        public bool TryParsePrice(InstrumentType instrumentType, double tickSize, string value, System.Double& price)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateRolloverCollection method.
        /// </summary>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="earliestRolloverToUpdate">System.DateTime</param>
        public void UpdateRolloverCollection(NinjaTrader.Core.IProgress progress, System.DateTime earliestRolloverToUpdate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Compare method.
        /// </summary>
        /// <param name="price1">double</param>
        /// <param name="price2">double</param>
        /// <returns>int</returns>
        public int Compare(double price1, double price2)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="forceDbQuery">bool</param>
        /// <returns>NinjaTrader.Cbi.MasterInstrument</returns>
        public NinjaTrader.Cbi.MasterInstrument DbGet(string name, InstrumentType instrumentType, bool forceDbQuery)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DeconstructPrice method.
        /// </summary>
        /// <param name="price">double</param>
        /// <param name="handlePrice">System.Double&</param>
        /// <param name="pipPrice">System.Double&</param>
        /// <param name="subPipPrice">System.Double&</param>
        /// <param name="standardTickSize">System.Boolean&</param>
        public void DeconstructPrice(double price, System.Double& handlePrice, System.Double& pipPrice, System.Double& subPipPrice, System.Boolean& standardTickSize)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FormatPrice method.
        /// </summary>
        /// <param name="price">double</param>
        /// <param name="round">bool</param>
        /// <returns>string</returns>
        public string FormatPrice(double price, bool round)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsValidName method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
        public bool IsValidName(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RoundPrice method.
        /// </summary>
        /// <param name="price">double</param>
        /// <param name="tickSize">double</param>
        /// <returns>double</returns>
        public double RoundPrice(double price, double tickSize)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RoundToTickSize method.
        /// </summary>
        /// <param name="price">double</param>
        /// <returns>double</returns>
        public double RoundToTickSize(double price)
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
