# SessionIterator

Namespace: `NinjaTrader.Data`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `ActualSessionEnd` (System.DateTime)
- `ActualSessionBegin` (System.DateTime)
- `ActualTradingDayEndLocal` (System.DateTime)
- `ActualTradingDayExchange` (System.DateTime)

## Methods
- `IsTradingDayDefined(System.DateTime date)` : bool
- `CalculateTradingDay(System.DateTime timeLocal, bool includesEndTimeStamp)` : void
- `GetNextSession(System.DateTime timeLocal, bool includesEndTimeStamp)` : bool
- `GetTradingDay(System.DateTime timeLocal)` : System.DateTime
- `GetTradingDayBeginLocal(System.DateTime tradingDayExchange)` : System.DateTime
- `GetTradingDayEndLocal(System.DateTime tradingDayExchange)` : System.DateTime
- `IsInSession(System.DateTime timeLocal, bool includesEndTimeStamp, bool isIntraday)` : bool
- `IsNewSession(System.DateTime time, bool includesEndTimeStamp)` : bool
- `Reset(void)` : void
