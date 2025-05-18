[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MMMEODLongTrade : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MALen.
        /// </summary>
        [DataMember]
        public Int32 MALen { get; set; }
        /// <summary>
        /// Gets or sets the SDMult.
        /// </summary>
        [DataMember]
        public Double SDMult { get; set; }
        /// <summary>
        /// Gets or sets the ATRLen.
        /// </summary>
        [DataMember]
        public Int32 ATRLen { get; set; }
        /// <summary>
        /// Gets or sets the ATRMult.
        /// </summary>
        [DataMember]
        public Double ATRMult { get; set; }
        /// <summary>
        /// Gets or sets the SLATRMult.
        /// </summary>
        [DataMember]
        public Double SLATRMult { get; set; }
        /// <summary>
        /// Gets or sets the LimitOneTradePerDay.
        /// </summary>
        [DataMember]
        public Boolean LimitOneTradePerDay { get; set; }
        /// <summary>
        /// Gets or sets the StartHour.
        /// </summary>
        [DataMember]
        public Int32 StartHour { get; set; }
        /// <summary>
        /// Gets or sets the StartMinute.
        /// </summary>
        [DataMember]
        public Int32 StartMinute { get; set; }
        /// <summary>
        /// Gets or sets the EndHour.
        /// </summary>
        [DataMember]
        public Int32 EndHour { get; set; }
        /// <summary>
        /// Gets or sets the EndMinute.
        /// </summary>
        [DataMember]
        public Int32 EndMinute { get; set; }
        /// <summary>
        /// Gets or sets the QuitHour.
        /// </summary>
        [DataMember]
        public Int32 QuitHour { get; set; }
        /// <summary>
        /// Gets or sets the QuitMinute.
        /// </summary>
        [DataMember]
        public Int32 QuitMinute { get; set; }
        /// <summary>
        /// Gets or sets the LongSun.
        /// </summary>
        [DataMember]
        public Boolean LongSun { get; set; }
        /// <summary>
        /// Gets or sets the LongMon.
        /// </summary>
        [DataMember]
        public Boolean LongMon { get; set; }
        /// <summary>
        /// Gets or sets the LongTue.
        /// </summary>
        [DataMember]
        public Boolean LongTue { get; set; }
        /// <summary>
        /// Gets or sets the LongWed.
        /// </summary>
        [DataMember]
        public Boolean LongWed { get; set; }
        /// <summary>
        /// Gets or sets the LongThu.
        /// </summary>
        [DataMember]
        public Boolean LongThu { get; set; }
        /// <summary>
        /// Gets or sets the LongFri.
        /// </summary>
        [DataMember]
        public Boolean LongFri { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
