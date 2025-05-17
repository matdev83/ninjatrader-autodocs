namespace NinjaTrader.Cbi
{
    public partial interface IRithmicOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public String BrandName { get; set; }
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
        /// Gets or sets the RithmicConnection.
        /// </summary>
        [DataMember]
        public RithmicConnection RithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the UsePluginData.
        /// </summary>
        [DataMember]
        public Boolean UsePluginData { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public String User { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
