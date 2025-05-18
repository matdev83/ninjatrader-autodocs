[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class PlaybackOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public String AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public Boolean IsDataProviderOnly { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
