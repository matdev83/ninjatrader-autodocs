[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class Index2BarsString : IEquatable<Index2BarsString>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Index.
        /// </summary>
        [DataMember]
        public Int32 Index { get; set; }
        /// <summary>
        /// Gets or sets the BarsString.
        /// </summary>
        [DataMember]
        public String BarsString { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Index2BarsString</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Index2BarsString other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object obj);
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        #endregion
    }
}
