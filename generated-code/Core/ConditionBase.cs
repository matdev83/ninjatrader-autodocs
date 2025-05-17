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
        public ConditionItem LeftItem { get; set; }
        /// <summary>
        /// Gets or sets the Lookback.
        /// </summary>
        [DataMember]
        public Int32 Lookback { get; set; }
        /// <summary>
        /// Gets or sets the Operator.
        /// </summary>
        [DataMember]
        public Condition Operator { get; set; }
        /// <summary>
        /// Gets or sets the RightItem.
        /// </summary>
        [DataMember]
        public ConditionItem RightItem { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">ConditionBase</param>
        public Void CopyTo(ConditionBase other);
        #endregion
    }
}
