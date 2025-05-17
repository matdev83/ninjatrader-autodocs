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
        public Boolean IsDownloadingData { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetFolderPath method.
        /// </summary>
        /// <param name="type">CotReportType</param>
        /// <returns>String</returns>
        public String GetFolderPath(CotReportType type);
        /// <summary>
        /// GetCotReportNames method.
        /// </summary>
        /// <param name="masterInstrumentName">String</param>
        /// <returns>List`1</returns>
        public List<String> GetCotReportNames(String masterInstrumentName);
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="cotReport">CotReport</param>
        /// <param name="instrument">String</param>
        /// <param name="dateTime">DateTime</param>
        /// <returns>Double</returns>
        public Double Calculate(CotReport cotReport, String instrument, DateTime dateTime);
        #endregion
    }
}
