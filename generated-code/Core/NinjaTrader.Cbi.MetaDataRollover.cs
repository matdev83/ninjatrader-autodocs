[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MetaDataRollover : NinjaTrader.Cbi.Rollover
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApiDate.
        /// </summary>
        [DataMember]
        public System.DateTime ApiDate { get; set; }
        /// <summary>
        /// Gets or sets the IsOverridden.
        /// </summary>
        [DataMember]
        public bool IsOverridden { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
