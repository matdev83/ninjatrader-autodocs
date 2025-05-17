[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AddTradeEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Trade.
        /// </summary>
        [DataMember]
        public Trade Trade { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
