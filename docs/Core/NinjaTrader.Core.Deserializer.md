# Deserializer

Namespace: `NinjaTrader.Core`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Adapter` (NinjaTrader.Adapter.IAdapter)
- `Api` (NinjaTrader.Server.Api)
- `Bytes` (System.Byte[])
- `Connection` (NinjaTrader.Cbi.IConnection)
- `DontProcessRealtimeData` (bool)
- `LargeString` (System.Text.StringBuilder)
- `Length` (int)
- `NT` (NinjaTrader.Cbi.NinjaTraderProxy)
- `Position` (int)

## Methods
- `Deserialize(System.Byte[] bytes, int offset, int length)` : void
- `Deserialize(bool verifyEntitlement)` : object
- `Dispose(void)` : void
- `OnError(string key, string extra)` : void
- `ReadBoolean(void)` : bool
- `ReadByte(void)` : byte
- `ReadDateTime(void)` : System.DateTime
- `ReadDateTimeUtc(void)` : System.DateTime
- `ReadDouble(void)` : double
- `ReadInt32(void)` : int
- `ReadInt64(void)` : long
- `ReadServerId(void)` : int
- `ReadString(void)` : string
- `ReadUInt16(void)` : ushort
