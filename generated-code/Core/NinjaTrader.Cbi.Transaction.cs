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
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the Expiration.
        /// </summary>
        [DataMember]
        public System.DateTime Expiration { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
