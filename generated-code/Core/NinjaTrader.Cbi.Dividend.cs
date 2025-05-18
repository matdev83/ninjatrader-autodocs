[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Dividend : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [DataMember]
        public Double Amount { get; set; }
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        #endregion
    }
}
