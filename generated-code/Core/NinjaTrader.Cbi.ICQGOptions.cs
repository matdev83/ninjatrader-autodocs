namespace NinjaTrader.Cbi
{
    public partial interface ICQGOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or sets the Fcms.
        /// </summary>
        [DataMember]
        public System.String[] Fcms { get; set; }
        /// <summary>
        /// Gets or sets the IncludeFx.
        /// </summary>
        [DataMember]
        public bool IncludeFx { get; set; }
        /// <summary>
        /// Gets or sets the Mode.
        /// </summary>
        [DataMember]
        public Mode Mode { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public Provider Provider { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public bool UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public string User { get; set; }
        /// <summary>
        /// Gets or sets the UseWebApi.
        /// </summary>
        [DataMember]
        public bool UseWebApi { get; set; }
        /// <summary>
        /// Gets or sets the UseHistoricalTickData.
        /// </summary>
        [DataMember]
        public bool UseHistoricalTickData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
