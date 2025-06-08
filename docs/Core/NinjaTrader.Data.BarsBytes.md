# BarsBytes

Namespace: `NinjaTrader.Data`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `IsRecordingSuspended` (bool)
- `BarsPeriod` (NinjaTrader.Data.BarsPeriod)
- `Count` (int)
- `FileName` (string)
- `FirstTime` (System.DateTime)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `IsRecordingMinuteOrDaily` (bool)
- `IsTickReplay` (bool)
- `LastTime` (System.DateTime)
- `LastTimeUtc` (System.DateTime)
- `MarketDataType` (MarketDataType)
- `MaxTime` (System.DateTime)
- `MinTime` (System.DateTime)
- `TickSize` (double)

## Methods
- `Compress(double open, double high, double low, double close, long volume, System.DateTime time, double bid, double ask, int barIndexReplay)` : void
- `DecompressReplayTick(System.IO.BinaryReader reader, int previousBarIndex, System.DateTime lastTimeRead, double lastOpenRead)` : NinjaTrader.Data.ReplayObject
- `GetDataDir(NinjaTrader.Cbi.Instrument instrument, BarsPeriodType periodType)` : string
- `OnMarketData(double price, long volume, System.DateTime time, long tickId)` : void
- `WriteToFile(void)` : void
- `Decompress(System.IO.BinaryReader reader, NinjaTrader.Data.Bars barsProxy)` : bool
- `Decompress(System.IO.BinaryReader reader, bool fromUtc, NinjaTrader.Data.Bars barsProxy, System.DateTime? minTime, System.DateTime? maxTime, bool suppressSessionHandling)` : bool
- `Dispose(void)` : void
- `GetTickMaxTime(System.DateTime time)` : System.DateTime
- `SetLastBarIndexReplay(int index)` : void
- `ToString(void)` : string
