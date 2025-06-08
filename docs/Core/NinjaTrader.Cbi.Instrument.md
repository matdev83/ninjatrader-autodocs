# Instrument

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `HistoricalData` (NinjaTrader.Data.BarsBytes[])
- `PendingRateUpdates` (System.Collections.Generic.List<NinjaTrader.Cbi.Execution>)
- `SubscriptionHelperInstance` (NinjaTrader.Cbi.Instrument.SubscriptionHelper)
- `HasSeenMarketData` (bool)
- `Dispatcher` (System.Windows.Threading.Dispatcher)
- `IsPersisted` (bool)
- `IsRMSOnly` (bool)
- `All` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument>)
- `Exchange` (Exchange)
- `Expiry` (System.DateTime)
- `FullName` (string)
- `FundamentalData` (NinjaTrader.Data.FundamentalData)
- `Id` (long)
- `IndexPrefix` (char)
- `IsAutoSubscribed` (bool)
- `MarketData` (NinjaTrader.Data.MarketData)
- `MarketDepth` (NinjaTrader.Data.MarketDepth<NinjaTrader.Data.MarketDepthRow>)
- `MasterInstrument` (NinjaTrader.Cbi.MasterInstrument)
- `OptionRight` (OptionRight)
- `StrikePrice` (double)
- `SyncFundamentalData` (object)
- `SyncMarketData` (object)
- `SyncMarketDepth` (object)
- `UnderlyingInstrumentType` (InstrumentType)

## Methods
- `BPRealtimeDataThread(NinjaTrader.Data.IInstrumentProvider e)` : void
- `DbAdd(bool persist)` : void
- `DbRemove(void)` : void
- `DbRemoveByMasterInstrumentID(long id)` : void
- `DbUpdateCache(void)` : void
- `GetDataConnection(Feature feature, bool includeConnectionLost)` : NinjaTrader.Cbi.Connection
- `GetFakeOptionInstrument(void)` : NinjaTrader.Cbi.Instrument
- `GetInstrumentFuzzy(string instrumentName)` : NinjaTrader.Cbi.Instrument
- `GetMarketDataConnection(void)` : NinjaTrader.Cbi.Connection
- `GetRolloverOffset(NinjaTrader.Cbi.Instrument toInstrument)` : double
- `IsInstrumentThread(System.Threading.Thread thread)` : bool
- `RecordingBarsDataFilename(NinjaTrader.Data.BarsPeriod barsPeriod)` : string
- `RequestBars(NinjaTrader.Data.Bars replayBars, NinjaTrader.Data.BarsPeriod barsPeriod, System.DateTime from, System.DateTime to, NinjaTrader.Data.TradingHours tradingHours, bool isDividendAdjusted, bool isSplitAdjusted, bool isRolloverAdjusted, bool isTickReplay, bool isResetOnNewTradingDay, bool isRequestForLiveSession, LookupPolicies lookupPolicy, NinjaTrader.Cbi.Instrument requestedInstrument, bool isSubscribed, bool calculateRollOvers, bool addToRepositorySeries, System.DateTime replayToDate, NinjaTrader.Core.IProgress progress, bool doSubscribeMarketData, System.DateTime lastTradingDayOfContract, System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> callback, object state)` : void
- `SnapShotPersist(bool updateVersion)` : void
- `UpdateExternCache(void)` : void
- `UpdateMarketDepth(string mmId, MarketDataType dataType, double askPrice, long askSize, double bidPrice, long bidSize, System.DateTime time, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)` : void
- `DbGet(long id, bool forceDbQuery)` : NinjaTrader.Cbi.Instrument
- `DbGet(string name, InstrumentType instrumentType, Exchange exchange, System.DateTime expiry, double strikePrice, OptionRight right, bool forceDbQuery)` : NinjaTrader.Cbi.Instrument
- `DbGet(string name, InstrumentType instrumentType, Exchange exchange, System.DateTime expiry, double strikePrice, OptionRight right, bool forceDbQuery, InstrumentType underlyingInstrumentType)` : NinjaTrader.Cbi.Instrument
- `GetFullName(UserSymbologySetting symbologySetting, bool legacy)` : string
- `GetConversionRate(MarketDataType marketDataType, Currency denomination, System.Boolean& tryAgainLater)` : double
- `GetInstrument(string instrumentName, bool create)` : NinjaTrader.Cbi.Instrument
- `GetInstrumentType(string instrumentName)` : InstrumentType
- `IsInstrumentFuture(string instrumentName)` : bool
- `ToInstrumentInfo(Exchange? exchange)` : NinjaTrader.Adapter.InstrumentInfo
- `ToString(void)` : string
- `UpdateMarketDepth(MarketDataType dataType, double price, long volume, Operation operation, System.DateTime time, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)` : void
