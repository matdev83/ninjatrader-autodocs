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
        public CancellationTokenSource CancellationTokenSource { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Authenticate method.
        /// </summary>
        /// <param name="connectOptions">TradovateOptions</param>
        /// <param name="pTicket">String</param>
        /// <param name="recaptchaValue">String</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <returns>Task`1</returns>
        public Task<ValueTuple<AccessTokenResult, Boolean, Boolean, Boolean, Boolean>> Authenticate(TradovateOptions connectOptions, String pTicket, String recaptchaValue, CancellationToken cancellationToken);
        /// <summary>
        /// CheckAccounts method.
        /// </summary>
        /// <param name="connectOptions">TradovateOptions</param>
        /// <param name="accessToken">String</param>
        /// <param name="connection">IConnection</param>
        /// <returns>Task`1</returns>
        public Task<ValueTuple<Boolean, String, Boolean, Boolean>> CheckAccounts(TradovateOptions connectOptions, String accessToken, IConnection connection);
        /// <summary>
        /// GetAccessToken method.
        /// </summary>
        /// <param name="connectOptions">TradovateOptions</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <param name="pTicket">String</param>
        /// <param name="recaptchaValue">String</param>
        /// <returns>Task`1</returns>
        public Task<ValueTuple<Boolean, AccessTokenResult>> GetAccessToken(TradovateOptions connectOptions, CancellationToken cancellationToken, String pTicket, String recaptchaValue);
        /// <summary>
        /// GetShortGrantCode method.
        /// </summary>
        /// <param name="accessToken">String</param>
        /// <param name="useDevEnvironment">Boolean</param>
        /// <returns>Task`1</returns>
        public Task<String> GetShortGrantCode(String accessToken, Boolean useDevEnvironment);
        /// <summary>
        /// QueueAccessTokenRenewal method.
        /// </summary>
        /// <param name="expSpan">TimeSpan</param>
        /// <param name="connectOptions">TradovateOptions</param>
        /// <param name="cancellationToken">CancellationToken</param>
        /// <param name="tokenToRenew">String</param>
        /// <param name="authenticatedUser">AuthenticatedUser</param>
        public Void QueueAccessTokenRenewal(TimeSpan expSpan, TradovateOptions connectOptions, CancellationToken cancellationToken, String tokenToRenew, AuthenticatedUser authenticatedUser);
        /// <summary>
        /// UpdateTokens method.
        /// </summary>
        /// <param name="connectOptions">TradovateOptions</param>
        /// <param name="accessToken">String</param>
        /// <param name="mdAccessToken">String</param>
        public Void UpdateTokens(TradovateOptions connectOptions, String accessToken, String mdAccessToken);
        #endregion
    }
}
