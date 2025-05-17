[Serializable]
[DataContract]
namespace NinjaTrader.Core.FloatingPoint
{
    public partial class MathExtentions
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// ApproxCompare method.
        /// </summary>
        /// <param name="double1">Double</param>
        /// <param name="double2">Double</param>
        /// <returns>Int32</returns>
        public Int32 ApproxCompare(Double double1, Double double2);
        /// <summary>
        /// ApproxCompare method.
        /// </summary>
        /// <param name="float1">Single</param>
        /// <param name="float2">Single</param>
        /// <returns>Int32</returns>
        public Int32 ApproxCompare(Single float1, Single float2);
        #endregion
    }
}
