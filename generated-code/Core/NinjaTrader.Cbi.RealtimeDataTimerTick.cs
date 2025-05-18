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
        public Int32 RealtimeMilliseconds { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeTickCount.
        /// </summary>
        [DataMember]
        public Int32 RealtimeTickCount { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Tick method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Tick();
        #endregion
    }
}
