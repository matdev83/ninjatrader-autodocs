[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class CotData
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsDownloadingData.
        /// </summary>
        [DataMember]
        public bool IsDownloadingData { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetFolderPath method.
        /// </summary>
        /// <param name="type">CotReportType</param>
        /// <returns>string</returns>
        public string GetFolderPath(CotReportType type)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetCotReportNames method.
        /// </summary>
        /// <param name="masterInstrumentName">string</param>
        /// <returns>System.Collections.Generic.List<string></returns>
        public System.Collections.Generic.List<string> GetCotReportNames(string masterInstrumentName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="cotReport">NinjaTrader.NinjaScript.CotReport</param>
        /// <param name="instrument">string</param>
        /// <param name="dateTime">System.DateTime</param>
        /// <returns>double</returns>
        public double Calculate(NinjaTrader.NinjaScript.CotReport cotReport, string instrument, System.DateTime dateTime)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
