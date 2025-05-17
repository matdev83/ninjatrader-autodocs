[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class InstrumentList : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsWebOnly.
        /// </summary>
        [DataMember]
        public Boolean IsWebOnly { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public Int32 Version { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<InstrumentList> All { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the Instruments.
        /// </summary>
        [DataMember]
        public Collection<Instrument> Instruments { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="instrumentList">InstrumentList</param>
        public Void CopyTo(InstrumentList instrumentList);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>InstrumentList</returns>
        public InstrumentList DbGet(Int64 id);
        /// <summary>
        /// DbPersist method.
        /// </summary>
        public Void DbPersist();
        /// <summary>
        /// DbPersist method.
        /// </summary>
        /// <param name="raiseEvent">Boolean</param>
        public Void DbPersist(Boolean raiseEvent);
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// GetInstruments method.
        /// </summary>
        /// <param name="instrumentOrInstrumentList">String</param>
        /// <returns>Collection`1</returns>
        public Collection<Instrument> GetInstruments(String instrumentOrInstrumentList);
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <returns>InstrumentList</returns>
        public InstrumentList DbGet(String name, Boolean forceDbQuery);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
