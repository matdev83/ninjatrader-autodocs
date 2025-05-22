[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Violation
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Constraint.
        /// </summary>
        [DataMember]
        public string Constraint { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public string Value { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
