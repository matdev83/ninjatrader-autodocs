namespace NinjaTrader.NinjaScript
{
    public enum StartBehavior
    {
        AdoptAccountPosition = 0,
        ImmediatelySubmit = 1,
        ImmediatelySubmitSynchronizeAccount = 2,
        WaitUntilFlat = 3,
        WaitUntilFlatSynchronizeAccount = 4
    }
}
