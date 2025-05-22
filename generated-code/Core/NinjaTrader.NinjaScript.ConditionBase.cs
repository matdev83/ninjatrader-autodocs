[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ConditionBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LeftItem.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.ConditionItem LeftItem { get; set; }
        /// <summary>
        /// Gets or sets the Lookback.
        /// </summary>
        [DataMember]
        public int Lookback { get; set; }
        /// <summary>
        /// Gets or sets the Operator.
        /// </summary>
        [DataMember]
        public Condition Operator { get; set; }
        /// <summary>
        /// Gets or sets the RightItem.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.ConditionItem RightItem { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.ConditionBase</param>
        public void CopyTo(NinjaTrader.NinjaScript.ConditionBase other)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
