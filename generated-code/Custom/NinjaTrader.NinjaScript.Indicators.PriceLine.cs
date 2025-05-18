[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class PriceLine : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AskLine.
        /// </summary>
        [DataMember]
        public Double AskLine { get; set; }
        /// <summary>
        /// Gets or sets the BidLine.
        /// </summary>
        [DataMember]
        public Double BidLine { get; set; }
        /// <summary>
        /// Gets or sets the LastLine.
        /// </summary>
        [DataMember]
        public Double LastLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowAskLine.
        /// </summary>
        [DataMember]
        public Boolean ShowAskLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowBidLine.
        /// </summary>
        [DataMember]
        public Boolean ShowBidLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowLastLine.
        /// </summary>
        [DataMember]
        public Boolean ShowLastLine { get; set; }
        /// <summary>
        /// Gets or sets the AskLineLength.
        /// </summary>
        [DataMember]
        public Int32 AskLineLength { get; set; }
        /// <summary>
        /// Gets or sets the BidLineLength.
        /// </summary>
        [DataMember]
        public Int32 BidLineLength { get; set; }
        /// <summary>
        /// Gets or sets the LastLineLength.
        /// </summary>
        [DataMember]
        public Int32 LastLineLength { get; set; }
        /// <summary>
        /// Gets or sets the AskStroke.
        /// </summary>
        [DataMember]
        public Stroke AskStroke { get; set; }
        /// <summary>
        /// Gets or sets the BidStroke.
        /// </summary>
        [DataMember]
        public Stroke BidStroke { get; set; }
        /// <summary>
        /// Gets or sets the LastStroke.
        /// </summary>
        [DataMember]
        public Stroke LastStroke { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        /// <summary>
        /// OnRenderTargetChanged method.
        /// </summary>
        public Void OnRenderTargetChanged();
        #endregion
    }
}
