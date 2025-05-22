namespace NinjaTrader.Cbi
{
    public partial interface IRithmicOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public string BrandName { get; set; }
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
        /// Gets or sets the RithmicConnection.
        /// </summary>
        [DataMember]
        public RithmicConnection RithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the UsePluginData.
        /// </summary>
        [DataMember]
        public bool UsePluginData { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public string User { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
