[Serializable]
[DataContract]
namespace NinjaTrader.Code
{
    public partial class Output
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="message">String</param>
        /// <param name="outputTab">PrintTo</param>
        public Void Process(String message, PrintTo outputTab);
        /// <summary>
        /// Reset method.
        /// </summary>
        /// <param name="outputTab">PrintTo</param>
        public Void Reset(PrintTo outputTab);
        #endregion
    }
}
