[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class CoreEnumConverter : System.ComponentModel.EnumConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ConvertFrom method.
        /// </summary>
        /// <param name="context">System.ComponentModel.ITypeDescriptorContext</param>
        /// <param name="culture">System.Globalization.CultureInfo</param>
        /// <param name="value">object</param>
        /// <returns>object</returns>
        public object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ConvertTo method.
        /// </summary>
        /// <param name="context">System.ComponentModel.ITypeDescriptorContext</param>
        /// <param name="culture">System.Globalization.CultureInfo</param>
        /// <param name="value">object</param>
        /// <param name="destinationType">System.Type</param>
        /// <returns>object</returns>
        public object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ConvertToString method.
        /// </summary>
        /// <param name="value">System.Enum</param>
        /// <returns>string</returns>
        public string ConvertToString(System.Enum value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetValues method.
        /// </summary>
        /// <param name="enumType">System.Type</param>
        /// <param name="culture">System.Globalization.CultureInfo</param>
        /// <returns>System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Enum, string>></returns>
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Enum, string>> GetValues(System.Type enumType, System.Globalization.CultureInfo culture)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetValues method.
        /// </summary>
        /// <param name="enumType">System.Type</param>
        /// <returns>System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Enum, string>></returns>
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Enum, string>> GetValues(System.Type enumType)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
