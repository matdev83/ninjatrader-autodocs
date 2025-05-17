[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class HandshakeRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public Int32 Version { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
