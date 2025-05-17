[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.AddOns
{
    public partial class DebuggingServiceServer
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public Int32 Port { get; set; }
        /// <summary>
        /// Gets or sets the IsRunning.
        /// </summary>
        [DataMember]
        public Boolean IsRunning { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Start method.
        /// </summary>
        public Void Start();
        /// <summary>
        /// Stop method.
        /// </summary>
        public Void Stop();
        #endregion
    }
}
