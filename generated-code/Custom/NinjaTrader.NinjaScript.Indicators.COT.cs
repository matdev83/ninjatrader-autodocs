[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class COT : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Cot1.
        /// </summary>
        [DataMember]
        public Series<Double> Cot1 { get; set; }
        /// <summary>
        /// Gets or sets the Cot2.
        /// </summary>
        [DataMember]
        public Series<Double> Cot2 { get; set; }
        /// <summary>
        /// Gets or sets the Cot3.
        /// </summary>
        [DataMember]
        public Series<Double> Cot3 { get; set; }
        /// <summary>
        /// Gets or sets the Cot4.
        /// </summary>
        [DataMember]
        public Series<Double> Cot4 { get; set; }
        /// <summary>
        /// Gets or sets the Cot5.
        /// </summary>
        [DataMember]
        public Series<Double> Cot5 { get; set; }
        /// <summary>
        /// Gets or sets the Number.
        /// </summary>
        [DataMember]
        public Int32 Number { get; set; }
        /// <summary>
        /// Gets or sets the CotReport1.
        /// </summary>
        [DataMember]
        public CotReport CotReport1 { get; set; }
        /// <summary>
        /// Gets or sets the CotReport2.
        /// </summary>
        [DataMember]
        public CotReport CotReport2 { get; set; }
        /// <summary>
        /// Gets or sets the CotReport3.
        /// </summary>
        [DataMember]
        public CotReport CotReport3 { get; set; }
        /// <summary>
        /// Gets or sets the CotReport4.
        /// </summary>
        [DataMember]
        public CotReport CotReport4 { get; set; }
        /// <summary>
        /// Gets or sets the CotReport5.
        /// </summary>
        [DataMember]
        public CotReport CotReport5 { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation.
        /// </summary>
        [DataMember]
        public LegendLocation LegendLocation { get; set; }
        /// <summary>
        /// Gets or sets the Cot1Serialize.
        /// </summary>
        [DataMember]
        public Int32 Cot1Serialize { get; set; }
        /// <summary>
        /// Gets or sets the Cot2Serialize.
        /// </summary>
        [DataMember]
        public Int32 Cot2Serialize { get; set; }
        /// <summary>
        /// Gets or sets the Cot3Serialize.
        /// </summary>
        [DataMember]
        public Int32 Cot3Serialize { get; set; }
        /// <summary>
        /// Gets or sets the Cot4Serialize.
        /// </summary>
        [DataMember]
        public Int32 Cot4Serialize { get; set; }
        /// <summary>
        /// Gets or sets the Cot5Serialize.
        /// </summary>
        [DataMember]
        public Int32 Cot5Serialize { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
