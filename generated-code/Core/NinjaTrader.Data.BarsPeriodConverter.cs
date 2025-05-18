[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsPeriodConverter : TypeConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetProperties method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <param name="component">Object</param>
        /// <param name="attrs">Attribute[]</param>
        /// <returns>PropertyDescriptorCollection</returns>
        public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object component, Attribute[] attrs);
        /// <summary>
        /// GetPropertiesSupported method.
        /// </summary>
        /// <param name="context">ITypeDescriptorContext</param>
        /// <returns>Boolean</returns>
        public Boolean GetPropertiesSupported(ITypeDescriptorContext context);
        #endregion
    }
}
