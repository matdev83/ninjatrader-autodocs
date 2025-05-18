[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SnapShot
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ChangeSetFilename.
        /// </summary>
        [DataMember]
        public String ChangeSetFilename { get; set; }
        /// <summary>
        /// Gets or sets the EntitledUser.
        /// </summary>
        [DataMember]
        public User EntitledUser { get; set; }
        /// <summary>
        /// Gets or sets the SnapShotFilename.
        /// </summary>
        [DataMember]
        public String SnapShotFilename { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Apply method.
        /// </summary>
        /// <param name="snapShot">XDocument</param>
        /// <param name="persist">Boolean</param>
        /// <param name="updateVersion">Boolean</param>
        /// <returns>ISnapShotSerializable[]</returns>
        public ISnapShotSerializable[] Apply(XDocument snapShot, Boolean persist, Boolean updateVersion);
        /// <summary>
        /// GetEntityType method.
        /// </summary>
        /// <param name="id">ApiCommand</param>
        /// <returns>EntityType</returns>
        public EntityType GetEntityType(ApiCommand id);
        /// <summary>
        /// GetEntityType method.
        /// </summary>
        /// <param name="entityTpe">Type</param>
        /// <returns>EntityType</returns>
        public EntityType GetEntityType(Type entityTpe);
        /// <summary>
        /// Make method.
        /// </summary>
        /// <param name="entities">ICollection`1</param>
        /// <returns>XDocument</returns>
        public XDocument Make(ICollection<ISnapShotSerializable> entities);
        #endregion
    }
}
