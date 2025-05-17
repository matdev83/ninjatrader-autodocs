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
        public Double[] AverageMae { get; set; }
        /// <summary>
        /// Gets or sets the AverageMfe.
        /// </summary>
        [DataMember]
        public Double[] AverageMfe { get; set; }
        /// <summary>
        /// Gets or sets the AverageProfit.
        /// </summary>
        [DataMember]
        public Double[] AverageProfit { get; set; }
        /// <summary>
        /// Gets or sets the Drawdown.
        /// </summary>
        [DataMember]
        public Double[] Drawdown { get; set; }
        /// <summary>
        /// Gets or sets the GrossLoss.
        /// </summary>
        [DataMember]
        public Double GrossLoss { get; set; }
        /// <summary>
        /// Gets or sets the GrossProfit.
        /// </summary>
        [DataMember]
        public Double GrossProfit { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveLoser.
        /// </summary>
        [DataMember]
        public Double MaxConsecutiveLoser { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveWinner.
        /// </summary>
        [DataMember]
        public Double MaxConsecutiveWinner { get; set; }
        /// <summary>
        /// Gets or sets the NetProfit.
        /// </summary>
        [DataMember]
        public Double NetProfit { get; set; }
        /// <summary>
        /// Gets or sets the ParameterValues.
        /// </summary>
        [DataMember]
        public Object[] ParameterValues { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceValue.
        /// </summary>
        [DataMember]
        public Double PerformanceValue { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
