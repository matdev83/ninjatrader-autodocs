[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class InstrumentList : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsWebOnly.
        /// </summary>
        [DataMember]
        public bool IsWebOnly { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public int Version { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.InstrumentList> All { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the Instruments.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument> Instruments { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="instrumentList">NinjaTrader.Cbi.InstrumentList</param>
        public void CopyTo(NinjaTrader.Cbi.InstrumentList instrumentList)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.InstrumentList</returns>
        public NinjaTrader.Cbi.InstrumentList DbGet(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbPersist method.
        /// </summary>
        public void DbPersist()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbPersist method.
        /// </summary>
        /// <param name="raiseEvent">bool</param>
        public void DbPersist(bool raiseEvent)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public void DbRemove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInstruments method.
        /// </summary>
        /// <param name="instrumentOrInstrumentList">string</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument> GetInstruments(string instrumentOrInstrumentList)
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
        /// DbGet method.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="forceDbQuery">bool</param>
        /// <returns>NinjaTrader.Cbi.InstrumentList</returns>
        public NinjaTrader.Cbi.InstrumentList DbGet(string name, bool forceDbQuery)
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
