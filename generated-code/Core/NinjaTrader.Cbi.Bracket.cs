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
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the StopLoss.
        /// </summary>
        [DataMember]
        public double StopLoss { get; set; }
        /// <summary>
        /// Gets or sets the StopStrategy.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.StopStrategy StopStrategy { get; set; }
        /// <summary>
        /// Gets or sets the Target.
        /// </summary>
        [DataMember]
        public double Target { get; set; }
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
