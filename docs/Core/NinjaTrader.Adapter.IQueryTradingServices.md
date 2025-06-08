# IQueryTradingServices

Namespace: `NinjaTrader.Adapter`
Type: interface

This documentation is generated from reflection scaffolding and may be incomplete.

## Methods
- `CompleteNotificationAsync(long id)` : System.Threading.Tasks.Task
- `ModifiyDemoAccountBalance(NinjaTrader.Cbi.Account account, double amount)` : System.Threading.Tasks.Task
- `ModifiyDemoAccountNickname(NinjaTrader.Cbi.Account account, string nickname, System.Threading.Tasks.TaskCompletionSource<string> taskCompletionSource)` : System.Threading.Tasks.Task<string>
- `QueryNotificationsAsync(void)` : System.Threading.Tasks.Task
- `StartAtmStrategyAsync(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, OrderAction action, NinjaTrader.ServerAtm.StrategyEntryInfo entryInfo, NinjaTrader.ServerAtm.ServerAtmStrategy serverAtmStrategy, bool isSimulatedOrder)` : System.Threading.Tasks.Task
- `StopAtmStrategyAsync(long strategyId)` : System.Threading.Tasks.Task
- `UploadUserAtmTemplates(void)` : System.Threading.Tasks.Task
