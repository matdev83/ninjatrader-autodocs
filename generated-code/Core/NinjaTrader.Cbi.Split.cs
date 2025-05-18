[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Split : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the Factor.
        /// </summary>
        [DataMember]
        public Double Factor { get; set; }
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
