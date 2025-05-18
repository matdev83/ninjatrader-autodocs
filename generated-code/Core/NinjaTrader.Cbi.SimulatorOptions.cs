[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SimulatorOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public String AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public Boolean IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the TicksPerSecond.
        /// </summary>
        [DataMember]
        public Int32 TicksPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the TimerMilliseconds.
        /// </summary>
        [DataMember]
        public Int32 TimerMilliseconds { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
