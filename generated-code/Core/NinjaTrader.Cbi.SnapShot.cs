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
        public string ChangeSetFilename { get; set; }
        /// <summary>
        /// Gets or sets the EntitledUser.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.User EntitledUser { get; set; }
        /// <summary>
        /// Gets or sets the SnapShotFilename.
        /// </summary>
        [DataMember]
        public string SnapShotFilename { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Apply method.
        /// </summary>
        /// <param name="snapShot">System.Xml.Linq.XDocument</param>
        /// <param name="persist">bool</param>
        /// <param name="updateVersion">bool</param>
        /// <returns>NinjaTrader.Cbi.ISnapShotSerializable[]</returns>
        public NinjaTrader.Cbi.ISnapShotSerializable[] Apply(System.Xml.Linq.XDocument snapShot, bool persist, bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetEntityType method.
        /// </summary>
        /// <param name="id">ApiCommand</param>
        /// <returns>NinjaTrader.Cbi.EntityType</returns>
        public NinjaTrader.Cbi.EntityType GetEntityType(ApiCommand id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetEntityType method.
        /// </summary>
        /// <param name="entityTpe">System.Type</param>
        /// <returns>NinjaTrader.Cbi.EntityType</returns>
        public NinjaTrader.Cbi.EntityType GetEntityType(System.Type entityTpe)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Make method.
        /// </summary>
        /// <param name="entities">System.Collections.Generic.ICollection<NinjaTrader.Cbi.ISnapShotSerializable></param>
        /// <returns>System.Xml.Linq.XDocument</returns>
        public System.Xml.Linq.XDocument Make(System.Collections.Generic.ICollection<NinjaTrader.Cbi.ISnapShotSerializable> entities)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
