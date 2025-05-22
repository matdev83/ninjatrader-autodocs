[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class NewsRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Filter.
        /// </summary>
        [DataMember]
        public string Filter { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
