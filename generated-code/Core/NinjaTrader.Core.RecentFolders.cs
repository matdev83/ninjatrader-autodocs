[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class RecentFolders
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetRecentFolder method.
        /// </summary>
        /// <param name="elementName">string</param>
        /// <param name="defaultFolder">string</param>
        /// <returns>string</returns>
        public string GetRecentFolder(string elementName, string defaultFolder)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetRecentFolder method.
        /// </summary>
        /// <param name="elementName">string</param>
        /// <param name="selectedFolder">string</param>
        public void SetRecentFolder(string elementName, string selectedFolder)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
