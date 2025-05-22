[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class PriceLevelTypeConverter : System.ComponentModel.TypeConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetProperties method.
        /// </summary>
        /// <param name="context">System.ComponentModel.ITypeDescriptorContext</param>
        /// <param name="component">object</param>
        /// <param name="attrs">System.Attribute[]</param>
        /// <returns>System.ComponentModel.PropertyDescriptorCollection</returns>
        public System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object component, System.Attribute[] attrs)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetPropertiesSupported method.
        /// </summary>
        /// <param name="context">System.ComponentModel.ITypeDescriptorContext</param>
        /// <returns>bool</returns>
        public bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
