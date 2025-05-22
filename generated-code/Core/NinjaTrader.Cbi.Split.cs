[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Split : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public System.DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the Factor.
        /// </summary>
        [DataMember]
        public double Factor { get; set; }
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
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
