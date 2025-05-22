[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class RealtimeDataTimerTick
    {
        #region Properties
        /// <summary>
        /// Gets or sets the RealtimeMilliseconds.
        /// </summary>
        [DataMember]
        public int RealtimeMilliseconds { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeTickCount.
        /// </summary>
        [DataMember]
        public int RealtimeTickCount { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Tick method.
        /// </summary>
        /// <returns>bool</returns>
        public bool Tick()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
