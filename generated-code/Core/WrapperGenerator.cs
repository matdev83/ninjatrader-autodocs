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
        public String WrapperRegionHeader { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetIndicatorFileNoWrapper method.
        /// </summary>
        /// <param name="fileContents">String</param>
        /// <returns>String</returns>
        public String GetIndicatorFileNoWrapper(String fileContents);
        /// <summary>
        /// GetIndexOfWrapperStart method.
        /// </summary>
        /// <param name="fileContents">String</param>
        /// <returns>Int32</returns>
        public Int32 GetIndexOfWrapperStart(String fileContents);
        /// <summary>
        /// Generate method.
        /// </summary>
        /// <param name="fileContents">String</param>
        /// <returns>String</returns>
        public String Generate(String fileContents);
        /// <summary>
        /// GenerateFooter method.
        /// </summary>
        /// <param name="fileContents">String</param>
        /// <returns>String</returns>
        public String GenerateFooter(String fileContents);
        /// <summary>
        /// GenerateFromCollection method.
        /// </summary>
        /// <param name="fileContents">Collection`1</param>
        /// <returns>String</returns>
        public String GenerateFromCollection(Collection<String> fileContents);
        /// <summary>
        /// RegenerateWrapper method.
        /// </summary>
        /// <param name="fileName">String</param>
        /// <returns>Boolean</returns>
        public Boolean RegenerateWrapper(String fileName);
        #endregion
    }
}
