[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Transaction
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the Expiration.
        /// </summary>
        [DataMember]
        public DateTime Expiration { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
