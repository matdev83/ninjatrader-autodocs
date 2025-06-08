# NinjaTrader.Client.Client

`Client` is the main programmatic entry for communicating with the NinjaTrader desktop application. It implements `IClient` and exposes methods for market data access, order submission and account queries.

Most methods return an `int` result code or a value depending on the query. A minimal outline of available calls is listed below.

## Key Methods
- `Ask(instrument, price, size)` – Submit an ask quote.
- `AskPlayback(instrument, price, size, timestamp)` – Feed historical ask data for playback.
- `AvgEntryPrice(instrument, account)` – Get the average entry price for an instrument and account.
- `AvgFillPrice(orderId)` – Obtain the average fill price for an order.
- `Bid(instrument, price, size)` – Submit a bid quote.
- `BidPlayback(instrument, price, size, timestamp)` – Feed historical bid data for playback.
- `BuyingPower(account)` – Query available buying power.
- `CashValue(account)` – Retrieve current cash value.
- `Command(command, account, instrument, action, quantity, orderType, limitPrice, stopPrice, timeInForce, oco, orderId, tpl, strategy)` – Generic command interface for order operations.
- `ConfirmOrders(confirm)` – Enable or disable order confirmations.
- `Connected(showMessage)` – Returns connection status.
- `Dispose()` – Clean up resources.
- `Filled(orderId)` – Check if an order is filled.
- `GetDouble(key)` – Retrieve a double value for a configuration key.
- `GetInt(key)` – Retrieve an integer value for a configuration key.
- `GetString(key)` – Retrieve a string value for a configuration key.
- `Last(instrument, price, size)` – Submit a last trade quote.
- `LastPlayback(instrument, price, size, timestamp)` – Feed historical last trade data for playback.
- `MarketData(instrument, type)` – Query market data of a specific `MarketDataType`.
- `MarketPosition(instrument, account)` – Get the net position for an account.
- `NewOrderId()` – Generate a new order identifier.
- `Orders(account)` – List working orders for an account.
- `OrderStatus(orderId)` – Retrieve the status string for an order.
- `QueryInstrument()` – Return serialized information about instruments.
- `RealizedPnL(account)` – Get realized profit and loss for an account.
- `SetAllocReturnString(value)` – Configure allocation string handling.
- `SetMaxReturnStringLength(value)` – Configure maximum length of returned strings.
- `SetUp(host, port)` – Establish a connection to the desktop application.
- `StopOrders(strategyId)` – List stop orders for a strategy.
- `Strategies(account)` – List running strategies for an account.
- `StrategyPosition(strategyId)` – Get a strategy's current position.
- `SubscribeMarketData(instrument)` – Begin streaming real-time market data.
- `TargetOrders(strategyId)` – List target orders for a strategy.
- `TearDown()` – Disconnect from the application.
- `UnsubscribeMarketData(instrument)` – Stop streaming market data.
