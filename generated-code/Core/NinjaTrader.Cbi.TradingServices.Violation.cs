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
        public String Constraint { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public String Value { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
