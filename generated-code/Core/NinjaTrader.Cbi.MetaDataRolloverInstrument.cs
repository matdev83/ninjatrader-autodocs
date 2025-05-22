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
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the ProviderNames.
        /// </summary>
        [DataMember]
        public System.String[] ProviderNames { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollection.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.MetaDataRollover> RolloverCollection { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
