# Serializer

Namespace: `NinjaTrader.Core`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `AreBuffersExceeded` (bool)
- `BytesBuffered` (int)
- `NT` (NinjaTrader.Cbi.NinjaTraderProxy)
- `NumBuffers` (int)

## Methods
- `FlowControl(void)` : void
- `Serialize(NinjaTrader.NinjaScript.AtmStrategy o, int version)` : void
- `Serialize(NinjaTrader.Cbi.Commission o)` : void
- `Serialize(NinjaTrader.Cbi.IConnection o)` : void
- `Serialize(NinjaTrader.Cbi.CustomOrder o)` : void
- `Serialize(NinjaTrader.Cbi.HandshakeReply o)` : void
- `Serialize(NinjaTrader.Cbi.HandshakeRequest o)` : void
- `Serialize(NinjaTrader.Data.Hotlist o)` : void
- `Serialize(NinjaTrader.Cbi.Instrument o, bool addToRepository)` : void
- `Serialize(NinjaTrader.Cbi.InstrumentList o)` : void
- `Serialize(NinjaTrader.Cbi.MasterInstrument o, bool addToRepository)` : void
- `Serialize(NinjaTrader.Cbi.Message o)` : void
- `Serialize(NinjaTrader.Cbi.Order o)` : void
- `Serialize(NinjaTrader.Cbi.Risk o)` : void
- `Serialize(NinjaTrader.Cbi.RolloverCollection o, string name)` : void
- `Serialize(NinjaTrader.Cbi.StartupInfo o)` : void
- `Serialize(NinjaTrader.Cbi.StartupInfoComplete o)` : void
- `Serialize(NinjaTrader.Server.Statistics o, bool all)` : void
- `Serialize(NinjaTrader.Data.TradingHours o, bool addToRepository)` : void
- `Serialize(byte b)` : void
- `Serialize(System.Byte[] array)` : void
- `SerializeMarkEndOfMessage(System.Byte[] array, int offset, int length, int numEvents)` : void
- `Serialize(bool value)` : void
- `Serialize(NinjaTrader.Cbi.IUserEntitlement o)` : void
- `Serialize(ushort value)` : void
- `Serialize(string value)` : void
- `Serialize(double value)` : void
- `Serialize(int value)` : void
- `Serialize(long value)` : void
- `Serialize(System.DateTime value)` : void
- `SerializeServerId(int value)` : void
- `SerializeToUtc(System.DateTime value)` : void
- `ToBytes(void)` : System.Byte[]
