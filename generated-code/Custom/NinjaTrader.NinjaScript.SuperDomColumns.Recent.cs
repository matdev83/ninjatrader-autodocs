[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.SuperDomColumns
{
    public partial class Recent : SuperDomColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DisplayType.
        /// </summary>
        [DataMember]
        public RecentDisplayType DisplayType { get; set; }
        /// <summary>
        /// Gets or sets the ResetWhen.
        /// </summary>
        [DataMember]
        public RecentResetWhen ResetWhen { get; set; }
        /// <summary>
        /// Gets or sets the ResetTolerance.
        /// </summary>
        [DataMember]
        public Int32 ResetTolerance { get; set; }
        /// <summary>
        /// Gets or sets the AskBackColor.
        /// </summary>
        [DataMember]
        public Brush AskBackColor { get; set; }
        /// <summary>
        /// Gets or sets the AskBackgroundBrushSerialize.
        /// </summary>
        [DataMember]
        public String AskBackgroundBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the AskForeColor.
        /// </summary>
        [DataMember]
        public Brush AskForeColor { get; set; }
        /// <summary>
        /// Gets or sets the AskForeColorSerialize.
        /// </summary>
        [DataMember]
        public String AskForeColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BidBackColor.
        /// </summary>
        [DataMember]
        public Brush BidBackColor { get; set; }
        /// <summary>
        /// Gets or sets the BidBackgroundBrushSerialize.
        /// </summary>
        [DataMember]
        public String BidBackgroundBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BidForeColor.
        /// </summary>
        [DataMember]
        public Brush BidForeColor { get; set; }
        /// <summary>
        /// Gets or sets the BidForeColorSerialize.
        /// </summary>
        [DataMember]
        public String BidForeColorSerialize { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnColumnLabelClicked method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">MouseButtonEventArgs</param>
        public Void OnColumnLabelClicked(Object sender, MouseButtonEventArgs e);
        #endregion
    }
}
