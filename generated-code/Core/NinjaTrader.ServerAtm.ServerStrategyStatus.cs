namespace NinjaTrader.ServerAtm
{
    public enum ServerStrategyStatus : int
    {
        ActiveStrategy = 0,
        ExecutionFailed = 1,
        ExecutionFinished = 2,
        ExecutionInterrupted = 3,
        InactiveStrategy = 4,
        NotEnoughLiquidity = 5,
        StoppedByUser = 6
    }
}
