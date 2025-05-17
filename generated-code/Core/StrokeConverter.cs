[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class StrokeConverter : ExpandableObjectConverter
    {
        #region Properties
        #endregion
        #region Methods
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
