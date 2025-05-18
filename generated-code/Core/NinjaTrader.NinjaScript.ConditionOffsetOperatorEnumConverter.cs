[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ConditionOffsetOperatorEnumConverter : EnumConverter
    {
        #region Properties
        #endregion
        #region Methods
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
        /// ConvertTo method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="culture">CultureInfo</param>
        /// <param name="value">Object</param>
        /// <param name="destinationType">Type</param>
        /// <returns>Object</returns>
        public Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType);
        /// <summary>
        /// ConvertFrom method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="culture">CultureInfo</param>
        /// <param name="value">Object</param>
        /// <returns>Object</returns>
        public Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value);
        #endregion
    }
}
