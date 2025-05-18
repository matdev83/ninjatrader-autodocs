[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AddOnBase : NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsSuspended.
        /// </summary>
        [DataMember]
        public Boolean IsSuspended { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// NotifyCreated method.
        /// </summary>
        /// <param name="window">Window</param>
        public Void NotifyCreated(Window window);
        /// <summary>
        /// NotifyDestroyed method.
        /// </summary>
        /// <param name="window">Window</param>
        public Void NotifyDestroyed(Window window);
        /// <summary>
        /// NotifyRestored method.
        /// </summary>
        /// <param name="window">Window</param>
        /// <param name="element">XElement</param>
        public Void NotifyRestored(Window window, XElement element);
        /// <summary>
        /// NotifySaved method.
        /// </summary>
        /// <param name="window">Window</param>
        /// <param name="element">XElement</param>
        public Void NotifySaved(Window window, XElement element);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
