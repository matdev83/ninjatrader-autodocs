[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class IndicatorSuperDomBase : IndicatorBase, INotifyPropertyChanged, IBarsPeriodProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsToLoad.
        /// </summary>
        [DataMember]
        public Int32 BarsToLoad { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the DaysBack.
        /// </summary>
        [DataMember]
        public Int32 DaysBack { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the DefaultName.
        /// </summary>
        [DataMember]
        public String DefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorInstance.
        /// </summary>
        [DataMember]
        public IndicatorBase IndicatorInstance { get; set; }
        /// <summary>
        /// Gets or sets the IndicatorName.
        /// </summary>
        [DataMember]
        public String IndicatorName { get; set; }
        /// <summary>
        /// Gets or sets the IsStableSession.
        /// </summary>
        [DataMember]
        public Boolean IsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public Boolean IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the RangeType.
        /// </summary>
        [DataMember]
        public RangeType RangeType { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursInstance.
        /// </summary>
        [DataMember]
        public TradingHours TradingHoursInstance { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursSerializable.
        /// </summary>
        [DataMember]
        public String TradingHoursSerializable { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        #endregion
    }
}
