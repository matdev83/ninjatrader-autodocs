[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class FxcmOptions : NinjaTrader.Cbi.ConnectOptions, NinjaTrader.Cbi.IFxcmOptions
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
        /// Gets or sets the PinCode.
        /// </summary>
        [DataMember]
        public string PinCode { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public bool UseLocalOcoSimulation { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
