[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Trade
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Commission.
        /// </summary>
        [DataMember]
        public Double Commission { get; set; }
        /// <summary>
        /// Gets or sets the Entry.
        /// </summary>
        [DataMember]
        public Execution Entry { get; set; }
        /// <summary>
        /// Gets or sets the EntryEfficiency.
        /// </summary>
        [DataMember]
        public Double EntryEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the Exit.
        /// </summary>
        [DataMember]
        public Execution Exit { get; set; }
        /// <summary>
        /// Gets or sets the ExitEfficiency.
        /// </summary>
        [DataMember]
        public Double ExitEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the Fee.
        /// </summary>
        [DataMember]
        public Double Fee { get; set; }
        /// <summary>
        /// Gets or sets the MaeCurrency.
        /// </summary>
        [DataMember]
        public Double MaeCurrency { get; set; }
        /// <summary>
        /// Gets or sets the MaePercent.
        /// </summary>
        [DataMember]
        public Double MaePercent { get; set; }
        /// <summary>
        /// Gets or sets the MaePoints.
        /// </summary>
        [DataMember]
        public Double MaePoints { get; set; }
        /// <summary>
        /// Gets or sets the MaeTicks.
        /// </summary>
        [DataMember]
        public Double MaeTicks { get; set; }
        /// <summary>
        /// Gets or sets the MaePips.
        /// </summary>
        [DataMember]
        public Double MaePips { get; set; }
        /// <summary>
        /// Gets or sets the MfeCurrency.
        /// </summary>
        [DataMember]
        public Double MfeCurrency { get; set; }
        /// <summary>
        /// Gets or sets the MfePercent.
        /// </summary>
        [DataMember]
        public Double MfePercent { get; set; }
        /// <summary>
        /// Gets or sets the MfePoints.
        /// </summary>
        [DataMember]
        public Double MfePoints { get; set; }
        /// <summary>
        /// Gets or sets the MfePips.
        /// </summary>
        [DataMember]
        public Double MfePips { get; set; }
        /// <summary>
        /// Gets or sets the MfeTicks.
        /// </summary>
        [DataMember]
        public Double MfeTicks { get; set; }
        /// <summary>
        /// Gets or sets the ProfitCurrency.
        /// </summary>
        [DataMember]
        public Double ProfitCurrency { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPercent.
        /// </summary>
        [DataMember]
        public Double ProfitPercent { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPips.
        /// </summary>
        [DataMember]
        public Double ProfitPips { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPoints.
        /// </summary>
        [DataMember]
        public Double ProfitPoints { get; set; }
        /// <summary>
        /// Gets or sets the ProfitTicks.
        /// </summary>
        [DataMember]
        public Double ProfitTicks { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the TotalEfficiency.
        /// </summary>
        [DataMember]
        public Double TotalEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the TradeNumber.
        /// </summary>
        [DataMember]
        public Int32 TradeNumber { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
