# MarketReplay

Namespace: `NinjaTrader.Data`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `CurrentMarketData` (NinjaTrader.Data.MarketDataEventArgs)
- `CurrentMarketDepth` (NinjaTrader.Data.MarketDepthEventArgs)
- `DoInitMarketDepth` (bool)
- `IsMinTimeCheckEnabled` (bool)

## Methods
- `Dispose(void)` : void
- `DumpMarketData(NinjaTrader.Cbi.Instrument instrument, System.DateTime from, System.DateTime to, string path)` : bool
- `DumpMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.DateTime from, System.DateTime to, string path)` : void
- `MoveNext(void)` : bool
- `OnMarketData(MarketDataType marketDataType, double price, long volume, System.DateTime timeLocal)` : void
- `OnMarketDepth(int position, string marketMaker, Operation operation, MarketDataType marketDataType, double price, long volume, System.DateTime timeLocal)` : void
- `Start(void)` : void
- `Stop(void)` : void
