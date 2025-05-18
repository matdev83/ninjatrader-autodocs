[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Risk : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<Risk> All { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrument.
        /// </summary>
        [DataMember]
        public Dictionary<MasterInstrument, InstrumentRisk> ByMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrumentsSerializable.
        /// </summary>
        [DataMember]
        public String[] MasterInstrumentsSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public Int32 Version { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="risk">Risk</param>
        public Void CopyTo(Risk risk);
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Risk</returns>
        public Risk Get(String name);
        /// <summary>
        /// Remove method.
        /// </summary>
        public Void Remove();
        /// <summary>
        /// Save method.
        /// </summary>
        /// <param name="persist">Boolean</param>
        public Void Save(Boolean persist);
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
