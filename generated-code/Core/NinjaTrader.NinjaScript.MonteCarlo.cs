[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class MonteCarlo
    {
        #region Properties
        /// <summary>
        /// Gets or sets the NumberOfSimulations.
        /// </summary>
        [DataMember]
        public Int32 NumberOfSimulations { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfTrades.
        /// </summary>
        [DataMember]
        public Int32 NumberOfTrades { get; set; }
        /// <summary>
        /// Gets or sets the RemoveLosingOutlierPercent.
        /// </summary>
        [DataMember]
        public Int32 RemoveLosingOutlierPercent { get; set; }
        /// <summary>
        /// Gets or sets the RemoveWinningOutlierPercent.
        /// </summary>
        [DataMember]
        public Int32 RemoveWinningOutlierPercent { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Run method.
        /// </summary>
        /// <param name="trades">ICollection`1</param>
        /// <param name="progress">IProgress</param>
        /// <returns>List`1</returns>
        public List<SystemPerformance> Run(ICollection<Trade> trades, IProgress progress);
        /// <summary>
        /// Run method.
        /// </summary>
        /// <param name="trades">ICollection`1</param>
        /// <param name="includeCommmision">Boolean</param>
        /// <param name="progress">IProgress</param>
        /// <returns>List`1</returns>
        [Obsolete]
        public List<SystemPerformance> Run(ICollection<Trade> trades, Boolean includeCommmision, IProgress progress);
        #endregion
    }
}
