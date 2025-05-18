[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class Extensions
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// FindAll method.
        /// </summary>
        /// <param name="parent">DependencyObject</param>
        /// <param name="automationId">String</param>
        /// <returns>DependencyObject[]</returns>
        public DependencyObject[] FindAll(DependencyObject parent, String automationId);
        /// <summary>
        /// FindFirst method.
        /// </summary>
        /// <param name="parent">DependencyObject</param>
        /// <param name="automationId">String</param>
        /// <returns>DependencyObject</returns>
        public DependencyObject FindFirst(DependencyObject parent, String automationId);
        #endregion
    }
}
