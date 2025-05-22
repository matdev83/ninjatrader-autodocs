[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class IndicatorSuperDomBase : NinjaTrader.NinjaScript.IndicatorBase, System.ComponentModel.INotifyPropertyChanged, NinjaTrader.Data.IBarsPeriodProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsToLoad.
        /// </summary>
        [DataMember]
        public int BarsToLoad { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public System.DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the DaysBack.
        /// </summary>
        [DataMember]
        public int DaysBack { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the DefaultName.
        /// </summary>
        [DataMember]
        public string DefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorInstance.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.IndicatorBase IndicatorInstance { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorName.
        /// </summary>
        [DataMember]
        public string IndicatorName { get; set; }
        /// <summary>
        /// Gets or sets the IsStableSession.
        /// </summary>
        [DataMember]
        public bool IsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public bool IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the RangeType.
        /// </summary>
        [DataMember]
        public RangeType RangeType { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursInstance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours TradingHoursInstance { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursSerializable.
        /// </summary>
        [DataMember]
        public string TradingHoursSerializable { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaTrader.NinjaScript.NinjaScript</param>
        public void CopyTo(NinjaTrader.NinjaScript.NinjaScript ninjaScript)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
