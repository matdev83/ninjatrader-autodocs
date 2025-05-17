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
        public Collection<Instrument> Instruments { get; set; }
        /// <summary>
        /// Gets or sets the IsRunning.
        /// </summary>
        [DataMember]
        public Boolean IsRunning { get; set; }
        /// <summary>
        /// Gets or sets the RunningSince.
        /// </summary>
        [DataMember]
        public DateTime RunningSince { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void AddInstrument(Instrument instrument);
        /// <summary>
        /// RemoveInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void RemoveInstrument(Instrument instrument);
        /// <summary>
        /// SaveToXml method.
        /// </summary>
        public Void SaveToXml();
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
