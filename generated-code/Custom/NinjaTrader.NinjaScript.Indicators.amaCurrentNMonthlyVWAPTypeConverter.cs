[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class amaCurrentNMonthlyVWAPTypeConverter : IndicatorBaseConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetPropertiesSupported method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>Boolean</returns>
        public Boolean GetPropertiesSupported(ITypeDescriptorContext context);
        /// <summary>
        /// GetProperties method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="value">Object</param>
        /// <param name="attributes">Attribute[]</param>
        /// <returns>PropertyDescriptorCollection</returns>
        public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object value, Attribute[] attributes);
        #endregion
    }
}
