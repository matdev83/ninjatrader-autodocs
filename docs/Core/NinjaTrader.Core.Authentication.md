# Authentication

Namespace: `NinjaTrader.Core`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `CancellationTokenSource` (System.Threading.CancellationTokenSource)

## Methods
- `GetShortGrantCode(string accessToken, bool useDevEnvironment)` : System.Threading.Tasks.Task<string>
- `QueueAccessTokenRenewal(System.TimeSpan expSpan, NinjaTrader.Cbi.TradovateOptions connectOptions, System.Threading.CancellationToken cancellationToken, string tokenToRenew, NinjaTrader.Cbi.AuthenticatedUser authenticatedUser)` : void
- `UpdateTokens(NinjaTrader.Cbi.TradovateOptions connectOptions, string accessToken, string mdAccessToken)` : void
