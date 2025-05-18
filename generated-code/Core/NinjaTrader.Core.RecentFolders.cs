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
        /// <param name="elementName">String</param>
        /// <param name="defaultFolder">String</param>
        /// <returns>String</returns>
        public String GetRecentFolder(String elementName, String defaultFolder);
        /// <summary>
        /// SetRecentFolder method.
        /// </summary>
        /// <param name="elementName">String</param>
        /// <param name="selectedFolder">String</param>
        public Void SetRecentFolder(String elementName, String selectedFolder);
        #endregion
    }
}
