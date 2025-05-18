[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MetaDataRolloverInstrument
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the ProviderNames.
        /// </summary>
        [DataMember]
        public String[] ProviderNames { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollection.
        /// </summary>
        [DataMember]
        public Collection<MetaDataRollover> RolloverCollection { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
