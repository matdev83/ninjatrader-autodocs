[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SnapShotIncludeAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsIncluded.
        /// </summary>
        [DataMember]
        public Boolean IsIncluded { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
