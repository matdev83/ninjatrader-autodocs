[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ImportTypes
{
    public partial class TextImportType : ImportType
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EndOfBarTimestamps.
        /// </summary>
        [DataMember]
        public Boolean EndOfBarTimestamps { get; set; }
        /// <summary>
        /// Gets or sets the FileNames.
        /// </summary>
        [DataMember]
        public String[] FileNames { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
