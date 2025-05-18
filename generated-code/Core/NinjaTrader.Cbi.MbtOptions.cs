[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MbtOptions : ConnectOptions
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
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public Boolean UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the VendorID.
        /// </summary>
        [DataMember]
        public Int32 VendorID { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
