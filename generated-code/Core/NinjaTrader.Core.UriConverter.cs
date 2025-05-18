[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class UriConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ConvertUri method.
        /// </summary>
        /// <param name="uriToConvert">String</param>
        /// <param name="isDev">Boolean</param>
        /// <param name="isBeta">Boolean</param>
        /// <returns>String</returns>
        public String ConvertUri(String uriToConvert, Boolean isDev, Boolean isBeta);
        /// <summary>
        /// ConvertUri method.
        /// </summary>
        /// <param name="uriToConvert">String</param>
        /// <returns>String</returns>
        public String ConvertUri(String uriToConvert);
        #endregion
    }
}
