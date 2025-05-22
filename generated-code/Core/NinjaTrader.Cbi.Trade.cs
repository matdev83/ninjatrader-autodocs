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
        public double Commission { get; set; }
        /// <summary>
        /// Gets or sets the Entry.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Execution Entry { get; set; }
        /// <summary>
        /// Gets or sets the EntryEfficiency.
        /// </summary>
        [DataMember]
        public double EntryEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the Exit.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Execution Exit { get; set; }
        /// <summary>
        /// Gets or sets the ExitEfficiency.
        /// </summary>
        [DataMember]
        public double ExitEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the Fee.
        /// </summary>
        [DataMember]
        public double Fee { get; set; }
        /// <summary>
        /// Gets or sets the MaeCurrency.
        /// </summary>
        [DataMember]
        public double MaeCurrency { get; set; }
        /// <summary>
        /// Gets or sets the MaePercent.
        /// </summary>
        [DataMember]
        public double MaePercent { get; set; }
        /// <summary>
        /// Gets or sets the MaePoints.
        /// </summary>
        [DataMember]
        public double MaePoints { get; set; }
        /// <summary>
        /// Gets or sets the MaeTicks.
        /// </summary>
        [DataMember]
        public double MaeTicks { get; set; }
        /// <summary>
        /// Gets or sets the MaePips.
        /// </summary>
        [DataMember]
        public double MaePips { get; set; }
        /// <summary>
        /// Gets or sets the MfeCurrency.
        /// </summary>
        [DataMember]
        public double MfeCurrency { get; set; }
        /// <summary>
        /// Gets or sets the MfePercent.
        /// </summary>
        [DataMember]
        public double MfePercent { get; set; }
        /// <summary>
        /// Gets or sets the MfePoints.
        /// </summary>
        [DataMember]
        public double MfePoints { get; set; }
        /// <summary>
        /// Gets or sets the MfePips.
        /// </summary>
        [DataMember]
        public double MfePips { get; set; }
        /// <summary>
        /// Gets or sets the MfeTicks.
        /// </summary>
        [DataMember]
        public double MfeTicks { get; set; }
        /// <summary>
        /// Gets or sets the ProfitCurrency.
        /// </summary>
        [DataMember]
        public double ProfitCurrency { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPercent.
        /// </summary>
        [DataMember]
        public double ProfitPercent { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPips.
        /// </summary>
        [DataMember]
        public double ProfitPips { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPoints.
        /// </summary>
        [DataMember]
        public double ProfitPoints { get; set; }
        /// <summary>
        /// Gets or sets the ProfitTicks.
        /// </summary>
        [DataMember]
        public double ProfitTicks { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the TotalEfficiency.
        /// </summary>
        [DataMember]
        public double TotalEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the TradeNumber.
        /// </summary>
        [DataMember]
        public int TradeNumber { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
