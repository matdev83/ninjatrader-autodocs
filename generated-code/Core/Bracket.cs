[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Bracket
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StopLoss.
        /// </summary>
        [DataMember]
        public Double StopLoss { get; set; }
        /// <summary>
        /// Gets or sets the StopStrategy.
        /// </summary>
        [DataMember]
        public StopStrategy StopStrategy { get; set; }
        /// <summary>
        /// Gets or sets the Target.
        /// </summary>
        [DataMember]
        public Double Target { get; set; }
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
