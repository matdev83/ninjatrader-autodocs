[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class SoundEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SoundType.
        /// </summary>
        [DataMember]
        public SoundType SoundType { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
