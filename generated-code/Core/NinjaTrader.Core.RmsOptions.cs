[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class RmsOptions : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ExcessPositionMarginLimit.
        /// </summary>
        [DataMember]
        public Double ExcessPositionMarginLimit { get; set; }
        /// <summary>
        /// Gets or sets the MaxAccountLossPercentage.
        /// </summary>
        [DataMember]
        public Double MaxAccountLossPercentage { get; set; }
        /// <summary>
        /// Gets or sets the MaxBidAskSpread.
        /// </summary>
        [DataMember]
        public Int32 MaxBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the MaxLiquidationValue.
        /// </summary>
        [DataMember]
        public Double MaxLiquidationValue { get; set; }
        /// <summary>
        /// Gets or sets the MaxOrderSize.
        /// </summary>
        [DataMember]
        public Int32 MaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public String OnBehalfOf { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">RmsOptions</param>
        public Void CopyTo(RmsOptions options);
        #endregion
    }
}
