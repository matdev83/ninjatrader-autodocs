[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class HdsRecorder
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instruments.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument> Instruments { get; set; }
        /// <summary>
        /// Gets or sets the IsRunning.
        /// </summary>
        [DataMember]
        public bool IsRunning { get; set; }
        /// <summary>
        /// Gets or sets the RunningSince.
        /// </summary>
        [DataMember]
        public System.DateTime RunningSince { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddInstrument method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void AddInstrument(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RemoveInstrument method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void RemoveInstrument(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SaveToXml method.
        /// </summary>
        public void SaveToXml()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Start method.
        /// </summary>
        public void Start()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Stop method.
        /// </summary>
        public void Stop()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
