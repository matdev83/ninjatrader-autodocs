[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class GainOptions : ConnectOptions
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
        /// Gets or sets the G2Aos.
        /// </summary>
        [DataMember]
        public String[] G2Aos { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
