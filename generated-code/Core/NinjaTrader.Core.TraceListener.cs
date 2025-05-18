[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class TraceListener : DefaultTraceListener
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Close method.
        /// </summary>
        public Void Close();
        /// <summary>
        /// CloseWriter method.
        /// </summary>
        public Void CloseWriter();
        /// <summary>
        /// TraceAsync method.
        /// </summary>
        /// <param name="func">Func`2</param>
        /// <param name="args">Object</param>
        public Void TraceAsync(Func<Object, String> func, Object args);
        /// <summary>
        /// WriteLine method.
        /// </summary>
        /// <param name="message">String</param>
        public Void WriteLine(String message);
        #endregion
    }
}
