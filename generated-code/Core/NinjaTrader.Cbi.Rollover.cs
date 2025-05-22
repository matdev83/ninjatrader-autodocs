[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Rollover : System.IEquatable<NinjaTrader.Cbi.Rollover>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ContractMonth.
        /// </summary>
        [DataMember]
        public System.DateTime ContractMonth { get; set; }
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public System.DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the IsRiskManagementOnly.
        /// </summary>
        [DataMember]
        public bool IsRiskManagementOnly { get; set; }
        /// <summary>
        /// Gets or sets the Offset.
        /// </summary>
        [DataMember]
        public double Offset { get; set; }
        /// <summary>
        /// Gets or sets the WasEdited.
        /// </summary>
        [DataMember]
        public bool WasEdited { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NinjaTrader.Cbi.Rollover</param>
        /// <returns>bool</returns>
        public bool Equals(NinjaTrader.Cbi.Rollover other)
        {
            // Method implementation goes here
        }
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
