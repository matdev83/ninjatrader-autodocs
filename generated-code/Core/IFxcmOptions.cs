namespace NinjaTrader.Cbi
{
    public partial interface IFxcmOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public String BrandName { get; set; }
        /// <summary>
        /// Gets or sets the IsHdsEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsHdsEnabled { get; set; }
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
        /// Gets or sets the PinCode.
        /// </summary>
        [DataMember]
        public String PinCode { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
