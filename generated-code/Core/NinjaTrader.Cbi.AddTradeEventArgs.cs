[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AddTradeEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Trade.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Trade Trade { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
