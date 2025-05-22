namespace NinjaTrader.ServerAtm
{
    public enum ServerStopLossType : int
    {
        Stop = 0,
        StopLimit = 1,
        TrailingStop = 2,
        TrailingStopLimit = 3,
        AutoBreakeven = 4,
        AutoTrail = 5,
        AutoTrailAutoBreakeven = 6
    }
}
