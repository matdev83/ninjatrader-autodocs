[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsResult
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Bars.
        /// </summary>
        [DataMember]
        public Bars Bars { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode.
        /// </summary>
        [DataMember]
        public ErrorCode ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMessage.
        /// </summary>
        [DataMember]
        public String ErrorMessage { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
