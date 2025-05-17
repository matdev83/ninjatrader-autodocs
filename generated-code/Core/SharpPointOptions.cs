[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SharpPointOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public String AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public String BrandName { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public String Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        [DataMember]
        public String Key { get; set; }
        /// <summary>
        /// Gets or sets the Server.
        /// </summary>
        [DataMember]
        public String Server { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public Int32 Port { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
