namespace NinjaTrader.Server
{
    public enum AtmCommand : int
    {
        AddExecution = 0,
        AddOrder = 1,
        AddTarget = 2,
        CloseStrategy = 3,
        NewStrategy = 4,
        ProtectPosition = 5,
        RemoveTarget = 6,
        ReverseStrategy = 7,
        SetOutstandingEntryQuantity = 8,
        SetOutstandingExitQuantity = 9,
        StateChanged = 10,
        SubmitRequest = 11,
        ReverseAtTarget = 12,
        ReverseAtStop = 13
    }
}
