[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class RithmicEvalSystem
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Int32 Order { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection.
        /// </summary>
        [DataMember]
        public RithmicConnection RithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the AdmPoint.
        /// </summary>
        [DataMember]
        public String AdmPoint { get; set; }
        /// <summary>
        /// Gets or sets the AdmPointSerialize.
        /// </summary>
        [DataMember]
        public String AdmPointSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BrokerServerAddress.
        /// </summary>
        [DataMember]
        public String BrokerServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the BrokerServerAddressSerialize.
        /// </summary>
        [DataMember]
        public String BrokerServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DomainName.
        /// </summary>
        [DataMember]
        public String DomainName { get; set; }
        /// <summary>
        /// Gets or sets the DomainNameSerialize.
        /// </summary>
        [DataMember]
        public String DomainNameSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DomainServerAddress.
        /// </summary>
        [DataMember]
        public String DomainServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the DomainServerAddressSerialize.
        /// </summary>
        [DataMember]
        public String DomainServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the LicenseServerAddress.
        /// </summary>
        [DataMember]
        public String LicenseServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the LicenseServerAddressSerialize.
        /// </summary>
        [DataMember]
        public String LicenseServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the LoggerServerAddress.
        /// </summary>
        [DataMember]
        public String LoggerServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the LoggerServerAddressSerialize.
        /// </summary>
        [DataMember]
        public String LoggerServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the MdPoint.
        /// </summary>
        [DataMember]
        public String MdPoint { get; set; }
        /// <summary>
        /// Gets or sets the MdPointSerialize.
        /// </summary>
        [DataMember]
        public String MdPointSerialize { get; set; }
        /// <summary>
        /// Gets or sets the PnlPoint.
        /// </summary>
        [DataMember]
        public String PnlPoint { get; set; }
        /// <summary>
        /// Gets or sets the PnlPointSerialize.
        /// </summary>
        [DataMember]
        public String PnlPointSerialize { get; set; }
        /// <summary>
        /// Gets or sets the TsPoint.
        /// </summary>
        [DataMember]
        public String TsPoint { get; set; }
        /// <summary>
        /// Gets or sets the TsPointSerialize.
        /// </summary>
        [DataMember]
        public String TsPointSerialize { get; set; }
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
