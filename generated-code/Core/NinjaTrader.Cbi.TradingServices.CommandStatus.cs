namespace NinjaTrader.Cbi.TradingServices
{
    public enum CommandStatus : int
    {
        AtExecution = 0,
        ExecutionRejected = 1,
        ExecutionStopped = 2,
        ExecutionSuspended = 3,
        OnHold = 4,
        Pending = 5,
        PendingExecution = 6,
        Replaced = 7,
        RiskPassed = 8,
        RiskRejected = 9
    }
}
