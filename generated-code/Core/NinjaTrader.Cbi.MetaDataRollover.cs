[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MetaDataRollover : Rollover
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApiDate.
        /// </summary>
        [DataMember]
        public DateTime ApiDate { get; set; }
        /// <summary>
        /// Gets or sets the IsOverridden.
        /// </summary>
        [DataMember]
        public Boolean IsOverridden { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
