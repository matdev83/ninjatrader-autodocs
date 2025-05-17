[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class CotReport
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Field.
        /// </summary>
        [DataMember]
        public CotReportField Field { get; set; }
        /// <summary>
        /// Gets or sets the ReportType.
        /// </summary>
        [DataMember]
        public CotReportType ReportType { get; set; }
        /// <summary>
        /// Gets or sets the SupportedFields.
        /// </summary>
        [DataMember]
        public List<CotReportField> SupportedFields { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="dateTime">DateTime</param>
        /// <returns>Double</returns>
        public Double Calculate(String instrument, DateTime dateTime);
        #endregion
    }
}
