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
        public double AverageEtd { get; set; }
        /// <summary>
        /// Gets or sets the AverageMae.
        /// </summary>
        [DataMember]
        public double AverageMae { get; set; }
        /// <summary>
        /// Gets or sets the AverageMfe.
        /// </summary>
        [DataMember]
        public double AverageMfe { get; set; }
        /// <summary>
        /// Gets or sets the AverageProfit.
        /// </summary>
        [DataMember]
        public double AverageProfit { get; set; }
        /// <summary>
        /// Gets or sets the CumProfit.
        /// </summary>
        [DataMember]
        public double CumProfit { get; set; }
        /// <summary>
        /// Gets or sets the Drawdown.
        /// </summary>
        [DataMember]
        public double Drawdown { get; set; }
        /// <summary>
        /// Gets or sets the LargestLoser.
        /// </summary>
        [DataMember]
        public double LargestLoser { get; set; }
        /// <summary>
        /// Gets or sets the LargestWinner.
        /// </summary>
        [DataMember]
        public double LargestWinner { get; set; }
        /// <summary>
        /// Gets or sets the ProfitPerMonth.
        /// </summary>
        [DataMember]
        public double ProfitPerMonth { get; set; }
        /// <summary>
        /// Gets or sets the StdDev.
        /// </summary>
        [DataMember]
        public double StdDev { get; set; }
        /// <summary>
        /// Gets or sets the Turnaround.
        /// </summary>
        [DataMember]
        public double Turnaround { get; set; }
        /// <summary>
        /// Gets or sets the Ulcer.
        /// </summary>
        [DataMember]
        public double Ulcer { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
