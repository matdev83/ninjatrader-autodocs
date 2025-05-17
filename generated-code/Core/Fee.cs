[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Fee : ISnapShotSerializable
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
        public Collection<Fee> All { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrument.
        /// </summary>
        [DataMember]
        public Dictionary<MasterInstrument, Double> ByMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrumentSerializable.
        /// </summary>
        [DataMember]
        public String[] ByMasterInstrumentSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Generic.
        /// </summary>
        [DataMember]
        public Dictionary<String, Double> Generic { get; set; }
        /// <summary>
        /// Gets or sets the GenericSerializable.
        /// </summary>
        [DataMember]
        public String[] GenericSerializable { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="fee">Fee</param>
        public Void CopyTo(Fee fee);
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Fee</returns>
        public Fee Get(String name);
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
