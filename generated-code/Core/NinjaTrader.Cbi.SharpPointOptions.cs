[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SharpPointOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public string AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public string Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        [DataMember]
        public string Key { get; set; }
        /// <summary>
        /// Gets or sets the Server.
        /// </summary>
        [DataMember]
        public string Server { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public int Port { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
