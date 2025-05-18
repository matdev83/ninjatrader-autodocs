[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class FibonacciPivots : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PivotRangeType.
        /// </summary>
        [DataMember]
        public PivotRange PivotRangeType { get; set; }
        /// <summary>
        /// Gets or sets the Pp.
        /// </summary>
        [DataMember]
        public Series<Double> Pp { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayHlc.
        /// </summary>
        [DataMember]
        public HLCCalculationMode PriorDayHlc { get; set; }
        /// <summary>
        /// Gets or sets the R1.
        /// </summary>
        [DataMember]
        public Series<Double> R1 { get; set; }
        /// <summary>
        /// Gets or sets the R2.
        /// </summary>
        [DataMember]
        public Series<Double> R2 { get; set; }
        /// <summary>
        /// Gets or sets the R3.
        /// </summary>
        [DataMember]
        public Series<Double> R3 { get; set; }
        /// <summary>
        /// Gets or sets the S1.
        /// </summary>
        [DataMember]
        public Series<Double> S1 { get; set; }
        /// <summary>
        /// Gets or sets the S2.
        /// </summary>
        [DataMember]
        public Series<Double> S2 { get; set; }
        /// <summary>
        /// Gets or sets the S3.
        /// </summary>
        [DataMember]
        public Series<Double> S3 { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedClose.
        /// </summary>
        [DataMember]
        public Double UserDefinedClose { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedHigh.
        /// </summary>
        [DataMember]
        public Double UserDefinedHigh { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedLow.
        /// </summary>
        [DataMember]
        public Double UserDefinedLow { get; set; }
        /// <summary>
        /// Gets or sets the Width.
        /// </summary>
        [DataMember]
        public Int32 Width { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
