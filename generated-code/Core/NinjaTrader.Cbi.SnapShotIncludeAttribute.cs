[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SnapShotIncludeAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsIncluded.
        /// </summary>
        [DataMember]
        public bool IsIncluded { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
