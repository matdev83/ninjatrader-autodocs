[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class TradovateSubscription
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the CancelReason.
        /// </summary>
        [DataMember]
        public string CancelReason { get; set; }
        /// <summary>
        /// Gets or sets the CancelledRenewal.
        /// </summary>
        [DataMember]
        public bool CancelledRenewal { get; set; }
        /// <summary>
        /// Gets or sets the CashBalanceLogId.
        /// </summary>
        [DataMember]
        public long CashBalanceLogId { get; set; }
        /// <summary>
        /// Gets or sets the CreditCardId.
        /// </summary>
        [DataMember]
        public long CreditCardId { get; set; }
        /// <summary>
        /// Gets or sets the CreditCardTransactionId.
        /// </summary>
        [DataMember]
        public long CreditCardTransactionId { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationTradeDate.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.TradeDate ExpirationTradeDate { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the PaidAmount.
        /// </summary>
        [DataMember]
        public double PaidAmount { get; set; }
        /// <summary>
        /// Gets or sets the PlanPrice.
        /// </summary>
        [DataMember]
        public double PlanPrice { get; set; }
        /// <summary>
        /// Gets or sets the StartTradeDate.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.TradeDate StartTradeDate { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradovateSubscriptionPlanId.
        /// </summary>
        [DataMember]
        public long TradovateSubscriptionPlanId { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationDate.
        /// </summary>
        [DataMember]
        public System.DateTime ExpirationDate { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public System.DateTime StartDate { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
