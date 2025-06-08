# HdsClient

Namespace: `NinjaTrader.Server`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `DoSuppressServerMessages` (bool)
- `NT` (NinjaTrader.Cbi.NinjaTraderProxy)
- `Options` (NinjaTrader.Cbi.NTConnectOptions)
- `UseSsl` (bool)
- `IsHdsBackfill` (bool)

## Methods
- `Connect(void)` : void
- `Disconnect(void)` : void
- `DownloadInfoFromServer(System.Action<ErrorCode, string> callback, System.Func<CoreDialogType, System.String[], bool> syncStartupInfoCallback, StartupInfoType onDemandInfoType, OnDemandUpdateOptions demandUpdateOptions, string system)` : void
- `RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)` : void
- `RequestMarketReplay(NinjaTrader.Cbi.Instrument instrument, System.DateTime dateEst, System.Action<ErrorCode, string, object> callback, NinjaTrader.Core.IProgress progress, object state)` : void
