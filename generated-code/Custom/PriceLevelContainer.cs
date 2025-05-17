[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class PriceLevelContainer : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PriceLevels.
        /// </summary>
        [DataMember]
        public List<PriceLevel> PriceLevels { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// SetAllPriceLevelsRenderTarget method.
        /// </summary>
        public Void SetAllPriceLevelsRenderTarget();
        #endregion
    }
}
