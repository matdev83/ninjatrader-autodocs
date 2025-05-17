namespace NinjaTrader.Cbi
{
    public partial interface ICQGOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public String BrandName { get; set; }
        /// <summary>
        /// Gets or sets the Fcms.
        /// </summary>
        [DataMember]
        public String[] Fcms { get; set; }
        /// <summary>
        /// Gets or sets the IncludeFx.
        /// </summary>
        [DataMember]
        public Boolean IncludeFx { get; set; }
        /// <summary>
        /// Gets or sets the Mode.
        /// </summary>
        [DataMember]
        public Mode Mode { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public String Password { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public Provider Provider { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public Boolean UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public String User { get; set; }
        /// <summary>
        /// Gets or sets the UseWebApi.
        /// </summary>
        [DataMember]
        public Boolean UseWebApi { get; set; }
        /// <summary>
        /// Gets or sets the UseHistoricalTickData.
        /// </summary>
        [DataMember]
        public Boolean UseHistoricalTickData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
