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
        public Func<String, Boolean, Boolean, ISnapShotSerializable> FromString { get; set; }
        /// <summary>
        /// Gets or sets the GetAll.
        /// </summary>
        [DataMember]
        public Func<Nullable<Boolean>, String, String, ICollection<ISnapShotSerializable>> GetAll { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public ApiCommand Id { get; set; }
        /// <summary>
        /// Gets or sets the IsEntitled.
        /// </summary>
        [DataMember]
        public Func<User, Boolean, Boolean> IsEntitled { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public Type Type { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
