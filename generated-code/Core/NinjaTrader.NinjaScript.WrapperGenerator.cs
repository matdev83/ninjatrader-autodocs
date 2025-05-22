[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class WrapperGenerator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the WrapperRegionHeader.
        /// </summary>
        [DataMember]
        public string WrapperRegionHeader { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetIndicatorFileNoWrapper method.
        /// </summary>
        /// <param name="fileContents">string</param>
        /// <returns>string</returns>
        public string GetIndicatorFileNoWrapper(string fileContents)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetIndexOfWrapperStart method.
        /// </summary>
        /// <param name="fileContents">string</param>
        /// <returns>int</returns>
        public int GetIndexOfWrapperStart(string fileContents)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Generate method.
        /// </summary>
        /// <param name="fileContents">string</param>
        /// <returns>string</returns>
        public string Generate(string fileContents)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GenerateFooter method.
        /// </summary>
        /// <param name="fileContents">string</param>
        /// <returns>string</returns>
        public string GenerateFooter(string fileContents)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GenerateFromCollection method.
        /// </summary>
        /// <param name="fileContents">System.Collections.ObjectModel.Collection<string></param>
        /// <returns>string</returns>
        public string GenerateFromCollection(System.Collections.ObjectModel.Collection<string> fileContents)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RegenerateWrapper method.
        /// </summary>
        /// <param name="fileName">string</param>
        /// <returns>bool</returns>
        public bool RegenerateWrapper(string fileName)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
