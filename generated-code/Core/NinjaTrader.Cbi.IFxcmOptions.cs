namespace NinjaTrader.Cbi
{
    public partial interface IFxcmOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or sets the IsHdsEnabled.
        /// </summary>
        [DataMember]
        public bool IsHdsEnabled { get; set; }
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
        /// Gets or sets the PinCode.
        /// </summary>
        [DataMember]
        public string PinCode { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
