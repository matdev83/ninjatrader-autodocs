[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class CoreEnumConverter : EnumConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ConvertFrom method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="culture">CultureInfo</param>
        /// <param name="value">Object</param>
        /// <returns>Object</returns>
        public Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value);
        /// <summary>
        /// ConvertTo method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="culture">CultureInfo</param>
        /// <param name="value">Object</param>
        /// <param name="destinationType">Type</param>
        /// <returns>Object</returns>
        public Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType);
        /// <summary>
        /// ConvertToString method.
        /// </summary>
        /// <param name="value">Enum</param>
        /// <returns>String</returns>
        public String ConvertToString(Enum value);
        /// <summary>
        /// GetValues method.
        /// </summary>
        /// <param name="enumType">Type</param>
        /// <param name="culture">CultureInfo</param>
        /// <returns>List`1</returns>
        public List<KeyValuePair<Enum, String>> GetValues(Type enumType, CultureInfo culture);
        /// <summary>
        /// GetValues method.
        /// </summary>
        /// <param name="enumType">Type</param>
        /// <returns>List`1</returns>
        public List<KeyValuePair<Enum, String>> GetValues(Type enumType);
        #endregion
    }
}
