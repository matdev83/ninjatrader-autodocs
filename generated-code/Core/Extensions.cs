[Serializable]
[DataContract]
namespace NinjaTrader.Core.XmlExtensions
{
    public partial class Extensions
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="element">XElement</param>
        /// <param name="child">String</param>
        /// <returns>XElement</returns>
        public XElement Get(XElement element, String child);
        #endregion
    }
}
