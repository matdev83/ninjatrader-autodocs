[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Commission : NinjaTrader.Cbi.ISnapShotSerializable
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
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Commission> All { get; set; }
        /// <summary>
        /// Gets or sets the ByInstrumentType.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.InstrumentCommission[] ByInstrumentType { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrument.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.MasterInstrument, NinjaTrader.Cbi.InstrumentCommission> ByMasterInstrument { get; set; }
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
        /// <param name="commission">NinjaTrader.Cbi.Commission</param>
        public void CopyTo(NinjaTrader.Cbi.Commission commission)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetMinimum method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <returns>double</returns>
        public double GetMinimum(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetWithMinimum method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="quantity">int</param>
        /// <returns>double</returns>
        public double GetWithMinimum(NinjaTrader.Cbi.Instrument instrument, int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetWithoutMinimum method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="quantity">int</param>
        /// <returns>double</returns>
        public double GetWithoutMinimum(NinjaTrader.Cbi.Instrument instrument, int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Cbi.Commission</returns>
        public NinjaTrader.Cbi.Commission Get(string name)
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
