[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class TSTrendConverter : IndicatorBaseConverter
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
        /// <param name="component">Object</param>
        /// <param name="attrs">Attribute[]</param>
        /// <returns>PropertyDescriptorCollection</returns>
        public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, Object component, Attribute[] attrs);
        #endregion
    }
}
