[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class GainOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the G2Aos.
        /// </summary>
        [DataMember]
        public System.String[] G2Aos { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
