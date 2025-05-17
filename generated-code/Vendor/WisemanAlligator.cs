[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class WisemanAlligator : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Jaw.
        /// </summary>
        [DataMember]
        public Series<Double> Jaw { get; set; }
        /// <summary>
        /// Gets or sets the Teeth.
        /// </summary>
        [DataMember]
        public Series<Double> Teeth { get; set; }
        /// <summary>
        /// Gets or sets the Lips.
        /// </summary>
        [DataMember]
        public Series<Double> Lips { get; set; }
        /// <summary>
        /// Gets or sets the JawPeriod.
        /// </summary>
        [DataMember]
        public Int32 JawPeriod { get; set; }
        /// <summary>
        /// Gets or sets the TeethPeriod.
        /// </summary>
        [DataMember]
        public Int32 TeethPeriod { get; set; }
        /// <summary>
        /// Gets or sets the LipsPeriod.
        /// </summary>
        [DataMember]
        public Int32 LipsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the JawOffset.
        /// </summary>
        [DataMember]
        public Int32 JawOffset { get; set; }
        /// <summary>
        /// Gets or sets the TeethOffset.
        /// </summary>
        [DataMember]
        public Int32 TeethOffset { get; set; }
        /// <summary>
        /// Gets or sets the LipsOffset.
        /// </summary>
        [DataMember]
        public Int32 LipsOffset { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
