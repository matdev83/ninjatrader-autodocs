[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Adapters
{
    public partial class AdapterBase : NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
