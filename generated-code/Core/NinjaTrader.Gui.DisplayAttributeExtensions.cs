[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class DisplayAttributeExtensions
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetValueSafe method.
        /// </summary>
        /// <param name="displayAttribute">DisplayAttribute</param>
        /// <param name="valueType">DisplayAttributeValue</param>
        /// <returns>String</returns>
        public String GetValueSafe(DisplayAttribute displayAttribute, DisplayAttributeValue valueType);
        #endregion
    }
}
