namespace NinjaTrader.NinjaScript
{
    public enum State : int
    {
        Undefined = 0,
        SetDefaults = 1,
        Configure = 2,
        Active = 3,
        DataLoaded = 4,
        Historical = 5,
        Transition = 6,
        Realtime = 7,
        Terminated = 8,
        Finalized = 9
    }
}
