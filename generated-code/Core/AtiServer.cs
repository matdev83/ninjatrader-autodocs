[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class AtiServer : IDisposable
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Close method.
        /// </summary>
        public Void Close();
        /// <summary>
        /// Connect method.
        /// </summary>
        public Void Connect();
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// SetValue method.
        /// </summary>
        /// <param name="key">String</param>
        /// <param name="value">String</param>
        public Void SetValue(String key, String value);
        #endregion
    }
}
