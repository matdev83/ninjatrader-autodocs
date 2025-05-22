[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class UserLicense
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the EndDate.
        /// </summary>
        [DataMember]
        public System.DateTime EndDate { get; set; }
        /// <summary>
        /// Gets or sets the HasStaticSuperDom.
        /// </summary>
        [DataMember]
        public bool HasStaticSuperDom { get; set; }
        /// <summary>
        /// Gets or sets the IsLegacy.
        /// </summary>
        [DataMember]
        public bool IsLegacy { get; set; }
        /// <summary>
        /// Gets or sets the IsLifeTime.
        /// </summary>
        [DataMember]
        public bool IsLifeTime { get; set; }
        /// <summary>
        /// Gets or sets the LicenseCode.
        /// </summary>
        [DataMember]
        public string LicenseCode { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType.
        /// </summary>
        [DataMember]
        public string LicenseType { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyPrice.
        /// </summary>
        [DataMember]
        public double MonthlyPrice { get; set; }
        /// <summary>
        /// Gets or sets the PaymentPlan.
        /// </summary>
        [DataMember]
        public string PaymentPlan { get; set; }
        /// <summary>
        /// Gets or sets the PaymentType.
        /// </summary>
        [DataMember]
        public string PaymentType { get; set; }
        /// <summary>
        /// Gets or sets the PayPalId.
        /// </summary>
        [DataMember]
        public string PayPalId { get; set; }
        /// <summary>
        /// Gets or sets the Product.
        /// </summary>
        [DataMember]
        public string Product { get; set; }
        /// <summary>
        /// Gets or sets the PurchaseDate.
        /// </summary>
        [DataMember]
        public System.DateTime PurchaseDate { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public System.DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the Technology.
        /// </summary>
        [DataMember]
        public string Technology { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
