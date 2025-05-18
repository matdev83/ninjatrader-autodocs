[Serializable]
[DataContract]
    public partial class TemplateChangedEventHandler : MulticastDelegate
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Invoke method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">TemplateChangedArgs</param>
        public Void Invoke(Object sender, TemplateChangedArgs e);
        /// <summary>
        /// BeginInvoke method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">TemplateChangedArgs</param>
        /// <param name="callback">AsyncCallback</param>
        /// <param name="object">Object</param>
        /// <returns>IAsyncResult</returns>
        public IAsyncResult BeginInvoke(Object sender, TemplateChangedArgs e, AsyncCallback callback, Object object);
        /// <summary>
        /// EndInvoke method.
        /// </summary>
        /// <param name="result">IAsyncResult</param>
        public Void EndInvoke(IAsyncResult result);
        #endregion
    }
