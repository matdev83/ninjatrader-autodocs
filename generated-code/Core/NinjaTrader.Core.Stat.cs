[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Stat
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Average method.
        /// </summary>
        /// <param name="collection">ICollection`1</param>
        /// <returns>Double</returns>
        public Double Average(ICollection<Double> collection);
        /// <summary>
        /// Gcd method.
        /// </summary>
        /// <param name="a">Double</param>
        /// <param name="b">Double</param>
        /// <returns>Double</returns>
        public Double Gcd(Double a, Double b);
        /// <summary>
        /// StdDev method.
        /// </summary>
        /// <param name="values">Double[]</param>
        /// <param name="maxIdx">Int32</param>
        /// <returns>Double</returns>
        public Double StdDev(Double[] values, Int32 maxIdx);
        /// <summary>
        /// Ulcer method.
        /// </summary>
        /// <param name="values">Double[]</param>
        /// <param name="maxIdx">Int32</param>
        /// <returns>Double</returns>
        public Double Ulcer(Double[] values, Int32 maxIdx);
        /// <summary>
        /// TargetDownsideDeviation method.
        /// </summary>
        /// <param name="values">Double[]</param>
        /// <param name="maxIdx">Int32</param>
        /// <param name="targetReturn">Double</param>
        /// <returns>Double</returns>
        public Double TargetDownsideDeviation(Double[] values, Int32 maxIdx, Double targetReturn);
        /// <summary>
        /// StudTP method.
        /// </summary>
        /// <param name="point">Double</param>
        /// <param name="freedom">Double</param>
        /// <returns>Double</returns>
        public Double StudTP(Double point, Double freedom);
        #endregion
    }
}
