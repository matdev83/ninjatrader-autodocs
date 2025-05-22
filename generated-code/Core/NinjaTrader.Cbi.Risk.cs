[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Risk : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Risk> All { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrument.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.MasterInstrument, NinjaTrader.Cbi.InstrumentRisk> ByMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrumentsSerializable.
        /// </summary>
        [DataMember]
        public System.String[] MasterInstrumentsSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public int Version { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="risk">NinjaTrader.Cbi.Risk</param>
        public void CopyTo(NinjaTrader.Cbi.Risk risk)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Cbi.Risk</returns>
        public NinjaTrader.Cbi.Risk Get(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Remove method.
        /// </summary>
        public void Remove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Save method.
        /// </summary>
        /// <param name="persist">bool</param>
        public void Save(bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
