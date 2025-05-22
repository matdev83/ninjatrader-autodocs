[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TTOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public string Accounts { get; set; }
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public string AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public string Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the OrdersHostName.
        /// </summary>
        [DataMember]
        public string OrdersHostName { get; set; }
        /// <summary>
        /// Gets or sets the OrdersPassword.
        /// </summary>
        [DataMember]
        public string OrdersPassword { get; set; }
        /// <summary>
        /// Gets or sets the OrdersPort.
        /// </summary>
        [DataMember]
        public int OrdersPort { get; set; }
        /// <summary>
        /// Gets or sets the OrdersSenderId.
        /// </summary>
        [DataMember]
        public string OrdersSenderId { get; set; }
        /// <summary>
        /// Gets or sets the OrdersTargetId.
        /// </summary>
        [DataMember]
        public string OrdersTargetId { get; set; }
        /// <summary>
        /// Gets or sets the PriceHostName.
        /// </summary>
        [DataMember]
        public string PriceHostName { get; set; }
        /// <summary>
        /// Gets or sets the PricePassword.
        /// </summary>
        [DataMember]
        public string PricePassword { get; set; }
        /// <summary>
        /// Gets or sets the PricePort.
        /// </summary>
        [DataMember]
        public int PricePort { get; set; }
        /// <summary>
        /// Gets or sets the PriceSenderId.
        /// </summary>
        [DataMember]
        public string PriceSenderId { get; set; }
        /// <summary>
        /// Gets or sets the PriceTargetId.
        /// </summary>
        [DataMember]
        public string PriceTargetId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
