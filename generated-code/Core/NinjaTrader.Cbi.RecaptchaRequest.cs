[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class RecaptchaRequest
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ClearSubscriptions method.
        /// </summary>
        public Void ClearSubscriptions();
        /// <summary>
        /// RaiseRecaptchaRequest method.
        /// </summary>
        /// <param name="e">RecaptchaRequestEventArgs</param>
        public Void RaiseRecaptchaRequest(RecaptchaRequestEventArgs e);
        #endregion
    }
}
