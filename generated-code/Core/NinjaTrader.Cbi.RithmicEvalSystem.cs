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
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public int Order { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection.
        /// </summary>
        [DataMember]
        public RithmicConnection RithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the AdmPoint.
        /// </summary>
        [DataMember]
        public string AdmPoint { get; set; }
        /// <summary>
        /// Gets or sets the AdmPointSerialize.
        /// </summary>
        [DataMember]
        public string AdmPointSerialize { get; set; }
        /// <summary>
        /// Gets or sets the BrokerServerAddress.
        /// </summary>
        [DataMember]
        public string BrokerServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the BrokerServerAddressSerialize.
        /// </summary>
        [DataMember]
        public string BrokerServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DomainName.
        /// </summary>
        [DataMember]
        public string DomainName { get; set; }
        /// <summary>
        /// Gets or sets the DomainNameSerialize.
        /// </summary>
        [DataMember]
        public string DomainNameSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DomainServerAddress.
        /// </summary>
        [DataMember]
        public string DomainServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the DomainServerAddressSerialize.
        /// </summary>
        [DataMember]
        public string DomainServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the LicenseServerAddress.
        /// </summary>
        [DataMember]
        public string LicenseServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the LicenseServerAddressSerialize.
        /// </summary>
        [DataMember]
        public string LicenseServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the LoggerServerAddress.
        /// </summary>
        [DataMember]
        public string LoggerServerAddress { get; set; }
        /// <summary>
        /// Gets or sets the LoggerServerAddressSerialize.
        /// </summary>
        [DataMember]
        public string LoggerServerAddressSerialize { get; set; }
        /// <summary>
        /// Gets or sets the MdPoint.
        /// </summary>
        [DataMember]
        public string MdPoint { get; set; }
        /// <summary>
        /// Gets or sets the MdPointSerialize.
        /// </summary>
        [DataMember]
        public string MdPointSerialize { get; set; }
        /// <summary>
        /// Gets or sets the PnlPoint.
        /// </summary>
        [DataMember]
        public string PnlPoint { get; set; }
        /// <summary>
        /// Gets or sets the PnlPointSerialize.
        /// </summary>
        [DataMember]
        public string PnlPointSerialize { get; set; }
        /// <summary>
        /// Gets or sets the TsPoint.
        /// </summary>
        [DataMember]
        public string TsPoint { get; set; }
        /// <summary>
        /// Gets or sets the TsPointSerialize.
        /// </summary>
        [DataMember]
        public string TsPointSerialize { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
