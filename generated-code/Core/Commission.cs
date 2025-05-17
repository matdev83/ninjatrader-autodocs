[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Commission : ISnapShotSerializable
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
        public Collection<Commission> All { get; set; }
        /// <summary>
        /// Gets or sets the ByInstrumentType.
        /// </summary>
        [DataMember]
        public InstrumentCommission[] ByInstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrument.
        /// </summary>
        [DataMember]
        public Dictionary<MasterInstrument, InstrumentCommission> ByMasterInstrument { get; set; }
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
        /// <param name="commission">Commission</param>
        public Void CopyTo(Commission commission);
        /// <summary>
        /// GetMinimum method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <returns>Double</returns>
        public Double GetMinimum(Instrument instrument);
        /// <summary>
        /// GetWithMinimum method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="quantity">Int32</param>
        /// <returns>Double</returns>
        public Double GetWithMinimum(Instrument instrument, Int32 quantity);
        /// <summary>
        /// GetWithoutMinimum method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="quantity">Int32</param>
        /// <returns>Double</returns>
        public Double GetWithoutMinimum(Instrument instrument, Int32 quantity);
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Commission</returns>
        public Commission Get(String name);
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
