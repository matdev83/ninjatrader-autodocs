[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MbtOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public bool UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the VendorID.
        /// </summary>
        [DataMember]
        public int VendorID { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
