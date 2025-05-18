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
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the PropertyType.
        /// </summary>
        [DataMember]
        public String PropertyType { get; set; }
        /// <summary>
        /// Gets or sets the EnumOptions.
        /// </summary>
        [DataMember]
        public String EnumOptions { get; set; }
        /// <summary>
        /// Gets or sets the DefaultValue.
        /// </summary>
        [DataMember]
        public String DefaultValue { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
