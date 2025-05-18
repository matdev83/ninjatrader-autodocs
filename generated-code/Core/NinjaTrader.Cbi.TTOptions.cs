[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TTOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public String Accounts { get; set; }
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public String AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public String BrandName { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public String Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the OrdersHostName.
        /// </summary>
        [DataMember]
        public String OrdersHostName { get; set; }
        /// <summary>
        /// Gets or sets the OrdersPassword.
        /// </summary>
        [DataMember]
        public String OrdersPassword { get; set; }
        /// <summary>
        /// Gets or sets the OrdersPort.
        /// </summary>
        [DataMember]
        public Int32 OrdersPort { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSenderId.
        /// </summary>
        [DataMember]
        public String OrdersSenderId { get; set; }
        /// <summary>
        /// Gets or sets the OrdersTargetId.
        /// </summary>
        [DataMember]
        public String OrdersTargetId { get; set; }
        /// <summary>
        /// Gets or sets the PriceHostName.
        /// </summary>
        [DataMember]
        public String PriceHostName { get; set; }
        /// <summary>
        /// Gets or sets the PricePassword.
        /// </summary>
        [DataMember]
        public String PricePassword { get; set; }
        /// <summary>
        /// Gets or sets the PricePort.
        /// </summary>
        [DataMember]
        public Int32 PricePort { get; set; }
        /// <summary>
        /// Gets or sets the PriceSenderId.
        /// </summary>
        [DataMember]
        public String PriceSenderId { get; set; }
        /// <summary>
        /// Gets or sets the PriceTargetId.
        /// </summary>
        [DataMember]
        public String PriceTargetId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
