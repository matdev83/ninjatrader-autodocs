[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Rollover : IEquatable<Rollover>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ContractMonth.
        /// </summary>
        [DataMember]
        public DateTime ContractMonth { get; set; }
        /// <summary>
        /// Gets or sets the Date.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the IsRiskManagementOnly.
        /// </summary>
        [DataMember]
        public Boolean IsRiskManagementOnly { get; set; }
        /// <summary>
        /// Gets or sets the Offset.
        /// </summary>
        [DataMember]
        public Double Offset { get; set; }
        /// <summary>
        /// Gets or sets the WasEdited.
        /// </summary>
        [DataMember]
        public Boolean WasEdited { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Rollover</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Rollover other);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
