[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.SuperDomColumns
{
    public partial class ProfitLoss : SuperDomColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BackColor.
        /// </summary>
        [DataMember]
        public Brush BackColor { get; set; }
        /// <summary>
        /// Gets or sets the BackColorSerialize.
        /// </summary>
        [DataMember]
        public String BackColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the NegativeBackColor.
        /// </summary>
        [DataMember]
        public Brush NegativeBackColor { get; set; }
        /// <summary>
        /// Gets or sets the NegativeBackColorSerialize.
        /// </summary>
        [DataMember]
        public String NegativeBackColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the NegativeForeColor.
        /// </summary>
        [DataMember]
        public Brush NegativeForeColor { get; set; }
        /// <summary>
        /// Gets or sets the NegativeForeColorSerialize.
        /// </summary>
        [DataMember]
        public String NegativeForeColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the PositiveBackColor.
        /// </summary>
        [DataMember]
        public Brush PositiveBackColor { get; set; }
        /// <summary>
        /// Gets or sets the PositiveBackColorSerialize.
        /// </summary>
        [DataMember]
        public String PositiveBackColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the PositiveForeColor.
        /// </summary>
        [DataMember]
        public Brush PositiveForeColor { get; set; }
        /// <summary>
        /// Gets or sets the PositiveForeColorSerialize.
        /// </summary>
        [DataMember]
        public String PositiveForeColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the PnlDisplayUnit.
        /// </summary>
        [DataMember]
        public PerformanceUnit PnlDisplayUnit { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
