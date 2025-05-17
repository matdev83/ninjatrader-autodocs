[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class UserPlugin
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Approval.
        /// </summary>
        [DataMember]
        public Boolean Approval { get; set; }
        /// <summary>
        /// Gets or sets the Archived.
        /// </summary>
        [DataMember]
        public Boolean Archived { get; set; }
        /// <summary>
        /// Gets or sets the Autorenewal.
        /// </summary>
        [DataMember]
        public Boolean Autorenewal { get; set; }
        /// <summary>
        /// Gets or sets the CashBalanceLogId.
        /// </summary>
        [DataMember]
        public Int64 CashBalanceLogId { get; set; }
        /// <summary>
        /// Gets or sets the CreditCardId.
        /// </summary>
        [DataMember]
        public Int64 CreditCardId { get; set; }
        /// <summary>
        /// Gets or sets the CreditCardTransactionId.
        /// </summary>
        [DataMember]
        public Int64 CreditCardTransactionId { get; set; }
        /// <summary>
        /// Gets or sets the EntitlementId.
        /// </summary>
        [DataMember]
        public Int64 EntitlementId { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationTradeDate.
        /// </summary>
        [DataMember]
        public TradeDate ExpirationTradeDate { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the PaidAmount.
        /// </summary>
        [DataMember]
        public Double PaidAmount { get; set; }
        /// <summary>
        /// Gets or sets the PlanCategories.
        /// </summary>
        [DataMember]
        public String PlanCategories { get; set; }
        /// <summary>
        /// Gets or sets the PlanPrice.
        /// </summary>
        [DataMember]
        public Double PlanPrice { get; set; }
        /// <summary>
        /// Gets or sets the PluginName.
        /// </summary>
        [DataMember]
        public String PluginName { get; set; }
        /// <summary>
        /// Gets or sets the StartTradeDate.
        /// </summary>
        [DataMember]
        public TradeDate StartTradeDate { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationDate.
        /// </summary>
        [DataMember]
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
