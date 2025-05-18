[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class ApiPacing
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApiRateMultiplier.
        /// </summary>
        [DataMember]
        public Double ApiRateMultiplier { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Check method.
        /// </summary>
        /// <param name="d">Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="errorCallback">Action`1</param>
        /// <returns>Boolean</returns>
        public Boolean Check(Deserializer d, ApiCommand cmd, Action<String> errorCallback);
        /// <summary>
        /// Reset method.
        /// </summary>
        public Void Reset();
        #endregion
    }
}
