[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ConnectionDemoModeReadonlyDescriptor : ConnectionDemoModeDescriptor
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsReadOnly.
        /// </summary>
        [DataMember]
        public Boolean IsReadOnly { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
