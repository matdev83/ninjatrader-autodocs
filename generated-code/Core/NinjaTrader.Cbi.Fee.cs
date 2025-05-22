[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Fee : NinjaTrader.Cbi.ISnapShotSerializable
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
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Fee> All { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrument.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.MasterInstrument, double> ByMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ByMasterInstrumentSerializable.
        /// </summary>
        [DataMember]
        public System.String[] ByMasterInstrumentSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Generic.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, double> Generic { get; set; }
        /// <summary>
        /// Gets or sets the GenericSerializable.
        /// </summary>
        [DataMember]
        public System.String[] GenericSerializable { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="fee">NinjaTrader.Cbi.Fee</param>
        public void CopyTo(NinjaTrader.Cbi.Fee fee)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Cbi.Fee</returns>
        public NinjaTrader.Cbi.Fee Get(string name)
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
