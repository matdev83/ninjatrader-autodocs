# Api

Namespace: `NinjaTrader.Server`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Challenge` (string)
- `Connection` (NinjaTrader.Cbi.Connection)
- `CurrentCulture` (System.Globalization.CultureInfo)
- `CurrentUICulture` (System.Globalization.CultureInfo)
- `Secret` (string)
- `SubscribedAccounts` (System.Collections.Generic.List<NinjaTrader.Cbi.Account>)
- `User` (NinjaTrader.Cbi.User)
- `IsDisposed` (bool)
- `NT` (NinjaTrader.Cbi.NinjaTraderProxy)

## Methods
- `Dispose(void)` : void
- `ForcedLogout(void)` : void
- `GetResource(string key)` : string
- `OnAccountItemUpdate(object sender, NinjaTrader.Cbi.AccountItemEventArgs e)` : void
- `OnExecutionUpdate(object sender, NinjaTrader.Cbi.ExecutionEventArgs e)` : void
- `OnLogEvent(object sender, NinjaTrader.Cbi.LogEventArgs e)` : void
- `OnOrderUpdate(object sender, NinjaTrader.Cbi.OrderEventArgs e)` : void
- `OnPositionUpdate(object sender, NinjaTrader.Cbi.PositionEventArgs e)` : void
- `OnSoundEvent(object sender, NinjaTrader.Core.SoundEventArgs e)` : void
- `SynchronizeInstrument(NinjaTrader.Cbi.Instrument instrument)` : void
