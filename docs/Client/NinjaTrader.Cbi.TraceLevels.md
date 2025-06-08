# NinjaTrader.Cbi.TraceLevels

`TraceLevels` is an enumeration that defines various tracing flags used throughout the NinjaTrader platform for debugging and logging. Multiple flags can be combined since the enum is decorated with `[Flags]`.

## Values
- `All` (268435455) – Enables all tracing categories.
- `None` (0) – Disables tracing.
- `Bars` (1) – Trace operations related to bar series updates.
- `Connect` (4) – Trace connection events.
- `Database` (8) – Trace database interactions.
- `Gui` (16) – Trace UI related activity.
- `Indicator` (32) – Trace indicator processing.
- `ResolveInstrument` (64) – Trace instrument lookup.
- `MarketData` (128) – Trace incoming market data.
- `MarketDepth` (256) – Trace level‑II market depth.
- `Native` (512) – Trace native wrapper calls.
- `News` (1024) – Trace news data.
- `Order` (2048) – Trace order submission and updates.
- `Strategy` (4096) – Trace strategy execution.
- `Strict` (8192) – Enable strict validation tracing.
- `Test` (16384) – Trace test framework events.
- `Timer` (32768) – Trace timer callbacks.
- `Server` (65536) – Trace server communication.
- `Alerts` (131072) – Trace alert generation.
- `FundamentalData` (262144) – Trace fundamental data events.
