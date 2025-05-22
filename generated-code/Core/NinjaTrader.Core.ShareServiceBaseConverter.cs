[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class ShareServiceBaseConverter : System.ComponentModel.TypeConverter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetProperties method.
        /// </summary>
        /// <param name="context">System.ComponentModel.ITypeDescriptorContext</param>
        /// <param name="value">object</param>
        /// <param name="attributes">System.Attribute[]</param>
        /// <returns>System.ComponentModel.PropertyDescriptorCollection</returns>
        public System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes)
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
