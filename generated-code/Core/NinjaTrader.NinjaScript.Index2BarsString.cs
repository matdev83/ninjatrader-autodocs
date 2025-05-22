[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class Index2BarsString : System.IEquatable<NinjaTrader.NinjaScript.Index2BarsString>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Index.
        /// </summary>
        [DataMember]
        public int Index { get; set; }
        /// <summary>
        /// Gets or sets the BarsString.
        /// </summary>
        [DataMember]
        public string BarsString { get; set; }
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
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.Index2BarsString</param>
        /// <returns>bool</returns>
        public bool Equals(NinjaTrader.NinjaScript.Index2BarsString other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public bool Equals(object obj)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>int</returns>
        public int GetHashCode()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
