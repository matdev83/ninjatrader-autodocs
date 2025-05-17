[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradesPerformanceValues
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AverageEtd.
        /// </summary>
        [DataMember]
        public Double AverageEtd { get; set; }
        /// <summary>
        /// Gets or sets the AverageMae.
        /// </summary>
        [DataMember]
        public Double AverageMae { get; set; }
        /// <summary>
        /// Gets or sets the AverageMfe.
        /// </summary>
        [DataMember]
        public Double AverageMfe { get; set; }
        /// <summary>
        /// Gets or sets the AverageProfit.
        /// </summary>
        [DataMember]
        public Double AverageProfit { get; set; }
        /// <summary>
        /// Gets or sets the CumProfit.
        /// </summary>
        [DataMember]
        public Double CumProfit { get; set; }
        /// <summary>
        /// Gets or sets the Drawdown.
        /// </summary>
        [DataMember]
        public Double Drawdown { get; set; }
        /// <summary>
        /// Gets or sets the LargestLoser.
        /// </summary>
        [DataMember]
        public Double LargestLoser { get; set; }
        /// <summary>
        /// Gets or sets the LargestWinner.
        /// </summary>
        [DataMember]
        public Double LargestWinner { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPerMonth.
        /// </summary>
        [DataMember]
        public Double ProfitPerMonth { get; set; }
        /// <summary>
        /// Gets or sets the StdDev.
        /// </summary>
        [DataMember]
        public Double StdDev { get; set; }
        /// <summary>
        /// Gets or sets the Turnaround.
        /// </summary>
        [DataMember]
        public Double Turnaround { get; set; }
        /// <summary>
        /// Gets or sets the Ulcer.
        /// </summary>
        [DataMember]
        public Double Ulcer { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
