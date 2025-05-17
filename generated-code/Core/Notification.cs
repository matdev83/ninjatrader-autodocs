[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Notification
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// RaiseNotification method.
        /// </summary>
        /// <param name="e">NotificationEventArgs</param>
        public Void RaiseNotification(NotificationEventArgs e);
        #endregion
    }
}
