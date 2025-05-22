namespace NinjaTrader.NinjaScript
{
    public enum AlertRearmType : int
    {
        Never = 0,
        OnTimer = 1,
        OnBarClose = 2,
        OnConditionReversed = 3,
        OnConnect = 4,
        RemoveAlert = 5
    }
}
