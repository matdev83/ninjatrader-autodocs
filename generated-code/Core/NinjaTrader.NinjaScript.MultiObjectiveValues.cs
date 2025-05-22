[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class MultiObjectiveValues
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ParameterValues.
        /// </summary>
        [DataMember]
        public System.Object[] ParameterValues { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceValues.
        /// </summary>
        [DataMember]
        public System.Double[] PerformanceValues { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
