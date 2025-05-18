[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ZigZagAnchoredVWAP : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ZigZagPercent.
        /// </summary>
        [DataMember]
        public Double ZigZagPercent { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagLookBack.
        /// </summary>
        [DataMember]
        public Int32 ZigZagLookBack { get; set; }
        /// <summary>
        /// Gets or sets the UseHighLow.
        /// </summary>
        [DataMember]
        public Boolean UseHighLow { get; set; }
        /// <summary>
        /// Gets or sets the AnchorBarsBack.
        /// </summary>
        [DataMember]
        public Int32 AnchorBarsBack { get; set; }
        /// <summary>
        /// Gets or sets the SupplyLineColor.
        /// </summary>
        [DataMember]
        public Brush SupplyLineColor { get; set; }
        /// <summary>
        /// Gets or sets the SupplyLineStyle.
        /// </summary>
        [DataMember]
        public DashStyleHelper SupplyLineStyle { get; set; }
        /// <summary>
        /// Gets or sets the SupplyLineWidth.
        /// </summary>
        [DataMember]
        public Int32 SupplyLineWidth { get; set; }
        /// <summary>
        /// Gets or sets the DemandLineColor.
        /// </summary>
        [DataMember]
        public Brush DemandLineColor { get; set; }
        /// <summary>
        /// Gets or sets the DemandLineStyle.
        /// </summary>
        [DataMember]
        public DashStyleHelper DemandLineStyle { get; set; }
        /// <summary>
        /// Gets or sets the DemandLineWidth.
        /// </summary>
        [DataMember]
        public Int32 DemandLineWidth { get; set; }
        /// <summary>
        /// Gets or sets the MinAvwapDistancePct.
        /// </summary>
        [DataMember]
        public Double MinAvwapDistancePct { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// IsPriceAboveAllSupplyAVWAPs method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean IsPriceAboveAllSupplyAVWAPs();
        /// <summary>
        /// IsPriceBelowAllDemandAVWAPs method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean IsPriceBelowAllDemandAVWAPs();
        #endregion
    }
}
