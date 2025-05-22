[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class TradingHoursBreakLine : NinjaTrader.Gui.Stroke
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TradingHoursBreakLineVisible.
        /// </summary>
        [DataMember]
        public TradingHoursBreakLineVisible TradingHoursBreakLineVisible { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="stroke">NinjaTrader.Gui.Stroke</param>
        public void CopyTo(NinjaTrader.Gui.Stroke stroke)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
