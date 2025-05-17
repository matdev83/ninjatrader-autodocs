[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MasterInstrument : ICloneable, ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAutoLiquidationEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAutoLiquidationEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Dividends.
        /// </summary>
        [DataMember]
        public Collection<Dividend> Dividends { get; set; }
        /// <summary>
        /// Gets or sets the Exchanges.
        /// </summary>
        [DataMember]
        public Collection<Exchange> Exchanges { get; set; }
        /// <summary>
        /// Gets or sets the IsServerSupported.
        /// </summary>
        [DataMember]
        public Boolean IsServerSupported { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy.
        /// </summary>
        [DataMember]
        public MergePolicy MergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the PriceLevel.
        /// </summary>
        [DataMember]
        public Double PriceLevel { get; set; }
        /// <summary>
        /// Gets or sets the Splits.
        /// </summary>
        [DataMember]
        public Collection<Split> Splits { get; set; }
        /// <summary>
        /// Gets or sets the SyncBarsBytesFiles.
        /// </summary>
        [DataMember]
        public Object SyncBarsBytesFiles { get; set; }
        /// <summary>
        /// Gets or sets the SyncPlaybackFiles.
        /// </summary>
        [DataMember]
        public Object SyncPlaybackFiles { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public Uri Url { get; set; }
        /// <summary>
        /// Gets or sets the UrlSerializable.
        /// </summary>
        [DataMember]
        public String UrlSerializable { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public XDocument UserData { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public Int32 Version { get; set; }
        /// <summary>
        /// Gets or sets the Sync.
        /// </summary>
        [DataMember]
        public Object Sync { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<MasterInstrument> All { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public Currency Currency { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalData.
        /// </summary>
        [DataMember]
        public FundamentalData FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType.
        /// </summary>
        [DataMember]
        public InstrumentType InstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the PointValue.
        /// </summary>
        [DataMember]
        public Double PointValue { get; set; }
        /// <summary>
        /// Gets or sets the ProviderNames.
        /// </summary>
        [DataMember]
        public String[] ProviderNames { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollection.
        /// </summary>
        [DataMember]
        public RolloverCollection RolloverCollection { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public TradingHours TradingHours { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="masterInstrument">MasterInstrument</param>
        public Void CopyTo(MasterInstrument masterInstrument);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="masterInstrument">MasterInstrument</param>
        /// <param name="generalPropertiesOnly">Boolean</param>
        public Void CopyTo(MasterInstrument masterInstrument, Boolean generalPropertiesOnly);
        /// <summary>
        /// CreateInstruments method.
        /// </summary>
        /// <param name="strikePrice">Double</param>
        /// <param name="right">OptionRight</param>
        public Void CreateInstruments(Double strikePrice, OptionRight right);
        /// <summary>
        /// DbAdd method.
        /// </summary>
        [Obsolete("Don't use, but call DbAdd(true) instead. It's only there to not break existing code.")]
        public Void DbAdd();
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">Boolean</param>
        public Void DbAdd(Boolean persist);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <returns>MasterInstrument</returns>
        public MasterInstrument DbGet(Int64 id, Boolean forceDbQuery);
        /// <summary>
        /// DbPersist method.
        /// </summary>
        public Void DbPersist();
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// DbUpdate method.
        /// </summary>
        public Void DbUpdate();
        /// <summary>
        /// DbUpdateCache method.
        /// </summary>
        public Void DbUpdateCache();
        /// <summary>
        /// GetDividendSum method.
        /// </summary>
        /// <param name="atDate">DateTime</param>
        /// <returns>Double</returns>
        public Double GetDividendSum(DateTime atDate);
        /// <summary>
        /// GetInstrumentByDate method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="date">DateTime</param>
        /// <param name="getActualExiry">Boolean</param>
        /// <param name="suppressCalculateRollOvers">Boolean</param>
        /// <param name="progress">IProgress</param>
        /// <returns>Instrument</returns>
        public Instrument GetInstrumentByDate(Instrument instrument, DateTime date, Boolean getActualExiry, Boolean suppressCalculateRollOvers, IProgress progress);
        /// <summary>
        /// GetNextExpiry method.
        /// </summary>
        /// <param name="afterDate">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime GetNextExpiry(DateTime afterDate);
        /// <summary>
        /// GetNextRolloverDate method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime GetNextRolloverDate(DateTime date);
        /// <summary>
        /// GetSplitFactor method.
        /// </summary>
        /// <param name="atDate">DateTime</param>
        /// <returns>Double</returns>
        public Double GetSplitFactor(DateTime atDate);
        /// <summary>
        /// RoundDownToTickSize method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Double</returns>
        public Double RoundDownToTickSize(Double price);
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// TryParsePrice method.
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="price">Double&</param>
        /// <returns>Boolean</returns>
        public Boolean TryParsePrice(String value, Double& price);
        /// <summary>
        /// TryParsePrice method.
        /// </summary>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="tickSize">Double</param>
        /// <param name="value">String</param>
        /// <param name="price">Double&</param>
        /// <returns>Boolean</returns>
        public Boolean TryParsePrice(InstrumentType instrumentType, Double tickSize, String value, Double& price);
        /// <summary>
        /// UpdateRolloverCollection method.
        /// </summary>
        /// <param name="progress">IProgress</param>
        /// <param name="earliestRolloverToUpdate">DateTime</param>
        public Void UpdateRolloverCollection(IProgress progress, DateTime earliestRolloverToUpdate);
        /// <summary>
        /// Compare method.
        /// </summary>
        /// <param name="price1">Double</param>
        /// <param name="price2">Double</param>
        /// <returns>Int32</returns>
        public Int32 Compare(Double price1, Double price2);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <returns>MasterInstrument</returns>
        public MasterInstrument DbGet(String name, InstrumentType instrumentType, Boolean forceDbQuery);
        /// <summary>
        /// DeconstructPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <param name="handlePrice">Double&</param>
        /// <param name="pipPrice">Double&</param>
        /// <param name="subPipPrice">Double&</param>
        /// <param name="standardTickSize">Boolean&</param>
        public Void DeconstructPrice(Double price, Double& handlePrice, Double& pipPrice, Double& subPipPrice, Boolean& standardTickSize);
        /// <summary>
        /// FormatPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <param name="round">Boolean</param>
        /// <returns>String</returns>
        public String FormatPrice(Double price, Boolean round);
        /// <summary>
        /// IsValidName method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidName(String name);
        /// <summary>
        /// RoundPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <param name="tickSize">Double</param>
        /// <returns>Double</returns>
        public Double RoundPrice(Double price, Double tickSize);
        /// <summary>
        /// RoundToTickSize method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Double</returns>
        public Double RoundToTickSize(Double price);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
