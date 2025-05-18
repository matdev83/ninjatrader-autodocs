namespace NinjaTrader.Cbi
{
    public enum OrderState
    {
        Accepted = 0,
        Cancelled = 1,
        Filled = 2,
        Initialized = 3,
        PartFilled = 4,
        CancelSubmitted = 5,
        ChangeSubmitted = 6,
        Submitted = 7,
        TriggerPending = 8,
        Rejected = 9,
        Working = 10,
        CancelPending = 11,
        ChangePending = 12,
        Suspended = 13,
        AcceptedByRisk = 50,
        Unknown = 99
    }
}
