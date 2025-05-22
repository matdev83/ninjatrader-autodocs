[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class OptimizationGraphValues
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AverageMae.
        /// </summary>
        [DataMember]
        public System.Double[] AverageMae { get; set; }
        /// <summary>
        /// Gets or sets the AverageMfe.
        /// </summary>
        [DataMember]
        public System.Double[] AverageMfe { get; set; }
        /// <summary>
        /// Gets or sets the AverageProfit.
        /// </summary>
        [DataMember]
        public System.Double[] AverageProfit { get; set; }
        /// <summary>
        /// Gets or sets the Drawdown.
        /// </summary>
        [DataMember]
        public System.Double[] Drawdown { get; set; }
        /// <summary>
        /// Gets or sets the GrossLoss.
        /// </summary>
        [DataMember]
        public double GrossLoss { get; set; }
        /// <summary>
        /// Gets or sets the GrossProfit.
        /// </summary>
        [DataMember]
        public double GrossProfit { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveLoser.
        /// </summary>
        [DataMember]
        public double MaxConsecutiveLoser { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveWinner.
        /// </summary>
        [DataMember]
        public double MaxConsecutiveWinner { get; set; }
        /// <summary>
        /// Gets or sets the NetProfit.
        /// </summary>
        [DataMember]
        public double NetProfit { get; set; }
        /// <summary>
        /// Gets or sets the ParameterValues.
        /// </summary>
        [DataMember]
        public System.Object[] ParameterValues { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceValue.
        /// </summary>
        [DataMember]
        public double PerformanceValue { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
