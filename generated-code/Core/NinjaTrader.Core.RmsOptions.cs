[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class RmsOptions : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ExcessPositionMarginLimit.
        /// </summary>
        [DataMember]
        public double ExcessPositionMarginLimit { get; set; }
        /// <summary>
        /// Gets or sets the MaxAccountLossPercentage.
        /// </summary>
        [DataMember]
        public double MaxAccountLossPercentage { get; set; }
        /// <summary>
        /// Gets or sets the MaxBidAskSpread.
        /// </summary>
        [DataMember]
        public int MaxBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the MaxLiquidationValue.
        /// </summary>
        [DataMember]
        public double MaxLiquidationValue { get; set; }
        /// <summary>
        /// Gets or sets the MaxOrderSize.
        /// </summary>
        [DataMember]
        public int MaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public string OnBehalfOf { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">NinjaTrader.Core.RmsOptions</param>
        public void CopyTo(NinjaTrader.Core.RmsOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
