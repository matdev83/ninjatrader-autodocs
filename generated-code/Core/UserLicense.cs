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
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the EndDate.
        /// </summary>
        [DataMember]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Gets or sets the HasStaticSuperDom.
        /// </summary>
        [DataMember]
        public Boolean HasStaticSuperDom { get; set; }
        /// <summary>
        /// Gets or sets the IsLegacy.
        /// </summary>
        [DataMember]
        public Boolean IsLegacy { get; set; }
        /// <summary>
        /// Gets or sets the IsLifeTime.
        /// </summary>
        [DataMember]
        public Boolean IsLifeTime { get; set; }
        /// <summary>
        /// Gets or sets the LicenseCode.
        /// </summary>
        [DataMember]
        public String LicenseCode { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType.
        /// </summary>
        [DataMember]
        public String LicenseType { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyPrice.
        /// </summary>
        [DataMember]
        public Double MonthlyPrice { get; set; }
        /// <summary>
        /// Gets or sets the PaymentPlan.
        /// </summary>
        [DataMember]
        public String PaymentPlan { get; set; }
        /// <summary>
        /// Gets or sets the PaymentType.
        /// </summary>
        [DataMember]
        public String PaymentType { get; set; }
        /// <summary>
        /// Gets or sets the PayPalId.
        /// </summary>
        [DataMember]
        public String PayPalId { get; set; }
        /// <summary>
        /// Gets or sets the Product.
        /// </summary>
        [DataMember]
        public String Product { get; set; }
        /// <summary>
        /// Gets or sets the PurchaseDate.
        /// </summary>
        [DataMember]
        public DateTime PurchaseDate { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the Technology.
        /// </summary>
        [DataMember]
        public String Technology { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
