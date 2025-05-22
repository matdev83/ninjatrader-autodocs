[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class EntityType
    {
        #region Properties
        /// <summary>
        /// Gets or sets the FromString.
        /// </summary>
        [DataMember]
        public System.Func<string, bool, bool, NinjaTrader.Cbi.ISnapShotSerializable> FromString { get; set; }
        /// <summary>
        /// Gets or sets the GetAll.
        /// </summary>
        [DataMember]
        public System.Func<bool?, string, string, System.Collections.Generic.ICollection<NinjaTrader.Cbi.ISnapShotSerializable>> GetAll { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public ApiCommand Id { get; set; }
        /// <summary>
        /// Gets or sets the IsEntitled.
        /// </summary>
        [DataMember]
        public System.Func<NinjaTrader.Cbi.User, bool, bool> IsEntitled { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public System.Type Type { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
