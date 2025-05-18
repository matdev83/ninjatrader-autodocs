[Serializable]
[DataContract]
namespace NinjaTrader.Vendor.Indicators.FXTile
{
    public partial class FXTileControl : UserControl, INotifyPropertyChanged, IComponentConnector, IStyleConnector
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BuyText.
        /// </summary>
        [DataMember]
        public String BuyText { get; set; }
        /// <summary>
        /// Gets or sets the BuyToolTip.
        /// </summary>
        [DataMember]
        public String BuyToolTip { get; set; }
        /// <summary>
        /// Gets or sets the ControlsVisibility.
        /// </summary>
        [DataMember]
        public Visibility ControlsVisibility { get; set; }
        /// <summary>
        /// Gets or sets the SellText.
        /// </summary>
        [DataMember]
        public String SellText { get; set; }
        /// <summary>
        /// Gets or sets the SellToolTip.
        /// </summary>
        [DataMember]
        public String SellToolTip { get; set; }
        /// <summary>
        /// Gets or sets the Trader.
        /// </summary>
        [DataMember]
        public ChartTrader Trader { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Cleanup method.
        /// </summary>
        public Void Cleanup();
        /// <summary>
        /// InitializeComponent method.
        /// </summary>
        public Void InitializeComponent();
        #endregion
    }
}
