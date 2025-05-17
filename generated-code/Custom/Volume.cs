[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.SuperDomColumns
{
    public partial class Volume : SuperDomColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Buys.
        /// </summary>
        [DataMember]
        public ConcurrentDictionary<Double, Int64> Buys { get; set; }
        /// <summary>
        /// Gets or sets the LastVolumes.
        /// </summary>
        [DataMember]
        public ConcurrentDictionary<Double, Int64> LastVolumes { get; set; }
        /// <summary>
        /// Gets or sets the Sells.
        /// </summary>
        [DataMember]
        public ConcurrentDictionary<Double, Int64> Sells { get; set; }
        /// <summary>
        /// Gets or sets the BackColor.
        /// </summary>
        [DataMember]
        public Brush BackColor { get; set; }
        /// <summary>
        /// Gets or sets the BackColorSerialize.
        /// </summary>
        [DataMember]
        public String BackColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BarColor.
        /// </summary>
        [DataMember]
        public Brush BarColor { get; set; }
        /// <summary>
        /// Gets or sets the BarColorSerialize.
        /// </summary>
        [DataMember]
        public String BarColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BuyColor.
        /// </summary>
        [DataMember]
        public Brush BuyColor { get; set; }
        /// <summary>
        /// Gets or sets the BuyColorSerialize.
        /// </summary>
        [DataMember]
        public String BuyColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DisplayText.
        /// </summary>
        [DataMember]
        public Boolean DisplayText { get; set; }
        /// <summary>
        /// Gets or sets the DisplayType.
        /// </summary>
        [DataMember]
        public DisplayType DisplayType { get; set; }
        /// <summary>
        /// Gets or sets the ForeColor.
        /// </summary>
        [DataMember]
        public Brush ForeColor { get; set; }
        /// <summary>
        /// Gets or sets the ForeColorSerialize.
        /// </summary>
        [DataMember]
        public String ForeColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ImmutableBarColor.
        /// </summary>
        [DataMember]
        public Brush ImmutableBarColor { get; set; }
        /// <summary>
        /// Gets or sets the ImmutableBarColorSerialize.
        /// </summary>
        [DataMember]
        public String ImmutableBarColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ImmutableForeColor.
        /// </summary>
        [DataMember]
        public Brush ImmutableForeColor { get; set; }
        /// <summary>
        /// Gets or sets the ImmutableForeColorSerialize.
        /// </summary>
        [DataMember]
        public String ImmutableForeColorSerialize { get; set; }
        /// <summary>
        /// Gets or sets the SellColor.
        /// </summary>
        [DataMember]
        public Brush SellColor { get; set; }
        /// <summary>
        /// Gets or sets the SellColorSerialize.
        /// </summary>
        [DataMember]
        public String SellColorSerialize { get; set; }
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
        /// <summary>
        /// Gets or sets the VolumeType.
        /// </summary>
        [DataMember]
        public VolumeType VolumeType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnRestoreValues method.
        /// </summary>
        public Void OnRestoreValues();
        #endregion
    }
}
