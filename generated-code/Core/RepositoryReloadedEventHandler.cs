[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class RepositoryReloadedEventHandler : MulticastDelegate
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Invoke method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">RepositoryReloadedEventArgs</param>
        public Void Invoke(Object sender, RepositoryReloadedEventArgs e);
        /// <summary>
        /// BeginInvoke method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">RepositoryReloadedEventArgs</param>
        /// <param name="callback">AsyncCallback</param>
        /// <param name="object">Object</param>
        /// <returns>IAsyncResult</returns>
        public IAsyncResult BeginInvoke(Object sender, RepositoryReloadedEventArgs e, AsyncCallback callback, Object object);
        /// <summary>
        /// EndInvoke method.
        /// </summary>
        /// <param name="result">IAsyncResult</param>
        public Void EndInvoke(IAsyncResult result);
        #endregion
    }
}
