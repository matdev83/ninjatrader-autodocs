    public enum StatusCode
    {
        Success = 0,
        Subscribed = 1,
        Dropped = 2,
        Update = 3,
        Disconnected = 4,
        Failure = 101,
        AccessDenied = 103,
        NotFound = 104,
        OutsideAllowedRange = 105,
        InvalidParams = 106,
        ActiveRequestsLimitViolation = 107,
        SubscriptionLimitViolation = 108,
        RequestRateLimitViolation = 109
    }
