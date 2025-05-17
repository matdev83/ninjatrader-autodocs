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
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Nickname.
        /// </summary>
        [DataMember]
        public String Nickname { get; set; }
        /// <summary>
        /// Gets or sets the TaskCompletionSource.
        /// </summary>
        [DataMember]
        public TaskCompletionSource<String> TaskCompletionSource { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
