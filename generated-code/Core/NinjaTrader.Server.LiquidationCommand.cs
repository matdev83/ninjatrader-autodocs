namespace NinjaTrader.Server
{
    public enum LiquidationCommand : int
    {
        AccountLiquidationStateResponse = 1,
        ServerLiquidationStateRequest = 2,
        ServerLiquidationStateResponse = 3,
        SetServerLiquidationState = 4,
        SetAccountLiquidationState = 5
    }
}
