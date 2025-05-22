[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class RecaptchaRequestEventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Callback.
        /// </summary>
        [DataMember]
        public System.Action<bool, string> Callback { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
