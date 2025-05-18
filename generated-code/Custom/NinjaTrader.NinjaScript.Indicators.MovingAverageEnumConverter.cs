[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MovingAverageEnumConverter : TypeConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetStandardValues method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>StandardValuesCollection</returns>
        public StandardValuesCollection GetStandardValues(ITypeDescriptorContext context);
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
        /// CanConvertFrom method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="sourceType">Type</param>
        /// <returns>Boolean</returns>
        public Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
        /// <summary>
        /// CanConvertTo method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="destinationType">Type</param>
        /// <returns>Boolean</returns>
        public Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType);
        /// <summary>
        /// GetStandardValuesExclusive method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>Boolean</returns>
        public Boolean GetStandardValuesExclusive(ITypeDescriptorContext context);
        /// <summary>
        /// GetStandardValuesSupported method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>Boolean</returns>
        public Boolean GetStandardValuesSupported(ITypeDescriptorContext context);
        #endregion
    }
}
