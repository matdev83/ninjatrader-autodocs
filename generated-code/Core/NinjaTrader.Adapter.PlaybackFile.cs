[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class PlaybackFile
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Filename.
        /// </summary>
        [DataMember]
        public String Filename { get; set; }
        /// <summary>
        /// Gets or sets the From.
        /// </summary>
        [DataMember]
        public DateTime From { get; set; }
        /// <summary>
        /// Gets or sets the To.
        /// </summary>
        [DataMember]
        public DateTime To { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
