[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Authentication
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CancellationTokenSource.
        /// </summary>
        [DataMember]
        public System.Threading.CancellationTokenSource CancellationTokenSource { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Authenticate method.
        /// </summary>
        /// <param name="connectOptions">NinjaTrader.Cbi.TradovateOptions</param>
        /// <param name="pTicket">string</param>
        /// <param name="recaptchaValue">string</param>
        /// <param name="cancellationToken">System.Threading.CancellationToken</param>
        /// <returns>System.Threading.Tasks.Task<System.ValueTuple<NinjaTrader.Adapter.AccessTokenResult, bool, bool, bool, bool>></returns>
        public System.Threading.Tasks.Task<System.ValueTuple<NinjaTrader.Adapter.AccessTokenResult, bool, bool, bool, bool>> Authenticate(NinjaTrader.Cbi.TradovateOptions connectOptions, string pTicket, string recaptchaValue, System.Threading.CancellationToken cancellationToken)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CheckAccounts method.
        /// </summary>
        /// <param name="connectOptions">NinjaTrader.Cbi.TradovateOptions</param>
        /// <param name="accessToken">string</param>
        /// <param name="connection">NinjaTrader.Cbi.IConnection</param>
        /// <returns>System.Threading.Tasks.Task<System.ValueTuple<bool, string, bool, bool>></returns>
        public System.Threading.Tasks.Task<System.ValueTuple<bool, string, bool, bool>> CheckAccounts(NinjaTrader.Cbi.TradovateOptions connectOptions, string accessToken, NinjaTrader.Cbi.IConnection connection)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAccessToken method.
        /// </summary>
        /// <param name="connectOptions">NinjaTrader.Cbi.TradovateOptions</param>
        /// <param name="cancellationToken">System.Threading.CancellationToken</param>
        /// <param name="pTicket">string</param>
        /// <param name="recaptchaValue">string</param>
        /// <returns>System.Threading.Tasks.Task<System.ValueTuple<bool, NinjaTrader.Adapter.AccessTokenResult>></returns>
        public System.Threading.Tasks.Task<System.ValueTuple<bool, NinjaTrader.Adapter.AccessTokenResult>> GetAccessToken(NinjaTrader.Cbi.TradovateOptions connectOptions, System.Threading.CancellationToken cancellationToken, string pTicket, string recaptchaValue)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetShortGrantCode method.
        /// </summary>
        /// <param name="accessToken">string</param>
        /// <param name="useDevEnvironment">bool</param>
        /// <returns>System.Threading.Tasks.Task<string></returns>
        public System.Threading.Tasks.Task<string> GetShortGrantCode(string accessToken, bool useDevEnvironment)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueueAccessTokenRenewal method.
        /// </summary>
        /// <param name="expSpan">System.TimeSpan</param>
        /// <param name="connectOptions">NinjaTrader.Cbi.TradovateOptions</param>
        /// <param name="cancellationToken">System.Threading.CancellationToken</param>
        /// <param name="tokenToRenew">string</param>
        /// <param name="authenticatedUser">NinjaTrader.Cbi.AuthenticatedUser</param>
        public void QueueAccessTokenRenewal(System.TimeSpan expSpan, NinjaTrader.Cbi.TradovateOptions connectOptions, System.Threading.CancellationToken cancellationToken, string tokenToRenew, NinjaTrader.Cbi.AuthenticatedUser authenticatedUser)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateTokens method.
        /// </summary>
        /// <param name="connectOptions">NinjaTrader.Cbi.TradovateOptions</param>
        /// <param name="accessToken">string</param>
        /// <param name="mdAccessToken">string</param>
        public void UpdateTokens(NinjaTrader.Cbi.TradovateOptions connectOptions, string accessToken, string mdAccessToken)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
