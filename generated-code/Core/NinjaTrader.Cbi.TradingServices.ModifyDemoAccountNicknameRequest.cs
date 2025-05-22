[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class ModifyDemoAccountNicknameRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Nickname.
        /// </summary>
        [DataMember]
        public string Nickname { get; set; }
        /// <summary>
        /// Gets or sets the TaskCompletionSource.
        /// </summary>
        [DataMember]
        public System.Threading.Tasks.TaskCompletionSource<string> TaskCompletionSource { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
