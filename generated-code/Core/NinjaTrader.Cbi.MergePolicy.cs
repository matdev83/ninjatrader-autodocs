namespace NinjaTrader.Cbi
{
    public enum MergePolicy : int
    {
        DoNotMerge = 0,
        MergeBackAdjusted = 1,
        MergeNonBackAdjusted = 2,
        UseGlobalSettings = 3,
        UseDefault = 4
    }
}
