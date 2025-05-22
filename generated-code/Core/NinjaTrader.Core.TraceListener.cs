[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class TraceListener : System.Diagnostics.DefaultTraceListener
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Close method.
        /// </summary>
        public void Close()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CloseWriter method.
        /// </summary>
        public void CloseWriter()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TraceAsync method.
        /// </summary>
        /// <param name="func">System.Func<object, string></param>
        /// <param name="args">object</param>
        public void TraceAsync(System.Func<object, string> func, object args)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// WriteLine method.
        /// </summary>
        /// <param name="message">string</param>
        public void WriteLine(string message)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
