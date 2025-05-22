[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class RepositoryReloadedEventHandler : System.MulticastDelegate
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Invoke method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Data.RepositoryReloadedEventArgs</param>
        public void Invoke(object sender, NinjaTrader.Data.RepositoryReloadedEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BeginInvoke method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Data.RepositoryReloadedEventArgs</param>
        /// <param name="callback">System.AsyncCallback</param>
        /// <param name="object">object</param>
        /// <returns>System.IAsyncResult</returns>
        public System.IAsyncResult BeginInvoke(object sender, NinjaTrader.Data.RepositoryReloadedEventArgs e, System.AsyncCallback callback, object object)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EndInvoke method.
        /// </summary>
        /// <param name="result">System.IAsyncResult</param>
        public void EndInvoke(System.IAsyncResult result)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
