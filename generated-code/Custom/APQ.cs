[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.SuperDomColumns
{
    public partial class APQ : SuperDomColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BackColor.
        /// </summary>
        [DataMember]
        public Brush BackColor { get; set; }
        /// <summary>
        /// Gets or sets the BackgroundBrushSerialize.
        /// </summary>
        [DataMember]
        public String BackgroundBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ForeColor.
        /// </summary>
        [DataMember]
        public Brush ForeColor { get; set; }
        /// <summary>
        /// Gets or sets the ForeColorSerialize.
        /// </summary>
        [DataMember]
        public String ForeColorSerialize { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
