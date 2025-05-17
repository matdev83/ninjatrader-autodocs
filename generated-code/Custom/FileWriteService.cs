[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.AddOns
{
    public partial class FileWriteService
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetInstance method.
        /// </summary>
        /// <returns>FileWriteService</returns>
        public FileWriteService GetInstance();
        /// <summary>
        /// SubmitWrite method.
        /// </summary>
        /// <param name="filePath">String</param>
        /// <param name="content">String</param>
        /// <param name="timestamp">DateTime</param>
        public Void SubmitWrite(String filePath, String content, DateTime timestamp);
        #endregion
    }
}
