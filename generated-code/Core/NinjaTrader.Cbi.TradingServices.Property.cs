[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Property
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PropertyType.
        /// </summary>
        [DataMember]
        public string PropertyType { get; set; }
        /// <summary>
        /// Gets or sets the EnumOptions.
        /// </summary>
        [DataMember]
        public string EnumOptions { get; set; }
        /// <summary>
        /// Gets or sets the DefaultValue.
        /// </summary>
        [DataMember]
        public string DefaultValue { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
