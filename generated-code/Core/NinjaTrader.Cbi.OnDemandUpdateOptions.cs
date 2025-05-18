[Flags]
namespace NinjaTrader.Cbi
{
    public enum OnDemandUpdateOptions
    {
        None = 0,
        CommissionRemoveUserAdded = 1,
        CommissionUpdate = 2,
        InstrumentUpdateGeneral = 4,
        InstrumentFutureExpiries = 8,
        InstrumentSymbolMappings = 4,
        InstrumentRemoveUserAdded = 16,
        InstrumentListRemoveUserAdded = 32,
        InstrumentListUpdate = 64,
        RiskRemoveUserAdded = 128,
        RiskUpdate = 256,
        TradingHoursRemoveUserAdded = 512,
        TradingHoursUpdate = 1024
    }
}
