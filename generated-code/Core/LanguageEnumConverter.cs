[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class LanguageEnumConverter : CoreEnumConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ConvertTo method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="culture">CultureInfo</param>
        /// <param name="value">Object</param>
        /// <param name="destinationType">Type</param>
        /// <returns>Object</returns>
        public Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType);
        #endregion
    }
}
