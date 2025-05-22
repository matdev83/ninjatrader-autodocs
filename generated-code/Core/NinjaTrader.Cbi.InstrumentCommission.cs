[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class InstrumentCommission
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public Currency Currency { get; set; }
        /// <summary>
        /// Gets or sets the Fee.
        /// </summary>
        [DataMember]
        public double Fee { get; set; }
        /// <summary>
        /// Gets or sets the Minimum.
        /// </summary>
        [DataMember]
        public double Minimum { get; set; }
        /// <summary>
        /// Gets or sets the PerUnit.
        /// </summary>
        [DataMember]
        public double PerUnit { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
