[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MMMMarwoodVWAPPilotSimplified : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AtrLen.
        /// </summary>
        [DataMember]
        public Int32 AtrLen { get; set; }
        /// <summary>
        /// Gets or sets the SlAtrMult.
        /// </summary>
        [DataMember]
        public Double SlAtrMult { get; set; }
        /// <summary>
        /// Gets or sets the TpAtrMult.
        /// </summary>
        [DataMember]
        public Double TpAtrMult { get; set; }
        /// <summary>
        /// Gets or sets the TradeLongs.
        /// </summary>
        [DataMember]
        public Boolean TradeLongs { get; set; }
        /// <summary>
        /// Gets or sets the TradeShorts.
        /// </summary>
        [DataMember]
        public Boolean TradeShorts { get; set; }
        /// <summary>
        /// Gets or sets the LimitOneTradePerDay.
        /// </summary>
        [DataMember]
        public Boolean LimitOneTradePerDay { get; set; }
        /// <summary>
        /// Gets or sets the MaxTradeHour.
        /// </summary>
        [DataMember]
        public Int32 MaxTradeHour { get; set; }
        /// <summary>
        /// Gets or sets the MaxTradeMinute.
        /// </summary>
        [DataMember]
        public Int32 MaxTradeMinute { get; set; }
        /// <summary>
        /// Gets or sets the Day1.
        /// </summary>
        [DataMember]
        public Boolean Day1 { get; set; }
        /// <summary>
        /// Gets or sets the Day2.
        /// </summary>
        [DataMember]
        public Boolean Day2 { get; set; }
        /// <summary>
        /// Gets or sets the Day3.
        /// </summary>
        [DataMember]
        public Boolean Day3 { get; set; }
        /// <summary>
        /// Gets or sets the Day4.
        /// </summary>
        [DataMember]
        public Boolean Day4 { get; set; }
        /// <summary>
        /// Gets or sets the Day5.
        /// </summary>
        [DataMember]
        public Boolean Day5 { get; set; }
        /// <summary>
        /// Gets or sets the Month1.
        /// </summary>
        [DataMember]
        public Boolean Month1 { get; set; }
        /// <summary>
        /// Gets or sets the Month2.
        /// </summary>
        [DataMember]
        public Boolean Month2 { get; set; }
        /// <summary>
        /// Gets or sets the Month3.
        /// </summary>
        [DataMember]
        public Boolean Month3 { get; set; }
        /// <summary>
        /// Gets or sets the Month4.
        /// </summary>
        [DataMember]
        public Boolean Month4 { get; set; }
        /// <summary>
        /// Gets or sets the Month5.
        /// </summary>
        [DataMember]
        public Boolean Month5 { get; set; }
        /// <summary>
        /// Gets or sets the Month6.
        /// </summary>
        [DataMember]
        public Boolean Month6 { get; set; }
        /// <summary>
        /// Gets or sets the Month7.
        /// </summary>
        [DataMember]
        public Boolean Month7 { get; set; }
        /// <summary>
        /// Gets or sets the Month8.
        /// </summary>
        [DataMember]
        public Boolean Month8 { get; set; }
        /// <summary>
        /// Gets or sets the Month9.
        /// </summary>
        [DataMember]
        public Boolean Month9 { get; set; }
        /// <summary>
        /// Gets or sets the Month10.
        /// </summary>
        [DataMember]
        public Boolean Month10 { get; set; }
        /// <summary>
        /// Gets or sets the Month11.
        /// </summary>
        [DataMember]
        public Boolean Month11 { get; set; }
        /// <summary>
        /// Gets or sets the Month12.
        /// </summary>
        [DataMember]
        public Boolean Month12 { get; set; }
        /// <summary>
        /// Gets or sets the Debug.
        /// </summary>
        [DataMember]
        public Boolean Debug { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
