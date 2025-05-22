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
        public double ApiRateMultiplier { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Check method.
        /// </summary>
        /// <param name="d">NinjaTrader.Core.Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="errorCallback">System.Action<string></param>
        /// <returns>bool</returns>
        public bool Check(NinjaTrader.Core.Deserializer d, ApiCommand cmd, System.Action<string> errorCallback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reset method.
        /// </summary>
        public void Reset()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
