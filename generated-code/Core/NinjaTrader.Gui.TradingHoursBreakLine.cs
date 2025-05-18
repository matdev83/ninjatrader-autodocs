[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class TradingHoursBreakLine : Stroke
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
        /// <param name="stroke">Stroke</param>
        public Void CopyTo(Stroke stroke);
        #endregion
    }
}
