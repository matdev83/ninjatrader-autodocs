[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SimulatorOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public string AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public bool IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the TicksPerSecond.
        /// </summary>
        [DataMember]
        public int TicksPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the TimerMilliseconds.
        /// </summary>
        [DataMember]
        public int TimerMilliseconds { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
