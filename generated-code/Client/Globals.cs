[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class Globals
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ProductName.
        /// </summary>
        [DataMember]
        public String ProductName { get; set; }
        /// <summary>
        /// Gets or sets the DataFolderName.
        /// </summary>
        [DataMember]
        public String DataFolderName { get; set; }
        /// <summary>
        /// Gets or sets the UserDataDir.
        /// </summary>
        [DataMember]
        public String UserDataDir { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
