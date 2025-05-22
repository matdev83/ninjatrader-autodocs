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
        public System.Collections.Generic.List<CotReportField> SupportedFields { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="dateTime">System.DateTime</param>
        /// <returns>double</returns>
        public double Calculate(string instrument, System.DateTime dateTime)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
