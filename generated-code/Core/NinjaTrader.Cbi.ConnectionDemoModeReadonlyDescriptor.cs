[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ConnectionDemoModeReadonlyDescriptor : NinjaTrader.Cbi.ConnectionDemoModeDescriptor
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsReadOnly.
        /// </summary>
        [DataMember]
        public bool IsReadOnly { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
